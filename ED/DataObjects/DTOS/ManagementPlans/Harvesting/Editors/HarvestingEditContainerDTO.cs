using MvvmHelpers;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class HarvestingEditContainerDto
    {
        public ObservableRangeCollection<HarvestingEditDTO> HarvestingEditorList { get; set; }
    }
}