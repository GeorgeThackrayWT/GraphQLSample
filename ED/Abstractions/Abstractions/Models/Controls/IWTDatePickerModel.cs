using System;
using System.ComponentModel;
using Abstractions;

namespace EDCORE.ViewModel.Widgets
{
    public interface IWTDatePickerModel : IBaseModel, INotifyPropertyChanged
    {
        void Selected(object sender, object e);

        DateTime? Selection { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

    }
}