using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVDoubleBoxModel : IBaseModel, INotifyPropertyChanged
    {
        Property<double> Double { get; set; }
 
        string Label { get; set; }

        bool ReadOnly { get; set; }

        void Selected(object sender, object e);

    }


    public interface IVDoubleBoxNullableModel : IBaseModel, INotifyPropertyChanged
    {
        void Selected(object sender, object e);

        Property<double?> Double { get; set; }

        string Label { get; set; }

        bool ReadOnly { get; set; }

    }
}