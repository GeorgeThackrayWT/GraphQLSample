using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class HazardFireRiskType
    {
        public HazardFireRiskType()
        {
            HazardFireRisk = new HashSet<HazardFireRisk>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int RiskLevel { get; set; }
        public int CategoryId { get; set; }
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

        public virtual ICollection<HazardFireRisk> HazardFireRisk { get; set; }
        public virtual HazardFireRiskCategory Category { get; set; }
        public virtual User Cru { get; set; }
        public virtual User Dlu { get; set; }
        public virtual User Lmu { get; set; }
    }
}
