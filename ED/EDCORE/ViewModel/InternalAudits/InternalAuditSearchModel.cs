using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores.Content.InternalAudits;
using DataObjects;
using DataObjects.DTOS.InternalAudits;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class InternalAuditSearchModel : SearchModelBase<InternalAuditsSearchDto>, IGeneralManagementPlanSearchModel<InternalAuditsSearchDto>
    {
        private readonly IInternalAuditStore _internalAuditStoreStore;


        public InternalAuditSearchModel(IInternalAuditStore internalAuditStoreStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _internalAuditStoreStore = internalAuditStoreStore;


            GetData(internalAuditStoreStore, iCache);


            LoadData = new RelayCommand((x) =>
            {                
                _iNavigation.Navigate(iLinkContainer.InternalAuditsEditor.Editor(), StateContainer.Create(SelectedRecord.ID, false));
            });
        }

        private void GetData(IInternalAuditStore internalAuditStoreStore, ICache iCache)
        {
            SearchData = new ObservableRangeCollection<InternalAuditsSearchDto>();

            SearchData.ReplaceRange(internalAuditStoreStore.GetInternalAuditsSearchDtos(iCache.CurrentUserRole(), iCache.CurrentUser(),
                iCache.GetApplication(), iCache.CurrentUserRegion()));

            if (SearchData.Count > 0)
                SelectedRecord = SearchData.FirstOrDefault();

            OnPropertyChanged("SearchData");
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_internalAuditStoreStore,_iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}