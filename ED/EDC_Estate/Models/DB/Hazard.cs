using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Hazard
    {
        public Hazard()
        {
            HazardAction = new HashSet<HazardAction>();
            HazardFireRisk = new HashSet<HazardFireRisk>();
            HazardIncidentHistory = new HashSet<HazardIncidentHistory>();
        }

        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public int? TypeId { get; set; }
        public int? OwnershipId { get; set; }
        public int? LocationId { get; set; }
        public string Description { get; set; }
        public string MapReference { get; set; }
        public bool AppliesToEntireSite { get; set; }
        public bool StructureReportRequired { get; set; }
        public string GisdataSource { get; set; }
        public int? GisupdatedById { get; set; }
        public DateTime? GisupdatedDate { get; set; }
        public double? Easting { get; set; }
        public double? Northing { get; set; }
        public double? SiteCentreEasting { get; set; }
        public double? SiteCentreNorthing { get; set; }
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

        public virtual ICollection<HazardAction> HazardAction { get; set; }
        public virtual ICollection<HazardFireRisk> HazardFireRisk { get; set; }
        public virtual ICollection<HazardIncidentHistory> HazardIncidentHistory { get; set; }
        public virtual User Lmu { get; set; }
        public virtual HazardLocation Location { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual HazardOwnership Ownership { get; set; }
        public virtual HazardType Type { get; set; }
    }
}
