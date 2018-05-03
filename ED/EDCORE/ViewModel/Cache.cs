using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using EDCORE.ViewModel;
using DataObjects.DTOS;
using EDCORE.Helpers;

namespace EDCORE
{


    public class Cache : ICache
    {

        private IUserStore _userStore;

        private IPageMessageBus _iPageMessageBus;

        public List<UserDto> UserDtos { get; set; } = new List<UserDto>();

        public ILookup<int, string> UserLookup { get; set; }

        public List<UserRoleSmallDto> UserRoleSmallDtos { get; set; } = new List<UserRoleSmallDto>();
        
        public ILookup<int, string> RegionLookup { get; set; }

        public List<ManagementUnitDto> ManagementUnitDtos { get; set; }
        
        public List<ComboBoxValue> DesignationLookup { get; set; } = new List<ComboBoxValue>();
        public Dictionary<int, int> AcquisitionOfficerLookup { get; set; }

        public Cache()
        {
        
        }

        public void Init(IUserStore iUserStore, IManagementUnitStore iManagementUnitStore, ILookupStore iLookupStore, IPageMessageBus iPageMessageBus)
        {
            UserDtos = iUserStore.GetUserDtosForCache();
            UserLookup = iUserStore.GetUserLookupForCache();
            UserRoleSmallDtos = iUserStore.GetUserRoleSmallDtos();
            RegionLookup = iLookupStore.GetRegionsForCache();
            DesignationLookup = iLookupStore.GetDesignationForCache();
            ManagementUnitDtos = iManagementUnitStore.GetManagementUnitDtosForCache();
            AcquisitionOfficerLookup = iManagementUnitStore.GetAcquisitionUnitOfficers();
            _iPageMessageBus = iPageMessageBus;
            _userStore = iUserStore;
            LocalSettings.Instance.Settings.Application=1;
        }

        public SettngsDto GetSettings()
        {
            return LocalSettings.Instance.Settings;
        }

        public void SetSettings(SettngsDto settngsDto)
        {
            LocalSettings.Instance.Settings = settngsDto;
        }

        public void SetApplication(int applicationId)
        {
            if (LocalSettings.Instance.Settings.Application != applicationId)
            {
                LocalSettings.Instance.Settings.Application = applicationId;

                _iPageMessageBus.Publish(new EdMessage
                {
                    EdEvent = EdEvent.ApplicationChanged,
                    Data = "Cache",
                    InstanceId = Guid.NewGuid()
                });
            }
        }

        public int GetApplication()
        {
            return LocalSettings.Instance.Settings.Application;
        }

        public int CurrentUser()
        {
            return _userStore.CurrentUserId();
        }

        public int CurrentUserRegion()
        {
            var userDto = UserDtos.FirstOrDefault(f => f.ID == _userStore.CurrentUserId());
 
            if (userDto != null)
                return userDto.RegionId;
            else
                return 0;
        }

        public List<UserRoleSmallDto> CurrentUserRole()
        {
            var userDto = UserDtos.FirstOrDefault(f => f.ID == _userStore.CurrentUserId());

            if (userDto != null)
            {
                var ursmd = UserRoleSmallDtos.Where(h => h.UserId == userDto.ID).ToList();

                if(ursmd.Count >0)
                    return ursmd;

                return new List<UserRoleSmallDto>(){ new UserRoleSmallDto()
                {
                    Id = 0,
                    RoleId = 2,
                    RegionId = 99,
                    UserId = userDto.ID
                }};
            }
            
            return new List<UserRoleSmallDto>(){ new UserRoleSmallDto()
            {
                Id = 0,
                RoleId = 2,
                RegionId = 99,
                UserId =  0
            }};
        }

        public int SetLoggedInUser(int userId)
        {
            _userStore.SetCurrentUser(userId);
            return 0;
        }

        public void SetManagementUnitId(int managementUnitId)
        {
            if(managementUnitId == LocalSettings.Instance.Settings.ManagementUnitId)
                LocalSettings.Instance.Settings.ManagementUnitId= 0;
            else
                LocalSettings.Instance.Settings.ManagementUnitId = managementUnitId;
        }

        public int GetManagementUnitId()
        {
            return LocalSettings.Instance.Settings.ManagementUnitId;
        }
    }
}

