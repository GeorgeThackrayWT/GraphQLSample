namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CafkfSummary
    {
        public int WoodlandConditionSubSectionId { get; set; }
         
        public bool OverallInterventionDesirable { get; set; }

        public bool OverallInterventionAchievable { get; set; }

        public string OverallConclusionsAndRecommendations { get; set; }

        public string Description { get; set; }

    }
}