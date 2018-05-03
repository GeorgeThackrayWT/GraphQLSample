using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DTOS
{
    public sealed class LocalSettings
    {
        public SettngsDto Settings { get; set; } = new SettngsDto();
        
        private LocalSettings()
        {

        }
        
        private static LocalSettings _instance = null;

        public static LocalSettings Instance => _instance ?? (_instance = new LocalSettings());
    }

    public class SettngsDto
    {
        public int Application { get; set; } = 99;

        public int LoggedInUser { get; set; }

        public int UserRoleGroup { get; set; }

        public int ManagementUnitId { get; set; }
    }
}
