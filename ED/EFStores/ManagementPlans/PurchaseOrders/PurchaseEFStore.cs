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
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;
using Utils;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using Tender = DataObjects.DAOS.Tender;
using User = DataObjects.DAOS.User;

namespace EFStores
{
    public class PurchaseEFStore : BaseEFStore, IPurchasesStore
    {
        private IUserStore _iUserStore;

        public PurchaseEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : 
            base(ec,iCache)
        {
            _iUserStore = iUserStore;



        }

        public List<DataObjects.DAOS.Expenditure> GetCacheExpenditures()
        {
            //sql lite cache stuff
            throw new NotImplementedException();
        }
        
        public List<ExpenditureDto> GetExpenditures(int managementUnitID)
        {
            var results = Context.Expenditure
                .Include(e => e.Product)
                .Include(e => e.WorkOrder)
                .AsNoTracking().ToList()
                .Where(p => !p.Deleted && !p.Cancelled && p.WorkOrder != null && p.Product != null && p.ManagementUnitId == managementUnitID)
                            .Select(inc => new ExpenditureDto()
                            {
                                Id = inc.Id,
                                Description = inc.Notes,
                                StartDate = inc.StartDate,
                                Actual = inc.Actual.GetValueOrDefault(),
                                EndDate = inc.EndDate,
                                ProductID = inc.ProductId,
                                Confidential = inc.Confidential,
                                AimID = inc.AimId,
                                PE = inc.Pe,
                                BudgetNet = inc.Budget,
                                ForecastNet = inc.Forecast.GetValueOrDefault(),
                                ForecastNetTotal = inc.Forecast.GetValueOrDefault(),
                                NoAgressoUpdate = inc.NoSync,
                                Pipeline = inc.Pipeline,
                                EMC = inc.Emc,
                                FundingStatusID = inc.FundingStatusId,
                                WSP = inc.Wsp,
                                PesticideRecord = inc.PesticideRecord,
                                BudgetTotal = inc.Budget,
                                Chalara = inc.Chalara,
                                Compeleted = inc.Completed,
                                CptNo = inc.CptNo,
                                DTP = inc.Dtp,
                                EMCSpecification = inc.Emcspec,
                                GRN = inc.Grn.GetValueOrDefault(),
                                OpsGrantAided = inc.OpsGrantAided,
                                PODate = inc.Podate,
                                PONo = inc.Pono,
                                RPI = inc.Rpi,
                                VolunteerWork = inc.VolunteerWork,
                                WorkOrder = inc.WorkOrderId,
                                VATRateID = 0,
                                Product = inc.Product.Description,
                                TAXRateID = inc.TaxCodeId.GetValueOrDefault(),
                                Budget = inc.Budget,
                                Completed = inc.Completed,
                                Forecast = inc.Forecast,
                                WorkOrderDescription = inc.WorkOrder.Description,
                                ULMDT = inc.Ulmdt,
                                ULMUID = inc.Ulmuid,
                                CRDT = inc.Crdt,
                                CRUID = inc.Cruid,
                                DLDT = inc.Dldt,
                                DLUID = inc.Dluid,
                                LMDT = inc.Lmdt,
                                LMUID = inc.Lmuid,
                                TenderId = inc.TenderId.GetValueOrDefault(),
                                ManagementUnitId = inc.ManagementUnitId
                            })
                            .ToList();


            return results;
        }

        public List<PurchaseOrderListDTO> GetPurchaseOrderListDtos(OrdersSelectionCriterion ordersCriterionarg,List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
           // Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetPurchaseOrderListDtos started");

            OrdersSelectionCriterion ordersCriterion = ordersCriterionarg;

            var retList = new List<PurchaseOrderListDTO>();

            var expenditureProducts = Context.ExpenditureProduct
                .Select(m => new { m.Id,  m.Description}).ToList();
            
          
            var configuration = Context.Configuration;

            int year = 2017;

            if (configuration != null && configuration.Any())
            {
                year = configuration.First().CurrentYear.Year;
            }

            TimeRange currentYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));

            //var x = Context.MetadataRecord.Where(p => p.Deleted).ToList();

            year++;
            TimeRange nextYearRange = new TimeRange(new DateTime(year, 1, 1), new DateTime(year + 1, 1, 1).AddSeconds(-1));


            var acqCache = Context.AcquisitionUnit.Select(s => new {s.Id,s.ManagementUnitId, s.LeaseEndDate, s.AcquisitionOfficerId}).ToList();

