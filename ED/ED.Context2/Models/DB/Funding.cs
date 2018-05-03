using System;

namespace EDC_Estate.Models.DB
{
    public partial class Funding
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int? TypeId { get; set; }
        public string DonorName { get; set; }
        public double? Amount { get; set; }
        public double? GiftAidOfferAmount { get; set; }
        public DateTime? OfferedDate { get; set; }
        public DateTime? ConditionsApprovedDate { get; set; }
        public DateTime? FundingConfirmedDate { get; set; }
        public DateTime? ClaimedDate { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
        public bool GrantConditionsExist { get; set; }
        public string GrantConditionsDescr { get; set; }
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
        public virtual FundingType Type { get; set; }
    }
}
