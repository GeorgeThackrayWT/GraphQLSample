using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite.DataTypes
{
    public class InternalAuditSearchResult
    {
        public int ID { get; set; }
        public DateTime? AuditDate { get; set; }
        public int? SiteManagerID { get; set; }
        public string SiteManager { get; set; }
        public int? FirstAuditorID { get; set; }
        public string FirstAuditor { get; set; }
        public int? SecondAuditorID { get; set; }
        public string SecondAuditor { get; set; }
        public string GeneralSummary { get; set; }
        public int? CertifiedByID { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int? AuthorisedByID { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Published { get; set; }
        public int? PublishedByID { get; set; }
        public DateTime? PublishingDate { get; set; }
        public int? RegionID { get; set; }
    }
}
