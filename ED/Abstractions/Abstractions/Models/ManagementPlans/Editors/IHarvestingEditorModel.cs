using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IHarvestingEditorModel : IBaseModel,  INotifyPropertyChanged
    {



        ObservableRangeCollection<ComboBoxValue> Years { get; }

        int SelectedYearOption { get; set; }
        int SelectedTotalYear { get; set; }

        ObservableRangeCollection<ComboBoxValue> HarvestingOperationTypes { get; }

        ObservableRangeCollection<ComboBoxValue> Compartments { get; }

        ExtRangeCollection<HarvestingEditDTOEditList> RecordsFlip { get; set; }
        
        ICommand LoadData { get; }

        HarvestingEditDTOEditList EditRecord { get; set; }

        

        double WorkAreaTotal { get; set; }
        double EstimatedTotalQuantity { get; set; }
        double ActualTotalQuantity { get; set; }


        double ByYearWorkAreaTotal { get; set; }
        double ByYearEstimatedTotalQuantity { get; set; }
        double ByYearActualTotalQuantity { get; set; }


    }
}