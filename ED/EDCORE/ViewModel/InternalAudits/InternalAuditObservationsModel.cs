using System;
using Abstractions;
using Abstractions.Models.InternalAudits;
using Abstractions.Navigation;
using Abstractions.Stores.Content.InternalAudits;
using DataObjects.DTOS.InternalAudits;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public class InternalAuditObservationsModel : GeneralModelBase, IInternalAuditObservationsModel
    {

        private InternalAuditsObservationEditEdit _auditsWoodlists;
        
        public InternalAuditsObservationEditEdit InternalAuditObservations
        {
            get { return _auditsWoodlists; }
            set
            {
                if (_auditsWoodlists == value) return;

                _auditsWoodlists = value;

           //     OnPropertyChanged();
            }
        }
        
        public InternalAuditObservationsModel(IWTTimer iWTimer, IInternalAuditStore internalAuditStoreStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {       
            InstanceID = GetType().Name + Guid.NewGuid();
            
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                  

                }

            };


        }
    }
}