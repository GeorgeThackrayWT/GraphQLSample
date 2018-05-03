using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVBoolBoxModel : IBaseModel, INotifyPropertyChanged
    {
        Property<bool> Bool { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }


        void Selected(object sender, object e);
    }

    public interface IVBoolBoxNullableModel : IBaseModel, INotifyPropertyChanged
    {
        Property<bool?> Bool { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

        void Selected(object sender, object e);

    }
}