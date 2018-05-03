using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface ISalesStore
    {        
        List<IncomeDto> GetIncomes();

        List<SalesOrdersListDTO> GetSalesOrdersListDtos(OrdersSelectionCriterion ordersCriterionarg,List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<IncomeDto> GetIncomes(int managementUnitId);

        List<IncomeDto> GetWpIncomes(int managementUnitId);

        WPSummaryDTO GetWpIncomesSummaryMySites(int managementUnitId);
        
        void UpdateIncomes(List<IncomeDto> editSet, int managementId);
    }
}