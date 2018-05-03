using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICARegenerationShrubSpeciesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATRegenerationTreeSpeciesDTOEdit CATRegenerationShrubSpeciesDTO { get; set; }
    }
}