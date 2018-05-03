using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{

    public interface IHiddenPanel
    {
        ICommand ShowHide { get; }

        bool Visible { get; set; }

    }

    public interface ISummaryDescriptionEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        SummaryOverviewEdit SummaryOverviewEdit { get; set; }

        ExtRangeCollection<SummaryEditList> SummariesList { get; set; }
        SummaryEditList SelectedSummary { get; set; }
        ExtRangeCollection<SummaryConstraintEditList> MajorManagementConstraintsList { get; set; }
        SummaryConstraintEditList SelectedConstraint { get; set; }
        ExtRangeCollection<SummaryFeatureEditList> ConservationFeaturesList { get; set; }
        SummaryFeatureEditList SelectedFeature { get; set; }
        ExtRangeCollection<SummaryDesignationEditList> DesignationsList { get; set; }
        SummaryDesignationEditList SelectedDesignation { get; set; }



        List<ComboBoxValue> YearsLookup { get; set; }
        List<ComboBoxValue> MainSpeciesLookup { get; set; }
  
        List<ComboBoxValue> ManagementRegionsLookup { get; set; }
        List<ComboBoxValue> ManagementConstraintTypesLookup { get; set; }
        List<ComboBoxValue> ConservationTypesLookup { get; set; }
        List<ComboBoxValue> DesignationsLookup { get; set; }




        IHiddenPanel SummaryDescription { get; }

        IHiddenPanel LongTermPolicy { get; }


        ICommand PAWSMap { get; }

        ICommand CompartmentMap { get; }
        
    }
}