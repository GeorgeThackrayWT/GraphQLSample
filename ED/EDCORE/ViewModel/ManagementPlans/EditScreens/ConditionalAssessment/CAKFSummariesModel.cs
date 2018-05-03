using System;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class CAKFSummariesModel : ConditionalAssessmentEditBase, ICAKFSummariesModel
    {    
        public CafkfSummaries CAFKFSummariesDTO { get; set; }

        private bool _isVisible = false;

        private int _featureMonitoringID;
        
        public CAKFSummariesModel(IWTTimer iWTimer,
            IConditionalAssessmentsStore iConditionalAssessmentsStore,
            IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "FeatureMonitoringID")
                {
                    CAFKFSummariesDTO = iConditionalAssessmentsStore.GetKfSummaries(FeatureMonitoringID);

                    if (CAFKFSummariesDTO.SummariesList.Count > 0)
                    {
                        _isVisible = true;
                    }
                    else
                    {
                        _isVisible = false;
                    }
                }
            };

        }

        public int FeatureMonitoringID
        {
            get
            {
                return _featureMonitoringID;
            }

            set
            {
                _featureMonitoringID = value;
                OnPropertyChanged();
            }
        }

        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }

            set { _isVisible = value; }
        }
    }
}