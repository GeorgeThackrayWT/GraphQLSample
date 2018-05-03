using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IReferenceInfoStore
    {
        List<EvaluationEditDto> GetEvaluations(int managementUnitID, int evaluationTypeID);

        List<ReferenceInfoListDTO> GetReferenceInfoListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        void UpdateEvaluations(List<EvaluationEditDto> evaluationDtos, int evaluationTypeID, int managementId);

    }
}