using System;

namespace EDC_Estate.Models.DB
{
    public partial class HazardFireRisk
    {
        public int Id { get; set; }
        public int HazardId { get; set; }
        public int FireRiskTypeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Cru { get; set; }
        public virtual User Dlu { get; set; }
        public virtual HazardFireRiskType FireRiskType { get; set; }
        public virtual Hazard Hazard { get; set; }
        public virtual User Lmu { get; set; }
    }
}
