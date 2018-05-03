using System;

namespace DataObjects
{
    public class MonitoringListDTO : SearchBase
    {
     
        public int? RegionId { get; set; }

        public int? WoodlandOfficerId { get; set; }

        public int NoOfKFAimObservations { get; set; }

        public int NoOfWCObservations { get; set; }

        public DateTime? NextObservableDate { get; set; }

        public DateTime? NextActionDate { get; set; }

        public int Overdue { get; set; }

        public string Summary { get; set; }

    }



}