using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAOverallStructureModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CAFOverallDTOEdit CAFOverallDTO { get; set; }
    }
}