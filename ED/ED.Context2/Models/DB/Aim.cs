﻿using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class Aim
    {
        public Aim()
        {
            Expenditure = new HashSet<Expenditure>();
            ExpenditureProduct = new HashSet<ExpenditureProduct>();
            Feature = new HashSet<Feature>();
            FeatureType = new HashSet<FeatureType>();
            Income = new HashSet<Income>();
            IncomeProduct = new HashSet<IncomeProduct>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
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
        public virtual ICollection<ExpenditureProduct> ExpenditureProduct { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<FeatureType> FeatureType { get; set; }
        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<IncomeProduct> IncomeProduct { get; set; }
        public virtual User Lmu { get; set; }
    }
}
