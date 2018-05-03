using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminIncomeProductsModel
    {
        List<AdminIncomeProductsDTO> IncomeProducts { get; set; }
    }
}