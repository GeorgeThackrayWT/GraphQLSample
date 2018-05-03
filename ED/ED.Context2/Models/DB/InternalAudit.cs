using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class InternalAudit
    {
        public InternalAudit()
        {
            AcquisitionUnitInternalAuditMap = new HashSet<AcquisitionUnitInternalAuditMap>();
            InternalAuditObservation = new HashSet<InternalAuditObservation>();
        }

        public int Id { get; set; }
        public DateTime? AuditDate { get; set; }
        public int? SiteManagerId { get; set; }
        public string SiteManager { get; set; }
        public int? FirstAuditorId { get; set; }
        public string FirstAuditor { get; set; }
        public int? SecondAuditorId { get; set; }
        public string SecondAuditor { get; set; }
        public string GeneralSummary { get; set; }
        public int? CertifiedById { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int? AuthorisedById { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Published { get; set; }
        public int? PublishedById { get; set; }
        public DateTime? PublishingDate { get; set; }
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

        public virtual ICollection<AcquisitionUnitInternalAuditMap> AcquisitionUnitInternalAuditMap { get; set; }
        public virtual ICollection<InternalAuditObservation> InternalAuditObservation { get; set; }
        public virtual User AuthorisedBy { get; set; }
        public virtual User CertifiedBy { get; set; }
        public virtual User FirstAuditorNavigation { get; set; }
        public virtual User Lmu { get; set; }
        public virtual User PublishedBy { get; set; }
        public virtual User SecondAuditorNavigation { get; set; }
        public virtual User SiteManagerNavigation { get; set; }
    }
}