            var filteredExpenditures =Context.Expenditure.Include(w=>w.WorkOrder).Include(m=>m.ManagementUnit).Include(i=>i.Tender).Where(m=>m.IsProtected==false 
                                                                &&  m.VolunteerWork ==false 
                                                                && m.Forecast != null 
                                                                && m.Forecast.Value!=0
                                                                && m.Pono !=""
                                                                );

            switch (ordersCriterion)
            {
                case OrdersSelectionCriterion.CurrentYear:
                    filteredExpenditures = filteredExpenditures.Where(e => e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;
                case OrdersSelectionCriterion.NextYear:
                    filteredExpenditures = filteredExpenditures.Where(e => e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;               
                case OrdersSelectionCriterion.EMCCurrentYear:
                    filteredExpenditures = filteredExpenditures.Where(e => e.Emc && e.EndDate >= currentYearRange.MinDate && e.EndDate < currentYearRange.MaxDate);
                    break;
                case OrdersSelectionCriterion.EMCNextYear:
                    filteredExpenditures = filteredExpenditures.Where(e => e.Emc && e.EndDate >= nextYearRange.MinDate && e.EndDate < nextYearRange.MaxDate);
                    break;
                case OrdersSelectionCriterion.EMCAllYears:
                    filteredExpenditures = filteredExpenditures.Where(e => e.Emc);
                    break;
                case OrdersSelectionCriterion.NonEMC:
                    filteredExpenditures = filteredExpenditures.Where(e => !e.Emc);
                    break;
            }

            //

            foreach (var exp in filteredExpenditures)
            {
              //  var manu = _cache.ManagementUnitDtos.FirstOrDefault(p => p.Id == exp.ManagementUnitId);

           
                var acqUnit = acqCache.Where(p => p.ManagementUnitId == exp.ManagementUnitId)
                        .OrderBy(a => a.Id)
                        .FirstOrDefault();

                if (acqUnit.LeaseEndDate == null || exp.EndDate <= acqUnit.LeaseEndDate)
                {                   
                    var pol = new PurchaseOrderListDTO()
                    {
                        Id = exp.Id,
                        CostCentre = exp.ManagementUnitId,
                        Manager = UserName(exp.ManagementUnit.WoodlandOfficerId),
                        Region = RegionName(exp.ManagementUnit.RegionId),
                        RegionId = exp.ManagementUnit.RegionId.GetValueOrDefault(),
                        WoodlandOfficerID = exp.ManagementUnit.WoodlandOfficerId,
                        AcquisitionOfficerID = acqUnit.AcquisitionOfficerId.GetValueOrDefault(),
                        DeputyID = exp.ManagementUnit.DeputyId.GetValueOrDefault(),
                        ApplicationId = exp.ManagementUnit.ApplicationId,
                        ManagementUnitID = exp.ManagementUnitId,
                        EndDate = exp.EndDate.Validate(),
                        StartDate = exp.StartDate.Validate(),
                        ForecastAmount = exp.Forecast.GetValueOrDefault(),
                        LastAmendedBy = UserName(exp.Lmuid),                      
                        LastAmendedDate = exp.Lmdt,
                        OutToTender = (exp.TenderId != null),
                        Product = expenditureProducts.First(f => f.Id == exp.ProductId).Description,
                        TenderNumber = exp.TenderId == null ? 0 : exp.TenderId.Value,
                        TenderName = exp.TenderId == null ? "" : exp.Tender.Number,
                        WorkOrder = exp.WorkOrder.Description
                    };

                    retList.Add(pol);
                }

            }

            //stopwatch.Stop();

            return retList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList(); ;
        }

        public TenderDto GetTender(int tenderID, int userId)
        {
            var returnTender = new TenderDto();

            var ue = Context.User.FirstOrDefault(f => f.Id == userId);

         

            double expenditureLimit = 0.0;

            if (ue != null)
            {
                var exp = Context.AuthorisationLevel.FirstOrDefault(f => f.Id == ue.AuthorisationLevelId);

                if (exp != null)
                {
                    expenditureLimit= exp.ExpenditureLimit;
                }
            }


            var tender = Context.Tender.FirstOrDefault(f => f.Id == tenderID);

            

            if (tender != null)
            {
                //var exps = Context.Expenditure.Where(w => w.TenderId == tender.Id);
                var exps = Context.Expenditure
                    .Include(e => e.Product)
                    .Include(e => e.WorkOrder)
                    .AsNoTracking().ToList()
                    .Where(p => !p.Deleted && !p.Cancelled && p.WorkOrder != null && p.Product != null &&
                                p.TenderId == tender.Id);

                bool nettingOffPo = false;
                int supplierId = 0;
                string remarks = "";

                var order = Context.Order.FirstOrDefault(f => f.Id == tender.OrderId);



                if (order != null)
                {
                    nettingOffPo = order.NettingOffPo;
                    supplierId = order.SupplierId.GetValueOrDefault();
                    remarks = order.Remarks;
                }

                string supplierRef = "";

                var supplier = Context.Supplier.FirstOrDefault(f => f.Id == supplierId);

                if (supplier != null)
                {
                    supplierRef = supplier.Name;
                }

                string userName = "";

                var user = Context.User.FirstOrDefault(f => f.Id == tender.Lmuid);

                if (user != null)
                    userName = user.DisplayName;

                var returnedTo = Context.User.FirstOrDefault(f => f.Id == tender.ReturnedToUser.GetValueOrDefault());

                string returnedToName = "";

                if (returnedTo != null)
                    returnedToName = returnedTo.DisplayName;

                var t = new TenderDto()
                {
                    AuthorisationLimit = expenditureLimit,
                    CreatedByUser = tender.Lmuid,
                    CreatedByUserName = userName,
                    DateCreated = tender.Crdt,
                    NettingOffPO = nettingOffPo,
                    TotalForecastNet = exps.Sum(s=>s.Forecast.GetValueOrDefault()),
                    TotalForecastTotal = exps.Sum(s => s.Forecast.GetValueOrDefault()),
                    PriceNet = exps.Sum(s=>s.TenderPrice.GetValueOrDefault()),
                    Remarks = remarks,
                    ReturnedBy = tender.ReturnedByDate,
                    ReturnedTo = tender.ReturnedToUser.GetValueOrDefault(),
                    ReturnedToName = returnedToName,
                    SupplierId = supplierId,
                    SupplierRef = supplierRef,
                    TenderNumber = tender.Number,
                    TenderTotal = exps.Sum(s => s.TenderPrice.GetValueOrDefault()),
                    Total = exps.Sum(s => s.TenderPrice.GetValueOrDefault()),
                };

                returnTender = t;
            }



            return returnTender;
        }


        public void UpdateTender(TenderDto tenderDto, int tenderID, int userId)
        {
            var tender = Context.Tender.FirstOrDefault(f => f.Id == tenderID);
            
            if (tender != null)
            {
                var order = Context.Order.FirstOrDefault(f => f.Id == tender.OrderId);

                if (order != null)
                {
                    order.Remarks = tenderDto.Remarks;
                    order.SupplierId = tenderDto.SupplierId == 0 ? null : (int?) tenderDto.SupplierId;
                }

                tender.ReturnedByDate = tenderDto.ReturnedBy;
                tender.ReturnedToUser = tenderDto.ReturnedTo;
                
            }


            Context.SaveChanges();

        }

        public void UpdateTenderExpenditures(int tenderId, List<TenderExpenditureDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = Context.Expenditure        
                .Where(p => !p.Deleted && p.TenderId == tenderId).ToList(); 

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
          
        
            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

    

            foreach (var existingExpenditure in existingData)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == existingExpenditure.Id);

                if (matchedRecord != null)
                {                 
                    if(matchedRecord.VatRate.ID!=0)
                        existingExpenditure.TaxCodeId = matchedRecord.VatRate.ID;

                    existingExpenditure.TenderPrice = matchedRecord.TenderPriceNet;

                    existingExpenditure.Crdt = matchedRecord.CRDT;
                    existingExpenditure.Dldt = matchedRecord.DLDT;
                    existingExpenditure.Ulmdt = matchedRecord.ULMDT;


                    existingExpenditure.Lmuid = matchedRecord.LMUID.GetValueOrDefault();
                    existingExpenditure.Cruid = matchedRecord.CRUID;
                    existingExpenditure.Dluid = matchedRecord.DLUID;
                    existingExpenditure.Ulmuid = matchedRecord.ULMUID;

                }

                if (deletedRecords.Contains(existingExpenditure.Id))
                {
                    existingExpenditure.TenderId = null;
                }
            }

