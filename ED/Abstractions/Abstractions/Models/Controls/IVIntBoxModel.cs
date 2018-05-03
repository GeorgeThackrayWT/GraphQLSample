using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVIntBoxNullableModel : IBaseModel, INotifyPropertyChanged
    {
        Property<int?> Int { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

        void Selected(object sender, object e);
    }

    public interface IVIntBoxModel : IBaseModel, INotifyPropertyChanged
    {
        Property<int> Int { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

        void Selected(object sender, object e);
    }


}