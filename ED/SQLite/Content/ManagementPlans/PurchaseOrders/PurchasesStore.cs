using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using EDCORE.ViewModel;
using MvvmHelpers;
using Stores;
using Utils;

namespace SQLite
{
    public class PurchasesStore : BaseStore, IPurchasesStore
    {


        public PurchasesStore(IDBPlatformSettings platform, ISQLiteCache iCache, IUserStore iUserStore)
        {
            _platform = platform;

            _iUserStore = iUserStore;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public List<PurchaseOrderListDTO> GetPurchaseOrderListDtos(OrdersSelectionCriterion ordersCriterionarg,List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetPurchaseOrderListDtos started");

            OrdersSelectionCriterion ordersCriterion = ordersCriterionarg;

            var retList = new List<PurchaseOrderListDTO>();

            var data = _sqLiteSyncConnection.Query<Expenditure>("select ID as Id,LMUID, PONo, EMC, EndDate, ManagementUnitID, WorkOrderID, StartDate, Forecast, TenderID, ProductID from Expenditure " +
                                                                "" +
                                                                "WHERE Cancelled =0 AND Deleted =0 AND IsProtected =0 AND VolunteerWork =0 AND Forecast !=0").ToList();

            var expenditureProducts = _sqLiteSyncConnection.Query<ExpenditureProduct>("SELECT ID, Description FROM ExpenditureProduct").ToList();

            //examples of why magic strings are bad = typos arg!
            var workOrders = _sqLiteSyncConnection.Query<WorkOrder>("SELECT ID, Description FROM WorkOrder").ToList();

            var configuration = _sqLiteSyncConnection.Table<Configuration>().ToList();
            int year = 2017;

            if (configuration != null && configuration.Count > 0)
            {
                year = configuration[0].CurrentYear.Year;
            }

            TimeRange currentYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));

