using System.Collections.Generic;
using System.Threading.Tasks;
using Abstractions;
using DataObjects.DAOS;
using Stores;

namespace SQLite
{
    public class RegionStore : BaseStore, IRegionStore
    {
        private readonly ISQLiteCache _iCache;

        public RegionStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

        }
        
        public Task<List<Region>> GetRegions()
        {
            return _sqLiteAsyncConnection.Table<Region>().ToListAsync();
        }
    }
}