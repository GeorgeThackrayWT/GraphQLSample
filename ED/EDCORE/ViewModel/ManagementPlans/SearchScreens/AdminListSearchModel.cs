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
    public class AdminListSearchModel: SearchModelBase<AdminListDTO>, IGeneralManagementPlanSearchModel<AdminListDTO>
    {
        // we need some means of turning on and off certain columns
        private IManagementPlanAdminEFStore _adminStore;
        
        public AdminListSearchModel(IManagementPlanAdminEFStore adminStore, IPlatformEventHandling iPlatformEventHandling, IUserStore iUserStore, IWTTimer iWTimer,
           INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
           ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
                  
            InstanceID = GetType().Name + Guid.NewGuid();
          
            _adminStore = adminStore;

            PropertyChanged += (sender, e) =>
            {
               
            };

            LoadData = new RelayCommand((x) =>
            {
               
                _iNavigation.Navigate(iManagementPlanLinkContainer.Adminstration.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(iCache);
        }

        private void GetData(ICache iCache)
        {
            var items = _adminStore.GetAdminListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<AdminListDTO>();

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

                GetData( _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}
