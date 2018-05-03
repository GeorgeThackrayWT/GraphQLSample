using MvvmHelpers;

namespace DataObjects.DTOS.ManagementPlans.Administration.Editors
{
    public class PesticideAdminContainerDto
    {
        public ObservableRangeCollection<PesticideAdminDto> PesticideAdminsFlip { get; set; }
    }
}