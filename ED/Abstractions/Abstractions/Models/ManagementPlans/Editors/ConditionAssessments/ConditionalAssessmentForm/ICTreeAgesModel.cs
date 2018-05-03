using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICTreeAgesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATTreeAgesDTOEdit CATTreeAgesDTO { get; set; }
    }
}