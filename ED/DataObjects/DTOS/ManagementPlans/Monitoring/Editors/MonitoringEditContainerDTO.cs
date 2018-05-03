using MvvmHelpers;

namespace DataObjects
{
    public class MonitoringEditContainerDto : ObservableObject
    {
        public ObservableRangeCollection<MonitoringEditDto> ObservationsList { get; set; }
    }
}