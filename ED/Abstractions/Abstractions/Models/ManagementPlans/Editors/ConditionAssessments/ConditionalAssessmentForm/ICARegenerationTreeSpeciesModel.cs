using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICARegenerationTreeSpeciesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATRegenerationTreeSpeciesDTOEdit CATRegenerationTreeSpeciesDTO { get; set; }
    }
}