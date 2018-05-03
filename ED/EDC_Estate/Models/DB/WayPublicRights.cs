using System;

namespace EDC_Estate.Models.DB
{
    public partial class WayPublicRights
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public bool HasBridleway { get; set; }
        public string BridlewayDescription { get; set; }
        public bool HasFootpath { get; set; }
        public string FootpathDescription { get; set; }
        public bool HasOther { get; set; }
        public string OtherDescription { get; set; }
        public string Comments { get; set; }
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

        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual User Lmu { get; set; }
    }
}
