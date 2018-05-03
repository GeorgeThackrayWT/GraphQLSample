using System.Collections.Generic;
using DataObjects.DTOS.InternalAudits;
using EDCORE.ViewModel;

namespace Abstractions.Stores.Content.InternalAudits
{
    public interface IInternalAuditStore
    {
        List<InternalAuditsSearchDto> GetInternalAuditsSearchDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        InternalAuditsEditDto GetInternalAuditsEditDtos(int internalAuditID);

        InternalAuditsObservationEditDto GetInternalAuditsObservations(int observationID);

        List<InternalAuditsWoodlist> GetAuditWoods(int internalAuditID);

        List<InternalAuditsObservationEditDto> GetInternalAuditsObservationList(int internalAuditID);
    }
}
