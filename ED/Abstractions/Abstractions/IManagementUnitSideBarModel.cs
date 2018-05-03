using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using EDCORE.ViewModel;
using MvvmHelpers;

namespace Abstractions
{
    public interface IManagementUnitSideBarModel : INotifyPropertyChanged
    {
        ApplicationDto SelectedApplicationFilter { get; set; }
        ObservableCollection<ApplicationDto> ApplicationLookup { get; }


        ManagementUnitShortEditList EditManagementUnits { get; set; }
        ExtRangeCollection<ManagementUnitShortEditList> ManagementUnitsList { get; set; }


        UserEditList EditUsers { get; set; }
        ExtRangeCollection<UserEditList> Users { get; }

            
        ICommand FilterChangedCommand { get; }

        ICommand FilterSelectionCommand { get; }

        ICommand ManagementUnitLoad { get; }

        double HeaderHeight { get; }

    }
}
