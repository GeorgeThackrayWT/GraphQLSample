using System;

namespace EDC_Estate.Models.DB
{
    public partial class ThirdPartyRights
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public int? ServiceId { get; set; }
        public int? TypeId { get; set; }
        public int? AgreementId { get; set; }
        public string AgreementWith { get; set; }
        public DateTime? CurrentPaymentDate { get; set; }
        public double? CurrentAmount { get; set; }
        public DateTime? CurrentReceivedDate { get; set; }
        public DateTime? ForecastPaymentDate { get; set; }
        public double? ForecastAmount { get; set; }
        public DateTime? ForecastReceivedDate { get; set; }
        public DateTime? InitialEnquiryDate { get; set; }
        public DateTime? ResponseReceivedDate { get; set; }
        public DateTime? ResponseReceivedTargetDate { get; set; }
        public bool ResponseResult { get; set; }
        public DateTime? MtmapprovalDate { get; set; }
        public DateTime? MtmapprovalTargetDate { get; set; }
        public DateTime? SouthernElectricDate { get; set; }
        public DateTime? SouthernElectricTargetDate { get; set; }
        public DateTime? Wtdate { get; set; }
        public DateTime? WttargetDate { get; set; }
        public DateTime? AgreementFromDate { get; set; }
        public string Comments { get; set; }
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
        public virtual ThirdPartyAgreement Agreement { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ThirdPartyService Service { get; set; }
        public virtual ThirdPartyType Type { get; set; }
    }
}
