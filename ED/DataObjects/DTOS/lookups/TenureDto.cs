using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class TenureDto : BaseDto, IRecord, IComboBoxValue
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}