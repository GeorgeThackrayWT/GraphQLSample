using System.Collections.Generic;
using Abstractions;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using EFStores;
 
namespace SQLite
{
    public class ApplicationEFStore : BaseEFStore, IApplicationStore
    {
        public ApplicationEFStore(EstateContext ec,ICache iCache) :
            base(ec, iCache)
        {
        }

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