using System.ComponentModel;
using System.Windows.Input;
using DataObjects.DTOS;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public interface IApplicationContainerModel : INotifyPropertyChanged
    {

        object Frame { get; set; }

        ObservableRangeCollection<MenuDTO> Menu { get; }
        ObservableRangeCollection<MenuDTO> SubMenu { get; }

        MenuDTO SelectedMenu { get; set; }

        MenuDTO SelectedSubMenu { get; set; }

        ICommand TogglePaneCommand { get; }

        bool IsPaneOpen { get; set; }

        bool IsSubFilterOpen { get; set; }

        void GridSelectionChanged(object sender, object e);

        void NavigatedTo();

        int TopRowHeight { get; set; }

    }
}