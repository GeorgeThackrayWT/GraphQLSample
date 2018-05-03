using System;

namespace EDC_Estate.Models.DB
{
    public partial class InternalAuditRow
    {
        public int Id { get; set; }
        public DateTime? AuditDate { get; set; }
        public string RegionName { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int? FirstAuditorId { get; set; }
        public string FirstAuditor { get; set; }
        public int? SecondAuditorId { get; set; }
        public string SecondAuditor { get; set; }
        public int? CertifiedById { get; set; }
        public string CertifiedBy { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int? AuthorisedById { get; set; }
        public string AuthorisedBy { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }
    }
}
