using System;

namespace EDC_Estate.Models.DB
{
    public partial class Licence
    {
        public int Id { get; set; }
        public int AcquisitionUnitId { get; set; }
        public double? AreaInHectares { get; set; }
        public int? FishingSize { get; set; }
        public int? SizeInId { get; set; }
        public int? LicenceAgreementId { get; set; }
        public int? LicenceTypeId { get; set; }
        public int? FishingTypeId { get; set; }
        public int? InterestLetId { get; set; }
        public string TenantLicensee { get; set; }
        public string Address { get; set; }
        public DateTime? CommencementDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? NoticeOfTerminationId { get; set; }
        public int? CommentsOnTermId { get; set; }
        public bool AgentExists { get; set; }
        public string Agent { get; set; }
        public double? RentOrFee { get; set; }
        public int? LicencePeriodId { get; set; }
        public int? RentReviewId { get; set; }
        public string RentReviewCycle { get; set; }
        public DateTime? RentReviewDate { get; set; }
        public int? ProvisionsNoticeId { get; set; }
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
        public virtual CommentsOnTerm CommentsOnTerm { get; set; }
        public virtual FishingType FishingType { get; set; }
        public virtual InterestLet InterestLet { get; set; }
        public virtual LicenceAgreement LicenceAgreement { get; set; }
        public virtual LicencePeriod LicencePeriod { get; set; }
        public virtual LicenceType LicenceType { get; set; }
        public virtual User Lmu { get; set; }
        public virtual NoticeOfTermination NoticeOfTermination { get; set; }
        public virtual ProvisionsNotice ProvisionsNotice { get; set; }
        public virtual RentReview RentReview { get; set; }
        public virtual SizeIn SizeIn { get; set; }
    }
}
