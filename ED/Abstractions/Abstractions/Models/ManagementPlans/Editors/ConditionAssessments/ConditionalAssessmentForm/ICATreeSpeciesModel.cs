using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICATreeSpeciesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        CATTreeSpeciesDTOEdit CATTreeSpeciesDTO { get; set; }      
    }
}