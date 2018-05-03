namespace EDC_Estate.Models.DB
{
    public partial class ManagementUnitRow
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public int? RegionId { get; set; }
        public string Region { get; set; }
        public int? ManagerId { get; set; }
        public string Manager { get; set; }
        public int? DeputyId { get; set; }
        public string Deputy { get; set; }
        public int? Aucount { get; set; }
        public bool IsPotSite { get; set; }
        public int ApplicationId { get; set; }
    }
}
