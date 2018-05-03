using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IGrantContractsEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        //    ObservableRangeCollection<GrantContractEditorDto> GrantContractsFlip { get; }

        ExtRangeCollection<PaymentSummaryDTOEditList> GrantPaymentsEditList { get; }

        ExtRangeCollection<GrantContractEditorEdit> RecordsFlip { get; set; }

        PaymentSummaryDTOEditList GrantPaymentsEditRecord { get; set; }

        GrantContractEditorEdit EditRecord { get; set; }

        ICommand LoadData { get; }
        

    }
}