            // we should never need to add new 
            // records here


            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TenderExpenditureDto> GetTenderExpenditures(int tenderId)
        {
            var exps = Context.Expenditure
                .Include(e => e.Product)
                .Include(e=>e.ManagementUnit)
                .Include(e => e.TaxCode)
                .Include(e => e.WorkOrder)
                .AsNoTracking().ToList()
                .Where(p => !p.Deleted && !p.Cancelled && p.WorkOrder != null && p.Product != null &&
                            p.TenderId == tenderId);

            List<TenderExpenditureDto> result = new List<TenderExpenditureDto>();

            foreach (var e in exps)
            {
                var taxCode = "unknown";

                if (e.TaxCodeId != null)
                {
                    taxCode = e.TaxCode.Description;
                }

                result.Add(new TenderExpenditureDto()
                {
                    Description = e.Notes,
                    Total = -255.0,
                    SiteName = e.ManagementUnit.Name,
                    EndDate = e.EndDate,
                    ForecastNet = e.Forecast.GetValueOrDefault(),
                    ForecastTotal = e.Forecast.GetValueOrDefault(),
                    ProductId = e.ProductId,
                    ProductName = e.Product.Description,
                    SpecRef = "",
                    StartDate = e.StartDate,
                    TenderPriceNet = e.TenderPrice.GetValueOrDefault(),
                    WorkOrder = e.WorkOrder.Code,
                    WorkOrderId = e.WorkOrderId,
                    VatRate = new ComboBoxValue() { ID = e.TaxCodeId.GetValueOrDefault(), Description = taxCode, Name = taxCode },
                });
            }

            return result;

        }

