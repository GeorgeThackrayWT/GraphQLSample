namespace DataObjects
{
    public class HarvestListDTO
    {
        public string Name { get; set; }

        public int? RegionId { get; set; }

        public int? ApplicationId { get; set; }

        public int? WoodlandOfficerId { get; set; }

        public int ManagementUnitID { get; set; }
        public double HistoricAmount { get; set; }
        public int Year1 { get; set; }
        public double Year1Amount { get; set; }
        public int Year2 { get; set; }
        public double Year2Amount { get; set; }

        public int Year3 { get; set; }
        public double Year3Amount { get; set; }

        public int Year4 { get; set; }
        public double Year4Amount { get; set; }

        public int Year5 { get; set; }
        public double Year5Amount { get; set; }

        public bool AWR { get; set; }
    }
}