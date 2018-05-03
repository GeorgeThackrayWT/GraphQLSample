using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace Abstractions
{
    public interface IWorkProgrammeEditorModel : IBaseModel, ICommonInterface, INotifyPropertyChanged
    {

        ExtRangeCollection<IncomeEditList> IncomesList { get; set; }

        ExtRangeCollection<ExpenditureEditList> ExpenditureList { get; set; }

        int YearOption { get; set; }

        WPSummaryDTO IncomeTotalsThisSite { get; }

        WPSummaryDTO IncomeTotalsMySites { get; }

        WPSummaryDTO ExpenditureTotalsThisSite { get; }

        WPSummaryDTO ExpenditureTotalsMySites { get; }

        IncomeEditList SelectedWpIncomeDto { get; set; }

        ExpenditureEditList SelectedWpExpenditureDto { get; set; }

        int ManagementUnitId { get; set; }

        ICommand LoadIncome { get; }

        ICommand LoadExpenditure { get; }

        ICommand ExpendituresFocused { get; }

        ICommand IncomesFocused { get; }
    }
}