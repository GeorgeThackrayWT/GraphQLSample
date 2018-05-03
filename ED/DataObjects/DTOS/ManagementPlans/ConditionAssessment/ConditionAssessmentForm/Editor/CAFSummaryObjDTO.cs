namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CAFSummaryObjDTO
    {
        public int ID { get; set; }
        public int FeatureMonitoringID { get; set; }

        public int WoodlandConditionSubSectionID { get; set; }

        public bool WholeSite { get; set; }

        public int KeyFeatureID { get; set; }

        public int StratumID { get; set; }

        public int NoOfPlots { get; set; }
        
        public string StratumDescription { get; set; }

        public string FeatureDescription { get; set; }

        public bool? OverallInterventionDesirable { get; set; }
        public bool? OverallInterventionAchievable { get; set; }
        public string OverallConclusionsAndRecommendations { get; set; }
        
        public bool? InterventionDesirable { get; set; }
        public bool? InterventionAchievable { get; set; }
        public string NotesAction { get; set; }
        
        public bool TAInterventionDesirable { get; set; }
        public bool TAInterventionAchievable { get; set; }
        public string TANotesActions { get; set; }
        
        public bool TSInterventionDesirable { get; set; }
        public bool TSInterventionAchievable { get; set; }
        public string TSNotesActions { get; set; }
        
        public bool SSInterventionDesirable { get; set; }
        public bool SSInterventionAchievable { get; set; }
        public string SSNotesActions { get; set; }
        
        public bool LTRInterventionDesirable { get; set; }
        public bool LTRInterventionAchievable { get; set; }
        public string LTRNotesActions { get; set; }
     
        public bool LSRInterventionDesirable { get; set; }
        public bool LSRInterventionAchievable { get; set; }
        public string LSRNotesActions { get; set; }
    
        public bool RTSInterventionDesirable { get; set; }
        public bool RTSInterventionAchievable { get; set; }
        public string RTSNotesActions { get; set; }

        public bool RSSInterventionDesirable { get; set; }
        public bool RSSInterventionAchievable { get; set; }
        public string RSSNotesActions { get; set; }
 
        public bool FInterventionDesirable { get; set; }
        public bool FInterventionAchievable { get; set; }
        public string FNotesActions { get; set; }

        public bool DInterventionDesirable { get; set; }
        public bool DInterventionAchievable { get; set; }
        public string DNotesActions { get; set; }
        
        public bool ADInterventionDesirable { get; set; }
        public bool ADInterventionAchievable { get; set; }
        public string ADNotesActions { get; set; }
      
        public bool IInterventionDesirable { get; set; }
        public bool IInterventionAchievable { get; set; }
        public string INotesActions { get; set; }

        public bool THInterventionDesirable { get; set; }
        public bool THInterventionAchievable { get; set; }
        public string THNotesActions { get; set; }
     
        public bool HIInterventionDesirable { get; set; }
        public bool HIInterventionAchievable { get; set; }
        public string HINotesActions { get; set; }


    }
}