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
    public class PublicRightsOfWayModel : PropertyBase, IPublicRightsOfWayModel
    {
        private ILookupStore _iLookupStore;

        public ExtRangeCollection<PublicRightOfWayEdit> Records { get; set; }

        private PublicRightOfWayEdit _editRecord;

        public PublicRightOfWayEdit EditRecord
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


        public PublicRightsOfWayModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iLookupStore = iLookupStore;

            Records = new ExtRangeCollection<PublicRightOfWayEdit>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(PublicRightOfWayEdit.MakeCollection(iPropertyStore.GetPublicRightsOfWayDto(State.RecordId)));

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
            //ProcessMessage(message);
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

       //     ProcessMessage(message);
        }

        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdatePublicRightsOfWay(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
       //     OnPropertyChanged("State");
        }

        protected void AddNew()
        {                       
            var newRec = new PublicRightOfWayDto()
            {
                Comments = "new rec comments",
                Bridleway = false,
                BridlewayDescription = "new rec brid desc",
                Footpath = false,
                FootpathDescription = "footpath desc new crec",
                Other = false,
                OtherDescription = "other desc",               
            };

            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            //reclist.Add(newRec);

            //_iPropertyStore.UpdatePublicRightsOfWay(State.RecordId, reclist);

            //Records.ReplaceRange(PublicRightOfWayEdit.MakeCollection(_iPropertyStore.GetPublicRightsOfWayDto(State.RecordId)));


            reclist.Add(newRec);

            Records.ReplaceRange(PublicRightOfWayEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();

        }
    }
}
