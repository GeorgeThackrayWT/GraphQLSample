using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;

namespace Abstractions.Models
{
    public interface IDocumentsModel : INotifyPropertyChanged
    {
        ObservableCollection<DocumentDto> DocumentsList { get; }
    }
}
