using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans;
using Stores;


namespace SQLite
{
    public class ManagementUnitStore : BaseStore, IManagementUnitStore
    {
        private readonly ISQLiteCache _iCache;
        
        public ManagementUnitStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }
     
        public List<ManagementUnitShortDto> GetManagementUnitLookupData()
        {
            var returnList0 = new List<ManagementUnitShortDto>();

            returnList0.AddRange(_iCache.ManagementUnits.Select(t => new ManagementUnitShortDto()
            {
                ManagementUnitId = t.Id,
                Name = t.Name,          
            }));

            return returnList0;
        }

        public List<ManagementUnitShortDto> GetManagementUnitLookupData(int applicationId)
        {
            var returnList0 = new List<ManagementUnitShortDto>();

            var r1 = _iCache.ManagementUnits.Where(m=>m.ApplicationId == applicationId);

            returnList0.AddRange(r1.Select(t => new ManagementUnitShortDto()
            {
                ManagementUnitId = t.Id,
                Name = t.Name,
            }));

            return returnList0;
        }

        public List<IncomeDto> GetIncomes()
        {
        //    return _sqLiteSyncConnection.Table<Income>().ToList();
            return new List<IncomeDto>();
        }


        public List<TenureDto> GetTenures()
        {
            return new List<TenureDto>();
        }

        public List<ManagementUnitDto> GetFilteredManagementUnits(string filter)
        {
            throw new NotImplementedException();
        }

        public List<ManagementPlanDto> GetManagementPlans()
        {
            return new List<ManagementPlanDto>();
        }

        public List<ManagementUnitDto> GetManagementUnits()
        {
        //    return _sqLiteSyncConnection.Table<ManagementUnit>().ToList();
            return new List<ManagementUnitDto>();
        }

        public int CreateManagementUnit()
        {
            throw new NotImplementedException();
        }

        public int CreateManagementUnit(string costCenter)
        {
            throw new NotImplementedException();
        }

        public List<ManagementUnitDto> GetManagementUnitDtosForCache()
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, int> GetAcquisitionUnitOfficers()
        {
            throw new NotImplementedException();
        }
    }
}
