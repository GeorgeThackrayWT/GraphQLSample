using DataObjects.DTOS;
using MvvmHelpers;

namespace Abstractions.Stores.Content
{
    public interface IMockData
    {
        ObservableRangeCollection<ReportDto> Reports { get; }
        ObservableRangeCollection<DocumentDto> Documents { get; }
    }

}
