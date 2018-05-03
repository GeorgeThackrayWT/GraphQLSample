namespace DataObjects.DTOS.TreePlanting
{
    public class TreePlantingSearchDto : SearchBase
    {    
        public int ManagementUnitID { get; set; }

        public double WCAreaToPlant { get; set; }

        public double WCAreaPlanted { get; set; }

        public double WCAreaAvailable { get; set; }

        public int TreeNumbersPlanted { get; set; }

        public int TreeNumbersAvailable { get; set; }

        public bool PlantingComplete { get; set; }

        public bool SuitableToBeSold { get; set; }



    }
}
