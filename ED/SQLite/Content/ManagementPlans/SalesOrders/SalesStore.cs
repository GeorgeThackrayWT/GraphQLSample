using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using MvvmHelpers;
using SQLite.Net;
using Stores;
using Utils;

namespace SQLite
{
    public class SalesStore : BaseStore, ISalesStore
    {
        public SalesStore(IDBPlatformSettings platform, ISQLiteCache iCache, IUserStore iUserStore)
        {
            _platform = platform;

            _iCache = iCache;

            _iUserStore = iUserStore;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }
        
        public List<IncomeDto> GetIncomes()
        {
            List<IncomeDto> idata = _sqLiteSyncConnection.Query<IncomeDto>("SELECT ManagementUnitID, EndDate, Forecast, Budget, Actual, Project, PE, Completed, ClmdInvd, TaxCodeID FROM Income where Deleted =0 and Cancelled = 0").ToList();

            return idata;
        }

        public List<SalesOrdersListDTO> GetSalesOrdersListDtos(OrdersSelectionCriterion ordersCriterionArg)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetSalesOrdersListDtos started");

            OrdersSelectionCriterion ordersCriterion = ordersCriterionArg;
            var workOrders = _sqLiteSyncConnection.Table<WorkOrder>().ToList();

            var incomeProducts = _sqLiteSyncConnection.Table<IncomeProduct>().ToList();

            var configuration = _sqLiteSyncConnection.Table<Configuration>().ToList();
            int year = 2017;

            if (configuration != null && configuration.Count > 0)
            {
                year = configuration[0].CurrentYear.Year;
            }

