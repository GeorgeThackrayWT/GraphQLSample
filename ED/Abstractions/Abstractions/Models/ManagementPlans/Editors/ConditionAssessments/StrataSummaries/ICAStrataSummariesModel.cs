using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAStrataSummariesModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        int FeatureMonitoringID { get; set; }

        CafStrataSummaryDto CAFStrataSummaryDTO { get; set; }

        CAFSummaryObjDTO SelectedRow { get; set; }

    }
}