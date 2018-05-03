using System;
using Abstractions;
using Abstractions.Models.Safety.Editors;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class SafetyBioRiskModel : GeneralModelBase, ISafetyBioRiskModel
    {
        private int _hazardID;

        private ISafetyStore _safetyStore;
      
        public SafetyBioRiskModel(IWTTimer iWTimer, ISafetyStore safetyStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _safetyStore = safetyStore;
 
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "HazardID")
                {
                    if (HazardID != 0)
                    {
                       
                    }

                }

            };
        }
        
        public int HazardID
        {
            get
            {
                return _hazardID;
            }
            set
            {
                if (_hazardID == value) return;
                _hazardID = value;

                OnPropertyChanged();
            }
        }
    }
}