using System;

namespace EDC_Estate.Models.DB
{
    public partial class Features
    {
        public int? WoodId { get; set; }
        public int? CostCentre { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string FeatureCode { get; set; }
        public string FeatureDescription { get; set; }
        public int? WholeSite { get; set; }
        public int? SubCompNo { get; set; }
        public string SubCompLetter { get; set; }
        public int? Confidential { get; set; }
        public string DataSource { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
