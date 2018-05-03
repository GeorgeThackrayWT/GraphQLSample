using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;
using Utils;

namespace EFStores
{
    public class SalesEFStore : BaseEFStore, ISalesStore
    {
        private IUserStore _iUserStore;

        public SalesEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) :
            base(ec, iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<IncomeDto> GetIncomes()
        {
            var data = Context.Income.Select(x => new IncomeDto()
            {
                Id = x.Id,
                LMDT = x.Lmdt,
                LMUID = x.Lmuid,
                CRDT = x.Crdt,
                CRUID = x.Cruid,
                DLDT = x.Dldt,
                DLUID = x.Dluid,
                ULMDT = x.Ulmdt,
                ULMUID = x.Ulmuid,
                Deleted = x.Deleted,

                Forecast = x.Forecast.GetValueOrDefault(),
                Actual = x.Actual.GetValueOrDefault(),
                AimId = x.AimId,
                Budget = x.Budget,
                BudgetNet = x.Budget,
                BudgetNetTotal = x.Budget,
                ClmdInvd = x.ClmdInvd.GetValueOrDefault(),
                Completed = x.Completed,
                Confidential = x.Confidential,
                Description = x.Notes,
                EndDate = x.EndDate,
                ForecastNet = x.Forecast.GetValueOrDefault(),
                ForecastNetTotal = x.Forecast.GetValueOrDefault(),
                GrantSchemeDescription = x.GrantReference,
                GrantSchemeId = x.GrantId.GetValueOrDefault(),
                IsProject = x.Project,
                ManagementUnitId = x.ManagementUnitId,
                NoAgressoUpdate = x.NoSync,
                Pe = x.Pe,
                Pipeline = x.Pipeline,
                Product = x.Product.Description,
                ProductId = x.ProductId,
                Received = x.Received.GetValueOrDefault(),
                Remaining = 0,
                SoDate = x.Sodate,
                SoNo = x.Sono,
                StartDate = x.StartDate,
                VatRateId = 0,
                WorkOrder = x.WorkOrderId,
                WorkOrderDescription = x.WorkOrder.Description
            }).Where(d=>!d.Deleted ).ToList();

            return data;
        }

        public List<IncomeDto> GetIncomes(int managementUnitId)
        {            
            return GetIncomes().Where(i=>i.ManagementUnitId== managementUnitId).ToList();
        }

        public List<SalesOrdersListDTO> GetSalesOrdersListDtos(OrdersSelectionCriterion ordersCriterionarg,List<UserRoleSmallDto> userRole,int userId, int application, int regionId)
        {
     
            OrdersSelectionCriterion ordersCriterion = ordersCriterionarg;

      
            var incomeProducts = Context.IncomeProduct.ToList();

            var configuration = Context.Configuration.ToList();

                    
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

            var acqCache = Context.AcquisitionUnit.Select(s => new { s.Id, s.ManagementUnitId, s.LeaseEndDate }).ToList();


            var query = Context.Income.Include(m => m.ManagementUnit).Include(w=>w.WorkOrder)
                .Where(i => i.Sono != "" && !i.Deleted && !i.Cancelled && !i.IsProtected && i.Forecast!=null && i.Forecast.Value!=0.0 && !i.Completed);

            var retList = new List<SalesOrdersListDTO>();

            switch (ordersCriterion)
            {
                case OrdersSelectionCriterion.CurrentYear:
                    query = query.Where(e => e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;
                case OrdersSelectionCriterion.NextYear:
                    query = query.Where(e => e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;                    
            }



            foreach (var e in query)
            {                
                var faq = acqCache.Where(p => p.ManagementUnitId== e.ManagementUnitId)
                        .OrderBy(a => a.Id)
                        .FirstOrDefault();

                if (faq.LeaseEndDate == null || faq.LeaseEndDate <= e.EndDate)
                {
                    var pol = new SalesOrdersListDTO()
                    {
                        CostCentre = e.ManagementUnitId,
                        Region = e.ManagementUnit!=null? RegionName(e.ManagementUnit.RegionId): "",
                        RegionId = e.ManagementUnit!=null ? e.ManagementUnit.RegionId.GetValueOrDefault() : 0,
                        ApplicationId = e.ManagementUnit != null ? e.ManagementUnit.ApplicationId : 99,
                        WoodlandOfficerID = e.ManagementUnit != null ? e.ManagementUnit.WoodlandOfficerId :0,
                        DeputyID = e.ManagementUnit != null ? e.ManagementUnit.DeputyId.GetValueOrDefault():0,
                        AcquisitionOfficerID = _cache.AcquisitionOfficerLookup.ContainsKey(e.ManagementUnitId) ? _cache.AcquisitionOfficerLookup[e.ManagementUnitId] :0,
                        ManagementUnitID = e.ManagementUnitId,
                        EndDate = e.EndDate.Validate(),
                        StartDate = e.StartDate.Validate(),
                        ForecastAmount = e.Forecast.GetValueOrDefault(),
                        LastAmendedBy = UserName(e.Lmuid),
                        LastAmendedDate = e.Lmdt,
                        Product = incomeProducts.First(f => f.Id == e.ProductId).Description,
                        WorkOrder = e.WorkOrder.Description,
                     
                    };

                    retList.Add(pol);
                }
            }

        
            return retList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public List<IncomeDto> GetWpIncomes(int managementUnitId)
        {
            return GetIncomes().Where(i => i.ManagementUnitId == managementUnitId).ToList();
        }

        public WPSummaryDTO GetWpIncomesSummaryMySites(int managementUnitId)
        {


            var summaryObject = new WPSummaryDTO()
            {
                Budget = Context.Income.Sum(p => p.Budget),
                Forecast = Context.Income.Where(a=>a.Forecast!=null).Sum(p => p.Forecast.Value),
                Actual = Context.Income.Where(a => a.Actual != null).Sum(p => p.Actual.Value),
                Remaining = 0
            };

            return summaryObject;
        }

        public void UpdateIncomes(List<IncomeDto> editSet, int managementId)
        {
            

            var currentUserId = _iUserStore.CurrentUserId();


            
            var existingData = Context.Income.Where(i => i.ManagementUnitId == managementId && !i.Deleted);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();


            foreach (var existingIncome in existingData)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == existingIncome.Id);

                if (matchedRecord != null)
                {                
                    existingIncome.StartDate = matchedRecord.StartDate.GetValueOrDefault();
                    existingIncome.EndDate = matchedRecord.EndDate.GetValueOrDefault();
                    existingIncome.ProductId = matchedRecord.ProductId;
                    existingIncome.AimId = matchedRecord.AimId;
                    existingIncome.ClmdInvd = matchedRecord.ClmdInvd;
                    existingIncome.Actual = matchedRecord.Actual;
                    existingIncome.Sono = matchedRecord.SoNo;
                    existingIncome.Sodate = matchedRecord.SoDate;
                    existingIncome.Received = matchedRecord.Received;
                    existingIncome.Completed = matchedRecord.Completed;
                    existingIncome.Pe = matchedRecord.Pe;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.Confidential = matchedRecord.Confidential;
                    existingIncome.Notes = matchedRecord.Description;
                    existingIncome.GrantId = matchedRecord.GrantSchemeId !=0 ? (int?)matchedRecord.GrantSchemeId : null;
                    existingIncome.GrantReference = matchedRecord.GrantSchemeDescription;
                    
                    existingIncome.WorkOrderId = matchedRecord.WorkOrder;
                    existingIncome.Budget = matchedRecord.BudgetNet;
                    existingIncome.Forecast = matchedRecord.ForecastNet;


                    existingIncome.Id = matchedRecord.Id;
                    existingIncome.Deleted = matchedRecord.Deleted;

                    existingIncome.Lmdt = DateTime.Today;
                    existingIncome.Lmuid = currentUserId;
                    //existingIncome.Crdt = matchedRecord.CRDT;
                    //existingIncome.Cruid = matchedRecord.CRUID;
                    //existingIncome.Dldt = matchedRecord.DLDT;
                    //existingIncome.Dluid = matchedRecord.DLUID;
                    //existingIncome.Ulmdt = matchedRecord.ULMDT;
                    //existingIncome.Ulmuid = matchedRecord.ULMUID;

                }

                if (deletedRecords.Any(f => f == existingIncome.Id))
                {
                    existingIncome.Deleted = true;
                    existingIncome.Dldt = DateTime.Today;
                    existingIncome.Dluid = currentUserId;
                }
            }

            //sonumber
            var recordsToAdd = newRecords.Select(nr => new Income()
            {
                    //   ID = id++,
                 
                    WorkOrderId = nr.WorkOrder,
                    Actual = nr.Actual,
                    GrantId = nr.GrantSchemeId != 0 ? (int?)nr.GrantSchemeId : null,
                    ManagementUnitId = managementId,
                    Deleted = false,
                    TaxCodeId = nr.TaskCodeId==0 ? null : (int?)nr.TaskCodeId,
                    Forecast = nr.ForecastNet,
                    GrantReference = nr.GrantSchemeDescription,
                    Budget = nr.BudgetNet,
                    Notes = nr.Description,
                    ActualDate = DateTime.Today,
                    AimId = nr.AimId,
                    Cancelled = false,
                    ClmdInvd = nr.ClmdInvd,
                    Completed = nr.Completed,
                    Confidential = nr.Confidential,
                    EndDate = nr.EndDate.GetValueOrDefault(),
                    StartDate = nr.StartDate.GetValueOrDefault(),
                    GrantScheme = nr.GrantSchemeDescription,
                    IsDefaultValue = false,
                    IsHistorical = false,
                    IsProtected = false,
                    LastMonthForecast = 0.0,
                    NetIncome = 0.0,
                    NoSync = false,
              //      Order = nr.SoNo.Contains("-") ? Context.Order.FirstOrDefault(f=>f.Id == Convert.ToInt32((nr.SoNo.Split('-')[0]))) : null,
                    //OrderId = nr.or,
                    Pe = nr.Pe,
                    Pipeline = nr.Pipeline,
                    ProductId = nr.ProductId,
                    Project = nr.IsProject,
                    Received = nr.Received,
                    Sodate = nr.SoDate,
                    Sono = nr.SoNo,
                    Aim =   Context.Aim.FirstOrDefault(a=>a.Id == nr.AimId),
                   // Grant =Context.Grant.First(),
                    //Order =null,
                    Product = Context.IncomeProduct.FirstOrDefault(f=>f.Id == nr.ProductId),
                    WorkOrder = Context.WorkOrder.FirstOrDefault(w=>w.Id == nr.WorkOrder),
                    Lmdt = DateTime.Today,
                    Lmuid = currentUserId,
                    Crdt = DateTime.Today,
                    Cruid = currentUserId,
                    Dldt = null,
                    Dluid = null,
                    Ulmdt = null,
                    Ulmuid = null
            }).ToList();
            
   
            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }
    }
}
