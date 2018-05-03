using System;

namespace EDC_Estate.Models.DB
{
    public partial class ReportQueue
    {
        public int Id { get; set; }
        public int? BinaryId { get; set; }
        public string ReportName { get; set; }
        public string FileName { get; set; }
        public string Mode { get; set; }
        public string SiteIds { get; set; }
        public int ApplicationId { get; set; }
        public int ReportFormat { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CustomParameters { get; set; }
        public bool Generated { get; set; }
        public string GenErrorMessage { get; set; }
        public string GenErrorDetails { get; set; }
        public bool Submitted { get; set; }
        public string SendErrorMessage { get; set; }
        public string SendErrorDetails { get; set; }
        public DateTime? ScheduledAt { get; set; }
        public string ToList { get; set; }
        public string CcList { get; set; }
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

        public virtual Application Application { get; set; }
        public virtual ReportBinary Binary { get; set; }
        public virtual User Lmu { get; set; }
    }
}
