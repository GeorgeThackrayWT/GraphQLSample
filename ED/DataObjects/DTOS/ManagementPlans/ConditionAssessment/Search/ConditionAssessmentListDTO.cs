using System;

namespace DataObjects
{
    
    public class ConditionAssessmentListDTO : SearchBase
    {     
        public DateTime? NextAssessmentDate { get; set; }

        public bool WholeSite { get; set; }

        public int NoOfStrata { get; set; }

        public int TotalNoOfPlots { get; set; }

        public int DesirableInterventions { get; set; }

        public int AchievableInterventions { get; set; }

        public int NoOfConditionsAssessments { get; set; }

    }
    
}