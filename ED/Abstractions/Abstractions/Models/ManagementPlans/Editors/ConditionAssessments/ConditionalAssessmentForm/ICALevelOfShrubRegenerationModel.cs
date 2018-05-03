using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICALevelOfShrubRegenerationModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATLevelOfShrubRegenerationDTOEdit CATLevelOfShrubRegenerationDTO { get; set; }
    }
}