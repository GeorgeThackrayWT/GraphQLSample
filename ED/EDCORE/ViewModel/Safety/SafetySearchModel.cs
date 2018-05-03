using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.SafetyObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{

    public class SafetySearchModel : SearchModelBase<SafetyDto>, IGeneralManagementPlanSearchModel<SafetyDto>
    {
        private ISafetyStore _iSafetyStore;

        public SafetySearchModel(IWTTimer iWTimer, ISafetyStore iSafetyStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _iSafetyStore = iSafetyStore;

            GetData(iSafetyStore, iCache);


            LoadData = new RelayCommand((x) =>
            {
                
                _iNavigation.Navigate(iLinkContainer.SafetyEditor.Editor(), StateContainer.Create(SelectedRecord.ID, false));
            });
        }

        private void GetData(ISafetyStore iSafetyStore, ICache iCache)
        {
            SearchData = new ObservableRangeCollection<SafetyDto>();
            SearchData.AddRange(iSafetyStore.GetSafetyDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion()));


            if (SearchData.Count > 0)
                SelectedRecord = SearchData.First();

            OnPropertyChanged("SearchData");
        }


        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iSafetyStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}