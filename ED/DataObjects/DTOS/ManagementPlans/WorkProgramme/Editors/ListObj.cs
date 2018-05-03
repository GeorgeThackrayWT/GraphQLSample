using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Abstractions;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class ListObj<T>: IModel where T : IRecord,  new() 
    {
        protected T _original;
        protected T _current;

        private bool isDirty = false;
        private bool isDeleted = false;

        public ObservableCollection<string> Errors { get; set; } = new ObservableCollection<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsValid { get; set; } = false;

        public bool IsDirty => isDirty;

        Action<IModel> _Validator = default(Action<IModel>);

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="System.Runtime.CompilerServices.CallerMemberNameAttribute"/>.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Action<IModel> Validator
        {
            get => _Validator;
            set => SetProperty(ref _Validator, value);
        }
        public void SetPropChanged() { }

        public bool Validate()
        {
            //this.Validate();

            Validator.Invoke(this);

            return true;
        }

        public void Revert()
        {
            this._current = this._original;
        }

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public bool Deleted
        {
            get => isDeleted;
            set => isDeleted = value;
        }

        public bool Disposed { get; private set; }

        public ListObj()
        {
            _original = new T();
            _current = new T();

            this.PropertyChanged = (e, s) =>
            {
                if (s.PropertyName != "CURRENT")
                {
                
                    Validate();

                    Type myClassType = this._current.GetType();
                    var properties = myClassType.GetRuntimeProperties();

                    Dictionary<string, string> currentProperties = properties.ToDictionary(property => property.Name,
                        property => property.GetValue(this._current, null)?.ToString());


                    myClassType = this._original.GetType();
                    properties = myClassType.GetRuntimeProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        //    Debug.WriteLine("Name: " + property.Name + ", Value: " + property.GetValue(this._original, null));

                        if (!currentProperties.ContainsKey(property.Name)) continue;

                        if (currentProperties[property.Name] != property.GetValue(_original, null)?.ToString())
                        {
                            isDirty = true;
                        }
                    }

                    OnPropertyChanged("CURRENT");
                }

                
            };
        }

        public virtual void Dispose()
        {
            PropertyChanged = null;
            Disposed = true;

        }
    }
}