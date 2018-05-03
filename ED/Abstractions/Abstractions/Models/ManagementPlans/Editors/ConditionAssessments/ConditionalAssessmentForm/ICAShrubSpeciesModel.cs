using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAShrubSpeciesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATShrubSpeciesDTOEdit CATShrubSpeciesDTO { get; set; }
    }
}