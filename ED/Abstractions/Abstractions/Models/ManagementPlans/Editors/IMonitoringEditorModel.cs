using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using MvvmHelpers;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IMonitoringEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        ObservableRangeCollection<ComboBoxValue> ObservationTypeLookup { get; }

        ExtRangeCollection<MonitoringEditEditList> Records { get; set; }

        MonitoringEditEditList EditRecord { get; set; }

        MonitoringEditEdit EditRecordEdit { get; set; }

        ICommand LoadData { get; }

        int YearFilter { get; set; }
    }

   

}