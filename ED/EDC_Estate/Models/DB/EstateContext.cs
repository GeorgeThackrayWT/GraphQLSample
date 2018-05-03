using Microsoft.EntityFrameworkCore;

namespace EDC_Estate.Models.DB
{
    public partial class EstateContext : DbContext
    {
        public virtual DbSet<AccountWtactivityMap> AccountWtactivityMap { get; set; }
        public virtual DbSet<AcquisitionType> AcquisitionType { get; set; }
        public virtual DbSet<AcquisitionUnit> AcquisitionUnit { get; set; }
        public virtual DbSet<AcquisitionUnitInternalAuditMap> AcquisitionUnitInternalAuditMap { get; set; }
        public virtual DbSet<AcquisitionUnitRow> AcquisitionUnitRow { get; set; }
        public virtual DbSet<Acronym> Acronym { get; set; }
        public virtual DbSet<AcronymType> AcronymType { get; set; }
        public virtual DbSet<ActiveIngredient> ActiveIngredient { get; set; }
        public virtual DbSet<AdministrationArea> AdministrationArea { get; set; }
        public virtual DbSet<Aim> Aim { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationMethod> ApplicationMethod { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<ApplicationUnit> ApplicationUnit { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AuthorisationLevel> AuthorisationLevel { get; set; }
        public virtual DbSet<AwardingScheme> AwardingScheme { get; set; }
        public virtual DbSet<BiosecurityZone> BiosecurityZone { get; set; }
        public virtual DbSet<BoundarySection> BoundarySection { get; set; }
        public virtual DbSet<CategoryDescription> CategoryDescription { get; set; }
        public virtual DbSet<CategoryTypes> CategoryTypes { get; set; }
        public virtual DbSet<CommentsOnTerm> CommentsOnTerm { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<ConservationFeature> ConservationFeature { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactStatus> ContactStatus { get; set; }
        public virtual DbSet<ControlMeasure> ControlMeasure { get; set; }
        public virtual DbSet<ControlMeasureType> ControlMeasureType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<DesignationType> DesignationType { get; set; }
        public virtual DbSet<Designator> Designator { get; set; }
        public virtual DbSet<DisposedInterest> DisposedInterest { get; set; }
        public virtual DbSet<DocumentArea> DocumentArea { get; set; }
        public virtual DbSet<DocumentBinary> DocumentBinary { get; set; }
        public virtual DbSet<DocumentExtension> DocumentExtension { get; set; }
        public virtual DbSet<DocumentName> DocumentName { get; set; }
        public virtual DbSet<DocumentQueue> DocumentQueue { get; set; }
        public virtual DbSet<DocumentStatus> DocumentStatus { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<DocuwareCabinet> DocuwareCabinet { get; set; }
        public virtual DbSet<DocuwareConfiguration> DocuwareConfiguration { get; set; }
        public virtual DbSet<DocuwareLoginType> DocuwareLoginType { get; set; }
        public virtual DbSet<DrainageRate> DrainageRate { get; set; }
        public virtual DbSet<EcologicalSubjectOrSpecies> EcologicalSubjectOrSpecies { get; set; }
        public virtual DbSet<EcologicalSurveyType> EcologicalSurveyType { get; set; }
        public virtual DbSet<EcologicalSurveyTypeSubjectOrSpeciesMap> EcologicalSurveyTypeSubjectOrSpeciesMap { get; set; }
        public virtual DbSet<EmailTask> EmailTask { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityType> EntityType { get; set; }
        public virtual DbSet<EnvAssessmentSubCompartmentMap> EnvAssessmentSubCompartmentMap { get; set; }
        public virtual DbSet<EnvironmentalAssessment> EnvironmentalAssessment { get; set; }
        public virtual DbSet<EnvironmentalAssessmentMitigation> EnvironmentalAssessmentMitigation { get; set; }
        public virtual DbSet<EnvironmentalAssessmentMitigationAction> EnvironmentalAssessmentMitigationAction { get; set; }
        public virtual DbSet<EnvironmentalAssessmentMitigationType> EnvironmentalAssessmentMitigationType { get; set; }
        public virtual DbSet<EnvironmentalAssessmentNeedToMitigate> EnvironmentalAssessmentNeedToMitigate { get; set; }
        public virtual DbSet<EnvironmentalAssessmentNeeded> EnvironmentalAssessmentNeeded { get; set; }
        public virtual DbSet<EnvironmentalAssessmentType> EnvironmentalAssessmentType { get; set; }
        public virtual DbSet<Epsmitigation> Epsmitigation { get; set; }
        public virtual DbSet<EpsmitigationMeasure> EpsmitigationMeasure { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<EvaluationType> EvaluationType { get; set; }
        public virtual DbSet<Expenditure> Expenditure { get; set; }
        public virtual DbSet<ExpenditureGrownMethod> ExpenditureGrownMethod { get; set; }
        public virtual DbSet<ExpenditureProduct> ExpenditureProduct { get; set; }
        public virtual DbSet<ExpenditureProductSiteMap> ExpenditureProductSiteMap { get; set; }
        public virtual DbSet<ExternalLink> ExternalLink { get; set; }
        public virtual DbSet<ExternalLinkType> ExternalLinkType { get; set; }
        public virtual DbSet<Farming> Farming { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FeatureMonitoring> FeatureMonitoring { get; set; }
        public virtual DbSet<FeatureType> FeatureType { get; set; }
        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<FireAssessment> FireAssessment { get; set; }
        public virtual DbSet<FishingType> FishingType { get; set; }
        public virtual DbSet<FollowOnActionType> FollowOnActionType { get; set; }
        public virtual DbSet<Funding> Funding { get; set; }
        public virtual DbSet<FundingStatus> FundingStatus { get; set; }
        public virtual DbSet<FundingType> FundingType { get; set; }
        public virtual DbSet<GlobalConfiguration> GlobalConfiguration { get; set; }
        public virtual DbSet<Grant> Grant { get; set; }
        public virtual DbSet<GrantBody> GrantBody { get; set; }
        public virtual DbSet<Harvesting> Harvesting { get; set; }
        public virtual DbSet<HarvestingOperationType> HarvestingOperationType { get; set; }
        public virtual DbSet<Hazard> Hazard { get; set; }
        public virtual DbSet<HazardAction> HazardAction { get; set; }
        public virtual DbSet<HazardCategory> HazardCategory { get; set; }
        public virtual DbSet<HazardFireRisk> HazardFireRisk { get; set; }
        public virtual DbSet<HazardFireRiskCategory> HazardFireRiskCategory { get; set; }
        public virtual DbSet<HazardFireRiskType> HazardFireRiskType { get; set; }
        public virtual DbSet<HazardIncidentHistory> HazardIncidentHistory { get; set; }
        public virtual DbSet<HazardLocation> HazardLocation { get; set; }
        public virtual DbSet<HazardOwnership> HazardOwnership { get; set; }
        public virtual DbSet<HazardType> HazardType { get; set; }
        public virtual DbSet<HelpCache> HelpCache { get; set; }
        public virtual DbSet<HighwayAuthority> HighwayAuthority { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<IncomeProduct> IncomeProduct { get; set; }
        public virtual DbSet<IncomeProductSiteMap> IncomeProductSiteMap { get; set; }
        public virtual DbSet<InterestLet> InterestLet { get; set; }
        public virtual DbSet<InternalAudit> InternalAudit { get; set; }
        public virtual DbSet<InternalAuditGrade> InternalAuditGrade { get; set; }
        public virtual DbSet<InternalAuditObservation> InternalAuditObservation { get; set; }
        public virtual DbSet<InternalAuditRow> InternalAuditRow { get; set; }
        public virtual DbSet<InternalDesignation> InternalDesignation { get; set; }
        public virtual DbSet<InternalDesignationType> InternalDesignationType { get; set; }
        public virtual DbSet<LandRegistration> LandRegistration { get; set; }
        public virtual DbSet<Licence> Licence { get; set; }
        public virtual DbSet<LicenceAgreement> LicenceAgreement { get; set; }
        public virtual DbSet<LicencePeriod> LicencePeriod { get; set; }
        public virtual DbSet<LicenceType> LicenceType { get; set; }
        public virtual DbSet<LookupTable> LookupTable { get; set; }
        public virtual DbSet<MajorManagementConstraint> MajorManagementConstraint { get; set; }
        public virtual DbSet<MajorManagementConstraintMap> MajorManagementConstraintMap { get; set; }
        public virtual DbSet<MajorManagementConstraintType> MajorManagementConstraintType { get; set; }
        public virtual DbSet<ManagementPlan> ManagementPlan { get; set; }
        public virtual DbSet<ManagementRegime> ManagementRegime { get; set; }
        public virtual DbSet<ManagementUnit> ManagementUnit { get; set; }
        public virtual DbSet<ManagementUnitAttribute> ManagementUnitAttribute { get; set; }
        public virtual DbSet<ManagementUnitGismo> ManagementUnitGismo { get; set; }
        public virtual DbSet<ManagementUnitRow> ManagementUnitRow { get; set; }
        public virtual DbSet<ManagementUnitWebSearch> ManagementUnitWebSearch { get; set; }
        public virtual DbSet<ManagementUnitWorkOrderMap> ManagementUnitWorkOrderMap { get; set; }
        public virtual DbSet<MapUrl> MapUrl { get; set; }
        public virtual DbSet<MapUrlType> MapUrlType { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MetadataField> MetadataField { get; set; }
        public virtual DbSet<MetadataFieldType> MetadataFieldType { get; set; }
        public virtual DbSet<MetadataRecord> MetadataRecord { get; set; }
        public virtual DbSet<MobileChange> MobileChange { get; set; }
        public virtual DbSet<NonFsctype> NonFsctype { get; set; }
        public virtual DbSet<NoticeOfTermination> NoticeOfTermination { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PartDisposal> PartDisposal { get; set; }
        public virtual DbSet<Pesticide> Pesticide { get; set; }
        public virtual DbSet<PesticideEntry> PesticideEntry { get; set; }
        public virtual DbSet<PesticideProduct> PesticideProduct { get; set; }
        public virtual DbSet<PlantType> PlantType { get; set; }
        public virtual DbSet<PlantedBy> PlantedBy { get; set; }
        public virtual DbSet<PlantingAccessType> PlantingAccessType { get; set; }
        public virtual DbSet<PlantingType> PlantingType { get; set; }
        public virtual DbSet<PortfolioCategory> PortfolioCategory { get; set; }
        public virtual DbSet<ProductUnitType> ProductUnitType { get; set; }
        public virtual DbSet<PropertyManagedBy> PropertyManagedBy { get; set; }
        public virtual DbSet<ProvenanceZone> ProvenanceZone { get; set; }
        public virtual DbSet<ProvisionsNotice> ProvisionsNotice { get; set; }
        public virtual DbSet<PublicInfo> PublicInfo { get; set; }
        public virtual DbSet<ReasonForUse> ReasonForUse { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RentReview> RentReview { get; set; }
        public virtual DbSet<ReportBinary> ReportBinary { get; set; }
        public virtual DbSet<ReportQueue> ReportQueue { get; set; }
        public virtual DbSet<RightsType> RightsType { get; set; }
        public virtual DbSet<RiskAssessment> RiskAssessment { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SeasonalActivity> SeasonalActivity { get; set; }
        public virtual DbSet<SeverityProbabilityOfHarm> SeverityProbabilityOfHarm { get; set; }
        public virtual DbSet<SiteCategory> SiteCategory { get; set; }
        public virtual DbSet<SiteClassification> SiteClassification { get; set; }
        public virtual DbSet<SizeIn> SizeIn { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Structure> Structure { get; set; }
        public virtual DbSet<StructureCondition> StructureCondition { get; set; }
        public virtual DbSet<StructureType> StructureType { get; set; }
        public virtual DbSet<SubCompartment> SubCompartment { get; set; }
        public virtual DbSet<SubCompartmentDesignationMap> SubCompartmentDesignationMap { get; set; }
        public virtual DbSet<SubCompartmentFeatureMap> SubCompartmentFeatureMap { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<TabletChange> TabletChange { get; set; }
        public virtual DbSet<TabletError> TabletError { get; set; }
        public virtual DbSet<TabletOrdersQueue> TabletOrdersQueue { get; set; }
        public virtual DbSet<TargetSpecies> TargetSpecies { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskCategory> TaskCategory { get; set; }
        public virtual DbSet<TaskRow> TaskRow { get; set; }
        public virtual DbSet<TaxCode> TaxCode { get; set; }
        public virtual DbSet<Tender> Tender { get; set; }
        public virtual DbSet<Tenure> Tenure { get; set; }
        public virtual DbSet<TerrainType> TerrainType { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<ThirdPartyAgreement> ThirdPartyAgreement { get; set; }
        public virtual DbSet<ThirdPartyRights> ThirdPartyRights { get; set; }
        public virtual DbSet<ThirdPartyService> ThirdPartyService { get; set; }
        public virtual DbSet<ThirdPartyType> ThirdPartyType { get; set; }
        public virtual DbSet<TreePlanting> TreePlanting { get; set; }
        public virtual DbSet<TreePlantingDetail> TreePlantingDetail { get; set; }
        public virtual DbSet<TypeOfInformation> TypeOfInformation { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<VatrateLock> VatrateLock { get; set; }
        public virtual DbSet<WayPublicRights> WayPublicRights { get; set; }
        public virtual DbSet<WoodlandConditionDafor> WoodlandConditionDafor { get; set; }
        public virtual DbSet<WoodlandConditionExtension> WoodlandConditionExtension { get; set; }
        public virtual DbSet<WoodlandConditionStratum> WoodlandConditionStratum { get; set; }
        public virtual DbSet<WoodlandConditionSubSection> WoodlandConditionSubSection { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }

        // Unable to generate entity type for table 'MAPINFO.MAPINFO_MAPCATALOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WTDepBoardSept2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WTNEDTreeStockUpdate20160920'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.aWCPOs2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WorkOrderClose'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



           //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-KGS70RI\SQL2016EX;Database=Estate; Trusted_Connection=True");
         //  optionsBuilder.UseSqlServer(@"Server=.\GTH;Database=Estate; Trusted_Connection=True");

        //    optionsBuilder.UseSqlServer(@"Server=tcp:VSQL14H01\SQL14H01,64706;Database=Estate_Zumero; Trusted_Connection=True");
 
     //      optionsBuilder.UseSqlServer(@"Server=DESKTOP-KGS70RI\SQL2016EX;Database=Estate; Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"Server=.\GTH;Database=Estate; Trusted_Connection=True");

           //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-KGS70RI\SQL2016EX;Database=Estate; Trusted_Connection=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountWtactivityMap>(entity =>
            {
                entity.ToTable("AccountWTActivityMap");

                entity.HasIndex(e => new { e.AccountCode, e.WtactivityCode })
                    .HasName("IX_AccountWTActivityMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Wtactivity)
                    .HasColumnName("WTActivity")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WtactivityCode).HasColumnName("WTActivityCode");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AccountWtactivityMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountWTActivityMap_User");
            });

            modelBuilder.Entity<AcquisitionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AcquisitionType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionTypeLMUID");
            });

            modelBuilder.Entity<AcquisitionUnit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionOfficerId)
                    .HasColumnName("AcquisitionOfficerID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AdministrationArea).HasColumnType("varchar(max)");

                entity.Property(e => e.AdministrationAreaId)
                    .HasColumnName("AdministrationAreaID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreDeedsSilent).HasDefaultValueSql("0");

                entity.Property(e => e.AreaInHectares).HasDefaultValueSql("0");

                entity.Property(e => e.Aspect)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BeneficialCovenants).HasDefaultValueSql("0");

                entity.Property(e => e.BeneficialCovenantsDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BoundariesDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BoundariesDescriptionLegal)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Clt).HasColumnName("CLT");

                entity.Property(e => e.CompletionPending).HasDefaultValueSql("0");

                entity.Property(e => e.ContaminationDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateContractCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateContractExchanged).HasColumnType("datetime");

                entity.Property(e => e.DateDisposed).HasColumnType("datetime");

                entity.Property(e => e.DateLeasedTo3rdParty).HasColumnType("datetime");

                entity.Property(e => e.DeerCullPlan)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dio).HasColumnName("DIO");

                entity.Property(e => e.DirectoryInformation).HasDefaultValueSql("0");

                entity.Property(e => e.District)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Easting).HasDefaultValueSql("0");

                entity.Property(e => e.FarmingId).HasColumnName("FarmingID");

                entity.Property(e => e.FormerNames).HasColumnType("varchar(max)");

                entity.Property(e => e.GeneralLocation)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GiftConditionsExist).HasDefaultValueSql("0");

                entity.Property(e => e.GisareaInHectares).HasColumnName("GISAreaInHectares");

                entity.Property(e => e.GridReference).HasColumnType("varchar(max)");

                entity.Property(e => e.HarvestingComments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HazardsAndLiabilities)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HighwayAuthorityId).HasColumnName("HighwayAuthorityID");

                entity.Property(e => e.HighwaysActDate).HasColumnType("datetime");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.LeaseEndDate).HasColumnType("datetime");

                entity.Property(e => e.LeaseStartDate).HasColumnType("datetime");

                entity.Property(e => e.Lessee).HasColumnType("varchar(max)");

                entity.Property(e => e.Lessor).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MaffholdingNumber)
                    .HasColumnName("MAFFHoldingNumber")
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagedById).HasColumnName("ManagedByID");

                entity.Property(e => e.ManagementAccessDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagementAccessDescriptionLegal)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagementInformation).HasColumnType("varchar(max)");

                entity.Property(e => e.ManagementUnitId)
                    .HasColumnName("ManagementUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MineralRightsDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MineralRightsId)
                    .HasColumnName("MineralRightsID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MtmdateApproved)
                    .HasColumnName("MTMDateApproved")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NextHighwaysActDate).HasColumnType("datetime");

                entity.Property(e => e.NextStatutoryDeclarationsDate).HasColumnType("datetime");

                entity.Property(e => e.NonFsc).HasColumnName("NonFSC");

                entity.Property(e => e.NonFscasOfDate)
                    .HasColumnName("NonFSCAsOfDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NonFsccomments)
                    .HasColumnName("NonFSCComments")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.NonFscinHectares).HasColumnName("NonFSCInHectares");

                entity.Property(e => e.NonFsctypeId).HasColumnName("NonFSCTypeID");

                entity.Property(e => e.Northing).HasDefaultValueSql("0");

                entity.Property(e => e.OtherRightsConveyed).HasDefaultValueSql("0");

                entity.Property(e => e.OtherRightsConveyedDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OwnedByWoodlandTrust).HasDefaultValueSql("1");

                entity.Property(e => e.ParentAcquisitionUnitId)
                    .HasColumnName("ParentAcquisitionUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Parish)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PermissiveAccessDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.PostCode).HasColumnType("varchar(max)");

                entity.Property(e => e.PreAcquisitionLandAreaInHectares).HasDefaultValueSql("0");

                entity.Property(e => e.PreAcquisitionWoodAreaInHectares).HasDefaultValueSql("0");

                entity.Property(e => e.PublicAccessDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublicAccessDescriptionLegal)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublicRightsOfWayComments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PurchasePrice).HasDefaultValueSql("0");

                entity.Property(e => e.RestrictiveCovenants).HasDefaultValueSql("0");

                entity.Property(e => e.RestrictiveCovenantsDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SellerDonorAgentId)
                    .HasColumnName("SellerDonorAgentID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellerDonorId)
                    .HasColumnName("SellerDonorID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SellerDonorSolicitorId)
                    .HasColumnName("SellerDonorSolicitorID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServicesDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ShootingRightsDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ShootingRightsId)
                    .HasColumnName("ShootingRightsID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatutoryDeclarationsDate).HasColumnType("datetime");

                entity.Property(e => e.Structures).HasDefaultValueSql("0");

                entity.Property(e => e.StructuresDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SummaryDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.T4a).HasColumnName("T4A");

                entity.Property(e => e.TenureId).HasColumnName("TenureID");

                entity.Property(e => e.ThirdPartyRights).HasDefaultValueSql("0");

                entity.Property(e => e.ThirdPartyRightsDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdateBoundaryDescription).HasDefaultValueSql("0");

                entity.Property(e => e.UpdateBoundaryDescriptionDate).HasColumnType("datetime");

                entity.Property(e => e.WoodlandOfficerId)
                    .HasColumnName("WoodlandOfficerID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Woyd).HasColumnName("WOYD");

                entity.Property(e => e.WtsolicitorsName)
                    .HasColumnName("WTSolicitorsName")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionOfficer)
                    .WithMany(p => p.AcquisitionUnitAcquisitionOfficer)
                    .HasForeignKey(d => d.AcquisitionOfficerId)
                    .HasConstraintName("FK_AcquisitionUnitAcquisitionOfficerID");

                entity.HasOne(d => d.AdministrationAreaNavigation)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.AdministrationAreaId)
                    .HasConstraintName("FK_AcquisitionUnitAdministrationAreaID");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.CountyId)
                    .HasConstraintName("FK_AcquisitionUnitCountyID");

                entity.HasOne(d => d.Farming)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.FarmingId)
                    .HasConstraintName("FK_AcquisitionUnitFarmingID");

                entity.HasOne(d => d.HighwayAuthority)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.HighwayAuthorityId)
                    .HasConstraintName("FK_AcquisitionUnitHighwayAuthorityID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AcquisitionUnitLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitLMUID");

                entity.HasOne(d => d.ManagedBy)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.ManagedById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitManagedByID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitManagementUnitID");

                entity.HasOne(d => d.MineralRights)
                    .WithMany(p => p.AcquisitionUnitMineralRights)
                    .HasForeignKey(d => d.MineralRightsId)
                    .HasConstraintName("FK_AcquisitionUnitMineralRightsID");

                entity.HasOne(d => d.NonFsctype)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.NonFsctypeId)
                    .HasConstraintName("FK_AcquisitionUnit_NonFSCType");

                entity.HasOne(d => d.SellerDonorAgent)
                    .WithMany(p => p.AcquisitionUnitSellerDonorAgent)
                    .HasForeignKey(d => d.SellerDonorAgentId)
                    .HasConstraintName("FK_AcquisitionUnitSellerDonorAgentID");

                entity.HasOne(d => d.SellerDonor)
                    .WithMany(p => p.AcquisitionUnitSellerDonor)
                    .HasForeignKey(d => d.SellerDonorId)
                    .HasConstraintName("FK_AcquisitionUnitSellerDonorID");

                entity.HasOne(d => d.SellerDonorSolicitor)
                    .WithMany(p => p.AcquisitionUnitSellerDonorSolicitor)
                    .HasForeignKey(d => d.SellerDonorSolicitorId)
                    .HasConstraintName("FK_AcquisitionUnitSellerDonorSolicitorID");

                entity.HasOne(d => d.ShootingRights)
                    .WithMany(p => p.AcquisitionUnitShootingRights)
                    .HasForeignKey(d => d.ShootingRightsId)
                    .HasConstraintName("FK_AcquisitionUnitShootingRightsID");

                entity.HasOne(d => d.Tenure)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.TenureId)
                    .HasConstraintName("FK_AcquisitionUnitTenureID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AcquisitionUnit)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitTypeID");

                entity.HasOne(d => d.WoodlandOfficer)
                    .WithMany(p => p.AcquisitionUnitWoodlandOfficer)
                    .HasForeignKey(d => d.WoodlandOfficerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitWoodlandOfficerID");
            });

            modelBuilder.Entity<AcquisitionUnitInternalAuditMap>(entity =>
            {
                entity.HasIndex(e => new { e.AcquisitionUnitId, e.InternalAuditId })
                    .HasName("IX_AcquisitionUnitInternalAuditMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.InternalAuditId).HasColumnName("InternalAuditID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.AcquisitionUnitInternalAuditMap)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitInternalAuditMap_AcquisitionUnit");

                entity.HasOne(d => d.InternalAudit)
                    .WithMany(p => p.AcquisitionUnitInternalAuditMap)
                    .HasForeignKey(d => d.InternalAuditId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcquisitionUnitInternalAuditMap_InternalAudit");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AcquisitionUnitInternalAuditMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<AcquisitionUnitRow>(entity =>
            {
                entity.HasKey(e => e.WoodId)
                    .HasName("PK_AcquisitionUnitRow");

                entity.Property(e => e.AcquisitionOfficer).HasColumnType("varchar(1)");

                entity.Property(e => e.AcquisitionOfficerId).HasColumnName("AcquisitionOfficerID");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WoodName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WoodlandOfficer)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.WoodlandOfficerId).HasColumnName("WoodlandOfficerID");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Caption).HasDefaultValueSql(" ");

                entity.Property(e => e.Destination).HasDefaultValueSql(" ");

            });

            modelBuilder.Entity<Acronym>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Acronym)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Acronym_User");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Acronym)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Acronym_AcronymType");
            });

