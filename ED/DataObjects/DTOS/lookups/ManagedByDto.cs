using DataObjects;

namespace EDCORE.ViewModel
{
    public class ManagedByDto : IComboBoxValue
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}