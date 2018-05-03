using DataObjects;

namespace EDCORE.ViewModel
{
    public class ApplicationDto : IComboBoxValue
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}