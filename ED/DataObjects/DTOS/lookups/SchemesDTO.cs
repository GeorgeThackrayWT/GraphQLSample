namespace DataObjects.DTOS.lookups
{
    public class SchemesDTO : IComboBoxValue
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}