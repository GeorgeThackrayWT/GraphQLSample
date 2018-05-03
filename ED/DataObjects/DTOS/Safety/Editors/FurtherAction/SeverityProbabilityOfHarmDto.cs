namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class SeverityProbabilityOfHarmDto : IComboBoxValue
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
    }
}