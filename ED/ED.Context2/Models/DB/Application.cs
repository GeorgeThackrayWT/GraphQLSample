using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Application
    {
        public Application()
        {
            DocumentName = new HashSet<DocumentName>();
            ExpenditureProduct = new HashSet<ExpenditureProduct>();
            IncomeProduct = new HashSet<IncomeProduct>();
            ManagementUnit = new HashSet<ManagementUnit>();
            ReportQueue = new HashSet<ReportQueue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ThemeId { get; set; }
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

        public virtual ICollection<DocumentName> DocumentName { get; set; }
        public virtual ICollection<ExpenditureProduct> ExpenditureProduct { get; set; }
        public virtual ICollection<IncomeProduct> IncomeProduct { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnit { get; set; }
        public virtual ICollection<ReportQueue> ReportQueue { get; set; }
        public virtual User Lmu { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
