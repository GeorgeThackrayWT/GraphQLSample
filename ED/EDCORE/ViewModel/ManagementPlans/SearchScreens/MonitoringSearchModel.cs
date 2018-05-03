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
    public class MonitoringSearchModel : SearchModelBase<MonitoringListDTO>, IGeneralManagementPlanSearchModel<MonitoringListDTO>
    {
        private IMonitoringStore _iMonitoringStore;

        public MonitoringSearchModel(IMonitoringStore iMonitoringStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            
            InstanceID = GetType().Name + Guid.NewGuid();

            _iMonitoringStore = iMonitoringStore;

            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.Monitoring.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(iMonitoringStore, iCache);
        }

        private void GetData(IMonitoringStore iMonitoringStore, ICache iCache)
        {
            var items = iMonitoringStore.GetMonitoringListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<MonitoringListDTO>();

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

                GetData(_iMonitoringStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }

    }
}