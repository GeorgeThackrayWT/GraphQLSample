using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminGeneralDetailsModel : GeneralModelBase, IAdminGeneralDetailsModel
    {
        private IGeneralAdminStore _iAdminStore;


        public AdminGeneralDetailsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
           INavigation iNavigation, IPageMessageBus iPageMessageBus,  IGeneralAdminStore iAdminStore, ITelerikConvertors iTelerikConvertors, ILinkContainer iLinkContainer,
           ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            _iAdminStore = iAdminStore;

            AdminGeneralDetailsDto = _iAdminStore.GetAdminGeneralDetailsDto(0);
        }

        public AdminGeneralDetailsDto AdminGeneralDetailsDto { get; set; }

        public int ConfigurationID { get; set; }
    }
}
