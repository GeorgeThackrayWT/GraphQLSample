using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DataObjects
{
    //ObservableObject

    public class ExtPropertyChangedEventArgs: PropertyChangedEventArgs{

        public string Tag { get; set; }

        public ExtPropertyChangedEventArgs(string propertyName, string tag) : base(propertyName)
        {
            Tag = tag;
        }
    }

    public abstract class BindableBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Multicast event for property change notifications.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Checks if a property already matches a desired value.  Sets the property and
        /// notifies listeners only when necessary.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="storage">Reference to a property with both getter and setter.</param>
        /// <param name="value">Desired value for the property.</param>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers that
        /// support CallerMemberName.</param>
        /// <returns>True if the value was changed, false if the existing value matched the
        /// desired value.</returns>
        protected bool SetProperty<T>(ref T storage, T value, string tag = null, [CallerMemberName] String propertyName = null )
        {
            if (Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName, tag);
            return true;
        }

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="System.Runtime.CompilerServices.CallerMemberNameAttribute"/>.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null, string tag = null)
        {
            try
            {
                PropertyChanged?.Invoke(this, new ExtPropertyChangedEventArgs(propertyName, tag));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
              
            }
           
        }

        public void ClearPropertyChanged()
        {
            PropertyChanged = null;
        }


    }
}
