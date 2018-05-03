using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IHarvestingStore : IBaseStore
    {
        //harvesting
        List<HarvestingEditDTO> GetHarvestingEditContainerDTO(int managementUnitID, int option);

        List<HarvestingEditDTO> GetHarvestingEditContainerDTOForYear(int managementUnitID, int option);

        List<HarvestingListDTO> GetHarvestingListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<ComboBoxValue> GetHarvestingOperations();

        List<ComboBoxValue> GetCompartments(int managementUnitId);

        void UpdateHarvestingObjects(List<HarvestingEditDTO> harvestingEditDtos, int managementUnitId);

    }
}