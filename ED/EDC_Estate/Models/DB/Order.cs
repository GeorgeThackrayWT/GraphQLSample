using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Order
    {
        public Order()
        {
            Income = new HashSet<Income>();
            TabletOrdersQueue = new HashSet<TabletOrdersQueue>();
            Tender = new HashSet<Tender>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int? SupplierId { get; set; }
        public int? CustomerId { get; set; }
        public string Remarks { get; set; }
        public bool NettingOffPo { get; set; }
        public string NettingOffPono { get; set; }
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

        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<TabletOrdersQueue> TabletOrdersQueue { get; set; }
        public virtual ICollection<Tender> Tender { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User Lmu { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
