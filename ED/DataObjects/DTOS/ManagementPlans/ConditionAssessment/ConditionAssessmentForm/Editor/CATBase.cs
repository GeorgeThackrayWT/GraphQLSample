namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public abstract class CATBase
    {

        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

    }
}