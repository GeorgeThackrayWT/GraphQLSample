using System;

namespace DataObjects.DTOS.ManagementPlans.Editors
{

    public class BaseDto
    {

        public BaseDto()
        {
            Random rnd = new Random();

            Id = 0-rnd.Next(52);
        }

        public int Id { get; set; }

        public bool Deleted { get; set; }

        public DateTime LMDT { get; set; }

        public int? LMUID { get; set; }

        public DateTime? CRDT { get; set; }

        public int? CRUID { get; set; }

        public DateTime? DLDT { get; set; }

        public int? DLUID { get; set; }

        public DateTime? ULMDT { get; set; }
        public int? ULMUID { get; set; }

        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
    }
    
}
