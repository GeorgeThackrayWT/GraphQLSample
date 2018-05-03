using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.Tasks;
using EDCORE.ViewModel;

namespace Abstractions
{
    public interface ITaskStore : IBaseStore
    {
        //List<EdTaskDto> GetSimpleTasksAsync();

        List<EdTaskDto> GetTasks(List<UserRoleSmallDto> userRole, int userId, int application, int regionId,DateRangeFilter dateRangeFilter, int managementUnitId =0);

        //List<EdTaskDto> GetTasks();

        List<TaskCategoryDto> GetTaskCategories();
    }
}