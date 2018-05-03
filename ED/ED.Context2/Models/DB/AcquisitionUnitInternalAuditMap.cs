using System;

namespace EDC_Estate.Models.DB
{
    public partial class AcquisitionUnitInternalAuditMap
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int InternalAuditId { get; set; }
        public bool Deleted { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual InternalAudit InternalAudit { get; set; }
        public virtual User Lmu { get; set; }
    }
}
