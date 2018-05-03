using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS.AdministrationArea;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IObjectivesKfEditorModel : IBaseModel,  INotifyPropertyChanged
    { 
        ObjectivesDTOEdit EditRecord { get; set; }

        ExtRangeCollection<ObjectivesDTOEdit> RecordsFlip { get; set; }

    }
}