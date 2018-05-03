using System;

namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminGeneralDetailsDto
    {
        public int ConfigID { get; set; }

        public DateTime CurrentYear { get; set; }

        public bool IsBudgetLocked { get; set; }

        public bool IsBudgetLockedForFutureYears { get; set; }

        public DateTime? DoNotShowTasksBefore { get; set; }

        public DateTime? DoNotShowSafetyTasksBefore { get; set; }

        public DateTime? DoNotShowTreePlantingTasksBefore { get; set; }

        public DateTime? StartDateCutOff { get; set; }
    }
}
