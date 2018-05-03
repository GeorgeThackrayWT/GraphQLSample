using System;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class ThirdPartyRightsModel : PropertyBase, IThirdPartyRightsModel
    {
        public ILookupStore _iLookupStore;
        public ExtRangeCollection<ThirdPartyRightEdit> Records { get; set; }

        private ThirdPartyRightEdit _editRecord;

        public ThirdPartyRightEdit EditRecord
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

        public ThirdPartyRightsModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<ThirdPartyRightEdit>(iDialogService);

            _iLookupStore = iLookupStore;
            _iPropertyStore = iPropertyStore;

            PropertyChanged += (sender, e) =>
            {
                //load data here
                switch (e.PropertyName)
                {
                    case "State":
                        Records.ReplaceRange(ThirdPartyRightEdit.MakeCollection(iPropertyStore.GetThirdPartyRightDtos(State.RecordId)));

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
            _iPropertyStore.UpdateThirdPartyRights(ParentID, Records.Select(c => c.ConvertToDto()).ToList());                            
        }

        protected void AddNew()
        {
            var thirdPartyAgreementTypeDto = _iLookupStore.GetAgreementTypes().Where(w=>w.ID !=0);

            var thirdPartyServiceTypeDto = _iLookupStore.GetThirdPartyServiceTypes().Where(w => w.ID != 0);

            var thirdPartyTypeDtos = _iLookupStore.GetThirdPartyTypeDtos().Where(w => w.ID != 0);
            
            var newRec = new ThirdPartyRightDto()
            {
                SouthernElectricTarget = DateTime.Today,
                WT = DateTime.Today,
                CurrentReceivementDate = DateTime.Today,
                ResponseResult = false,
                Comments = "new record",
                ForecastPaymentDate = DateTime.Today,
                InitialEnquiry = DateTime.Today,
                MTMApprovalTarget = DateTime.Today,
                ForecastPaymentAmount = 0.0,
                WTTarget                = DateTime.Today,
                AgreementWith = "new record",
                AgreementFrom = DateTime.Today,
                SouthernElectric = DateTime.Today,
                ResponsiveReceived = DateTime.Today,
                CurrentPaymentDate = DateTime.Today,
                ResponsiveReceivedTarget = DateTime.Today,
                RightsTypeId = thirdPartyTypeDtos.First().ID,
                ForecastReceivementDate = DateTime.Today,
                ServiceId = thirdPartyServiceTypeDto.First().ID,
                AgreementTypeId = thirdPartyAgreementTypeDto.First().ID,
                MTMApproval = DateTime.Today,
                CurrentPaymentAmount = 0.0
            };

            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            Records.ReplaceRange(ThirdPartyRightEdit.MakeCollection(reclist));
            
            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();
        }
    }
}
