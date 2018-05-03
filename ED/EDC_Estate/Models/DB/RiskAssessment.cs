using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class RiskAssessment
    {
        public RiskAssessment()
        {
            ControlMeasure = new HashSet<ControlMeasure>();
            ManagementUnit = new HashSet<ManagementUnit>();
        }

        public int Id { get; set; }
        public int? CompletedByWoodlandOfficerId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool Authorised { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public int? AuthorisedByRegionalManagerId { get; set; }
        public int? FireAssessmentId { get; set; }
        public int? BiosecurityZoneId { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string PersonalIssues { get; set; }
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

        public virtual ICollection<ControlMeasure> ControlMeasure { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnit { get; set; }
        public virtual User AuthorisedByRegionalManager { get; set; }
        public virtual BiosecurityZone BiosecurityZone { get; set; }
        public virtual User CompletedByWoodlandOfficer { get; set; }
        public virtual FireAssessment FireAssessment { get; set; }
        public virtual User Lmu { get; set; }
    }
}
