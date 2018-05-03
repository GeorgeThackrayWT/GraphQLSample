using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor;
using MvvmHelpers;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IConditionAssessmentFormEditorModel : IConditionalAssessmentBase, INotifyPropertyChanged
    {
        ObservableRangeCollection<ComboBoxValue> KeyFeatures { get; }

        ObservableRangeCollection<ComboBoxValue> Stratum { get; }

        ExtRangeCollection<WoodlandSubsectionEditList> Records { get; set; }

        #region switch mode commands

        ICommand ShowOverallStructure { get; }

        ICommand ShowTreeAgees { get;  }

        ICommand ShowTreeSpecies { get;  }

        ICommand ShowShrubSpecies { get; }

        ICommand ShowLevelOfTreeRegeneration { get;  }

        ICommand ShowLevelOfShrubRegeneration { get; }

        ICommand ShowRegenerationTreeSpecies { get; }

        ICommand ShowRegenerationShrubSpecies { get;  }

        ICommand ShowFlora { get; }

        ICommand ShowDeadwood { get; }

        ICommand ShowAnimalDamage { get; }

        ICommand ShowInvasives { get;  }

        ICommand ShowTreeHealth { get; }

        ICommand ShowHumanImpacts { get; }

        #endregion

        int FeatureMonitoringID { get; set; }

 
        ICommand LoadData { get; }

        WoodlandSubsectionEditList EditRow { get; set; }

        #region modes

        bool OverallStructure { get; set; }

        bool TreeAges { get; set; }

        bool TreeSpecies { get; set; }

        bool ShrubSpecies { get; set; }

        bool LevelofTreeRegeneration { get; set; }

        bool LevelofShrubRegeneration { get; set; }

        bool RegenerationTreeSpecies { get; set; }

        bool RegenerationShrubSpecies { get; set; }

        bool Flora { get; set; }

        bool Deadwood { get; set; }

        bool AnimalDamage { get; set; }

        bool Invasives { get; set; }

        bool TreeHealth { get; set; }
   
        bool HumanImpacts { get; set; }


        #endregion



    }
}