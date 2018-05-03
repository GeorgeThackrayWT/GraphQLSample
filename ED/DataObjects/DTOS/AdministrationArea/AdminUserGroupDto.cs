using System.Collections.Generic;

namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminUserGroupDto
    {
        public int GroupID { get; set; }

        public string GroupDescription { get; set; }

        public List<AdminUserDto> UserDtos { get; set; }

    }
}