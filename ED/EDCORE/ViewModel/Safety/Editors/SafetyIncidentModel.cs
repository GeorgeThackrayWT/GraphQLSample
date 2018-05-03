using System;
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
    public class SafetyIncidentModel : GeneralModelBase, ISafetyIncidentModel
    {
        private int _hazardId;

   
        private HazardIncidentEditList _editRecord;

        

        public ExtRangeCollection<HazardIncidentEditList> Records { get; set; }
       


        public SafetyIncidentModel(ISafetyStore safetyStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<HazardIncidentEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {                
                if (e.PropertyName == "HazardId")
                {
                    if (HazardId == 0) return;

                    var result = safetyStore.GetHazardIncidentDtos(HazardId);

                    Records.ReplaceRange(HazardIncidentEditList.MakeCollection(result));
                }
                
            };

            SaveCommand = new RelayCommand((x) =>
            {
                safetyStore.UpdateHazardIncidents(HazardId, Records.Select(s => s.ConvertToDto()).ToList());
            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();

                if (!Records.Errors())
                    safetyStore.UpdateHazardIncidents(HazardId, Records.Select(s => s.ConvertToDto()).ToList());
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

            });
        }

        protected void AddNew()
        {

            var _tpRecs = Records.Select(s => s.ConvertToDto()).ToList();

            _tpRecs.Add(new HazardIncidentDto()
            {
                Description = "new rec",
                DateRecorded = DateTime.Today,
                HazardId = ParentID
            });

            Records.ReplaceRange(HazardIncidentEditList.MakeCollection(_tpRecs));

            EditRecord = Records.Last();




        }



        public int HazardId
        {
            get => _hazardId;

            set
            {
                if (_hazardId == value) return;

                _hazardId = value;
                
                OnPropertyChanged();
            }
        }
 
        public HazardIncidentEditList EditRecord
        {
            get => _editRecord;

            set
            {
                if (_editRecord == value) return;

                _editRecord = value;

                OnPropertyChanged();
            }
        }

        
    }
}