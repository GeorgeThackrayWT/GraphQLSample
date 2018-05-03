using System.ComponentModel;
using System.Windows.Input;
using Abstractions;

namespace EDCORE.ViewModel.Widgets.Interfaces
{
    public interface INavOptions : IBaseModel, INotifyPropertyChanged
    {
        ICommand BackCommand { get; }

        string Parent { get; set; }
    }


}
