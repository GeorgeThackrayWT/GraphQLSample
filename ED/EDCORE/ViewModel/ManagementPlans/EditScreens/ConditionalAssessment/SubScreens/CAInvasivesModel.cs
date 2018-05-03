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
    public class CAInvasivesModel : ConditionalAssessmentEditBase, ICAInvasivesModel
    {
        public CAInvasivesModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATInvasivesDTO.Make(
                        iConditionalAssessmentsStore.GetCatInvasivesDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATInvasivesDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CATInvasivesDTO SaveCommand: " + CATInvasivesDTO.ConvertToDto().Notes);

                iConditionalAssessmentsStore.UpdateCATInvasivesDTO(WoodlandConditionSubSectionId, CATInvasivesDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });
        }

      
        public CATInvasivesDTOEdit CATInvasivesDTO { get; set; } = new CATInvasivesDTOEdit();
    }
}