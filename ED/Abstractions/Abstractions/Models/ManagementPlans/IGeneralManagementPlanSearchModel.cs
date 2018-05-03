using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using MvvmHelpers;

namespace Abstractions
{
    public interface IGeneralManagementPlanSearchModel<T> : IBaseModel, INotifyPropertyChanged
    {
        ObservableRangeCollection<T> SearchData { get; set; }



        ICommand LoadData { get; set; }

        T SelectedRecord { get; set; }


        ObservableRangeCollection<T> SelectedRecords { get; set; }
        void RadGridSelectionChanged(object sender, object e);

        bool IsDetailOpen { get; set; }
    }

     
}