namespace EDC_Estate.Models.DB
{
    public partial class AcquisitionUnitRow
    {
        public int WoodId { get; set; }
        public string WoodName { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public bool IsPotSite { get; set; }
        public int WoodlandOfficerId { get; set; }
        public string WoodlandOfficer { get; set; }
        public int? AcquisitionOfficerId { get; set; }
        public string AcquisitionOfficer { get; set; }
        public long DirectoryInformation { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}
