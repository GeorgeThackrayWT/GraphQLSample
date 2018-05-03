using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects;
using MvvmHelpers;

namespace EDCORE.ViewModel.Widgets
{
    public interface IWTComboBoxModel :IBaseModel, INotifyPropertyChanged
    {
        object Parent { get; set; }

        string Label { get; set; }

        object Filter { get; set; }

        ObservableRangeCollection<ComboBoxValue> Source { get; }

        ComboBoxValue Selection { get; set; }

        int CachedSelectionID { get; set; }

        Dictionary<string, Func<ILookupStore,int, List<ComboBoxValue>>> DataMethods { get;  }

        bool ReadOnly { get; set; }

    }
}