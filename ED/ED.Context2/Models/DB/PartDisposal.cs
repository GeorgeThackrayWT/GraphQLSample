using System;

namespace EDC_Estate.Models.DB
{
    public partial class PartDisposal
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public DateTime? DisposalDate { get; set; }
        public int? DisposedInterestId { get; set; }
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public double? TotalReceivable { get; set; }
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
        public virtual DisposedInterest DisposedInterest { get; set; }
        public virtual User Lmu { get; set; }
    }
}
