using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Models;
using DataObjects.DAOS;
using DataObjects.DTOS;
using EDC_Estate.Models.DB;
using EDCORE.ViewModel;
using Microsoft.EntityFrameworkCore;
using User = DataObjects.DAOS.User;

namespace EFStores.Fabric
{
    public class UserEFStore : BaseEFStore , IUserStore
    {

        private readonly IUserLookup _iUserLookup;
        private int _specifiedUser = 0;

        public UserEFStore(EstateContext ec, ICache iCache,IUserLookup iLookupStore) : 
            base(ec, iCache)
        {
            _iUserLookup = iLookupStore;
        }



        public Dictionary<int, string> GetUserList()
        {
            return Context.User.Select(t => new {t.Id, t.DisplayName}).ToDictionary(s => s.Id, s => s.DisplayName);
        }
 
        public List<UserRoleDto> GetUserRoleDtos()
        {
            return Context.UserRole.Include(u=>u.User).Select(t => new UserRoleDto()
            {
                ID = t.Id,
                UserID = t.UserId,
                CountryID = t.User.Country.Count >0 ? t.User.Country.First().Id : 0,
                RegionID = t.RegionId,
                RoleID = t.RoleId
            }).ToList();
        }

        public List<PermissionGroup> CurrentUserGroup()
        {
            var results = new List<PermissionGroup>();

            var cuserid = CurrentUserId();

            //var useroles = Context.UserRole.FirstOrDefault(f => f.UserId == cuserid);

            foreach (var ur in Context.UserRole.Where(w=>w.UserId == cuserid))
            {

                switch (ur.RoleId)
                {
                    case 1: results.Add(PermissionGroup.GroupA); break;
                    case 2: results.Add(PermissionGroup.GroupB); break;
                    case 3: results.Add(PermissionGroup.GroupC); break;
                    case 4: results.Add(PermissionGroup.GroupD); break;
                    case 5: results.Add(PermissionGroup.GroupE); break;
                    case 6: results.Add(PermissionGroup.GroupF); break;
                    case 7: results.Add(PermissionGroup.GroupG); break;
                    case 8: results.Add(PermissionGroup.GroupH); break;
                    case 9: results.Add(PermissionGroup.GroupI); break;
                    case 10: results.Add(PermissionGroup.GroupJ); break;
                    case 11: results.Add(PermissionGroup.GroupK); break;
                    case 12: results.Add(PermissionGroup.GroupL); break;
                    case 13: results.Add(PermissionGroup.GroupM); break;
                    case 14: results.Add(PermissionGroup.GroupN); break;
                    case 15: results.Add(PermissionGroup.GroupO); break;
                    case 16: results.Add(PermissionGroup.GroupP); break;
                    case 17: results.Add(PermissionGroup.GroupQ); break;
                    case 18: results.Add(PermissionGroup.GroupR); break;
                    case 19: results.Add(PermissionGroup.GroupS); break;
                    case 20: results.Add(PermissionGroup.GroupT); break;           
                }

                
            }


            return results;
        }

        public bool UserInRequiredGroup(int groupID)
        {
            var user = _iUserLookup.GetLoginName();

            foreach (var ur in Context.UserRole.Include(u => u.User).Where(u=>u.User.LoginName.ToLower().Contains(user.ToLower())))
            {
                if (ur.RoleId == groupID)
                {
                    return true;
                }
            }
            return false;
        }

        public int CurrentUserId()
        {
            var user = _iUserLookup.GetLoginName();


            if (_specifiedUser <1)
            {

                var users = _cache.UserDtos.Where(u => u.LoginName.ToLower().Contains(user.ToLower())).ToList();

                if (users.Any())
                {
                    return users.First().ID;
                }

            }
            else
            {
                var users = _cache.UserDtos.Where(w => w.ID == _specifiedUser);

                if (users.Any())
                {
                    return users.First().ID;
                }
            }


            return 0;
        }

        public List<DataObjects.DAOS.User> GetUsers()
        {
            //sql lite cache stuff
            throw new System.NotImplementedException();
        }

        //get users
        public List<UserDto> GetUserDtos()
        {
            var results = new List<UserDto>();

            foreach (var user in Context.User.Where(w => !w.Deleted).Include(i=>i.UserRole).Where(w=>!w.Deleted && w.DisplayName!=null).OrderBy(o=>o.DisplayName))
            {
                var roleList = "";

                foreach (var role in user.UserRole)
                {
                    roleList += role.RoleId + " ";
                }

                roleList = roleList.Trim().Replace(" ", ",");

            

                var newUserDto = new UserDto()
                {
                    ID = user.Id,
                    RegionId = user.RegionId.GetValueOrDefault(),
                    Description = user.DisplayName + "("+ roleList+")",
                    Name = user.LoginName
                };

                results.Add(newUserDto);
            }

            return results;
        }

        public List<UserDto> GetUserDtosForCache()
        {
            var userLookup = Context.User.Where(w => !w.Deleted).AsNoTracking().Select(us => new UserDto()
            {
                ID = us.Id,
                LoginName = us.LoginName,
                DisplayName = us.DisplayName,
                Name = us.DisplayName

            }).ToList();

            return userLookup;
        }

        public ILookup<int, string> GetUserLookupForCache()
        {
            var userLookup = Context.User.AsNoTracking().Where(w=>!w.Deleted).ToList().Select(p => new { p.Id, p.DisplayName })
                .AsEnumerable()
                .ToLookup(kvp => kvp.Id, kvp => kvp.DisplayName);

            return userLookup;
        }

        public List<UserRoleSmallDto> GetUserRoleSmallDtos()
        {
            var userRoleSmallDtos = Context.UserRole.AsNoTracking().Select(u => new UserRoleSmallDto()
            {
                UserId = u.UserId,
                Id = u.Id,
                RegionId = u.RegionId.GetValueOrDefault(),
                RoleId = u.RoleId

            }).ToList();


            return userRoleSmallDtos;
        }

        public void SetCurrentUser(int userId)
        {
            this._specifiedUser = userId;
        }
    }
}
