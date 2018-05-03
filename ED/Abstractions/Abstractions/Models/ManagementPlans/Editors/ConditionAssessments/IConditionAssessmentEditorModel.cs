using System.ComponentModel;
using System.Windows.Input;
using Abstractions.Navigation;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IConditionAssessmentEditorModel : IBaseModel, INotifyPropertyChanged
    {     

        ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList> Records { get; set; }

        ConditionAssessmentEditorEntryDtoEditList EditRecord { get; set; }

        ConditionAssessmentEditorEntryDtoEdit EditPropertyRecord { get; }

        int ManagementUnitID { get; set; }

        ICommand LoadData { get; }

        ICommand LoadConditionAssessmentForm { get; }

        bool IsHistoricCondition { get; set; }

        bool IsCondition { get; set; }
        
    }
}