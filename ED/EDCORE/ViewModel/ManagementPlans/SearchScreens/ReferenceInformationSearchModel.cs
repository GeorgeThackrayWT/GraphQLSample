using System;
using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class ReferenceInformationSearchModel : SearchModelBase<ReferenceInfoListDTO>, IGeneralManagementPlanSearchModel<ReferenceInfoListDTO>
    {
        private IReferenceInfoStore _referenceInfoStore;

        public ReferenceInformationSearchModel(IReferenceInfoStore referenceInfoStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
          
            InstanceID = GetType().Name + Guid.NewGuid();
            _referenceInfoStore = referenceInfoStore;


            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.ReferenceInformation.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(referenceInfoStore, iCache);
        }

        private void GetData(IReferenceInfoStore referenceInfoStore, ICache iCache)
        {
            var items = referenceInfoStore.GetReferenceInfoListDtos(iCache.CurrentUserRole(), iCache.GetApplication(), iCache.CurrentUser(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<ReferenceInfoListDTO>();
            SearchData.ReplaceRange(items);

            if (SearchData.Count > 0)
                this.SelectedRecord = SearchData.First();

            OnPropertyChanged("SearchData");
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_referenceInfoStore,_iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}