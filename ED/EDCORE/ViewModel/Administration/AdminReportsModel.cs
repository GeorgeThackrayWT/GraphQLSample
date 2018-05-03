using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminReportsModel : GeneralModelBase, IAdminReportsModel
    {
        private IGeneralAdminStore _iAdminStore;

        public AdminReportsModel(IGeneralAdminStore iAdminStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            _iAdminStore = iAdminStore;



            AdminReportsDTO = _iAdminStore.GetAdminReportsDTO(0);
        }


        public AdminReportsDTO AdminReportsDTO { get; set; }

        public int ConfigurationID { get; set; }
    }
}