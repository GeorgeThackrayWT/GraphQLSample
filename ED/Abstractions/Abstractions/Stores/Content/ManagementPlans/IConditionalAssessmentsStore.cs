using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IConditionalAssessmentsStore
    {
        List<ComboBoxValue> GetCAStratums();

        List<ComboBoxValue> GetCAKeyFeatures(int filter);

        CafStrataSummaryDto GetCAFStrataSummaryDTO(int featureMonitoringID);

        List<ConditionAssessmentListDTO> GetConditionAssessmentListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<ConditionAssessmentEditorEntryDto> GetConditionAssessmentEditorDto(int managementUnitID);

        void UpdateConditionAssessmentEditorEntryDtos(int managementUnitId, List<ConditionAssessmentEditorEntryDto> editSet);

        List<WoodlandSubsectionDto> GetCFContainerCollection(int featureMonitoringId);
        
        void UpdateCFContainerCollection(int managementUnitId, int featureMonitoringId,
            List<WoodlandSubsectionDto> editSet);

        CafkfSummaries GetKfSummaries(int featureMonitoringID);
        void UpdateCafkfSummaries(int Id, CafkfSummaries cafkfSummaries);

        CAFOverallDTO GetCafOverallDto(int Id);
        void UpdateCAFOverallDTO(int Id, CAFOverallDTO cafkfSummaries);


        CATTreeSpeciesDTO GetCatTreeSpeciesDto(int Id);
        void UpdateCATTreeSpeciesDTO(int Id, CATTreeSpeciesDTO cafkfSummaries);


        CATShrubSpeciesDTO GetCatShrubSpeciesDto(int Id);
        void UpdateCATShrubSpeciesDTO(int Id, CATShrubSpeciesDTO cafkfSummaries);


        CATLevelOfShrubRegenerationDTO GetCatLevelOfShrubRegenerationDto(int Id);
        void UpdateCATLevelOfShrubRegenerationDTO(int Id, CATLevelOfShrubRegenerationDTO cafkfSummaries);


        CATLevelOfTreeRegenerationDTO GetCatLevelOfTreeRegenerationDto(int Id);
        void UpdateCATLevelOfTreeRegenerationDTO(int Id, CATLevelOfTreeRegenerationDTO cafkfSummaries);


        CATRegenerationTreeSpeciesDTO GetCatRegenerationTreeSpeciesDto(int Id);
        void UpdateCATRegenerationTreeSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries);


        CATRegenerationTreeSpeciesDTO GetCatRegenerationShrubSpeciesDto(int Id);
        void UpdateCATRegenerationShrubSpeciesDTO(int Id, CATRegenerationTreeSpeciesDTO cafkfSummaries);


        CATFloraDTO GetCatFloraDto(int Id);
        void UpdateCATFloraDTO(int Id, CATFloraDTO cafkfSummaries);



        CATDeadWoodDTO GetCatDeadWoodDto(int Id);
        void UpdateCATDeadWoodDTO(int Id, CATDeadWoodDTO cafkfSummaries);


        CATAnimalDamageDTO GetCatAnimalDamageDto(int Id);
        void UpdateCATAnimalDamageDTO(int Id, CATAnimalDamageDTO cafkfSummaries);


        CATInvasivesDTO GetCatInvasivesDto(int Id);
        void UpdateCATInvasivesDTO(int Id, CATInvasivesDTO cafkfSummaries);


        CATTreeHealthDTO GetCatTreeHealthDto(int Id);
        void UpdateCATTreeHealthDTO(int Id, CATTreeHealthDTO cafkfSummaries);


        CATHumanImpactsDTO GetCatHumanImpactsDto(int Id);
        void UpdateCATHumanImpactsDTO(int Id, CATHumanImpactsDTO cafkfSummaries);


        CATTreeAgesDTO GetCatTreeAgesDto(int Id);
        void UpdateCATTreeAgesDTO(int Id, CATTreeAgesDTO cafkfSummaries);


    }
}