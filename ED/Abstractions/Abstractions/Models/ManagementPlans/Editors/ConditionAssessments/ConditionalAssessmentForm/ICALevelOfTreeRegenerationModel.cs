using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICALevelOfTreeRegenerationModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATLevelOfTreeRegenerationDTOEdit CATLevelOfTreeRegenerationDTO { get; set; }
    }
}