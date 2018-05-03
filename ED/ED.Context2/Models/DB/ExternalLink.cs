namespace EDC_Estate.Models.DB
{
    public partial class ExternalLink
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int? ManagementUnitId { get; set; }
        public string Url { get; set; }

        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual ExternalLinkType Type { get; set; }
    }
}
