using DataObjects;

namespace Abstractions.Models
{
    public interface ISalesOrdersSearchModel : IGeneralManagementPlanSearchModel<SalesOrdersListDTO>
    {
        int SelectedSoGenOptions { get; set; }
    }
}