        public WPSummaryDTO GetWPExpendituresSummaryMySites(List<ExpenditureDto> temp)
        {       
            return new WPSummaryDTO()
            {
                Budget = temp.Sum(p => p.Budget),
                Forecast = temp.Where(p=>p.Forecast!=null).Sum(p => p.Forecast.Value),
                Actual = temp.Sum(p => p.Actual),
                Remaining = temp.Sum(p => p.Remaining)
            };
        }

        public WPSummaryDTO GetWPExpendituresSummaryThisSite(List<ExpenditureDto> temp)
        {         
            var temp2 = Context.Expenditure.Select(a => new ExpenditureDto()
            {
                Actual = a.Actual.GetValueOrDefault(),
                Budget = a.Budget,
                Forecast = a.Forecast,
                Remaining = 0
            }).ToList();

            return new WPSummaryDTO()
            {
                Budget = temp2.Sum(p => p.Budget),
                Forecast = temp2.Where(p => p.Forecast != null).Sum(p => p.Forecast.Value),
                Actual = temp2.Sum(p => p.Actual),
                Remaining = temp2.Sum(p => p.Remaining)
            };
        }

        public void UpdateExpenditures(List<ExpenditureDto> editSet, int managementId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = Context.Expenditure.Where(i => i.ManagementUnitId == managementId && !i.Deleted);

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
                    existingIncome.Id = matchedRecord.Id;

                    existingIncome.StartDate =  matchedRecord.StartDate ?? DateTime.Today;
                    existingIncome.EndDate = matchedRecord.EndDate ?? DateTime.Today;

                    existingIncome.Podate = matchedRecord.PODate;



                    existingIncome.ProductId = matchedRecord.ProductID;
                    existingIncome.AimId = matchedRecord.AimID;
                    existingIncome.Actual = matchedRecord.Actual;
                    existingIncome.Completed = matchedRecord.Completed;
                    existingIncome.Pe = matchedRecord.PE;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.Confidential = matchedRecord.Confidential;
                    existingIncome.Notes = matchedRecord.Description;
                    existingIncome.TaxCodeId = matchedRecord.TAXRateID ==0 ? null: (int?)matchedRecord.TAXRateID;
                    existingIncome.WorkOrderId = matchedRecord.WorkOrder;
                    existingIncome.Budget = matchedRecord.BudgetNet;
                    existingIncome.Forecast = matchedRecord.ForecastNet;
                    existingIncome.FundingStatusId = matchedRecord.FundingStatusID;
                    existingIncome.Pono = matchedRecord.PONo;
                    

                    existingIncome.Grn = matchedRecord.GRN;
                    existingIncome.CptNo = matchedRecord.CptNo;
                    existingIncome.Emc = matchedRecord.EMC;
                    existingIncome.Rpi = matchedRecord.RPI;
                    existingIncome.PesticideRecord = matchedRecord.PesticideRecord;


                    existingIncome.Wsp = matchedRecord.WSP;
                    existingIncome.Dtp = matchedRecord.DTP;
                    existingIncome.Pipeline = matchedRecord.Pipeline;
                    existingIncome.Pe = matchedRecord.PE;
                    existingIncome.Chalara = matchedRecord.Chalara;
                    existingIncome.OpsGrantAided = matchedRecord.OpsGrantAided;
                    existingIncome.VolunteerWork = matchedRecord.VolunteerWork;
                    existingIncome.Budget = matchedRecord.Budget;
                    existingIncome.Forecast = matchedRecord.Forecast;
                    existingIncome.Completed = matchedRecord.Completed;


                    //existingIncome.Lmdt = matchedRecord.LMDT;




                    existingIncome.Crdt = matchedRecord.CRDT;
                    existingIncome.Dldt = matchedRecord.DLDT;
                    existingIncome.Ulmdt = matchedRecord.ULMDT;


                    existingIncome.Lmuid = matchedRecord.LMUID.GetValueOrDefault();                    
                    existingIncome.Cruid = matchedRecord.CRUID;                    
                    existingIncome.Dluid = matchedRecord.DLUID;                    
                    existingIncome.Ulmuid = matchedRecord.ULMUID;

                }

