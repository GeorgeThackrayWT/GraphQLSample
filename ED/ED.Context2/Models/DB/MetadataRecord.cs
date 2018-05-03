using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class MetadataRecord
    {
        public MetadataRecord()
        {
            MetadataField = new HashSet<MetadataField>();
            TabletChange = new HashSet<TabletChange>();
        }

        public int Id { get; set; }
        public string RecordName { get; set; }
        public string RecordAlias { get; set; }
        public string SysRecordName { get; set; }
        public int? ParentRecordId { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLookup { get; set; }
        public bool Sync { get; set; }
        public bool SyncAll { get; set; }
        public bool SyncDeleted { get; set; }
        public bool SyncOut { get; set; }
        public string Sqlquery { get; set; }
        public int? Order { get; set; }
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

        public virtual ICollection<MetadataField> MetadataField { get; set; }
        public virtual ICollection<TabletChange> TabletChange { get; set; }
        public virtual MetadataRecord ParentRecord { get; set; }
        public virtual ICollection<MetadataRecord> InverseParentRecord { get; set; }
    }
}
