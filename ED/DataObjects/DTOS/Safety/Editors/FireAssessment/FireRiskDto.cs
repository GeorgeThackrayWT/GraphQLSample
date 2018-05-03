namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class FireRiskDto
    {
        public int Id { get; set; }

        public int HazardId { get; set; }

        public int FireRiskTypeId { get; set; }

        public int RiskLevel { get; set; }

        public int CategoryId { get; set; }
    }
}