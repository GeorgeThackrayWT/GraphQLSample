using System;
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

namespace EDCORE.ViewModel.ManagementPlans
{
    public class ConditionAssessmentEditorModel : GeneralModelBase, IConditionAssessmentEditorModel
    {

        protected bool _isAssessmentCondition;
        protected bool _isHistoricCondition;

        protected ConditionAssessmentEditorEntryDtoEditList _editRecord;
        private IConditionalAssessmentsStore _iConditionalAssessmentsStore;
        private ConditionAssessmentEditorEntryDtoEdit _conditionAssessmentEditorEntryDtoEdit = new ConditionAssessmentEditorEntryDtoEdit(){IsDirty = false};
      

        public ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList> Records { get; set; } = new ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList>();
     



        public ConditionAssessmentEditorEntryDtoEditList EditRecord
        {
            get
            {
                if (Records.Count == 0) return null;

                return _editRecord ?? Records[0];
                
            }

            set
            {
                if (_editRecord == value) return;

                if (value == null) return;

                //get the old values and save them into 
                //var old = _conditionAssessmentEditorEntryDtoEdit.ConvertToDto();

                if (value != null && _editRecord != null)
                {
                    if (_editRecord.Id == value.Id) return;
                }


                if (_editRecord == null) _editRecord = value;


                UpdateEditRecord();


                _editRecord = value;




                if (_editRecord != null)
                {
                    _conditionAssessmentEditorEntryDtoEdit.Make(_editRecord.ConvertToDto());


                    if (_editRecord.Description == "Condition Assessment")
                    {
                        IsHistoricCondition = false;
                        IsCondition = true;
                    }
                    else
                    {
                        IsHistoricCondition = true;
                        IsCondition = false;
                    }

                }
                OnPropertyChanged();
                OnPropertyChanged("EditPropertyRecord");
            }
        }

        private void UpdateEditRecord()
        {
            if (_conditionAssessmentEditorEntryDtoEdit.IsDirty)
            {               
                _editRecord.AreaHa = _conditionAssessmentEditorEntryDtoEdit.AreaHa.Value;
                _editRecord.AreaAWHa = _conditionAssessmentEditorEntryDtoEdit.AreaAWHa.Value;
                _editRecord.ChangeInAreaSinceLastSurveyHa =
                    _conditionAssessmentEditorEntryDtoEdit.ChangeInAreaSinceLastSurveyHa.Value;
                _editRecord.ChangeInAreaAWSinceLastSurveyHa =
                    _conditionAssessmentEditorEntryDtoEdit.ChangeInAreaAWSinceLastSurveyHa.Value;
                _editRecord.OverallDesirable = _conditionAssessmentEditorEntryDtoEdit.OverallDesirable.Value;
                _editRecord.OverallAchievable = _conditionAssessmentEditorEntryDtoEdit.OverallAchievable.Value;
                _editRecord.ConclusionsAndRecommendations =
                    _conditionAssessmentEditorEntryDtoEdit.ConclusionsAndRecommendations.Value;
                _editRecord.PredictionShortTermObjective =
                    _conditionAssessmentEditorEntryDtoEdit.PredictionShortTermObjective.Value;
                _editRecord.Surveyor = _conditionAssessmentEditorEntryDtoEdit.Surveyor.Value;
                _editRecord.PlannedObservation = _conditionAssessmentEditorEntryDtoEdit.PlannedObservation.Value;
                _editRecord.ActualObservation = _conditionAssessmentEditorEntryDtoEdit.ActualObservation.Value;
                _editRecord.SuggestionsAndActions = _conditionAssessmentEditorEntryDtoEdit.SuggestionsAndActions.Value;

                //    OnPropertyChanged();
            }
        }


        public ConditionAssessmentEditorModel(IWTTimer iWTimer, IConditionalAssessmentsStore iConditionalAssessmentsStore, 
            ILinkContainer iManagementPlanLinkContainer, object iDialogService,
            IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iConditionalAssessmentsStore = iConditionalAssessmentsStore;

            ManagementPlanLinkContainer = iManagementPlanLinkContainer;

            Records = new ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    Records.ReplaceRange(
                        ConditionAssessmentEditorEntryDtoEditList.MakeCollection(
                            _iConditionalAssessmentsStore.GetConditionAssessmentEditorDto(ParentID)));

                    if (Records != null && Records.Count > 0)
                    {
                        EditRecord = Records.First();
                    }
                    else
                    {
                        AddNew();
                    }
                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("cond ass SaveCommand: "+ _conditionAssessmentEditorEntryDtoEdit.Surveyor);
            });

            LoadConditionAssessmentForm = new RelayCommand((x) =>
            {

                if (EditRecord.Id > 0)
                {
                    _iNavigation.Navigate(iManagementPlanLinkContainer.ConditionAssessmentForm.Editor(),
                        StateContainer.Create(EditRecord.FeatureMonitoringID, false));
                }

            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.Id == EditRecord.Id).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
            });

            SaveCommand = new RelayCommand((x) =>
            {
                //if (!_iUserStore.Check(UserActions.GroupB)) return;

                UpdateEditRecord();

                //if (Records.Count == 0)
                //{
                //    Records.AddItem(EditRecord);

                //    var t = Records.Select(s => s.ConvertToDto()).ToList();

                //    _iConditionalAssessmentsStore.UpdateConditionAssessmentEditorEntryDtos(ParentID, t);
                //}
                //else
                //{
                    var t = Records.Select(s => s.ConvertToDto()).ToList();

                    _iConditionalAssessmentsStore.UpdateConditionAssessmentEditorEntryDtos(ParentID, t);
               // }
              

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
        }

        private void AddNew()
        {
            var newRecord = new ConditionAssessmentEditorEntryDtoEditList();
            newRecord.Make(new ConditionAssessmentEditorEntryDto()
            {
                ActualActionDate = DateTime.Today,
                ActualObservationDate = DateTime.Today,
                FeatureMonitoringID = EditRecord?.FeatureMonitoringID??0,
                IsHistorical = false,
                AreaAWHa = 0.0,
                AreaHa = 0.0,
                ChangeInAreaAWSinceLastSurveyHa = 0.0,
                ChangeInAreaSinceLastSurveyHa = 0.0,
                Description = "Condition Assessment",
                PlannedObservationDate = DateTime.Today,
                ConclusionsAndRecommendations = "new record"

            });


            Records.AddItem(newRecord, true);

            EditRecord = newRecord;
        }

        public bool IsCondition
        {
            get { return _isAssessmentCondition; }
            set
            {
                if (_isAssessmentCondition == value) return;
                _isAssessmentCondition = value;


                OnPropertyChanged();
            }
        }

        public bool IsHistoricCondition
        {
            get { return _isHistoricCondition; }
            set
            {
                if (_isHistoricCondition == value) return;
                _isHistoricCondition = value;


                OnPropertyChanged();
            }
        }

        public ICommand LoadConditionAssessmentForm { get; protected set; }

        public ICommand LoadData { get; protected set; }
         

        public ILinkContainer ManagementPlanLinkContainer { get; set; }


        public int ManagementUnitID { get; set; }
     
        public ConditionAssessmentEditorEntryDtoEdit EditPropertyRecord => _conditionAssessmentEditorEntryDtoEdit;
        
    }
}