using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminWorkProgrammeModel
    {
        AdminWorkProgrammeDTO GetAdminWorkProgrammeDTO { get; set; }
    }
}