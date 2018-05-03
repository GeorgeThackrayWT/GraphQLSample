using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Feature
    {
        public Feature()
        {
            FeatureMonitoring = new HashSet<FeatureMonitoring>();
            WoodlandConditionSubSection = new HashSet<WoodlandConditionSubSection>();
        }

        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public string Reference { get; set; }
        public string OtherTypeDescription { get; set; }
        public int? TypeId { get; set; }
        public int? AimId { get; set; }
        public string Description { get; set; }
        public bool Confidential { get; set; }
        public string BiodiversityActionPlans { get; set; }
        public string ConstraintsAndOpportunities { get; set; }
        public string ShortTermObjective { get; set; }
        public string LongTermObjective { get; set; }
        public string OtherCostedHabitatActionPlans { get; set; }
        public bool? AppliesToEntireSite { get; set; }
        public string Significance { get; set; }
        public string FactorsCausingChange { get; set; }
        public bool WoodProduction { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<FeatureMonitoring> FeatureMonitoring { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSection { get; set; }
        public virtual Aim Aim { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual FeatureType Type { get; set; }
    }
}
