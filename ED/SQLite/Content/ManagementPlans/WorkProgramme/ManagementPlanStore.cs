using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using EDCORE.ViewModel;
using SQLite.DataTypes;
using Stores;
using SQLite.Net;

namespace SQLite
{
    public class ManagementPlanStore : BaseStore, IManagementPlanStore
    {
        public ManagementPlanStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }


     
      
        public List<WorkProgrammeListDTO> GetWorkProgrammeListDtos()
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetWorkProgrammeListDtos started");

            List<WorkProgramCollation> collationCollection = new List<WorkProgramCollation>();

            foreach (var e in _iCache.Expenditures)
            {
                collationCollection.Add(new WorkProgramCollation
                {
                    ID = e.ID,
                    T=false,
                    ManagementUnitID = e.ManagementUnitID,
                    Completed = e.Completed,
                    Forecast = e.Forecast,
                    Actual = e.Actual,
                    Budget = e.Budget,
                   // Ordered_ClmdInvd = e.ClmdInvd,
                    EMC = e.EMC,
                    EndDate = e.EndDate,
                    FundingStatusID = e.FundingStatusID,
                    PE = e.PE,
                    PesticideRecord = e.PesticideRecord,
                    ProductID = e.ProductID,
                    Project = e.Project,
                    TaxCodeID = e.TaxCodeID,
                    WSP = e.WSP,
                    WorkOrderID = e.WorkOrderID
                });                
            }

            foreach (var e in _iCache.Incomes)
            {
                collationCollection.Add(new WorkProgramCollation
                {
                    ID = e.Id,
                    T=true,
                    ManagementUnitID = e.ManagementUnitId,
                    Completed = e.Completed,
                    Forecast = e.Forecast,
                    Actual = e.Actual,
                 
                    Budget = e.Budget,
                    Ordered_ClmdInvd = e.ClmdInvd,
                    EMC = false,
                    EndDate = e.EndDate.GetValueOrDefault(),
                    FundingStatusID = 0,
                    PE = e.Pe,
                    PesticideRecord = false,
                    ProductID = e.ProductId,
                    Project = e.IsProject,
                    TaxCodeID = e.TaskCodeId,
                    WSP = false,
                    WorkOrderID = e.WorkOrder
                });
            }

            var firstDayThisYear = new DateTime(DateTime.Now.Year, 1, 1);
            var firstDayOneYear = new DateTime(DateTime.Now.Year +1, 1, 1);
            var firstDayFiveYear = new DateTime(DateTime.Now.Year + 5, 1, 1);

            var retData2 = new List<WorkProgrammeListDTO>();
            foreach (var group in collationCollection.GroupBy(m => m.ManagementUnitID))
            {
                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == group.Key);

                var fiveYearExpenditureForecast =
                    group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayFiveYear).Sum(s => s.Forecast);

                var fiveYearIncomeForecast =
                    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayFiveYear).Sum(s => s.Forecast);

                var thisYearExpenditureForecast =
                   group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Forecast);

                var thisYearIncomeForecast =
                    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Forecast);

                //var thisYearExpenditureBudget =
                //    group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Budget);

                //var thisYearExpenditureEMCForecast =
                //    group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear && a.EMC).Sum(s => s.Forecast);

                //var thisYearExpenditureActual =
                //    group.Where(a => !a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Actual);

                //double taxForecast = 0;
                //double actual = 0;

                //taxForecast = GetExpend(@group, firstDayThisYear, firstDayOneYear, taxRates, taxForecast, ref actual);

                //var thisYearExpenditureRemaining = taxForecast - actual;



                //var thisYearIncomeBudget =
                //    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Budget);

                //var thisYearIncomeActual =
                //    group.Where(a => a.T && a.EndDate > firstDayThisYear && a.EndDate <= firstDayOneYear).Sum(s => s.Actual);


                //taxForecast = GetIncome(@group, firstDayThisYear, firstDayOneYear, taxRates, taxForecast, ref actual);

                //var thisYearIncomeRemaining = taxForecast - actual;

                var EMC = group.Any(a => !a.T && a.EMC);

                var PRS = group.Any(a => !a.T && a.PesticideRecord);

                var FundingOpportunity = group.Any(a => !a.T && (a.FundingStatusID == 2 || a.FundingStatusID ==3));

                var ProjectExpenditure = group.Any(a => !a.T && a.Project);

                var ProjectIncome = group.Any(a => a.T && a.Project);

                var WSP = group.Any(a => !a.T && a.WSP);

                var PE = group.Any(a => !a.T && a.PE);

                retData2.Add(new WorkProgrammeListDTO()
                {
                    ManagementUnitID = group.Key,
                    WSP = WSP,
                    CostCentre =  group.Key,
                    Name = manu.Name,
                    EMC = EMC,
                    FundingOpportunity = FundingOpportunity,
                    PE = PE,
                    Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                    PRS = PRS,
                    Year5Expenditure = fiveYearExpenditureForecast.GetValueOrDefault(),
                    Year5Income = fiveYearIncomeForecast.GetValueOrDefault(),
                    Year5Net = fiveYearIncomeForecast.GetValueOrDefault() - fiveYearExpenditureForecast.GetValueOrDefault(),

                    YearXExpenditure = thisYearExpenditureForecast.GetValueOrDefault(),
                    YearXIncome = thisYearIncomeForecast.GetValueOrDefault(),
                    YearXNet = thisYearIncomeForecast.GetValueOrDefault() - thisYearExpenditureForecast.GetValueOrDefault(),
                    Project = ProjectExpenditure || ProjectIncome
                });

            }

            stopwatch.Stop();

            Debug.WriteLine("GetWorkProgrammeListDtos ended in: " + stopwatch.ElapsedMilliseconds);
            
            return retData2;
        }

        public List<WorkProgrammeListDTO> GetWorkProgrammeListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }

}
