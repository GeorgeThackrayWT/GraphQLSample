using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class MetadataField
    {
        public MetadataField()
        {
            TabletChange = new HashSet<TabletChange>();
        }

        public int Id { get; set; }
        public int RecordId { get; set; }
        public string FieldName { get; set; }
        public string FieldAlias { get; set; }
        public string SysFieldName { get; set; }
        public string FieldTypeRef { get; set; }
        public int? RecordRefId { get; set; }
        public bool IsKey { get; set; }
        public bool IsRequired { get; set; }
        public bool ReadOnly { get; set; }
        public int MaxLength { get; set; }
        public string Permissions { get; set; }
        public bool Sync { get; set; }
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

        public virtual ICollection<TabletChange> TabletChange { get; set; }
        public virtual MetadataFieldType FieldTypeRefNavigation { get; set; }
        public virtual MetadataRecord Record { get; set; }
        public virtual MetadataField RecordRef { get; set; }
        public virtual ICollection<MetadataField> InverseRecordRef { get; set; }
    }
}
