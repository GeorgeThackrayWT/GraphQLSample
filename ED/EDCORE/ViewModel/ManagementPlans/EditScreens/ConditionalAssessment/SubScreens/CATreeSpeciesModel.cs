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
    public class CATreeSpeciesModel : ConditionalAssessmentEditBase, ICATreeSpeciesModel
    {
        public CATreeSpeciesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATTreeSpeciesDTO.Make(
                        iConditionalAssessmentsStore.GetCatTreeSpeciesDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATTreeSpeciesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATreeSpeciesModel SaveCommand: " + CATTreeSpeciesDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATTreeSpeciesDTO(WoodlandConditionSubSectionId, CATTreeSpeciesDTO.ConvertToDto());


                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }
        
        public CATTreeSpeciesDTOEdit CATTreeSpeciesDTO { get; set; } = new CATTreeSpeciesDTOEdit();

    }
}