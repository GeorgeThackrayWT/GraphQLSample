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
    public class CADeadWoodModel : ConditionalAssessmentEditBase, ICADeadWoodModel
    {
        public CADeadWoodModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATDeadWoodDTO.Make(iConditionalAssessmentsStore.GetCatDeadWoodDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATDeadWoodDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CADeadWoodModel SaveCommand: " + CATDeadWoodDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATDeadWoodDTO(WoodlandConditionSubSectionId, CATDeadWoodDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }
             
        public CATDeadWoodDTOEdit CATDeadWoodDTO { get; set; } = new CATDeadWoodDTOEdit();
    }
}