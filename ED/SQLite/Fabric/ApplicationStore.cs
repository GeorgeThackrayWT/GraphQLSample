using System.Collections.Generic;
using Abstractions;
using EDCORE.ViewModel;
using Stores;

namespace SQLite
{
    public class ApplicationStore : BaseStore, IApplicationStore
    {
     
        public List<ApplicationDto> GetApplications()
        {
            var items = new List<ApplicationDto>
            {
                new ApplicationDto() {ID = 99, Name = "All"},
                new ApplicationDto() {ID = 1, Name = "ED"},
                new ApplicationDto() {ID = 2, Name = "NED"}
            };
            return items;
        }
    }
}