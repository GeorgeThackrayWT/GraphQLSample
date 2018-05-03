using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Designation
    {
        public Designation()
        {
            EnvironmentalAssessmentMitigation = new HashSet<EnvironmentalAssessmentMitigation>();
            SubCompartmentDesignationMap = new HashSet<SubCompartmentDesignationMap>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int? DesignatorId { get; set; }
        public double? Hectares { get; set; }
        public string SiteDescription { get; set; }
        public string Comments { get; set; }
        public string AreaName { get; set; }
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

        public virtual ICollection<EnvironmentalAssessmentMitigation> EnvironmentalAssessmentMitigation { get; set; }
        public virtual ICollection<SubCompartmentDesignationMap> SubCompartmentDesignationMap { get; set; }
        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual Designator Designator { get; set; }
        public virtual User Lmu { get; set; }
        public virtual DesignationType Type { get; set; }
    }
}
