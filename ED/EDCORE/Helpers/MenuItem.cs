//using System;
//using System.Collections.ObjectModel;
//using System.Windows.Input;
//using DataObjects;

//namespace EDCORE.Helpers
//{

   


//    public class MenuItem : BindableBase
//    {
//        private string _glyph;
//        private string _text;
//        private string _param;
//        private DelegateCommand _command;
//        private Type _navigationDestination;


//        public ObservableCollection<MenuItem> SubMenu { get; set; }

//        public string Glyph
//        {
//            get { return _glyph; }
//            set { SetProperty(ref _glyph, value); }
//        }

//        public string Text
//        {
//            get { return _text; }
//            set { SetProperty(ref _text, value); }
//        }

//        public ICommand Command
//        {
//            get { return _command; }
//            set { SetProperty(ref _command, (DelegateCommand)value); }
//        }

//        public Type NavigationDestination
//        {
//            get { return _navigationDestination; }
//            set { SetProperty(ref _navigationDestination, value); }
//        }

//        public string Param
//        {
//            get { return _param; }
//            set { SetProperty(ref _param, value); }
//        }

//        public bool IsNavigation => _navigationDestination != null;
//    }
//}
