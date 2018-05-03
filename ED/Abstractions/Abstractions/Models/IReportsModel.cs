using System.Collections.ObjectModel;
using System.ComponentModel;
using DataObjects.DTOS;

namespace Abstractions.Models
{
    public interface IReportsModel : INotifyPropertyChanged
    {
        ObservableCollection<ReportDto> ReportsList { get; }
    }
}
