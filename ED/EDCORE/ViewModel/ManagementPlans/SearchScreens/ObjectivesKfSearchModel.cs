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
    public class ObjectivesKfSearchModel : SearchModelBase<ObjectiveKFListDTO>, IGeneralManagementPlanSearchModel<ObjectiveKFListDTO>
    {
        private IObjectiveStore _iObjectiveStore;

        public ObjectivesKfSearchModel(IObjectiveStore iObjectiveStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, 
            ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {                       
            InstanceID = GetType().Name + Guid.NewGuid();

            _iObjectiveStore = iObjectiveStore;

            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.ObjectivesKF.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });

            GetData(iObjectiveStore, iCache);
        }

        private void GetData(IObjectiveStore iObjectiveStore, ICache iCache)
        {
            var items = iObjectiveStore.GetObjectiveKfListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<ObjectiveKFListDTO>();


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

                GetData(_iObjectiveStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}