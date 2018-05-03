using System.ComponentModel;
using DataObjects.DTOS.SafetyObjects.Editors;
using MvvmHelpers;

namespace Abstractions.Models.Safety.Editors
{
    public interface ISafetyActionModel : IBaseModel, INotifyPropertyChanged
    {
        ObservableRangeCollection<HazardActionDto> HazardActions { get; set; }

        HazardActionDto SelectedHazardActionDto { get; set; }

        int HazardID { get; set; }

    }
}