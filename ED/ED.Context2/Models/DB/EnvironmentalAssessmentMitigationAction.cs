using System;

namespace EDC_Estate.Models.DB
{
    public partial class EnvironmentalAssessmentMitigationAction
    {
        public int Id { get; set; }
        public int EnvAssessmentMitigationId { get; set; }
        public string Measure { get; set; }
        public string Comment { get; set; }
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

        public virtual EnvironmentalAssessmentMitigation EnvAssessmentMitigation { get; set; }
        public virtual User Lmu { get; set; }
    }
}
