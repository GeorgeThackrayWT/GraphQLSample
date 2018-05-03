using System.ComponentModel;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IPurchaseOrderEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        ExtRangeCollection<ExpenditureEdit> ExpenditureFlip { get; set; }

        ExpenditureEdit SelectedExpenditureEditDto { get; set; }
    }
    
}