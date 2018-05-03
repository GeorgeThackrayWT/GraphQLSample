using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDC_Estate.Models.DB;
using EDCORE.ViewModel;
using Utils;


namespace EFStores
{
    public class GrantEFStore : BaseEFStore, IGrantStore
    {
        
        public List<GrantContractEditorDto> GetGrantContract(int managementUnitID)
        {
            var results = new List<GrantContractEditorDto>();

            if (managementUnitID == 0) return results;


            var mu = Context.ManagementUnit.FirstOrDefault(m => m.Id == managementUnitID && m.ManagementPlanId!=null);

            if (mu != null)
            {
                var planid = mu.ManagementPlanId.GetValueOrDefault();

                var grants = Context.Grant.Where(g => g.ManagementPlanId == planid && !g.Deleted);
                
                if (grants.Any())
                {
                    foreach (var g in grants)
                    {
                        var gc = new GrantContractEditorDto
                        {
                            Id = g.Id,
                            GrantBodyId = g.GrantBodyId,
                            ClumpedWithId = g.ClumpedWithId.GetValueOrDefault(),
                            ClumpedWith = g.IsClumpedContract,
                            Contract = g.IsMainContract,
                            EndDate = g.EndDate,
                            StartDate = g.StartDate,
                            Reference = g.Reference,
                            Notes = g.Comments,
                            GrantPeriod = g.StartDate.ToShortDateString()+ " to " + g.EndDate.ToShortDateString(),
                            MainContract = g.IsMainContract,
                            SchemeId = g.SchemeId
                        };

                        results.Add(gc);
                    }
                }
                //else
                //{
                //    var gc = new GrantContractEditorDto { };

                //    results.Add(gc);
                //}

            }

            return results;
        }

        public List<PaymentSummaryDTO> GetGrantPayments(int grantId)
        {
            var payments = Context.Income.Where(x => x.GrantId == grantId);

            var paymentList = new List<PaymentSummaryDTO>();

            foreach (var p in payments)
            {
             
                paymentList.Add(new PaymentSummaryDTO()
                {
                    GrantId = grantId,
                    Actual = p.Actual,
                    Budget = p.Budget,
                    Claimed = p.ClmdInvd,
                    Forecast = p.Forecast,
                    Year = p.Sodate,
                    Id = p.Id
                });
            }
            return paymentList;
        }

