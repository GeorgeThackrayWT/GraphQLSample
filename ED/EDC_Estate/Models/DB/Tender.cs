﻿using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Tender
    {
        public Tender()
        {
            Expenditure = new HashSet<Expenditure>();
            TabletOrdersQueue = new HashSet<TabletOrdersQueue>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime? ReturnedByDate { get; set; }
        public int? ReturnedToUser { get; set; }
        public int? OrderId { get; set; }
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

        public virtual ICollection<Expenditure> Expenditure { get; set; }
        public virtual ICollection<TabletOrdersQueue> TabletOrdersQueue { get; set; }
        public virtual User Lmu { get; set; }
        public virtual Order Order { get; set; }
        public virtual User ReturnedToUserNavigation { get; set; }
    }
}