            year++;
            TimeRange nextYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));




            IQueryable<Expenditure> query = data.AsQueryable();

            switch (ordersCriterion)
            {
                case OrdersSelectionCriterion.CurrentYear:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.NextYear:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.AllYears:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty));
                    break;

                case OrdersSelectionCriterion.EMCCurrentYear:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => e.EMC && e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.EMCNextYear:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => e.EMC && e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;

                case OrdersSelectionCriterion.EMCAllYears:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => e.EMC);
                    break;

                case OrdersSelectionCriterion.NonEMC:
                    query = query.Where(i => (i.PONo == null || i.PONo == string.Empty))
                        .Where(e => !e.EMC);
                    break;


            }

            //

            foreach (var e in query)
            {
                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == e.ManagementUnitID);
                var worder = workOrders.FirstOrDefault(f => f.ID == e.WorkOrderID);
                var faq =
                    _iCache.AcquisitionUnits.Where(p => p.ManagementUnitID == manu.Id)
                        .OrderBy(a => a.ID)
                        .FirstOrDefault();

                if (faq.LeaseEndDate == null || e.EndDate <= faq.LeaseEndDate)
                {
                    DateTime? lmdt = null;

                    if (e.LMDT.Year != 1)
                        lmdt = e.LMDT;

                    var pol = new PurchaseOrderListDTO()
                    {
                        CostCentre = e.ManagementUnitID,
                        Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                        Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                        ManagementUnitID = e.ManagementUnitID,
                        EndDate = e.EndDate.Validate(),
                        StartDate = e.StartDate.Validate(),
                        ForecastAmount = e.Forecast.GetValueOrDefault(),
                        LastAmendedBy = _iCache.UserLookup[e.LMUID],
                        LastAmendedDate = lmdt,
                        OutToTender = (e.TenderID == null),
                        Product = expenditureProducts.First(f => f.ID == e.ProductID).Description,
                        TenderNumber = e.TenderID.GetValueOrDefault(),
                        WorkOrder = worder.Description
                    };

                    retList.Add(pol);
                }

            }

            stopwatch.Stop();



            Debug.WriteLine("GetPurchaseOrderListDtos got : " + data.Count + " records in " + stopwatch.ElapsedMilliseconds);

            return retList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();

        }
        
        public List<ExpenditureDto> GetExpenditures(int managementUnitID)
        {   
            var data = _sqLiteSyncConnection.Table<Expenditure>().Where(p=>p.ManagementUnitID == managementUnitID && !p.Deleted).ToList();

            var expenditures = new List<ExpenditureDto>();
             
            foreach (var inc in data)
            {
                expenditures.Add(new ExpenditureDto()
                {
                    Id = inc.ID,
                    Description = inc.Notes,
                    StartDate = inc.StartDate,
                    Actual = inc.Actual.GetValueOrDefault(),
                    EndDate = inc.EndDate,
                    ProductID = inc.ProductID,
                    Confidential = inc.Confidential,
                    AimID = inc.AimID,
                    PE = inc.PE,
                    BudgetNet = inc.Budget,
                    ForecastNet = inc.Forecast.GetValueOrDefault(),
                    ForecastNetTotal = inc.Forecast.GetValueOrDefault(),
                    NoAgressoUpdate = inc.NoSync,
                    Pipeline = inc.Pipeline,
                    EMC = inc.EMC,
                    FundingStatusID = inc.FundingStatusID,
                    WSP = inc.WSP,
                    PesticideRecord = inc.PesticideRecord,
                    BudgetTotal = inc.Budget,
                    Chalara = inc.Chalara,
                    Compeleted = inc.Completed,
                    CptNo = inc.CptNo,
                    DTP = inc.DTP,
                    EMCSpecification = inc.EMCSpec,
                    GRN = inc.GRN.GetValueOrDefault(),
                    OpsGrantAided = inc.OpsGrantAided,
                    PODate = inc.PODate.GetValueOrDefault(),
                    PONo = inc.PONo,
                    RPI = inc.RPI,
                    VolunteerWork = inc.VolunteerWork,
                    WorkOrder = inc.WorkOrderID,
                    VATRateID = 0,
                    TAXRateID = inc.TaxCodeID.GetValueOrDefault(),
                    ULMDT = inc.ULMDT,
                    ULMUID = inc.ULMUID,
                    Budget = inc.Budget,
                    CRDT = inc.CRDT,
                    CRUID = inc.CRUID,
                    Completed = inc.Completed,
                    DLDT = inc.DLDT,
                    DLUID = inc.DLUID,
                    Forecast = inc.Forecast,
                    LMDT = inc.LMDT,
                    LMUID = inc.LMUID,
                    ManagementUnitId = inc.ManagementUnitID                    
                });
            }

            return expenditures;
        }
        
        public List<ExpenditureDto> GetWPExpenditures(int managementUnitID)
        {
       
            var sqlStr = "SELECT wo.[Description] as WorkOrderDescription, ip.Description AS Product,  0 AS Remaining,  Completed, Notes as [Description] " +
                         ",e.ID ,e.Kind ,e.GroupGuid ,e.ManagementUnitID as ManagementUnitId ,e.Project ,e.WorkOrderID ,e.ProductID ,e.AimID ,e.Notes ,e.StartDate ,e.EndDate ,e.ActualDate ,e.Budget ,e.Ordered ,e.Forecast ,e.LastMonthForecast ,e.Actual ,e.TenderPrice ,e.GRN ,e.CptNo ,e.EMC ,e.PesticideRecord ,e.EMCSpec ,e.WSP ,e.DTP ,e.PE ,e.Pipeline ,e.FundingStatusID ,e.PONo ,e.PODate ,e.TenderID ,e.TaxCodeID ,e.AccountingYear ,e.RPI ,e.Confidential ,e.OpsGrantAided ,e.Completed ,e.Chalara ,e.VolunteerWork ,e.Cancelled ,e.NoSync ,e.WoodProduction ,e.NumberOfTrees ,e.NumberOfTreesOrigin ,e.CostPerTree ,e.TreeSupplierID ,e.WCExpenditureID ,e.ProvenanceZoneID ,e.PlantTypeID ,e.GrownMethodID ,e.Size_cm ,e.EcoSurveyTypeID ,e.EcoSubjectOrSpeciesID ,e.EcoOtherDescription ,e.EcoAuthorOfOutput ,e.EcoSurveyUploadedToDW ,e.Deleted ,e.IsProtected ,e.IsHistorical ,e.IsDefaultValue ,e.LMDT ,e.LMUID ,e.ULMDT ,e.ULMUID ,e.CRDT ,e.CRUID ,e.DLDT,e.DLUID" +
                         " FROM Expenditure e join IncomeProduct ip on e.ProductID = ip.ID join WorkOrder wo on e.WorkOrderID = wo.ID " +
                         "WHERE e.Deleted = 0 AND e.ManagementUnitID =" + managementUnitID;

            var edata = _sqLiteSyncConnection.Query<ExpenditureDto>(sqlStr).ToList();



            return edata;
        }

        public WPSummaryDTO GetWPExpendituresSummaryThisSite(int managementUnitID)
        {
            var results = GetWPExpenditures(managementUnitID);

            var summaryObject = new WPSummaryDTO()
            {
                Budget = results.Sum(p => p.Budget),
                Forecast = results.Sum(p => p.Forecast.GetValueOrDefault()),
                Actual = results.Sum(p => p.Actual),
                Remaining = results.Sum(p => p.Remaining)
            };

            return summaryObject;
        }
        
        public WPSummaryDTO GetWPExpendituresSummaryMySites(int managementUnitID)
        {
            var sqlStr = "SELECT i.ID,i.ManagementUnitID,wo.[Description] as WorkOrder, ip.Description AS Product, i.StartDate, i.EndDate, i.Budget, i.Forecast, i.Actual, 0 AS Remaining, PONo, GRN, Completed, Notes as [Description] " +
                         " FROM Expenditure i join IncomeProduct ip on i.ProductID = ip.ID join WorkOrder wo on i.WorkOrderID = wo.ID " +
                         "WHERE i.Deleted = 0 AND i.ManagementUnitID =" + managementUnitID;

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

        //public List<ExpenditureDto> GetExpenditures()
        //{
        //    List<ExpenditureDto> edata = _sqLiteSyncConnection.Query<ExpenditureDto>("SELECT ManagementUnitID, EndDate, Forecast, Budget, EMC, Actual, PesticideRecord, FundingStatusID, Project, WSP, PE, Completed, TaxCodeID FROM Expenditure where Deleted =0 and Cancelled = 0").ToList();

        //    return edata;
        //}

        public void UpdateExpenditures(List<ExpenditureDto> editSet, int managementId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = _sqLiteSyncConnection.Table<Expenditure>().Where(i => i.ManagementUnitID == managementId && !i.Deleted).ToList();

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
                    existingIncome.ProductID = matchedRecord.ProductID;
                    existingIncome.AimID = matchedRecord.AimID;                    
                    existingIncome.Actual = matchedRecord.Actual;                  
                    existingIncome.Completed = matchedRecord.Completed;
                    existingIncome.PE = matchedRecord.PE;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.Confidential = matchedRecord.Confidential;
                    existingIncome.Notes = matchedRecord.Description;                  
                    existingIncome.TaxCodeID = matchedRecord.TAXRateID;
                    existingIncome.WorkOrderID = matchedRecord.WorkOrder;
                    existingIncome.Budget = matchedRecord.BudgetNet;
                    existingIncome.Forecast = matchedRecord.ForecastNet;                     
                    existingIncome.FundingStatusID = matchedRecord.FundingStatusID;
                    existingIncome.PONo = matchedRecord.PONo;
                    existingIncome.PODate = matchedRecord.PODate;
                    existingIncome.GRN = matchedRecord.GRN;                     
                    existingIncome.CptNo = matchedRecord.CptNo;
                    existingIncome.EMC = matchedRecord.EMC;
                    existingIncome.RPI = matchedRecord.RPI;
                    existingIncome.PesticideRecord = matchedRecord.PesticideRecord;
                    existingIncome.WSP = matchedRecord.WSP;
                    existingIncome.DTP = matchedRecord.DTP;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.PE = matchedRecord.PE;
                    existingIncome.Chalara = matchedRecord.Chalara; 
                    existingIncome.OpsGrantAided = matchedRecord.OpsGrantAided;
                    existingIncome.VolunteerWork = matchedRecord.VolunteerWork; 
                    existingIncome.Budget = matchedRecord.Budget;
                    existingIncome.Forecast = matchedRecord.Forecast; 
                    existingIncome.Completed = matchedRecord.Completed;



                    existingIncome.LMDT = matchedRecord.LMDT;
                    existingIncome.LMUID = matchedRecord.LMUID.GetValueOrDefault();
                    existingIncome.CRDT = matchedRecord.CRDT;
                    existingIncome.CRUID = matchedRecord.CRUID;
                    existingIncome.DLDT = matchedRecord.DLDT;
                    existingIncome.DLUID = matchedRecord.DLUID;
                    existingIncome.ULMDT = matchedRecord.ULMDT;
                    existingIncome.ULMUID = matchedRecord.ULMUID;
                }

                if (deletedRecords.Any(f => f == existingIncome.ID))
                {
                    existingIncome.Deleted = true;
                }
            }


            _sqLiteSyncConnection.UpdateAll(existingData);



            var recordsToAdd = new List<Expenditure>();


            var latestRecord = _sqLiteSyncConnection.Table<Income>().OrderByDescending(i => i.ID).FirstOrDefault();

            int id = 0;

            if (latestRecord != null)
            {
                id = latestRecord.ID;
            }

            foreach (var nr in newRecords)
            {
                var newRecord = new Expenditure()
                {
                    ID = id++,  
                    Kind ="" ,
                    GroupGuid ="" ,
                    ManagementUnitID = nr.ManagementUnitId,
                    Project = false,
                    WorkOrderID = nr.WorkOrder,
                    ProductID = nr.ProductID,
                    AimID = nr.AimID,
                    Notes = nr.Description,
                    StartDate = nr.StartDate.GetValueOrDefault(),
                    EndDate = nr.EndDate.GetValueOrDefault(),
                    ActualDate = DateTime.Today,
                    Budget = nr.Budget,
                    //ClmdInvd = 0,
                    Forecast = nr.Forecast,
                    LastMonthForecast = 0.0,
                    Actual =nr.Actual,
                    TenderPrice = 0.0,
                    GRN = nr.GRN,
                    CptNo = nr.CptNo,
                    EMC = nr.EMC,
                    PesticideRecord = nr.PesticideRecord,
                    EMCSpec = nr.EMCSpecification,
                    WSP = nr.WSP,
                    DTP = nr.DTP,
                    PE = nr.PE,
                    Pipeline = nr.Pipeline,
                    FundingStatusID = nr.FundingStatusID,
                    PONo = nr.PONo,
                    PODate = nr.PODate,
                    TenderID = 0,
                    TaxCodeID = nr.TAXRateID,
                    AccountingYear = 0,
                    RPI = nr.RPI,
                    Confidential = nr.Confidential,
                    OpsGrantAided = nr.OpsGrantAided,
                    Completed = nr.Completed,
                    Chalara =nr.Chalara,
                    VolunteerWork = nr.VolunteerWork,
                    Cancelled = false,
                    NoSync =false,    
                    NumberOfTrees = 0,
                    NumberOfTreesOrigin =0,
                    CostPerTree = 0.0,
                    TreeSupplierID = 0,
                    WCExpenditureID = 0,
                    ProvenanceZoneID = 0,
                    PlantTypeID = 0,
                    GrownMethodID =0,
                    Size_cm = 0,
                    Deleted =false,
                    IsProtected =false,
                    IsHistorical =false,
                    IsDefaultValue =false,



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

            if (recordsToAdd.Count > 0)
                _sqLiteSyncConnection.InsertAll(recordsToAdd);
        }

        public List<Expenditure> GetCacheExpenditures()
        {
            List<Expenditure> edata = _sqLiteSyncConnection.Query<Expenditure>("SELECT ManagementUnitID, EndDate, Forecast, Budget, EMC, Actual, PesticideRecord, FundingStatusID, Project, WSP, PE, Completed, TaxCodeID FROM Expenditure where Deleted =0 and Cancelled = 0").ToList();

            List<ExpenditureDto> expenditureDtos = edata.Select(e => new ExpenditureDto()
            {
                Description = e.Notes,
                WorkOrder = e.WorkOrderID,
                Forecast = e.Forecast,
                Id = e.ID,
                Product = "",
                ManagementUnitId = e.ManagementUnitID,
                Confidential = e.Confidential,
                LMDT = e.LMDT,
                Deleted = e.Deleted,
                Budget = e.Budget,
                EndDate = e.EndDate,
                ULMDT = e.ULMDT,
                IsProtected = e.IsProtected,
                LMUID = e.LMUID,
                CRDT = e.CRDT,
                ULMUID = e.ULMUID,
                CRUID = e.CRUID,
                DLUID = e.DLUID,
                IsHistorical = e.IsHistorical,
                DLDT = e.DLDT,
                IsDefaultValue = e.IsDefaultValue,
                StartDate = e.StartDate,
                TenderId = e.TenderID.GetValueOrDefault(),
                WorkOrderDescription = "",
                BudgetNet = e.Budget,
                Actual = e.Actual.GetValueOrDefault(),
                ForecastNetTotal = e.Forecast.GetValueOrDefault(),
                Completed = e.Completed,
                Pipeline = e.Pipeline,
                ProductID = e.ProductID,
                TAXRateID = e.TaxCodeID.GetValueOrDefault(),
                VolunteerWork = e.VolunteerWork,
                NoAgressoUpdate = e.NoSync,
                Remaining = 0,
                AimID = e.AimID,
                ForecastNet = e.Forecast.GetValueOrDefault(),
                BudgetTotal = e.Budget,
                Chalara = e.Chalara,
                Compeleted = e.Completed,
                CptNo = e.CptNo,
                DTP = e.DTP,
                EMC = e.EMC,
                EMCSpecification = e.EMCSpec,
                FundingStatusID = e.FundingStatusID,
                GRN = e.GRN.GetValueOrDefault(),
                OpsGrantAided = e.OpsGrantAided,
                Ordered = 0.0,
                PE = e.PE,
                PODate = e.PODate,
                PONo = e.PONo,
                PesticideRecord = e.PesticideRecord,
                RPI = e.RPI,
                VATRateID = 0,
                WSP = e.WSP

            }).ToList();

            return edata;
        }

        public WPSummaryDTO GetWPExpendituresSummaryMySites(List<ExpenditureDto> temp)
        {
            throw new NotImplementedException();
        }

        public WPSummaryDTO GetWPExpendituresSummaryThisSite(List<ExpenditureDto> temp)
        {
            throw new NotImplementedException();
        }

        public List<TenderExpenditureDto> GetTenderExpenditures(int tenderId)
        {
            throw new NotImplementedException();
        }

        public TenderDto GetTender(int tenderID, int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateTender(TenderDto tenderDto, int tenderID, int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateTenderExpenditures(int tenderId, List<TenderExpenditureDto> tenderExpenditureDtos)
        {
            throw new NotImplementedException();
        }

        public List<TenderDto> GetTenders()
        {
            throw new NotImplementedException();
        }

        public List<SupplierDto> GetSuppliers()
        {
            throw new NotImplementedException();
        }

        public void AddToTender(int tenderId, List<int> expenditureIds)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromTender(int tenderId, List<int> expenditureIds)
        {
            throw new NotImplementedException();
        }
    }
}