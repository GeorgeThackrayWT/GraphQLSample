namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminFundedProjectSitesDto
    {
        public int ID { get; set; }

        public string CostCentre { get; set; }

        public string SiteName { get; set; }

        public int RegionID { get; set; }

        public int SiteManagerID { get; set; }

        public int LinkTypeID { get; set; }

        public string Link { get; set; }

    }
}