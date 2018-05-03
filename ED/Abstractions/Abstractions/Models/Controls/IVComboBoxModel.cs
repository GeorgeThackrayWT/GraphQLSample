using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Abstractions;
using DataObjects;
using MvvmHelpers;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVComboBoxModel : IBaseModel, INotifyPropertyChanged
    {
        bool ReadOnly { get; set; }

        object Parent { get; set; }

        string Label { get; set; }

        object Filter { get; set; }

        ObservableRangeCollection<ComboBoxValue> Source { get; }

        ComboBoxValue Selection { get; set; }
         
        Dictionary<string, Func<ILookupStore, int, List<ComboBoxValue>>> DataMethods { get; }

        Property<int> SelectedItem { get; set; }

        ICommand SelectionChangedCommand { get; set; }

        void Dispose();

    }
}