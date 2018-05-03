using System;

namespace DataObjects.DTOS
{
    public class MenuDTO :BindableBase
    {
        private string _text;
        private string _param;
        private bool _visible;

        private Type _navigationDestination;
        
        public int Id { get; set; }

        public int? ParentMenuId { get; set; }
        
        public string Destination { get; set; }
        
        public string Text { get; set; }

        public Type NavigationDestination { get; set; }

        public bool IsNavigation => _navigationDestination != null;

        public bool IsVisible {
            get { return _visible; }
            set
            {                
                SetProperty(ref _visible, value);
            }
        }

    }
}
