using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models;
using DataObjects.DAOS;
using DataObjects.DTOS;
using EDCORE.ViewModel;
using Stores;

namespace SQLite
{
    //IApplicationStore

    public class UserStore : BaseStore, IUserStore
    {
        private readonly ISQLiteCache _iCache;
        private readonly IUserLookup _iUserLookup;

        public UserStore(IDBPlatformSettings platform, ISQLiteCache iCache, IUserLookup iUserLookup)
        {
            _platform = platform;

            _iCache = iCache;

            _iUserLookup = iUserLookup;

            _sqLiteSyncConnection = GetSynchConnection();

            _sqLiteAsyncConnection = GetConnection();
        }

        public Dictionary<int, string> GetUserList()
        {
            return _iCache.UserLookup;
        }

        public List<UserRoleDto> GetUserRoleDtos()
        {
            var userRoleDtos = _sqLiteSyncConnection.Query<UserRoleDto>(@"SELECT ID ,UserID ,RoleID ,RegionID ,CountryID FROM UserRole");

            return userRoleDtos;
        }

        public bool UserInRequiredGroup(int groupID)
        {
            var user = _iUserLookup.GetLoginName();

            var magicString = @"SELECT u.ID,UserID,RoleID,u.RegionID,CountryID FROM User u join UserRole ur on u.ID = ur.UserID WHERE LoginName like '" + user + "'";

            var userRoleDtos = _sqLiteSyncConnection.Query<UserRoleDto>(magicString);

            foreach (var ur in userRoleDtos)
            {
                if (ur.RoleID == groupID)
                {
                    return true;
                }
            }

            return false;
        }



        public List<User> GetUsers()
        {            
            return _sqLiteSyncConnection.Table<User>().ToList();
        }

        public int CurrentUserId()
        {
            var user = _iUserLookup.GetLoginName();

            var magicString = @"SELECT u.ID FROM User u WHERE LoginName like '%" + user + "%'";

            var userRoleDtos = _sqLiteSyncConnection.Query<UserRoleDto>(magicString);

            if (userRoleDtos.Count > 0)
            {
                return userRoleDtos.First().ID;
            }

            return 0;
        }

        public List<UserDto> GetUserDtos()
        {
            throw new NotImplementedException();
        }

        public List<PermissionGroup> CurrentUserGroup()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetUserDtosForCache()
        {
            throw new NotImplementedException();
        }

        public ILookup<int, string> GetUserLookupForCache()
        {
            throw new NotImplementedException();
        }

        public List<UserRoleSmallDto> GetUserRoleSmallDtos()
        {
            throw new NotImplementedException();
        }

        public void SetCurrentUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}