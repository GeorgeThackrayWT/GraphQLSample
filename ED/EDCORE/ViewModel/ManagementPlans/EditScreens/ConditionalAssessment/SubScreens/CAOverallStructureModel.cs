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
    public class CAOverallStructureModel : ConditionalAssessmentEditBase, ICAOverallStructureModel
    {
        public CAOverallStructureModel(
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CAFOverallDTO.Make(
                        iConditionalAssessmentsStore.GetCafOverallDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CAFOverallDTO");

                }
            };


            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CAOverallStructureModel SaveCommand: " + CAFOverallDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCAFOverallDTO(WoodlandConditionSubSectionId, CAFOverallDTO.ConvertToDto());
            });
        }

        public CAFOverallDTOEdit CAFOverallDTO { get; set; } = new CAFOverallDTOEdit();
    }
}