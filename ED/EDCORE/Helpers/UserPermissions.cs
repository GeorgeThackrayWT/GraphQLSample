using System;
using System.Collections.Generic;
using Abstractions;
using Abstractions.Models;
using DataObjects.DTOS;

namespace EDCORE.Helpers
{


    public class UserPermissions : IUserPermissions
    {
        private List<UserRoleDto> _userRoles = new List<UserRoleDto>();
        private IUserStore _iUserStore;


        public UserPermissions(IUserStore iUserStore)
        {
            _userRoles = iUserStore.GetUserRoleDtos();
            _iUserStore = iUserStore;

        }
        
        public bool Check(UserActions actions)
        {                    
            return _iUserStore.UserInRequiredGroup(Convert.ToInt32(actions));
        }

        public int UserId()
        {
            return _iUserStore.CurrentUserId();
        }

    }
}
