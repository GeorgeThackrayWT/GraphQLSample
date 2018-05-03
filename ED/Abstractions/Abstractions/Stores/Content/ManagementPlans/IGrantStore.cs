using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IGrantStore
    {
        //grant
        List<GrantContractEditorDto> GetGrantContract(int managementUnitID);

        List<GrantContractsListDTO> GetGrantContractsListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<PaymentSummaryDTO> GetGrantPayments(int grantId);

        void UpdatePayments(List<PaymentSummaryDTO> payments, int managementUnitId);

        void UpdateGrants(List<GrantContractEditorDto> grants, int managementUnitId);


    }
}