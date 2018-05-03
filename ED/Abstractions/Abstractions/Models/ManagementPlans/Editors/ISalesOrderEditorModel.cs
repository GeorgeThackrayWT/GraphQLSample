using System.ComponentModel;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ISalesOrderEditorModel : IBaseModel, ICommonInterface, INotifyPropertyChanged
    {
        ExtRangeCollection<IncomeEdit> IncomesFlip { get; set; }
         
        IncomeEdit SelectedIncomeEdit { get; set; }
    }

}