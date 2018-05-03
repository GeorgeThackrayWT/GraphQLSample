namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminVATRateLocks
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string SiteName { get; set; }

        public int RegionID { get; set; }

        public int SiteManagerID { get; set; }

        public int IncomeTaxCode { get; set; }

        public int ExpenditureTaxCode { get; set; }


    }
}