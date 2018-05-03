using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors
{
    public class SupplierDto : BaseDto, IRecord
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Group { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string Town { get; set; }

        public string County { get; set; }



    }
}