            modelBuilder.Entity<AcronymType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AcronymType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcronymType_User");
            });

            modelBuilder.Entity<ActiveIngredient>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ActiveIngredient)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActiveIngredientLMUID");
            });

            modelBuilder.Entity<AdministrationArea>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BroadleafRegion)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionalDevelopmentRegion)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WoodlandOperationRegion)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AdministrationArea)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdministratonAreaLMUID");
            });

            modelBuilder.Entity<Aim>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.LongDescription).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Aim)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AimLMUID");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationLMUID");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationThemeID");
            });

            modelBuilder.Entity<ApplicationMethod>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ApplicationMethod)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationMethodLMUID");
            });

            modelBuilder.Entity<ApplicationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ApplicationType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationTypeLMUID");
            });

            modelBuilder.Entity<ApplicationUnit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ApplicationUnit)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationUnitLMUID");
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IconFileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsSpecial).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Mask).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Priority).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewValue).HasColumnType("varchar(max)");

                entity.Property(e => e.OldValue).HasColumnType("varchar(max)");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Audit)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AuditLMUID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Audit)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_AuditSiteID");
            });

            modelBuilder.Entity<AuthorisationLevel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ExpenditureLimit).HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AuthorisationLevel)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AuthorisationLevelLMUID");
            });

            modelBuilder.Entity<AwardingScheme>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.GrantBodyId).HasColumnName("GrantBodyID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.GrantBody)
                    .WithMany(p => p.AwardingScheme)
                    .HasForeignKey(d => d.GrantBodyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AwardingSchemeGrantBodyID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.AwardingScheme)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AwardingSchemeLMUID");
            });

            modelBuilder.Entity<BiosecurityZone>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.BiosecurityZone)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BiosecurityZoneLMUID");
            });

            modelBuilder.Entity<BoundarySection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId)
                    .HasColumnName("AcquisitionUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ownership).HasDefaultValueSql("0");

                entity.Property(e => e.Responsibility).HasDefaultValueSql("0");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.BoundarySection)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BoundarySectionAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.BoundarySection)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BoundarySectionLMUID");
            });

            modelBuilder.Entity<CategoryDescription>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryTypeId).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.CategoryDescription)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CategoryDescription_LMUser");
            });

            modelBuilder.Entity<CategoryTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.CategoryTypes)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CategoryTypes_LMUser");
            });

            modelBuilder.Entity<CommentsOnTerm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.CommentsOnTerm)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommentsOnTermLMUID");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwrresNo)
                    .HasColumnName("AWRResNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.BudgetLock).HasDefaultValueSql("1");

                entity.Property(e => e.ChalaraWorkOrderCode).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.CurrentYear)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DisablePo).HasColumnName("DisablePO");

                entity.Property(e => e.DisablePomessage)
                    .HasColumnName("DisablePOMessage")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.DisableSo).HasColumnName("DisableSO");

                entity.Property(e => e.DisableSomessage)
                    .HasColumnName("DisableSOMessage")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.LastAppliedAt).HasColumnType("datetime");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.NedresNo)
                    .HasColumnName("NEDResNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OrdersDropDirectory)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.PeresNo)
                    .HasColumnName("PEResNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.PurchaseFilename)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.PurchaseOrderMajorNumber).HasDefaultValueSql("499999");

                entity.Property(e => e.Q4dateRestrictionDate)
                    .HasColumnName("Q4DateRestrictionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportDropDirectory).HasColumnType("varchar(max)");

                entity.Property(e => e.ReportPath).HasColumnType("varchar(max)");

                entity.Property(e => e.ReportServer).HasColumnType("varchar(max)");

                entity.Property(e => e.SafetyTasksCutOffDate).HasColumnType("datetime");

                entity.Property(e => e.SalesFilename)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SalesOrderMajorNumber).HasDefaultValueSql("49999");

                entity.Property(e => e.TasksCutOffDate).HasColumnType("datetime");

                entity.Property(e => e.TreePlantingTasksCutOffDate).HasColumnType("datetime");

                entity.Property(e => e.VatguideUrl)
                    .HasColumnName("VATGuideURL")
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<ConservationFeature>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ConservationFeature)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ConservationFeature_LMUser");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Address).HasColumnType("varchar(max)");

                entity.Property(e => e.County).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EMail)
                    .HasColumnName("E-mail")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.Organisation).HasColumnType("varchar(max)");

                entity.Property(e => e.OtherStatus).HasColumnType("varchar(max)");

                entity.Property(e => e.Postcode).HasColumnType("varchar(max)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Telephone).HasColumnType("varchar(max)");

                entity.Property(e => e.Town).HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactLMUID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ContactContactStatusID");
            });

            modelBuilder.Entity<ContactStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ContactStatus)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContactStatusLMUID");
            });

            modelBuilder.Entity<ControlMeasure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControlMeasureTypeId)
                    .HasColumnName("ControlMeasureTypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RiskAssessmentId).HasColumnName("RiskAssessmentID");

                entity.HasOne(d => d.ControlMeasureType)
                    .WithMany(p => p.ControlMeasure)
                    .HasForeignKey(d => d.ControlMeasureTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ControlMeasureControlMeasureTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ControlMeasure)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ControlMeasureLMUID");

                entity.HasOne(d => d.RiskAssessment)
                    .WithMany(p => p.ControlMeasure)
                    .HasForeignKey(d => d.RiskAssessmentId)
                    .HasConstraintName("FK_ControlMeasureRiskAssessmentID");
            });

            modelBuilder.Entity<ControlMeasureType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ControlMeasureType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ControlMeasureTypeLMUID");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CountryLMUID");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.County)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CountyLMUID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("varchar(250)");

                entity.Property(e => e.AddressType).HasColumnType("varchar(250)");

                entity.Property(e => e.Assistant).HasColumnType("varchar(250)");

                entity.Property(e => e.Category).HasColumnType("varchar(250)");

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Code).HasColumnType("varchar(250)");

                entity.Property(e => e.County).HasColumnType("varchar(250)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Group).HasColumnType("varchar(250)");

                entity.Property(e => e.Home).HasColumnType("varchar(250)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LongCategory).HasColumnType("varchar(250)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(250)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Pager).HasColumnType("varchar(250)");

                entity.Property(e => e.PostalNo).HasColumnType("varchar(250)");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.Telefax).HasColumnType("varchar(250)");

                entity.Property(e => e.Telephone).HasColumnType("varchar(250)");

                entity.Property(e => e.Telex).HasColumnType("varchar(250)");

                entity.Property(e => e.To).HasColumnType("varchar(250)");

                entity.Property(e => e.Town).HasColumnType("varchar(250)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomerLMUID");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TaxCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomerTaxCodeID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("'000'");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DepartmentLMUID");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId)
                    .HasColumnName("AcquisitionUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AreaName)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DesignatorId)
                    .HasColumnName("DesignatorID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SiteDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Designation)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DesignationAcquisitionUnitID");

                entity.HasOne(d => d.Designator)
                    .WithMany(p => p.Designation)
                    .HasForeignKey(d => d.DesignatorId)
                    .HasConstraintName("FK_DesignationDesignatorID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Designation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DesignationLMUID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Designation)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DesignationTypeID");
            });

            modelBuilder.Entity<DesignationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IncludeInDirectory).HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.KeyDesignation).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DesignationType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DesignationTypeLMUID");
            });

            modelBuilder.Entity<Designator>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Designator)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DesignatorLMUID");
            });

            modelBuilder.Entity<DisposedInterest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DisposedInterest)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DisposedInterestLMUID");
            });

            modelBuilder.Entity<DocumentArea>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cabinet)
                    .WithMany(p => p.DocumentArea)
                    .HasForeignKey(d => d.CabinetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentArea_DocuwareCabinet");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentArea)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentArea_LMUser");
            });

            modelBuilder.Entity<DocumentBinary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Data).HasColumnType("image");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentBinary)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_DocumentBinary_User");
            });

            modelBuilder.Entity<DocumentExtension>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegEx).HasColumnType("varchar(max)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentExtension)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentExtension_LMUser");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DocumentExtension)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentExtension_DocumentType");
            });

            modelBuilder.Entity<DocumentName>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.DocumentName)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentName_Application");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DocumentName)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentName_DocumentArea");

                entity.HasOne(d => d.Cabinet)
                    .WithMany(p => p.DocumentName)
                    .HasForeignKey(d => d.CabinetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentName_DocuwareCabinet");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentName)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentName_LMUser");
            });

            modelBuilder.Entity<DocumentQueue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BinaryId).HasColumnName("BinaryID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.FileCabinetId).HasColumnName("FileCabinetID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Binary)
                    .WithMany(p => p.DocumentQueue)
                    .HasForeignKey(d => d.BinaryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentQueue_DocumentBinary");

                entity.HasOne(d => d.FileCabinet)
                    .WithMany(p => p.DocumentQueue)
                    .HasForeignKey(d => d.FileCabinetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentQueue_DocuwareCabinet");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentQueue)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_DocumentQueue_User");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DocumentQueue)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentQueue_DocumentStatus");
            });

            modelBuilder.Entity<DocumentStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentStatus)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentStatus_User");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cabinet)
                    .WithMany(p => p.DocumentType)
                    .HasForeignKey(d => d.CabinetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentType_DocuwareCabinet");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocumentType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocumentType_LMUser");
            });

            modelBuilder.Entity<DocuwareCabinet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FileCabinet).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ResultList).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocuwareCabinet)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocuwareCabinetLMUID");
            });

            modelBuilder.Entity<DocuwareConfiguration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CabinetId).HasColumnName("CabinetID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("0");

                entity.Property(e => e.HttpSecure).HasDefaultValueSql("0");

                entity.Property(e => e.IntegrationIdentifier).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoginKey).HasColumnType("varchar(max)");

                entity.Property(e => e.LoginToken).HasColumnType("varchar(max)");

                entity.Property(e => e.LoginTypeId).HasColumnName("LoginTypeID");

                entity.Property(e => e.Password).HasColumnType("varchar(max)");

                entity.Property(e => e.PathExtension)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TargetDirectory)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Username).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Cabinet)
                    .WithMany(p => p.DocuwareConfiguration)
                    .HasForeignKey(d => d.CabinetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocuwareConfigurationCabinetID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocuwareConfiguration)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocuwareConfigurationLMUID");

                entity.HasOne(d => d.LoginType)
                    .WithMany(p => p.DocuwareConfiguration)
                    .HasForeignKey(d => d.LoginTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocuwareConfigurationLoginTypeID");
            });

            modelBuilder.Entity<DocuwareLoginType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DocuwareLoginType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocuwareLoginTypeLMUID");
            });

            modelBuilder.Entity<DrainageRate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Body).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateDue).HasColumnType("datetime");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.DrainageRate)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DrainageRateAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.DrainageRate)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DrainageRateLMUID");
            });

            modelBuilder.Entity<EcologicalSubjectOrSpecies>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EcologicalSubjectOrSpecies)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EcologicalSubjectOrSpecies_User");
            });

            modelBuilder.Entity<EcologicalSurveyType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EcologicalSurveyType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EcologicalSurveyType_User");
            });

            modelBuilder.Entity<EcologicalSurveyTypeSubjectOrSpeciesMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubjectOrSpeciesId).HasColumnName("SubjectOrSpeciesID");

                entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EcologicalSurveyTypeSubjectOrSpeciesMap)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_EcologicalSurveyTypeSubjectOrSpeciesMap_User");

                entity.HasOne(d => d.SubjectOrSpecies)
                    .WithMany(p => p.EcologicalSurveyTypeSubjectOrSpeciesMap)
                    .HasForeignKey(d => d.SubjectOrSpeciesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EcologicalSurveyTypeSubjectOrSpeciesMap_EcologicalSubjectOrSpecies");

                entity.HasOne(d => d.SurveyType)
                    .WithMany(p => p.EcologicalSurveyTypeSubjectOrSpeciesMap)
                    .HasForeignKey(d => d.SurveyTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EcologicalSurveyTypeSubjectOrSpeciesMap_EcologicalSurveyType");
            });

            modelBuilder.Entity<EmailTask>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionCompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ActionDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.Bcc).HasColumnType("varchar(max)");

                entity.Property(e => e.Cc).HasColumnType("varchar(max)");

                entity.Property(e => e.ClosingComments).HasColumnType("varchar(max)");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.From).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestComments).HasColumnType("varchar(max)");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasColumnType("varchar(max)");

                entity.Property(e => e.SuggestionsOrActions).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EmailTaskLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmailTask_User");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.EmailTask)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmailTask_ManagementUnit");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.EmailTaskSender)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_EmailTask_Sender");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.HasOne(d => d.EntityType)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.EntityTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EntityEntityTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EntityLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EntityManagementUnitID");
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.TypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EntityType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EntityTypeLMUID");
            });

            modelBuilder.Entity<EnvAssessmentSubCompartmentMap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EnvAssessmentId).HasColumnName("EnvAssessmentID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubCompartmentId).HasColumnName("SubCompartmentID");

                entity.HasOne(d => d.EnvAssessment)
                    .WithMany(p => p.EnvAssessmentSubCompartmentMap)
                    .HasForeignKey(d => d.EnvAssessmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvAssessmentSubCompartmentMap_EnvironmentalAssessment");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvAssessmentSubCompartmentMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvAssessmentSubCompartmentMap_LMUser");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.EnvAssessmentSubCompartmentMap)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvAssessmentSubCompartmentMap_SubCompartment");
            });

            modelBuilder.Entity<EnvironmentalAssessment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionedById).HasColumnName("ActionedByID");

                entity.Property(e => e.BurningJustificationForBurning).HasColumnType("varchar(max)");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EngineeringFillMaterial).HasColumnType("varchar(max)");

                entity.Property(e => e.EngineeringImpactDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PesticideApplicationMethodId).HasColumnName("PesticideApplicationMethodID");

                entity.Property(e => e.PesticideChemicalUsed).HasColumnType("varchar(max)");

                entity.Property(e => e.PesticideTargetSpeciesId).HasColumnName("PesticideTargetSpeciesID");

                entity.Property(e => e.PesticideWhyChemicalControlNeeded).HasColumnType("varchar(max)");

                entity.Property(e => e.PreviousIncidentsOfDamage).HasColumnType("varchar(max)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WorkProgrammeId).HasColumnName("WorkProgrammeID");

                entity.HasOne(d => d.ActionedBy)
                    .WithMany(p => p.EnvironmentalAssessmentActionedBy)
                    .HasForeignKey(d => d.ActionedById)
                    .HasConstraintName("FK_EnvironmentalAssessment_ActionedByUser");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessment_LMUser");

                entity.HasOne(d => d.PesticideApplicationMethod)
                    .WithMany(p => p.EnvironmentalAssessment)
                    .HasForeignKey(d => d.PesticideApplicationMethodId)
                    .HasConstraintName("FK_EnvironmentalAssessment_ApplicationMethod");

                entity.HasOne(d => d.PesticideTargetSpecies)
                    .WithMany(p => p.EnvironmentalAssessment)
                    .HasForeignKey(d => d.PesticideTargetSpeciesId)
                    .HasConstraintName("FK_EnvironmentalAssessment_TargetSpecies");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.EnvironmentalAssessment)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessment_EnvironmentalAssessmentType");

                //entity.HasOne(d => d.WorkProgramme)
                //    .WithMany(p => p.EnvironmentalAssessment)
                //    .HasForeignKey(d => d.WorkProgrammeId)
                //    .OnDelete(DeleteBehavior.Restrict)
                //    .HasConstraintName("FK_EnvironmentalAssessment_Expenditure");
            });

            modelBuilder.Entity<EnvironmentalAssessmentMitigation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BurningId).HasColumnName("BurningID");

                entity.Property(e => e.ConservationFeatureId).HasColumnName("ConservationFeatureID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EnvironmentalAssessmentId).HasColumnName("EnvironmentalAssessmentID");

                entity.Property(e => e.ExplainationIfNo).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineryId).HasColumnName("MachineryID");

                entity.Property(e => e.MajorManagementConstraintId).HasColumnName("MajorManagementConstraintID");

                entity.Property(e => e.NeedToMitigateId).HasColumnName("NeedToMitigateID");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PesticideUseId).HasColumnName("PesticideUseID");

                entity.Property(e => e.ProtectedSpeciesId).HasColumnName("ProtectedSpeciesID");

                entity.Property(e => e.RecordTypeId).HasColumnName("RecordTypeID");

                entity.Property(e => e.SubCompartmentId).HasColumnName("SubCompartmentID");

                entity.Property(e => e.TreeSafetyWorkId).HasColumnName("TreeSafetyWorkID");

                entity.HasOne(d => d.ConservationFeature)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.ConservationFeatureId)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_ConservationFeature");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_Designation");

                entity.HasOne(d => d.EnvironmentalAssessment)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.EnvironmentalAssessmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_EnvironmentalAssessment");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_LMUser");

                entity.HasOne(d => d.MajorManagementConstraint)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.MajorManagementConstraintId)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_MajorManagementConstraint");

                entity.HasOne(d => d.NeedToMitigate)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.NeedToMitigateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_EnvironmentalAssessmentNeedToMitigate");

                entity.HasOne(d => d.RecordType)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.RecordTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_EnvironmentalAssessmentMitigationType");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.EnvironmentalAssessmentMitigation)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigation_SubCompartment");
            });

            modelBuilder.Entity<EnvironmentalAssessmentMitigationAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EnvAssessmentMitigationId).HasColumnName("EnvAssessmentMitigationID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Measure).HasColumnType("varchar(max)");

                entity.HasOne(d => d.EnvAssessmentMitigation)
                    .WithMany(p => p.EnvironmentalAssessmentMitigationAction)
                    .HasForeignKey(d => d.EnvAssessmentMitigationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigationAction_EnvironmentalAssessmentMitigation");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentMitigationAction)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigationAction_LMUser");
            });

            modelBuilder.Entity<EnvironmentalAssessmentMitigationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentMitigationType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentMitigationType_LMUser");
            });

            modelBuilder.Entity<EnvironmentalAssessmentNeedToMitigate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentNeedToMitigate)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentNeedToMitigate_LMUser");
            });

            modelBuilder.Entity<EnvironmentalAssessmentNeeded>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentNeeded)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentNeeded_LMUser");
            });

            modelBuilder.Entity<EnvironmentalAssessmentType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EnvironmentalAssessmentType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EnvironmentalAssessmentType_LMUser");
            });

            modelBuilder.Entity<Epsmitigation>(entity =>
            {
                entity.ToTable("EPSMitigation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecordTypeId).HasColumnName("RecordTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Epsmitigation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EPSMitigation_LMUser");

                entity.HasOne(d => d.RecordType)
                    .WithMany(p => p.Epsmitigation)
                    .HasForeignKey(d => d.RecordTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EPSMitigation_EnvironmentalAssessmentMitigationType");
            });

            modelBuilder.Entity<EpsmitigationMeasure>(entity =>
            {
                entity.ToTable("EPSMitigationMeasure");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EpsmitigationId).HasColumnName("EPSMitigationID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OverwriteId).HasColumnName("OverwriteID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.EpsmitigationMeasure)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_EPSMitigationMeasure_Country");

                entity.HasOne(d => d.Epsmitigation)
                    .WithMany(p => p.EpsmitigationMeasure)
                    .HasForeignKey(d => d.EpsmitigationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EPSMitigationMeasure_EPSMitigation");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EpsmitigationMeasure)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EPSMitigationMeasure_LMUser");
            });

            modelBuilder.Entity<Evaluation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId)
                    .HasColumnName("AcquisitionUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Author)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateOfRecord)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Detail)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EvaluationTypeId)
                    .HasColumnName("EvaluationTypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SuppliedBy)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TypeOfInformationId)
                    .HasColumnName("TypeOfInformationID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EvaluationAcquisitionUnitID");

                entity.HasOne(d => d.EvaluationType)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.EvaluationTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EvaluationEvaluationTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EvaluationLMUID");

                entity.HasOne(d => d.TypeOfInformation)
                    .WithMany(p => p.Evaluation)
                    .HasForeignKey(d => d.TypeOfInformationId)
                    .HasConstraintName("FK_EvaluationTypeOfInformationID");
            });

            modelBuilder.Entity<EvaluationType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.EvaluationType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EvaluationTypeLMUID");
            });

            modelBuilder.Entity<Expenditure>(entity =>
            {
                entity.HasIndex(e => new { e.ManagementUnitId, e.Deleted })
                    .HasName("IX_ManagementUnitID_Deleted");

                entity.HasIndex(e => new { e.Actual, e.Budget, e.Completed, e.ManagementUnitId, e.Ordered, e.Pe, e.PesticideRecord, e.Project, e.TaxCodeId, e.Wsp, e.Emc, e.EndDate, e.Forecast, e.FundingStatusId, e.Cancelled, e.Deleted })
                    .HasName("Expenditure_IX_PerfOpt01");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingYear).HasDefaultValueSql("0");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.AimId).HasColumnName("AimID");

                entity.Property(e => e.Budget).HasDefaultValueSql("0.0");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("0");

                entity.Property(e => e.Chalara).HasDefaultValueSql("0");

                entity.Property(e => e.Completed).HasDefaultValueSql("0");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.CptNo).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Dtp)
                    .HasColumnName("DTP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EcoAuthorOfOutput).HasColumnType("varchar(max)");

                entity.Property(e => e.EcoOtherDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.EcoSubjectOrSpeciesId).HasColumnName("EcoSubjectOrSpeciesID");

                entity.Property(e => e.EcoSurveyTypeId).HasColumnName("EcoSurveyTypeID");

                entity.Property(e => e.EcoSurveyUploadedToDw).HasColumnName("EcoSurveyUploadedToDW");

                entity.Property(e => e.Emc)
                    .HasColumnName("EMC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Emcspec)
                    .HasColumnName("EMCSpec")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FundingStatusId).HasColumnName("FundingStatusID");

                entity.Property(e => e.Grn).HasColumnName("GRN");

                entity.Property(e => e.GrownMethodId).HasColumnName("GrownMethodID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Kind).HasColumnType("varchar(2)");

                entity.Property(e => e.LastMonthForecast).HasDefaultValueSql("0.0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.NoSync).HasDefaultValueSql("0");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.OpsGrantAided).HasDefaultValueSql("0");

                entity.Property(e => e.Pe)
                    .HasColumnName("PE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PesticideRecord).HasDefaultValueSql("0");

                entity.Property(e => e.Pipeline).HasDefaultValueSql("0");

                entity.Property(e => e.PlantTypeId).HasColumnName("PlantTypeID");

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pono)
                    .HasColumnName("PONo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Project).HasDefaultValueSql("0");

                entity.Property(e => e.ProvenanceZoneId).HasColumnName("ProvenanceZoneID");

                entity.Property(e => e.Rpi)
                    .HasColumnName("RPI")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SizeCm).HasColumnName("Size_cm");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.TenderId).HasColumnName("TenderID");

                entity.Property(e => e.TreeSupplierId).HasColumnName("TreeSupplierID");

                entity.Property(e => e.Ulmdt)
                    .HasColumnName("ULMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ulmuid).HasColumnName("ULMUID");

                entity.Property(e => e.VolunteerWork).HasDefaultValueSql("0");

                entity.Property(e => e.WcexpenditureId).HasColumnName("WCExpenditureID");

                entity.Property(e => e.WoodProduction).HasDefaultValueSql("0");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.Property(e => e.Wsp)
                    .HasColumnName("WSP")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Aim)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.AimId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureAimID");

                entity.HasOne(d => d.EcoSubjectOrSpecies)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.EcoSubjectOrSpeciesId)
                    .HasConstraintName("FK_Expenditure_EcologicalSubjectOrSpecies");

                entity.HasOne(d => d.EcoSurveyType)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.EcoSurveyTypeId)
                    .HasConstraintName("FK_Expenditure_EcologicalSurveyType");

                entity.HasOne(d => d.FundingStatus)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.FundingStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureFundingStatusID");

                entity.HasOne(d => d.GrownMethod)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.GrownMethodId)
                    .HasConstraintName("FK_Expenditure_ExpenditureGrownMethod");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ExpenditureLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureManagementUnitID");

                entity.HasOne(d => d.PlantType)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.PlantTypeId)
                    .HasConstraintName("FK_Expenditure_PlantType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductID");

                entity.HasOne(d => d.ProvenanceZone)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.ProvenanceZoneId)
                    .HasConstraintName("FK_Expenditure_ProvenanceZone");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_ExpenditureTaxCodeID");

                entity.HasOne(d => d.Tender)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.TenderId)
                    .HasConstraintName("FK_ExpenditureTenderID");

                entity.HasOne(d => d.TreeSupplier)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.TreeSupplierId)
                    .HasConstraintName("FK_Expenditure_TreeSupplier");

                entity.HasOne(d => d.Ulmu)
                    .WithMany(p => p.ExpenditureUlmu)
                    .HasForeignKey(d => d.Ulmuid)
                    .HasConstraintName("FK_ExpenditureULMUID");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Expenditure)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureWorkOrderID");
            });

            modelBuilder.Entity<ExpenditureGrownMethod>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ExpenditureGrownMethod)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureGrownMethod_User");
            });

            modelBuilder.Entity<ExpenditureProduct>(entity =>
            {
                entity.HasIndex(e => new { e.Code, e.ApplicationId })
                    .HasName("IX_ExpenditureProductCode")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(max)");

                entity.Property(e => e.AimId).HasColumnName("AimID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

            //    entity.Property(e => e.EnvAssessmentNeededId).HasColumnName("EnvAssessmentNeededID");

                entity.Property(e => e.IsWoodProduction).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.Wtactivity)
                    .HasColumnName("WTActivity")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WtactivityCode).HasColumnName("WTActivityCode");

                entity.HasOne(d => d.Aim)
                    .WithMany(p => p.ExpenditureProduct)
                    .HasForeignKey(d => d.AimId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductAimID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ExpenditureProduct)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProduct_Application");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ExpenditureProduct)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductLMUID");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.ExpenditureProduct)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_ExpenditureProductTaxCodeID");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.ExpenditureProduct)
                    .HasForeignKey(d => d.UnitTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProduct_ExpenditureProductUnitType");
            });

            modelBuilder.Entity<ExpenditureProductSiteMap>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.SiteId })
                    .HasName("IX_ExpenditureProductSiteMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ExpenditureProductSiteMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductSiteMap_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ExpenditureProductSiteMap)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductSiteMap_ExpenditureProduct");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ExpenditureProductSiteMap)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductSiteMap_ManagementUnit");
            });

            modelBuilder.Entity<ExternalLink>(entity =>
            {
                entity.HasIndex(e => new { e.ManagementUnitId, e.TypeId })
                    .HasName("IX_ExternalLink")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ManagementUnitId)
                    .IsRequired()
                    .HasColumnName("ManagementUnitID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.ExternalLink)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalLink_ManagementUnit");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ExternalLink)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExternalLink_ExternalLinkType");
            });

            modelBuilder.Entity<ExternalLinkType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<Farming>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Arp).HasColumnName("ARP");

                entity.Property(e => e.Cphno)
                    .HasColumnName("CPHNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Css).HasColumnName("CSS");

                entity.Property(e => e.Cssdate)
                    .HasColumnName("CSSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CssrefNo)
                    .HasColumnName("CSSRefNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Els).HasColumnName("ELS");

                entity.Property(e => e.Elsdate)
                    .HasColumnName("ELSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ElsrefNo)
                    .HasColumnName("ELSRefNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Fwps).HasColumnName("FWPS");

                entity.Property(e => e.GlastirAwe).HasColumnName("GlastirAWE");

                entity.Property(e => e.GlastirAwedate)
                    .HasColumnName("GlastirAWEDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GlastirAwerefNo)
                    .HasColumnName("GlastirAWERefNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.GlastirTe).HasColumnName("GlastirTE");

                entity.Property(e => e.GlastirTedate)
                    .HasColumnName("GlastirTEDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GlastirTerefNo)
                    .HasColumnName("GlastirTERefNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.GlastirWcp).HasColumnName("GlastirWCP");

                entity.Property(e => e.Hls).HasColumnName("HLS");

                entity.Property(e => e.Hlsdate)
                    .HasColumnName("HLSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HlsrefNo)
                    .HasColumnName("HLSRefNo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Ilp).HasColumnName("ILP");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lfa).HasColumnName("LFA");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sbibrncrn)
                    .HasColumnName("SBIBRNCRN")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Sfps).HasColumnName("SFPS");

                entity.Property(e => e.Srdp).HasColumnName("SRDP");

                entity.Property(e => e.WtfarmingLtd).HasColumnName("WTFarmingLtd");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Farming)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FarmingLMUID");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.HasIndex(e => e.Reference)
                    .HasName("Feature_Reference_IX");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AimId)
                    .HasColumnName("AimID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AppliesToEntireSite).HasDefaultValueSql("0");

                entity.Property(e => e.BiodiversityActionPlans)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.ConstraintsAndOpportunities)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FactorsCausingChange).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LongTermObjective)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagementUnitId)
                    .HasColumnName("ManagementUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtherCostedHabitatActionPlans)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OtherTypeDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShortTermObjective)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Significance)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WoodProduction).HasDefaultValueSql("0");

                entity.HasOne(d => d.Aim)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.AimId)
                    .HasConstraintName("FK_Feature_Aim");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_FeatureLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeatureManagementUnitID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FeatureTypeID");
            });

            modelBuilder.Entity<FeatureMonitoring>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActualObservation).HasColumnType("varchar(max)");

                entity.Property(e => e.ActualObservationDate).HasColumnType("datetime");

                entity.Property(e => e.AttributeToBeMeasured)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DeadlineActionDate).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FeatureID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LowerLimit).HasDefaultValueSql("0");

                entity.Property(e => e.Method)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PlannedObservation).HasColumnType("varchar(max)");

                entity.Property(e => e.PlannedObservationDate).HasColumnType("datetime");

                entity.Property(e => e.PredictionShortTermObjective).HasColumnType("varchar(max)");

                entity.Property(e => e.SuggestionsAndActions).HasColumnType("varchar(max)");

                entity.Property(e => e.TargetValue).HasDefaultValueSql("0");

                entity.Property(e => e.UpperLimit).HasDefaultValueSql("0");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.FeatureMonitoring)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeatureMonitoringFeatureID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FeatureMonitoring)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeatureMonitoringLMUID");
            });

            modelBuilder.Entity<FeatureType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.IsWoodProduction).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FeatureType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeatureTypeLMUID");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.FeatureType)
                    .HasForeignKey(d => d.ObjectiveId)
                    .HasConstraintName("FK_FeatureType_Aim");
            });

            modelBuilder.Entity<Features>(entity =>
            {
                entity.HasKey(e => e.MiPrinx)
                    .HasName("PK__features__B335D4E50845CD96");

                entity.ToTable("features");

                entity.Property(e => e.MiPrinx).HasColumnName("MI_PRINX");

                entity.Property(e => e.DataSource).HasColumnType("varchar(50)");

                entity.Property(e => e.FeatureCode).HasColumnType("varchar(5)");

                entity.Property(e => e.FeatureDescription).HasColumnType("varchar(130)");

                entity.Property(e => e.MiStyle)
                    .HasColumnName("MI_STYLE")
                    .HasColumnType("varchar(254)");

                entity.Property(e => e.SubCompLetter).HasColumnType("varchar(4)");

                entity.Property(e => e.SubType).HasColumnType("varchar(100)");

                entity.Property(e => e.Type).HasColumnType("varchar(15)");

                entity.Property(e => e.UpdateBy).HasColumnType("varchar(15)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WoodId).HasColumnName("WoodID");
            });

            modelBuilder.Entity<FireAssessment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FireAssessment)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FireAssessmentLMUID");
            });

            modelBuilder.Entity<FishingType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FishingType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FishingTypeLMUID");
            });

            modelBuilder.Entity<FollowOnActionType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FollowOnActionType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FollowOnActionTypeLMUID");
            });

            modelBuilder.Entity<Funding>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.ClaimedDate).HasColumnType("datetime");

                entity.Property(e => e.ConditionsApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DonorName).HasColumnType("varchar(max)");

                entity.Property(e => e.FundingConfirmedDate).HasColumnType("datetime");

                entity.Property(e => e.GrantConditionsDescr).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.OfferedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Funding)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FundingAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Funding)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FundingLMUID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Funding)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FundingFundingTypeID");
            });

            modelBuilder.Entity<FundingStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FundingStatus)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FundingStatusLMUID");
            });

            modelBuilder.Entity<FundingType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.FundingType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FundingTypeLMUID");
            });

            modelBuilder.Entity<GlobalConfiguration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.GlobalConfiguration)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GlobalConfigurationLMUID");
            });

            modelBuilder.Entity<Grant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Archived).HasDefaultValueSql("0");

                entity.Property(e => e.ArchivedById).HasColumnName("ArchivedByID");

                entity.Property(e => e.Authorised).HasDefaultValueSql("0");

                entity.Property(e => e.AuthorisedById)
                    .HasColumnName("AuthorisedByID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ClumpedWithId).HasColumnName("ClumpedWithID");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Completed).HasDefaultValueSql("0");

                entity.Property(e => e.CompletedById).HasColumnName("CompletedByID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateArchived).HasColumnType("datetime");

                entity.Property(e => e.DateAuthorised).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.GrantBodyId).HasColumnName("GrantBodyID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementPlanId).HasColumnName("ManagementPlanID");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SchemeId).HasColumnName("SchemeID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.ArchivedBy)
                    .WithMany(p => p.GrantArchivedBy)
                    .HasForeignKey(d => d.ArchivedById)
                    .HasConstraintName("FK_GrantArchivedByID");

                entity.HasOne(d => d.AuthorisedBy)
                    .WithMany(p => p.GrantAuthorisedBy)
                    .HasForeignKey(d => d.AuthorisedById)
                    .HasConstraintName("FK_GrantAuthorisedByID");

                entity.HasOne(d => d.ClumpedWith)
                    .WithMany(p => p.InverseClumpedWith)
                    .HasForeignKey(d => d.ClumpedWithId)
                    .HasConstraintName("FK_GrantClumpedWithID");

                entity.HasOne(d => d.CompletedBy)
                    .WithMany(p => p.GrantCompletedBy)
                    .HasForeignKey(d => d.CompletedById)
                    .HasConstraintName("FK_GrantCompletedByID");

                entity.HasOne(d => d.GrantBody)
                    .WithMany(p => p.Grant)
                    .HasForeignKey(d => d.GrantBodyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantGrantBodyID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.GrantLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantLMUID");

                entity.HasOne(d => d.ManagementPlan)
                    .WithMany(p => p.Grant)
                    .HasForeignKey(d => d.ManagementPlanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantManagementPlanID");

                entity.HasOne(d => d.Scheme)
                    .WithMany(p => p.Grant)
                    .HasForeignKey(d => d.SchemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantSchemeID");
            });

            modelBuilder.Entity<GrantBody>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.GrantBody)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrantBodyLMUID");
            });

            modelBuilder.Entity<Harvesting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.SubCompartmentId).HasColumnName("SubCompartmentID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Harvesting)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Harvesting_User");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Harvesting)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Harvesting_ManagementUnit");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.Harvesting)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Harvesting_SubCompartment");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Harvesting)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Harvesting_HarvestingOperationType");
            });

            modelBuilder.Entity<HarvestingOperationType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Hazard>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppliesToEntireSite).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Easting).HasDefaultValueSql("0");

                entity.Property(e => e.GisdataSource)
                    .HasColumnName("GISDataSource")
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GisupdatedById)
                    .HasColumnName("GISUpdatedByID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GisupdatedDate)
                    .HasColumnName("GISUpdatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.MapReference)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Northing).HasDefaultValueSql("0");

                entity.Property(e => e.OwnershipId).HasColumnName("OwnershipID");

                entity.Property(e => e.SiteCentreEasting).HasDefaultValueSql("0");

                entity.Property(e => e.SiteCentreNorthing).HasDefaultValueSql("0");

                entity.Property(e => e.StructureReportRequired).HasDefaultValueSql("0");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Hazard)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardLMUID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Hazard)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_HazardLocationID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Hazard)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardManagementUnitID");

                entity.HasOne(d => d.Ownership)
                    .WithMany(p => p.Hazard)
                    .HasForeignKey(d => d.OwnershipId)
                    .HasConstraintName("FK_HazardOwnershipID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Hazard)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_HazardTypeID");
            });

            modelBuilder.Entity<HazardAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FollowOnActionId).HasColumnName("FollowOnActionID");

                entity.Property(e => e.FollowOnComplete).HasColumnType("datetime");

                entity.Property(e => e.FollowOnDeadline).HasColumnType("datetime");

                entity.Property(e => e.FurtherAction)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.HazardId).HasColumnName("HazardID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeverityProbabilityOfHarmId).HasColumnName("SeverityProbabilityOfHarmID");

                entity.HasOne(d => d.FollowOnAction)
                    .WithMany(p => p.HazardAction)
                    .HasForeignKey(d => d.FollowOnActionId)
                    .HasConstraintName("FK_HazardActionFollowOnActionID");

                entity.HasOne(d => d.Hazard)
                    .WithMany(p => p.HazardAction)
                    .HasForeignKey(d => d.HazardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardActionID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardAction)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardActionLMUID");

                entity.HasOne(d => d.SeverityProbabilityOfHarm)
                    .WithMany(p => p.HazardAction)
                    .HasForeignKey(d => d.SeverityProbabilityOfHarmId)
                    .HasConstraintName("FK_HazardActionSeverityProbabilityOfHarmID");
            });

            modelBuilder.Entity<HazardCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DocuwareName).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Label).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardCategory)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardCategoryLMUID");
            });

            modelBuilder.Entity<HazardFireRisk>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FireRiskTypeId).HasColumnName("FireRiskTypeID");

                entity.Property(e => e.HazardId).HasColumnName("HazardID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cru)
                    .WithMany(p => p.HazardFireRiskCru)
                    .HasForeignKey(d => d.Cruid)
                    .HasConstraintName("FK_HazardFireRiskCRUID");

                entity.HasOne(d => d.Dlu)
                    .WithMany(p => p.HazardFireRiskDlu)
                    .HasForeignKey(d => d.Dluid)
                    .HasConstraintName("FK_HazardFireRiskDLUID");

                entity.HasOne(d => d.FireRiskType)
                    .WithMany(p => p.HazardFireRisk)
                    .HasForeignKey(d => d.FireRiskTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskFireRiskTypeID");

                entity.HasOne(d => d.Hazard)
                    .WithMany(p => p.HazardFireRisk)
                    .HasForeignKey(d => d.HazardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskHazardID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardFireRiskLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskLMUID");
            });

            modelBuilder.Entity<HazardFireRiskCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowMultiSelect).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cru)
                    .WithMany(p => p.HazardFireRiskCategoryCru)
                    .HasForeignKey(d => d.Cruid)
                    .HasConstraintName("FK_HazardFireRiskCategoryCRUID");

                entity.HasOne(d => d.Dlu)
                    .WithMany(p => p.HazardFireRiskCategoryDlu)
                    .HasForeignKey(d => d.Dluid)
                    .HasConstraintName("FK_HazardFireRiskCategoryDLUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardFireRiskCategoryLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskCategoryLMUID");
            });

            modelBuilder.Entity<HazardFireRiskType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.HazardFireRiskType)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskTypeCategoryID");

                entity.HasOne(d => d.Cru)
                    .WithMany(p => p.HazardFireRiskTypeCru)
                    .HasForeignKey(d => d.Cruid)
                    .HasConstraintName("FK_HazardFireRiskTypeCRUID");

                entity.HasOne(d => d.Dlu)
                    .WithMany(p => p.HazardFireRiskTypeDlu)
                    .HasForeignKey(d => d.Dluid)
                    .HasConstraintName("FK_HazardFireRiskTypepDLUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardFireRiskTypeLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardFireRiskTypeLMUID");
            });

            modelBuilder.Entity<HazardIncidentHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateRecorded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.HazardId).HasColumnName("HazardID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Hazard)
                    .WithMany(p => p.HazardIncidentHistory)
                    .HasForeignKey(d => d.HazardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardIncidentHistoryHazardID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardIncidentHistory)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardIncidentHistoryLMUID");
            });

            modelBuilder.Entity<HazardLocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsgridReference)
                    .IsRequired()
                    .HasColumnName("OSGridReference")
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardLocation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardLocationLMUID");
            });

            modelBuilder.Entity<HazardOwnership>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.HazardOwnership)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardOwnershipCategoryID");

                entity.HasOne(d => d.Cru)
                    .WithMany(p => p.HazardOwnershipCru)
                    .HasForeignKey(d => d.Cruid)
                    .HasConstraintName("FK_HazardOwnershipCRUID");

                entity.HasOne(d => d.Dlu)
                    .WithMany(p => p.HazardOwnershipDlu)
                    .HasForeignKey(d => d.Dluid)
                    .HasConstraintName("FK_HazardOwnershipDLUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardOwnershipLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardOwnershipLMUID");
            });

            modelBuilder.Entity<HazardType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.HazardType)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardTypeCategoryID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HazardType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HazardTypeLMUID");
            });

            modelBuilder.Entity<HelpCache>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasColumnType("varchar(max)");

                entity.Property(e => e.Content).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HelpCache)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HelpCache_LMUser");
            });

            modelBuilder.Entity<HighwayAuthority>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.HighwayAuthority)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HighwayAuthorityLMUID");
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasIndex(e => new { e.ManagementUnitId, e.Deleted })
                    .HasName("IX_ManagementUnitID_Deleted");

                entity.HasIndex(e => new { e.Actual, e.Budget, e.ClmdInvd, e.Completed, e.EndDate, e.Forecast, e.ManagementUnitId, e.Pe, e.Project, e.TaxCodeId, e.Cancelled, e.Deleted })
                    .HasName("Income_IX_PerfOpt01");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDate).HasColumnType("datetime");

                entity.Property(e => e.AimId).HasColumnName("AimID");

                entity.Property(e => e.Budget).HasDefaultValueSql("0.0");

                entity.Property(e => e.Cancelled).HasDefaultValueSql("0");

                entity.Property(e => e.Completed).HasDefaultValueSql("0");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GrantId).HasColumnName("GrantID");

                entity.Property(e => e.GrantReference).HasColumnType("varchar(max)");

                entity.Property(e => e.GrantScheme).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.LastMonthForecast).HasDefaultValueSql("0.0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.NoSync).HasDefaultValueSql("0");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pe)
                    .HasColumnName("PE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pipeline).HasDefaultValueSql("0");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Project).HasDefaultValueSql("0");

                entity.Property(e => e.Sodate)
                    .HasColumnName("SODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sono)
                    .HasColumnName("SONo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.Ulmdt)
                    .HasColumnName("ULMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ulmuid).HasColumnName("ULMUID");

                entity.Property(e => e.WoodProduction).HasDefaultValueSql("0");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.HasOne(d => d.Aim)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.AimId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeAimID");

                entity.HasOne(d => d.Grant)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.GrantId)
                    .HasConstraintName("FK_IncomeGrantID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.IncomeLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeManagementUnitID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_IncomeOrderID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductID");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_IncomeTaxCodeID");

                entity.HasOne(d => d.Ulmu)
                    .WithMany(p => p.IncomeUlmu)
                    .HasForeignKey(d => d.Ulmuid)
                    .HasConstraintName("FK_IncomeULMUID");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Income)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeWorkOrderID");
            });

            modelBuilder.Entity<IncomeProduct>(entity =>
            {
                entity.HasIndex(e => new { e.Code, e.ApplicationId })
                    .HasName("IX_IncomeProductCode")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(max)");

                entity.Property(e => e.AimId).HasColumnName("AimID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsWoodProduction).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.Wtactivity)
                    .HasColumnName("WTActivity")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WtactivityCode).HasColumnName("WTActivityCode");

                entity.HasOne(d => d.Aim)
                    .WithMany(p => p.IncomeProduct)
                    .HasForeignKey(d => d.AimId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductAimID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.IncomeProduct)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProduct_Application");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.IncomeProduct)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductLMUID");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.IncomeProduct)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_IncomeProductTaxCodeID");
            });

            modelBuilder.Entity<IncomeProductSiteMap>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.SiteId })
                    .HasName("IX_IncomeProductSiteMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.IncomeProductSiteMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductSiteMap_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.IncomeProductSiteMap)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductSiteMap_IncomeProduct");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.IncomeProductSiteMap)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_IncomeProductSiteMap_ManagementUnit");
            });

            modelBuilder.Entity<InterestLet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InterestLet)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterestLetLMUID");
            });

            modelBuilder.Entity<InternalAudit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuthoriseDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorisedById).HasColumnName("AuthorisedByID");

                entity.Property(e => e.CertifiedById).HasColumnName("CertifiedByID");

                entity.Property(e => e.CertifyDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FirstAuditor).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstAuditorId).HasColumnName("FirstAuditorID");

                entity.Property(e => e.GeneralSummary).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PublishedById).HasColumnName("PublishedByID");

                entity.Property(e => e.PublishingDate).HasColumnType("datetime");

                entity.Property(e => e.SecondAuditor).HasColumnType("varchar(max)");

                entity.Property(e => e.SecondAuditorId).HasColumnName("SecondAuditorID");

                entity.Property(e => e.SiteManager).HasColumnType("varchar(max)");

                entity.Property(e => e.SiteManagerId).HasColumnName("SiteManagerID");

                entity.HasOne(d => d.AuthorisedBy)
                    .WithMany(p => p.InternalAuditAuthorisedBy)
                    .HasForeignKey(d => d.AuthorisedById)
                    .HasConstraintName("FK_InternalAudit_User_AuthorisedBy");

                entity.HasOne(d => d.CertifiedBy)
                    .WithMany(p => p.InternalAuditCertifiedBy)
                    .HasForeignKey(d => d.CertifiedById)
                    .HasConstraintName("FK_InternalAudit_User_CertifiedBy");

                entity.HasOne(d => d.FirstAuditorNavigation)
                    .WithMany(p => p.InternalAuditFirstAuditorNavigation)
                    .HasForeignKey(d => d.FirstAuditorId)
                    .HasConstraintName("FK_InternalAudit_User_1stAuditor");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InternalAuditLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PublishedBy)
                    .WithMany(p => p.InternalAuditPublishedBy)
                    .HasForeignKey(d => d.PublishedById)
                    .HasConstraintName("FK_InternalAudit_User_PublishedBy");

                entity.HasOne(d => d.SecondAuditorNavigation)
                    .WithMany(p => p.InternalAuditSecondAuditorNavigation)
                    .HasForeignKey(d => d.SecondAuditorId)
                    .HasConstraintName("FK_InternalAudit_User_2ndAuditor");

                entity.HasOne(d => d.SiteManagerNavigation)
                    .WithMany(p => p.InternalAuditSiteManagerNavigation)
                    .HasForeignKey(d => d.SiteManagerId)
                    .HasConstraintName("FK_InternalAudit_User_SiteManager");
            });

            modelBuilder.Entity<InternalAuditGrade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InternalAuditGrade)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternalAuditGrade_User");
            });

            modelBuilder.Entity<InternalAuditObservation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionById).HasColumnName("ActionByID");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.ClosingComments).HasColumnType("varchar(max)");

                entity.Property(e => e.CorrectiveAction).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.InternalAuditId).HasColumnName("InternalAuditID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Observation).HasColumnType("varchar(max)");

                entity.Property(e => e.UkwastrustProcedure)
                    .HasColumnName("UKWASTrustProcedure")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.ActionBy)
                    .WithMany(p => p.InternalAuditObservationActionBy)
                    .HasForeignKey(d => d.ActionById)
                    .HasConstraintName("FK_InternalAuditObservation_User_ActionBy");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.InternalAuditObservation)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_InternalAuditObservation_InternalAuditGrade");

                entity.HasOne(d => d.InternalAudit)
                    .WithMany(p => p.InternalAuditObservation)
                    .HasForeignKey(d => d.InternalAuditId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternalAuditObservation_InternalAudit");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InternalAuditObservationLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<InternalAuditRow>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.AuthoriseDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorisedBy).HasColumnType("varchar(max)");

                entity.Property(e => e.AuthorisedById).HasColumnName("AuthorisedByID");

                entity.Property(e => e.CertifiedBy).HasColumnType("varchar(max)");

                entity.Property(e => e.CertifiedById).HasColumnName("CertifiedByID");

                entity.Property(e => e.CertifyDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FirstAuditor).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstAuditorId).HasColumnName("FirstAuditorID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ManagerName).HasColumnType("varchar(max)");

                entity.Property(e => e.RegionName).HasColumnType("varchar(max)");

                entity.Property(e => e.SecondAuditor).HasColumnType("varchar(max)");

                entity.Property(e => e.SecondAuditorId).HasColumnName("SecondAuditorID");
            });

            modelBuilder.Entity<InternalDesignation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.InternalDesignation)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternalDesignation_AcquisitionUnit");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InternalDesignation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternalDesignation_LMUser");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.InternalDesignation)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_InternalDesignation_InternalDesignationType");
            });

            modelBuilder.Entity<InternalDesignationType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InternalDesignationType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternalDesignationType_LMUser");
            });

            modelBuilder.Entity<LandRegistration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId)
                    .HasColumnName("AcquisitionUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Number)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.LandRegistration)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LandRegistrationAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.LandRegistration)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LandRegistrationLMUID");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Address).HasColumnType("varchar(max)");

                entity.Property(e => e.Agent).HasColumnType("varchar(max)");

                entity.Property(e => e.CommencementDate).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.CommentsOnTermId).HasColumnName("CommentsOnTermID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FishingTypeId).HasColumnName("FishingTypeID");

                entity.Property(e => e.InterestLetId).HasColumnName("InterestLetID");

                entity.Property(e => e.LicenceAgreementId).HasColumnName("LicenceAgreementID");

                entity.Property(e => e.LicencePeriodId).HasColumnName("LicencePeriodID");

                entity.Property(e => e.LicenceTypeId).HasColumnName("LicenceTypeID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.NoticeOfTerminationId).HasColumnName("NoticeOfTerminationID");

                entity.Property(e => e.ProvisionsNoticeId).HasColumnName("ProvisionsNoticeID");

                entity.Property(e => e.RentReviewCycle).HasColumnType("varchar(max)");

                entity.Property(e => e.RentReviewDate).HasColumnType("datetime");

                entity.Property(e => e.RentReviewId).HasColumnName("RentReviewID");

                entity.Property(e => e.SizeInId).HasColumnName("SizeInID");

                entity.Property(e => e.TenantLicensee).HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LicenceAcquisitionUnitID");

                entity.HasOne(d => d.CommentsOnTerm)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.CommentsOnTermId)
                    .HasConstraintName("FK_LicenceCommentsOnTermID");

                entity.HasOne(d => d.FishingType)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.FishingTypeId)
                    .HasConstraintName("FK_LicenceFishingTypeID");

                entity.HasOne(d => d.InterestLet)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.InterestLetId)
                    .HasConstraintName("FK_LicenceInterestLetID");

                entity.HasOne(d => d.LicenceAgreement)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.LicenceAgreementId)
                    .HasConstraintName("FK_LicenceLicenceAgreementID");

                entity.HasOne(d => d.LicencePeriod)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.LicencePeriodId)
                    .HasConstraintName("FK_LicenceLicencePeriodID");

                entity.HasOne(d => d.LicenceType)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.LicenceTypeId)
                    .HasConstraintName("FK_LicenceLicenceTypeID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LicenceLMUID");

                entity.HasOne(d => d.NoticeOfTermination)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.NoticeOfTerminationId)
                    .HasConstraintName("FK_LicenceNoticeOfTerminationID");

                entity.HasOne(d => d.ProvisionsNotice)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.ProvisionsNoticeId)
                    .HasConstraintName("FK_LicenceProvisionsNoticeID");

                entity.HasOne(d => d.RentReview)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.RentReviewId)
                    .HasConstraintName("FK_LicenceRentReviewID");

                entity.HasOne(d => d.SizeIn)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.SizeInId)
                    .HasConstraintName("FK_LicenceSizeInID");
            });

            modelBuilder.Entity<LicenceAgreement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.LicenceAgreement)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LicenceAgreementLMUID");
            });

            modelBuilder.Entity<LicencePeriod>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.LicencePeriod)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LicencePeriodLMUID");
            });

            modelBuilder.Entity<LicenceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.LicenceType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LicenceTypeLMUID");
            });

            modelBuilder.Entity<LookupTable>(entity =>
            {
                entity.HasIndex(e => e.Sqltable)
                    .HasName("IX_LookupTable_SQLTable")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Column1Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Column1LookupId).HasColumnName("Column1LookupID");

                entity.Property(e => e.Column1Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Column2Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column2LookupId).HasColumnName("Column2LookupID");

                entity.Property(e => e.Column2Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column3Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column3LookupId).HasColumnName("Column3LookupID");

                entity.Property(e => e.Column3Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column4Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column4LookupId).HasColumnName("Column4LookupID");

                entity.Property(e => e.Column4Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column5Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column5LookupId).HasColumnName("Column5LookupID");

                entity.Property(e => e.Column5Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column6Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column6LookupId).HasColumnName("Column6LookupID");

                entity.Property(e => e.Column6Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column7Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column7LookupId).HasColumnName("Column7LookupID");

                entity.Property(e => e.Column7Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Column8Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Column8LookupId).HasColumnName("Column8LookupID");

                entity.Property(e => e.Column8Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Sqltable)
                    .IsRequired()
                    .HasColumnName("SQLTable")
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<MajorManagementConstraint>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OtherDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.MajorManagementConstraint)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MajorManagementConstraintLMUID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MajorManagementConstraint)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MajorManagementConstraintTypeID");
            });

            modelBuilder.Entity<MajorManagementConstraintMap>(entity =>
            {
                entity.HasIndex(e => new { e.MajorManagementConstraintTypeId, e.SubCompartmentId })
                    .HasName("IX_MajorManagementConstraintMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.MajorManagementConstraintTypeId)
                    .HasColumnName("MajorManagementConstraintTypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubCompartmentId)
                    .HasColumnName("SubCompartmentID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.MajorManagementConstraint)
                    .WithMany(p => p.MajorManagementConstraintMap)
                    .HasForeignKey(d => d.MajorManagementConstraintTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MajorManagementConstraintMapMajorManagementConstraintTypeID");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.MajorManagementConstraintMap)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MajorManagementConstraintSubCompartmentID");
            });

            modelBuilder.Entity<MajorManagementConstraintType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.MajorManagementConstraintType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MajorManagementConstraintTypeLMUID");
            });

            modelBuilder.Entity<ManagementPlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Approved).HasDefaultValueSql("0");

                entity.Property(e => e.ApprovedById)
                    .HasColumnName("ApprovedByID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ConsultationEndDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.LastExported).HasColumnType("datetime");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pdffile)
                    .HasColumnName("PDFFile")
                    .HasColumnType("image");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.ReviewDeadline).HasColumnType("datetime");

                entity.Property(e => e.UnderConsultation).HasDefaultValueSql("0");

                entity.Property(e => e.UnderReview).HasDefaultValueSql("0");

                entity.Property(e => e.WoodBoardJpgfile)
                    .HasColumnName("WoodBoardJPGFile")
                    .HasColumnType("image");

                entity.Property(e => e.WoodBoardPdffile)
                    .HasColumnName("WoodBoardPDFFile")
                    .HasColumnType("image");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.ManagementPlanApprovedBy)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("FK_ManagementPlanApprovedByID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ManagementPlanLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_ManagementPlanLMUID");
            });

            modelBuilder.Entity<ManagementRegime>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ManagementRegime)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementRegime_LMUser");
            });

            modelBuilder.Entity<ManagementUnit>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessCategory).HasColumnType("char(1)");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AdministrationArea).HasColumnType("varchar(max)");

                entity.Property(e => e.AdministrationAreaId)
                    .HasColumnName("AdministrationAreaID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AllowPoso).HasColumnName("AllowPOSO");

                entity.Property(e => e.AntisocialIssues).HasColumnType("varchar(max)");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Aspect)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BoundariesDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ClumpedManagementUnitId).HasColumnName("ClumpedManagementUnitID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DeerCullPlan)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DeputyId).HasColumnName("DeputyID");

                entity.Property(e => e.DirectionsToMainEntrance).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EstateCategory).HasColumnType("char(1)");

                entity.Property(e => e.ExcludeFromAccountsReporting).HasDefaultValueSql("0");

                entity.Property(e => e.ForecastApproved).HasDefaultValueSql("0");

                entity.Property(e => e.GridReference)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HarvestingComments)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InterimCategory).HasColumnType("char(1)");

                entity.Property(e => e.InterimPortfolioCategoryId)
                    .HasColumnName("InterimPortfolioCategoryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsMainClumpedSite).HasDefaultValueSql("0");

                entity.Property(e => e.IsPaws)
                    .HasColumnName("IsPAWS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocalName).HasColumnType("varchar(max)");

                entity.Property(e => e.LocalNameDesc).HasColumnType("varchar(max)");

                entity.Property(e => e.LongTermIntentions)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MainAccessGridReference)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagementAccessDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ManagementPlanId)
                    .HasColumnName("ManagementPlanID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaximumAltitude).HasDefaultValueSql("0");

                entity.Property(e => e.MicrositeUrl)
                    .HasColumnName("MicrositeURL")
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MinimumAltitude).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NavisionId)
                    .HasColumnName("NavisionID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewEstateCategory).HasColumnType("char(2)");

                entity.Property(e => e.ParentManagementUnitId).HasColumnName("ParentManagementUnitID");

                entity.Property(e => e.PortfolioCategoryId)
                    .HasColumnName("PortfolioCategoryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostCode).HasColumnType("varchar(max)");

                entity.Property(e => e.PreviousOfficerId).HasColumnName("PreviousOfficerID");

                entity.Property(e => e.PublicAccessDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublishedSummaryDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResNo).HasColumnType("varchar(max)");

                entity.Property(e => e.RiskAssessmentId)
                    .HasColumnName("RiskAssessmentID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SiteCategoryId).HasColumnName("SiteCategoryID");

                entity.Property(e => e.SpecialSiteFeatures).HasColumnType("varchar(max)");

                entity.Property(e => e.StandardKey).HasColumnType("varchar(max)");

                entity.Property(e => e.SuitableForFilming).HasColumnType("varchar(max)");

                entity.Property(e => e.SummaryDescription)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Vatrecoverable)
                    .HasColumnName("VATRecoverable")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Wcbudget).HasColumnName("WCBudget");

                entity.Property(e => e.WoodlandOfficerId)
                    .HasColumnName("WoodlandOfficerID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AdministrationAreaNavigation)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.AdministrationAreaId)
                    .HasConstraintName("FK_ManagementUnitAdministrationAreaID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitApplicationID");

                entity.HasOne(d => d.ClumpedManagementUnit)
                    .WithMany(p => p.InverseClumpedManagementUnit)
                    .HasForeignKey(d => d.ClumpedManagementUnitId)
                    .HasConstraintName("FK_ClumpedManagementUnit_ManagementUnit");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_ManagementUnitDepartmentID");

                entity.HasOne(d => d.Deputy)
                    .WithMany(p => p.ManagementUnitDeputy)
                    .HasForeignKey(d => d.DeputyId)
                    .HasConstraintName("FK_ManagementUnitDeputyID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ManagementUnitLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_ManagementUnitLMUID");

                entity.HasOne(d => d.ManagementPlan)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.ManagementPlanId)
                    .HasConstraintName("FK_ManagementUnitManagementPlanID");

                entity.HasOne(d => d.ParentManagementUnit)
                    .WithMany(p => p.InverseParentManagementUnit)
                    .HasForeignKey(d => d.ParentManagementUnitId)
                    .HasConstraintName("FK_ManagementUnitParentManagementUnitID");

                entity.HasOne(d => d.PortfolioCategory)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.PortfolioCategoryId)
                    .HasConstraintName("FK_ManagementUnitPortfolioCategoryID");

                entity.HasOne(d => d.PreviousOfficer)
                    .WithMany(p => p.ManagementUnitPreviousOfficer)
                    .HasForeignKey(d => d.PreviousOfficerId)
                    .HasConstraintName("FK_ManagementUnitPreviousOfficerID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_ManagementUnitRegionID");

                entity.HasOne(d => d.RiskAssessment)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.RiskAssessmentId)
                    .HasConstraintName("FK_ManagementUnitRiskAssessmentID");

                entity.HasOne(d => d.SiteCategory)
                    .WithMany(p => p.ManagementUnit)
                    .HasForeignKey(d => d.SiteCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnit_SiteCategory");

                entity.HasOne(d => d.WoodlandOfficer)
                    .WithMany(p => p.ManagementUnitWoodlandOfficer)
                    .HasForeignKey(d => d.WoodlandOfficerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitWoodlandOfficerID");
            });

            modelBuilder.Entity<ManagementUnitAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ManagementUnitId, e.AttributeId })
                    .HasName("PK_ManagementUnitAttribute");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ManagementUnitAttribute)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitAttribute_Attribute");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.ManagementUnitAttribute)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitAttribute_ManagementUnit");
            });

            modelBuilder.Entity<ManagementUnitGismo>(entity =>
            {
                entity.HasIndex(e => e.ManagementUnitId)
                    .HasName("IX_ManagementUnitGismo")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ManagementUnitGismo)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitGismo_User");

                entity.HasOne(d => d.ManagementUnit)
                    .WithOne(p => p.ManagementUnitGismo)
                    .HasForeignKey<ManagementUnitGismo>(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitGismo_ManagementUnit");
            });

            modelBuilder.Entity<ManagementUnitRow>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK_ManagementUnitRowSiteId");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Aucount).HasColumnName("AUCount");

                entity.Property(e => e.Deputy).HasColumnType("varchar(max)");

                entity.Property(e => e.Manager).HasColumnType("varchar(max)");

                entity.Property(e => e.Region).HasColumnType("varchar(max)");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<ManagementUnitWebSearch>(entity =>
            {
                entity.HasKey(e => e.ManagementUnitWebSearchId)
                    .HasName("PK__tmp_ms_x__CC62255D03B499DD");

                entity.Property(e => e.ManagementUnitWebSearchId).HasColumnName("ManagementUnitWebSearchID");

                entity.Property(e => e.AcquisitionName).HasColumnType("varchar(max)");

                entity.Property(e => e.AreaInHectares).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Designation).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.HistoricName).HasColumnType("varchar(max)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Region).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<ManagementUnitWorkOrderMap>(entity =>
            {
                entity.HasIndex(e => new { e.ManagementUnitId, e.WorkOrderId })
                    .HasName("IX_ManagementUnitWorkOrderMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.WorkOrderId).HasColumnName("WorkOrderID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ManagementUnitWorkOrderMap)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitWorkOrderMapLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.ManagementUnitWorkOrderMap)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitWorkOrderMapManagementUnitID");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ManagementUnitWorkOrderMap)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ManagementUnitWorkOrderMapWorkOrderID");
            });

            modelBuilder.Entity<MapUrl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Url).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.MapUrl)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MapUrl_User");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.MapUrl)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MapUrl_Region");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MapUrl)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MapUrl_MapUrlType");
            });

            modelBuilder.Entity<MapUrlType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.MapUrlType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MapUrlType_User");
            });

            modelBuilder.Entity<MetadataField>(entity =>
            {
                entity.HasIndex(e => new { e.RecordId, e.FieldName })
                    .HasName("IX_MetadataField_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.RecordId, e.SysFieldName })
                    .HasName("IX_MetadataField_SysName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FieldAlias)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FieldTypeRef)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsKey).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaxLength).HasDefaultValueSql("0");

                entity.Property(e => e.Permissions).HasColumnType("varchar(250)");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.RecordRefId).HasColumnName("RecordRefID");

                entity.Property(e => e.Sync).HasDefaultValueSql("0");

                entity.Property(e => e.SysFieldName)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.FieldTypeRefNavigation)
                    .WithMany(p => p.MetadataField)
                    .HasForeignKey(d => d.FieldTypeRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MetadataField_MetadataFieldType");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.MetadataField)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MetadataField_MetadataRecord");

                entity.HasOne(d => d.RecordRef)
                    .WithMany(p => p.InverseRecordRef)
                    .HasForeignKey(d => d.RecordRefId)
                    .HasConstraintName("FK_MetadataField_MetadataFieldRef");
            });

            modelBuilder.Entity<MetadataFieldType>(entity =>
            {
                entity.HasKey(e => e.Alias)
                    .HasName("IX_MetadataFieldType_Alias");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_MetadataFieldType_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.Alias, e.Dbname })
                    .HasName("IX_MetadataFieldType_DBName")
                    .IsUnique();

                entity.Property(e => e.Alias).HasColumnType("varchar(250)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dbname)
                    .IsRequired()
                    .HasColumnName("DBName")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DefaultFormat).HasColumnType("varchar(250)");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            modelBuilder.Entity<MetadataRecord>(entity =>
            {
                entity.HasIndex(e => e.RecordName)
                    .HasName("IX_MetadataRecord_Name")
                    .IsUnique();

                entity.HasIndex(e => e.SysRecordName)
                    .HasName("IX_MetadataRecord_SysName")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsLookup).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.IsRoot).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ParentRecordId).HasColumnName("ParentRecordID");

                entity.Property(e => e.RecordAlias)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Sqlquery)
                    .HasColumnName("SQLQuery")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Sync).HasDefaultValueSql("0");

                entity.Property(e => e.SyncAll).HasDefaultValueSql("0");

                entity.Property(e => e.SyncDeleted).HasDefaultValueSql("0");

                entity.Property(e => e.SysRecordName)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.ParentRecord)
                    .WithMany(p => p.InverseParentRecord)
                    .HasForeignKey(d => d.ParentRecordId)
                    .HasConstraintName("FK_MetadataRecord_MetadataRecord");
            });

            modelBuilder.Entity<MobileChange>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewValue).HasColumnType("varchar(max)");

                entity.Property(e => e.OldValue).HasColumnType("varchar(max)");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.RecordName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.MobileChange)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MobileChange_LMUser");
            });

            modelBuilder.Entity<NonFsctype>(entity =>
            {
                entity.ToTable("NonFSCType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.NonFsctype)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NonFSCType_User");
            });

            modelBuilder.Entity<NoticeOfTermination>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.NoticeOfTermination)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NoticeOfTerminationLMUID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NettingOffPo).HasColumnName("NettingOffPO");

                entity.Property(e => e.NettingOffPono)
                    .HasColumnName("NettingOffPONo")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Number).HasColumnType("varchar(max)");

                entity.Property(e => e.Remarks).HasColumnType("varchar(max)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_OrderCustomerID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OrderLMUID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_OrderSupplierID");
            });

            modelBuilder.Entity<PartDisposal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.Address).HasColumnType("varchar(max)");

                entity.Property(e => e.County).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.DisposalDate).HasColumnType("datetime");

                entity.Property(e => e.DisposedInterestId).HasColumnName("DisposedInterestID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Email).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Name).HasColumnType("varchar(max)");

                entity.Property(e => e.Organisation).HasColumnType("varchar(max)");

                entity.Property(e => e.Postcode).HasColumnType("varchar(max)");

                entity.Property(e => e.Telephone).HasColumnType("varchar(max)");

                entity.Property(e => e.Town).HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.PartDisposal)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PartDisposalAcquisitionUnitID");

                entity.HasOne(d => d.DisposedInterest)
                    .WithMany(p => p.PartDisposal)
                    .HasForeignKey(d => d.DisposedInterestId)
                    .HasConstraintName("FK_PartDisposalDisposedInterestID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PartDisposal)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PartDisposalLMUID");
            });

            modelBuilder.Entity<Pesticide>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.ActiveIngredientId).HasColumnName("ActiveIngredientID");

                entity.Property(e => e.ApplicationMethodId).HasColumnName("ApplicationMethodID");

                entity.Property(e => e.ApplicationRate).HasDefaultValueSql("0");

                entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");

                entity.Property(e => e.ApplicationUnitId).HasColumnName("ApplicationUnitID");

                entity.Property(e => e.Archived).HasDefaultValueSql("0");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.ContractorCode).HasColumnType("varchar(max)");

                entity.Property(e => e.ContractorName).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ExpenditureId).HasColumnName("ExpenditureID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocationInSite).HasColumnType("varchar(max)");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.OldPonumber)
                    .HasColumnName("OldPONumber")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OtherIngredient).HasColumnType("varchar(max)");

                entity.Property(e => e.ProductDescr).HasColumnType("varchar(max)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReasonForUseId).HasColumnName("ReasonForUseID");

                entity.Property(e => e.SiteClassificationId).HasColumnName("SiteClassificationID");

                entity.Property(e => e.SurplusDisposed).HasColumnType("varchar(max)");

                entity.Property(e => e.TargetSpeciesId).HasColumnName("TargetSpeciesID");

                entity.Property(e => e.WeatherConditions).HasColumnType("varchar(max)");

                entity.Property(e => e.WholeSite).HasDefaultValueSql("0");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .HasConstraintName("FK_PesticideAcquisitionUnitID");

                entity.HasOne(d => d.ActiveIngredient)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ActiveIngredientId)
                    .HasConstraintName("FK_PesticideActiveIngredientID");

                entity.HasOne(d => d.ApplicationMethod)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ApplicationMethodId)
                    .HasConstraintName("FK_PesticideApplicationMethodID");

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .HasConstraintName("FK_PesticideApplicationTypeID");

                entity.HasOne(d => d.ApplicationUnit)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ApplicationUnitId)
                    .HasConstraintName("FK_PesticideApplicationUnitID");

                entity.HasOne(d => d.Expenditure)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ExpenditureId)
                    .HasConstraintName("FK_PesticideExpenditureID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PesticideLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PesticideManagementUnitID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PesticidePesticideProductID");

                entity.HasOne(d => d.ReasonForUse)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.ReasonForUseId)
                    .HasConstraintName("FK_PesticideReasonForUseID");

                entity.HasOne(d => d.SiteClassification)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.SiteClassificationId)
                    .HasConstraintName("FK_PesticideSiteClassificationID");

                entity.HasOne(d => d.TargetSpecies)
                    .WithMany(p => p.Pesticide)
                    .HasForeignKey(d => d.TargetSpeciesId)
                    .HasConstraintName("FK_PesticideTargetSpeciesID");
            });

            modelBuilder.Entity<PesticideEntry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operator).HasColumnType("varchar(max)");

                entity.Property(e => e.PesticideId).HasColumnName("PesticideID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PesticideEntry)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PesticideEntryLMUID");

                entity.HasOne(d => d.Pesticide)
                    .WithMany(p => p.PesticideEntry)
                    .HasForeignKey(d => d.PesticideId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PesticideEntryPesticideID");
            });

            modelBuilder.Entity<PesticideProduct>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PesticideProduct)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PesticideProductLMUID");
            });

            modelBuilder.Entity<PlantType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PlantType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlantType_LMUser");
            });

            modelBuilder.Entity<PlantedBy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PlantedBy)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlantedByLMUID");
            });

            modelBuilder.Entity<PlantingAccessType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PlantingAccessType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlantingAccessTypeLMUID");
            });

            modelBuilder.Entity<PlantingType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PlantingType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlantingTypeLMUID");
            });

            modelBuilder.Entity<PortfolioCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("'<Assigned>'");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PortfolioCategory)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PortfolioCategoryLMUID");
            });

            modelBuilder.Entity<ProductUnitType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ProductUnitType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpenditureProductUnitType_User");
            });

            modelBuilder.Entity<PropertyManagedBy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PropertyManagedBy)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PropertyManagedByLMUID");
            });

            modelBuilder.Entity<ProvenanceZone>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ProvenanceZone)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProvenanceZone_LMUser");
            });

            modelBuilder.Entity<ProvisionsNotice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ProvisionsNotice)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProvisionsNoticeLMUID");
            });

            modelBuilder.Entity<PublicInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessWalks).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ExtendedDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.Folklore).HasColumnType("varchar(max)");

                entity.Property(e => e.GettingThere).HasColumnType("varchar(max)");

                entity.Property(e => e.History).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.NearestAmenities).HasColumnType("varchar(max)");

                entity.Property(e => e.OriginOfName).HasColumnType("varchar(max)");

                entity.Property(e => e.Setting).HasColumnType("varchar(max)");

                entity.Property(e => e.TreesAndPlants).HasColumnType("varchar(max)");

                entity.Property(e => e.Wildlife).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.PublicInfo)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PublicInfo_User");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.PublicInfo)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PublicInfo_ManagementUnit");
            });

            modelBuilder.Entity<ReasonForUse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ReasonForUse)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReasonForUseLMUID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateForecastApproved).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DocuwareName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ForecastApproved).HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResNo)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RegionCountryID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RegionLMUID");
            });

            modelBuilder.Entity<RentReview>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.RentReview)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RentReviewLMUID");
            });

            modelBuilder.Entity<ReportBinary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentType).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Data).HasColumnType("image");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Encoding).HasColumnType("varchar(max)");

                entity.Property(e => e.Extension).HasColumnType("varchar(max)");

                entity.Property(e => e.HistoryId)
                    .HasColumnName("HistoryID")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.MimeType).HasColumnType("varchar(max)");

                entity.Property(e => e.SessionId).HasColumnType("varchar(max)");

                entity.Property(e => e.Size).HasColumnType("varchar(max)");

                entity.Property(e => e.Warnings).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ReportBinary)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_ReportBinary_User");
            });

            modelBuilder.Entity<ReportQueue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BinaryId).HasColumnName("BinaryID");

                entity.Property(e => e.CcList).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.CustomParameters).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GenErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.GenErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ScheduledAt).HasColumnType("datetime");

                entity.Property(e => e.SendErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.SendErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.SiteIds)
                    .HasColumnName("SiteIDs")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToList).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ReportQueue)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportQueue_Application");

                entity.HasOne(d => d.Binary)
                    .WithMany(p => p.ReportQueue)
                    .HasForeignKey(d => d.BinaryId)
                    .HasConstraintName("FK_ReportQueue_ReportBinary");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ReportQueue)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_ReportQueue_User");
            });

            modelBuilder.Entity<RightsType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.RightsType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RightsTypeLMUID");
            });

            modelBuilder.Entity<RiskAssessment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Authorised).HasDefaultValueSql("0");

                entity.Property(e => e.AuthorisedByRegionalManagerId)
                    .HasColumnName("AuthorisedByRegionalManagerID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BiosecurityZoneId).HasColumnName("BiosecurityZoneID");

                entity.Property(e => e.CompletedByWoodlandOfficerId)
                    .HasColumnName("CompletedByWoodlandOfficerID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DateAuthorised).HasColumnType("datetime");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FireAssessmentId)
                    .HasColumnName("FireAssessmentID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PersonalIssues).HasColumnType("varchar(max)");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.AuthorisedByRegionalManager)
                    .WithMany(p => p.RiskAssessmentAuthorisedByRegionalManager)
                    .HasForeignKey(d => d.AuthorisedByRegionalManagerId)
                    .HasConstraintName("FK_RiskAssessmentAuthorisedByRegionalManagerID");

                entity.HasOne(d => d.BiosecurityZone)
                    .WithMany(p => p.RiskAssessment)
                    .HasForeignKey(d => d.BiosecurityZoneId)
                    .HasConstraintName("FK_RiskAssessmentBiosecurityZoneID");

                entity.HasOne(d => d.CompletedByWoodlandOfficer)
                    .WithMany(p => p.RiskAssessmentCompletedByWoodlandOfficer)
                    .HasForeignKey(d => d.CompletedByWoodlandOfficerId)
                    .HasConstraintName("FK_RiskAssessmentCompletedByWoodlandOfficerID");

                entity.HasOne(d => d.FireAssessment)
                    .WithMany(p => p.RiskAssessment)
                    .HasForeignKey(d => d.FireAssessmentId)
                    .HasConstraintName("FK_RiskAssessmentFireAssessmentID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.RiskAssessmentLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RiskAssessmentLMUID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<SeasonalActivity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId)
                    .HasColumnName("ManagementUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SeasonalActivity)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SeasonalActivityLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.SeasonalActivity)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SeasonalActivityManagementUnitID");
            });

            modelBuilder.Entity<SeverityProbabilityOfHarm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Probability)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SeverityProbabilityOfHarm)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SeveriryProbabilityOfHarmLMUID");
            });

            modelBuilder.Entity<SiteCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SiteCategory)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SiteCategory_LMUser");
            });

            modelBuilder.Entity<SiteClassification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SiteClassification)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SiteClassificationLMUID");
            });

            modelBuilder.Entity<SizeIn>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SizeIn)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SizeInLMUID");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasColumnType("varchar(10)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Group).HasColumnType("varchar(5)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.LatinName)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Species)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SpeciesLMUID");
            });

            modelBuilder.Entity<Structure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.BriefReportSummary).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.LastInspectionDate).HasColumnType("datetime");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.NextInspectionDate).HasColumnType("datetime");

                entity.Property(e => e.ReportAuthor).HasColumnType("varchar(max)");

                entity.Property(e => e.ResponsibilityDescr).HasColumnType("varchar(max)");

                entity.Property(e => e.StructureConditionId).HasColumnName("StructureConditionID");

                entity.Property(e => e.StructureTypeId).HasColumnName("StructureTypeID");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Structure)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StructureAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Structure)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StructureLMUID");

                entity.HasOne(d => d.StructureCondition)
                    .WithMany(p => p.Structure)
                    .HasForeignKey(d => d.StructureConditionId)
                    .HasConstraintName("FK_StructureStructureConditionID");

                entity.HasOne(d => d.StructureType)
                    .WithMany(p => p.Structure)
                    .HasForeignKey(d => d.StructureTypeId)
                    .HasConstraintName("FK_StructureStructureTypeID");
            });

            modelBuilder.Entity<StructureCondition>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.StructureCondition)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StructureConditionLMUID");
            });

            modelBuilder.Entity<StructureType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.StructureType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StructureTypeLMUID");
            });

            modelBuilder.Entity<SubCompartment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaInHectares).HasDefaultValueSql("0");

                entity.Property(e => e.Compartment).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsOtherHabitat).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.IsWoodland).HasDefaultValueSql("0");

                entity.Property(e => e.IsWoodlandCreation).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MainSpeciesId).HasColumnName("MainSpeciesID");

                entity.Property(e => e.ManagementRegimeId).HasColumnName("ManagementRegimeID");

                entity.Property(e => e.ManagementUnitId)
                    .HasColumnName("ManagementUnitID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pawsstatus).HasColumnName("PAWSStatus");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.SecondSpeciesId).HasColumnName("SecondSpeciesID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.SubCompartment)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentLMUID");

                entity.HasOne(d => d.MainSpecies)
                    .WithMany(p => p.SubCompartmentMainSpecies)
                    .HasForeignKey(d => d.MainSpeciesId)
                    .HasConstraintName("FK_SubCompartment_Species");

                entity.HasOne(d => d.ManagementRegime)
                    .WithMany(p => p.SubCompartment)
                    .HasForeignKey(d => d.ManagementRegimeId)
                    .HasConstraintName("FK_SubCompartment_ManagementRegime");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.SubCompartment)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentManagementUnitID");

                entity.HasOne(d => d.SecondSpecies)
                    .WithMany(p => p.SubCompartmentSecondSpecies)
                    .HasForeignKey(d => d.SecondSpeciesId)
                    .HasConstraintName("FK_SubCompartment_Species1");
            });

            modelBuilder.Entity<SubCompartmentDesignationMap>(entity =>
            {
                entity.HasIndex(e => new { e.DesignationId, e.SubCompartmentId })
                    .HasName("IX_SubCompartmentDesignationMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DesignationId)
                    .HasColumnName("DesignationID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.SubCompartmentId)
                    .HasColumnName("SubCompartmentID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.SubCompartmentDesignationMap)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentDesignationMapDesignationID");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.SubCompartmentDesignationMap)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentDesignationMapSubCompartmentID");
            });

            modelBuilder.Entity<SubCompartmentFeatureMap>(entity =>
            {
                entity.HasIndex(e => new { e.SubCompartmentId, e.FeatureId })
                    .HasName("IX_SubCompartmentFeatureMap")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Confidential).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("FeatureID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.MapRef).HasColumnType("varchar(max)");

                entity.Property(e => e.SubCompartmentId)
                    .HasColumnName("SubCompartmentID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.SubCompartmentFeatureMap)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentFeatureMapFeatureID");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.SubCompartmentFeatureMap)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubCompartmentFeatureMapSubCompartmentID");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("varchar(max)");

                entity.Property(e => e.AddressType)
                    .HasColumnName("Address type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Assistant).HasColumnType("varchar(50)");

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Code).HasColumnType("varchar(50)");

                entity.Property(e => e.County).HasColumnType("varchar(50)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Home).HasColumnType("varchar(50)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Pager).HasColumnType("varchar(50)");

                entity.Property(e => e.PostalNo).HasColumnType("varchar(50)");

                entity.Property(e => e.Suppcat).HasColumnType("varchar(50)");

                entity.Property(e => e.Suppgrp).HasColumnType("varchar(50)");

                entity.Property(e => e.TaxCodeId).HasColumnName("TaxCodeID");

                entity.Property(e => e.Telefax).HasColumnType("varchar(50)");

                entity.Property(e => e.Telephone).HasColumnType("varchar(50)");

                entity.Property(e => e.Telex).HasColumnType("varchar(50)");

                entity.Property(e => e.To).HasColumnType("varchar(50)");

                entity.Property(e => e.Town).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SupplierLMUID");

                entity.HasOne(d => d.TaxCode)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.TaxCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SupplierTaxCodeID");
            });

            modelBuilder.Entity<TabletChange>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.FieldId).HasColumnName("FieldID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewValue).HasColumnType("varchar(max)");

                entity.Property(e => e.OldValue).HasColumnType("varchar(max)");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.TabletChange)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletChange_MetadataField");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TabletChange)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletChange_User");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.TabletChange)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletChange_MetadataRecord");
            });

            modelBuilder.Entity<TabletError>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TabletError)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletError_LMUser");
            });

            modelBuilder.Entity<TabletOrdersQueue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ErrorDetails).HasColumnType("varchar(max)");

                entity.Property(e => e.ErrorMessage).HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Processed).HasDefaultValueSql("0");

                entity.Property(e => e.TenderId).HasColumnName("TenderID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TabletOrdersQueue)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletOrdersQueue_User");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TabletOrdersQueue)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TabletOrdersQueue_Order");

                entity.HasOne(d => d.Tender)
                    .WithMany(p => p.TabletOrdersQueue)
                    .HasForeignKey(d => d.TenderId)
                    .HasConstraintName("FK_TabletOrdersQueue_Tender");
            });

            modelBuilder.Entity<TargetSpecies>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TargetSpecies)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TargetSpeciesLMUID");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Label).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.Src2FieldName).HasColumnType("varchar(max)");

                entity.Property(e => e.Src2RecordId).HasColumnName("Src2RecordID");

                entity.Property(e => e.SrcFieldName).HasColumnType("varchar(max)");

                entity.Property(e => e.SrcRecordId).HasColumnName("SrcRecordID");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .HasConstraintName("FK_TaskAcquisitionUnitID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskTaskCategoryID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_TaskLMUID");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .HasConstraintName("FK_TaskManagementUnitID");
            });

            modelBuilder.Entity<TaskCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TaskCategory)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskCategoryLMUID");
            });

            modelBuilder.Entity<TaskRow>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.AcquisitionUnitName).HasColumnType("varchar(max)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.DeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Label).HasColumnType("varchar(max)");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.Property(e => e.ManagementUnitName).HasColumnType("varchar(max)");

                entity.Property(e => e.ManagerName).HasColumnType("varchar(max)");

                entity.Property(e => e.Notes).HasColumnType("varchar(max)");

                entity.Property(e => e.RegionName).HasColumnType("varchar(max)");

                entity.Property(e => e.Src2FieldName).HasColumnType("varchar(max)");

                entity.Property(e => e.Src2RecordId).HasColumnName("Src2RecordID");

                entity.Property(e => e.SrcFieldName).HasColumnType("varchar(max)");

                entity.Property(e => e.SrcRecordId).HasColumnName("SrcRecordID");
            });

            modelBuilder.Entity<TaxCode>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Vatcode)
                    .IsRequired()
                    .HasColumnName("VATCode")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Vatrate).HasColumnName("VATRate");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TaxCode)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaxCodeLMUID");
            });

            modelBuilder.Entity<Tender>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ReturnedByDate).HasColumnType("datetime");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TenderLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TenderLMUID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Tender)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_TenderOrderID");

                entity.HasOne(d => d.ReturnedToUserNavigation)
                    .WithMany(p => p.TenderReturnedToUserNavigation)
                    .HasForeignKey(d => d.ReturnedToUser)
                    .HasConstraintName("FK_TenderReturnedToUser");
            });

            modelBuilder.Entity<Tenure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Tenure)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TenureLMUID");
            });

            modelBuilder.Entity<TerrainType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TerrainType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TerrainTypeLMUID");
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.Theme)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeLMUID");
            });

            modelBuilder.Entity<ThirdPartyAgreement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ThirdPartyAgreement)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThirdPartyAgreementLMUID");
            });

            modelBuilder.Entity<ThirdPartyRights>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.AgreementFromDate).HasColumnType("datetime");

                entity.Property(e => e.AgreementId).HasColumnName("AgreementID");

                entity.Property(e => e.AgreementWith).HasColumnType("varchar(max)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.CurrentPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ForecastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ForecastReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.InitialEnquiryDate).HasColumnType("datetime");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.MtmapprovalDate)
                    .HasColumnName("MTMApprovalDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtmapprovalTargetDate)
                    .HasColumnName("MTMApprovalTargetDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseReceivedTargetDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.SouthernElectricDate).HasColumnType("datetime");

                entity.Property(e => e.SouthernElectricTargetDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Wtdate)
                    .HasColumnName("WTDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WttargetDate)
                    .HasColumnName("WTTargetDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.ThirdPartyRightsNavigation)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThirdPartyRightsAcquisitionUnitID");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.ThirdPartyRights)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_ThirdPartyRightsThirdPartyAgreementID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ThirdPartyRights)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThirdPartyRightsLMUID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ThirdPartyRights)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ThirdPartyRightsThirdPartyServiceID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ThirdPartyRights)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ThirdPartyRightsThirdPartyTypeID");
            });

            modelBuilder.Entity<ThirdPartyService>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ThirdPartyService)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThirdPartyServiceLMUID");
            });

            modelBuilder.Entity<ThirdPartyType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.ThirdPartyType)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThirdPartyTypeLMUID");
            });

            modelBuilder.Entity<TreePlanting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Completed).HasDefaultValueSql("0");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlantedById)
                    .HasColumnName("PlantedByID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PlantingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PlantingTypeId)
                    .HasColumnName("PlantingTypeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubCompartmentId)
                    .HasColumnName("SubCompartmentID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SuitableToBeSold).HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TreePlanting)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingLMUID");

                entity.HasOne(d => d.PlantedBy)
                    .WithMany(p => p.TreePlanting)
                    .HasForeignKey(d => d.PlantedById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingPlantedByID");

                entity.HasOne(d => d.PlantingType)
                    .WithMany(p => p.TreePlanting)
                    .HasForeignKey(d => d.PlantingTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingPlantingTypeID");

                entity.HasOne(d => d.SubCompartment)
                    .WithMany(p => p.TreePlanting)
                    .HasForeignKey(d => d.SubCompartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingSubCompartmentID");
            });

            modelBuilder.Entity<TreePlantingDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.TerrainTypeId).HasColumnName("TerrainTypeID");

                entity.Property(e => e.TreePlantingId).HasColumnName("TreePlantingID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TreePlantingDetail)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingDetailLMUID");

                entity.HasOne(d => d.TreePlanting)
                    .WithMany(p => p.TreePlantingDetails)
                    .HasForeignKey(d => d.TreePlantingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingDetail_TreePlanting");

                entity.HasOne(d => d.TerrainType)
                    .WithMany(p => p.TreePlantingDetails)
                    .HasForeignKey(d => d.TerrainTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingDetail_TerrainType");

                entity.HasOne(d => d.PlantingAccessType)
                    .WithMany(p => p.TreePlantingDetails)
                    .HasForeignKey(d => d.AccessTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TreePlantingDetail_PlantingAccessType");                
            });

            modelBuilder.Entity<TypeOfInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.EvaluationTypeId).HasColumnName("EvaluationTypeID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EvaluationType)
                    .WithMany(p => p.TypeOfInformation)
                    .HasForeignKey(d => d.EvaluationTypeId)
                    .HasConstraintName("FK_TypeOfInformation_EvaluationType");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.TypeOfInformation)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TypeOfInformationLMUID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorisationLevelId).HasColumnName("AuthorisationLevelID");

                entity.Property(e => e.ComputerName)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DisplayName)
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Email).HasColumnType("varchar(max)");

                entity.Property(e => e.FirstRun).HasDefaultValueSql("0");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.Lnrdt)
                    .HasColumnName("LNRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LoggedOn).HasDefaultValueSql("0");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasColumnType("varchar(max)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SecurityToken).HasDefaultValueSql("0");

                entity.HasOne(d => d.AuthorisationLevelNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.AuthorisationLevelId)
                    .HasConstraintName("FK_UserAuthorisationLevelID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.InverseLmu)
                    .HasForeignKey(d => d.Lmuid)
                    .HasConstraintName("FK_UserLMUID");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.RoleId, e.RegionId, e.CountryId })
                    .HasName("IX_UserRole")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("CountryID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasColumnName("RegionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_Country");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_Region");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<VatrateLock>(entity =>
            {
                entity.ToTable("VATRateLock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.ExpenditureTaxCodeId).HasColumnName("ExpenditureTaxCodeID");

                entity.Property(e => e.IncomeTaxCodeId).HasColumnName("IncomeTaxCodeID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.ManagementUnitId).HasColumnName("ManagementUnitID");

                entity.HasOne(d => d.ExpenditureTaxCode)
                    .WithMany(p => p.VatrateLockExpenditureTaxCode)
                    .HasForeignKey(d => d.ExpenditureTaxCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VATRateLock_ExpenditureTaxCode");

                entity.HasOne(d => d.IncomeTaxCode)
                    .WithMany(p => p.VatrateLockIncomeTaxCode)
                    .HasForeignKey(d => d.IncomeTaxCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VATRateLock_IncomeTaxCode");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.VatrateLock)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VATRateLock_User");

                entity.HasOne(d => d.ManagementUnit)
                    .WithMany(p => p.VatrateLock)
                    .HasForeignKey(d => d.ManagementUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VATRateLock_ManagementUnit");
            });

            modelBuilder.Entity<WayPublicRights>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcquisitionUnitId).HasColumnName("AcquisitionUnitID");

                entity.Property(e => e.BridlewayDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.Comments).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FootpathDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.HasBridleway).HasDefaultValueSql("0");

                entity.Property(e => e.HasFootpath).HasDefaultValueSql("0");

                entity.Property(e => e.HasOther).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.Property(e => e.OtherDescription).HasColumnType("varchar(max)");

                entity.HasOne(d => d.AcquisitionUnit)
                    .WithMany(p => p.WayPublicRights)
                    .HasForeignKey(d => d.AcquisitionUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WayPublicRightsAcquisitionUnitID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WayPublicRights)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WayPublicRightsLMUID");
            });

            modelBuilder.Entity<WoodlandConditionDafor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WoodlandConditionDafor)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionDafor_LMUID");
            });

            modelBuilder.Entity<WoodlandConditionExtension>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaAwha)
                    .HasColumnName("AreaAWHa")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.AreaHa).HasDefaultValueSql("0.0");

                entity.Property(e => e.ChangeInAreaAwsinceLastSurveyHa)
                    .HasColumnName("ChangeInAreaAWSinceLastSurveyHa")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.ChangeInAreaSinceLastSurveyHa).HasDefaultValueSql("0.0");

                entity.Property(e => e.ConclusionsAndRecommendations).HasColumnType("varchar(max)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.FeatureMonitoringId).HasColumnName("FeatureMonitoringID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Surveyor).HasColumnType("varchar(max)");

                entity.HasOne(d => d.FeatureMonitoring)
                    .WithMany(p => p.WoodlandConditionExtension)
                    .HasForeignKey(d => d.FeatureMonitoringId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionExtension_FeatureMonitoring");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WoodlandConditionExtension)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionExtension_LMUID");
            });

            modelBuilder.Entity<WoodlandConditionStratum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WoodlandConditionStratum)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionStratum_LMUID");
            });

            modelBuilder.Entity<WoodlandConditionSubSection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddeerId).HasColumnName("ADDeerID");

                entity.Property(e => e.AddeerPlot1Id).HasColumnName("ADDeerPlot1ID");

                entity.Property(e => e.AddeerPlot2Id).HasColumnName("ADDeerPlot2ID");

                entity.Property(e => e.AddeerPlot3Id).HasColumnName("ADDeerPlot3ID");

                entity.Property(e => e.AddeerPlot4Id).HasColumnName("ADDeerPlot4ID");

                entity.Property(e => e.AddeerPlot5Id).HasColumnName("ADDeerPlot5ID");

                entity.Property(e => e.AdinterventionAchievable)
                    .HasColumnName("ADInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdinterventionDesirable)
                    .HasColumnName("ADInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdnotesActions)
                    .HasColumnName("ADNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.AdotherId).HasColumnName("ADOtherID");

                entity.Property(e => e.AdotherPlot1Id).HasColumnName("ADOtherPlot1ID");

                entity.Property(e => e.AdotherPlot2Id).HasColumnName("ADOtherPlot2ID");

                entity.Property(e => e.AdotherPlot3Id).HasColumnName("ADOtherPlot3ID");

                entity.Property(e => e.AdotherPlot4Id).HasColumnName("ADOtherPlot4ID");

                entity.Property(e => e.AdotherPlot5Id).HasColumnName("ADOtherPlot5ID");

                entity.Property(e => e.AdrabBitsId).HasColumnName("ADRabBITsID");

                entity.Property(e => e.AdrabBitsPlot1Id).HasColumnName("ADRabBITsPlot1ID");

                entity.Property(e => e.AdrabBitsPlot2Id).HasColumnName("ADRabBITsPlot2ID");

                entity.Property(e => e.AdrabBitsPlot3Id).HasColumnName("ADRabBITsPlot3ID");

                entity.Property(e => e.AdrabBitsPlot4Id).HasColumnName("ADRabBITsPlot4ID");

                entity.Property(e => e.AdrabBitsPlot5Id).HasColumnName("ADRabBITsPlot5ID");

                entity.Property(e => e.AdsquirrelsId).HasColumnName("ADSquirrelsID");

                entity.Property(e => e.AdsquirrelsPlot1Id).HasColumnName("ADSquirrelsPlot1ID");

                entity.Property(e => e.AdsquirrelsPlot2Id).HasColumnName("ADSquirrelsPlot2ID");

                entity.Property(e => e.AdsquirrelsPlot3Id).HasColumnName("ADSquirrelsPlot3ID");

                entity.Property(e => e.AdsquirrelsPlot4Id).HasColumnName("ADSquirrelsPlot4ID");

                entity.Property(e => e.AdsquirrelsPlot5Id).HasColumnName("ADSquirrelsPlot5ID");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Cruid)
                    .HasColumnName("CRUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Deleted).HasDefaultValueSql("0");

                entity.Property(e => e.DfallenId).HasColumnName("DFallenID");

                entity.Property(e => e.DfallenPlot1Id).HasColumnName("DFallenPlot1ID");

                entity.Property(e => e.DfallenPlot2Id).HasColumnName("DFallenPlot2ID");

                entity.Property(e => e.DfallenPlot3Id).HasColumnName("DFallenPlot3ID");

                entity.Property(e => e.DfallenPlot4Id).HasColumnName("DFallenPlot4ID");

                entity.Property(e => e.DfallenPlot5Id).HasColumnName("DFallenPlot5ID");

                entity.Property(e => e.DinterventionAchievable)
                    .HasColumnName("DInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DinterventionDesirable)
                    .HasColumnName("DInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.DnotesActions)
                    .HasColumnName("DNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.DstandingId).HasColumnName("DStandingID");

                entity.Property(e => e.DstandingPlot1Id).HasColumnName("DStandingPlot1ID");

                entity.Property(e => e.DstandingPlot2Id).HasColumnName("DStandingPlot2ID");

                entity.Property(e => e.DstandingPlot3Id).HasColumnName("DStandingPlot3ID");

                entity.Property(e => e.DstandingPlot4Id).HasColumnName("DStandingPlot4ID");

                entity.Property(e => e.DstandingPlot5Id).HasColumnName("DStandingPlot5ID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsId).HasColumnName("FAncientWoodlandPlantsSpecialistsID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsPlot1Id).HasColumnName("FAncientWoodlandPlantsSpecialistsPlot1ID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsPlot2Id).HasColumnName("FAncientWoodlandPlantsSpecialistsPlot2ID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsPlot3Id).HasColumnName("FAncientWoodlandPlantsSpecialistsPlot3ID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsPlot4Id).HasColumnName("FAncientWoodlandPlantsSpecialistsPlot4ID");

                entity.Property(e => e.FancientWoodlandPlantsSpecialistsPlot5Id).HasColumnName("FAncientWoodlandPlantsSpecialistsPlot5ID");

                entity.Property(e => e.FcoarseVegetationId).HasColumnName("FCoarseVegetationID");

                entity.Property(e => e.FcoarseVegetationPlot1Id).HasColumnName("FCoarseVegetationPlot1ID");

                entity.Property(e => e.FcoarseVegetationPlot2Id).HasColumnName("FCoarseVegetationPlot2ID");

                entity.Property(e => e.FcoarseVegetationPlot3Id).HasColumnName("FCoarseVegetationPlot3ID");

                entity.Property(e => e.FcoarseVegetationPlot4Id).HasColumnName("FCoarseVegetationPlot4ID");

                entity.Property(e => e.FcoarseVegetationPlot5Id).HasColumnName("FCoarseVegetationPlot5ID");

                entity.Property(e => e.FeatureMonitoringId).HasColumnName("FeatureMonitoringID");

                entity.Property(e => e.FinterventionAchievable)
                    .HasColumnName("FInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinterventionDesirable)
                    .HasColumnName("FInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FnoVegetationId).HasColumnName("FNoVegetationID");

                entity.Property(e => e.FnoVegetationPlot1Id).HasColumnName("FNoVegetationPlot1ID");

                entity.Property(e => e.FnoVegetationPlot2Id).HasColumnName("FNoVegetationPlot2ID");

                entity.Property(e => e.FnoVegetationPlot3Id).HasColumnName("FNoVegetationPlot3ID");

                entity.Property(e => e.FnoVegetationPlot4Id).HasColumnName("FNoVegetationPlot4ID");

                entity.Property(e => e.FnoVegetationPlot5Id).HasColumnName("FNoVegetationPlot5ID");

                entity.Property(e => e.FnotesActions)
                    .HasColumnName("FNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.FotherNativePlantsId).HasColumnName("FOtherNativePlantsID");

                entity.Property(e => e.FotherNativePlantsPlot1Id).HasColumnName("FOtherNativePlantsPlot1ID");

                entity.Property(e => e.FotherNativePlantsPlot2Id).HasColumnName("FOtherNativePlantsPlot2ID");

                entity.Property(e => e.FotherNativePlantsPlot3Id).HasColumnName("FOtherNativePlantsPlot3ID");

                entity.Property(e => e.FotherNativePlantsPlot4Id).HasColumnName("FOtherNativePlantsPlot4ID");

                entity.Property(e => e.FotherNativePlantsPlot5Id).HasColumnName("FOtherNativePlantsPlot5ID");

                entity.Property(e => e.FotherPlantsId).HasColumnName("FOtherPlantsID");

                entity.Property(e => e.FotherPlantsPlot1Id).HasColumnName("FOtherPlantsPlot1ID");

                entity.Property(e => e.FotherPlantsPlot2Id).HasColumnName("FOtherPlantsPlot2ID");

                entity.Property(e => e.FotherPlantsPlot3Id).HasColumnName("FOtherPlantsPlot3ID");

                entity.Property(e => e.FotherPlantsPlot4Id).HasColumnName("FOtherPlantsPlot4ID");

                entity.Property(e => e.FotherPlantsPlot5Id).HasColumnName("FOtherPlantsPlot5ID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsId).HasColumnName("FOtherWoodlandPlantsGeneralistsID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsPlot1Id).HasColumnName("FOtherWoodlandPlantsGeneralistsPlot1ID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsPlot2Id).HasColumnName("FOtherWoodlandPlantsGeneralistsPlot2ID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsPlot3Id).HasColumnName("FOtherWoodlandPlantsGeneralistsPlot3ID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsPlot4Id).HasColumnName("FOtherWoodlandPlantsGeneralistsPlot4ID");

                entity.Property(e => e.FotherWoodlandPlantsGeneralistsPlot5Id).HasColumnName("FOtherWoodlandPlantsGeneralistsPlot5ID");

                entity.Property(e => e.HicontinuousImpactsId).HasColumnName("HIContinuousImpactsID");

                entity.Property(e => e.HicontinuousImpactsPlot1Id).HasColumnName("HIContinuousImpactsPlot1ID");

                entity.Property(e => e.HicontinuousImpactsPlot2Id).HasColumnName("HIContinuousImpactsPlot2ID");

                entity.Property(e => e.HicontinuousImpactsPlot3Id).HasColumnName("HIContinuousImpactsPlot3ID");

                entity.Property(e => e.HicontinuousImpactsPlot4Id).HasColumnName("HIContinuousImpactsPlot4ID");

                entity.Property(e => e.HicontinuousImpactsPlot5Id).HasColumnName("HIContinuousImpactsPlot5ID");

                entity.Property(e => e.HiinterventionAchievable)
                    .HasColumnName("HIInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HiinterventionDesirable)
                    .HasColumnName("HIInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HinotesActions)
                    .HasColumnName("HINotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.HioneOffImpactsId).HasColumnName("HIOneOffImpactsID");

                entity.Property(e => e.HioneOffImpactsPlot1Id).HasColumnName("HIOneOffImpactsPlot1ID");

                entity.Property(e => e.HioneOffImpactsPlot2Id).HasColumnName("HIOneOffImpactsPlot2ID");

                entity.Property(e => e.HioneOffImpactsPlot3Id).HasColumnName("HIOneOffImpactsPlot3ID");

                entity.Property(e => e.HioneOffImpactsPlot4Id).HasColumnName("HIOneOffImpactsPlot4ID");

                entity.Property(e => e.HioneOffImpactsPlot5Id).HasColumnName("HIOneOffImpactsPlot5ID");

                entity.Property(e => e.IhimalayanBalsamId).HasColumnName("IHimalayanBalsamID");

                entity.Property(e => e.IhimalayanBalsamPlot1Id).HasColumnName("IHimalayanBalsamPlot1ID");

                entity.Property(e => e.IhimalayanBalsamPlot2Id).HasColumnName("IHimalayanBalsamPlot2ID");

                entity.Property(e => e.IhimalayanBalsamPlot3Id).HasColumnName("IHimalayanBalsamPlot3ID");

                entity.Property(e => e.IhimalayanBalsamPlot4Id).HasColumnName("IHimalayanBalsamPlot4ID");

                entity.Property(e => e.IhimalayanBalsamPlot5Id).HasColumnName("IHimalayanBalsamPlot5ID");

                entity.Property(e => e.IinterventionAchievable)
                    .HasColumnName("IInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IinterventionDesirable)
                    .HasColumnName("IInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IjapaneseKnotweedId).HasColumnName("IJapaneseKnotweedID");

                entity.Property(e => e.IjapaneseKnotweedPlot1Id).HasColumnName("IJapaneseKnotweedPlot1ID");

                entity.Property(e => e.IjapaneseKnotweedPlot2Id).HasColumnName("IJapaneseKnotweedPlot2ID");

                entity.Property(e => e.IjapaneseKnotweedPlot3Id).HasColumnName("IJapaneseKnotweedPlot3ID");

                entity.Property(e => e.IjapaneseKnotweedPlot4Id).HasColumnName("IJapaneseKnotweedPlot4ID");

                entity.Property(e => e.IjapaneseKnotweedPlot5Id).HasColumnName("IJapaneseKnotweedPlot5ID");

                entity.Property(e => e.InotesActions)
                    .HasColumnName("INotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.IotherId).HasColumnName("IOtherID");

                entity.Property(e => e.IotherPlot1Id).HasColumnName("IOtherPlot1ID");

                entity.Property(e => e.IotherPlot2Id).HasColumnName("IOtherPlot2ID");

                entity.Property(e => e.IotherPlot3Id).HasColumnName("IOtherPlot3ID");

                entity.Property(e => e.IotherPlot4Id).HasColumnName("IOtherPlot4ID");

                entity.Property(e => e.IotherPlot5Id).HasColumnName("IOtherPlot5ID");

                entity.Property(e => e.IrhododendronId).HasColumnName("IRhododendronID");

                entity.Property(e => e.IrhododendronPlot1Id).HasColumnName("IRhododendronPlot1ID");

                entity.Property(e => e.IrhododendronPlot2Id).HasColumnName("IRhododendronPlot2ID");

                entity.Property(e => e.IrhododendronPlot3Id).HasColumnName("IRhododendronPlot3ID");

                entity.Property(e => e.IrhododendronPlot4Id).HasColumnName("IRhododendronPlot4ID");

                entity.Property(e => e.IrhododendronPlot5Id).HasColumnName("IRhododendronPlot5ID");

                entity.Property(e => e.IsDefaultValue).HasDefaultValueSql("0");

                entity.Property(e => e.IsHistorical).HasDefaultValueSql("0");

                entity.Property(e => e.IsProtected).HasDefaultValueSql("0");

                entity.Property(e => e.KeyFeatureId).HasColumnName("KeyFeatureID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lmuid)
                    .HasColumnName("LMUID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringId).HasColumnName("LSRCoppiceRegrowthOrSuckeringID");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringPlot1Id).HasColumnName("LSRCoppiceRegrowthOrSuckeringPlot1ID");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringPlot2Id).HasColumnName("LSRCoppiceRegrowthOrSuckeringPlot2ID");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringPlot3Id).HasColumnName("LSRCoppiceRegrowthOrSuckeringPlot3ID");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringPlot4Id).HasColumnName("LSRCoppiceRegrowthOrSuckeringPlot4ID");

                entity.Property(e => e.LsrcoppiceRegrowthOrSuckeringPlot5Id).HasColumnName("LSRCoppiceRegrowthOrSuckeringPlot5ID");

                entity.Property(e => e.LsrinterventionAchievable)
                    .HasColumnName("LSRInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LsrinterventionDesirable)
                    .HasColumnName("LSRInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LsrnotesActions)
                    .HasColumnName("LSRNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.LsrsaplingsGreater100cmId).HasColumnName("LSRSaplingsGreater100cmID");

                entity.Property(e => e.LsrsaplingsGreater100cmPlot1Id).HasColumnName("LSRSaplingsGreater100cmPlot1ID");

                entity.Property(e => e.LsrsaplingsGreater100cmPlot2Id).HasColumnName("LSRSaplingsGreater100cmPlot2ID");

                entity.Property(e => e.LsrsaplingsGreater100cmPlot3Id).HasColumnName("LSRSaplingsGreater100cmPlot3ID");

                entity.Property(e => e.LsrsaplingsGreater100cmPlot4Id).HasColumnName("LSRSaplingsGreater100cmPlot4ID");

                entity.Property(e => e.LsrsaplingsGreater100cmPlot5Id).HasColumnName("LSRSaplingsGreater100cmPlot5ID");

                entity.Property(e => e.Lsrseedlings10100cmId).HasColumnName("LSRSeedlings10_100cmID");

                entity.Property(e => e.Lsrseedlings10100cmPlot1Id).HasColumnName("LSRSeedlings10_100cmPlot1ID");

                entity.Property(e => e.Lsrseedlings10100cmPlot2Id).HasColumnName("LSRSeedlings10_100cmPlot2ID");

                entity.Property(e => e.Lsrseedlings10100cmPlot3Id).HasColumnName("LSRSeedlings10_100cmPlot3ID");

                entity.Property(e => e.Lsrseedlings10100cmPlot4Id).HasColumnName("LSRSeedlings10_100cmPlot4ID");

                entity.Property(e => e.Lsrseedlings10100cmPlot5Id).HasColumnName("LSRSeedlings10_100cmPlot5ID");

                entity.Property(e => e.LsrseedlingsLess10cmId).HasColumnName("LSRSeedlingsLess10cmID");

                entity.Property(e => e.LsrseedlingsLess10cmPlot1Id).HasColumnName("LSRSeedlingsLess10cmPlot1ID");

                entity.Property(e => e.LsrseedlingsLess10cmPlot2Id).HasColumnName("LSRSeedlingsLess10cmPlot2ID");

                entity.Property(e => e.LsrseedlingsLess10cmPlot3Id).HasColumnName("LSRSeedlingsLess10cmPlot3ID");

                entity.Property(e => e.LsrseedlingsLess10cmPlot4Id).HasColumnName("LSRSeedlingsLess10cmPlot4ID");

                entity.Property(e => e.LsrseedlingsLess10cmPlot5Id).HasColumnName("LSRSeedlingsLess10cmPlot5ID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringId).HasColumnName("LTRCoppiceRegrowthOrSuckeringID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringPlot1Id).HasColumnName("LTRCoppiceRegrowthOrSuckeringPlot1ID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringPlot2Id).HasColumnName("LTRCoppiceRegrowthOrSuckeringPlot2ID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringPlot3Id).HasColumnName("LTRCoppiceRegrowthOrSuckeringPlot3ID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringPlot4Id).HasColumnName("LTRCoppiceRegrowthOrSuckeringPlot4ID");

                entity.Property(e => e.LtrcoppiceRegrowthOrSuckeringPlot5Id).HasColumnName("LTRCoppiceRegrowthOrSuckeringPlot5ID");

                entity.Property(e => e.LtrinterventionAchievable)
                    .HasColumnName("LTRInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtrinterventionDesirable)
                    .HasColumnName("LTRInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LtrnotesActions)
                    .HasColumnName("LTRNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.LtrsaplingsGreater100cmId).HasColumnName("LTRSaplingsGreater100cmID");

                entity.Property(e => e.LtrsaplingsGreater100cmPlot1Id).HasColumnName("LTRSaplingsGreater100cmPlot1ID");

                entity.Property(e => e.LtrsaplingsGreater100cmPlot2Id).HasColumnName("LTRSaplingsGreater100cmPlot2ID");

                entity.Property(e => e.LtrsaplingsGreater100cmPlot3Id).HasColumnName("LTRSaplingsGreater100cmPlot3ID");

                entity.Property(e => e.LtrsaplingsGreater100cmPlot4Id).HasColumnName("LTRSaplingsGreater100cmPlot4ID");

                entity.Property(e => e.LtrsaplingsGreater100cmPlot5Id).HasColumnName("LTRSaplingsGreater100cmPlot5ID");

                entity.Property(e => e.Ltrseedlings10100cmId).HasColumnName("LTRSeedlings10_100cmID");

                entity.Property(e => e.Ltrseedlings10100cmPlot1Id).HasColumnName("LTRSeedlings10_100cmPlot1ID");

                entity.Property(e => e.Ltrseedlings10100cmPlot2Id).HasColumnName("LTRSeedlings10_100cmPlot2ID");

                entity.Property(e => e.Ltrseedlings10100cmPlot3Id).HasColumnName("LTRSeedlings10_100cmPlot3ID");

                entity.Property(e => e.Ltrseedlings10100cmPlot4Id).HasColumnName("LTRSeedlings10_100cmPlot4ID");

                entity.Property(e => e.Ltrseedlings10100cmPlot5Id).HasColumnName("LTRSeedlings10_100cmPlot5ID");

                entity.Property(e => e.LtrseedlingsLess10cmId).HasColumnName("LTRSeedlingsLess10cmID");

                entity.Property(e => e.LtrseedlingsLess10cmPlot1Id).HasColumnName("LTRSeedlingsLess10cmPlot1ID");

                entity.Property(e => e.LtrseedlingsLess10cmPlot2Id).HasColumnName("LTRSeedlingsLess10cmPlot2ID");

                entity.Property(e => e.LtrseedlingsLess10cmPlot3Id).HasColumnName("LTRSeedlingsLess10cmPlot3ID");

                entity.Property(e => e.LtrseedlingsLess10cmPlot4Id).HasColumnName("LTRSeedlingsLess10cmPlot4ID");

                entity.Property(e => e.LtrseedlingsLess10cmPlot5Id).HasColumnName("LTRSeedlingsLess10cmPlot5ID");

                entity.Property(e => e.NotesAction).HasColumnType("varchar(max)");

                entity.Property(e => e.OverallConclusionsAndRecommendations).HasColumnType("varchar(max)");

                entity.Property(e => e.RssdominatedByOneOrTwoSpp)
                    .HasColumnName("RSSDominatedByOneOrTwoSPP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssdominatedByOneOrTwoSppplot1)
                    .HasColumnName("RSSDominatedByOneOrTwoSPPPlot1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssdominatedByOneOrTwoSppplot2)
                    .HasColumnName("RSSDominatedByOneOrTwoSPPPlot2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssdominatedByOneOrTwoSppplot3)
                    .HasColumnName("RSSDominatedByOneOrTwoSPPPlot3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssdominatedByOneOrTwoSppplot4)
                    .HasColumnName("RSSDominatedByOneOrTwoSPPPlot4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssdominatedByOneOrTwoSppplot5)
                    .HasColumnName("RSSDominatedByOneOrTwoSPPPlot5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssinterventionAchievable)
                    .HasColumnName("RSSInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssinterventionDesirable)
                    .HasColumnName("RSSInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RssnativesNumberPresent).HasColumnName("RSSNativesNumberPresent");

                entity.Property(e => e.RssnativesNumberPresentPlot1).HasColumnName("RSSNativesNumberPresentPlot1");

                entity.Property(e => e.RssnativesNumberPresentPlot2).HasColumnName("RSSNativesNumberPresentPlot2");

                entity.Property(e => e.RssnativesNumberPresentPlot3).HasColumnName("RSSNativesNumberPresentPlot3");

                entity.Property(e => e.RssnativesNumberPresentPlot4).HasColumnName("RSSNativesNumberPresentPlot4");

                entity.Property(e => e.RssnativesNumberPresentPlot5).HasColumnName("RSSNativesNumberPresentPlot5");

                entity.Property(e => e.RssnonNativesNumberPresent).HasColumnName("RSSNonNativesNumberPresent");

                entity.Property(e => e.RssnonNativesNumberPresentPlot1).HasColumnName("RSSNonNativesNumberPresentPlot1");

                entity.Property(e => e.RssnonNativesNumberPresentPlot2).HasColumnName("RSSNonNativesNumberPresentPlot2");

                entity.Property(e => e.RssnonNativesNumberPresentPlot3).HasColumnName("RSSNonNativesNumberPresentPlot3");

                entity.Property(e => e.RssnonNativesNumberPresentPlot4).HasColumnName("RSSNonNativesNumberPresentPlot4");

                entity.Property(e => e.RssnonNativesNumberPresentPlot5).HasColumnName("RSSNonNativesNumberPresentPlot5");

                entity.Property(e => e.RssnotesActions)
                    .HasColumnName("RSSNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.RtsdominatedByOneOrTwoSpp)
                    .HasColumnName("RTSDominatedByOneOrTwoSPP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsdominatedByOneOrTwoSppplot1)
                    .HasColumnName("RTSDominatedByOneOrTwoSPPPlot1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsdominatedByOneOrTwoSppplot2)
                    .HasColumnName("RTSDominatedByOneOrTwoSPPPlot2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsdominatedByOneOrTwoSppplot3)
                    .HasColumnName("RTSDominatedByOneOrTwoSPPPlot3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsdominatedByOneOrTwoSppplot4)
                    .HasColumnName("RTSDominatedByOneOrTwoSPPPlot4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsdominatedByOneOrTwoSppplot5)
                    .HasColumnName("RTSDominatedByOneOrTwoSPPPlot5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsinterventionAchievable)
                    .HasColumnName("RTSInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsinterventionDesirable)
                    .HasColumnName("RTSInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RtsnativesNumberPresent).HasColumnName("RTSNativesNumberPresent");

                entity.Property(e => e.RtsnativesNumberPresentPlot1).HasColumnName("RTSNativesNumberPresentPlot1");

                entity.Property(e => e.RtsnativesNumberPresentPlot2).HasColumnName("RTSNativesNumberPresentPlot2");

                entity.Property(e => e.RtsnativesNumberPresentPlot3).HasColumnName("RTSNativesNumberPresentPlot3");

                entity.Property(e => e.RtsnativesNumberPresentPlot4).HasColumnName("RTSNativesNumberPresentPlot4");

                entity.Property(e => e.RtsnativesNumberPresentPlot5).HasColumnName("RTSNativesNumberPresentPlot5");

                entity.Property(e => e.RtsnonNativesNumberPresent).HasColumnName("RTSNonNativesNumberPresent");

                entity.Property(e => e.RtsnonNativesNumberPresentPlot1).HasColumnName("RTSNonNativesNumberPresentPlot1");

                entity.Property(e => e.RtsnonNativesNumberPresentPlot2).HasColumnName("RTSNonNativesNumberPresentPlot2");

                entity.Property(e => e.RtsnonNativesNumberPresentPlot3).HasColumnName("RTSNonNativesNumberPresentPlot3");

                entity.Property(e => e.RtsnonNativesNumberPresentPlot4).HasColumnName("RTSNonNativesNumberPresentPlot4");

                entity.Property(e => e.RtsnonNativesNumberPresentPlot5).HasColumnName("RTSNonNativesNumberPresentPlot5");

                entity.Property(e => e.RtsnotesActions)
                    .HasColumnName("RTSNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SsdaforofCoverId)
                    .HasColumnName("SSDAFOROfCoverID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsdaforofCoverPlot1Id).HasColumnName("SSDAFOROfCoverPlot1ID");

                entity.Property(e => e.SsdaforofCoverPlot2Id).HasColumnName("SSDAFOROfCoverPlot2ID");

                entity.Property(e => e.SsdaforofCoverPlot3Id).HasColumnName("SSDAFOROfCoverPlot3ID");

                entity.Property(e => e.SsdaforofCoverPlot4Id).HasColumnName("SSDAFOROfCoverPlot4ID");

                entity.Property(e => e.SsdaforofCoverPlot5Id).HasColumnName("SSDAFOROfCoverPlot5ID");

                entity.Property(e => e.SsinterventionAchievable)
                    .HasColumnName("SSInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsinterventionDesirable)
                    .HasColumnName("SSInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsnativesNumberPresent).HasColumnName("SSNativesNumberPresent");

                entity.Property(e => e.SsnativesNumberPresentPlot1).HasColumnName("SSNativesNumberPresentPlot1");

                entity.Property(e => e.SsnativesNumberPresentPlot2).HasColumnName("SSNativesNumberPresentPlot2");

                entity.Property(e => e.SsnativesNumberPresentPlot3).HasColumnName("SSNativesNumberPresentPlot3");

                entity.Property(e => e.SsnativesNumberPresentPlot4).HasColumnName("SSNativesNumberPresentPlot4");

                entity.Property(e => e.SsnativesNumberPresentPlot5).HasColumnName("SSNativesNumberPresentPlot5");

                entity.Property(e => e.SsnonNativesNumberPresent).HasColumnName("SSNonNativesNumberPresent");

                entity.Property(e => e.SsnonNativesNumberPresentPlot1).HasColumnName("SSNonNativesNumberPresentPlot1");

                entity.Property(e => e.SsnonNativesNumberPresentPlot2).HasColumnName("SSNonNativesNumberPresentPlot2");

                entity.Property(e => e.SsnonNativesNumberPresentPlot3).HasColumnName("SSNonNativesNumberPresentPlot3");

                entity.Property(e => e.SsnonNativesNumberPresentPlot4).HasColumnName("SSNonNativesNumberPresentPlot4");

                entity.Property(e => e.SsnonNativesNumberPresentPlot5).HasColumnName("SSNonNativesNumberPresentPlot5");

                entity.Property(e => e.SsnotesActions)
                    .HasColumnName("SSNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSpp)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSppplot1)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPPPlot1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSppplot2)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPPPlot2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSppplot3)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPPPlot3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSppplot4)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPPPlot4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SsshrubLayerDominatedByOneOrTwoSppplot5)
                    .HasColumnName("SSShrubLayerDominatedByOneOrTwoSPPPlot5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StratumDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.StratumId).HasColumnName("StratumID");

                entity.Property(e => e.Ta100200yearsId).HasColumnName("TA100_200YearsID");

                entity.Property(e => e.Ta100200yearsPlot1Id).HasColumnName("TA100_200YearsPlot1ID");

                entity.Property(e => e.Ta100200yearsPlot2Id).HasColumnName("TA100_200YearsPlot2ID");

                entity.Property(e => e.Ta100200yearsPlot3Id).HasColumnName("TA100_200YearsPlot3ID");

                entity.Property(e => e.Ta100200yearsPlot4Id).HasColumnName("TA100_200YearsPlot4ID");

                entity.Property(e => e.Ta100200yearsPlot5Id).HasColumnName("TA100_200YearsPlot5ID");

                entity.Property(e => e.Ta2050yearsId).HasColumnName("TA20_50YearsID");

                entity.Property(e => e.Ta2050yearsPlot1Id).HasColumnName("TA20_50YearsPlot1ID");

                entity.Property(e => e.Ta2050yearsPlot2Id).HasColumnName("TA20_50YearsPlot2ID");

                entity.Property(e => e.Ta2050yearsPlot3Id).HasColumnName("TA20_50YearsPlot3ID");

                entity.Property(e => e.Ta2050yearsPlot4Id).HasColumnName("TA20_50YearsPlot4ID");

                entity.Property(e => e.Ta2050yearsPlot5Id).HasColumnName("TA20_50YearsPlot5ID");

                entity.Property(e => e.Ta20yearsId).HasColumnName("TA20YearsID");

                entity.Property(e => e.Ta20yearsPlot1Id).HasColumnName("TA20YearsPlot1ID");

                entity.Property(e => e.Ta20yearsPlot2Id).HasColumnName("TA20YearsPlot2ID");

                entity.Property(e => e.Ta20yearsPlot3Id).HasColumnName("TA20YearsPlot3ID");

                entity.Property(e => e.Ta20yearsPlot4Id).HasColumnName("TA20YearsPlot4ID");

                entity.Property(e => e.Ta20yearsPlot5Id).HasColumnName("TA20YearsPlot5ID");

                entity.Property(e => e.Ta50100yearsId).HasColumnName("TA50_100YearsID");

                entity.Property(e => e.Ta50100yearsPlot1Id).HasColumnName("TA50_100YearsPlot1ID");

                entity.Property(e => e.Ta50100yearsPlot2Id).HasColumnName("TA50_100YearsPlot2ID");

                entity.Property(e => e.Ta50100yearsPlot3Id).HasColumnName("TA50_100YearsPlot3ID");

                entity.Property(e => e.Ta50100yearsPlot4Id).HasColumnName("TA50_100YearsPlot4ID");

                entity.Property(e => e.Ta50100yearsPlot5Id).HasColumnName("TA50_100YearsPlot5ID");

                entity.Property(e => e.TainterventionAchievable)
                    .HasColumnName("TAInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TainterventionDesirable)
                    .HasColumnName("TAInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TanotesActions)
                    .HasColumnName("TANotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsId).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsID");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsPlot1Id).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsPlot1ID");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsPlot2Id).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsPlot2ID");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsPlot3Id).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsPlot3ID");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsPlot4Id).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsPlot4ID");

                entity.Property(e => e.TaveteranPollardsAncientCoppiceStoolsPlot5Id).HasColumnName("TAVeteranPollardsAncientCoppiceStoolsPlot5ID");

                entity.Property(e => e.ThinterventionAchievable)
                    .HasColumnName("THInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThinterventionDesirable)
                    .HasColumnName("THInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThnotesActions)
                    .HasColumnName("THNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ThnotifiablePestOrDiseaseId).HasColumnName("THNotifiablePestOrDiseaseID");

                entity.Property(e => e.ThnotifiablePestOrDiseasePlot1Id).HasColumnName("THNotifiablePestOrDiseasePlot1ID");

                entity.Property(e => e.ThnotifiablePestOrDiseasePlot2Id).HasColumnName("THNotifiablePestOrDiseasePlot2ID");

                entity.Property(e => e.ThnotifiablePestOrDiseasePlot3Id).HasColumnName("THNotifiablePestOrDiseasePlot3ID");

                entity.Property(e => e.ThnotifiablePestOrDiseasePlot4Id).HasColumnName("THNotifiablePestOrDiseasePlot4ID");

                entity.Property(e => e.ThnotifiablePestOrDiseasePlot5Id).HasColumnName("THNotifiablePestOrDiseasePlot5ID");

                entity.Property(e => e.ThotherDiseaseOrPestId).HasColumnName("THOtherDiseaseOrPestID");

                entity.Property(e => e.ThotherDiseaseOrPestPlot1Id).HasColumnName("THOtherDiseaseOrPestPlot1ID");

                entity.Property(e => e.ThotherDiseaseOrPestPlot2Id).HasColumnName("THOtherDiseaseOrPestPlot2ID");

                entity.Property(e => e.ThotherDiseaseOrPestPlot3Id).HasColumnName("THOtherDiseaseOrPestPlot3ID");

                entity.Property(e => e.ThotherDiseaseOrPestPlot4Id).HasColumnName("THOtherDiseaseOrPestPlot4ID");

                entity.Property(e => e.ThotherDiseaseOrPestPlot5Id).HasColumnName("THOtherDiseaseOrPestPlot5ID");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSpp)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSppplot1)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPPPlot1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSppplot2)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPPPlot2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSppplot3)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPPPlot3")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSppplot4)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPPPlot4")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TscanopyDominatedByOneOrTwoSppplot5)
                    .HasColumnName("TSCanopyDominatedByOneOrTwoSPPPlot5")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TsinterventionAchievable)
                    .HasColumnName("TSInterventionAchievable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TsinterventionDesirable)
                    .HasColumnName("TSInterventionDesirable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TsnativesNumberPresent).HasColumnName("TSNativesNumberPresent");

                entity.Property(e => e.TsnativesNumberPresentPlot1).HasColumnName("TSNativesNumberPresentPlot1");

                entity.Property(e => e.TsnativesNumberPresentPlot2).HasColumnName("TSNativesNumberPresentPlot2");

                entity.Property(e => e.TsnativesNumberPresentPlot3).HasColumnName("TSNativesNumberPresentPlot3");

                entity.Property(e => e.TsnativesNumberPresentPlot4).HasColumnName("TSNativesNumberPresentPlot4");

                entity.Property(e => e.TsnativesNumberPresentPlot5).HasColumnName("TSNativesNumberPresentPlot5");

                entity.Property(e => e.TsnonNativesNumberPresent).HasColumnName("TSNonNativesNumberPresent");

                entity.Property(e => e.TsnonNativesNumberPresentPlot1).HasColumnName("TSNonNativesNumberPresentPlot1");

                entity.Property(e => e.TsnonNativesNumberPresentPlot2).HasColumnName("TSNonNativesNumberPresentPlot2");

                entity.Property(e => e.TsnonNativesNumberPresentPlot3).HasColumnName("TSNonNativesNumberPresentPlot3");

                entity.Property(e => e.TsnonNativesNumberPresentPlot4).HasColumnName("TSNonNativesNumberPresentPlot4");

                entity.Property(e => e.TsnonNativesNumberPresentPlot5).HasColumnName("TSNonNativesNumberPresentPlot5");

                entity.Property(e => e.TsnotesActions)
                    .HasColumnName("TSNotesActions")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.WholeSite).HasDefaultValueSql("0");

                entity.HasOne(d => d.Addeer)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeer)
                    .HasForeignKey(d => d.AddeerId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerID");

                entity.HasOne(d => d.AddeerPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeerPlot1)
                    .HasForeignKey(d => d.AddeerPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerPlot1ID");

                entity.HasOne(d => d.AddeerPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeerPlot2)
                    .HasForeignKey(d => d.AddeerPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerPlot2ID");

                entity.HasOne(d => d.AddeerPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeerPlot3)
                    .HasForeignKey(d => d.AddeerPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerPlot3ID");

                entity.HasOne(d => d.AddeerPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeerPlot4)
                    .HasForeignKey(d => d.AddeerPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerPlot4ID");

                entity.HasOne(d => d.AddeerPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionAddeerPlot5)
                    .HasForeignKey(d => d.AddeerPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADDeerPlot5ID");

                entity.HasOne(d => d.Adother)
                    .WithMany(p => p.WoodlandConditionSubSectionAdother)
                    .HasForeignKey(d => d.AdotherId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherID");

                entity.HasOne(d => d.AdotherPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionAdotherPlot1)
                    .HasForeignKey(d => d.AdotherPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherPlot1ID");

                entity.HasOne(d => d.AdotherPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionAdotherPlot2)
                    .HasForeignKey(d => d.AdotherPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherPlot2ID");

                entity.HasOne(d => d.AdotherPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionAdotherPlot3)
                    .HasForeignKey(d => d.AdotherPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherPlot3ID");

                entity.HasOne(d => d.AdotherPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionAdotherPlot4)
                    .HasForeignKey(d => d.AdotherPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherPlot4ID");

                entity.HasOne(d => d.AdotherPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionAdotherPlot5)
                    .HasForeignKey(d => d.AdotherPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADOtherPlot5ID");

                entity.HasOne(d => d.AdrabBits)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBits)
                    .HasForeignKey(d => d.AdrabBitsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsID");

                entity.HasOne(d => d.AdrabBitsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBitsPlot1)
                    .HasForeignKey(d => d.AdrabBitsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsPlot1ID");

                entity.HasOne(d => d.AdrabBitsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBitsPlot2)
                    .HasForeignKey(d => d.AdrabBitsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsPlot2ID");

                entity.HasOne(d => d.AdrabBitsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBitsPlot3)
                    .HasForeignKey(d => d.AdrabBitsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsPlot3ID");

                entity.HasOne(d => d.AdrabBitsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBitsPlot4)
                    .HasForeignKey(d => d.AdrabBitsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsPlot4ID");

                entity.HasOne(d => d.AdrabBitsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionAdrabBitsPlot5)
                    .HasForeignKey(d => d.AdrabBitsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADRabBITsPlot5ID");

                entity.HasOne(d => d.Adsquirrels)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrels)
                    .HasForeignKey(d => d.AdsquirrelsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsID");

                entity.HasOne(d => d.AdsquirrelsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrelsPlot1)
                    .HasForeignKey(d => d.AdsquirrelsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsPlot1ID");

                entity.HasOne(d => d.AdsquirrelsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrelsPlot2)
                    .HasForeignKey(d => d.AdsquirrelsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsPlot2ID");

                entity.HasOne(d => d.AdsquirrelsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrelsPlot3)
                    .HasForeignKey(d => d.AdsquirrelsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsPlot3ID");

                entity.HasOne(d => d.AdsquirrelsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrelsPlot4)
                    .HasForeignKey(d => d.AdsquirrelsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsPlot4ID");

                entity.HasOne(d => d.AdsquirrelsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionAdsquirrelsPlot5)
                    .HasForeignKey(d => d.AdsquirrelsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_ADSquirrelsPlot5ID");

                entity.HasOne(d => d.Dfallen)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallen)
                    .HasForeignKey(d => d.DfallenId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenID");

                entity.HasOne(d => d.DfallenPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallenPlot1)
                    .HasForeignKey(d => d.DfallenPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenPlot1ID");

                entity.HasOne(d => d.DfallenPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallenPlot2)
                    .HasForeignKey(d => d.DfallenPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenPlot2ID");

                entity.HasOne(d => d.DfallenPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallenPlot3)
                    .HasForeignKey(d => d.DfallenPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenPlot3ID");

                entity.HasOne(d => d.DfallenPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallenPlot4)
                    .HasForeignKey(d => d.DfallenPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenPlot4ID");

                entity.HasOne(d => d.DfallenPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionDfallenPlot5)
                    .HasForeignKey(d => d.DfallenPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DFallenPlot5ID");

                entity.HasOne(d => d.Dstanding)
                    .WithMany(p => p.WoodlandConditionSubSectionDstanding)
                    .HasForeignKey(d => d.DstandingId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingID");

                entity.HasOne(d => d.DstandingPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionDstandingPlot1)
                    .HasForeignKey(d => d.DstandingPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingPlot1ID");

                entity.HasOne(d => d.DstandingPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionDstandingPlot2)
                    .HasForeignKey(d => d.DstandingPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingPlot2ID");

                entity.HasOne(d => d.DstandingPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionDstandingPlot3)
                    .HasForeignKey(d => d.DstandingPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingPlot3ID");

                entity.HasOne(d => d.DstandingPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionDstandingPlot4)
                    .HasForeignKey(d => d.DstandingPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingPlot4ID");

                entity.HasOne(d => d.DstandingPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionDstandingPlot5)
                    .HasForeignKey(d => d.DstandingPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_DStandingPlot5ID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialists)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialists)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialistsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot1)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsPlot1ID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialistsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot2)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsPlot2ID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialistsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot3)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsPlot3ID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialistsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot4)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsPlot4ID");

                entity.HasOne(d => d.FancientWoodlandPlantsSpecialistsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFancientWoodlandPlantsSpecialistsPlot5)
                    .HasForeignKey(d => d.FancientWoodlandPlantsSpecialistsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FAncientWoodlandPlantsSpecialistsPlot5ID");

                entity.HasOne(d => d.FcoarseVegetation)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetation)
                    .HasForeignKey(d => d.FcoarseVegetationId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationID");

                entity.HasOne(d => d.FcoarseVegetationPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetationPlot1)
                    .HasForeignKey(d => d.FcoarseVegetationPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationPlot1ID");

                entity.HasOne(d => d.FcoarseVegetationPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetationPlot2)
                    .HasForeignKey(d => d.FcoarseVegetationPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationPlot2ID");

                entity.HasOne(d => d.FcoarseVegetationPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetationPlot3)
                    .HasForeignKey(d => d.FcoarseVegetationPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationPlot3ID");

                entity.HasOne(d => d.FcoarseVegetationPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetationPlot4)
                    .HasForeignKey(d => d.FcoarseVegetationPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationPlot4ID");

                entity.HasOne(d => d.FcoarseVegetationPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFcoarseVegetationPlot5)
                    .HasForeignKey(d => d.FcoarseVegetationPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FCoarseVegetationPlot5ID");

                entity.HasOne(d => d.FeatureMonitoring)
                    .WithMany(p => p.WoodlandConditionSubSection)
                    .HasForeignKey(d => d.FeatureMonitoringId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FeatureMonitoring");

                entity.HasOne(d => d.FnoVegetation)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetation)
                    .HasForeignKey(d => d.FnoVegetationId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationID");

                entity.HasOne(d => d.FnoVegetationPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetationPlot1)
                    .HasForeignKey(d => d.FnoVegetationPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationPlot1ID");

                entity.HasOne(d => d.FnoVegetationPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetationPlot2)
                    .HasForeignKey(d => d.FnoVegetationPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationPlot2ID");

                entity.HasOne(d => d.FnoVegetationPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetationPlot3)
                    .HasForeignKey(d => d.FnoVegetationPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationPlot3ID");

                entity.HasOne(d => d.FnoVegetationPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetationPlot4)
                    .HasForeignKey(d => d.FnoVegetationPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationPlot4ID");

                entity.HasOne(d => d.FnoVegetationPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFnoVegetationPlot5)
                    .HasForeignKey(d => d.FnoVegetationPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FNoVegetationPlot5ID");

                entity.HasOne(d => d.FotherNativePlants)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlants)
                    .HasForeignKey(d => d.FotherNativePlantsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsID");

                entity.HasOne(d => d.FotherNativePlantsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlantsPlot1)
                    .HasForeignKey(d => d.FotherNativePlantsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsPlot1ID");

                entity.HasOne(d => d.FotherNativePlantsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlantsPlot2)
                    .HasForeignKey(d => d.FotherNativePlantsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsPlot2ID");

                entity.HasOne(d => d.FotherNativePlantsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlantsPlot3)
                    .HasForeignKey(d => d.FotherNativePlantsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsPlot3ID");

                entity.HasOne(d => d.FotherNativePlantsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlantsPlot4)
                    .HasForeignKey(d => d.FotherNativePlantsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsPlot4ID");

                entity.HasOne(d => d.FotherNativePlantsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherNativePlantsPlot5)
                    .HasForeignKey(d => d.FotherNativePlantsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherNativePlantsPlot5ID");

                entity.HasOne(d => d.FotherPlants)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlants)
                    .HasForeignKey(d => d.FotherPlantsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsID");

                entity.HasOne(d => d.FotherPlantsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlantsPlot1)
                    .HasForeignKey(d => d.FotherPlantsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsPlot1ID");

                entity.HasOne(d => d.FotherPlantsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlantsPlot2)
                    .HasForeignKey(d => d.FotherPlantsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsPlot2ID");

                entity.HasOne(d => d.FotherPlantsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlantsPlot3)
                    .HasForeignKey(d => d.FotherPlantsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsPlot3ID");

                entity.HasOne(d => d.FotherPlantsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlantsPlot4)
                    .HasForeignKey(d => d.FotherPlantsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsPlot4ID");

                entity.HasOne(d => d.FotherPlantsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherPlantsPlot5)
                    .HasForeignKey(d => d.FotherPlantsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherPlantsPlot5ID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralists)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralists)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralistsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot1)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsPlot1ID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralistsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot2)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsPlot2ID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralistsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot3)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsPlot3ID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralistsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot4)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsPlot4ID");

                entity.HasOne(d => d.FotherWoodlandPlantsGeneralistsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionFotherWoodlandPlantsGeneralistsPlot5)
                    .HasForeignKey(d => d.FotherWoodlandPlantsGeneralistsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_FOtherWoodlandPlantsGeneralistsPlot5ID");

                entity.HasOne(d => d.HicontinuousImpacts)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpacts)
                    .HasForeignKey(d => d.HicontinuousImpactsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsID");

                entity.HasOne(d => d.HicontinuousImpactsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpactsPlot1)
                    .HasForeignKey(d => d.HicontinuousImpactsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsPlot1ID");

                entity.HasOne(d => d.HicontinuousImpactsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpactsPlot2)
                    .HasForeignKey(d => d.HicontinuousImpactsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsPlot2ID");

                entity.HasOne(d => d.HicontinuousImpactsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpactsPlot3)
                    .HasForeignKey(d => d.HicontinuousImpactsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsPlot3ID");

                entity.HasOne(d => d.HicontinuousImpactsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpactsPlot4)
                    .HasForeignKey(d => d.HicontinuousImpactsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsPlot4ID");

                entity.HasOne(d => d.HicontinuousImpactsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionHicontinuousImpactsPlot5)
                    .HasForeignKey(d => d.HicontinuousImpactsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIContinuousImpactsPlot5ID");

                entity.HasOne(d => d.HioneOffImpacts)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpacts)
                    .HasForeignKey(d => d.HioneOffImpactsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsID");

                entity.HasOne(d => d.HioneOffImpactsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpactsPlot1)
                    .HasForeignKey(d => d.HioneOffImpactsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsPlot1ID");

                entity.HasOne(d => d.HioneOffImpactsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpactsPlot2)
                    .HasForeignKey(d => d.HioneOffImpactsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsPlot2ID");

                entity.HasOne(d => d.HioneOffImpactsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpactsPlot3)
                    .HasForeignKey(d => d.HioneOffImpactsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsPlot3ID");

                entity.HasOne(d => d.HioneOffImpactsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpactsPlot4)
                    .HasForeignKey(d => d.HioneOffImpactsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsPlot4ID");

                entity.HasOne(d => d.HioneOffImpactsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionHioneOffImpactsPlot5)
                    .HasForeignKey(d => d.HioneOffImpactsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_HIOneOffImpactsPlot5ID");

                entity.HasOne(d => d.IhimalayanBalsam)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsam)
                    .HasForeignKey(d => d.IhimalayanBalsamId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamID");

                entity.HasOne(d => d.IhimalayanBalsamPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsamPlot1)
                    .HasForeignKey(d => d.IhimalayanBalsamPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamPlot1ID");

                entity.HasOne(d => d.IhimalayanBalsamPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsamPlot2)
                    .HasForeignKey(d => d.IhimalayanBalsamPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamPlot2ID");

                entity.HasOne(d => d.IhimalayanBalsamPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsamPlot3)
                    .HasForeignKey(d => d.IhimalayanBalsamPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamPlot3ID");

                entity.HasOne(d => d.IhimalayanBalsamPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsamPlot4)
                    .HasForeignKey(d => d.IhimalayanBalsamPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamPlot4ID");

                entity.HasOne(d => d.IhimalayanBalsamPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionIhimalayanBalsamPlot5)
                    .HasForeignKey(d => d.IhimalayanBalsamPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IHimalayanBalsamPlot5ID");

                entity.HasOne(d => d.IjapaneseKnotweed)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweed)
                    .HasForeignKey(d => d.IjapaneseKnotweedId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedID");

                entity.HasOne(d => d.IjapaneseKnotweedPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweedPlot1)
                    .HasForeignKey(d => d.IjapaneseKnotweedPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedPlot1ID");

                entity.HasOne(d => d.IjapaneseKnotweedPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweedPlot2)
                    .HasForeignKey(d => d.IjapaneseKnotweedPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedPlot2ID");

                entity.HasOne(d => d.IjapaneseKnotweedPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweedPlot3)
                    .HasForeignKey(d => d.IjapaneseKnotweedPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedPlot3ID");

                entity.HasOne(d => d.IjapaneseKnotweedPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweedPlot4)
                    .HasForeignKey(d => d.IjapaneseKnotweedPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedPlot4ID");

                entity.HasOne(d => d.IjapaneseKnotweedPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionIjapaneseKnotweedPlot5)
                    .HasForeignKey(d => d.IjapaneseKnotweedPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IJapaneseKnotweedPlot5ID");

                entity.HasOne(d => d.Iother)
                    .WithMany(p => p.WoodlandConditionSubSectionIother)
                    .HasForeignKey(d => d.IotherId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherID");

                entity.HasOne(d => d.IotherPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionIotherPlot1)
                    .HasForeignKey(d => d.IotherPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherPlot1ID");

                entity.HasOne(d => d.IotherPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionIotherPlot2)
                    .HasForeignKey(d => d.IotherPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherPlot2ID");

                entity.HasOne(d => d.IotherPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionIotherPlot3)
                    .HasForeignKey(d => d.IotherPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherPlot3ID");

                entity.HasOne(d => d.IotherPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionIotherPlot4)
                    .HasForeignKey(d => d.IotherPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherPlot4ID");

                entity.HasOne(d => d.IotherPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionIotherPlot5)
                    .HasForeignKey(d => d.IotherPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IOtherPlot5ID");

                entity.HasOne(d => d.Irhododendron)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendron)
                    .HasForeignKey(d => d.IrhododendronId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronID");

                entity.HasOne(d => d.IrhododendronPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendronPlot1)
                    .HasForeignKey(d => d.IrhododendronPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronPlot1ID");

                entity.HasOne(d => d.IrhododendronPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendronPlot2)
                    .HasForeignKey(d => d.IrhododendronPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronPlot2ID");

                entity.HasOne(d => d.IrhododendronPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendronPlot3)
                    .HasForeignKey(d => d.IrhododendronPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronPlot3ID");

                entity.HasOne(d => d.IrhododendronPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendronPlot4)
                    .HasForeignKey(d => d.IrhododendronPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronPlot4ID");

                entity.HasOne(d => d.IrhododendronPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionIrhododendronPlot5)
                    .HasForeignKey(d => d.IrhododendronPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_IRhododendronPlot5ID");

                entity.HasOne(d => d.KeyFeature)
                    .WithMany(p => p.WoodlandConditionSubSection)
                    .HasForeignKey(d => d.KeyFeatureId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_Feature");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WoodlandConditionSubSection)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LMUID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckering)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckering)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckeringPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot1)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringPlot1ID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckeringPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot2)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringPlot2ID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckeringPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot3)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringPlot3ID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckeringPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot4)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringPlot4ID");

                entity.HasOne(d => d.LsrcoppiceRegrowthOrSuckeringPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrcoppiceRegrowthOrSuckeringPlot5)
                    .HasForeignKey(d => d.LsrcoppiceRegrowthOrSuckeringPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRCoppiceRegrowthOrSuckeringPlot5ID");

                entity.HasOne(d => d.LsrsaplingsGreater100cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cm)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmID");

                entity.HasOne(d => d.LsrsaplingsGreater100cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot1)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmPlot1ID");

                entity.HasOne(d => d.LsrsaplingsGreater100cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot2)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmPlot2ID");

                entity.HasOne(d => d.LsrsaplingsGreater100cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot3)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmPlot3ID");

                entity.HasOne(d => d.LsrsaplingsGreater100cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot4)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmPlot4ID");

                entity.HasOne(d => d.LsrsaplingsGreater100cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrsaplingsGreater100cmPlot5)
                    .HasForeignKey(d => d.LsrsaplingsGreater100cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSaplingsGreater100cmPlot5ID");

                entity.HasOne(d => d.Lsrseedlings10100cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cm)
                    .HasForeignKey(d => d.Lsrseedlings10100cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmID");

                entity.HasOne(d => d.Lsrseedlings10100cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cmPlot1)
                    .HasForeignKey(d => d.Lsrseedlings10100cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmPlot1ID");

                entity.HasOne(d => d.Lsrseedlings10100cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cmPlot2)
                    .HasForeignKey(d => d.Lsrseedlings10100cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmPlot2ID");

                entity.HasOne(d => d.Lsrseedlings10100cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cmPlot3)
                    .HasForeignKey(d => d.Lsrseedlings10100cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmPlot3ID");

                entity.HasOne(d => d.Lsrseedlings10100cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cmPlot4)
                    .HasForeignKey(d => d.Lsrseedlings10100cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmPlot4ID");

                entity.HasOne(d => d.Lsrseedlings10100cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlings10100cmPlot5)
                    .HasForeignKey(d => d.Lsrseedlings10100cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlings10_100cmPlot5ID");

                entity.HasOne(d => d.LsrseedlingsLess10cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cm)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmID");

                entity.HasOne(d => d.LsrseedlingsLess10cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cmPlot1)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmPlot1ID");

                entity.HasOne(d => d.LsrseedlingsLess10cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cmPlot2)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmPlot2ID");

                entity.HasOne(d => d.LsrseedlingsLess10cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cmPlot3)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmPlot3ID");

                entity.HasOne(d => d.LsrseedlingsLess10cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cmPlot4)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmPlot4ID");

                entity.HasOne(d => d.LsrseedlingsLess10cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLsrseedlingsLess10cmPlot5)
                    .HasForeignKey(d => d.LsrseedlingsLess10cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LSRSeedlingsLess10cmPlot5ID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckering)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckering)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckeringPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot1)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringPlot1ID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckeringPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot2)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringPlot2ID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckeringPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot3)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringPlot3ID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckeringPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot4)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringPlot4ID");

                entity.HasOne(d => d.LtrcoppiceRegrowthOrSuckeringPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrcoppiceRegrowthOrSuckeringPlot5)
                    .HasForeignKey(d => d.LtrcoppiceRegrowthOrSuckeringPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRCoppiceRegrowthOrSuckeringPlot5ID");

                entity.HasOne(d => d.LtrsaplingsGreater100cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cm)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmID");

                entity.HasOne(d => d.LtrsaplingsGreater100cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot1)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmPlot1ID");

                entity.HasOne(d => d.LtrsaplingsGreater100cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot2)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmPlot2ID");

                entity.HasOne(d => d.LtrsaplingsGreater100cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot3)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmPlot3ID");

                entity.HasOne(d => d.LtrsaplingsGreater100cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot4)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmPlot4ID");

                entity.HasOne(d => d.LtrsaplingsGreater100cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrsaplingsGreater100cmPlot5)
                    .HasForeignKey(d => d.LtrsaplingsGreater100cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSaplingsGreater100cmPlot5ID");

                entity.HasOne(d => d.Ltrseedlings10100cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cm)
                    .HasForeignKey(d => d.Ltrseedlings10100cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmID");

                entity.HasOne(d => d.Ltrseedlings10100cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cmPlot1)
                    .HasForeignKey(d => d.Ltrseedlings10100cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmPlot1ID");

                entity.HasOne(d => d.Ltrseedlings10100cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cmPlot2)
                    .HasForeignKey(d => d.Ltrseedlings10100cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmPlot2ID");

                entity.HasOne(d => d.Ltrseedlings10100cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cmPlot3)
                    .HasForeignKey(d => d.Ltrseedlings10100cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmPlot3ID");

                entity.HasOne(d => d.Ltrseedlings10100cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cmPlot4)
                    .HasForeignKey(d => d.Ltrseedlings10100cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmPlot4ID");

                entity.HasOne(d => d.Ltrseedlings10100cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlings10100cmPlot5)
                    .HasForeignKey(d => d.Ltrseedlings10100cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlings10_100cmPlot5ID");

                entity.HasOne(d => d.LtrseedlingsLess10cm)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cm)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmID");

                entity.HasOne(d => d.LtrseedlingsLess10cmPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cmPlot1)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmPlot1ID");

                entity.HasOne(d => d.LtrseedlingsLess10cmPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cmPlot2)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmPlot2ID");

                entity.HasOne(d => d.LtrseedlingsLess10cmPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cmPlot3)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmPlot3ID");

                entity.HasOne(d => d.LtrseedlingsLess10cmPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cmPlot4)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmPlot4ID");

                entity.HasOne(d => d.LtrseedlingsLess10cmPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionLtrseedlingsLess10cmPlot5)
                    .HasForeignKey(d => d.LtrseedlingsLess10cmPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_LTRSeedlingsLess10cmPlot5ID");

                entity.HasOne(d => d.SsdaforofCover)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCover)
                    .HasForeignKey(d => d.SsdaforofCoverId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverID");

                entity.HasOne(d => d.SsdaforofCoverPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCoverPlot1)
                    .HasForeignKey(d => d.SsdaforofCoverPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverPlot1ID");

                entity.HasOne(d => d.SsdaforofCoverPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCoverPlot2)
                    .HasForeignKey(d => d.SsdaforofCoverPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverPlot2ID");

                entity.HasOne(d => d.SsdaforofCoverPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCoverPlot3)
                    .HasForeignKey(d => d.SsdaforofCoverPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverPlot3ID");

                entity.HasOne(d => d.SsdaforofCoverPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCoverPlot4)
                    .HasForeignKey(d => d.SsdaforofCoverPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverPlot4ID");

                entity.HasOne(d => d.SsdaforofCoverPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionSsdaforofCoverPlot5)
                    .HasForeignKey(d => d.SsdaforofCoverPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_SSDAFOROfCoverPlot5ID");

                entity.HasOne(d => d.Stratum)
                    .WithMany(p => p.WoodlandConditionSubSection)
                    .HasForeignKey(d => d.StratumId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_WoodlandConditionStratum");

                entity.HasOne(d => d.Ta100200years)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200years)
                    .HasForeignKey(d => d.Ta100200yearsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsID");

                entity.HasOne(d => d.Ta100200yearsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200yearsPlot1)
                    .HasForeignKey(d => d.Ta100200yearsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsPlot1ID");

                entity.HasOne(d => d.Ta100200yearsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200yearsPlot2)
                    .HasForeignKey(d => d.Ta100200yearsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsPlot2ID");

                entity.HasOne(d => d.Ta100200yearsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200yearsPlot3)
                    .HasForeignKey(d => d.Ta100200yearsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsPlot3ID");

                entity.HasOne(d => d.Ta100200yearsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200yearsPlot4)
                    .HasForeignKey(d => d.Ta100200yearsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsPlot4ID");

                entity.HasOne(d => d.Ta100200yearsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionTa100200yearsPlot5)
                    .HasForeignKey(d => d.Ta100200yearsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA100_200YearsPlot5ID");

                entity.HasOne(d => d.Ta2050years)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050years)
                    .HasForeignKey(d => d.Ta2050yearsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsID");

                entity.HasOne(d => d.Ta2050yearsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050yearsPlot1)
                    .HasForeignKey(d => d.Ta2050yearsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsPlot1ID");

                entity.HasOne(d => d.Ta2050yearsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050yearsPlot2)
                    .HasForeignKey(d => d.Ta2050yearsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsPlot2ID");

                entity.HasOne(d => d.Ta2050yearsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050yearsPlot3)
                    .HasForeignKey(d => d.Ta2050yearsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsPlot3ID");

                entity.HasOne(d => d.Ta2050yearsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050yearsPlot4)
                    .HasForeignKey(d => d.Ta2050yearsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsPlot4ID");

                entity.HasOne(d => d.Ta2050yearsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionTa2050yearsPlot5)
                    .HasForeignKey(d => d.Ta2050yearsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20_50YearsPlot5ID");

                entity.HasOne(d => d.Ta20years)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20years)
                    .HasForeignKey(d => d.Ta20yearsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsID");

                entity.HasOne(d => d.Ta20yearsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20yearsPlot1)
                    .HasForeignKey(d => d.Ta20yearsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsPlot1ID");

                entity.HasOne(d => d.Ta20yearsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20yearsPlot2)
                    .HasForeignKey(d => d.Ta20yearsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsPlot2ID");

                entity.HasOne(d => d.Ta20yearsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20yearsPlot3)
                    .HasForeignKey(d => d.Ta20yearsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsPlot3ID");

                entity.HasOne(d => d.Ta20yearsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20yearsPlot4)
                    .HasForeignKey(d => d.Ta20yearsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsPlot4ID");

                entity.HasOne(d => d.Ta20yearsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionTa20yearsPlot5)
                    .HasForeignKey(d => d.Ta20yearsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA20YearsPlot5ID");

                entity.HasOne(d => d.Ta50100years)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100years)
                    .HasForeignKey(d => d.Ta50100yearsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsID");

                entity.HasOne(d => d.Ta50100yearsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100yearsPlot1)
                    .HasForeignKey(d => d.Ta50100yearsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsPlot1ID");

                entity.HasOne(d => d.Ta50100yearsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100yearsPlot2)
                    .HasForeignKey(d => d.Ta50100yearsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsPlot2ID");

                entity.HasOne(d => d.Ta50100yearsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100yearsPlot3)
                    .HasForeignKey(d => d.Ta50100yearsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsPlot3ID");

                entity.HasOne(d => d.Ta50100yearsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100yearsPlot4)
                    .HasForeignKey(d => d.Ta50100yearsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsPlot4ID");

                entity.HasOne(d => d.Ta50100yearsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionTa50100yearsPlot5)
                    .HasForeignKey(d => d.Ta50100yearsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TA50_100YearsPlot5ID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStools)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStools)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStoolsPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot1)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsPlot1ID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStoolsPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot2)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsPlot2ID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStoolsPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot3)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsPlot3ID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStoolsPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot4)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsPlot4ID");

                entity.HasOne(d => d.TaveteranPollardsAncientCoppiceStoolsPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionTaveteranPollardsAncientCoppiceStoolsPlot5)
                    .HasForeignKey(d => d.TaveteranPollardsAncientCoppiceStoolsPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_TAVeteranPollardsAncientCoppiceStoolsPlot5ID");

                entity.HasOne(d => d.ThnotifiablePestOrDisease)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDisease)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseaseId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseaseID");

                entity.HasOne(d => d.ThnotifiablePestOrDiseasePlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot1)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseasePlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseasePlot1ID");

                entity.HasOne(d => d.ThnotifiablePestOrDiseasePlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot2)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseasePlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseasePlot2ID");

                entity.HasOne(d => d.ThnotifiablePestOrDiseasePlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot3)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseasePlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseasePlot3ID");

                entity.HasOne(d => d.ThnotifiablePestOrDiseasePlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot4)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseasePlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseasePlot4ID");

                entity.HasOne(d => d.ThnotifiablePestOrDiseasePlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionThnotifiablePestOrDiseasePlot5)
                    .HasForeignKey(d => d.ThnotifiablePestOrDiseasePlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THNotifiablePestOrDiseasePlot5ID");

                entity.HasOne(d => d.ThotherDiseaseOrPest)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPest)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestId)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestID");

                entity.HasOne(d => d.ThotherDiseaseOrPestPlot1)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPestPlot1)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestPlot1Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestPlot1ID");

                entity.HasOne(d => d.ThotherDiseaseOrPestPlot2)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPestPlot2)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestPlot2Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestPlot2ID");

                entity.HasOne(d => d.ThotherDiseaseOrPestPlot3)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPestPlot3)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestPlot3Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestPlot3ID");

                entity.HasOne(d => d.ThotherDiseaseOrPestPlot4)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPestPlot4)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestPlot4Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestPlot4ID");

                entity.HasOne(d => d.ThotherDiseaseOrPestPlot5)
                    .WithMany(p => p.WoodlandConditionSubSectionThotherDiseaseOrPestPlot5)
                    .HasForeignKey(d => d.ThotherDiseaseOrPestPlot5Id)
                    .HasConstraintName("FK_WoodlandConditionSubSection_THOtherDiseaseOrPestPlot5ID");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasIndex(e => new { e.Code, e.Description })
                    .HasName("IX_WorkOrderCode")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Crdt)
                    .HasColumnName("CRDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cruid).HasColumnName("CRUID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(450)");

                entity.Property(e => e.Dldt)
                    .HasColumnName("DLDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dluid).HasColumnName("DLUID");

                entity.Property(e => e.Lmdt)
                    .HasColumnName("LMDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmuid).HasColumnName("LMUID");

                entity.HasOne(d => d.Lmu)
                    .WithMany(p => p.WorkOrder)
                    .HasForeignKey(d => d.Lmuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkOrderLMUID");
            });
        }
    }
}