namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminReportsDTO
    {
        public int ID { get; set; }

        public string ReportServer { get; set; }

        public string ReportsPath { get; set; }

        public string ReportsDropPath { get; set; }

        public int Timeout { get; set; }
    }
}