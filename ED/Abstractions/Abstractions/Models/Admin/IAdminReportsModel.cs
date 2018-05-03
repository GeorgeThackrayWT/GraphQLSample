using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminReportsModel
    {
        int ConfigurationID { get; set; }

        AdminReportsDTO AdminReportsDTO { get; set; }
    }
}