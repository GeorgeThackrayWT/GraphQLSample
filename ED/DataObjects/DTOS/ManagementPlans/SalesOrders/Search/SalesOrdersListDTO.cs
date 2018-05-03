using System;

namespace DataObjects
{
    public class SalesOrdersListDTO : SearchBase
    {
        public string WorkOrder { get; set; }

        public string Product { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public double ForecastAmount { get; set; }

        public string LastAmendedBy { get; set; }

        public DateTime? LastAmendedDate { get; set; }
        
    }
}