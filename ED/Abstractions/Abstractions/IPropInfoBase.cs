using DataObjects.DTOS;

namespace Abstractions
{
    public interface IPropInfoBase : IBaseModel
    {
        //   int AcquisitionId { get; set; }

        SubAcquisitionUnitEdit SubAcquisitionUnitEdit { get; set; }
    }
}