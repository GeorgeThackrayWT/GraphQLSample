using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using Stores;
using Utils;

namespace SQLite
{
    public class GrantStore : BaseStore, IGrantStore
    {
        public GrantStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }
        
        public List<GrantContractsListDTO> GetGrantContractsListDtos()
        {
            //todo rewrite as c#
            // obviously magic strings like this are extremely bad practice for obvious reasons
            // but need alot of time to figure out all this sql which dont currently have.
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetGrantContractsListDtos started");


            string qryString = "SELECT        mu.ID AS ManagementUnitID, " +
                               "\r\nSUM(CASE WHEN i.Forecast IS NOT NULL AND i.TaxCodeID IS NOT NULL THEN i.Forecast + i.Forecast * tc.TaxRate ELSE i.Forecast END) AS TotalForecast, " +
                               "\r\nSUM(i.ClmdInvd) AS TotalClaimed, " +
                               "\r\nSUM(i.Actual) AS TotalActual, " +
                               "\r\nMAX(g.DateCompleted) AS LastChecked, " +
                               "\r\nMAX(g.DateAuthorised) AS LastAuthorised, " +
                               "\r\nMAX(g.LMDT) AS LastAmended" +
                               "\r\n\r\nFROM            ManagementUnit AS mu INNER JOIN" +
                               "\r\n                         ManagementPlan AS mp ON mp.ID = mu.ManagementPlanID LEFT OUTER JOIN" +
                               "\r\n                         [Grant] AS g ON mp.ID = g.ManagementPlanID AND g.Deleted = 0 LEFT OUTER JOIN" +
                               "\r\n                         Income AS i ON g.ID = i.GrantID LEFT OUTER JOIN\r\n                         TaxCode AS tc ON tc.ID = i.TaxCodeID LEFT OUTER JOIN" +
                               "\r\n                         IncomeProduct AS p ON p.ID = i.ProductID\r\nWHERE        (p.ID IS NULL) OR\r\n                         (p.ID NOT IN (51, 52, 53, 54))" +
                               "\r\nGROUP BY mu.ID";

            var data = _sqLiteSyncConnection.Query<GrantContractsListDTO>(qryString).ToList();

            foreach (var d in data)
            {
                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == d.ManagementUnitID);
                //   d.ManagementUnitID = manu.ID;
                d.CostCentre = manu.Id;
                d.Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()];
                d.Manager = _iCache.UserLookup[manu.WoodlandOfficerId];
                d.Name = manu.Name;
                d.LastAmended = d.LastAmended.Validate();
                d.LastAuthorised = d.LastAuthorised.Validate();
                d.LastChecked = d.LastChecked.Validate();
            }

            stopwatch.Stop();

            Debug.WriteLine("GetGrantContractsListDtos ended in: " + stopwatch.ElapsedMilliseconds);
            return data.OrderBy(o=>o.Name).ToList();
        }

        public List<GrantContractEditorDto> GetGrantContract(int managementUnitID)
        {
            var results = new List<GrantContractEditorDto>();

            if (managementUnitID == 0) return results;


            var mu = _iCache.ManagementUnits.First(m => m.Id == managementUnitID);

            if (mu != null)
            {

                var planid = mu.ManagementPlanId.GetValueOrDefault();

                var grants = _sqLiteSyncConnection.Table<Grant>()
                    .Where(g => g.ManagementPlanID == planid);

                if (grants.Count() > 0)
                {
                    foreach (var g in grants)
                    {
                        var gc = new GrantContractEditorDto
                        {
                            GrantBodyId = g.GrantBodyID,
                           
                            ClumpedWith = g.IsClumpedContract,
                            Contract = g.IsMainContract,
                            EndDate = g.EndDate,
                            StartDate = g.StartDate,
                            Reference = g.Reference,
                            Notes = g.Comments,
                            GrantPeriod = g.StartDate.ToString() + " to " + g.EndDate.ToString(),
                            MainContract = g.IsMainContract,
                            SchemeId = g.SchemeID
                        };

                        //var payments =
                        //    _sqLiteSyncConnection.Query<Income>(
                        //        "SELECT ID, Actual, Forecast,ClmdInvd, Budget, GrantID FROM Income WHERE GrantID = " +
                        //        g.ID);

                        //var paymentList = new List<PaymentSummaryDTO>();

                        //foreach (var p in payments)
                        //{

                        //    var year = p.SODate.GetValueOrDefault().Year;

                        //    paymentList.Add(new PaymentSummaryDTO()
                        //    {
                        //        Actual = p.Actual,
                        //        Budget = p.Budget,
                        //        Claimed = p.ClmdInvd,
                        //        Forecast = p.Forecast,
                        //        Year = year,
                        //        PaymentID = p.ID
                        //    });


                        //}





                        //gc.PaymentSummaryList = paymentList;

                        results.Add(gc);
                    }
                }
                else
                {
                    var gc = new GrantContractEditorDto{ };

                    results.Add(gc);
                }

            }

            return results;
        }

        public List<PaymentSummaryDTO> GetGrantPayments(int grantId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePayments(List<PaymentSummaryDTO> payments, int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateGrants(List<GrantContractEditorDto> grants, int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<GrantContractsListDTO> GetGrantContractsListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}