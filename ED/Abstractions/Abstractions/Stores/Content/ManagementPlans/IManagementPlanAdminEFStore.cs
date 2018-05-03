using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Administration.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IManagementPlanAdminEFStore
    {        
        void UpdateAdminEditDTO(AdminEditDTO adminEditDTO, int managementUnitId);

        List<AdminListDTO> GetAdminListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        AdminEditDTO GetAdminEditDTO(int managementUnitID);

        List<PesticideAdminDto> GetPesticideAdminDto(int managementUnitId);

        List<PesticideEntryDto> GetPesticideEntrys(int pesticideId);

        void UpdatePesticides(int managementUnitId, List<PesticideAdminDto> pesticideAdminDtos);

        void UpdatePesticideEntries(int pesticideId, List<PesticideEntryDto> pesticideEntryDtos);
    }
}