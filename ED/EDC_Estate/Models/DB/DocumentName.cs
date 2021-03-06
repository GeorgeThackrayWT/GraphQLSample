﻿using System;

namespace EDC_Estate.Models.DB
{
    public partial class DocumentName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CabinetId { get; set; }
        public int AreaId { get; set; }
        public int ApplicationId { get; set; }
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

        public virtual Application Application { get; set; }
        public virtual DocumentArea Area { get; set; }
        public virtual DocuwareCabinet Cabinet { get; set; }
        public virtual User Lmu { get; set; }
    }
}
