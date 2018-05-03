using System;

namespace EDC_Estate.Models.DB
{
    public partial class MajorManagementConstraintMap
    {
        public int Id { get; set; }
        public int MajorManagementConstraintTypeId { get; set; }
        public int SubCompartmentId { get; set; }
        public bool? Confidential { get; set; }
        public bool Deleted { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual MajorManagementConstraint MajorManagementConstraint { get; set; }
        public virtual SubCompartment SubCompartment { get; set; }
    }
}
