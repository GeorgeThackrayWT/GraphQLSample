using System;

namespace EDC_Estate.Models.DB
{
    public partial class ManagementUnitAttribute
    {
        public int AttributeId { get; set; }
        public int ManagementUnitId { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
    }
}
