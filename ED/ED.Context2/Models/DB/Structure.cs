using System;

namespace EDC_Estate.Models.DB
{
    public partial class Structure
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int? StructureTypeId { get; set; }
        public string Description { get; set; }
        public int? StructureConditionId { get; set; }
        public double? RebuildCost { get; set; }
        public bool Responsibility { get; set; }
        public string ResponsibilityDescr { get; set; }
        public double? AnnualMaintenanceCosts { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public DateTime? NextInspectionDate { get; set; }
        public string ReportAuthor { get; set; }
        public string BriefReportSummary { get; set; }
        public bool Completed { get; set; }
        public bool ExternalSurveyorRequired { get; set; }
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

        public virtual AcquisitionUnit AcquisitionUnit { get; set; }
        public virtual User Lmu { get; set; }
        public virtual StructureCondition StructureCondition { get; set; }
        public virtual StructureType StructureType { get; set; }
    }
}