            TimeRange currentYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));

            year++;
            TimeRange nextYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));

            currentYearRange.MaxDate = currentYearRange.MaxDate.AddDays(1);
            nextYearRange.MaxDate = nextYearRange.MaxDate.AddDays(1);

            // var data = _sqLiteSyncConnection.Table<Income>().ToList();

            IQueryable<Income> query = _sqLiteSyncConnection.Table<Income>().AsQueryable();

            var retList = new List<SalesOrdersListDTO>();

            switch (ordersCriterion)
            {
                case OrdersSelectionCriterion.CurrentYear:
                    query = query.Where(i => i.Deleted == false && i.Cancelled == false && i.IsProtected == false && (i.SONo == null || i.SONo == string.Empty))
                        .Where(e => e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.NextYear:
                    query = query.Where(i => i.Deleted == false && i.Cancelled == false && i.IsProtected == false && (i.SONo == null || i.SONo == string.Empty))
                        .Where(e => e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.AllYears:
                    query = query.Where(i => i.Deleted == false && i.Cancelled == false && i.IsProtected == false && (i.SONo == null || i.SONo == string.Empty));
                    break;

            }

            foreach (var e in query.Where(p => (p.Forecast != null && p.Forecast != 0.0)))
            {

                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == e.ManagementUnitID);


                var faq =
                    _iCache.AcquisitionUnits.Where(p => p.ManagementUnitID == manu.Id)
                        .OrderBy(a => a.ID)
                        .FirstOrDefault();

                var worder = workOrders.FirstOrDefault(f => f.ID == e.WorkOrderID);

                if (faq.LeaseEndDate == null || faq.LeaseEndDate <= e.EndDate)
                {
                    var pol = new SalesOrdersListDTO()
                    {
                        CostCentre = e.ManagementUnitID,
                        Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                        ManagementUnitID = e.ManagementUnitID,
                        EndDate = e.EndDate.Validate(),
                        StartDate = e.StartDate.Validate(),
                        ForecastAmount = e.Forecast.GetValueOrDefault(),
                        LastAmendedBy = _iCache.UserLookup[e.LMUID.GetValueOrDefault()],
                        LastAmendedDate = e.LMDT.Validate(),
                        Product = incomeProducts.First(f => f.ID == e.ProductID).Description,
                        WorkOrder = worder.Description,
                    };

                    retList.Add(pol);
                }
            }

            stopwatch.Stop();

            Debug.WriteLine("GetSalesOrdersListDtos ended in: " + stopwatch.ElapsedMilliseconds);

            return retList;
        }
        
        public List<IncomeDto> GetWpIncomes(int managementUnitId)
        {
            var result = new List<IncomeDto>();

            var sqlStr = "SELECT i.Id,i.ManagementUnitID as ManagementUnitId ,i.Project ,i.WorkOrderID ,i.ProductID ,i.AimID ,i.Notes ,i.StartDate ," +
                         "i.EndDate ,i.ActualDate ,i.Budget ,i.ClmdInvd ,i.Forecast ,i.LastMonthForecast ,i.Actual ,i.NetIncome ,i.Received ,i.GrantScheme ," +
                         "i.GrantReference ,i.PE ,i.Pipeline ,i.SONo AS SoNo,i.SODate ,i.OrderID ,i.TaxCodeID ,i.GrantID ,i.Confidential ,i.Completed ," +
                         "i.Cancelled ,i.NoSync ,i.WoodProduction ,i.Deleted ,i.IsProtected ,i.IsHistorical ,i.IsDefaultValue ,i.LMDT ,i.LMUID ,i.ULMDT ," +
                         "i.ULMUID ,i.CRDT ,i.CRUID ,i.DLDT ,i.DLUID ,"+
                        "wo.[Description] as WorkOrderDescription, ip.Description AS Product,0 AS Remaining, Notes as [Description] "+
                        "FROM Income i join IncomeProduct ip on i.ProductID = ip.ID join WorkOrder wo on i.WorkOrderID = wo.ID " +
                        "WHERE i.Deleted = 0 AND i.ManagementUnitID =" + managementUnitId;

            Debug.WriteLine(sqlStr);

            var edata = _sqLiteSyncConnection.Query<IncomeDto>(sqlStr).ToList();


            return edata;
        }
        
        public WPSummaryDTO GetWpIncomesSummaryMySites(int managementUnitId)
        {
            var sqlStr = "SELECT i.ID,i.ManagementUnitID,wo.[Description] as WorkOrder, ip.Description AS Product, i.StartDate, i.EndDate, i.Budget, i.Forecast, i.Actual, 0 AS Remaining, SONo, Received, Completed, Notes as [Description] FROM Income i join IncomeProduct ip on i.ProductID = ip.ID join WorkOrder wo on i.WorkOrderID = wo.ID " +
                         "WHERE i.Deleted = 0 AND i.ManagementUnitID =" + managementUnitId;

            var edata = _sqLiteSyncConnection.Query<IncomeDto>(sqlStr).ToList();

            var summaryObject = new WPSummaryDTO()
            {
                Budget = edata.Sum(p => p.Budget),
                Forecast = edata.Sum(p => p.Forecast),
                Actual = edata.Sum(p => p.Actual),
                Remaining = edata.Sum(p => p.Remaining)
            };

            return summaryObject;
        }
        
        public List<IncomeDto> GetIncomes(int managementUnitId)
        {
            //var magicString = @"SELECT ID,ManagementUnitID,Project,WorkOrderID,ProductID,AimID,Notes,StartDate,EndDate,ActualDate,Budget,
            //                    ClmdInvd,Forecast,LastMonthForecast,Actual,NetIncome,Received,GrantScheme,GrantReference,PE,Pipeline,SONo AS SoNo,
            //                    SODate,OrderID,TaxCodeID,GrantID,Confidential,Completed 
            //                    FROM Income WHERE Deleted =0 AND ManagementUnitID = " + managementUnitId;

        

            var data = _sqLiteSyncConnection.Table<Income>().Where(p=>p.ManagementUnitID == managementUnitId && p.Deleted ==false).ToList();

         

            List<IncomeDto> incomeCollectionEditDto = new List<IncomeDto>();


            foreach (var inc in data)
            {
                
                

                incomeCollectionEditDto.Add(new IncomeDto()
                {
                    Id= inc.ID,
                    Description = inc.Notes,
                    StartDate= inc.StartDate,
                    Actual= inc.Actual.GetValueOrDefault(),
                    EndDate= inc.EndDate,
                    ProductId= inc.ProductID,
                    Completed= inc.Completed,
                    ClmdInvd= inc.ClmdInvd.GetValueOrDefault(),
                    Confidential= inc.Confidential,
                    AimId= inc.AimID,
                    Pe= inc.PE,
                    SoDate= inc.SODate,
                    BudgetNet= inc.Budget,
                    BudgetNetTotal= inc.Budget,
                    ForecastNet= inc.Forecast.GetValueOrDefault(),
                    ForecastNetTotal= inc.Forecast.GetValueOrDefault(),
                    GrantSchemeId= inc.GrantID.GetValueOrDefault(),
                    GrantSchemeDescription= inc.GrantReference,
                    IsProject= inc.Project,
                    NoAgressoUpdate= inc.NoSync,
                    Pipeline= inc.Pipeline,
                    Received= inc.Received.GetValueOrDefault(),
                    SoNo= inc.SONo,
                    WorkOrder = inc.WorkOrderID,
                    TaskCodeId = inc.TaxCodeID.GetValueOrDefault()
                   
                });
            }

            return incomeCollectionEditDto;
        }
        
        public void UpdateIncomes(List<IncomeDto> editSet, int managementId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = _sqLiteSyncConnection.Table<Income>().Where(i => i.ManagementUnitID == managementId && !i.Deleted).ToList();

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingData.Select(i => i.ID).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.ID) select existingRecord.ID).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();


            foreach (var existingIncome in existingData)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == existingIncome.ID);

                if (matchedRecord != null)
                {
                    existingIncome.ID = matchedRecord.Id;
                    existingIncome.StartDate = matchedRecord.StartDate.GetValueOrDefault();
                    existingIncome.EndDate = matchedRecord.EndDate.GetValueOrDefault();
                    existingIncome.ProductID = matchedRecord.ProductId;
                    existingIncome.AimID = matchedRecord.AimId;
                    existingIncome.ClmdInvd = matchedRecord.ClmdInvd;
                    existingIncome.Actual = matchedRecord.Actual;
                    existingIncome.SONo = matchedRecord.SoNo;
                    existingIncome.SODate = matchedRecord.SoDate;
                    existingIncome.Received = matchedRecord.Received;
                    existingIncome.Completed = matchedRecord.Completed;
                    existingIncome.PE = matchedRecord.Pe;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.Confidential = matchedRecord.Confidential;
                    existingIncome.Notes = matchedRecord.Description;
                    existingIncome.GrantID = matchedRecord.GrantSchemeId;
                    existingIncome.GrantReference = matchedRecord.GrantSchemeDescription;
                    existingIncome.TaxCodeID = matchedRecord.TaskCodeId;
                    existingIncome.WorkOrderID = matchedRecord.WorkOrder;
                    existingIncome.Budget = matchedRecord.BudgetNet;
                    existingIncome.Forecast = matchedRecord.ForecastNet;


                    existingIncome.LMDT = matchedRecord.LMDT;
                    existingIncome.LMUID = currentUserId;
                    existingIncome.CRDT = matchedRecord.CRDT;
                    existingIncome.CRUID = currentUserId;
                    existingIncome.DLDT = matchedRecord.DLDT;
                    existingIncome.DLUID = currentUserId;
                    existingIncome.ULMDT = matchedRecord.ULMDT;
                    existingIncome.ULMUID = currentUserId;
                }

                if (deletedRecords.Any(f => f == existingIncome.ID))
                {
                    existingIncome.Deleted = true;
                }
            }


            _sqLiteSyncConnection.UpdateAll(existingData);



            var recordsToAdd = new List<Income>();


            var latestRecord = _sqLiteSyncConnection.Table<Income>().OrderByDescending(i => i.ID).FirstOrDefault();

            int id = 0;

            if (latestRecord != null)
            {
                id = latestRecord.ID;
            }

            foreach (var nr in newRecords)
            {
                var newRecord = new Income()
                {
                    ID = id++,
                    WorkOrderID = nr.WorkOrder,
                    Actual = nr.Actual,
                    GrantID = nr.GrantSchemeId,
                    ManagementUnitID = managementId,
                    Deleted = false,
                    TaxCodeID = nr.TaskCodeId,
                    Forecast = nr.ForecastNet,
                    GrantReference = nr.GrantSchemeDescription,
                    Budget = nr.BudgetNet,
                    Notes = nr.Description,
                    ActualDate = DateTime.Today,
                    AimID = nr.AimId,           
                    Cancelled = false,
                    ClmdInvd = nr.ClmdInvd,
                    Completed = nr.Completed,
                    Confidential = nr.Confidential,                 
                    EndDate = nr.EndDate.GetValueOrDefault(),
                    GrantScheme = nr.GrantSchemeDescription,
                    IsDefaultValue = false,
                    IsHistorical = false,
                    IsProtected = false,       
                    LastMonthForecast = 0.0,
                    NetIncome = 0.0,
                    NoSync = false,
                    OrderID = nr.WorkOrder,
                    PE = nr.Pe,
                    Pipeline = nr.Pipeline,
                    ProductID = nr.ProductId,
                    Project = nr.IsProject,
                    Received = nr.Received,
                    SODate = nr.SoDate.GetValueOrDefault(),
                    SONo = nr.SoNo,
                    StartDate = nr.StartDate.GetValueOrDefault(),


                    LMDT = DateTime.Today,
                    LMUID = currentUserId,
                    CRDT = DateTime.Today,
                    CRUID = currentUserId,
                    DLDT = DateTime.Today,
                    DLUID = currentUserId,
                    ULMDT = DateTime.Today,
                    ULMUID = currentUserId

                };

                recordsToAdd.Add(newRecord);
            }

            if(recordsToAdd.Count>0)
                _sqLiteSyncConnection.InsertAll(recordsToAdd);

        }

        public List<SalesOrdersListDTO> GetSalesOrdersListDtos(OrdersSelectionCriterion ordersCriterionarg, int userRole, int application, int regionId)
        {
            throw new NotImplementedException();
        }

        public List<SalesOrdersListDTO> GetSalesOrdersListDtos(OrdersSelectionCriterion ordersCriterionarg, List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }
}