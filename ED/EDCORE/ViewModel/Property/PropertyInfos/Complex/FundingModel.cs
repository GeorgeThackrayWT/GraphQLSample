using System;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class FundingModel : PropertyBase, IFundingModel
    {
        private readonly ILookupStore _iLookupStore;

        public ExtRangeCollection<FundingEditList> Records { get; set; }

        private FundingEditList _editRecord;

        public FundingEditList EditRecord
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

        public ObservableRangeCollection<ComboBoxValue> FundingTypes { get; set; } =
                                                        new ObservableRangeCollection<ComboBoxValue>();

        public FundingModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IWTTimer iWTimer, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            FundingTypes.AddRange(iLookupStore.GetFundingTypes());

            _iLookupStore = iLookupStore;

            Records = new ExtRangeCollection<FundingEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(FundingEditList.MakeCollection(iPropertyStore.GetFundingDtos(State.RecordId)));

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

            ProcessMessage(message);
        }

        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdateFundings(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {
            var fundingTypes = _iLookupStore.GetFundingTypes().Where(w => w.ID != 0);
        
            var newRec = new FundingDto()
            {
                Amount = 0.0,
                NameOfDonor = "new rec",
                GiftAidOfferAmount = 0.0,
                FundingTypeId = fundingTypes.First()
            };

            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            Records.ReplaceRange(FundingEditList.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();
        }
    }
}
