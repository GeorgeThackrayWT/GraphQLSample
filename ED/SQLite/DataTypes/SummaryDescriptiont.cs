namespace DataObjects.DTOS.ManagementPlans.SearchScreens
{
    public class SummaryDescriptiont
    {
        public int AcquisitionUnitID { get; set; }
        public int ManagementUnitID { get; set; }
        public int? CountSSSI { get; set; }
        public bool? IsSSSI { get; set; }
        public int? CountTPO { get; set; }
        public bool? IsTPO { get; set; }
        public int? CountAWS { get; set; }
        public bool? IsAWS { get; set; }
        public int? CountAONB { get; set; }
        public bool? IsAONB { get; set; }
        public int? CountNP { get; set; }
        public bool? IsNP { get; set; }
        public int? CountSAM { get; set; }
        public bool? IsSAM { get; set; }
        public bool? AWR { get; set; }
        public bool? DEMOWC { get; set; }

        public bool? DEMOAWR { get; set; }
        public bool? DIO { get; set; }
        public bool? DEST { get; set; }
        public bool? FA { get; set; }
        public bool? FWW { get; set; }
        public bool? LTM { get; set; }
        public bool? PPP { get; set; }
        public bool? PRP { get; set; }
        public bool? T4A { get; set; }
        public bool? Trafalgar { get; set; }
        public bool? WOYD { get; set; }
        public bool? WSP { get; set; }
        public int? PAWSStatus { get; set; }
        public bool? MoreDesignations { get; set; }
    }
}