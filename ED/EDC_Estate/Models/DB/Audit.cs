using System;

namespace EDC_Estate.Models.DB
{
    public partial class Audit
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public int? SiteId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Action { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Lmu { get; set; }
        public virtual ManagementUnit Site { get; set; }
    }
}
