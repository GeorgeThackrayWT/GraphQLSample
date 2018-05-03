using System.ComponentModel;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface ICAKFSummariesModel : IBaseModel, INotifyPropertyChanged
    {
        bool IsVisible { get; set; }

        int FeatureMonitoringID { get; set; }

        CafkfSummaries CAFKFSummariesDTO { get; set; }
    }
}