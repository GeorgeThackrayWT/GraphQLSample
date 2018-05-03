using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.Tasks;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.Tasks
{
    public class TasksEFStore : BaseEFStore, ITaskStore
    {
        public TasksEFStore(EstateContext ec,ICache iCache) : 
            base(ec,iCache)
        {
        }

        public List<EdTaskDto> GetTasks(List<UserRoleSmallDto> userRole, int userId, int application, int regionId,DateRangeFilter dateRangeFilter, int managementUnitId = 0)
        {
            var tasks = Context.Task.Include(m=>m.ManagementUnit).Include(a=>a.Category).Select(s=>new
                {
                    s.Amount,
                    s.DeadlineDate,
                    s.Deleted,
                    s.CompletedDate,
                    s.ManagementUnitId,
                    s.Notes,
                    s.Id,
                    s.Category.Description,
                    s.ManagementUnit.WoodlandOfficerId

                })
                .Where(p => (p.DeadlineDate >= dateRangeFilter.From && p.DeadlineDate <= dateRangeFilter.To) && p.Deleted == false && p.CompletedDate != null && p.ManagementUnitId!=null).ToList();

            return tasks.Select(t => new EdTaskDto()
                {
                    ManagementUnitID = t.ManagementUnitId.GetValueOrDefault(),
                    Amount = t.Amount ?? 0,
                    Manager = UserName(t.WoodlandOfficerId),
                    Category = t.Description,
                    Notes = t.Notes,
                    Region = RegionName(t.ManagementUnitId),
                    
                    TaskId = t.Id,
                    Deadline = t.DeadlineDate
                })
                .Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList(); 
        }

        public List<TaskCategoryDto> GetTaskCategories()
        {       
            return Context.TaskCategory.Select(t=>new TaskCategoryDto()
            {
                ID = t.Id,
                Description = t.Description
            }).ToList();
        }
    }
}
