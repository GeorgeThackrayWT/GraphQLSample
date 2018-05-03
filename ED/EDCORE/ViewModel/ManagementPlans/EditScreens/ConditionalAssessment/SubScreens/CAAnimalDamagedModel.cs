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
    public class CAAnimalDamagedModel : ConditionalAssessmentEditBase, ICAAnimalDamageModel
    {
        public CAAnimalDamagedModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
                     
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATAnimalDamageDTO.Make(iConditionalAssessmentsStore.GetCatAnimalDamageDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATAnimalDamageDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CAAnimalDamagedModel SaveCommand: " + CATAnimalDamageDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATAnimalDamageDTO(WoodlandConditionSubSectionId, CATAnimalDamageDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }

        public CATAnimalDamageDTOEdit CATAnimalDamageDTO { get; set; } = new CATAnimalDamageDTOEdit();
    }
}