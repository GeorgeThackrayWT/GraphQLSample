using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using EDCORE.Helpers;
using MvvmHelpers;
using INavigation = Abstractions.Navigation.INavigation;

namespace EDCORE.ViewModel
{



    public class TreePlantingSearchModel : SearchModelBase<TreePlantingSearchDto>, IGeneralManagementPlanSearchModel<TreePlantingSearchDto>
    {
        private ITreePlantingStore _treePlantingStore;

        public TreePlantingSearchModel(IWTTimer iWTimer, ITreePlantingStore treePlantingStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            GetData(treePlantingStore, iCache);

            _treePlantingStore = treePlantingStore;

            LoadData = new RelayCommand((x) =>
            {
                
                _iNavigation.Navigate(iLinkContainer.TreePlantingEditor.Editor(), StateContainer.Create(SelectedRecord.ManagementUnitID, false));
            });
        }

        private void GetData(ITreePlantingStore treePlantingStore, ICache iCache)
        {
            SearchData = new ObservableRangeCollection<TreePlantingSearchDto>();
            SearchData.AddRange(treePlantingStore.GetTreePlantingDtos(iCache.CurrentUserRole(),iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion()));

            OnPropertyChanged("SearchData");
        }


        public override void HandleMessage(EdMessage message)
        {

            if (IsDisposed) return;


            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_treePlantingStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
    
}