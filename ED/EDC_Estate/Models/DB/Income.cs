using System;

namespace EDC_Estate.Models.DB
{
    public partial class Income
    {
        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public bool Project { get; set; }
        public int WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public int AimId { get; set; }
        public string Notes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public double Budget { get; set; }
        public double? ClmdInvd { get; set; }
        public double? Forecast { get; set; }
        public double LastMonthForecast { get; set; }
        public double? Actual { get; set; }
        public double? NetIncome { get; set; }
        public bool? Received { get; set; }
        public string GrantScheme { get; set; }
        public string GrantReference { get; set; }
        public bool Pe { get; set; }
        public bool Pipeline { get; set; }
        public string Sono { get; set; }
        public DateTime? Sodate { get; set; }
        public int? OrderId { get; set; }
        public int? TaxCodeId { get; set; }
        public int? GrantId { get; set; }
        public bool Confidential { get; set; }
        public bool Completed { get; set; }
        public bool Cancelled { get; set; }
        public bool NoSync { get; set; }
        public bool WoodProduction { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Ulmdt { get; set; }
        public int? Ulmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual Aim Aim { get; set; }
        public virtual Grant Grant { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual Order Order { get; set; }
        public virtual IncomeProduct Product { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual User Ulmu { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
