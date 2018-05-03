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
    public class DrainageRatesModel : PropertyBase, IDrainageRatesModel
    {
//        private IPropertyStore _iPropertyStore;
        public ExtRangeCollection<DrainageRateEdit> Records { get; set; }

        private DrainageRateEdit _editRecord;

        public DrainageRateEdit EditRecord
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

        public DrainageRatesModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
            _iPropertyStore = iPropertyStore;

            Records = new ExtRangeCollection<DrainageRateEdit>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(DrainageRateEdit.MakeCollection(iPropertyStore.GetDrainageRatesDto(State.RecordId)));

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
            _iPropertyStore.UpdateDrainages(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {                 
            var newRec =new DrainageRateDto()
            {
                Body = "new rec",
                ReferenceNumber = "new ref",
                DateDue = DateTime.Today,                
            };
             
            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            Records.ReplaceRange(DrainageRateEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();
             
        }
    }


}
