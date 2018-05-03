using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataObjects
{
    public interface IModel
    {
        void SetPropChanged();


        event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<string> Errors { get; }
        Action<IModel> Validator { get; set; }
        bool IsValid { get; }
        bool IsDirty { get; }
        bool Disposed { get; }
        bool Validate();
        void Revert();

        void Dispose();

    }
}