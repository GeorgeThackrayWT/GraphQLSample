﻿using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class DocuwareCabinet
    {
        public DocuwareCabinet()
        {
            DocumentArea = new HashSet<DocumentArea>();
            DocumentName = new HashSet<DocumentName>();
            DocumentQueue = new HashSet<DocumentQueue>();
            DocumentType = new HashSet<DocumentType>();
            DocuwareConfiguration = new HashSet<DocuwareConfiguration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileCabinet { get; set; }
        public string ResultList { get; set; }
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

        public virtual ICollection<DocumentArea> DocumentArea { get; set; }
        public virtual ICollection<DocumentName> DocumentName { get; set; }
        public virtual ICollection<DocumentQueue> DocumentQueue { get; set; }
        public virtual ICollection<DocumentType> DocumentType { get; set; }
        public virtual ICollection<DocuwareConfiguration> DocuwareConfiguration { get; set; }
        public virtual User Lmu { get; set; }
    }
}
