using System;

namespace EDC_Estate.Models.DB
{
    public partial class TreePlantingDetail
    {
        public int Id { get; set; }
        public int TreePlantingId { get; set; }
        public int TerrainTypeId { get; set; }
        public int AccessTypeId { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public double? PlantingArea { get; set; }
        public double PlantedArea { get; set; }
        public int? TreesToPlant { get; set; }
        public int TreesPlanted { get; set; }
        public int TreesAllocated { get; set; }
        public string Comments { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Lmu { get; set; }
        public virtual TreePlanting TreePlanting { get; set; }
        public virtual TerrainType TerrainType { get; set; }

        public virtual PlantingAccessType PlantingAccessType { get; set; }
    }
}
