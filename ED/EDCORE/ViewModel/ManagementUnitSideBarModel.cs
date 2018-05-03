using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{

    // so what do we need in here
    //user list
    
    //role list

    //calls to populate both


    public class ManagementUnitSideBarModel : GeneralModelBase, IManagementUnitSideBarModel, ISubscriber<EdMessage>
    {
        private int _selectedManagementUnitId = 0;
        private List<int> _clickHistory = new List<int>();

        private double _headerHeight = 0;
        private readonly ILinkContainer _iManagementPlanLinkContainer;
        private readonly IManagementUnitStore _managementUnitStore;
        private readonly IUserStore _iUserStore;
        private readonly IApplicationStore _iApplicationStore;
        private readonly IPlatformEventHandling _iPlatformEventHandling;
 
        private readonly ExtRangeCollection<UserEditList> _userList
            = new ExtRangeCollection<UserEditList>();

        private readonly ObservableCollection<ApplicationDto> _applicationFilters 
            = new ObservableCollection<ApplicationDto>();

        ApplicationDto _selectedApplicationFilter;
  
        public ICommand FilterChangedCommand => new RelayCommand<object>(FilterChanged);

   
        public ICommand FilterSelectionCommand => new RelayCommand<object>(SelectionChanged);

        public ExtRangeCollection<ManagementUnitShortEditList> ManagementUnitsList { get; set; }

        public ManagementUnitShortEditList EditManagementUnits { get; set; }


        public ObservableCollection<ApplicationDto> ApplicationLookup => _applicationFilters;
     
        public ApplicationDto SelectedApplicationFilter
        {
            get
            {

                if (_selectedApplicationFilter != null)
                    return _selectedApplicationFilter;
                else
                    return _applicationFilters[0];
            }
            set
            {
                if (_selectedApplicationFilter != value)
                {
                    _selectedApplicationFilter = value;
                                        
                    OnPropertyChanged();
                }
            }
        }

        private UserEditList _editUser;

        public UserEditList EditUsers
        {
            get { return _editUser; }

            set
            {
                if (_editUser?.ID != value?.ID)
                {
                    _editUser = value;
                    OnPropertyChanged();
                }
            }
        }

        public ExtRangeCollection<UserEditList> Users => _userList;

        public ICommand ManagementUnitLoad => new RelayCommand<object>(FilterChanged);

        public double HeaderHeight {
            get { return _headerHeight; }

            set
            {
                _headerHeight = value;
                OnPropertyChanged();
            }
        }

        public ManagementUnitSideBarModel(
            IManagementUnitStore iManagementUnitStore, IUserStore iUserStore,   IWTTimer iWTimer,
            ITelerikConvertors iTelerikConvertors, ILinkContainer iManagementPlanLinkContainer,
            IApplicationStore iApplicationStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus, 
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)

        {
            HeaderHeight = 60;

            _iManagementPlanLinkContainer = iManagementPlanLinkContainer;
            _managementUnitStore = iManagementUnitStore;
            _iApplicationStore = iApplicationStore;
            _iUserStore = iUserStore;
            _iTelerikConvertors = iTelerikConvertors;
            _iPlatformEventHandling = iPlatformEventHandling;

            ManagementUnitsList = new ExtRangeCollection<ManagementUnitShortEditList>();

            LoadFilters();

            LoadManagementUnits();

            LoadUserList();

            PropertyChanged += (sender, e) =>
            {

                switch (e.PropertyName)
                {
                    case "SelectedApplicationFilter":                    
                        LoadManagementUnits();

                        _iCache.SetApplication(SelectedApplicationFilter.ID);

                        iPageMessageBus.Publish(new EdMessage
                        {
                            EdEvent = EdEvent.ApplicationChanged,
                            Data = _selectedApplicationFilter.ID,
                            InstanceId = Guid.NewGuid()
                        });

                        break;

                    case "EditUsers":
                        _iCache.SetLoggedInUser(this.EditUsers.ID);

                        iPageMessageBus.Publish(new EdMessage
                        {
                            EdEvent = EdEvent.ApplicationChanged,
                            Data = SelectedApplicationFilter.ID,
                            InstanceId = Guid.NewGuid()
                        });
                        break;


                }
            };
        }

        
        private void LoadFilters()
        {
            Debug.WriteLine("LoadFilters");

            var cbItems = _iApplicationStore.GetApplications();

            _applicationFilters.Clear();
            foreach (var p in cbItems)
            {
                _applicationFilters.Add(p);
            }
        }
        
        private void LoadManagementUnits()
        {
            Debug.WriteLine("LoadManagementUnits");

            var results = SelectedApplicationFilter.ID == 99 ? 
                _managementUnitStore.GetManagementUnitLookupData() : 
                _managementUnitStore.GetManagementUnitLookupData(SelectedApplicationFilter.ID);

            ManagementUnitsList.ReplaceRange(ManagementUnitShortEditList.MakeCollection(results));
        }

        private void LoadUserList()
        {
            var results  = _iUserStore.GetUserDtos();

            Users.ReplaceRange(UserEditList.MakeCollection(results));                   
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.PageChanged)
            {
                var cid = _iCache.CurrentUser();

                var user = Users.FirstOrDefault(f => f.ID == cid);

                if (user != null)
                    EditUsers = user;

                switch (_iNavigation.CurrentLocation)
                {
                    case "SafetyPage":
                        HeaderHeight = 36;
                        break;
                    case "TreePlantingSearchPage":
                        HeaderHeight = 36;
                        break;
                    case "PublicInformationPage":
                        HeaderHeight = 36;
                        break;
                    case "ManagementPlansPage":
                        HeaderHeight = 36;
                        break;
                    case "InternalAuditsPage":
                        HeaderHeight = 36;
                        break;
                    case "AdminGeneralDetails":
                        HeaderHeight = 75;
                        break;
                    case "AdministrationList":
                        HeaderHeight = 75;
                        break;
                    case "GrantContractsList":
                        HeaderHeight = 36;
                        break;
                    case "ConditionAssessment":
                        HeaderHeight = 36;
                        break;
                    case "SummaryDescriptionList":
                        HeaderHeight = 36;
                        break;
                    case "ObjectivesKFList":
                        HeaderHeight = 36;
                        break;
                    case "WorkProgrammeList":
                        HeaderHeight = 36;
                        break;
                    case "PurchaseOrdersList":
                        HeaderHeight = 36;
                        break;
                    case "SalesOrdersList":
                        HeaderHeight = 36;
                        break;
                    case "MonitoringList":
                        HeaderHeight = 36;
                        break;
                    case "HarvestingList":
                        HeaderHeight = 36;
                        break;
                    case "Tasks":
                        HeaderHeight = 36;
                        break;
                    case "PropertyPage":
                        HeaderHeight = 36;
                        break;
                    case "ReferenceInformationList":
                        HeaderHeight = 36;
                        break;
                    case "TreePlantingPage":
                        HeaderHeight = 36;
                        break;
                    case "AdministrationEditor":
                        HeaderHeight = 50;
                        break;

                    default:
                        HeaderHeight = 36;
                        break;
                }
            }

            base.HandleMessage(message);
        }

        private void FilterChanged(object cellValue)
        {
            var column = _iTelerikConvertors.GetCellColumnName(cellValue);

            var result = _iTelerikConvertors.GetCellItem(cellValue);

            ManagementUnitShortEditList managementUnitShort = (ManagementUnitShortEditList)result;
            
            // needs 3 click mechanism

            
         
               
            _iCache.SetManagementUnitId(managementUnitShort.ManagementUnitId);

            if (_clickHistory.Contains(managementUnitShort.ManagementUnitId))
            {
                if (_clickHistory.Count > 0)
                {
                    foreach (var manu in ManagementUnitsList)
                    {
                        if (manu.ManagementUnitId == managementUnitShort.ManagementUnitId)
                        {

                            manu.Selected = !manu.Selected;
                        }
                        else
                        {
                            manu.Selected = false;
                        }
                    }
                }
                else
                {
                    _iNavigation.SidebarNavigate(StateContainer.Create(managementUnitShort.ManagementUnitId, false));

                }

                _clickHistory.Add(managementUnitShort.ManagementUnitId);
            }
            else
            {
                //we've moved on to a different management unit
                //deselect everything
                _clickHistory = new List<int> {managementUnitShort.ManagementUnitId};

                foreach (var manu in ManagementUnitsList)
                {
                    manu.Selected = false;                   
                }
                _iCache.SetManagementUnitId(0);

                _iNavigation.SidebarNavigate(StateContainer.Create(managementUnitShort.ManagementUnitId, false));

            }



            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.ManagementUnitChanged,
                Data = managementUnitShort.ManagementUnitId
            });
            
        }

        private void SelectionChanged(object data)
        {
            Debug.WriteLine("double tap");
        }

    }
}