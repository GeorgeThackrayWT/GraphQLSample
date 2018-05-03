using System.ComponentModel;
using Abstractions;
using DataObjects;

namespace EDCORE.ViewModel.Widgets
{
    public interface IVTextBoxModel : IBaseModel, INotifyPropertyChanged
    {
        Property<string> Text { get; set; }
     
        string Label { get; set; }

        bool ReadOnly { get; set; }

        void Selected(object sender, object e);
    }

}