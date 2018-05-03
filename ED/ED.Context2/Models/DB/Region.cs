using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Region
    {
        public Region()
        {
            ManagementUnit = new HashSet<ManagementUnit>();
            MapUrl = new HashSet<MapUrl>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DocuwareName { get; set; }
        public bool ForecastApproved { get; set; }
        public DateTime? DateForecastApproved { get; set; }
        public int CountryId { get; set; }
        public string ResNo { get; set; }
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

        public virtual ICollection<ManagementUnit> ManagementUnit { get; set; }
        public virtual ICollection<MapUrl> MapUrl { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual Country Country { get; set; }
        public virtual User Lmu { get; set; }
    }
}
