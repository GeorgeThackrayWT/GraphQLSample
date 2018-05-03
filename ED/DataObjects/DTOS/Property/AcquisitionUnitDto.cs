namespace DataObjects.DTOS
{

    //this to be refactored



    public class AcquisitionUnitDto
    {

        public PropertyGeneralDetailsDto PropertyGeneralDetailsDto { get; set; }

        public PropertyLegalTitleDto PropertyLegalTitleDto { get; set; }

        public PropertyFarmingDto PropertyFarmingDto { get; set; }

        public MainSectionDto AcquisitionMainSectionDto { get; set; }

        public int ManagementUnitId { get; set; }


    }
}