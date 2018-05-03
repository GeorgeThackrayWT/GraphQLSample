using System.Collections.Generic;
using DataObjects;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IManagementPlanStore
    {                        
        List<WorkProgrammeListDTO> GetWorkProgrammeListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);
    }
}