using System.Collections.Generic;
using DataObjects.DTOS.SafetyObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores.Content.Safety
{
    public interface ISafetyStore
    {
        //SafetyDto

        List<SafetyDto> GetSafetyDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<HazardDto> GetHazardDtos(int managementUnitID);

        void UpdateHazards(int managementUnitId, List<HazardDto> editSet);

        RiskAssessmentDto GetRiskAssessmentDto(int managementUnitID);

        List<HazardTypeDtoLookup> GetHazardTypeDtos();

        List<HazardCategoryDtoLookup> GetHazardCategoryDtos();

        List<HazardOwnershipDtoLookup> GetHazardOwnershipDtos();

        List<HazardActionDto> GetHazardActionDtos(int hazardID);

        void UpdateHazardActions(int hazardId, List<HazardActionDto> editSet);

        List<HazardIncidentDto> GetHazardIncidentDtos(int hazardID);

        void UpdateHazardIncidents(int hazardId, List<HazardIncidentDto> editSet);


        

        void UpdateRiskAssessment(int managementUnitId, RiskAssessmentDto riskAssessmentDto);

        FireRiskCollectionDto GetFireRiskCollectionDto(int hazardID);


        //FireRiskCollectionDto


    }
}
