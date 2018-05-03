using System;
using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVDatePickerModel : IBaseModel, INotifyPropertyChanged
    {
        void Selected(object sender, object e);

        Property<DateTime?> Selection { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

    }


}