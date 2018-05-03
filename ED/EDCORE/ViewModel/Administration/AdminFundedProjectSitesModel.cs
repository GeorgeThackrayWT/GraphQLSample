using System.Collections.Generic;
using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminFundedProjectSitesModel : GeneralModelBase, IAdminFundedProjectSitesModel
    {

        public AdminFundedProjectSitesModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, ILinkContainer iLinkContainer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

        }

        public List<AdminFundedProjectSitesDto> FundedProjectSites { get; set; }
    }
}