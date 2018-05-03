using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using MvvmHelpers;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ITenderEditorModel : IBaseModel, INotifyPropertyChanged
    {
        // tender detail
        TenderEdit Tenure { get; set; }

        ExtRangeCollection<TenderExpenditureEditList> Records { get; set; }

        TenderExpenditureEditList EditRecord { get; set; }

        ObservableRangeCollection<ComboBoxValue> VatRates { get; set; }

        SupplierDto SelectedSupplier { get; set; }

        List<SupplierDto> SupplierList { get; set; }

        ICommand RemoveFromTender { get; set; }

        ICommand PrintTender { get; set; }

        ICommand SubmitOrder { get; set; }

    }

}
