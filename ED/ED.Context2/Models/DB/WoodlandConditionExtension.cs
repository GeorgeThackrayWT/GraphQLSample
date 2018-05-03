using System;

namespace EDC_Estate.Models.DB
{
    public partial class WoodlandConditionExtension
    {
        public int Id { get; set; }
        public int FeatureMonitoringId { get; set; }
        public double AreaHa { get; set; }
        public double AreaAwha { get; set; }
        public string Surveyor { get; set; }
        public double ChangeInAreaSinceLastSurveyHa { get; set; }
        public double ChangeInAreaAwsinceLastSurveyHa { get; set; }
        public string ConclusionsAndRecommendations { get; set; }
        public bool OverallDesirable { get; set; }
        public bool OverallAchievable { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual FeatureMonitoring FeatureMonitoring { get; set; }
        public virtual User Lmu { get; set; }
    }
}
