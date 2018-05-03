using System.ComponentModel;
using DataObjects.DTOS.TreePlanting;
using MvvmHelpers;

namespace Abstractions
{
    public interface ITreePlantingDedicationsModel : IBaseModel, INotifyPropertyChanged
    {
        ObservableRangeCollection<TreePlantDedicationsDto> Dedications { get; set; }

        TreePlantDedicationsDto SelectedDedication { get; set; }

        TreePlantEditList TreePlantingID { get; set; }

    }
}