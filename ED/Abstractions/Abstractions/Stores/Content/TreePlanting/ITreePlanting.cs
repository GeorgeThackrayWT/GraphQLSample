using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using EDCORE.ViewModel;

namespace Abstractions.Stores.Content.Safety
{
    public interface ITreePlantingStore
    {
        List<TreePlantingSearchDto> GetTreePlantingDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<TreePlantDto> GetTreePlantDtos(int managementUnitID);

        List<ComboBoxValue> GetPlantedByDtos();

        List<ComboBoxValue> GetPlantTypeDtos();

        List<SubCompartmentLookupDto> GetSubCompartmentLookupDtos();

        List<TreePlantDedicationsDto> GetTreePlantDedicationsDtos(int treePlantingID);

        List<TreePlantDetailDto> GetTreePlantDetailDtos(int treePlantingID);

        List<TreePlantAccessDto> GetTreePlantAccessDtos();

        List<TreePlantTerrainDto> GetTreePlantTerrainDtos();

        void UpdateTreePlantDtos(int managementUnitID, List<TreePlantDto> editSet);

        void UpdateTreePlantDetailsDtos(int treePlantingID, List<TreePlantDetailDto> editSet);

        // we need compartment info
        //planting type
        //plantedby
        //terrain
        //access
        //TreePlantDto

    }
}
