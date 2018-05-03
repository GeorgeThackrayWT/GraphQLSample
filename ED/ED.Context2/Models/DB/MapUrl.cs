using System;

namespace EDC_Estate.Models.DB
{
    public partial class MapUrl
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int RegionId { get; set; }
        public string Url { get; set; }
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

        public virtual User Lmu { get; set; }
        public virtual Region Region { get; set; }
        public virtual MapUrlType Type { get; set; }
    }
}
