using System.Collections.Generic;
using System.Windows.Input;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;

namespace Abstractions.Models
{
    public interface IPurchaseOrdersSearchModel : IGeneralManagementPlanSearchModel<PurchaseOrderListDTO>
    {
        ICommand AddLine { get; set; }

        ICommand RemoveLine { get; set; }


        ICommand SelectAllLines { get; set; }

        ICommand DeSelectAllLines { get; set; }

        ILinkContainer Links { get; set; }

        int SelectedPoGenOptions { get; set; }

        TenderDto SelectedTender { get; set; }

        List<TenderDto> TenderList { get; set; }

        string TenderName { get; }

    }
}
