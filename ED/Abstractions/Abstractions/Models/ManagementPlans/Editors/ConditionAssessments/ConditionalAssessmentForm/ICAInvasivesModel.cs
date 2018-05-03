using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAInvasivesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATInvasivesDTOEdit CATInvasivesDTO { get; set; }
    }
}