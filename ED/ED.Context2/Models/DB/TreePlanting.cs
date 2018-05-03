using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class TreePlanting
    {

        public TreePlanting()
        {
            TreePlantingDetails = new HashSet<TreePlantingDetail>();
       
        }

        public int Id { get; set; }
        public int SubCompartmentId { get; set; }
        public DateTime? PlantingDate { get; set; }
        public bool Completed { get; set; }
        public int PlantingTypeId { get; set; }
        public int PlantedById { get; set; }
        public bool SuitableToBeSold { get; set; }
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

        public virtual ICollection<TreePlantingDetail> TreePlantingDetails { get; set; }


        public virtual User Lmu { get; set; }
        public virtual PlantedBy PlantedBy { get; set; }
        public virtual PlantingType PlantingType { get; set; }
        public virtual SubCompartment SubCompartment { get; set; }
        
    }
}
