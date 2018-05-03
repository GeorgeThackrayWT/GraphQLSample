using System.ComponentModel;
using System.Windows.Input;
using DataObjects.DTOS;
using MvvmHelpers;

namespace Abstractions
{
    public interface IPropertyModel : IBaseModel, INotifyPropertyChanged
    {
        ObservableRangeCollection<PropertyDto> Properties { get;}

        ICommand LoadProperty { get; }

        PropertyDto SelectedProperty { get; set; }
    }

   

}