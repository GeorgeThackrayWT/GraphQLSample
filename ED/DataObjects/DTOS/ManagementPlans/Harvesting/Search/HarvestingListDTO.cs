
namespace DataObjects
{
    public class HarvestingListDTO : SearchBase
    {
        public int? RegionId { get; set; }

        public int? WoodlandOfficerId { get; set; }

        public int Historic { get; set; }

        public int ProductionForecastNext0 { get; set; }

        public int ProductionForecastNext1 { get; set; }

        public int ProductionForecastNext2 { get; set; }

        public int ProductionForecastNext3 { get; set; }

        public int ProductionForecastNext4 { get; set; }

        public bool PAWS { get; set; }


    }
}