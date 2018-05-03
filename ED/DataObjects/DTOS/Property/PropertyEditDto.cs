using System.Collections.Generic;
using System.Linq;

namespace DataObjects.DTOS
{
    public class PropertyEditDto
    {
        public int Id { get; set; }

        public List<AcquisitionUnitDto> AcquisitionUnitsFlip { get; set; }

        public double GisTotalAcres
        {
            get { return AcquisitionUnitsFlip.Sum(a => a.AcquisitionMainSectionDto.GISHa); }

        }
        public double WoodTotalAcres
        {
            get { return AcquisitionUnitsFlip.Sum(a => a.AcquisitionMainSectionDto.WoodHa); }
        }

        public double LandTotalAcres
        {
            get { return AcquisitionUnitsFlip.Sum(a => a.AcquisitionMainSectionDto.LandHa); }
        }

    }
}