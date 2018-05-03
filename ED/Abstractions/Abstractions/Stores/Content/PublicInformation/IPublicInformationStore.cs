using System.Collections.Generic;
using DataObjects.DTOS.PublicInformationDtos;
using EDCORE.ViewModel;

namespace Abstractions.Stores.Content.PublicInformation
{
    public interface IPublicInformationStore
    {
        List<PublicInformationSearchDto> GetPublicInformationDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        PublicInformationDto GetPublicInformationDto(int managementID);

        string GetDirections(int managementID);

        void UpdatePublicInformation(PublicInformationDto publicInformationDto, int managementId);



    }
}
