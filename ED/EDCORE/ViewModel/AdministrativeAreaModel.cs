using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public class AdministrativeAreaModel : GeneralModelBase, IAdministrativeAreaModel
    {
        public AdministrativeAreaModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
           
        }
    }
}