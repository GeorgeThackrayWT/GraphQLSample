using MvvmHelpers;

namespace DataObjects
{
    public class ExpenditureCollectionEditDto : ObservableObject
    {
        public ObservableRangeCollection<ExpenditureDto> ExpenditureFlip { get; set; }

    }
}