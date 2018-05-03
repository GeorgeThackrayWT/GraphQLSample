using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS.TreePlanting;

namespace Abstractions.Models.TreePlanting
{
    public interface ITreePlantingModel : INotifyPropertyChanged
    {
        ObservableCollection<TreePlantingSearchDto> TreePlantings { get; }
    }
}
