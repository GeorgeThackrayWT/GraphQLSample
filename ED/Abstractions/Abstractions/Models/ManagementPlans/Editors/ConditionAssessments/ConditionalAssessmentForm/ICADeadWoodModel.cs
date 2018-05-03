using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICADeadWoodModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATDeadWoodDTOEdit CATDeadWoodDTO { get; set; }
    }
}