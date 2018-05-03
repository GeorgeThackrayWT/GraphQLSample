using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataObjects
{
    public interface IProperty : INotifyPropertyChanged
    {
        ObservableCollection<string> Errors { get; }
        bool IsValid { get; }
        bool IsDirty { get; }
        void Revert();

        void Dispose();
    }
}