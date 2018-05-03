using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminUsersAndGroupsModel : GeneralModelBase, IAdminUsersAndGroupsModel
    {

        public AdminUsersAndGroupsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {

        }

        public int ConfigurationID { get; set; }
    }
}