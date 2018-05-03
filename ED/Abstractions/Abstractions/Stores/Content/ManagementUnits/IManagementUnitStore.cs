using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans;

namespace Abstractions
{
    public interface IManagementUnitStore : IBaseStore
    {
        List<ManagementUnitShortDto> GetManagementUnitLookupData(int applicationId);
        List<ManagementUnitShortDto> GetManagementUnitLookupData();

        List<ManagementUnitDto> GetManagementUnits();

        List<ManagementUnitDto> GetFilteredManagementUnits(string filter);

        List<ManagementPlanDto> GetManagementPlans();

        List<ManagementUnitDto> GetManagementUnitDtosForCache();

        List<TenureDto> GetTenures();

        Dictionary<int, int> GetAcquisitionUnitOfficers();

        int CreateManagementUnit(string costCenter);
    }
}