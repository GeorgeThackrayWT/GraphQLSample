using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class ApplicationContainerModel : GeneralModelBase, IApplicationContainerModel
    {
        private ICache _cache;
        private bool _isPaneOpen;
        private bool _isSubFilterOpen;
        private bool _suppressPane;

        private MenuDTO _selectSubMenuDto;
        private MenuDTO _selectMenuDto;
        private MessageFilter _messageFilter = new MessageFilter();
        private IPageLookup _pageLookup;


        public ObservableRangeCollection<MenuDTO> Menu { get; }

        public ObservableRangeCollection<MenuDTO> SubMenu { get; private set; } 
            = new ObservableRangeCollection<MenuDTO>();

        public ICommand TogglePaneCommand => new RelayCommand<object>((o) =>
        {
            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.PaneButtonClicked,
                Data = IsPaneOpen
            });

            if (_suppressPane) return;

            IsPaneOpen = !IsPaneOpen;
        });


        public MenuDTO SelectedMenu
        {
            get
            {
                if (_selectMenuDto != null)
                    return _selectMenuDto;
                else
                    return Menu[0];
            }
            set
            {
                SetProperty(ref _selectMenuDto, value);
            }
        }

        public bool IsPaneOpen
        {
            //introduce something like 'ispane needed' here
            //
            get { return _isPaneOpen; }

            set { SetProperty(ref _isPaneOpen, value); }
        }

        public object Frame
        {
            get { return _iNavigation.Frame; }

            set
            {               
                _iNavigation.Frame = value;
                OnPropertyChanged();
            }
        }

        public MenuDTO SelectedSubMenu
        {
            get
            {
                if (_selectMenuDto != null)
                    return _selectSubMenuDto;
                else
                    return Menu[0];
            }
            set
            {
                SetProperty(ref _selectSubMenuDto, value);
            }
        }

        public bool IsSubFilterOpen
        {
            get { return _isSubFilterOpen; }

            set { SetProperty(ref _isSubFilterOpen, value); }
        }

        public int TopRowHeight { get; set; }

        public ApplicationContainerModel(IMenuFormatter iMenu, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer, IPageLookup iPageLookup,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            TopRowHeight = 50;

            _cache = iCache;
            _pageLookup = iPageLookup;

            PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                Debug.WriteLine("Property Changed: " + e.PropertyName);

                switch (e.PropertyName)
                {
                    case "SelectedMenu":                                                
                        SetSubMenus(iMenu);
                        GoToPage(GetSubPageTarget());                       
                        break;

                    case "SelectedSubMenu":
                        GoToPage(GetSubPageTarget());
                        break;

                    case "Frame": //frame set
                        GoToPage(GetSubPageTarget());
                        break;

                    case "IsPaneOpen":
                        Debug.WriteLine(_iNavigation.CurrentLocation);

                        //LocalSettings.Instance.
                      
                        break;
                }
            };

            

            Menu = iMenu.GetTier1Menus();

            SelectedMenu = Menu.First(f => f.Text == "Tasks");
        }
        
        private MenuDTO GetSubPageTarget()
        {
            MenuDTO result;

            // ok so we have no submenus
            if (SubMenu.Count == 0)
            {
                result = SelectedMenu;
            }
            else
            {
                if (SelectedSubMenu != null) return SelectedSubMenu;

                result = SubMenu.First();
            }


            return result;
        }

        private void SetSubMenus(IMenuFormatter iMenu)
        {
            var newMenus = new ObservableCollection<MenuDTO>();


            var tpMenus = iMenu.GetTier2Menus();

            foreach (var m in tpMenus)
            {
                if (m.ParentMenuId == _selectMenuDto.Id)
                {
                    newMenus.Add(m);
                }
            }

            if (newMenus.Count ==0)
            {
                IsSubFilterOpen = false;
                TopRowHeight = 50;
            }
            else
            {
                IsSubFilterOpen = true;
                TopRowHeight = 100;
            }

            OnPropertyChanged("TopRowHeight");

            SubMenu.ReplaceRange(newMenus);        
        }


        private void GoToPage(MenuDTO si)
        {

            var manuid = _cache.GetManagementUnitId();

            if (manuid == 0)
            {

                if (!_iNavigation.OnPage(si.NavigationDestination))
                {
                    _iNavigation.Navigate(si.NavigationDestination);
                }
                else
                {
                    PageMessageBus.Publish(new EdMessage()
                    {
                        EdEvent = EdEvent.AppConSelectionChanged,
                        Data = si
                    });
                }
            }
            else
            {
                var newDest = _pageLookup.PageEditorType(si.Destination);

                _iNavigation.Navigate(newDest, StateContainer.Create(manuid, false));
            }

        }
    
        public void NavigatedTo()
        {
            _iNavigation.EnableBackButton();
        }

        public void GridSelectionChanged(object sender, object e)
        {
         
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            _messageFilter.FilterHandledMessages(message, "");

            switch (message.EdEvent)
            {
                case EdEvent.PageChanged:

         //           Debug.WriteLine("page changed to: " + message.Data.ToString());
                    switch (message.Data.ToString())
                    {                  
                        case "AdministrationList":
                        case "GrantContractsList":
                        case "ConditionAssessment":
                        case "SummaryDescriptionList":
                        case "ObjectivesKFList":
                        case "WorkProgrammeList":
                        case "PurchaseOrdersList":
                        case "SalesOrdersList":
                        case "MonitoringList":
                        case "HarvestingList":
                        case "Tasks":
                        case "PropertyPage":
                        case "ReferenceInformationList":
                        case "TreePlantingPage":
                            _suppressPane = true;
                            IsPaneOpen = false;
                            break;
                            
                        default:
                            _suppressPane = false;
                            break;
                    }
                    break;

            }
        }
    }




}
