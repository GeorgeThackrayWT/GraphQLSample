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
    public class CARegenerationTreeSpeciesModel : ConditionalAssessmentEditBase, ICARegenerationTreeSpeciesModel
    {
        public CARegenerationTreeSpeciesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATRegenerationTreeSpeciesDTO.Make(
                        iConditionalAssessmentsStore.GetCatRegenerationTreeSpeciesDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATRegenerationTreeSpeciesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATRegenerationTreeSpeciesDTO SaveCommand: " + CATRegenerationTreeSpeciesDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATRegenerationTreeSpeciesDTO(WoodlandConditionSubSectionId, CATRegenerationTreeSpeciesDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }
      
        public CATRegenerationTreeSpeciesDTOEdit CATRegenerationTreeSpeciesDTO { get; set; } 
            = new CATRegenerationTreeSpeciesDTOEdit();
    }
}