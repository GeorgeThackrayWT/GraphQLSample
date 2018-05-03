using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminFundedProjectSitesModel
    {
        List<AdminFundedProjectSitesDto> FundedProjectSites { get; set; }
    }
}