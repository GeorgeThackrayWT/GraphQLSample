using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminExpenditureProductsModel
    {
        List<AdminExpenditureProductsDto> ExpenditureProducts { get; set; }
    }
}