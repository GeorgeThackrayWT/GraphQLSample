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
    public class HarvestingSearchModel : SearchModelBase<HarvestingListDTO>, IGeneralManagementPlanSearchModel<HarvestingListDTO>
    {
        private readonly IHarvestingStore _iharvestingStore;

        public HarvestingSearchModel(IHarvestingStore iharvestingStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {                       
            InstanceID = GetType().Name + Guid.NewGuid();

            _iharvestingStore = iharvestingStore;

            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.Harvesting.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(iharvestingStore, iCache);
        }

        private void GetData(IHarvestingStore iharvestingStore, ICache iCache)
        {
            var items = iharvestingStore.GetHarvestingListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<HarvestingListDTO>();

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

                GetData(_iharvestingStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }

    }
}