using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class TaxCode
    {
        public TaxCode()
        {
            Customer = new HashSet<Customer>();
            Expenditure = new HashSet<Expenditure>();
            ExpenditureProduct = new HashSet<ExpenditureProduct>();
            Income = new HashSet<Income>();
            IncomeProduct = new HashSet<IncomeProduct>();
            Supplier = new HashSet<Supplier>();
            VatrateLockExpenditureTaxCode = new HashSet<VatrateLock>();
            VatrateLockIncomeTaxCode = new HashSet<VatrateLock>();
        }

        public int Id { get; set; }
        public string Section { get; set; }
        public string Vatcode { get; set; }
        public double TaxRate { get; set; }
        public double Vatrate { get; set; }
        public string Description { get; set; }
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

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Expenditure> Expenditure { get; set; }
        public virtual ICollection<ExpenditureProduct> ExpenditureProduct { get; set; }
        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<IncomeProduct> IncomeProduct { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<VatrateLock> VatrateLockExpenditureTaxCode { get; set; }
        public virtual ICollection<VatrateLock> VatrateLockIncomeTaxCode { get; set; }
        public virtual User Lmu { get; set; }
    }
}
