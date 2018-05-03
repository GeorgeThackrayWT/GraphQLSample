using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using DataObjects.DTOS.Tasks;
using EDCORE.ViewModel;
using SQLiteNetExtensionsAsync.Extensions;
using Stores;

namespace SQLite
{
    public class TaskStore : BaseStore, ITaskStore
    {
        private readonly ISQLiteCache _iCache;


        public TaskStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;
            _iCache = iCache;
            _sqLiteAsyncConnection = GetConnection();
            _sqLiteSyncConnection = GetSynchConnection();
        }
       
        public List<EdTaskDto> GetSimpleTasksAsync()
        {
            var returnList0 = new List<DataObjects.EdTaskDto>();

            var r1 = _sqLiteSyncConnection.Table<DataObjects.DAOS.Task>();
            
            returnList0.AddRange(r1.Select(t => new DataObjects.EdTaskDto()
            {                                    
                Amount = t.Amount ?? 0,
                Manager = t.ManagementUnit.GetIFNull().WoodlandOfficer.DisplayName,
                Category = t.TaskCategory.Description,
                Notes = t.Notes,
                Region = t.ManagementUnit.GetIFNull().Region.Description,
                TaskId = t.ID

            }));
            
            return returnList0;
        }

        public List<TaskCategoryDto> GetTaskCategories()
        {
            var r1 = _sqLiteSyncConnection.Table<TaskCategory>().Select(t=> new TaskCategoryDto()
            {
                ID = t.ID,
                Description = t.Description
            });


            return r1.ToList();
        }

        public List<EdTaskDto> GetTasks()
        {
    
            var returnList0 = new List<DataObjects.EdTaskDto>();

            var r1 = _sqLiteSyncConnection.Table<DataObjects.DAOS.Task>();

            returnList0.AddRange(r1.Select(t => new DataObjects.EdTaskDto()
            {     
                Notes = t.Notes,           
                TaskId = t.ID
            }));


            return returnList0;
        }

        public List<EdTaskDto> GetTasks(DateRangeFilter dateRangeFilter, int managementUnitId =0)
        {
            var returnList0 = new List<EdTaskDto>();

         
            var tasks = _sqLiteSyncConnection.Table<DataObjects.DAOS.Task>()
                .Where(p => (p.DeadlineDate >= dateRangeFilter.From && p.DeadlineDate <= dateRangeFilter.To) && p.Deleted == false && p.CompletedDate != null).ToList();


           // tasks = tasks.Where(p => p.DeadlineDate >= dateRangeFilter.From && p.DeadlineDate <= dateRangeFilter.To).ToList();

            int idx = 0;

            while (idx < tasks.Count())
            {

                var manu = _iCache.ManagementUnits.FirstOrDefault();
                var woodlandOfficer = "";
                var region = "";
                var category = "";

                if (manu != null)
                {
                    woodlandOfficer = _iCache.UserLookup[manu.WoodlandOfficerId];
                    region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()];
                    category = _iCache.TaskCategories[tasks[idx].CategoryID];
                }

                returnList0.Add(new EdTaskDto()
                {
                    Amount = tasks[idx].Amount ?? 0,
                    Manager = woodlandOfficer,
                    Category = category,
                    Notes = tasks[idx].Notes,
                    Region = region,
                    TaskId = tasks[idx].ID,
                    Deadline = tasks[idx].DeadlineDate
                });
                idx++;
            }
           
             
            return returnList0;
        }

        public List<EdTaskDto> GetTasks(List<UserRoleSmallDto> userRole, int userId, int application, int regionId, DateRangeFilter dateRangeFilter, int managementUnitId = 0)
        {
            throw new NotImplementedException();
        }
    }   
}