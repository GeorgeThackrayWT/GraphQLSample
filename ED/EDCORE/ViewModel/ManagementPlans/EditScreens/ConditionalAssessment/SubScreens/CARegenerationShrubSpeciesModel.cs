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
    public class CARegenerationShrubSpeciesModel : ConditionalAssessmentEditBase, ICARegenerationShrubSpeciesModel
    {
        public CARegenerationShrubSpeciesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATRegenerationShrubSpeciesDTO.Make(
                        iConditionalAssessmentsStore.GetCatRegenerationShrubSpeciesDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATRegenerationShrubSpeciesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATRegenerationShrubSpeciesDTO SaveCommand: " + CATRegenerationShrubSpeciesDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATRegenerationShrubSpeciesDTO(WoodlandConditionSubSectionId, CATRegenerationShrubSpeciesDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }

        public CATRegenerationTreeSpeciesDTOEdit CATRegenerationShrubSpeciesDTO { get; set; } =
            new CATRegenerationTreeSpeciesDTOEdit();
    }
}