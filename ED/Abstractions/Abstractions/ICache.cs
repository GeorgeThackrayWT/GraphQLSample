using System.Collections.Generic;
using System.Linq;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans;
using EDCORE.Helpers;
using EDCORE.ViewModel;

namespace Abstractions
{
    public interface ICache
    {
        void Init(IUserStore iUserStore, IManagementUnitStore iManagementUnitStore, ILookupStore iLookupStore, IPageMessageBus iPageMessageBus);

        ILookup<int, string> UserLookup { get; set; }

        ILookup<int, string> RegionLookup { get; set; }

        Dictionary<int, int> AcquisitionOfficerLookup { get; set; }

        List<ManagementUnitDto> ManagementUnitDtos { get; set; }

        List<UserDto> UserDtos { get; set; }

        List<ComboBoxValue> DesignationLookup { get; set; }

        List<UserRoleSmallDto> UserRoleSmallDtos { get; set; }

        SettngsDto GetSettings();

        void SetSettings(SettngsDto settngsDto);

        void SetApplication(int applicationId);

        void SetManagementUnitId(int managementUnitId);

        int GetManagementUnitId();

        int GetApplication();


        int CurrentUser();

        int CurrentUserRegion();

        List<UserRoleSmallDto> CurrentUserRole();


        int SetLoggedInUser(int userId);
    }


    
}