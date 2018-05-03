using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminVatRateLocksModel
    {
        List<AdminVATRateLocks> VatRateLocks { get; set; }
    }
}