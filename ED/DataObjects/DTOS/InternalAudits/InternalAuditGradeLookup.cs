namespace DataObjects.DTOS.InternalAudits
{
    public class InternalAuditGradeLookup : IComboBoxValue
    {
        public string Description { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}