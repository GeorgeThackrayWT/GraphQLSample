using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DataObjects
{
    public class Property<T> : BindableBase, IProperty
    {


        public Property()
        {
            // TODO: train the serializer
            this.Errors.CollectionChanged += (s, e) => OnPropertyChanged("IsValid");
        }

        ObservableCollection<string> _Errors = new ObservableCollection<string>();
        public ObservableCollection<string> Errors { get { return _Errors; } private set { _Errors = value; } }


        public string Name { get; set; }

        public bool IsDirty
        {
            get
            {
                if (this.Value == null && this.Original == null)
                    return false;
                else if (this.Value == null && this.Original != null)
                    return true;
                else
                {
                    //we need this hack because date picker control insists
                    //on converting null datetime to 1 Jan 1918!!!!
                    if (Value.GetType().Name == "DateTime")
                    {
                        DateTime tp = DateTime.Parse(Value.ToString());

                        if (tp.Year == 1918)
                        {
                            tp = new DateTime(1,1,1);

                            return !tp.Equals(this.Original);
                        }
                        else
                        {
                            return !this.Value.Equals(this.Original);
                        }
                    }
                    else
                    {
                        return !this.Value.Equals(this.Original);
                    }
                    
                }
                
            }
        }

        public bool IsValid { get { return !this.Errors.Any(); } }

        bool _IsEnabled = default(bool);
        public bool IsEnabled { get { return _IsEnabled; } set { base.SetProperty(ref _IsEnabled, value); } }

        T _Original = default(T);
        public T Original
        {
            get { return _Original; }
            set
            {
                ValueHasBeenSet = true;
                SetProperty(ref _Original, value);
            }
        }

        private bool ValueHasBeenSet = false;

        T _Value = default(T);
        public T Value
        {
            get { return _Value; }
            set
            {
               // if(Name!=null)
               // Debug.WriteLine("test test");

                if (!ValueHasBeenSet)
                    Original = value;


                if (Name != null)
                    SetProperty(ref _Value, value, Name);
                else
                    SetProperty(ref _Value, value);


                OnPropertyChanged("IsDirty");
            }
        }

        public void Revert()
        {
            this.Value = this.Original;
        }

        public override string ToString()
        {
            if (this.Value == null)
                return string.Empty;
            return this.Value.ToString();
        }

        public static Property<T> Make(T value, string name ="")
        {
            return new Property<T>() {
                Value = value,
                Original = value,
                Name =name
            };
        }

        public static Property<T> Make(T value, Property<T> xprop, string name = "")
        {
            if (xprop != null)
            {
                xprop.Value = value;
                xprop.Original = value;
                xprop.Name = name;

                return xprop;
            }

            return new Property<T>()
            {
                Value = value,
                Original = value,
                Name = name
            };
        }

        public bool IsDisplayOnly { get; set; }

        public void Dispose()
        {
            this.ClearPropertyChanged();
            


        }

    }
}
