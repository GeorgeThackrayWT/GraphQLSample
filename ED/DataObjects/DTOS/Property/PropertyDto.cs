using System;

namespace DataObjects.DTOS
{

    public class PropertyDto : SearchBase
    {
        public int ID { get; set; }

        public string TenureDescription { get; set; }

        public int? LeaseTermYrs { get; set; }

        public string SiteName { get; set; }

        public string GridReference { get; set; }

        public DateTime? Acquired { get; set; }

        public string LPMDescription { get; set; }

        public double AreaHa { get; set; }

        public string ManagedBy { get; set; }
    }
}