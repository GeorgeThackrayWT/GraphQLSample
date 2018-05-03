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
    public class CATreeHealthModel : ConditionalAssessmentEditBase, ICATreeHealthModel
    {
        public CATreeHealthModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATTreeHealthDTO.Make(
                        iConditionalAssessmentsStore.GetCatTreeHealthDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATTreeHealthDTO");
                }
            };


            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATTreeHealthDTO SaveCommand: " + CATTreeHealthDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATTreeHealthDTO(WoodlandConditionSubSectionId, CATTreeHealthDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }

        public CATTreeHealthDTOEdit CATTreeHealthDTO { get; set; } = new CATTreeHealthDTOEdit();
    }
}