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
    public class CATreeAgesModel : ConditionalAssessmentEditBase, ICTreeAgesModel
    {
        public CATreeAgesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATTreeAgesDTO.Make(
                        iConditionalAssessmentsStore.GetCatTreeAgesDto(WoodlandConditionSubSectionId));



                    OnPropertyChanged("CATTreeAgesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATreeAgesModel SaveCommand: " + CATTreeAgesDTO.ConvertToDto().Notes);


                iConditionalAssessmentsStore.UpdateCATTreeAgesDTO(WoodlandConditionSubSectionId, CATTreeAgesDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }

        public CATTreeAgesDTOEdit CATTreeAgesDTO { get; set; } = new CATTreeAgesDTOEdit();
    }



}