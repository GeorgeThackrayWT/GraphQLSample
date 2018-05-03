using System.Collections.Generic;
using DataObjects;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface ISummaryStore
    {
        //summary description

        SummaryOverviewDto GetSummaryDescriptionContainerEditDto(int managementUnitID);
        void UpdateSummaryDescriptionOverview(SummaryOverviewDto editSet, int managementId);

        List<SummaryDescriptiontListDTO> GetSummaryDescriptiontListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);
        

        List<SummaryDto> GetSummaries(int managementUnitId);
        void UpdateSummaries(List<SummaryDto> editSet, int managementId);

        List<SummaryConstraintDto> GetSummaryConstraints(int subCompartmentId);
        void UpdateSummaryConstraints(List<SummaryConstraintDto> editSet, int subCompartmentId);

        List<SummaryFeatureDto> GetSummaryFeatures(int subCompartmentId);
        void UpdateSummaryFeatures(List<SummaryFeatureDto> editSet, int subCompartmentId);

        List<SummaryDesignationDto> GetSummaryDesignations(int subCompartmentId);
        void UpdateSummaryDesignations(List<SummaryDesignationDto> editSet, int subCompartmentId);
    }
}