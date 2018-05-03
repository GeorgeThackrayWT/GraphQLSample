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
    public class CAStrataSummariesModel : ConditionalAssessmentEditBase, ICAStrataSummariesModel
    {
        private int _featureMonitoringID;

        public CafStrataSummaryDto CAFStrataSummaryDTO { get; set; }

        private CAFSummaryObjDTO _selectedSummaryObjDto;

        public CAStrataSummariesModel(IWTTimer iWTimer,
            IConditionalAssessmentsStore iConditionalAssessmentsStore,
            IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "FeatureMonitoringID")
                {                   
                    CAFStrataSummaryDTO = iConditionalAssessmentsStore.GetCAFStrataSummaryDTO(FeatureMonitoringID);
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
        
        public CAFSummaryObjDTO SelectedRow
        {
            get
            {
                if (_selectedSummaryObjDto == null) return null;

                return _selectedSummaryObjDto ?? CAFStrataSummaryDTO.CafSummaryObjsList[0];
            }

            set
            {
                if (_selectedSummaryObjDto == value) return;
                _selectedSummaryObjDto = value;

                 

                OnPropertyChanged();
            }
        }
    }
}