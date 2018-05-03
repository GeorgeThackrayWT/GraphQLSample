using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class FeatureMonitoring
    {
        public FeatureMonitoring()
        {
            WoodlandConditionExtension = new HashSet<WoodlandConditionExtension>();
            WoodlandConditionSubSection = new HashSet<WoodlandConditionSubSection>();
        }

        public int Id { get; set; }
        public int FeatureId { get; set; }
        public DateTime PlannedObservationDate { get; set; }
        public DateTime? ActualObservationDate { get; set; }
        public DateTime? DeadlineActionDate { get; set; }
        public DateTime? ActualActionDate { get; set; }
        public string AttributeToBeMeasured { get; set; }
        public string PredictionShortTermObjective { get; set; }
        public string PlannedObservation { get; set; }
        public string ActualObservation { get; set; }
        public string SuggestionsAndActions { get; set; }
        public int? LowerLimit { get; set; }
        public int? UpperLimit { get; set; }
        public string Method { get; set; }
        public int? TargetValue { get; set; }
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

        public virtual ICollection<WoodlandConditionExtension> WoodlandConditionExtension { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSection { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual User Lmu { get; set; }
    }
}
