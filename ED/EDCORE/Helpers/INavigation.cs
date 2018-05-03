using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions.Helpers;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.ViewModel.Property;

namespace EDCORE.Helpers
{
    public class NavCouple : INavCouple
    {
        private Type _pageType;
        private INavigation _iNavigation;
        private readonly IPageMessageBus _iPageMessageBus;
    

        public NavCouple(INavigation iNavigation, Type pageType, IPageMessageBus iPageMessageBus)
        {
            _pageType = pageType;
            _iNavigation = iNavigation;
            _iPageMessageBus = iPageMessageBus;

      
        }

        public ICommand Command => new RelayCommand((x) =>
        {
          
            if (x == null) x =0;

            _iNavigation.Navigate(Editor(), StateContainer.Create((int) x, false));

        });
   
        public Type Editor()
        {
            return _pageType;
        }

 
    }

    public class AcqCouple : INavCouple
    {
        private Type _pageType;
        private INavigation _iNavigation;
 
        private static int _acquisitionUnitId = 0;

    
        public AcqCouple(INavigation iNavigation, Type pageType)
        {
            _pageType = pageType;
            _iNavigation = iNavigation;
         
    
        }

        public ICommand Command => new RelayCommand((x) =>
        {           
            var editor = Editor();

           

            switch (editor.Name)
            {
                case "LicenseEditor":
              
                    //pass in parameter with 2 values and parse
                    //still to do!"!!

                    Tuple<int, string> param = (Tuple<int, string>) x;

                    _iNavigation.Navigate(editor, StateContainer.Create(param.Item1, param.Item2, false));

                    break;
                default:

                    int tpAcqId = 0;


                    if (!Int32.TryParse(x.ToString(), out tpAcqId))
                        tpAcqId = _acquisitionUnitId;


                    _iNavigation.Navigate(editor, StateContainer.Create(tpAcqId, false));
                    break;
            }

        });

     

        public Type Editor()
        {
            return _pageType;
        }

       
    }

}