                if (deletedRecords.Any(f => f == existingIncome.Id))
                {
                    existingIncome.Deleted = true;
                }
            }


            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.Expenditure()
            {            
                Kind = "",
                GroupGuid = null,
                ManagementUnitId = managementId,
                ManagementUnit = Context.ManagementUnit.FirstOrDefault(f=>f.Id == managementId),
                Project = false,
                WorkOrderId= nr.WorkOrder,
                ProductId = nr.ProductID,
                AimId = nr.AimID,
                Notes = nr.Description,
               
                Budget = nr.Budget,
                //ClmdInvd = 0,
                Forecast = nr.Forecast,
                LastMonthForecast = 0.0,
                Actual = nr.Actual,
                TenderPrice = 0.0,
                Grn = nr.GRN,
                CptNo = nr.CptNo,
                Emc = nr.EMC,
                PesticideRecord = nr.PesticideRecord,
                Emcspec = nr.EMCSpecification,
                Wsp = nr.WSP,
                Dtp = nr.DTP,
                Pe = nr.PE,
                Pipeline = nr.Pipeline,
                FundingStatusId = Context.FundingStatus.First().Id,
                Pono = nr.PONo,
               
                TenderId = nr.TenderId==0? null : (int?)nr.TenderId,
                TaxCodeId =  nr.TAXRateID ==0 ? null : (int?)nr.TAXRateID,
                AccountingYear = 0,
                Rpi = nr.RPI,
                Confidential = nr.Confidential,
                OpsGrantAided = nr.OpsGrantAided,
                Completed = nr.Completed,
                Chalara = nr.Chalara,
                VolunteerWork = nr.VolunteerWork,
                Cancelled = false,
                NoSync = false,

                NumberOfTrees = null,
                NumberOfTreesOrigin = null,
                CostPerTree = null,
                TreeSupplierId = null,
                WcexpenditureId = null,
                ProvenanceZoneId = null,
                PlantTypeId = null,
                GrownMethodId = null,
                
                Deleted = false,
                IsProtected = false,
                IsHistorical = false,
                IsDefaultValue = false,

                StartDate = nr.StartDate ?? DateTime.Today,
                EndDate = nr.EndDate ?? DateTime.Today,
            //    ActualDate = DateTime.Today,
                Podate =  nr.PODate,


                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Cruid = currentUserId,
                Crdt = DateTime.Today,
                Dldt = DateTime.Today,
                Dluid = currentUserId,
                Ulmdt = DateTime.Today,
                Ulmuid = currentUserId
            }).ToList();

            Context.AddRange(recordsToAdd);

            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TenderDto> GetTenders()
        {
            var tender = Context.Tender.Where(t => !t.Deleted).Select(s=>new TenderDto()
            {
                Id = s.Id,
                TenderNumber = s.Number
            }).ToList();

            return tender;
        }

        public List<SupplierDto> GetSuppliers()
        {
            var tender = Context.Supplier.Where(t => !t.Deleted && t.Suppcat!=null).Select(s => new SupplierDto()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Address = s.Address,
                Category = s.Suppcat,
                Group = s.Suppgrp,
                Town = s.Town,
                PostCode = s.PostalNo
            }).ToList();

            return tender;
        }

        public void AddToTender(int tenderId, List<int> expenditureIds)
        {
            var exps = Context.Expenditure.Where(w => expenditureIds.Contains(w.Id));

            foreach (var e in exps)
            {
                e.TenderId = tenderId;
            }

            Context.SaveChanges();
        }

        public void RemoveFromTender(int tenderId, List<int> expenditureIds)
        {
            var exps = Context.Expenditure.Where(w => expenditureIds.Contains(w.Id));

            foreach (var e in exps)
            {
                e.TenderId = null;
            }

            Context.SaveChanges();
        }
    }
}
