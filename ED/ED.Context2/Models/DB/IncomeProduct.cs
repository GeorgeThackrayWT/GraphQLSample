﻿using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class IncomeProduct
    {
        public IncomeProduct()
        {
            Income = new HashSet<Income>();
            IncomeProductSiteMap = new HashSet<IncomeProductSiteMap>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int AimId { get; set; }
        public int AccountCode { get; set; }
        public string Account { get; set; }
        public int WtactivityCode { get; set; }
        public string Wtactivity { get; set; }
        public int? TaxCodeId { get; set; }
        public int ApplicationId { get; set; }
        public bool Locked { get; set; }
        public bool IsWoodProduction { get; set; }
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
        public int UnitTypeId { get; set; }

        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<IncomeProductSiteMap> IncomeProductSiteMap { get; set; }
        public virtual Aim Aim { get; set; }
        public virtual Application Application { get; set; }
        public virtual User Lmu { get; set; }
        public virtual TaxCode TaxCode { get; set; }
    }
}
