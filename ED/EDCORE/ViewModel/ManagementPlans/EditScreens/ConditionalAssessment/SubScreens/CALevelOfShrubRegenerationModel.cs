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
    public class CALevelOfShrubRegenerationModel : ConditionalAssessmentEditBase, ICALevelOfShrubRegenerationModel
    {
        public CALevelOfShrubRegenerationModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATLevelOfShrubRegenerationDTO.Make(iConditionalAssessmentsStore.GetCatLevelOfShrubRegenerationDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATLevelOfShrubRegenerationDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATLevelOfShrubRegenerationDTO SaveCommand: " + CATLevelOfShrubRegenerationDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATLevelOfShrubRegenerationDTO(WoodlandConditionSubSectionId, CATLevelOfShrubRegenerationDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }

        public CATLevelOfShrubRegenerationDTOEdit CATLevelOfShrubRegenerationDTO { get; set; } = new CATLevelOfShrubRegenerationDTOEdit();
    }
}