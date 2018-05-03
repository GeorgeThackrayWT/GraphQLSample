using System.Collections.Generic;
using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminExpenditureProductsModel : GeneralModelBase, IAdminExpenditureProductsModel
    {

        public AdminExpenditureProductsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,   ITelerikConvertors iTelerikConvertors, ILinkContainer iLinkContainer,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

        }

        public List<AdminExpenditureProductsDto> ExpenditureProducts { get; set; }
    }
}