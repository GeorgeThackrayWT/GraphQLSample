using System;

namespace SQLite.DataTypes
{
    public class MonitoringData
    {
        public int ID { get; set; }

        public string Name { get; set; }


        public int ManagementUnitID { get; set; }

        public int CountKFObservations { get; set; }

        public int CountWCObservations { get; set; }

        public DateTime? NextObservationDate { get; set; }

        public DateTime? NextActionDate { get; set; }

        public int CountOverdue { get; set; }

    }
}