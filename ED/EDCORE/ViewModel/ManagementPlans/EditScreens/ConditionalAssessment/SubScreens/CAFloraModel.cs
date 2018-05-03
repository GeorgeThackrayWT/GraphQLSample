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
    public class CAFloraModel : ConditionalAssessmentEditBase, ICAFloraModel
    {
        public CAFloraModel(IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, IConditionalAssessmentsStore iConditionalAssessmentsStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "WoodlandConditionSubSectionId")
                {
                    CATFloraDTO.Make(iConditionalAssessmentsStore.GetCatFloraDto(WoodlandConditionSubSectionId));

                    OnPropertyChanged("CATFloraDTO");
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("CAFloraModel SaveCommand: " + CATFloraDTO.ConvertToDto().Notes);


                iConditionalAssessmentsStore.UpdateCATFloraDTO(WoodlandConditionSubSectionId, CATFloraDTO.ConvertToDto());

                OnPropertyChanged("WoodlandConditionSubSectionId");
            });

        }

        public CATFloraDTOEdit CATFloraDTO { get; set; } = new CATFloraDTOEdit();
    }
}