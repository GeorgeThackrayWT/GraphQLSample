namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminWTFLSitesDTO
    {
        public int ID { get; set; }

        public string CostCentre { get; set; }

        public string SiteName { get; set; }

        public string Region { get; set; }

        public string SiteManager { get; set; }

        public int EntityTypeID { get; set; }

        public bool WholeSite { get; set; }
        
    }
}