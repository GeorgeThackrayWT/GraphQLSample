using System;

namespace EDC_Estate.Models.DB
{
    public partial class Evaluation
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int EvaluationTypeId { get; set; }
        public int? TypeOfInformationId { get; set; }
        public string Author { get; set; }
        public bool? Confidential { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public string Location { get; set; }
        public string Detail { get; set; }
        public string SuppliedBy { get; set; }
        public double? Cost { get; set; }
        public bool HasDocument { get; set; }
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
        public virtual EvaluationType EvaluationType { get; set; }
        public virtual User Lmu { get; set; }
        public virtual TypeOfInformation TypeOfInformation { get; set; }
    }
}
