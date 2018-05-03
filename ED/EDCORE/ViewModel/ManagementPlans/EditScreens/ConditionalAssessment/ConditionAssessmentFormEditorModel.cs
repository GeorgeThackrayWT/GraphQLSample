using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class ConditionAssessmentFormEditorModel : ConditionalAssessmentEditBase, IConditionAssessmentFormEditorModel
    {
        protected WoodlandSubsectionEditList SelectedWoodlandSubsectionDto;
        private IConditionalAssessmentsStore _iConditionalAssessmentsStore;

        private int _featureMonitoringID;

        #region mode 

        private bool _overallStructure=false;

        private bool _treeAges=false;

        private bool _treeSpecies=false;

        private bool _shrubSpecies=false;

        private bool _levelofTreeRegeneration=false;

        private bool _levelofShrubRegeneration=false;

        private bool _regenerationTreeSpecies=false;

        private bool _regenerationShrubSpecies=false;

        private bool _flora=false;

        private bool _deadwood=false;

        private bool _animalDamage=false;

        private bool _invasives=false;

        private bool _treeHealth=false;

        private bool _humanImpacts=false;

        #endregion

        public ConditionAssessmentFormEditorModel(IWTTimer iWTimer, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            IPlatformEventHandling iPlatformEventHandling, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iConditionalAssessmentsStore = iConditionalAssessmentsStore;

            Records = new ExtRangeCollection<WoodlandSubsectionEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {

                    //Records =
                    //    _iConditionalAssessmentsStore.GetCFContainerCollection(State.RecordId);

                    _featureMonitoringID = State.RecordId;

                    var data = _iConditionalAssessmentsStore.GetCFContainerCollection(_featureMonitoringID);


                    Records.ReplaceRange(WoodlandSubsectionEditList.MakeCollection(data));


                    Stratum.ReplaceRange(_iConditionalAssessmentsStore.GetCAStratums());

                    KeyFeatures.ReplaceRange(_iConditionalAssessmentsStore.GetCAKeyFeatures(_featureMonitoringID));


                    if (Records.Count > 0)
                    {                       
                        

                        EditRow = Records[0];
                    }
                }
            };



            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.Id == EditRow.Id).ContinueWith((a) => EditRow = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
            });

            SaveCommand = new RelayCommand((x) =>
            {
                //if (!_iUserStore.Check(UserActions.GroupB)) return;

                _iConditionalAssessmentsStore.UpdateCFContainerCollection(ManagementUnitId,FeatureMonitoringID,Records.Select(s=>s.ConvertToDto()).ToList());

                if (!Records.Errors())
                {
           
                    State.NewRecord = false;
                    OnPropertyChanged("State");
                }


            });
 
            CancelCommand = new RelayCommand((x) =>
            {
                Records.Rollback();


            });

            SetupModelModeVisibility();
        }

        private void AddNew()
        {
            var newRecord = new WoodlandSubsectionEditList();
            newRecord.Make(new WoodlandSubsectionDto()
            {
                KeyFeature = KeyFeatures.FirstOrDefault(),
                KeyFeatureDescription = KeyFeatures.FirstOrDefault()?.Description,
                KeyFeatureId = KeyFeatures.FirstOrDefault().ID,
                Stratum = Stratum.FirstOrDefault(),
                ManagementUnitId = State.RecordId,
                StratumDescription = Stratum.FirstOrDefault()?.Description,
                StratumId = Stratum.FirstOrDefault().ID
            });


            Records.AddItem(newRecord, true);

            EditRow = newRecord;
        }

        private void SetupModelModeVisibility()
        {
            //initial state
            SetVisibility(true, false, false, false, false, false, false, false, false, false, false, false, false, false);

            ShowOverallStructure =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(true, false, false, false, false, false, false, false, false, false, false, false, false,
                            false);
                    });

            ShowTreeAgees =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, true, false, false, false, false, false, false, false, false, false, false, false,
                            false);
                    });

            ShowTreeSpecies =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, true, false, false, false, false, false, false, false, false, false, false,
                            false);
                    });

            ShowShrubSpecies =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, true, false, false, false, false, false, false, false, false, false,
                            false);
                    });

            ShowLevelOfTreeRegeneration =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, true, false, false, false, false, false, false, false, false,
                            false);
                    });

            ShowLevelOfShrubRegeneration =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, true, false, false, false, false, false, false, false,
                            false);
                    });

            ShowRegenerationTreeSpecies =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, true, false, false, false, false, false, false,
                            false);
                    });

            ShowRegenerationShrubSpecies =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, true, false, false, false, false, false,
                            false);
                    });

            ShowFlora =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, true, false, false, false, false,
                            false);
                    });

            ShowDeadwood =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, false, true, false, false, false,
                            false);
                    });

            ShowAnimalDamage =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, false, false, true, false, false,
                            false);
                    });

            ShowInvasives =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, false, false, false, true, false,
                            false);
                    });

            ShowTreeHealth =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, false, false, false, false, true,
                            false);
                    });

            ShowHumanImpacts =
                new RelayCommand(
                    (x) =>
                    {
                        SetVisibility(false, false, false, false, false, false, false, false, false, false, false, false, false,
                            true);
                    });
        }

        private void InitComboData()
        {

        }

        private void SetVisibility(bool overallStructure, bool treeAges,   bool treeSpecies,
            bool shrubSpecies,  bool levelofTreeRegeneration,  bool levelofShrubRegeneration , bool regenerationTreeSpecies ,  
            bool regenerationShrubSpecies,   bool flora , bool deadwood ,
           bool animalDamage ,  bool invasives ,  bool treeHealth ,  bool humanImpacts )
        {
            OverallStructure = overallStructure;
            TreeAges = treeAges;
            TreeSpecies = treeSpecies;
            ShrubSpecies = shrubSpecies;
            LevelofTreeRegeneration = levelofTreeRegeneration;
            LevelofShrubRegeneration = levelofShrubRegeneration;
            RegenerationTreeSpecies = regenerationTreeSpecies;
            RegenerationShrubSpecies = regenerationShrubSpecies;
            Flora = flora;
            Deadwood = deadwood;
            AnimalDamage = animalDamage;
            Invasives = invasives;
            TreeHealth = treeHealth;
            HumanImpacts = humanImpacts;

            
        }


        public int ManagementUnitId { get; set; }

        public ExtRangeCollection<WoodlandSubsectionEditList> Records { get; set; } =
            new ExtRangeCollection<WoodlandSubsectionEditList>();

        public int FeatureMonitoringID
        {
            get
            {
                return _featureMonitoringID;
            }

            set
            {
                _featureMonitoringID =value;
                OnPropertyChanged();
            }
        }
        
        public ICommand LoadData { get; protected set; }
        
        public WoodlandSubsectionEditList EditRow
        {
            get
            {
                if(SelectedWoodlandSubsectionDto==null) return null;

                return SelectedWoodlandSubsectionDto ?? Records[0];


            }

            set
            {
                if (value == null)
                {
                    Debug.WriteLine("");
                }
                else
                {

                    if (SelectedWoodlandSubsectionDto == value) return;


                    SelectedWoodlandSubsectionDto = value;
                    Debug.WriteLine("sel row changed wcid: " + value.Id + " - keyfeat: " + value.KeyFeatureId +
                                    " - strat: " + value.StratumId);
                    OnPropertyChanged();
                }
            }
        }



        #region mode 

        public bool OverallStructure
        {
            get { return _overallStructure; }

            set
            {
                _overallStructure = value;
                OnPropertyChanged();
            }
        }

        public bool TreeAges
        {
            get { return _treeAges; }

            set
            {
                _treeAges = value;
                OnPropertyChanged();
            }
        }

        public bool TreeSpecies
        {
            get { return _treeSpecies; }

            set
            {
                _treeSpecies = value;
                OnPropertyChanged();
            }
        }

        public bool ShrubSpecies
        {
            get { return _shrubSpecies; }

            set
            {
                _shrubSpecies = value;
                OnPropertyChanged();
            }
        }

        public bool LevelofTreeRegeneration
        {
            get { return _levelofTreeRegeneration; }

            set
            {
                _levelofTreeRegeneration = value;
                OnPropertyChanged();
            }
        }

        public bool LevelofShrubRegeneration
        {
            get { return _levelofShrubRegeneration; }

            set
            {
                _levelofShrubRegeneration = value;
                OnPropertyChanged();
            }
        }

        public bool RegenerationTreeSpecies
        {
            get { return _regenerationTreeSpecies; }

            set
            {
                _regenerationTreeSpecies = value;
                OnPropertyChanged();
            }
        }

        public bool RegenerationShrubSpecies
        {
            get { return _regenerationShrubSpecies; }

            set
            {
                _regenerationShrubSpecies = value;
                OnPropertyChanged();
            }
        }

        public bool Flora
        {
            get { return _flora; }

            set
            {
                _flora = value;
                OnPropertyChanged();
            }
        }

        public bool Deadwood
        {
            get { return _deadwood; }

            set
            {
                _deadwood = value;
                OnPropertyChanged();
            }
        }

        public bool AnimalDamage
        {
            get { return _animalDamage; }

            set
            {
                _animalDamage = value;
                OnPropertyChanged();
            }
        }

        public bool Invasives
        {
            get { return _invasives; }

            set
            {
                _invasives = value;
                OnPropertyChanged();
            }
        }

        public bool TreeHealth
        {
            get { return _treeHealth; }

            set
            {
                _treeHealth = value;
                OnPropertyChanged();
            }
        }

        public bool HumanImpacts
        {
            get { return _humanImpacts; }

            set
            {
                _humanImpacts = value;
                OnPropertyChanged();
            }
        }






        public ICommand ShowOverallStructure { get; protected set; }

        public ICommand ShowTreeAgees { get; protected set; }

        public ICommand ShowTreeSpecies { get; protected set; }

        public ICommand ShowShrubSpecies { get; protected set; }

        public ICommand ShowLevelOfTreeRegeneration { get; protected set; }

        public ICommand ShowLevelOfShrubRegeneration { get; protected set; }

        public ICommand ShowRegenerationTreeSpecies { get; protected set; }

        public ICommand ShowRegenerationShrubSpecies { get; protected set; }

        public ICommand ShowFlora { get; protected set; }

        public ICommand ShowDeadwood { get; protected set; }

        public ICommand ShowAnimalDamage { get; protected set; }

        public ICommand ShowInvasives { get; protected set; }

        public ICommand ShowTreeHealth { get; protected set; }

        public ICommand ShowHumanImpacts { get; protected set; }

 
        #endregion

        public ObservableRangeCollection<ComboBoxValue> KeyFeatures { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public ObservableRangeCollection<ComboBoxValue> Stratum { get; set; } = new ObservableRangeCollection<ComboBoxValue>();
    }
}