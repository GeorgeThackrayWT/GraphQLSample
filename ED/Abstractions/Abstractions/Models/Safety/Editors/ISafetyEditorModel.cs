using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using MvvmHelpers;

namespace Abstractions.Models.Safety.Editors
{
    public interface ISafetyEditorModel : IBaseModel, INotifyPropertyChanged
    {

        //   HazardCollectionDto Hazards { get; }

         ExtRangeCollection<HazardEditList> Records { get; set; }

         RiskAssessmentEdit RiskAssessmentDto { get; set; }

         HazardEditList EditRecord { get; set; }



         bool HazardsListActive { get; set; }

         bool SiteBasedControlMeasuresActive { get; set; }

         bool FirePlanActive { get; set; }

         bool BiosecurityZoneActive { get; set; }

         bool PersonalLocalIssuesActive { get; set; }

         bool ProbabilitySeverityInjuryTableActive { get; set; }
        

        ObservableRangeCollection<HazardTypeDtoLookup> HazardTypeLookup { get;  }

        ObservableRangeCollection<HazardCategoryDtoLookup> HazardCategoryLookup { get;  }

        ObservableRangeCollection<HazardOwnershipDtoLookup> HazardOwnershipLookup { get; }
        
    //    int ManagementUnitID { get; set; }

        ICommand LoadData { get; }

        

        ICommand Autherise { get; }

        ICommand ShowHazardsList { get; }

        ICommand ShowShowSiteBasedControlMeasures { get; }

        ICommand ShowFirePlan { get;  }

        ICommand ShowBiosecurityZone { get; }

        ICommand ShowPersonalLocalIssues { get;}

        ICommand ShowProbabilitySeverityInjuryTable { get;  }

        ICommand ShowHazardMap { get; }



    }
}
