using System;

namespace EDC_Estate.Models.DB
{
    public partial class Harvesting
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int ManagementUnitId { get; set; }
        public int SubCompartmentId { get; set; }
        public double WorkAreaInHectares { get; set; }
        public double EstimatedAmount { get; set; }
        public double? ActualAmount { get; set; }
        public string Unit { get; set; }
        public int? ForecastYear { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
        public bool Deleted { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual SubCompartment SubCompartment { get; set; }
        public virtual HarvestingOperationType Type { get; set; }
    }
}
