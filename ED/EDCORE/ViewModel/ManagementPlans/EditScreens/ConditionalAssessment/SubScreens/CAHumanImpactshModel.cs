using System;
using System.Diagnostics;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class CAHumanImpactshModel : ConditionalAssessmentEditBase, ICAHumanImpactshModel
    {
        public CAHumanImpactshModel(
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATHumanImpactsDTO.Make(
                        iConditionalAssessmentsStore.GetCatHumanImpactsDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATHumanImpactsDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATHumanImpactsDTOEdit SaveCommand: " + CATHumanImpactsDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATHumanImpactsDTO(WoodlandConditionSubSectionId, CATHumanImpactsDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }
         
        public CATHumanImpactsDTOEdit CATHumanImpactsDTO { get; set; } = new CATHumanImpactsDTOEdit();
    }
}