using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class ReportBinary
    {
        public ReportBinary()
        {
            ReportQueue = new HashSet<ReportQueue>();
        }

        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string Warnings { get; set; }
        public string SessionId { get; set; }
        public string ContentType { get; set; }
        public string HistoryId { get; set; }
        public string Encoding { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public string Size { get; set; }
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

        public virtual ICollection<ReportQueue> ReportQueue { get; set; }
        public virtual User Lmu { get; set; }
    }
}
