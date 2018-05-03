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
    public class GrantContractsSearchModel : SearchModelBase<GrantContractsListDTO>, IGeneralManagementPlanSearchModel<GrantContractsListDTO>
    {
        private IGrantStore _iGrantStore;

        public GrantContractsSearchModel(IGrantStore iGrantStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, 
            ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

            SearchData.Add(new GrantContractsListDTO());

            InstanceID = GetType().Name + Guid.NewGuid();

            _iGrantStore = iGrantStore;

            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.GrantContracts.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });


            GetData(iGrantStore, iCache);
        }

        private void GetData(IGrantStore iGrantStore, ICache iCache)
        {
            var items = iGrantStore.GetGrantContractsListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<GrantContractsListDTO>();

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

                GetData(_iGrantStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}