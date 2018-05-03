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
    public class PartDisposalsModel : PropertyBase, IPartDisposalsModel
    {
        private ILookupStore _iLookupStore;

        public ExtRangeCollection<PartDisposalEdit> Records { get; set; }

        private PartDisposalEdit _editRecord;

        public PartDisposalEdit EditRecord
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



        public PartDisposalsModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iLookupStore = iLookupStore;
            _iPropertyStore = iPropertyStore;

            Records = new ExtRangeCollection<PartDisposalEdit>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(PartDisposalEdit.MakeCollection(_iPropertyStore.GetPartDisposal(State.RecordId)));

                        if (Records.Count > 0)
                            EditRecord = Records.First();

                        break;
                }
            };
            
        }

        public override void HandleMessage(EdMessage message)
        {
            // we only want messages that have been sent to us.
            if (IsDisposed) return;


            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;
            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;

            //var t = this.GetType().Name + Guid.NewGuid();

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

            //ProcessMessage(message);
        }

        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdatePartDisposal(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {
            var interestDisposal = _iLookupStore.GetInterestDisposed().Where(w => w.ID != 0);
            
            var newRec = new PartDisposalDto()
            {
                Description = "new rec desc",
                Address =  "new rec address",
                County = "new rec county",
                DateOfDisposal = DateTime.Today,
                Name = "new rec name",
                Organisation = "new rec orgs",
                Postcode = "new rec postcode",
                Email = "new rec email",
                Telephone = "new rec telephone",
                TotalConsiderationReceivable = 0.0,
                InterestDisposalId = interestDisposal.First().ID
            };

            var reclist = Records.Select(s => s.ConvertToDto()).ToList();


            reclist.Add(newRec);

            Records.ReplaceRange(PartDisposalEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();

            //reclist.Add(newRec);

            //_iPropertyStore.UpdatePartDisposal(State.RecordId, reclist);

            //Records.ReplaceRange(PartDisposalEdit.MakeCollection(_iPropertyStore.GetPartDisposal(State.RecordId)));

        }
    }
}
