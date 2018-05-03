using System;
using System.Linq;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class ReferenceInformationModel : GeneralModelBase, IReferenceInformationModel
    {
        private IReferenceInfoStore _referenceInfoStore;

        public ReferenceInformationModel(IReferenceInfoStore referenceInfoStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _referenceInfoStore = referenceInfoStore;

            PropertyChanged += (sender, e) =>
            {
                //load data here
                ReferenceInfoListDTO = _referenceInfoStore.GetReferenceInfoListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(), iCache.CurrentUserRegion()).First(m => m.ManagementUnitID == ParentID);
            };
        }

        public ReferenceInfoListDTO ReferenceInfoListDTO { get; set; }

       
    }
}