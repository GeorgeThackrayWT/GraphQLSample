using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class AcquisitionUnit
    {
        public AcquisitionUnit()
        {
            AcquisitionUnitInternalAuditMap = new HashSet<AcquisitionUnitInternalAuditMap>();
            BoundarySection = new HashSet<BoundarySection>();
            Contact = new HashSet<Contact>();
            Designation = new HashSet<Designation>();
            DrainageRate = new HashSet<DrainageRate>();
            Evaluation = new HashSet<Evaluation>();
            Funding = new HashSet<Funding>();
            InternalDesignation = new HashSet<InternalDesignation>();
            LandRegistration = new HashSet<LandRegistration>();
            Licence = new HashSet<Licence>();
            PartDisposal = new HashSet<PartDisposal>();
            Pesticide = new HashSet<Pesticide>();
            Structure = new HashSet<Structure>();
            Task = new HashSet<Task>();
            ThirdPartyRightsNavigation = new HashSet<ThirdPartyRights>();
            WayPublicRights = new HashSet<WayPublicRights>();
        }

        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public int ParentAcquisitionUnitId { get; set; }
        public int WoodlandOfficerId { get; set; }
        public int? AcquisitionOfficerId { get; set; }
        public int? FarmingId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string GeneralLocation { get; set; }
        public int? AdministrationAreaId { get; set; }
        public DateTime? MtmdateApproved { get; set; }
        public DateTime? DateContractExchanged { get; set; }
        public DateTime? DateContractCompleted { get; set; }
        public DateTime? DateDisposed { get; set; }
        public DateTime? DateArchived { get; set; }
        public bool OwnedByWoodlandTrust { get; set; }
        public string Description { get; set; }
        public string SummaryDescription { get; set; }
        public string ManagementInformation { get; set; }
        public bool CompletionPending { get; set; }
        public string District { get; set; }
        public string Parish { get; set; }
        public string PublicAccessDescription { get; set; }
        public string ManagementAccessDescription { get; set; }
        public string BoundariesDescription { get; set; }
        public bool UpdateBoundaryDescription { get; set; }
        public DateTime? UpdateBoundaryDescriptionDate { get; set; }
        public string PublicRightsOfWayComments { get; set; }
        public string Aspect { get; set; }
        public string HarvestingComments { get; set; }
        public string DeerCullPlan { get; set; }
        public double Easting { get; set; }
        public double Northing { get; set; }
        public long DirectoryInformation { get; set; }
        public long? CombinedDirectoryInformation { get; set; }
        public int TypeId { get; set; }
        public bool GiftConditionsExist { get; set; }
        public string PublicAccessDescriptionLegal { get; set; }
        public string ManagementAccessDescriptionLegal { get; set; }
        public int? ShootingRightsId { get; set; }
        public string ShootingRightsDescription { get; set; }
        public int? MineralRightsId { get; set; }
        public string MineralRightsDescription { get; set; }
        public string BoundariesDescriptionLegal { get; set; }
        public bool? DrainageRatesExist { get; set; }
        public bool? HasPublicRightsOfWay { get; set; }
        public int? HighwayAuthorityId { get; set; }
        public DateTime? HighwaysActDate { get; set; }
        public DateTime? NextHighwaysActDate { get; set; }
        public DateTime? StatutoryDeclarationsDate { get; set; }
        public DateTime? NextStatutoryDeclarationsDate { get; set; }
        public bool AreDeedsSilent { get; set; }
        public DateTime? DateLeasedTo3rdParty { get; set; }
        public int? ThirdPartyLeaseTerm { get; set; }
        public bool ThirdPartyRights { get; set; }
        public string ThirdPartyRightsDescription { get; set; }
        public bool ServicesExist { get; set; }
        public string ServicesDescription { get; set; }
        public string MaffholdingNumber { get; set; }
        public bool RestrictiveCovenants { get; set; }
        public string RestrictiveCovenantsDescription { get; set; }
        public bool BeneficialCovenants { get; set; }
        public string BeneficialCovenantsDescription { get; set; }
        public bool Structures { get; set; }
        public string StructuresDescription { get; set; }
        public string AdditionalInformation { get; set; }
        public bool OtherRightsConveyed { get; set; }
        public string OtherRightsConveyedDescription { get; set; }
        public bool? PermissiveAccess { get; set; }
        public string PermissiveAccessDescription { get; set; }
        public string ContaminationDescription { get; set; }
        public string HazardsAndLiabilities { get; set; }
        public string FormerNames { get; set; }
        public double AreaInHectares { get; set; }
        public int? SellerDonorId { get; set; }
        public int? SellerDonorAgentId { get; set; }
        public int? SellerDonorSolicitorId { get; set; }
        public bool? HasPhotos { get; set; }
        public double? PreAcquisitionWoodAreaInHectares { get; set; }
        public double? PreAcquisitionLandAreaInHectares { get; set; }
        public double? PurchasePrice { get; set; }
        public string GridReference { get; set; }
        public string PostCode { get; set; }
        public string AdministrationArea { get; set; }
        public double? WoodAreaInHectares { get; set; }
        public double? GisareaInHectares { get; set; }
        public int? CountyId { get; set; }
        public bool? NonFsc { get; set; }
        public double? NonFscinHectares { get; set; }
        public string NonFsccomments { get; set; }
        public int? NonFsctypeId { get; set; }
        public DateTime? NonFscasOfDate { get; set; }
        public bool? T4a { get; set; }
        public bool? Woyd { get; set; }
        public bool? Trafalgar { get; set; }
        public bool? Dio { get; set; }
        public int? TenureId { get; set; }
        public int? LeaseTerm { get; set; }
        public DateTime? LeaseStartDate { get; set; }
        public DateTime? LeaseEndDate { get; set; }
        public double? Rent { get; set; }
        public string Lessor { get; set; }
        public string Lessee { get; set; }
        public string WtsolicitorsName { get; set; }
        public bool? Clt { get; set; }
        public int? Explorer { get; set; }
        public int? Landranger { get; set; }
        public int ManagedById { get; set; }
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

        public virtual ICollection<AcquisitionUnitInternalAuditMap> AcquisitionUnitInternalAuditMap { get; set; }
        public virtual ICollection<BoundarySection> BoundarySection { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<Designation> Designation { get; set; }
        public virtual ICollection<DrainageRate> DrainageRate { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<Funding> Funding { get; set; }
        public virtual ICollection<InternalDesignation> InternalDesignation { get; set; }
        public virtual ICollection<LandRegistration> LandRegistration { get; set; }
        public virtual ICollection<Licence> Licence { get; set; }
        public virtual ICollection<PartDisposal> PartDisposal { get; set; }
        public virtual ICollection<Pesticide> Pesticide { get; set; }
        public virtual ICollection<Structure> Structure { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<ThirdPartyRights> ThirdPartyRightsNavigation { get; set; }
        public virtual ICollection<WayPublicRights> WayPublicRights { get; set; }
        public virtual User AcquisitionOfficer { get; set; }
        public virtual AdministrationArea AdministrationAreaNavigation { get; set; }
        public virtual County County { get; set; }
        public virtual Farming Farming { get; set; }
        public virtual HighwayAuthority HighwayAuthority { get; set; }
        public virtual User Lmu { get; set; }
        public virtual PropertyManagedBy ManagedBy { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual RightsType MineralRights { get; set; }
        public virtual NonFsctype NonFsctype { get; set; }
        public virtual Contact SellerDonorAgent { get; set; }
        public virtual Contact SellerDonor { get; set; }
        public virtual Contact SellerDonorSolicitor { get; set; }
        public virtual RightsType ShootingRights { get; set; }
        public virtual Tenure Tenure { get; set; }
        public virtual AcquisitionType Type { get; set; }
        public virtual User WoodlandOfficer { get; set; }
    }
}
