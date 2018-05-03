using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class SubAcquisitionUnitModel : PropertyBase
    {
        public SubAcquisitionUnitModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus, iLookupStore, iTelerikConvertors, iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();


            PropertyChanged += (sender, e) =>
            {
                //load data here
                //   BeneficialCovenantsDto = _iPropertyStore.GetBeneficialCovenantsDto(ParentID);


            };
            
        }


        public override void HandleMessage(EdMessage message)
        {
            // we only want messages that have been sent to us.

            if (IsDisposed) return;


            ProcessMessage(message);
        }
    }
}