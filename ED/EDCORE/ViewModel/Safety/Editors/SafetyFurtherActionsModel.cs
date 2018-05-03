using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class SafetyFurtherActionsModel : GeneralModelBase, ISafetyFurtherActionsModel
    {
        private int _hazardID;

        private ISafetyStore _safetyStore;
        private ILookupStore _iLookupStore;


        private HazardActionEdit _editRecord;
  
        public ExtRangeCollection<HazardActionEdit> Records { get; set; } 

        private List<ComboBoxValue> _followOnActionTypes;

        private List<ComboBoxValue> _probabilitysOfHarm;

        public SafetyFurtherActionsModel(IWTTimer iWTimer, ISafetyStore safetyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService,
                                    INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
                                    ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _safetyStore = safetyStore;
            _iLookupStore = iLookupStore;

            _followOnActionTypes = iLookupStore.GetFollowOnActionTypeDtos();

            _probabilitysOfHarm = iLookupStore.GetSeverityProbabilityOfHarmDtos();


            Records = new ExtRangeCollection<HazardActionEdit>(iDialogService);

            // load data when acquisition id property is set
            PropertyChanged += (sender, e) =>
            {                
                if (e.PropertyName == "HazardId" )
                {                     
                    if (HazardId != 0)
                    {
                        var result = _safetyStore.GetHazardActionDtos(HazardId);
                        
                        Records.ReplaceRange(HazardActionEdit.MakeCollection(result));
                    }
                }
                
            };

            SaveCommand = new RelayCommand((x) =>
            {
                _safetyStore.UpdateHazardActions(HazardId,Records.Select(s=>s.ConvertToDto()).ToList());      
            });

            AddCommand = new RelayCommand((x) =>
            {          
                AddNew();

                if (!Records.Errors())
                    _safetyStore.UpdateHazardActions(HazardId, Records.Select(s => s.ConvertToDto()).ToList());
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

            });
        }

        protected void AddNew()
        {
         
            var _tpRecs = Records.Select(s => s.ConvertToDto()).ToList();

            _tpRecs.Add(new HazardActionDto()
            {
                FollowOnActionId = _followOnActionTypes.First(f => f.ID != 0).ID,
                Description = "new rec",
                FollowOnCompleteDate = DateTime.Today,
                FollowOnDeadlineDate = DateTime.Today,
                InspectionActualDate = DateTime.Today,
                InspectionDeadlineDate = DateTime.Today,
                FurtherAction = "new further",
                SeverityProbabilityOfHarmId = _probabilitysOfHarm.FirstOrDefault(a => a.ID != 0).ID
            });

            Records.ReplaceRange(HazardActionEdit.MakeCollection(_tpRecs));

            EditRecord = Records.Last();


            

        }



        public int HazardId
        {
            get => _hazardID;

            set
            {
                if (_hazardID == value) return;
                _hazardID = value;
                
                OnPropertyChanged();
            }
        }


        public HazardActionEdit EditRecord {

            get { return _editRecord; }

            set
            {
                if (_editRecord == value) return;

                _editRecord = value;

                OnPropertyChanged();
            }
        }   
        
        
         
    }
}

