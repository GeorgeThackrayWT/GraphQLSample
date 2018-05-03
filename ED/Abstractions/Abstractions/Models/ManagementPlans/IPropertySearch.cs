using System.Windows.Input;
using DataObjects;
using MvvmHelpers;

namespace Abstractions
{
    public interface IPropertySearch<T> : IGeneralManagementPlanSearchModel<T>
    {

        ManagementUnitDto SelectedManagementUnitDto { get; set; }

        ObservableRangeCollection<ManagementUnitDto> FindResults { get; }

        string FindQuery { get; set; }

        ICommand FindCommand { get; set; }

        ICommand SelectCommand { get; set; }

        ICommand NewComand { get; set; }

        ICommand CancelCommand { get; set; }
    }
}