        public List<GrantContractsListDTO> GetGrantContractsListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {  
            string magicString = "SELECT        mu.ID AS ManagementUnitID, SUM(CASE WHEN i.Forecast IS NOT NULL AND i.TaxCodeID IS NOT NULL THEN i.Forecast + i.Forecast * tc.TaxRate ELSE i.Forecast END) AS TotalForecast, SUM(i.ClmdInvd) AS TotalClaimed, \r\n                         SUM(i.Actual) AS TotalActual, MAX(g.DateCompleted) AS LastChecked, MAX(g.DateAuthorised) AS LastAuthorised, MAX(g.LMDT) AS LastAmended\r\nFROM            dbo.ManagementUnit AS mu INNER JOIN\r\n                         dbo.ManagementPlan AS mp ON mp.ID = mu.ManagementPlanID LEFT OUTER JOIN\r\n                         dbo.[Grant] AS g ON mp.ID = g.ManagementPlanID AND g.Deleted = 0 LEFT OUTER JOIN\r\n                         dbo.Income AS i ON g.ID = i.GrantID LEFT OUTER JOIN\r\n                         dbo.TaxCode AS tc ON tc.ID = i.TaxCodeID LEFT OUTER JOIN\r\n                         dbo.IncomeProduct AS p ON p.ID = i.ProductID\r\nWHERE        (p.ID IS NULL) OR\r\n                         (p.ID NOT IN (51, 52, 53, 54))\r\nGROUP BY mu.ID";

            
            var data = ExecSQL<GrantContractsListDTO>(magicString, Context);


            foreach (var d in data)
            {
                var manu = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID);


                if (manu != null)
                {
                    d.RegionId = manu.RegionId.GetValueOrDefault();
                    d.ApplicationId = manu.ApplicationId;
                    d.WoodlandOfficerID = manu.WoodlandOfficerId;
                    d.DeputyID = manu.DeputyId.GetValueOrDefault();
                    d.AcquisitionOfficerID = _cache.AcquisitionOfficerLookup.ContainsKey(manu.Id) ? _cache.AcquisitionOfficerLookup[manu.Id] :0 ;
                }

                d.WoodlandOfficerId = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID)?.WoodlandOfficerId;
                d.Name = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID)?.Name;
            }

            foreach (var d in data)
            {
          
                d.CostCentre = d.ManagementUnitID;
                d.Region = RegionName(d.RegionId);
                d.Manager = UserName(d.WoodlandOfficerId);
                d.Name =d.Name == "" ? "Name not entered" :d.Name;
                d.LastAmended = d.LastAmended.Validate();
                d.LastAuthorised = d.LastAuthorised.Validate();
                d.LastChecked = d.LastChecked.Validate();
            }
            
            return data.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public void UpdatePayments(List<PaymentSummaryDTO> payments, int managementUnitId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var incomes = Context.Income.Where(e => !e.Deleted && e.ManagementUnitId == managementUnitId);

            List<int> editSetIds = payments.Select(i => i.Id).ToList();
            List<int> existingRecordIds = incomes.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in incomes
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = payments.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();

            foreach (var income in incomes)
            {
                var matchedRecord = payments.FirstOrDefault(f => f.Id == income.Id);

           
                if (matchedRecord != null)
                {                   
                    income.Sodate = matchedRecord.Year;
                    income.Budget = matchedRecord.Budget.GetValueOrDefault();
                    income.Forecast = matchedRecord.Forecast.GetValueOrDefault();
                    income.ClmdInvd = matchedRecord.Claimed.GetValueOrDefault();
                    income.Actual = matchedRecord.Actual;
                }

                if (deletedRecords.Any(f => f == income.Id))
                {
                    income.Deleted = true;
                    income.Dldt = DateTime.Today;
                    income.Dluid = currentUserId;
                }
            }

            //you cant add payments here

        }

        public void UpdateGrants(List<GrantContractEditorDto> grants, int managementUnitId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            

            var mu = Context.ManagementUnit.FirstOrDefault(m => m.Id == managementUnitId && m.ManagementPlanId != null);

            var existingGrants = Context.Grant.Where(e => !e.Deleted && e.ManagementPlanId == mu.ManagementPlanId);

            List<int> editSetIds = grants.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingGrants.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingGrants
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = grants.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            foreach (var existingGrant in existingGrants)
            {
                var matchedRecord = grants.FirstOrDefault(f => f.Id == existingGrant.Id);


                if (matchedRecord != null)
                {
                    existingGrant.ArchivedById = matchedRecord.ArchivedBy == 0 ? null : (int?) matchedRecord.ArchivedBy;
                    existingGrant.ArchivedBy = Context.User.FirstOrDefault(f => f.Id == matchedRecord.ArchivedBy);
                    existingGrant.Archived = matchedRecord.ArchivedBy != 0;
                    existingGrant.AuthorisedById = matchedRecord.AuthorisedBy == 0 ? null : (int?)matchedRecord.AuthorisedBy;
                    existingGrant.AuthorisedBy = Context.User.FirstOrDefault(f => f.Id == matchedRecord.AuthorisedBy);
                    existingGrant.Authorised = matchedRecord.AuthorisedBy != 0;
                    existingGrant.ClumpedWithId = matchedRecord.ClumpedWithId == 0 ? null : (int?)matchedRecord.ClumpedWithId;
                  //  existingGrant.ClumpedWith = Context.Grant.First(f => f.Id == matchedRecord.ClumpedWithId);
                    existingGrant.Comments = matchedRecord.Notes;
                    existingGrant.GrantBodyId = matchedRecord.GrantBodyId;
                    existingGrant.SchemeId = matchedRecord.SchemeId;
                    existingGrant.Reference = matchedRecord.Reference;
                    existingGrant.StartDate = matchedRecord.StartDate.GetValueOrDefault();
                    existingGrant.EndDate = matchedRecord.EndDate.GetValueOrDefault();
                    existingGrant.IsMainContract = matchedRecord.MainContract;
                    existingGrant.IsClumpedContract = matchedRecord.ClumpedWithId != 0;
                    


                }

                if (deletedRecords.Any(f => f == existingGrant.Id))
                {
                    existingGrant.Deleted = true;
                    existingGrant.Dldt = DateTime.Today;
                    existingGrant.Dluid = currentUserId;
                }
            }

            var defaultGrant = Context.GrantBody.First(i => i.Id != 0);
            var defaultAward = Context.AwardingScheme.First(i => i.Id != 0);


            var recordsToAdd = newRecords.Select(nr => new Grant()
            {
                ArchivedById = nr.ArchivedBy == 0 ? null : (int?)nr.ArchivedBy,
            //    ArchivedBy = Context.User.FirstOrDefault(f => f.Id == nr.ArchivedBy),
                Archived = nr.ArchivedBy != 0,
                AuthorisedById = nr.AuthorisedBy == 0 ? null : (int?)nr.AuthorisedBy,
               // AuthorisedBy = Context.User.FirstOrDefault(f => f.Id == nr.AuthorisedBy),
                Authorised = nr.AuthorisedBy != 0,
                ClumpedWithId = nr.ClumpedWithId == 0 ? null : (int?)nr.ClumpedWithId,
              //  ClumpedWith = Context.Grant.First(f => f.Id == nr.ClumpedWithId),
                ManagementPlanId = mu.ManagementPlanId.GetValueOrDefault(),

                Comments = nr.Notes,

                GrantBodyId = nr.GrantBodyId ==0 ? defaultGrant.Id : nr.GrantBodyId,
                SchemeId = nr.SchemeId ==0 ? defaultAward.Id : nr.SchemeId,

                Reference = nr.Reference,
                StartDate = nr.StartDate.GetValueOrDefault(),
                EndDate = nr.EndDate.GetValueOrDefault(),
                IsMainContract = nr.MainContract,
                IsClumpedContract = nr.ClumpedWithId != 0,
                Completed = false,
                
                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }

 

        public GrantEFStore(EstateContext ec,ICache iCache, IUserStore iUserStore) : 
            base(ec,iCache)
        {
            _iUserStore = iUserStore;
        }
    }
}
