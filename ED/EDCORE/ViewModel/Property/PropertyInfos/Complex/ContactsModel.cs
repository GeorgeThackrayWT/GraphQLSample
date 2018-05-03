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
    public class ContactsModel : PropertyBase, IContactsModel
    {
        private ILookupStore _iLookupStore;

        public ExtRangeCollection<ContactEdit> Records { get; set; } = new ExtRangeCollection<ContactEdit>();

        private ContactEdit _editRecord;

        public ContactEdit EditRecord
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


        public ContactsModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<ContactEdit>(iDialogService);

            _iPropertyStore = iPropertyStore;
            _iLookupStore = iLookupStore;

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(ContactEdit.MakeCollection(_iPropertyStore.GetContactsDto(State.RecordId)));

                        if (Records.Count > 0)
                            EditRecord = Records.First();
                        break;
                }
            };
            
        }
        
        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;



            var t = this.GetType().Name + Guid.NewGuid();

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

         //   ProcessMessage(message);
        }

        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdateContacts(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {
            var contactStatuses = _iLookupStore.GetContactStatuses().Where(i=>i.ID !=0);

           
            var newRec = new ContactDto()
            {
                Email = "new email",
                Name = "new name",
                Telephone = "new telephone",
                County = "new county",
                Organisation = "new org",
                Other = "new other",
                Postcode = "new postcode",
                Address = "new address",
                Notes = "new notes",
                Town = "new town",
                StatusId = contactStatuses.First().ID
            };


            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);


            Records.ReplaceRange(ContactEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();

        }
    }
}
