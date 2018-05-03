using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class EvaluationType
    {
        public EvaluationType()
        {
            Evaluation = new HashSet<Evaluation>();
            TypeOfInformation = new HashSet<TypeOfInformation>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
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

        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<TypeOfInformation> TypeOfInformation { get; set; }
        public virtual User Lmu { get; set; }
    }
}
