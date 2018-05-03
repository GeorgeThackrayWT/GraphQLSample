using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Attribute
    {
        public Attribute()
        {
            ManagementUnitAttribute = new HashSet<ManagementUnitAttribute>();
        }

        public int Id { get; set; }
        public int Priority { get; set; }
        public bool IsSpecial { get; set; }
        public long Mask { get; set; }
        public string Category { get; set; }
        public string IconFileName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<ManagementUnitAttribute> ManagementUnitAttribute { get; set; }
    }
}
