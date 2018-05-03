using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public class MapsModel : GeneralModelBase, IMapsModel
    {
       
        public MapsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
          
        }

    }
}