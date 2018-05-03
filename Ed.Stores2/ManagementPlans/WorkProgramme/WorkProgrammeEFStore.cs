using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.ManagementPlans.WorkProgramme
{
    public class WorkProgramCollation
    {

        public int Id { get; set; }

        public bool T { get; set; }

        public string Name { get; set; }

        public int ManagementUnitId { get; set; }
        public bool Project { get; set; }

   
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }

        public System.DateTime EndDate { get; set; }

        public double Budget { get; set; }

        public double? Forecast { get; set; }

        public double? Actual { get; set; }

        public bool Emc { get; set; }
        public bool PesticideRecord { get; set; }

        public bool Wsp { get; set; }

        public bool Pe { get; set; }

        public int FundingStatusId { get; set; }

        public int? TaxCodeId { get; set; }
        

    }

    public class WorkProgrammeEfStore : BaseEFStore, IManagementPlanStore
    {
        public WorkProgrammeEfStore(EstateContext ec,ICache iCache) :
            base(ec,iCache)
        {
        }

        public List<WorkProgrammeListDTO> GetWorkProgrammeListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
       
            List<WorkProgramCollation> collationCollection = new List<WorkProgramCollation>();




            collationCollection.AddRange(Context.Expenditure.Select(e => new WorkProgramCollation
            {
                Id = e.Id,
                T = false,
                ManagementUnitId = e.ManagementUnitId,
                Forecast = e.Forecast,
                Actual = e.Actual,
                Budget = e.Budget,
                Emc = e.Emc,
                EndDate = e.EndDate,
                FundingStatusId = e.FundingStatusId,
                Pe = e.Pe,
                PesticideRecord = e.PesticideRecord,
                ProductId = e.ProductId,
                Project = e.Project,
                TaxCodeId = e.TaxCodeId,
                Wsp = e.Wsp,
                WorkOrderId = e.WorkOrderId
            }).ToList());

            
            collationCollection.AddRange(Context.Income.Select(e => new WorkProgramCollation
            {
                Id = e.Id,
                T = true,
                ManagementUnitId = e.ManagementUnitId,

                Forecast = e.Forecast,
                Actual = e.Actual,

                Budget = e.Budget,
                Emc = false,
                EndDate = e.EndDate,
                FundingStatusId = 0,
                Pe = e.Pe,
                PesticideRecord = false,
                ProductId = e.ProductId,
                Project = e.Project,
                TaxCodeId = e.TaxCodeId,
                Wsp = false,
                WorkOrderId = e.WorkOrderId
            }).ToList());




            var firstDayThisYear = new DateTime(DateTime.Now.Year, 1, 1);
            var firstDayOneYear = new DateTime(DateTime.Now.Year + 1, 1, 1);
            var firstDayFiveYear = new DateTime(DateTime.Now.Year + 5, 1, 1);

            var retData2 = new List<WorkProgrammeListDTO>();
            foreach (var group in collationCollection.GroupBy(m => m.ManagementUnitId))
            {
                var manu = _cache.ManagementUnitDtos.FirstOrDefault(p => p.Id == group.Key);

                var fiveYearExpenditureForecast =
                    group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayFiveYear).Sum(s => s.Forecast);

                var fiveYearIncomeForecast =
                    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayFiveYear).Sum(s => s.Forecast);

                var thisYearExpenditureForecast =
                   group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Forecast);

                var thisYearIncomeForecast =
                    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Forecast);
                

                var emc = group.Any(a => !a.T && a.Emc);

                var prs = group.Any(a => !a.T && a.PesticideRecord);

                var fundingOpportunity = group.Any(a => !a.T && (a.FundingStatusId == 2 || a.FundingStatusId == 3));

                var projectExpenditure = group.Any(a => !a.T && a.Project);

                var projectIncome = group.Any(a => a.T && a.Project);

                var wsp = group.Any(a => !a.T && a.Wsp);

                var pe = group.Any(a => !a.T && a.Pe);

                retData2.Add(new WorkProgrammeListDTO()
                {
                    ManagementUnitID = group.Key,
                    RegionId =manu.RegionId.GetValueOrDefault(),
                    DeputyID = manu.DeputyId.GetValueOrDefault(),
                    WoodlandOfficerID = manu.WoodlandOfficerId,
                    ApplicationId = manu.ApplicationId,
                    WSP = wsp,
                    CostCentre = group.Key,
                    Name = manu.Name == "" ? "No name entered" : manu.Name,
                    EMC = emc,
                    FundingOpportunity = fundingOpportunity,
                    PE = pe,
                    Region = RegionName(manu.RegionId),
                    Manager = UserName(manu.WoodlandOfficerId),
                    PRS = prs,
                    Year5Expenditure = fiveYearExpenditureForecast.GetValueOrDefault(),
                    Year5Income = fiveYearIncomeForecast.GetValueOrDefault(),
                    Year5Net = fiveYearIncomeForecast.GetValueOrDefault() - fiveYearExpenditureForecast.GetValueOrDefault(),

                    YearXExpenditure = thisYearExpenditureForecast.GetValueOrDefault(),
                    YearXIncome = thisYearIncomeForecast.GetValueOrDefault(),
                    YearXNet = thisYearIncomeForecast.GetValueOrDefault() - thisYearExpenditureForecast.GetValueOrDefault(),
                    Project = projectExpenditure || projectIncome
                });

            }
 
            return retData2.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }
    }
}
