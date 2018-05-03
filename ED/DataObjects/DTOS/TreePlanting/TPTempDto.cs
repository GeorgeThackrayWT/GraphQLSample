namespace DataObjects.DTOS.TreePlanting
{
    public class TPTempDto
    {
        public int ID { get; set; }

        public int ManagementUnitID { get; set; }

        public double PlantingArea { get; set; }

        public bool Completed { get; set; }

        public double TreesToPlant { get; set; }

        public double TreesPlanted { get; set; }

        public bool SuitableToBeSold { get; set; }

    }
}