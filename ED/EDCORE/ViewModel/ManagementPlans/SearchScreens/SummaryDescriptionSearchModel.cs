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
    public class SummaryDescriptionSearchModel : SearchModelBase<SummaryDescriptiontListDTO>, IGeneralManagementPlanSearchModel<SummaryDescriptiontListDTO>
    {
        private ISummaryStore _iSummaryStore;

        public SummaryDescriptionSearchModel(ISummaryStore iSummaryStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {                    
            InstanceID = GetType().Name + Guid.NewGuid();

            _iSummaryStore = iSummaryStore;


            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.SummaryDescription.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(iSummaryStore, iCache);
        }

        private void GetData(ISummaryStore iSummaryStore, ICache iCache)
        {
            var items = iSummaryStore.GetSummaryDescriptiontListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<SummaryDescriptiontListDTO>();
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

                GetData(_iSummaryStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}