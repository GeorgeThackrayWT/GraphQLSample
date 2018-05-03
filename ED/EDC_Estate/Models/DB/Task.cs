using System;

namespace EDC_Estate.Models.DB
{
    public partial class Task
    {
        public int Id { get; set; }
        public int? ManagementUnitId { get; set; }
        public int? AcquisitionUnitId { get; set; }
        public int SrcRecordId { get; set; }
        public string SrcFieldName { get; set; }
        public int? Src2RecordId { get; set; }
        public string Src2FieldName { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }
        public string Label { get; set; }
        public double? Amount { get; set; }
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

        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual TaskCategory Category { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
    }
}
