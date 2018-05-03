using System.Collections.Generic;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CafkfSummaries
    {
        public int FeatureMonitoringId { get; set; }

        public List<CafkfSummary> SummariesList { get; set; }

        public CafkfSummary OverallSummary { get; set; }

    }
}