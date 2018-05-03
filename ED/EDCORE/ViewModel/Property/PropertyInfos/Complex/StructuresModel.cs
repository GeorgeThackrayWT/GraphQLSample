using System;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class StructuresModel : PropertyBase, IStructuresModel
    {
       
        public ILookupStore _iLookupStore;
        public ExtRangeCollection<StructureEdit> Records { get; set; }

        private StructureEdit _editRecord;

        public StructureEdit EditRecord
        {
            get => _editRecord;

            set
            {
                if (_editRecord?.Id != value?.Id)
                {
                    _editRecord = value;
                    OnPropertyChanged();
                }
            }
        }

        public StructuresModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService,IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iLookupStore,iTelerikConvertors, iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iLookupStore = iLookupStore;

            Records = new ExtRangeCollection<StructureEdit>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                //load data here
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(StructureEdit.MakeCollection(iPropertyStore.GetStructuresDto(State.RecordId)));

                        if (Records.Count > 0)
                            EditRecord = Records.First();
                        break;
                }
            };
            
        }

        public override void HandleMessage(EdMessage message)
        {

            if (IsDisposed) return;
            // we only want messages that have been sent to us.

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;



        //    var t = this.GetType().Name + Guid.NewGuid();

            switch (message.EdEvent)
            {
                case EdEvent.BackButtonClicked:
                    //Debug.WriteLine("go back to :" + message.Data);
                    _iNavigation.GoBack();


                    break;
                case EdEvent.SaveButtonClicked:
                    SaveData();

                    break;

                case EdEvent.DeleteButtonClicked:
                    Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) =>
                    {
                        SaveData();

                        if (Records.Count > 0)
                            EditRecord = Records.Last();
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                    break;
                case EdEvent.AddButtonClicked:
                    AddNew();
                    break;
            }

        //    ProcessMessage(message);
        }

        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdateStructures(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {
            var structureConditions = _iLookupStore.GetStructureConditionDtos().Where(w => w.ID != 0);

            var structureTypes = _iLookupStore.GetStructureTypeDtos().Where(w => w.ID != 0);
            
            var newRec =new StructureDto()
            {
                AnnualMaintenanceCosts             = 0.0,
                BriefReportSummary = "new record",
                Description = "new rec description",
                ExternalSurveyorRequired = false,
                LastInspectionDate = DateTime.Today,
                NextInspectionDate = DateTime.Today,
                RebuildCost = 0.0,
                ReportAuthor = "new rec rep author",
                Responsibility = false,
                ResponsibilityDescription = "new rec res desc",
                StructureConditionId = structureConditions.First().ID,
                StructureTypeId = structureTypes.First().ID
                
            };
    
            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            Records.ReplaceRange(StructureEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();
        }
    }
}
