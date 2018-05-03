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
    public class CALevelOfTreeRegenerationModel : ConditionalAssessmentEditBase, ICALevelOfTreeRegenerationModel
    {
        public CALevelOfTreeRegenerationModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATLevelOfTreeRegenerationDTO.Make(
                        iConditionalAssessmentsStore.GetCatLevelOfTreeRegenerationDto(WoodlandConditionSubSectionId));


                    OnPropertyChanged("CATLevelOfTreeRegenerationDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATLevelOfTreeRegenerationDTO SaveCommand: " + CATLevelOfTreeRegenerationDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATLevelOfTreeRegenerationDTO(WoodlandConditionSubSectionId, CATLevelOfTreeRegenerationDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }

        public CATLevelOfTreeRegenerationDTOEdit CATLevelOfTreeRegenerationDTO { get; set; } = new CATLevelOfTreeRegenerationDTOEdit();
    }
}