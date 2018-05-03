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
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{


    public class MonitoringEditorModel : GeneralModelBase, IMonitoringEditorModel
    {
        private int _yearFilter;

        protected MonitoringEditEditList _editRecord;
        protected MonitoringEditEdit _editRecordEdit = new MonitoringEditEdit() {IsDirty = false};


        protected IMonitoringStore _monitoringStore;

        public ObservableRangeCollection<ComboBoxValue> ObservationTypeLookup { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public ExtRangeCollection<MonitoringEditEditList> Records { get; set; }

        private ExtRangeCollection<MonitoringEditEditList> _cache = new ExtRangeCollection<MonitoringEditEditList>();

        public MonitoringEditorModel(IWTTimer iWTimer, IMonitoringStore iMonitoringStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  IWTTimer timer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer,  iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _monitoringStore = iMonitoringStore;

            Records = new ExtRangeCollection<MonitoringEditEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                //load data here
          
                if (e.PropertyName == "State")
                {
                    ObservationTypeLookup.ReplaceRange(_monitoringStore.GetObservationTypeDtos(ParentID));

               
                    Records.ReplaceRange(MonitoringEditEditList.MakeCollection(_monitoringStore.GetMonitoringEditContainerDto(ParentID)));

                    if (Records.Count > 0)
                        EditRecord = Records[0];                    
                }

                if (e.PropertyName == "YearFilter")
                {                    
                    filterDataByYear(_yearFilter);
                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                updateEditRecord();


                _monitoringStore.UpdateMonitoring(ParentID, Records.Select(s=>s.ConvertToDto()).ToList());

            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();                
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

              //  _monitoringStore.UpdateMonitoring(ParentID, Records.Select(s => s.ConvertToDto()).ToList());

            });

            LoadData = new RelayCommand((x) =>
            {

            });     
            


        }
        
        
        public ICommand LoadData { get; protected set; }

        public int YearFilter
        {
            get => _yearFilter;

            set
            {
                _yearFilter = value;
                OnPropertyChanged();
            }
        }

        public MonitoringEditEditList EditRecord
        {
            get
            {
                if (Records.Count == 0) return null;

                return _editRecord ?? Records[0];
            }

            set
            {
                if (_editRecord == value) return;

                if (_editRecord == null) _editRecord = value;
                
                //update the contents of editrecordedit with the previously editted values.
                updateEditRecord();

                _editRecord = value;

                if (_editRecord != null)
                {
                    _editRecordEdit.Make(_editRecord.ConvertToDto());
                }

                OnPropertyChanged("EditRecordEdit");

                OnPropertyChanged();
            }
        }

        private void updateEditRecord()
        {
            if (_editRecordEdit.IsDirty)
            {
                _editRecord.ActualActionDate = _editRecordEdit.ActualActionDate.Value;
                _editRecord.ActualObservation = _editRecordEdit.ActualObservation.Value;
                _editRecord.ActualObservationDate = _editRecordEdit.ActualObservationDate.Value;
                _editRecord.DeadlineActionDate = _editRecordEdit.DeadlineActionDate.Value;
                _editRecord.FeatureID = _editRecordEdit.FeatureID.Value;
                _editRecord.FeatureType = _editRecordEdit.FeatureType.Value;
                _editRecord.ManagementUnitId = _editRecordEdit.ManagementUnitId.Value;
                _editRecord.PlannedObservation = _editRecordEdit.PlannedObservation.Value;
                _editRecord.PlannedObservationDate = _editRecordEdit.PlannedObservationDate.Value;
                _editRecord.PredictionShortTermObjective = _editRecordEdit.PredictionShortTermObjective.Value;
                _editRecord.SuggestionsAndActions = _editRecordEdit.SuggestionsAndActions.Value;
            }
        }

        protected void AddNew()
        {          
            var tp = ObservationTypeLookup.FirstOrDefault(f => f.ID != 0);

            if (tp != null)
            {           
                var newRecord = new MonitoringEditEditList();
                newRecord.Make(new MonitoringEditDto()
                {
                   FeatureType = tp,
                   FeatureID = tp.ID,
                   ActualObservation = "new record...",
                   PlannedObservation = "new record..",
                   PlannedObservationDate = DateTime.Today

                });

                Records.AddItem(newRecord, true);

                EditRecord = newRecord;
            }
        }


        public MonitoringEditEdit EditRecordEdit
        {
            get
            {
                return _editRecordEdit;
            }

            set { _editRecordEdit = value; }
        }


        private void filterDataByYear(int year)
        {
            if (year != 1 && year != 2)
            {
                year = 3;
            }

            if (year == 3)
            {
                if (_cache.Count > 0)
                    Records.ReplaceRange(_cache); 
            }
            else
            {
                if (year == 1) year = 2017;
                if (year == 2) year = 2018;

                var cachedmonitorstoremove = Records.Where(w => w.PlannedObservationDate.Year != year).ToList();
                var cachedmonitorstokeep = Records.Where(w => w.PlannedObservationDate.Year == year).ToList();
                

                foreach (var v in cachedmonitorstoremove)
                {
                    if (_cache.All(a => a.Id != v.Id))
                    {
                        _cache.AddItem(v);
                    }
                }
                Records.ReplaceRange(cachedmonitorstokeep);                 
            }
        }
        
        }
}