﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Abstractions;

namespace DataObjects
{
    public abstract class PropertyBase<T> : BindableBase,IChangeTracking, IPropertyRecord, IModel where T : IModel
    {
        public bool Disposed { get; private set; } = false;

        public PropertyBase()
        {
           
            
        }


        public void SetPropChanged() {

            // whenever a property is changed, validate the model
            foreach (var property in this.Properties().Select(x => x.GetValue(this) as IProperty))
            {
                if (property != null)
                {
                    //    Debug.WriteLine("added property changed");

                    property.PropertyChanged += (s, e) =>
                    {
                        if (e is ExtPropertyChangedEventArgs exte)
                        {
                            //    Debug.WriteLine("property changed: " + e.PropertyName + " - "  +  s);

                            if (exte.PropertyName == "Value")
                            {
                                this.Validate();

                                if (exte.Tag != null)
                                    this.OnPropertyChanged("validation", exte.Tag);
                                else
                                    this.OnPropertyChanged("validation");
                            }
                        }
                        else
                        {
                            if (e.PropertyName == "Value")
                            {
                                this.Validate();
                                this.OnPropertyChanged("validation");
                            }
                        }



                    };


                }

            }
        }

        ObservableCollection<string> _Errors = new ObservableCollection<string>();
        public ObservableCollection<string> Errors { get { return _Errors; } }

        bool _IsValid = true;
        public bool IsValid { get { return _IsValid; } set { SetProperty(ref _IsValid, value); } }

        bool _IsDirty = false;

        public bool IsDirty
        {
            get { return _IsDirty; }
            set
            {
                base.SetProperty(ref _IsDirty, value);
            }
        }

        private bool _IsNew = false;
        public bool IsNew { get { return _IsValid; } set { SetProperty(ref _IsNew, value); } }


        Action<IModel> _Validator = default(Action<IModel>);

        public Action<IModel> Validator
        {
            get
            {
                return _Validator;
            }
            set
            {
                SetProperty(ref _Validator, value);
            }
        }

     

        public void Revert()
        {
            foreach (var property in Properties().Select(x => x.GetValue(this) as IProperty))
                property.Revert();
        }

        public bool Validate()
        {
            var properties = Properties().Where(a => (a.GetValue(this) as IProperty)!=null).Select(x => x.GetValue(this) as IProperty);

            foreach (var property in properties)
            {
                property?.Errors.Clear();
            }

            this.Errors.Clear();

            Validator?.Invoke(this as IModel);


            foreach (var error in properties.SelectMany(x => x.Errors))
            {
                this.Errors.Add(error);
            }


            IsDirty = properties.Any(x => x.IsDirty);

            return IsValid = (properties.Any(x => !x.IsValid)) ? false : !this.Errors.Any();
        }

        private IEnumerable<PropertyInfo> _Properties;
        public IEnumerable<PropertyInfo> Properties()
        {
            if (_Properties != null)
                return _Properties;
            var typeinfo = typeof(IProperty).GetTypeInfo();
            var properties = typeof(T).GetRuntimeProperties();
            return _Properties = properties.Where(x => typeinfo.IsAssignableFrom(x.PropertyType.GetTypeInfo()));
        }




        public Property<DateTime> LMDT { get; set; }

        public Property<int?> LMUID { get; set; }

        public Property<DateTime?> CRDT { get; set; }

        public Property<int?> CRUID { get; set; }

        public Property<DateTime?> DLDT { get; set; }

        public Property<int?> DLUID { get; set; }

        public Property<int> Id { get; set; }

        public Property<bool> Deleted { get; set; }

        public void Dispose()
        {
            if (Disposed) return;

            Disposed = true;

            this.ClearPropertyChanged();


            var ps = typeof(T).GetRuntimeMethods();



            foreach (var p in ps)
            {
                

        //        Debug.WriteLine(p.Name);

                if(p.Name =="Dispose")
                    p.Invoke(this, null);
            }
        }
    }
}