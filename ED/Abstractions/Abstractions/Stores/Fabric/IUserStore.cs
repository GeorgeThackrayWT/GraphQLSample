using System.Collections.Generic;
using System.Linq;
using DataObjects.DTOS;
using EDCORE.ViewModel;

namespace Abstractions
{

    public interface IApplicationStore : IBaseStore
    {
        List<ApplicationDto> GetApplications();
    }


    public interface IUserStore : IBaseStore
    {
        Dictionary<int, string> GetUserList();
                    
        List<UserDto> GetUserDtos();


        List<UserRoleDto> GetUserRoleDtos();

        List<PermissionGroup> CurrentUserGroup();

        bool UserInRequiredGroup(int groupID);

        int CurrentUserId();


        List<UserDto> GetUserDtosForCache();

        ILookup<int, string> GetUserLookupForCache();

        List<UserRoleSmallDto> GetUserRoleSmallDtos();

        void SetCurrentUser(int userId);

    }
}