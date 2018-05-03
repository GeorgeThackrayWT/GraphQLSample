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
    public class CAShrubSpeciesModel : ConditionalAssessmentEditBase, ICAShrubSpeciesModel
    {
        public CAShrubSpeciesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {

                    CATShrubSpeciesDTO.Make(
                        iConditionalAssessmentsStore.GetCatShrubSpeciesDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATShrubSpeciesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATShrubSpeciesDTO SaveCommand: " + CATShrubSpeciesDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATShrubSpeciesDTO(WoodlandConditionSubSectionId, CATShrubSpeciesDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }
      
        public CATShrubSpeciesDTOEdit CATShrubSpeciesDTO { get; set; } = new CATShrubSpeciesDTOEdit();
    }
}