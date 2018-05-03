using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS.property.subobjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class DirectoryInfoModel : PropertyBase, IDirectoryInfoModel
    {

        public DirectoryInfoModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(  iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

          
            PropertyChanged += (sender, e) =>
            {
                //load data here
                DirectoryInfoDto = iPropertyStore.GetDirectoryInfo(ParentID);
            };
        }

        public DirectoryInfoDto DirectoryInfoDto { get; set; }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;
            // we only want messages that have been sent to us.
            ProcessMessage(message);
        }
    }
}