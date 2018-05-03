using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminWorkProgrammeModel : GeneralModelBase, IAdminWorkProgrammeModel
    {
        private IGeneralAdminStore _iAdminStore;


        public AdminWorkProgrammeModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, IGeneralAdminStore iAdminStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {

            _iAdminStore = iAdminStore;



            GetAdminWorkProgrammeDTO = _iAdminStore.GetAdminWorkProgrammeDTO();



        }

        public AdminWorkProgrammeDTO GetAdminWorkProgrammeDTO { get; set; }
    }
}