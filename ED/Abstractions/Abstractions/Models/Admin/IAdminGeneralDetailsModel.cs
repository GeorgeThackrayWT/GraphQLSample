using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminGeneralDetailsModel
    {
        int ConfigurationID { get; set; }

        AdminGeneralDetailsDto AdminGeneralDetailsDto { get; set; }
    }
}