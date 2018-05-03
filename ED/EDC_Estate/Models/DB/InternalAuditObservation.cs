using System;

namespace EDC_Estate.Models.DB
{
    public partial class InternalAuditObservation
    {
        public int Id { get; set; }
        public int InternalAuditId { get; set; }
        public string UkwastrustProcedure { get; set; }
        public string Observation { get; set; }
        public string CorrectiveAction { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ActionById { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ClosingComments { get; set; }
        public int? GradeId { get; set; }
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

        public virtual User ActionBy { get; set; }
        public virtual InternalAuditGrade Grade { get; set; }
        public virtual InternalAudit InternalAudit { get; set; }
        public virtual User Lmu { get; set; }
    }
}
