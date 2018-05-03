using System;

namespace EDC_Estate.Models.DB
{
    public partial class DocumentQueue
    {
        public int Id { get; set; }
        public int BinaryId { get; set; }
        public int FileCabinetId { get; set; }
        public int? TaskId { get; set; }
        public string DocumentName { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Metadata { get; set; }
        public int SizeInBytes { get; set; }
        public int StatusId { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
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

        public virtual DocumentBinary Binary { get; set; }
        public virtual DocuwareCabinet FileCabinet { get; set; }
        public virtual User Lmu { get; set; }
        public virtual DocumentStatus Status { get; set; }
    }
}
