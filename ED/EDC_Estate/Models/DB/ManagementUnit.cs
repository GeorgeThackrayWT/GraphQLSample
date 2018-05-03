using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class ManagementUnit
    {
        public ManagementUnit()
        {
            AcquisitionUnit = new HashSet<AcquisitionUnit>();
            Audit = new HashSet<Audit>();
            EmailTask = new HashSet<EmailTask>();
            Entity = new HashSet<Entity>();
            Expenditure = new HashSet<Expenditure>();
            ExpenditureProductSiteMap = new HashSet<ExpenditureProductSiteMap>();
            ExternalLink = new HashSet<ExternalLink>();
            Feature = new HashSet<Feature>();
            Harvesting = new HashSet<Harvesting>();
            Hazard = new HashSet<Hazard>();
            Income = new HashSet<Income>();
            IncomeProductSiteMap = new HashSet<IncomeProductSiteMap>();
            ManagementUnitAttribute = new HashSet<ManagementUnitAttribute>();
            ManagementUnitWorkOrderMap = new HashSet<ManagementUnitWorkOrderMap>();
            Pesticide = new HashSet<Pesticide>();
            PublicInfo = new HashSet<PublicInfo>();
            SeasonalActivity = new HashSet<SeasonalActivity>();
            SubCompartment = new HashSet<SubCompartment>();
            Task = new HashSet<Task>();
            VatrateLock = new HashSet<VatrateLock>();
        }

        public int Id { get; set; }
        public int NavisionId { get; set; }
        public int WoodlandOfficerId { get; set; }
        public int? PreviousOfficerId { get; set; }
        public int? DeputyId { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public string LocalNameDesc { get; set; }
        public int ApplicationId { get; set; }
        public int? DepartmentId { get; set; }
        public int SiteCategoryId { get; set; }
        public int? AdministrationAreaId { get; set; }
        public string AccessCategory { get; set; }
        public string EstateCategory { get; set; }
        public string NewEstateCategory { get; set; }
        public string InterimCategory { get; set; }
        public string Remarks { get; set; }
        public string AdditionalInformation { get; set; }
        public bool Vatrecoverable { get; set; }
        public bool ExcludeFromAccountsReporting { get; set; }
        public int? RiskAssessmentId { get; set; }
        public int? ManagementPlanId { get; set; }
        public int? RegionId { get; set; }
        public int? ParentManagementUnitId { get; set; }
        public int? PortfolioCategoryId { get; set; }
        public int? InterimPortfolioCategoryId { get; set; }
        public bool? ForecastApproved { get; set; }
        public string SummaryDescription { get; set; }
        public string PublishedSummaryDescription { get; set; }
        public string LongTermIntentions { get; set; }
        public string MicrositeUrl { get; set; }
        public string Aspect { get; set; }
        public double MinimumAltitude { get; set; }
        public double MaximumAltitude { get; set; }
        public int? WebsiteVisits { get; set; }
        public string GridReference { get; set; }
        public string MainAccessGridReference { get; set; }
        public string PublicAccessDescription { get; set; }
        public string ManagementAccessDescription { get; set; }
        public string DirectionsToMainEntrance { get; set; }
        public string BoundariesDescription { get; set; }
        public string HarvestingComments { get; set; }
        public string DeerCullPlan { get; set; }
        public string PostCode { get; set; }
        public string SpecialSiteFeatures { get; set; }
        public string SuitableForFilming { get; set; }
        public string AntisocialIssues { get; set; }
        public bool? NonStandardKey { get; set; }
        public bool IsPaws { get; set; }
        public bool IsPotSite { get; set; }
        public bool AllowPoso { get; set; }
        public bool Wcbudget { get; set; }
        public string AdministrationArea { get; set; }
        public bool Disposed { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public bool IsMainClumpedSite { get; set; }
        public int? ClumpedManagementUnitId { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }
        public string StandardKey { get; set; }
        public string ResNo { get; set; }

        public virtual ICollection<AcquisitionUnit> AcquisitionUnit { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<EmailTask> EmailTask { get; set; }
        public virtual ICollection<Entity> Entity { get; set; }
        public virtual ICollection<Expenditure> Expenditure { get; set; }
        public virtual ICollection<ExpenditureProductSiteMap> ExpenditureProductSiteMap { get; set; }
        public virtual ICollection<ExternalLink> ExternalLink { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<Harvesting> Harvesting { get; set; }
        public virtual ICollection<Hazard> Hazard { get; set; }
        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<IncomeProductSiteMap> IncomeProductSiteMap { get; set; }
        public virtual ICollection<ManagementUnitAttribute> ManagementUnitAttribute { get; set; }
        public virtual ManagementUnitGismo ManagementUnitGismo { get; set; }
        public virtual ICollection<ManagementUnitWorkOrderMap> ManagementUnitWorkOrderMap { get; set; }
        public virtual ICollection<Pesticide> Pesticide { get; set; }
        public virtual ICollection<PublicInfo> PublicInfo { get; set; }
        public virtual ICollection<SeasonalActivity> SeasonalActivity { get; set; }
        public virtual ICollection<SubCompartment> SubCompartment { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<VatrateLock> VatrateLock { get; set; }
        public virtual AdministrationArea AdministrationAreaNavigation { get; set; }
        public virtual Application Application { get; set; }
        public virtual ManagementUnit ClumpedManagementUnit { get; set; }
        public virtual ICollection<ManagementUnit> InverseClumpedManagementUnit { get; set; }
        public virtual Department Department { get; set; }
        public virtual User Deputy { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ManagementPlan ManagementPlan { get; set; }
        public virtual ManagementUnit ParentManagementUnit { get; set; }
        public virtual ICollection<ManagementUnit> InverseParentManagementUnit { get; set; }
        public virtual PortfolioCategory PortfolioCategory { get; set; }
        public virtual User PreviousOfficer { get; set; }
        public virtual Region Region { get; set; }
        public virtual RiskAssessment RiskAssessment { get; set; }
        public virtual SiteCategory SiteCategory { get; set; }
        public virtual User WoodlandOfficer { get; set; }
    }
}
