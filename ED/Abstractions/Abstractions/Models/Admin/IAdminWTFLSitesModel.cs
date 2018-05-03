using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminWTFLSitesModel
    {
        List<AdminWTFLSitesDTO> WtflSites { get; set; }
    }
}