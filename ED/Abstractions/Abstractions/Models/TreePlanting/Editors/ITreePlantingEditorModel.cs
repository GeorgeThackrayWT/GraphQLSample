using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using MvvmHelpers;

namespace Abstractions.Models.Safety.Editors
{
    public interface ITreePlantingEditorModel : IBaseModel, INotifyPropertyChanged
    {      
        ObservableRangeCollection<ComboBoxValue> PlantingTypeLookup { get; }

        ObservableRangeCollection<ComboBoxValue> PlantedByLookup { get; }

        ObservableRangeCollection<SubCompartmentLookupDto> SubCompartmentsLookup { get; }

        ExtRangeCollection<TreePlantEditList> Records { get; set; }
        
        ICommand LoadData { get; }

        TreePlantEditList EditRecord { get; set; }
    }



}