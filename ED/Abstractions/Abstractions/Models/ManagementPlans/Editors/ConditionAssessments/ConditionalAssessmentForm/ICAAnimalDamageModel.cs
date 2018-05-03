using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAAnimalDamageModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATAnimalDamageDTOEdit CATAnimalDamageDTO { get; set; }
    }
}