using System.Collections.Generic;
using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminVATRateLocksModel : GeneralModelBase, IAdminVatRateLocksModel
    {

        public AdminVATRateLocksModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {

        }

        public List<AdminVATRateLocks> VatRateLocks { get; set; }
    }
}