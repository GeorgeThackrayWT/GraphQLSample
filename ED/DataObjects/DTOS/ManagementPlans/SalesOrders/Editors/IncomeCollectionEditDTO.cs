using MvvmHelpers;

namespace DataObjects
{
    public class IncomeCollectionEditDto : ObservableObject
    {
        public ObservableRangeCollection<IncomeEdit> IncomesFlip { get; set; }

    }
}