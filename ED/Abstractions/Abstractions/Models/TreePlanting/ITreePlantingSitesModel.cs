using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using MvvmHelpers;

namespace Abstractions
{
    public interface ITreePlantingSitesModel : IBaseModel, INotifyPropertyChanged, ICommonInterface
    {
        ExtRangeCollection<TreePlantDetailEditList> Records { get; set; }

        ObservableRangeCollection<TreePlantAccessDto> TreePlantAccessLookup { get; set; }

        ObservableRangeCollection<TreePlantTerrainDto> TreePlantTerrainLookup { get; set; }

        TreePlantDetailEditList EditRecord { get; set; }

        TreePlantEditList TreePlantingId { get; set; }

    }
}