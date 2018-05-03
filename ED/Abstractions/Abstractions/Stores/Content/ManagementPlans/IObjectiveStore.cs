using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IObjectiveStore
    {
        List<ObjectivesDTO> GetObjectivesContainerEditDto(int managementUnitID);

        void UpdateObjectivesDTO(List<ObjectivesDTO> objectivesDtos, int recordId);

        List<ObjectiveKFListDTO> GetObjectiveKfListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);
    }
}