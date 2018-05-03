using System;

namespace EDC_Estate.Models.DB
{
    public partial class SubCompartmentDesignationMap
    {
        public int Id { get; set; }
        public int DesignationId { get; set; }
        public int SubCompartmentId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual SubCompartment SubCompartment { get; set; }
    }
}
