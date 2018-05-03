using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class ManagementPlan
    {
        public ManagementPlan()
        {
            Grant = new HashSet<Grant>();
            ManagementUnit = new HashSet<ManagementUnit>();
        }

        public int Id { get; set; }
        public byte[] Pdffile { get; set; }
        public byte[] WoodBoardPdffile { get; set; }
        public byte[] WoodBoardJpgfile { get; set; }
        public bool UnderConsultation { get; set; }
        public DateTime? ConsultationEndDate { get; set; }
        public DateTime? ReviewDeadline { get; set; }
        public bool UnderReview { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public bool Approved { get; set; }
        public int? ApprovedById { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? LastExported { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<Grant> Grant { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnit { get; set; }
        public virtual User ApprovedBy { get; set; }
        public virtual User Lmu { get; set; }
    }
}
