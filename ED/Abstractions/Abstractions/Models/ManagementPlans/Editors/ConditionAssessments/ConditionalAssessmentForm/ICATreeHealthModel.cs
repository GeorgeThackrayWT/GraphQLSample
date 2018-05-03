using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICATreeHealthModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATTreeHealthDTOEdit CATTreeHealthDTO { get; set; }
    }
}