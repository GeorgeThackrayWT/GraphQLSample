using System;

namespace DataObjects.DTOS.InternalAudits
{
    public class InternalAuditsSearchDto: SearchBase
    {
        public int ID { get; set; }
        public DateTime? AuditDate { get; set; }

        public string LeadAuditor { get; set; }

        public string SecondAuditor { get; set; }

        public string CertifiedCorrectBy { get; set; }

        public DateTime? CertifiedCorrectDate { get; set; }

        public string AuthorisedCorrectBy { get; set; }

        public DateTime? AutherisedCorrectDate { get; set; }



    }
}