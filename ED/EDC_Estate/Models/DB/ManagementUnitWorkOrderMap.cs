using System;

namespace EDC_Estate.Models.DB
{
    public partial class ManagementUnitWorkOrderMap
    {
        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public int WorkOrderId { get; set; }
        public bool Deleted { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
