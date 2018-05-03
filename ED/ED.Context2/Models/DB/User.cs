using System;
using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class User
    {
        public User()
        {
            AccountWtactivityMap = new HashSet<AccountWtactivityMap>();
            AcquisitionType = new HashSet<AcquisitionType>();
            AcquisitionUnitAcquisitionOfficer = new HashSet<AcquisitionUnit>();
            AcquisitionUnitLmu = new HashSet<AcquisitionUnit>();
            AcquisitionUnitWoodlandOfficer = new HashSet<AcquisitionUnit>();
            AcquisitionUnitInternalAuditMap = new HashSet<AcquisitionUnitInternalAuditMap>();
            Acronym = new HashSet<Acronym>();
            AcronymType = new HashSet<AcronymType>();
            ActiveIngredient = new HashSet<ActiveIngredient>();
            AdministrationArea = new HashSet<AdministrationArea>();
            Aim = new HashSet<Aim>();
            Application = new HashSet<Application>();
            ApplicationMethod = new HashSet<ApplicationMethod>();
            ApplicationType = new HashSet<ApplicationType>();
            ApplicationUnit = new HashSet<ApplicationUnit>();
            Audit = new HashSet<Audit>();
            AuthorisationLevel = new HashSet<AuthorisationLevel>();
            AwardingScheme = new HashSet<AwardingScheme>();
            BiosecurityZone = new HashSet<BiosecurityZone>();
            BoundarySection = new HashSet<BoundarySection>();
            CategoryDescription = new HashSet<CategoryDescription>();
            CategoryTypes = new HashSet<CategoryTypes>();
            CommentsOnTerm = new HashSet<CommentsOnTerm>();
            ConservationFeature = new HashSet<ConservationFeature>();
            Contact = new HashSet<Contact>();
            ContactStatus = new HashSet<ContactStatus>();
            ControlMeasure = new HashSet<ControlMeasure>();
            ControlMeasureType = new HashSet<ControlMeasureType>();
            Country = new HashSet<Country>();
            County = new HashSet<County>();
            Customer = new HashSet<Customer>();
            Department = new HashSet<Department>();
            Designation = new HashSet<Designation>();
            DesignationType = new HashSet<DesignationType>();
            Designator = new HashSet<Designator>();
            DisposedInterest = new HashSet<DisposedInterest>();
            DocumentArea = new HashSet<DocumentArea>();
            DocumentBinary = new HashSet<DocumentBinary>();
            DocumentExtension = new HashSet<DocumentExtension>();
            DocumentName = new HashSet<DocumentName>();
            DocumentQueue = new HashSet<DocumentQueue>();
            DocumentStatus = new HashSet<DocumentStatus>();
            DocumentType = new HashSet<DocumentType>();
            DocuwareCabinet = new HashSet<DocuwareCabinet>();
            DocuwareConfiguration = new HashSet<DocuwareConfiguration>();
            DocuwareLoginType = new HashSet<DocuwareLoginType>();
            DrainageRate = new HashSet<DrainageRate>();
            EcologicalSubjectOrSpecies = new HashSet<EcologicalSubjectOrSpecies>();
            EcologicalSurveyType = new HashSet<EcologicalSurveyType>();
            EcologicalSurveyTypeSubjectOrSpeciesMap = new HashSet<EcologicalSurveyTypeSubjectOrSpeciesMap>();
            EmailTaskLmu = new HashSet<EmailTask>();
            EmailTaskSender = new HashSet<EmailTask>();
            Entity = new HashSet<Entity>();
            EntityType = new HashSet<EntityType>();
            EnvAssessmentSubCompartmentMap = new HashSet<EnvAssessmentSubCompartmentMap>();
            EnvironmentalAssessmentActionedBy = new HashSet<EnvironmentalAssessment>();
            EnvironmentalAssessmentLmu = new HashSet<EnvironmentalAssessment>();
            EnvironmentalAssessmentMitigation = new HashSet<EnvironmentalAssessmentMitigation>();
            EnvironmentalAssessmentMitigationAction = new HashSet<EnvironmentalAssessmentMitigationAction>();
            EnvironmentalAssessmentMitigationType = new HashSet<EnvironmentalAssessmentMitigationType>();
            EnvironmentalAssessmentNeeded = new HashSet<EnvironmentalAssessmentNeeded>();
            EnvironmentalAssessmentNeedToMitigate = new HashSet<EnvironmentalAssessmentNeedToMitigate>();
            EnvironmentalAssessmentType = new HashSet<EnvironmentalAssessmentType>();
            Epsmitigation = new HashSet<Epsmitigation>();
            EpsmitigationMeasure = new HashSet<EpsmitigationMeasure>();
            Evaluation = new HashSet<Evaluation>();
            EvaluationType = new HashSet<EvaluationType>();
            ExpenditureLmu = new HashSet<Expenditure>();
            ExpenditureUlmu = new HashSet<Expenditure>();
            ExpenditureGrownMethod = new HashSet<ExpenditureGrownMethod>();
            ExpenditureProduct = new HashSet<ExpenditureProduct>();
            ExpenditureProductSiteMap = new HashSet<ExpenditureProductSiteMap>();
            Farming = new HashSet<Farming>();
            Feature = new HashSet<Feature>();
            FeatureMonitoring = new HashSet<FeatureMonitoring>();
            FeatureType = new HashSet<FeatureType>();
            FireAssessment = new HashSet<FireAssessment>();
            FishingType = new HashSet<FishingType>();
            FollowOnActionType = new HashSet<FollowOnActionType>();
            Funding = new HashSet<Funding>();
            FundingStatus = new HashSet<FundingStatus>();
            FundingType = new HashSet<FundingType>();
            GlobalConfiguration = new HashSet<GlobalConfiguration>();
            GrantArchivedBy = new HashSet<Grant>();
            GrantAuthorisedBy = new HashSet<Grant>();
            GrantCompletedBy = new HashSet<Grant>();
            GrantLmu = new HashSet<Grant>();
            GrantBody = new HashSet<GrantBody>();
            Harvesting = new HashSet<Harvesting>();
            Hazard = new HashSet<Hazard>();
            HazardAction = new HashSet<HazardAction>();
            HazardCategory = new HashSet<HazardCategory>();
            HazardFireRiskCru = new HashSet<HazardFireRisk>();
            HazardFireRiskDlu = new HashSet<HazardFireRisk>();
            HazardFireRiskLmu = new HashSet<HazardFireRisk>();
            HazardFireRiskCategoryCru = new HashSet<HazardFireRiskCategory>();
            HazardFireRiskCategoryDlu = new HashSet<HazardFireRiskCategory>();
            HazardFireRiskCategoryLmu = new HashSet<HazardFireRiskCategory>();
            HazardFireRiskTypeCru = new HashSet<HazardFireRiskType>();
            HazardFireRiskTypeDlu = new HashSet<HazardFireRiskType>();
            HazardFireRiskTypeLmu = new HashSet<HazardFireRiskType>();
            HazardIncidentHistory = new HashSet<HazardIncidentHistory>();
            HazardLocation = new HashSet<HazardLocation>();
            HazardOwnershipCru = new HashSet<HazardOwnership>();
            HazardOwnershipDlu = new HashSet<HazardOwnership>();
            HazardOwnershipLmu = new HashSet<HazardOwnership>();
            HazardType = new HashSet<HazardType>();
            HelpCache = new HashSet<HelpCache>();
            HighwayAuthority = new HashSet<HighwayAuthority>();
            IncomeLmu = new HashSet<Income>();
            IncomeUlmu = new HashSet<Income>();
            IncomeProduct = new HashSet<IncomeProduct>();
            IncomeProductSiteMap = new HashSet<IncomeProductSiteMap>();
            InterestLet = new HashSet<InterestLet>();
            InternalAuditAuthorisedBy = new HashSet<InternalAudit>();
            InternalAuditCertifiedBy = new HashSet<InternalAudit>();
            InternalAuditFirstAuditorNavigation = new HashSet<InternalAudit>();
            InternalAuditLmu = new HashSet<InternalAudit>();
            InternalAuditPublishedBy = new HashSet<InternalAudit>();
            InternalAuditSecondAuditorNavigation = new HashSet<InternalAudit>();
            InternalAuditSiteManagerNavigation = new HashSet<InternalAudit>();
            InternalAuditGrade = new HashSet<InternalAuditGrade>();
            InternalAuditObservationActionBy = new HashSet<InternalAuditObservation>();
            InternalAuditObservationLmu = new HashSet<InternalAuditObservation>();
            InternalDesignation = new HashSet<InternalDesignation>();
            InternalDesignationType = new HashSet<InternalDesignationType>();
            LandRegistration = new HashSet<LandRegistration>();
            Licence = new HashSet<Licence>();
            LicenceAgreement = new HashSet<LicenceAgreement>();
            LicencePeriod = new HashSet<LicencePeriod>();
            LicenceType = new HashSet<LicenceType>();
            MajorManagementConstraint = new HashSet<MajorManagementConstraint>();
            MajorManagementConstraintType = new HashSet<MajorManagementConstraintType>();
            ManagementPlanApprovedBy = new HashSet<ManagementPlan>();
            ManagementPlanLmu = new HashSet<ManagementPlan>();
            ManagementRegime = new HashSet<ManagementRegime>();
            ManagementUnitDeputy = new HashSet<ManagementUnit>();
            ManagementUnitLmu = new HashSet<ManagementUnit>();
            ManagementUnitPreviousOfficer = new HashSet<ManagementUnit>();
            ManagementUnitWoodlandOfficer = new HashSet<ManagementUnit>();
            ManagementUnitGismo = new HashSet<ManagementUnitGismo>();
            ManagementUnitWorkOrderMap = new HashSet<ManagementUnitWorkOrderMap>();
            MapUrl = new HashSet<MapUrl>();
            MapUrlType = new HashSet<MapUrlType>();
            MobileChange = new HashSet<MobileChange>();
            NonFsctype = new HashSet<NonFsctype>();
            NoticeOfTermination = new HashSet<NoticeOfTermination>();
            Order = new HashSet<Order>();
            PartDisposal = new HashSet<PartDisposal>();
            Pesticide = new HashSet<Pesticide>();
            PesticideEntry = new HashSet<PesticideEntry>();
            PesticideProduct = new HashSet<PesticideProduct>();
            PlantedBy = new HashSet<PlantedBy>();
            PlantingAccessType = new HashSet<PlantingAccessType>();
            PlantingType = new HashSet<PlantingType>();
            PlantType = new HashSet<PlantType>();
            PortfolioCategory = new HashSet<PortfolioCategory>();
            ProductUnitType = new HashSet<ProductUnitType>();
            PropertyManagedBy = new HashSet<PropertyManagedBy>();
            ProvenanceZone = new HashSet<ProvenanceZone>();
            ProvisionsNotice = new HashSet<ProvisionsNotice>();
            PublicInfo = new HashSet<PublicInfo>();
            ReasonForUse = new HashSet<ReasonForUse>();
            Region = new HashSet<Region>();
            RentReview = new HashSet<RentReview>();
            ReportBinary = new HashSet<ReportBinary>();
            ReportQueue = new HashSet<ReportQueue>();
            RightsType = new HashSet<RightsType>();
            RiskAssessmentAuthorisedByRegionalManager = new HashSet<RiskAssessment>();
            RiskAssessmentCompletedByWoodlandOfficer = new HashSet<RiskAssessment>();
            RiskAssessmentLmu = new HashSet<RiskAssessment>();
            SeasonalActivity = new HashSet<SeasonalActivity>();
            SeverityProbabilityOfHarm = new HashSet<SeverityProbabilityOfHarm>();
            SiteCategory = new HashSet<SiteCategory>();
            SiteClassification = new HashSet<SiteClassification>();
            SizeIn = new HashSet<SizeIn>();
            Species = new HashSet<Species>();
            Structure = new HashSet<Structure>();
            StructureCondition = new HashSet<StructureCondition>();
            StructureType = new HashSet<StructureType>();
            SubCompartment = new HashSet<SubCompartment>();
            Supplier = new HashSet<Supplier>();
            TabletChange = new HashSet<TabletChange>();
            TabletError = new HashSet<TabletError>();
            TabletOrdersQueue = new HashSet<TabletOrdersQueue>();
            TargetSpecies = new HashSet<TargetSpecies>();
            Task = new HashSet<Task>();
            TaskCategory = new HashSet<TaskCategory>();
            TaxCode = new HashSet<TaxCode>();
            TenderLmu = new HashSet<Tender>();
            TenderReturnedToUserNavigation = new HashSet<Tender>();
            Tenure = new HashSet<Tenure>();
            TerrainType = new HashSet<TerrainType>();
            Theme = new HashSet<Theme>();
            ThirdPartyAgreement = new HashSet<ThirdPartyAgreement>();
            ThirdPartyRights = new HashSet<ThirdPartyRights>();
            ThirdPartyService = new HashSet<ThirdPartyService>();
            ThirdPartyType = new HashSet<ThirdPartyType>();
            TreePlanting = new HashSet<TreePlanting>();
            TreePlantingDetail = new HashSet<TreePlantingDetail>();
            TypeOfInformation = new HashSet<TypeOfInformation>();
            UserRole = new HashSet<UserRole>();
            VatrateLock = new HashSet<VatrateLock>();
            WayPublicRights = new HashSet<WayPublicRights>();
            WoodlandConditionDafor = new HashSet<WoodlandConditionDafor>();
            WoodlandConditionExtension = new HashSet<WoodlandConditionExtension>();
            WoodlandConditionStratum = new HashSet<WoodlandConditionStratum>();
            WoodlandConditionSubSection = new HashSet<WoodlandConditionSubSection>();
            WorkOrder = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string LoginName { get; set; }
        public string DisplayName { get; set; }
        public long? SecurityToken { get; set; }
        public int? RegionId { get; set; }
        public int? OfficeLocation { get; set; }
        public bool FirstRun { get; set; }
        public bool LoggedOn { get; set; }
        public string ComputerName { get; set; }
        public string Email { get; set; }
        public DateTime Lnrdt { get; set; }
        public int? AuthorisationLevelId { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int? Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual ICollection<AccountWtactivityMap> AccountWtactivityMap { get; set; }
        public virtual ICollection<AcquisitionType> AcquisitionType { get; set; }
        public virtual ICollection<AcquisitionUnit> AcquisitionUnitAcquisitionOfficer { get; set; }
        public virtual ICollection<AcquisitionUnit> AcquisitionUnitLmu { get; set; }
        public virtual ICollection<AcquisitionUnit> AcquisitionUnitWoodlandOfficer { get; set; }
        public virtual ICollection<AcquisitionUnitInternalAuditMap> AcquisitionUnitInternalAuditMap { get; set; }
        public virtual ICollection<Acronym> Acronym { get; set; }
        public virtual ICollection<AcronymType> AcronymType { get; set; }
        public virtual ICollection<ActiveIngredient> ActiveIngredient { get; set; }
        public virtual ICollection<AdministrationArea> AdministrationArea { get; set; }
        public virtual ICollection<Aim> Aim { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<ApplicationMethod> ApplicationMethod { get; set; }
        public virtual ICollection<ApplicationType> ApplicationType { get; set; }
        public virtual ICollection<ApplicationUnit> ApplicationUnit { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<AuthorisationLevel> AuthorisationLevel { get; set; }
        public virtual ICollection<AwardingScheme> AwardingScheme { get; set; }
        public virtual ICollection<BiosecurityZone> BiosecurityZone { get; set; }
        public virtual ICollection<BoundarySection> BoundarySection { get; set; }
        public virtual ICollection<CategoryDescription> CategoryDescription { get; set; }
        public virtual ICollection<CategoryTypes> CategoryTypes { get; set; }
        public virtual ICollection<CommentsOnTerm> CommentsOnTerm { get; set; }
        public virtual ICollection<ConservationFeature> ConservationFeature { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<ContactStatus> ContactStatus { get; set; }
        public virtual ICollection<ControlMeasure> ControlMeasure { get; set; }
        public virtual ICollection<ControlMeasureType> ControlMeasureType { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<County> County { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Designation> Designation { get; set; }
        public virtual ICollection<DesignationType> DesignationType { get; set; }
        public virtual ICollection<Designator> Designator { get; set; }
        public virtual ICollection<DisposedInterest> DisposedInterest { get; set; }
        public virtual ICollection<DocumentArea> DocumentArea { get; set; }
        public virtual ICollection<DocumentBinary> DocumentBinary { get; set; }
        public virtual ICollection<DocumentExtension> DocumentExtension { get; set; }
        public virtual ICollection<DocumentName> DocumentName { get; set; }
        public virtual ICollection<DocumentQueue> DocumentQueue { get; set; }
        public virtual ICollection<DocumentStatus> DocumentStatus { get; set; }
        public virtual ICollection<DocumentType> DocumentType { get; set; }
        public virtual ICollection<DocuwareCabinet> DocuwareCabinet { get; set; }
        public virtual ICollection<DocuwareConfiguration> DocuwareConfiguration { get; set; }
        public virtual ICollection<DocuwareLoginType> DocuwareLoginType { get; set; }
        public virtual ICollection<DrainageRate> DrainageRate { get; set; }
        public virtual ICollection<EcologicalSubjectOrSpecies> EcologicalSubjectOrSpecies { get; set; }
        public virtual ICollection<EcologicalSurveyType> EcologicalSurveyType { get; set; }
        public virtual ICollection<EcologicalSurveyTypeSubjectOrSpeciesMap> EcologicalSurveyTypeSubjectOrSpeciesMap { get; set; }
        public virtual ICollection<EmailTask> EmailTaskLmu { get; set; }
        public virtual ICollection<EmailTask> EmailTaskSender { get; set; }
        public virtual ICollection<Entity> Entity { get; set; }
        public virtual ICollection<EntityType> EntityType { get; set; }
        public virtual ICollection<EnvAssessmentSubCompartmentMap> EnvAssessmentSubCompartmentMap { get; set; }
        public virtual ICollection<EnvironmentalAssessment> EnvironmentalAssessmentActionedBy { get; set; }
        public virtual ICollection<EnvironmentalAssessment> EnvironmentalAssessmentLmu { get; set; }
        public virtual ICollection<EnvironmentalAssessmentMitigation> EnvironmentalAssessmentMitigation { get; set; }
        public virtual ICollection<EnvironmentalAssessmentMitigationAction> EnvironmentalAssessmentMitigationAction { get; set; }
        public virtual ICollection<EnvironmentalAssessmentMitigationType> EnvironmentalAssessmentMitigationType { get; set; }
        public virtual ICollection<EnvironmentalAssessmentNeeded> EnvironmentalAssessmentNeeded { get; set; }
        public virtual ICollection<EnvironmentalAssessmentNeedToMitigate> EnvironmentalAssessmentNeedToMitigate { get; set; }
        public virtual ICollection<EnvironmentalAssessmentType> EnvironmentalAssessmentType { get; set; }
        public virtual ICollection<Epsmitigation> Epsmitigation { get; set; }
        public virtual ICollection<EpsmitigationMeasure> EpsmitigationMeasure { get; set; }
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        public virtual ICollection<EvaluationType> EvaluationType { get; set; }
        public virtual ICollection<Expenditure> ExpenditureLmu { get; set; }
        public virtual ICollection<Expenditure> ExpenditureUlmu { get; set; }
        public virtual ICollection<ExpenditureGrownMethod> ExpenditureGrownMethod { get; set; }
        public virtual ICollection<ExpenditureProduct> ExpenditureProduct { get; set; }
        public virtual ICollection<ExpenditureProductSiteMap> ExpenditureProductSiteMap { get; set; }
        public virtual ICollection<Farming> Farming { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<FeatureMonitoring> FeatureMonitoring { get; set; }
        public virtual ICollection<FeatureType> FeatureType { get; set; }
        public virtual ICollection<FireAssessment> FireAssessment { get; set; }
        public virtual ICollection<FishingType> FishingType { get; set; }
        public virtual ICollection<FollowOnActionType> FollowOnActionType { get; set; }
        public virtual ICollection<Funding> Funding { get; set; }
        public virtual ICollection<FundingStatus> FundingStatus { get; set; }
        public virtual ICollection<FundingType> FundingType { get; set; }
        public virtual ICollection<GlobalConfiguration> GlobalConfiguration { get; set; }
        public virtual ICollection<Grant> GrantArchivedBy { get; set; }
        public virtual ICollection<Grant> GrantAuthorisedBy { get; set; }
        public virtual ICollection<Grant> GrantCompletedBy { get; set; }
        public virtual ICollection<Grant> GrantLmu { get; set; }
        public virtual ICollection<GrantBody> GrantBody { get; set; }
        public virtual ICollection<Harvesting> Harvesting { get; set; }
        public virtual ICollection<Hazard> Hazard { get; set; }
        public virtual ICollection<HazardAction> HazardAction { get; set; }
        public virtual ICollection<HazardCategory> HazardCategory { get; set; }
        public virtual ICollection<HazardFireRisk> HazardFireRiskCru { get; set; }
        public virtual ICollection<HazardFireRisk> HazardFireRiskDlu { get; set; }
        public virtual ICollection<HazardFireRisk> HazardFireRiskLmu { get; set; }
        public virtual ICollection<HazardFireRiskCategory> HazardFireRiskCategoryCru { get; set; }
        public virtual ICollection<HazardFireRiskCategory> HazardFireRiskCategoryDlu { get; set; }
        public virtual ICollection<HazardFireRiskCategory> HazardFireRiskCategoryLmu { get; set; }
        public virtual ICollection<HazardFireRiskType> HazardFireRiskTypeCru { get; set; }
        public virtual ICollection<HazardFireRiskType> HazardFireRiskTypeDlu { get; set; }
        public virtual ICollection<HazardFireRiskType> HazardFireRiskTypeLmu { get; set; }
        public virtual ICollection<HazardIncidentHistory> HazardIncidentHistory { get; set; }
        public virtual ICollection<HazardLocation> HazardLocation { get; set; }
        public virtual ICollection<HazardOwnership> HazardOwnershipCru { get; set; }
        public virtual ICollection<HazardOwnership> HazardOwnershipDlu { get; set; }
        public virtual ICollection<HazardOwnership> HazardOwnershipLmu { get; set; }
        public virtual ICollection<HazardType> HazardType { get; set; }
        public virtual ICollection<HelpCache> HelpCache { get; set; }
        public virtual ICollection<HighwayAuthority> HighwayAuthority { get; set; }
        public virtual ICollection<Income> IncomeLmu { get; set; }
        public virtual ICollection<Income> IncomeUlmu { get; set; }
        public virtual ICollection<IncomeProduct> IncomeProduct { get; set; }
        public virtual ICollection<IncomeProductSiteMap> IncomeProductSiteMap { get; set; }
        public virtual ICollection<InterestLet> InterestLet { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditAuthorisedBy { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditCertifiedBy { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditFirstAuditorNavigation { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditLmu { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditPublishedBy { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditSecondAuditorNavigation { get; set; }
        public virtual ICollection<InternalAudit> InternalAuditSiteManagerNavigation { get; set; }
        public virtual ICollection<InternalAuditGrade> InternalAuditGrade { get; set; }
        public virtual ICollection<InternalAuditObservation> InternalAuditObservationActionBy { get; set; }
        public virtual ICollection<InternalAuditObservation> InternalAuditObservationLmu { get; set; }
        public virtual ICollection<InternalDesignation> InternalDesignation { get; set; }
        public virtual ICollection<InternalDesignationType> InternalDesignationType { get; set; }
        public virtual ICollection<LandRegistration> LandRegistration { get; set; }
        public virtual ICollection<Licence> Licence { get; set; }
        public virtual ICollection<LicenceAgreement> LicenceAgreement { get; set; }
        public virtual ICollection<LicencePeriod> LicencePeriod { get; set; }
        public virtual ICollection<LicenceType> LicenceType { get; set; }
        public virtual ICollection<MajorManagementConstraint> MajorManagementConstraint { get; set; }
        public virtual ICollection<MajorManagementConstraintType> MajorManagementConstraintType { get; set; }
        public virtual ICollection<ManagementPlan> ManagementPlanApprovedBy { get; set; }
        public virtual ICollection<ManagementPlan> ManagementPlanLmu { get; set; }
        public virtual ICollection<ManagementRegime> ManagementRegime { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnitDeputy { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnitLmu { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnitPreviousOfficer { get; set; }
        public virtual ICollection<ManagementUnit> ManagementUnitWoodlandOfficer { get; set; }
        public virtual ICollection<ManagementUnitGismo> ManagementUnitGismo { get; set; }
        public virtual ICollection<ManagementUnitWorkOrderMap> ManagementUnitWorkOrderMap { get; set; }
        public virtual ICollection<MapUrl> MapUrl { get; set; }
        public virtual ICollection<MapUrlType> MapUrlType { get; set; }
        public virtual ICollection<MobileChange> MobileChange { get; set; }
        public virtual ICollection<NonFsctype> NonFsctype { get; set; }
        public virtual ICollection<NoticeOfTermination> NoticeOfTermination { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<PartDisposal> PartDisposal { get; set; }
        public virtual ICollection<Pesticide> Pesticide { get; set; }
        public virtual ICollection<PesticideEntry> PesticideEntry { get; set; }
        public virtual ICollection<PesticideProduct> PesticideProduct { get; set; }
        public virtual ICollection<PlantedBy> PlantedBy { get; set; }
        public virtual ICollection<PlantingAccessType> PlantingAccessType { get; set; }
        public virtual ICollection<PlantingType> PlantingType { get; set; }
        public virtual ICollection<PlantType> PlantType { get; set; }
        public virtual ICollection<PortfolioCategory> PortfolioCategory { get; set; }
        public virtual ICollection<ProductUnitType> ProductUnitType { get; set; }
        public virtual ICollection<PropertyManagedBy> PropertyManagedBy { get; set; }
        public virtual ICollection<ProvenanceZone> ProvenanceZone { get; set; }
        public virtual ICollection<ProvisionsNotice> ProvisionsNotice { get; set; }
        public virtual ICollection<PublicInfo> PublicInfo { get; set; }
        public virtual ICollection<ReasonForUse> ReasonForUse { get; set; }
        public virtual ICollection<Region> Region { get; set; }
        public virtual ICollection<RentReview> RentReview { get; set; }
        public virtual ICollection<ReportBinary> ReportBinary { get; set; }
        public virtual ICollection<ReportQueue> ReportQueue { get; set; }
        public virtual ICollection<RightsType> RightsType { get; set; }
        public virtual ICollection<RiskAssessment> RiskAssessmentAuthorisedByRegionalManager { get; set; }
        public virtual ICollection<RiskAssessment> RiskAssessmentCompletedByWoodlandOfficer { get; set; }
        public virtual ICollection<RiskAssessment> RiskAssessmentLmu { get; set; }
        public virtual ICollection<SeasonalActivity> SeasonalActivity { get; set; }
        public virtual ICollection<SeverityProbabilityOfHarm> SeverityProbabilityOfHarm { get; set; }
        public virtual ICollection<SiteCategory> SiteCategory { get; set; }
        public virtual ICollection<SiteClassification> SiteClassification { get; set; }
        public virtual ICollection<SizeIn> SizeIn { get; set; }
        public virtual ICollection<Species> Species { get; set; }
        public virtual ICollection<Structure> Structure { get; set; }
        public virtual ICollection<StructureCondition> StructureCondition { get; set; }
        public virtual ICollection<StructureType> StructureType { get; set; }
        public virtual ICollection<SubCompartment> SubCompartment { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<TabletChange> TabletChange { get; set; }
        public virtual ICollection<TabletError> TabletError { get; set; }
        public virtual ICollection<TabletOrdersQueue> TabletOrdersQueue { get; set; }
        public virtual ICollection<TargetSpecies> TargetSpecies { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<TaskCategory> TaskCategory { get; set; }
        public virtual ICollection<TaxCode> TaxCode { get; set; }
        public virtual ICollection<Tender> TenderLmu { get; set; }
        public virtual ICollection<Tender> TenderReturnedToUserNavigation { get; set; }
        public virtual ICollection<Tenure> Tenure { get; set; }
        public virtual ICollection<TerrainType> TerrainType { get; set; }
        public virtual ICollection<Theme> Theme { get; set; }
        public virtual ICollection<ThirdPartyAgreement> ThirdPartyAgreement { get; set; }
        public virtual ICollection<ThirdPartyRights> ThirdPartyRights { get; set; }
        public virtual ICollection<ThirdPartyService> ThirdPartyService { get; set; }
        public virtual ICollection<ThirdPartyType> ThirdPartyType { get; set; }
        public virtual ICollection<TreePlanting> TreePlanting { get; set; }
        public virtual ICollection<TreePlantingDetail> TreePlantingDetail { get; set; }
        public virtual ICollection<TypeOfInformation> TypeOfInformation { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<VatrateLock> VatrateLock { get; set; }
        public virtual ICollection<WayPublicRights> WayPublicRights { get; set; }
        public virtual ICollection<WoodlandConditionDafor> WoodlandConditionDafor { get; set; }
        public virtual ICollection<WoodlandConditionExtension> WoodlandConditionExtension { get; set; }
        public virtual ICollection<WoodlandConditionStratum> WoodlandConditionStratum { get; set; }
        public virtual ICollection<WoodlandConditionSubSection> WoodlandConditionSubSection { get; set; }
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
        public virtual AuthorisationLevel AuthorisationLevelNavigation { get; set; }
        public virtual User Lmu { get; set; }
        public virtual ICollection<User> InverseLmu { get; set; }
    }
}
