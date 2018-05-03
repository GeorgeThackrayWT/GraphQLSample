namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminVATCodes
    {
        public int ID { get; set; }

        public SectionDescriptionDto Section { get; set; }

        public string VATCode { get; set; }

        public string Description { get; set; }

        public double VATImpact { get; set; }

        public bool VATIsDefault { get; set; }


    }
}