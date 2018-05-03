using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Category { get; set; }
        public string LongCategory { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalNo { get; set; }
        public string Town { get; set; }
        public string Code { get; set; }
        public string County { get; set; }
        public string Telephone { get; set; }
        public string Telefax { get; set; }
        public string Telex { get; set; }
        public string Mobile { get; set; }
        public string Pager { get; set; }
        public string Home { get; set; }
        public string Assistant { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string AddressType { get; set; }
        public int TaxCodeId { get; set; }
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

        public virtual ICollection<Order> Order { get; set; }
        public virtual User Lmu { get; set; }
        public virtual TaxCode TaxCode { get; set; }
    }
}
