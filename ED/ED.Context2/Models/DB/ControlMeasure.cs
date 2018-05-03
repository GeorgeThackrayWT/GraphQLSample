using System;

namespace EDC_Estate.Models.DB
{
    public partial class ControlMeasure
    {
        public int Id { get; set; }
        public int? RiskAssessmentId { get; set; }
        public int ControlMeasureTypeId { get; set; }
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

        public virtual ControlMeasureType ControlMeasureType { get; set; }
        public virtual User Lmu { get; set; }
        public virtual RiskAssessment RiskAssessment { get; set; }
    }
}
