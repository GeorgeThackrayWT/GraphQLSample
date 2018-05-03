using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Property.Interfaces
{
    public class ConditionalAssessmentEditBase : GeneralModelBase
    {

        protected int _managementId;
        protected int _woodlandConditionSubSectionId;

        protected IManagementPlanStore _IManagementPlanStore;

        public ConditionalAssessmentEditBase(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, 
            IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {

        }

        public int ManagementId {
            get => _managementId;

            set
            {
                _managementId = value;
                OnPropertyChanged();
            }
        }

        public int WoodlandConditionSubSectionId
        {
            get => _woodlandConditionSubSectionId;

            set
            {
                _woodlandConditionSubSectionId = value;
                OnPropertyChanged();
            }
        }
 
    }
}