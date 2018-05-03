using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.Safety.Editors;
using Abstractions.Navigation;

using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    
    public class SafetyEditorModel : GeneralModelBase, ISafetyEditorModel
    {
     

        private HazardEditList _selectedRow;

        private ISafetyStore _iSafetyStore;


        private bool _hazardsListActive =true;

        private bool _siteBasedControlMeasuresActive = false;

        private bool _firePlanActive = false;

        private bool _biosecurityZoneActive = false;

        private bool _personalLocalIssuesActive = false;

        private bool _probabilitySeverityInjuryTableActive = false;





        public bool HazardsListActive {
            get
            {
                return _hazardsListActive;
                
            }
            set
            {
                _hazardsListActive = value;

            //    if (!value) SiteBasedControlMeasuresActive = true;
                OnPropertyChanged();
            }
        }

        public bool SiteBasedControlMeasuresActive
        {
            get
            {
                return _siteBasedControlMeasuresActive;

            }
            set
            {
                _siteBasedControlMeasuresActive = value;
               // if (!value) HazardsListActive = true;
                OnPropertyChanged();
            }
        }

        public bool FirePlanActive
        {
            get
            {
                return _firePlanActive;

            }
            set
            {
                _firePlanActive = value;
              //  if (!value) HazardsListActive = true;
                OnPropertyChanged();
            }
        }

        public bool BiosecurityZoneActive
        {
            get
            {
                return _biosecurityZoneActive;

            }
            set
            {
                _biosecurityZoneActive = value;
              //  if (!value) HazardsListActive = true;
                OnPropertyChanged();
            }
        }

        public bool PersonalLocalIssuesActive
        {
            get
            {
                return _personalLocalIssuesActive;

            }
            set
            {
                _personalLocalIssuesActive = value;
              //  if (!value) HazardsListActive = true;
                OnPropertyChanged();
            }
        }

        public bool ProbabilitySeverityInjuryTableActive
        {
            get
            {
                return _probabilitySeverityInjuryTableActive;

            }
            set
            {
                _probabilitySeverityInjuryTableActive = value;
             //   if (!value) HazardsListActive = true;
                OnPropertyChanged();
            }
        }









        public ObservableRangeCollection<HazardTypeDtoLookup> HazardTypeLookup { get; } = new ObservableRangeCollection<HazardTypeDtoLookup>();

        public ObservableRangeCollection<HazardCategoryDtoLookup> HazardCategoryLookup { get; } = new ObservableRangeCollection<HazardCategoryDtoLookup>();

        public ObservableRangeCollection<HazardOwnershipDtoLookup> HazardOwnershipLookup { get; } = new ObservableRangeCollection<HazardOwnershipDtoLookup>();




        public HazardEditList EditRecord
        {
            get
            {
                if (Records.Count == 0) return null;

                return _selectedRow ?? Records[0];
            }

            set
            {
                if (_selectedRow == value) return;


                _selectedRow = value;

                OnPropertyChanged();
            }
        } 


        public ExtRangeCollection<HazardEditList> Records { get; set; }



        public RiskAssessmentEdit RiskAssessmentDto { get; set; }




        public SafetyEditorModel(IWTTimer iWTimer, ISafetyStore iSafetyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService,
           INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
           ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iSafetyStore = iSafetyStore;

            Records = new ExtRangeCollection<HazardEditList>(iDialogService);

            RiskAssessmentDto = new RiskAssessmentEdit();

            HazardTypeLookup.ReplaceRange(_iSafetyStore.GetHazardTypeDtos());

            HazardCategoryLookup.ReplaceRange(_iSafetyStore.GetHazardCategoryDtos());

            HazardOwnershipLookup.ReplaceRange(_iSafetyStore.GetHazardOwnershipDtos());


            PropertyChanged += (sender, e) =>
            {                
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(HazardEditList.MakeCollection(_iSafetyStore.GetHazardDtos(ParentID)));

                        var rec = _iSafetyStore.GetRiskAssessmentDto(ParentID);

                        RiskAssessmentDto.Make(rec);
                         
                        break;                  
                }
                
            };

            LoadData = new RelayCommand((x) =>
            {

            });

            Autherise = new RelayCommand((x) =>
            {

            });

            ShowHazardMap = new RelayCommand((x) =>
            {
                
            });

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("test safety save");
                _iSafetyStore.UpdateRiskAssessment(ParentID, RiskAssessmentDto.ConvertToDto());

                _iSafetyStore.UpdateHazards(ParentID, Records.Select(s=>s.ConvertToDto()).ToList());

            });

            AddCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("test safety add");
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

            });

            SwitchScreens();
        }

        private void SwitchScreens()
        {
            ShowHazardsList = new RelayCommand((x) =>
            {                
                FirePlanActive = false;
                BiosecurityZoneActive = false;
                PersonalLocalIssuesActive = false;
                ProbabilitySeverityInjuryTableActive = false;       
                    
                HazardsListActive = !HazardsListActive;

                if (!HazardsListActive)
                    SiteBasedControlMeasuresActive = true;
                else
                    SiteBasedControlMeasuresActive = false;

            });


            ShowShowSiteBasedControlMeasures = new RelayCommand((x) =>
            {
                FirePlanActive = false;
                BiosecurityZoneActive = false;
                PersonalLocalIssuesActive = false;
                ProbabilitySeverityInjuryTableActive = false;
                

                SiteBasedControlMeasuresActive = !SiteBasedControlMeasuresActive;

                if (!SiteBasedControlMeasuresActive)
                    HazardsListActive = true;
                else
                    HazardsListActive = false;

            });

            ShowFirePlan = new RelayCommand((x) =>
            {
                SiteBasedControlMeasuresActive = false;
                BiosecurityZoneActive = false;
                PersonalLocalIssuesActive = false;
                ProbabilitySeverityInjuryTableActive = false;               
                FirePlanActive = !FirePlanActive;

                if (!FirePlanActive)
                    HazardsListActive = true;
                else
                    HazardsListActive = false;
            });

            ShowBiosecurityZone = new RelayCommand((x) =>
            {
                SiteBasedControlMeasuresActive = false;
                FirePlanActive = false;
                PersonalLocalIssuesActive = false;
                ProbabilitySeverityInjuryTableActive = false;
              

                BiosecurityZoneActive = !BiosecurityZoneActive;

                if (!BiosecurityZoneActive)
                    HazardsListActive = true;
                else
                    HazardsListActive = false;
            });

            ShowPersonalLocalIssues = new RelayCommand((x) =>
            {
                SiteBasedControlMeasuresActive = false;
                FirePlanActive = false;
                BiosecurityZoneActive = false;
                ProbabilitySeverityInjuryTableActive = false;
         
                PersonalLocalIssuesActive = !PersonalLocalIssuesActive;

                if (!PersonalLocalIssuesActive)
                    HazardsListActive = true;
                else
                    HazardsListActive = false;
            });

            ShowProbabilitySeverityInjuryTable = new RelayCommand((x) =>
            {
                SiteBasedControlMeasuresActive = false;
                FirePlanActive = false;
                BiosecurityZoneActive = false;
                PersonalLocalIssuesActive = false;
          
                ProbabilitySeverityInjuryTableActive = !ProbabilitySeverityInjuryTableActive;

                if (!ProbabilitySeverityInjuryTableActive)
                    HazardsListActive = true;
                else
                    HazardsListActive = false;
            });
        }


        protected void AddNew()
        {
            var newRecord = new HazardEditList();
            newRecord.Make(new HazardDto()
            {
                HazardType = HazardTypeLookup.First(f=>f.Id!=0),
                Description = "new record",
                GridReference = "grid ref",
                ManagementUnitId = ParentID,
                MapRef = "map ref",
                Ownership = HazardOwnershipLookup.First(x=>x.Id!=0)
            });

            Records.AddItem(newRecord, true);

            EditRecord = newRecord;

        }








        public ICommand LoadData { get; protected set; }

        public ICommand Autherise { get; protected set; }

        public ICommand ShowHazardsList { get; protected set; }

        public ICommand ShowShowSiteBasedControlMeasures { get; protected set; }

        public ICommand ShowFirePlan { get; protected set; }

        public ICommand ShowBiosecurityZone { get; protected set; }

        public ICommand ShowPersonalLocalIssues { get; protected set; }

        public ICommand ShowProbabilitySeverityInjuryTable { get; protected set; }

        public ICommand ShowHazardMap { get; protected set; }
    }
}
