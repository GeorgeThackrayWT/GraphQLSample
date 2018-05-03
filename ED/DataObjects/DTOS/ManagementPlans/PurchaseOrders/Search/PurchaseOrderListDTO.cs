using System;

namespace DataObjects
{
    public class PurchaseOrderListDTO : SearchBase
    {
        public string WorkOrder { get; set; }

        public string Product { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Double ForecastAmount { get; set; }

        public string LastAmendedBy { get; set; }

        public DateTime? LastAmendedDate { get; set; }

        public bool OutToTender { get; set; }

        public int TenderNumber { get; set; }

        public string TenderName { get; set; }
        
    }
}