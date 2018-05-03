using System;

namespace EDC_Estate.Models.DB
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public DateTime CurrentYear { get; set; }
        public int PurchaseOrderMajorNumber { get; set; }
        public int SalesOrderMajorNumber { get; set; }
        public int FirstExpAccountCode { get; set; }
        public string OrdersDropDirectory { get; set; }
        public string PurchaseFilename { get; set; }
        public string SalesFilename { get; set; }
        public bool BudgetLock { get; set; }
        public bool FutureBudgetLock { get; set; }
        public string ChalaraWorkOrderCode { get; set; }
        public string VatguideUrl { get; set; }
        public bool DisablePo { get; set; }
        public bool DisableSo { get; set; }
        public string DisablePomessage { get; set; }
        public string DisableSomessage { get; set; }
        public string ReportServer { get; set; }
        public string ReportPath { get; set; }
        public string ReportDropDirectory { get; set; }
        public int ReportTimeout { get; set; }
        public DateTime? TasksCutOffDate { get; set; }
        public DateTime? SafetyTasksCutOffDate { get; set; }
        public DateTime? TreePlantingTasksCutOffDate { get; set; }
        public string PeresNo { get; set; }
        public string NedresNo { get; set; }
        public string AwrresNo { get; set; }
        public DateTime? LastAppliedAt { get; set; }
        public bool Deleted { get; set; }
        public DateTime? Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }
        public DateTime Q4dateRestrictionDate { get; set; }
    }
}
