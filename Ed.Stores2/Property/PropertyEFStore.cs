using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects.DTOS;
using DataObjects.DTOS.property.subobjects;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;
using Utils;

namespace EFStores.Property
{
    public class PropertyEFStore: BaseEFStore, IPropertyStore
    {

        private ILookupStore _iLookupStore;

        public PropertyEFStore(EstateContext ec,ICache iCache, IUserStore iUserStore, ILookupStore iLookupStore) : 
            base(ec,iCache)
        {
            _iLookupStore = iLookupStore;
            _iUserStore = iUserStore;
        }


        public List<LicenseDto> GetLicenseDto(int acquisitionId, List<int> licenseTypes)
        {
            var LicensesFlip = new List<LicenseDto>();
             
            var licenses = Context.Licence.Where(a =>
                !a.Deleted &&
                a.AcquisitionUnitId == acquisitionId && 
                a.LicenceAgreementId != null &&
                licenseTypes.Contains(a.LicenceAgreementId.Value)).ToList();


            foreach (var c in licenses)
            {
                var contactDto = new LicenseDto()
                {
                    Comments = c.Comments,
                    AreaHa = c.AreaInHectares.GetValueOrDefault(),
                    Address = c.Address,
                    Agent = c.Agent,
                    AgentExists = c.AgentExists,
                    AgreementId = c.LicenceAgreementId.GetValueOrDefault(),
                    CommencementDate = c.CommencementDate,
                    CommentsOnTermId = c.CommentsOnTermId.GetValueOrDefault(),
                    ExpiryDate = c.ExpiryDate,
                    FishingSize = c.FishingSize.GetValueOrDefault(),
                    FishingTypeId = c.FishingTypeId.GetValueOrDefault(),
                    InterestLetId = c.InterestLetId.GetValueOrDefault(),
                    NoticeOfTerminationId = c.NoticeOfTerminationId.GetValueOrDefault(),
                    NoticeProvisionsId = c.ProvisionsNoticeId.GetValueOrDefault(),
                    PerioId = c.LicencePeriodId.GetValueOrDefault(),
                    RentFee = c.RentOrFee.GetValueOrDefault(),
                    RentReviewCycle = c.RentReviewCycle,
                    RentReviewDate = c.RentReviewDate,
                    RentReviewId = c.RentReviewId.GetValueOrDefault(),
                    SizeInId = c.SizeInId.GetValueOrDefault(),
                    TenantLicensee = c.TenantLicensee,
                    TypeId = c.LicenceTypeId.GetValueOrDefault(),
                    Id = c.Id

                };


                LicensesFlip.Add(contactDto);
            }

            return LicensesFlip;
        }


        public List<PropertyDto> GetPropertyList(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            List<PropertyDto> propertyDtoResult = new List<PropertyDto>();

            var tenures = Context.Tenure.ToList();
            var propertyManagedBy = Context.PropertyManagedBy.ToList();


            var acqCache = Context.AcquisitionUnit.Include(i=>i.Tenure).Where(d => !d.Deleted).Select(s => new
            {
                s.Id,
                s.ManagementUnitId,
                s.TenureId,
                s.LeaseTerm,
                s.DateContractCompleted,
                s.AcquisitionOfficerId,
                s.Location,
                s.AreaInHectares,
                s.ManagedById
                
                
            }).ToList();
            
            foreach (var manu in Context.ManagementUnit.Where(m => !m.Deleted).OrderBy(n=>n.Name))
            {
                if((application == 99) || (manu.ApplicationId == application)) {
                    var v = acqCache.OrderBy(i => i.Id).FirstOrDefault(f => f.ManagementUnitId == manu.Id);

                    if (v != null)
                    {
                        var newRecord = new PropertyDto()
                        {
                            TenureDescription =
                                v.TenureId == null ? "" : tenures.First(f => f.Id == v.TenureId).Description,
                            LeaseTermYrs = v.LeaseTerm,
                            ID = v.Id,
                            SiteName = manu.Name,
                            GridReference = manu.GridReference,
                            Acquired = v.DateContractCompleted,
                            LPMDescription = v.AcquisitionOfficerId == null ? "" : UserName(v.AcquisitionOfficerId),
                            Manager = UserName(manu.WoodlandOfficerId),
                            Location = v.Location,
                            AreaHa = v.AreaInHectares,
                            Region = RegionName(manu.RegionId),
                            RegionId = manu.RegionId.GetValueOrDefault(),
                            ApplicationId = manu.ApplicationId,
                            ManagedBy = propertyManagedBy.FirstOrDefault(x => x.Id == v.ManagedById).Description,
                            CostCentre = v.ManagementUnitId,
                            DeputyID = manu.DeputyId.GetValueOrDefault(),
                            WoodlandOfficerID = manu.WoodlandOfficerId,
                            AcquisitionOfficerID = v.AcquisitionOfficerId.GetValueOrDefault()
                        };

                        propertyDtoResult.Add(newRecord);
                    }

                }
            }

            return propertyDtoResult.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList(); 
        }

        public List<AcquisitionUnitDto> GetProperty(int costCentreId)
        {
            List<AcquisitionUnitDto> results = new List<AcquisitionUnitDto>();
            
            var managementUnit = _cache.ManagementUnitDtos.FirstOrDefault(m => m.Id == costCentreId);

            if (managementUnit == null)
                return new List<AcquisitionUnitDto>();


            foreach (var aq in Context.AcquisitionUnit.Include(f=>f.Farming).Where(a=>a.ManagementUnitId == costCentreId))
            {

                var propertyGeneralDetailsDto = new PropertyGeneralDetailsDto
                {
                    Id = aq.Id,
                    AllowPOSO = managementUnit.AllowPOSO,
                    AdminArea = "unk location",
                    Comments = aq.NonFsccomments,
                    County = aq.CountyId.GetValueOrDefault(),
                    DirectorySuppressed = false,
                    Disposed = aq.DateDisposed.HasValue ? true : false,
                    GeneralPotSite = false,
                    NonFSC = aq.NonFsc.GetValueOrDefault(),
                    NonFSCDate = aq.NonFscasOfDate.GetValueOrDefault(),
                    NonFSCHa = aq.NonFscinHectares.GetValueOrDefault(),
                    NonFSCType = aq.NonFsctypeId.GetValueOrDefault(),
                    Parish = aq.Parish,
                    PotSite = managementUnit.IsPotSite,
                    WCBudget = managementUnit.WCBudget,
                    LADistrict = aq.District
                };

                var propertyFarming = new PropertyFarmingDto();

                if (aq.FarmingId != null)
                {
                   // var farm = Context.Farming.First(m => m.Id == aq.FarmingId);

                    propertyFarming = new PropertyFarmingDto()
                    {
                        Id = aq.Farming.Id,
                        ARP = aq.Farming.Arp,
                        CPHNO = aq.Farming.Cphno,
                        CSS = aq.Farming.Css,
                        CSSSRDPDate = aq.Farming.Cssdate.GetValueOrDefault(),
                        CSSSRDP_RefNo = aq.Farming.CssrefNo,
                        ELS = aq.Farming.Els,
                        ELSSRDPDate = aq.Farming.Elsdate.GetValueOrDefault(),
                        ELSSRDP_RefNo = aq.Farming.ElsrefNo,
                        FWPS = aq.Farming.Fwps,
                        GlastirAWE = aq.Farming.GlastirAwe,
                        GlastirAWEDate = aq.Farming.GlastirAwedate.GetValueOrDefault(),
                        GlastirAWE_RefNo = aq.Farming.GlastirTerefNo,
                        GlastirTE = aq.Farming.GlastirTe,
                        GlastirTEDate = aq.Farming.GlastirTedate.GetValueOrDefault(),
                        GlastirTE_RefNo = aq.Farming.GlastirTerefNo,
                        GlastirWCP = aq.Farming.GlastirWcp,
                        HLS = aq.Farming.Hls,
                        HLSSRDPDate = aq.Farming.Hlsdate.GetValueOrDefault(),
                        HLSSRDP_RefNo = aq.Farming.HlsrefNo,
                        ILP = aq.Farming.Ilp,
                        LFA = aq.Farming.Lfa,
                        Registered = aq.Farming.Registered,
                        SBIBRNCRN = aq.Farming.Sbibrncrn,
                        SFPS = aq.Farming.Sfps,
                        SRDP = aq.Farming.Srdp,
                        VendorNo = aq.Farming.VendorNo.GetValueOrDefault(),
                        WTFarmingLtd = aq.Farming.WtfarmingLtd
                    };
                }
                
                var propertyLegalTitle = new PropertyLegalTitleDto()
                {
                    Id = aq.Id,
                    DateDisposed = aq.DateDisposed.GetValueOrDefault(),
                    AcquisitionTypeId = aq.TypeId,
                    DateCompleted = aq.DateContractCompleted.GetValueOrDefault(),
                    DateExchanged = aq.DateContractExchanged.GetValueOrDefault(),
                    DateLeasedTo3rdParty = aq.DateLeasedTo3rdParty.GetValueOrDefault(),
                    LandRegistryNumbers = "unknown field",
                    LeaseEnd = aq.LeaseEndDate.GetValueOrDefault(),
                    LeaseStart = aq.LeaseStartDate.GetValueOrDefault(),
                    LeaseTerm = aq.LeaseTerm.GetValueOrDefault(),
                    Lessee = aq.Lessee,
                    Lessor = aq.Lessor,
                    MTMApprovalDate = aq.MtmdateApproved.GetValueOrDefault(),
                    PurchasePrice = aq.PurchasePrice.GetValueOrDefault(),
                    Rent = aq.Rent.GetValueOrDefault(),
                    Tenure = aq.TenureId.GetValueOrDefault(),
                    ThirdPartyLeaseTerm = aq.ThirdPartyLeaseTerm.GetValueOrDefault(),
                    WTSolicitorsName = aq.WtsolicitorsName,
                    CLT = aq.Clt.GetValueOrDefault()
                };

                var mainAcquisitionUnit = new MainSectionDto()
                {
                    Id = aq.Id,
                    Region = managementUnit.RegionId.GetValueOrDefault(),
                    Manager = aq.WoodlandOfficerId,
                    LPM = aq.AcquisitionOfficerId.GetValueOrDefault(),
                    County = aq.CountyId.GetValueOrDefault(),
                    AcquisitionTypeId = aq.TypeId,
                    ManagedBy = aq.ManagedById,
                    CostCentre = aq.ManagementUnitId.ToString(),
                    Location = aq.Location,
                    WoodNo = aq.Id.ToString(),
                    GridReference = aq.GridReference,
                    SiteName = aq.Name,
                    ApplicationId = -1, //todo
                    GISHa = aq.GisareaInHectares.GetValueOrDefault(),
                    LandHa = aq.AreaInHectares,
                    WoodHa = aq.WoodAreaInHectares.GetValueOrDefault(),
                    SetAsMainAcquisitionUnit = aq.IsDefaultValue,
                    PostCode = aq.PostCode
                };

                results.Add(new AcquisitionUnitDto()
                {
                    ManagementUnitId = aq.ManagementUnitId,
                    AcquisitionMainSectionDto = mainAcquisitionUnit,
                    PropertyFarmingDto = propertyFarming,
                    PropertyGeneralDetailsDto = propertyGeneralDetailsDto,
                    PropertyLegalTitleDto = propertyLegalTitle
                });
            }



           

            return results;
        }

        public List<AUID> GetAcquisitionIds(int managementUnitId)
        {
            var acquisitionIds = Context.AcquisitionUnit.AsNoTracking().Where(m => m.ManagementUnitId == managementUnitId && !m.Deleted).Select(s=>new
            {
                s.Id,
                s.Name,
                s.ManagementUnitId,
                s.ManagedById
            }).ToList();

            return acquisitionIds.Select(acq => new AUID()
                {
                    Id = acq.Id,
                    Name = acq.Name, 
                    ManagementUnitId = acq.ManagementUnitId,
                    ManagedById = acq.ManagedById
                    
                })
                .ToList();
        }

        public int SaveNewAcquisitionUnit(int managementUnitId, AUID auid)
        {
        
            var currentUserId = _iUserStore.CurrentUserId();
             
            var defaultManagedBy = Context.PropertyManagedBy.First().Id;

            var atype = Context.AcquisitionType.First();

            var administrationArea = Context.AdministrationArea.First().Id;

            var recordsToAdd = new EDC_Estate.Models.DB.AcquisitionUnit()
            {

                Name = auid.Name,
                ManagementUnitId = managementUnitId,
                ManagedById = defaultManagedBy,
                WoodlandOfficerId = currentUserId,
                OwnedByWoodlandTrust = true,
                TypeId = atype.Id,
                AdministrationAreaId = administrationArea,
                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            };

            Context.AddRange(recordsToAdd);

            Context.SaveChanges();

            return recordsToAdd.Id;
        }



        public AcquisitionUnitDto GetAcquisitionUnit(int acquisitionUnitId)
        {
            var result = new AcquisitionUnitDto();
            
            var aq = Context.AcquisitionUnit.Include(f => f.Farming).AsNoTracking()
                .FirstOrDefault(a => a.Id == acquisitionUnitId);

            var managementUnit = Context.ManagementUnit.Select(s=>new
            {
                Id = s.Id,
                AllowPoso = s.AllowPoso,
                IsPotSite = s.IsPotSite,
                Wcbudget = s.Wcbudget,
                RegionId = s.RegionId,
                ApplicationId = s.ApplicationId
            }) .FirstOrDefault(f => f.Id == aq.ManagementUnitId);

            var propertyGeneralDetailsDto = new PropertyGeneralDetailsDto
            {
                Id = aq.Id,
                AllowPOSO = managementUnit.AllowPoso,
                AdminArea = aq.AdministrationArea,
                AdminAreaId = aq.AdministrationAreaId.GetValueOrDefault(),
                Comments = aq.NonFsccomments,
                County = aq.CountyId.GetValueOrDefault(),
                DirectorySuppressed = false,
                Disposed = aq.DateDisposed.HasValue ? true : false,
                GeneralPotSite = false,
                NonFSC = aq.NonFsc.GetValueOrDefault(),
                NonFSCDate = aq.NonFscasOfDate.GetValueOrDefault(),
                NonFSCHa = aq.NonFscinHectares.GetValueOrDefault(),
                NonFSCType = aq.NonFsctypeId.GetValueOrDefault(),
                Parish = aq.Parish,
                PotSite = managementUnit.IsPotSite,
                WCBudget = managementUnit.Wcbudget,
                LADistrict = aq.District,
               
            };

            var propertyFarming = new PropertyFarmingDto();

            if (aq.FarmingId != null)
            {
                // var farm = Context.Farming.First(m => m.Id == aq.FarmingId);

                propertyFarming = new PropertyFarmingDto()
                {
                    Id = aq.Farming.Id,
                    ARP = aq.Farming.Arp,
                    CPHNO = aq.Farming.Cphno,
                    CSS = aq.Farming.Css,
                    CSSSRDPDate = aq.Farming.Cssdate,
                    CSSSRDP_RefNo = aq.Farming.CssrefNo,
                    ELS = aq.Farming.Els,
                    ELSSRDPDate = aq.Farming.Elsdate,
                    ELSSRDP_RefNo = aq.Farming.ElsrefNo,
                    FWPS = aq.Farming.Fwps,
                    GlastirAWE = aq.Farming.GlastirAwe,
                    GlastirAWEDate = aq.Farming.GlastirAwedate,
                    GlastirAWE_RefNo = aq.Farming.GlastirAwerefNo,
                    GlastirTE = aq.Farming.GlastirTe,
                    GlastirTEDate = aq.Farming.GlastirTedate,
                    GlastirTE_RefNo = aq.Farming.GlastirTerefNo,
                    GlastirWCP = aq.Farming.GlastirWcp,
                    HLS = aq.Farming.Hls,
                    HLSSRDPDate = aq.Farming.Hlsdate,
                    HLSSRDP_RefNo = aq.Farming.HlsrefNo,
                    ILP = aq.Farming.Ilp,
                    LFA = aq.Farming.Lfa,
                    Registered = aq.Farming.Registered,
                    SBIBRNCRN = aq.Farming.Sbibrncrn,
                    SFPS = aq.Farming.Sfps,
                    SRDP = aq.Farming.Srdp,
                    VendorNo = aq.Farming.VendorNo.GetValueOrDefault(),
                    WTFarmingLtd = aq.Farming.WtfarmingLtd
                };
            }

            var propertyLegalTitle = new PropertyLegalTitleDto()
            {
                Id = aq.Id,
                DateDisposed = aq.DateDisposed,
                AcquisitionTypeId = aq.TypeId,
                DateCompleted = aq.DateContractCompleted,
                DateExchanged = aq.DateContractExchanged,
                DateLeasedTo3rdParty = aq.DateLeasedTo3rdParty,
                LandRegistryNumbers = "unknown field",
                LeaseEnd = aq.LeaseEndDate,
                LeaseStart = aq.LeaseStartDate,
                LeaseTerm = aq.LeaseTerm.GetValueOrDefault(),
                Lessee = aq.Lessee,
                Lessor = aq.Lessor,
                MTMApprovalDate = aq.MtmdateApproved,
                PurchasePrice = aq.PurchasePrice.GetValueOrDefault(),
                Rent = aq.Rent.GetValueOrDefault(),
                Tenure = aq.TenureId.GetValueOrDefault(),
                ThirdPartyLeaseTerm = aq.ThirdPartyLeaseTerm.GetValueOrDefault(),
                WTSolicitorsName = aq.WtsolicitorsName,
                CLT = aq.Clt.GetValueOrDefault()
                
            };

            var mainAcquisitionUnit = new MainSectionDto()
            {
                Id = aq.Id,
                Region = managementUnit.RegionId.GetValueOrDefault(),
                Manager = aq.WoodlandOfficerId,
                LPM = aq.AcquisitionOfficerId.GetValueOrDefault(),
                County = aq.CountyId.GetValueOrDefault(),
                AcquisitionTypeId = aq.TypeId,
                ManagedBy = aq.ManagedById,
                CostCentre = aq.ManagementUnitId.ToString(),
                Location = aq.Location,
                WoodNo = aq.Id.ToString(),
                GridReference = aq.GridReference,
                SiteName = aq.Name,
                ApplicationId = managementUnit.ApplicationId,
                GISHa = aq.GisareaInHectares.GetValueOrDefault(),
                LandHa = aq.AreaInHectares,
                WoodHa = aq.WoodAreaInHectares.GetValueOrDefault(),
                SetAsMainAcquisitionUnit = aq.IsDefaultValue,
                PostCode = aq.PostCode
                
            };

            result.ManagementUnitId = aq.ManagementUnitId;
            result.AcquisitionMainSectionDto = mainAcquisitionUnit;
            result.PropertyFarmingDto = propertyFarming;
            result.PropertyGeneralDetailsDto = propertyGeneralDetailsDto;
            result.PropertyLegalTitleDto = propertyLegalTitle;
              

            return result;
        }

        public DirectoryInfoDto GetDirectoryInfo(int acquisitionId)
        {
            var acu = Context.AcquisitionUnit.FirstOrDefault(a => a.Id == acquisitionId);

            var di = new DirectoryInfoDto();

            //acu.DirectoryInformation

            if ((acu.DirectoryInformation & 8388608) == 8388608) di.MainAcquisitionRecord = true;

            if ((acu.DirectoryInformation & 4) == 4) di.InformationBoard = true;
            if ((acu.DirectoryInformation & 8) == 8) di.WTCarParkAtSite = true;
            if ((acu.DirectoryInformation & 16) == 16) di.ParkingNearby = true;
            if ((acu.DirectoryInformation & 32) == 32) di.LocalParkingDifficult = true;
            if ((acu.DirectoryInformation & 64) == 64) di.GoodViews = true;
            if ((acu.DirectoryInformation & 128) == 128) di.WaymarkedWalk = true;
            if ((acu.DirectoryInformation & 256) == 256) di.Moorland = true;
            if ((acu.DirectoryInformation & 512) == 512) di.Grassland = true;
            if ((acu.DirectoryInformation & 1024) == 1024) di.Marshland = true;
            if ((acu.DirectoryInformation & 4096) == 4096) di.MainlyBroadleavedWoodland = true;
            if ((acu.DirectoryInformation & 8192) == 8192) di.MixedWoodland = true;
            if ((acu.DirectoryInformation & 16384) == 16384) di.MainlyConiferousWoodland = true;
            if ((acu.DirectoryInformation & 65536) == 65536) di.SpecialWildlifeInterest = true;
            if ((acu.DirectoryInformation & 131072) == 131072) di.WellWorthAVisit = true;
            if ((acu.DirectoryInformation & 4194304) == 4194304) di.PublicAccess = true;
            if ((acu.DirectoryInformation & 2) == 2) di.DirectoryOwnIdentity = true;
            if ((acu.DirectoryInformation & 524288) == 524288) di.SpringFlowers = true;
            if ((acu.DirectoryInformation & 262144) == 262144) di.GoodAutumnColour = true;
            if ((acu.DirectoryInformation & 1048576) == 1048576) di.MainlyYoungWoodland = true;
            if ((acu.DirectoryInformation & 2048) == 2048) di.WoodlandCreationSite = true;
            if ((acu.DirectoryInformation & 2097152) == 2097152) di.NoAccessForSafetyReasons = true;
            if ((acu.DirectoryInformation & 1) == 1) di.DirectorySuppress = true;
            if ((acu.DirectoryInformation & 32768) == 32768) di.FreeLeafletAvailable = true;
            if ((acu.DirectoryInformation & 16777216) == 16777216) di.ManagementAccess = true;
            if ((acu.DirectoryInformation & 33554432) == 33554432) di.AncientWoodlandConcentrationArea = true;
            if ((acu.DirectoryInformation & 67108864) == 67108864) di.BufferingSemiNaturalHabitat = true;
            if ((acu.DirectoryInformation & 134217728) == 134217728) di.LegacySite = true;



            return di;
        }



        public List<BoundariesAndPlanDto> GetBoundariesAndPlansDto(int acquisitionId)
        {
            var boundaries = Context.BoundarySection.Include(i => i.AcquisitionUnit).AsNoTracking().Select(s=>new
            {
                AcquisitionUnitId = s.AcquisitionUnitId,
                Id = s.Id,
                Description = s.Description,
                Ownership= s.Ownership,
                Responsibility = s.Responsibility,
                Comments =s.Comments
            }).Where(a => a.AcquisitionUnitId == acquisitionId).ToList();

            var boundsAndPlansFlip = new List<BoundariesAndPlanDto>();

            foreach (var b in boundaries)
            {
                var boundarySection = new BoundariesAndPlanDto
                {
                    Id = b.Id,
                    Description = b.Description,
                    Ownership = b.Ownership,
                    Responsibility = b.Responsibility,
                    Section = b.Comments
                };

                boundsAndPlansFlip.Add(boundarySection);
            }

            return boundsAndPlansFlip;
        }

        public List<ContactDto> GetContactsDto(int acquisitionId)
        {

            var contactsFlip = new List<ContactDto>();

            foreach (var c in Context.Contact.Where(a => a.AcquisitionUnitId == acquisitionId))
            {
                var contactDto = new ContactDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Address = c.Address,
                    County = c.County,
                    Email = c.EMail,
                    Notes = c.Notes,
                    Organisation = c.Organisation,
                    Other = c.OtherStatus,
                    Postcode = c.Postcode,
                    StatusId = c.StatusId != null ? c.StatusId.Value : 0,
                    Telephone = c.Telephone,
                    Town = c.Town
                };


                contactsFlip.Add(contactDto);
            }

            return contactsFlip;
        }

        public List<DrainageRateDto> GetDrainageRatesDto(int acquisitionId)
        {

            var drainageRatesResult = Context.DrainageRate.Include(i => i.AcquisitionUnit)
                .Where(a => a.AcquisitionUnitId == acquisitionId && !a.Deleted).ToList();

            var drainageRatesFlip = new List<DrainageRateDto>();


            foreach (var d in drainageRatesResult)
            {
                var dr = new DrainageRateDto
                {
                    Amount = d.Amount.GetValueOrDefault(),
                    Body = d.Body,
                    DateDue = d.DateDue.GetValueOrDefault(),
                    Id = d.Id,
                    ReferenceNumber = d.ReferenceNumber
                };


                drainageRatesFlip.Add(dr);
            }

            return drainageRatesFlip;
        }

        public List<FundingDto> GetFundingDtos(int acquisitionId)
        {
            var funding = Context.Funding.Where(a => a.AcquisitionUnitId == acquisitionId).ToList();

            var fundingsList = new List<FundingDto>();

            var fundingTypes = _iLookupStore.GetFundingTypes();

            foreach (var s in funding)
            {
                var fundingType = fundingTypes.FirstOrDefault(fx => fx.ID == s.TypeId);

                if (fundingType == null)
                    fundingType = fundingTypes.FirstOrDefault(a => a.ID == 0);

                var f = new FundingDto
                {
                    Id = s.Id,
                    Amount = s.Amount.GetValueOrDefault(),
                    DateClaimed = s.ClaimedDate,
                    DateConditionsApproved = s.ConditionsApprovedDate.Validate(),
                    DateFoundingConfirmed = s.FundingConfirmedDate.Validate(),
                    DateOffered = s.OfferedDate.Validate(),
                    FundingTypeId = fundingType,
                    GiftAidOfferAmount = s.GiftAidOfferAmount.GetValueOrDefault(),
                    GrantConditionsDescription = s.GrantConditionsDescr,
                    GrantConditionsExist = s.GrantConditionsExist,
                    NameOfDonor = s.DonorName,
                    PaymentReceivedDate = s.PaymentReceivedDate.Validate()
                };

                fundingsList.Add(f);
            }

            return fundingsList;
        }

        public List<PartDisposalDto> GetPartDisposal(int acquisitionId)
        {

            var partDisposalsFlip = new List<PartDisposalDto>();

            var p = Context.PartDisposal.Where(w => w.AcquisitionUnitId == acquisitionId).ToList();

            foreach (var a in p)
            {
                var pp = new PartDisposalDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    Address = a.Address,
                    County = a.County,
                    DateOfDisposal = a.DisposalDate.GetValueOrDefault(),
                    Description = a.Description,
                    Email = a.Email,
                    InterestDisposalId = a.DisposedInterestId.GetValueOrDefault(),
                    Organisation = a.Organisation,
                    Postcode = a.Postcode,
                    Telephone = a.Telephone
                };

                partDisposalsFlip.Add(pp);

            }


            return partDisposalsFlip;
        }

        public List<PublicRightOfWayDto> GetPublicRightsOfWayDto(int acquisitionId)
        {
            var publicRightOfWayFlip = new List<PublicRightOfWayDto>();

            var row = Context.WayPublicRights.Where(w => w.AcquisitionUnitId == acquisitionId).ToList();
            foreach (var p in row)
            {
                var pp = new PublicRightOfWayDto
                {
                    Id = p.Id,
                    Bridleway = p.HasBridleway,
                    BridlewayDescription = p.BridlewayDescription,
                    Comments = p.Comments,
                    Footpath = p.HasFootpath,
                    FootpathDescription = p.FootpathDescription,
                    Other = p.HasOther,
                    OtherDescription = p.OtherDescription
                };

                publicRightOfWayFlip.Add(pp);
            }

            return publicRightOfWayFlip;
        }

        public List<StructureDto> GetStructuresDto(int acquisitionId)
        {
            var acu = Context.AcquisitionUnit.FirstOrDefault(a => a.Id == acquisitionId);

            var structuresFlip = new List<StructureDto>();

            foreach (var s in Context.Structure.Where(w => w.AcquisitionUnitId == acquisitionId))
            {
                var ss = new StructureDto
                {
                    AnnualMaintenanceCosts = s.AnnualMaintenanceCosts.GetValueOrDefault(),
                    BriefReportSummary = s.BriefReportSummary,
                    Completed = s.Completed,
                    Description = s.Description,
                    ExternalSurveyorRequired = s.ExternalSurveyorRequired,
                    LastInspectionDate = s.LastInspectionDate.GetValueOrDefault(),
                    NextInspectionDate = s.NextInspectionDate.GetValueOrDefault(),
                    RebuildCost = s.RebuildCost.GetValueOrDefault(),
                    ReportAuthor = s.ReportAuthor,
                    Responsibility = s.Responsibility,
                    ResponsibilityDescription = s.ResponsibilityDescr,
                    StructureConditionId = s.StructureConditionId.GetValueOrDefault(),
                    Id = s.Id,
                    StructureTypeId = s.StructureTypeId.GetValueOrDefault()
                };


                structuresFlip.Add(ss);
            }

            return structuresFlip;
        }

        public List<ThirdPartyRightDto> GetThirdPartyRightDtos(int acquisitionId)
        {

            var thirdPartyRightsFlip = new List<ThirdPartyRightDto>();

            foreach (var thirdPartyRight in Context.ThirdPartyRights.Where(w => w.AcquisitionUnitId == acquisitionId))
            {
                var tr = new ThirdPartyRightDto()
                {
                    Id = thirdPartyRight.Id,
                    Comments = thirdPartyRight.Comments,
                    AgreementFrom = thirdPartyRight.AgreementFromDate.GetValueOrDefault(),
                    AgreementTypeId = thirdPartyRight.AgreementId.GetValueOrDefault(),
                    AgreementWith = thirdPartyRight.AgreementWith,
                    CurrentPaymentAmount = thirdPartyRight.CurrentAmount.GetValueOrDefault(),
                    CurrentPaymentDate = thirdPartyRight.CurrentPaymentDate.GetValueOrDefault(),
                    CurrentReceivementDate = thirdPartyRight.CurrentReceivedDate.GetValueOrDefault(),
                    ForecastPaymentAmount = thirdPartyRight.ForecastAmount.GetValueOrDefault(),
                    ForecastPaymentDate = thirdPartyRight.ForecastReceivedDate.GetValueOrDefault(),
                    ForecastReceivementDate = thirdPartyRight.ForecastReceivedDate.GetValueOrDefault(),
                    InitialEnquiry = thirdPartyRight.InitialEnquiryDate.GetValueOrDefault(),
                    MTMApproval = thirdPartyRight.MtmapprovalDate.GetValueOrDefault(),
                    MTMApprovalTarget = thirdPartyRight.MtmapprovalTargetDate.GetValueOrDefault(),
                    ResponseResult = thirdPartyRight.ResponseResult,
                    ResponsiveReceived = thirdPartyRight.ResponseReceivedDate.GetValueOrDefault(),
                    ResponsiveReceivedTarget = thirdPartyRight.ResponseReceivedTargetDate.GetValueOrDefault(),
                    RightsTypeId = thirdPartyRight.TypeId.GetValueOrDefault(),
                    ServiceId = thirdPartyRight.ServiceId.GetValueOrDefault(),
                    SouthernElectric = thirdPartyRight.SouthernElectricDate.GetValueOrDefault(),
                    SouthernElectricTarget = thirdPartyRight.SouthernElectricTargetDate.GetValueOrDefault(),
                    WT = thirdPartyRight.Wtdate.GetValueOrDefault(),
                    WTTarget = thirdPartyRight.WttargetDate.GetValueOrDefault()
                };

                thirdPartyRightsFlip.Add(tr);
            }

            return thirdPartyRightsFlip;
        }

        public SubAcquisitionUnit GetSubAcquisitionUnit(int acquisitionId)
        {
            var acquistionUnit = Context.AcquisitionUnit.Select(au=>new
            {
                au.Id,
                au.BeneficialCovenantsDescription,
                au.BeneficialCovenants,
                au.ContaminationDescription,
                au.HazardsAndLiabilities,
                au.FormerNames,
                au.ManagementAccessDescription,
                au.ManagementInformation,
                MineralRightTypeId = au.MineralRightsId.GetValueOrDefault(),
                au.MineralRightsDescription,
                au.OtherRightsConveyedDescription,
                au.OtherRightsConveyed,
                au.PermissiveAccessDescription,

                PermissiveAccessExists = au.PermissiveAccess.GetValueOrDefault(),
                au.AdditionalInformation,
                PropertyInfoDescription = au.Description,
                Comment = au.PublicAccessDescription,
                RestrictiveCovenantDescription = au.RestrictiveCovenantsDescription,
                RestrictiveCovenantsExist = au.RestrictiveCovenants,
                ShootingDescription = au.ShootingRightsDescription,
                ShootingFishingTypeId = au.ShootingRightsId.GetValueOrDefault(),
                PlanningMattersDescription = au.SummaryDescription,

                au.BoundariesDescription,
                DrainageRatesExist = au.DrainageRatesExist.GetValueOrDefault(),
                HighwayAuthorityId = au.HighwayAuthorityId.GetValueOrDefault(),
                PublicRightsOfWayExist = au.HasPublicRightsOfWay.GetValueOrDefault(),
                au.StatutoryDeclarationsDate,
                au.NextStatutoryDeclarationsDate,
                au.HighwaysActDate,
                au.NextHighwaysActDate,
                au.StructuresDescription,
                au.Structures,
                au.ServicesDescription,
                au.ServicesExist,
                au.ThirdPartyRightsDescription,
                au.ThirdPartyRights,
            }).FirstOrDefault(f => f.Id == acquisitionId);

            if (acquistionUnit == null) return new SubAcquisitionUnit();

            return new SubAcquisitionUnit()
            {
                Id = acquistionUnit.Id,
                BeneficialCovenantText = acquistionUnit.BeneficialCovenantsDescription,
                BeneficialCovenantsExist = acquistionUnit.BeneficialCovenants,
                Contamination = acquistionUnit.ContaminationDescription,
                HazardsLiabilities = acquistionUnit.HazardsAndLiabilities,
                Names = acquistionUnit.FormerNames,
                ManagementAccess = acquistionUnit.ManagementAccessDescription,
                ManagementInformation = acquistionUnit.ManagementInformation,
                MineralRightTypeId = acquistionUnit.MineralRightTypeId,
                MineralRightsDescription = acquistionUnit.MineralRightsDescription,
                OtherRightsConveyedDescription = acquistionUnit.OtherRightsConveyedDescription,
                OtherRightsConveyedExists = acquistionUnit.OtherRightsConveyed,
                PermissiveAccessDescription = acquistionUnit.PermissiveAccessDescription,
                PermissiveAccessExists = acquistionUnit.PermissiveAccessExists,
                AdditionalInformationDescription = acquistionUnit.AdditionalInformation,
                PropertyInfoDescription = acquistionUnit.PropertyInfoDescription,
                Comment = acquistionUnit.Comment,
                RestrictiveCovenantDescription = acquistionUnit.RestrictiveCovenantDescription,
                RestrictiveCovenantsExist = acquistionUnit.RestrictiveCovenantsExist,
                ShootingDescription = acquistionUnit.ShootingDescription,
                ShootingFishingTypeId = acquistionUnit.ShootingFishingTypeId,
                PlanningMattersDescription = acquistionUnit.PlanningMattersDescription,

                BoundariesDescription = acquistionUnit.BoundariesDescription,
                DrainageRatesExist = acquistionUnit.DrainageRatesExist,
                HighwayAuthorityId = acquistionUnit.HighwayAuthorityId,
                PublicRightsOfWayExist = acquistionUnit.PublicRightsOfWayExist,
                StatutoryDeclarations = acquistionUnit.StatutoryDeclarationsDate,
                StatutoryDeclarationsNext = acquistionUnit.NextStatutoryDeclarationsDate,
                HighwayAct = acquistionUnit.HighwaysActDate,
                HighwayActNext = acquistionUnit.NextHighwaysActDate,
                StructuresDescription = acquistionUnit.StructuresDescription,
                StructuresExist = acquistionUnit.Structures,
                ServicesDescription = acquistionUnit.ServicesDescription,
                ServicesExist = acquistionUnit.ServicesExist,
                ThirdPartyRightsDescription = acquistionUnit.ThirdPartyRightsDescription,
                ThirdPartyRightsExist = acquistionUnit.ThirdPartyRights,

            };
        }


        #region lists collections

        public void UpdateLicenses(int acquisitionId, List<LicenseDto> editSet)
        {
            var existingHarvestings = Context.Licence.Where(h => h.AcquisitionUnitId == acquisitionId).ToList();

            var currentUserId = _iUserStore.CurrentUserId();


            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingHarvestings.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingHarvestings
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();

            foreach (var acq in existingHarvestings)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == acq.Id);

                //   if (matchedRecord == null) continue;

                if (matchedRecord != null)
                {
                    acq.Address = matchedRecord.Address;
                    acq.Agent = matchedRecord.Agent;
                    acq.AgentExists = matchedRecord.AgentExists;
                    acq.AreaInHectares = matchedRecord.AreaHa;
                    acq.CommencementDate = matchedRecord.CommencementDate;
                    acq.Comments = matchedRecord.Comments;
                    acq.RentReviewCycle = matchedRecord.RentReviewCycle;
                    acq.RentReviewDate = matchedRecord.RentReviewDate;
                    acq.ExpiryDate = matchedRecord.ExpiryDate;
                    acq.FishingSize = matchedRecord.FishingSize;
                    acq.TenantLicensee = matchedRecord.TenantLicensee;
                    acq.RentOrFee = matchedRecord.RentFee;
                    
                    acq.CommentsOnTermId = matchedRecord.CommentsOnTermId;          
                    acq.FishingTypeId = matchedRecord.FishingTypeId;
                    acq.InterestLetId = matchedRecord.InterestLetId;
                    acq.LicenceAgreementId = matchedRecord.AgreementId == 0 ? null : (int?)matchedRecord.AgreementId;
                    acq.LicencePeriodId = matchedRecord.PerioId;
                    acq.LicenceTypeId = matchedRecord.TypeId;
                    acq.NoticeOfTerminationId = matchedRecord.NoticeOfTerminationId;
                    acq.ProvisionsNoticeId = matchedRecord.NoticeProvisionsId;                   
                    acq.RentReviewId = matchedRecord.RentReviewId;               
                    acq.SizeInId = matchedRecord.SizeInId;
                    


                }

                if (deletedRecords.Any(f => f == acq.Id))
                {
                    acq.Deleted = true;
                    acq.Dldt = DateTime.Today;
                    acq.Dluid = currentUserId;
                }
            }

            var commentsOnTermId = Context.AdministrationArea.First().Id;
            var fishingTypeId = Context.FishingType.First().Id;
            var interestLetId = Context.InterestLet.First().Id;
            //   var licenceAgreementId = Context.LicenceAgreement.First().Id;
            var licencePeriodId = Context.LicencePeriod.First().Id;
            var licenceTypeId = Context.LicenceType.First().Id;
            var noticeOfTerminationId = Context.NoticeOfTermination.First().Id;
            var provisionsNoticeId = Context.ProvisionsNotice.First().Id;
            var rentReviewId = Context.RentReview.First().Id;
            var sizeInId = Context.SizeIn.First().Id;




            var recordsToAdd = newRecords.Select(matchedRecord => new Licence()
            {
                AcquisitionUnitId = acquisitionId,

                Address = matchedRecord.Address,

                Agent = matchedRecord.Agent,

                AgentExists = matchedRecord.AgentExists,

                AreaInHectares = matchedRecord.AreaHa,

                CommencementDate = matchedRecord.CommencementDate,

                Comments = matchedRecord.Comments,

                ExpiryDate = matchedRecord.ExpiryDate,

                FishingSize = matchedRecord.FishingSize,

                RentOrFee = matchedRecord.RentFee,

                RentReviewCycle = matchedRecord.RentReviewCycle,

                RentReviewDate = matchedRecord.RentReviewDate,

                TenantLicensee = matchedRecord.TenantLicensee,

                CommentsOnTermId = commentsOnTermId,
                LicenceAgreementId = matchedRecord.AgreementId,



                //FishingTypeId = fishingTypeId,

                //InterestLetId = interestLetId,


                //LicencePeriodId = licencePeriodId,

                //LicenceTypeId = licenceTypeId,

                //NoticeOfTerminationId = noticeOfTerminationId,

                //ProvisionsNoticeId = provisionsNoticeId,



                //RentReviewId = rentReviewId,



                //SizeInId = sizeInId,







                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();


        }


        public void UpdateBoundariesAndPlansDto(int acquisitionId, List<BoundariesAndPlanDto> editSet)
        {          
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.BoundarySection.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Comments = matchedRecord.Section;
                    xRec.Description = matchedRecord.Description;
                    xRec.Ownership = matchedRecord.Ownership;
                    xRec.Responsibility = matchedRecord.Responsibility;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.BoundarySection()
            {
                //xRec.Comments = matchedRecord.Section;               
                Comments = nr.Section,
                //xRec.Description = matchedRecord.Description;
                Description = nr.Description,
                //xRec.Ownership = matchedRecord.Ownership;
                Ownership = nr.Ownership,
                //xRec.Responsibility = matchedRecord.Responsibility;
                Responsibility = nr.Responsibility,
                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();
        }
 
        public void UpdateContacts(int acquisitionId, List<ContactDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.Contact.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.Address = matchedRecord.Address;
                xRec.County = matchedRecord.County;
                xRec.Name = matchedRecord.Name;
                xRec.Notes = matchedRecord.Notes;
                xRec.Organisation = matchedRecord.Organisation;
                xRec.OtherStatus = matchedRecord.Other;
                xRec.Postcode = matchedRecord.Postcode;
                xRec.Telephone = matchedRecord.Telephone;
                xRec.StatusId = matchedRecord.StatusId == 0 ? null : (int?) matchedRecord.StatusId;
                xRec.EMail = matchedRecord.Email;
                xRec.Town = matchedRecord.Town;

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.Contact()
            { 
                Address = nr.Address,
                County = nr.County,
                Name = nr.Name,
                Notes = nr.Notes,
                Organisation = nr.Organisation,
                OtherStatus = nr.Other,
                Postcode = nr.Postcode,
                Telephone = nr.Telephone,
                StatusId = nr.StatusId == 0 ? null : (int?)nr.StatusId,
                EMail = nr.Email,
                Town = nr.Town,
                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();
        }
        
        public void UpdateDrainages(int acquisitionId, List<DrainageRateDto> editSet)
        {
            //* drainages that's a new word :P

            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.DrainageRate.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Amount = matchedRecord.Amount;
                    xRec.Body = matchedRecord.Body;
                    xRec.DateDue = matchedRecord.DateDue;
                    xRec.ReferenceNumber = matchedRecord.ReferenceNumber;
                }
                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.DrainageRate()
            {
                Amount = nr.Amount,
                Body = nr.Body,
                DateDue = nr.DateDue,
                ReferenceNumber = nr.ReferenceNumber,
                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();
        }

        public void UpdateFundings(int acquisitionId, List<FundingDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.Funding.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();

           

            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.Amount = matchedRecord.Amount;
                xRec.ClaimedDate = matchedRecord.DateClaimed;
                xRec.ConditionsApprovedDate = matchedRecord.DateConditionsApproved;
                xRec.DonorName = matchedRecord.NameOfDonor;
                xRec.FundingConfirmedDate = matchedRecord.DateFoundingConfirmed;
                xRec.GiftAidOfferAmount = matchedRecord.GiftAidOfferAmount;
                xRec.GrantConditionsDescr = matchedRecord.GrantConditionsDescription;
                xRec.GrantConditionsExist = matchedRecord.GrantConditionsExist;
                xRec.OfferedDate = matchedRecord.DateOffered;
                xRec.PaymentReceivedDate = matchedRecord.PaymentReceivedDate;
                xRec.TypeId = matchedRecord.FundingTypeId.ID == 0 ? null : (int?) matchedRecord.FundingTypeId.ID;

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.Funding()
            {
                Amount = nr.Amount,

                //xRec.ClaimedDate = matchedRecord.DateClaimed;
                ClaimedDate = nr.DateClaimed,
                //xRec.ConditionsApprovedDate = matchedRecord.DateConditionsApproved;
                ConditionsApprovedDate = nr.DateConditionsApproved,
                //xRec.DonorName = matchedRecord.NameOfDonor;
                DonorName = nr.NameOfDonor,
                //xRec.FundingConfirmedDate = matchedRecord.DateFoundingConfirmed;
                FundingConfirmedDate = nr.DateFoundingConfirmed,
                //xRec.GiftAidOfferAmount = matchedRecord.GiftAidOfferAmount;
                GiftAidOfferAmount = nr.GiftAidOfferAmount,
                //xRec.GrantConditionsDescr = matchedRecord.GrantConditionsDescription;
                GrantConditionsDescr = nr.GrantConditionsDescription,
                //xRec.GrantConditionsExist = matchedRecord.GrantConditionsExist;
                GrantConditionsExist = nr.GrantConditionsExist,
                //xRec.OfferedDate = matchedRecord.DateOffered;
                OfferedDate = nr.DateOffered,
                //xRec.PaymentReceivedDate = matchedRecord.PaymentReceivedDate;
                PaymentReceivedDate = nr.PaymentReceivedDate,
                //xRec.TypeId = matchedRecord.FundingTypeId == 0 ? null : (int?)matchedRecord.FundingTypeId;
                TypeId = nr.FundingTypeId.ID == 0 ? null : (int?)nr.FundingTypeId.ID,

                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }

        public void UpdatePartDisposal(int acquisitionId, List<PartDisposalDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.PartDisposal.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.Address = matchedRecord.Address;
                xRec.County = matchedRecord.County;
                xRec.Description = matchedRecord.Description;
                xRec.DisposalDate = matchedRecord.DateOfDisposal;
                xRec.DisposedInterestId = matchedRecord.InterestDisposalId == 0
                    ? null
                    : (int?) matchedRecord.InterestDisposalId;
                xRec.Email = matchedRecord.Email;
                xRec.Name = matchedRecord.Name;
                xRec.Organisation = matchedRecord.Organisation;
                xRec.Postcode = matchedRecord.Postcode;
                xRec.Telephone = matchedRecord.Telephone;
                xRec.TotalReceivable = matchedRecord.TotalConsiderationReceivable;
                xRec.Town = matchedRecord.Town;



                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.PartDisposal()
            {

                //xRec.Address = matchedRecord.Address,
                Address = nr.Address,
                //xRec.County = matchedRecord.County,
                County = nr.County,
                //xRec.Description = matchedRecord.Description,
                Description = nr.Description,
                //xRec.DisposalDate = matchedRecord.DateOfDisposal,
                DisposalDate = nr.DateOfDisposal,
                //xRec.DisposedInterestId = matchedRecord.InterestDisposalId == 0
                //? null
                //: (int?)matchedRecord.InterestDisposalId,
                DisposedInterestId = nr.InterestDisposalId ==0 ?null : (int?)nr.InterestDisposalId,
                //xRec.Email = matchedRecord.Email,
                Email = nr.Email,
                //xRec.Name = matchedRecord.Name,
                Name = nr.Name,
                //xRec.Organisation = matchedRecord.Organisation,
                Organisation = nr.Organisation,
                //xRec.Postcode = matchedRecord.Postcode,
                Postcode = nr.Postcode,
                //xRec.Telephone = matchedRecord.Telephone,
                Telephone = nr.Telephone,
                //xRec.TotalReceivable = matchedRecord.TotalConsiderationReceivable,
                TotalReceivable = nr.TotalConsiderationReceivable,
                //xRec.Town = matchedRecord.Town,
                Town = nr.Town,

                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }

        public void UpdatePublicRightsOfWay(int acquisitionId, List<PublicRightOfWayDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.WayPublicRights.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingRecords
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.BridlewayDescription = matchedRecord.BridlewayDescription;
                xRec.Comments = matchedRecord.Comments;
                xRec.FootpathDescription = matchedRecord.FootpathDescription;
                xRec.HasBridleway = matchedRecord.Bridleway;
                xRec.HasFootpath = matchedRecord.Footpath;
                xRec.HasOther = matchedRecord.Other;
                xRec.OtherDescription = matchedRecord.OtherDescription;
                
                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.WayPublicRights()
            {

                BridlewayDescription = nr.BridlewayDescription,
                Comments = nr.Comments,
                FootpathDescription = nr.FootpathDescription,
                HasBridleway = nr.Bridleway,
                HasFootpath = nr.Footpath,
                HasOther = nr.Other,
                OtherDescription = nr.OtherDescription,

                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }
      
        public void UpdateStructures(int acquisitionId, List<StructureDto> editSet)
        {           
            var existingRecords = Context.Structure.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);



            var currentUserId = _iUserStore.CurrentUserId();
            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.AnnualMaintenanceCosts = matchedRecord.AnnualMaintenanceCosts;
                xRec.BriefReportSummary = matchedRecord.BriefReportSummary;
                xRec.Completed = matchedRecord.Completed;
                xRec.Description = matchedRecord.Description;
                xRec.ExternalSurveyorRequired = matchedRecord.ExternalSurveyorRequired;
                xRec.LastInspectionDate = matchedRecord.LastInspectionDate;
                xRec.NextInspectionDate = matchedRecord.NextInspectionDate;
                xRec.RebuildCost = matchedRecord.RebuildCost;
                xRec.ReportAuthor = matchedRecord.ReportAuthor;
                xRec.Responsibility = matchedRecord.Responsibility;
                xRec.ResponsibilityDescr = matchedRecord.ResponsibilityDescription;
                xRec.StructureConditionId = matchedRecord.StructureConditionId == 0
                    ? null
                    : (int?) matchedRecord.StructureConditionId;
                xRec.StructureTypeId = matchedRecord.StructureTypeId == 0 ? null : (int?) matchedRecord.StructureTypeId;


                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.Structure()
            {

                AnnualMaintenanceCosts = nr.AnnualMaintenanceCosts,
                BriefReportSummary = nr.BriefReportSummary,
                Completed = nr.Completed,
                Description = nr.Description,
                ExternalSurveyorRequired = nr.ExternalSurveyorRequired,
                LastInspectionDate = nr.LastInspectionDate,
                NextInspectionDate = nr.NextInspectionDate,
                RebuildCost = nr.RebuildCost,
                ReportAuthor = nr.ReportAuthor,
                Responsibility = nr.Responsibility,
                ResponsibilityDescr = nr.ResponsibilityDescription,
                StructureConditionId = nr.StructureConditionId == 0 ? null
                                                                        : (int?)nr.StructureConditionId,
                StructureTypeId = nr.StructureTypeId == 0 ? null : (int?)nr.StructureTypeId,

                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();

        }

        public void UpdateThirdPartyRights(int acquisitionId, List<ThirdPartyRightDto> editSet)
        {
            var existingRecords = Context.ThirdPartyRights.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);



            var currentUserId = _iUserStore.CurrentUserId();
            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();

            var deletedRecords = (from existingRecord in existingRecords
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord == null) continue;

                xRec.AgreementId = matchedRecord.AgreementTypeId == 0 ? null : (int?) matchedRecord.AgreementTypeId;
                xRec.AgreementFromDate = matchedRecord.AgreementFrom;
                xRec.AgreementWith = matchedRecord.AgreementWith;
                xRec.Comments = matchedRecord.Comments;
                xRec.CurrentAmount = matchedRecord.CurrentPaymentAmount;
                xRec.CurrentPaymentDate = matchedRecord.CurrentPaymentDate;
                xRec.CurrentReceivedDate = matchedRecord.CurrentReceivementDate;
                xRec.ForecastAmount = matchedRecord.ForecastPaymentAmount;
                xRec.ForecastPaymentDate = matchedRecord.ForecastPaymentDate;
                xRec.ForecastReceivedDate = matchedRecord.ForecastReceivementDate;
                xRec.InitialEnquiryDate = matchedRecord.InitialEnquiry;
                xRec.MtmapprovalDate = matchedRecord.MTMApproval;
                xRec.MtmapprovalTargetDate = matchedRecord.MTMApprovalTarget;
                xRec.ResponseReceivedDate = matchedRecord.ResponsiveReceived;
                xRec.ResponseReceivedTargetDate = matchedRecord.ResponsiveReceivedTarget;
                xRec.ResponseResult = matchedRecord.ResponseResult;
                xRec.ServiceId = matchedRecord.ServiceId == 0 ? null : (int?) matchedRecord.ServiceId;
                xRec.SouthernElectricDate = matchedRecord.SouthernElectric;
                xRec.SouthernElectricTargetDate = matchedRecord.SouthernElectricTarget;
                xRec.TypeId = matchedRecord.RightsTypeId == 0 ? null : (int?) matchedRecord.RightsTypeId;
                xRec.Wtdate = matchedRecord.WT;
                xRec.WttargetDate = matchedRecord.WTTarget;


                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }



            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.ThirdPartyRights()
            {
                AgreementId = nr.AgreementTypeId == 0 ? null : (int?)nr.AgreementTypeId,
                AgreementFromDate = nr.AgreementFrom,
                AgreementWith = nr.AgreementWith,
                Comments = nr.Comments,
                CurrentAmount = nr.CurrentPaymentAmount,
                CurrentPaymentDate = nr.CurrentPaymentDate,
                CurrentReceivedDate = nr.CurrentReceivementDate,
                ForecastAmount = nr.ForecastPaymentAmount,
                ForecastPaymentDate = nr.ForecastPaymentDate,
                ForecastReceivedDate = nr.ForecastReceivementDate,
                InitialEnquiryDate = nr.InitialEnquiry,
                MtmapprovalDate = nr.MTMApproval,
                MtmapprovalTargetDate = nr.MTMApprovalTarget,
                ResponseReceivedDate = nr.ResponsiveReceived,
                ResponseReceivedTargetDate = nr.ResponsiveReceivedTarget,
                ResponseResult = nr.ResponseResult,
                ServiceId = nr.ServiceId == 0 ? null : (int?)nr.ServiceId,
                SouthernElectricDate = nr.SouthernElectric,
                SouthernElectricTargetDate = nr.SouthernElectricTarget,
                TypeId = nr.RightsTypeId == 0 ? null : (int?)nr.RightsTypeId,
                Wtdate = nr.WT,
                WttargetDate = nr.WTTarget,
                AcquisitionUnitId = acquisitionId,

                Lmdt = DateTime.Today,
                Lmuid = currentUserId,
                Crdt = DateTime.Today,
                Cruid = currentUserId,
                Dldt = null,
                Dluid = null,

            }).ToList();

            Context.AddRange(recordsToAdd);
            Context.SaveChanges();
        }
        
        public void UpdateSubAcquisitionUnit(int acquisitionId, SubAcquisitionUnit subAcquisitionUnit)
        {
            var au = Context.AcquisitionUnit.FirstOrDefault(f => f.Id == acquisitionId);

            au.BeneficialCovenantsDescription = subAcquisitionUnit.BeneficialCovenantText;
            au.BeneficialCovenants = subAcquisitionUnit.BeneficialCovenantsExist;
            au.ContaminationDescription = subAcquisitionUnit.Contamination;
            au.HazardsAndLiabilities = subAcquisitionUnit.HazardsLiabilities;
            au.FormerNames = subAcquisitionUnit.Names;
            au.ManagementAccessDescription = subAcquisitionUnit.ManagementAccess;
            au.ManagementInformation = subAcquisitionUnit.ManagementInformation;
            au.MineralRightsDescription = subAcquisitionUnit.MineralRightsDescription;
            au.MineralRightsId = subAcquisitionUnit.MineralRightTypeId != 0
                ? (int?)subAcquisitionUnit.MineralRightTypeId
                : null;
            au.OtherRightsConveyedDescription = subAcquisitionUnit.OtherRightsConveyedDescription;
            au.PermissiveAccessDescription = subAcquisitionUnit.PermissiveAccessDescription;

            au.OtherRightsConveyed = subAcquisitionUnit.OtherRightsConveyedExists;
            au.PermissiveAccess = subAcquisitionUnit.PermissiveAccessExists;

            au.AdditionalInformation = subAcquisitionUnit.AdditionalInformationDescription;

            au.PublicAccessDescription = subAcquisitionUnit.Comment;

            au.RestrictiveCovenantsDescription = subAcquisitionUnit.RestrictiveCovenantDescription;
            au.RestrictiveCovenants = subAcquisitionUnit.RestrictiveCovenantsExist;

            au.ShootingRightsDescription = subAcquisitionUnit.ShootingDescription;

            au.ShootingRightsId = subAcquisitionUnit.ShootingFishingTypeId == 0 ? null : (int?)subAcquisitionUnit.ShootingFishingTypeId;

            au.SummaryDescription = subAcquisitionUnit.PlanningMattersDescription;

            au.Description = subAcquisitionUnit.PropertyInfoDescription;

            //BoundariesDescription = au.BoundariesDescription,
            au.BoundariesDescription = subAcquisitionUnit.BoundariesDescription;
            //DrainageRatesExist = au.DrainageRatesExist.GetValueOrDefault(),
            au.DrainageRatesExist = subAcquisitionUnit.DrainageRatesExist;
            //HighwayAuthorityId = au.HighwayAuthorityId.GetValueOrDefault(),
            au.HighwayAuthorityId = subAcquisitionUnit.HighwayAuthorityId ==0 ? null : (int?)subAcquisitionUnit.HighwayAuthorityId;
            //PublicRightsOfWayExist = au.HasPublicRightsOfWay.GetValueOrDefault(),
            au.HasPublicRightsOfWay = subAcquisitionUnit.PublicRightsOfWayExist;
            //StatutoryDeclarations = au.StatutoryDeclarationsDate,
            au.StatutoryDeclarationsDate = subAcquisitionUnit.StatutoryDeclarations;
            //StatutoryDeclarationsNext = au.NextStatutoryDeclarationsDate,
            au.NextStatutoryDeclarationsDate = subAcquisitionUnit.StatutoryDeclarationsNext;
            //HighwayAct = au.HighwaysActDate,
            au.HighwaysActDate = subAcquisitionUnit.HighwayAct;
            //HighwayActNext = au.NextHighwaysActDate,
            au.NextHighwaysActDate = subAcquisitionUnit.HighwayActNext;
            //StructuresDescription = au.StructuresDescription,
            au.StructuresDescription = subAcquisitionUnit.StructuresDescription;
            //StructuresExist = au.Structures,
            au.Structures = subAcquisitionUnit.StructuresExist;
            //ServicesDescription = au.ServicesDescription,
            au.ServicesDescription = subAcquisitionUnit.ServicesDescription;
            //ServicesExist = au.ServicesExist,
            au.ServicesExist = subAcquisitionUnit.ServicesExist;
            //ThirdPartyRightsDescription = au.ThirdPartyRightsDescription,
            au.ThirdPartyRightsDescription = subAcquisitionUnit.ThirdPartyRightsDescription;
            //ThirdPartyRightsExist = au.ThirdPartyRights,
            au.ThirdPartyRights = subAcquisitionUnit.ThirdPartyRightsExist;

            Context.SaveChanges();
        }

        public void UpdateCostCenter(int managementUnitId, string costCenter)
        {
            if (!ValidateCostCenter(costCenter)) return;

            int costCenterId = 0;

            bool invalidNumber = int.TryParse(costCenter, out costCenterId);


            var mu = Context.ManagementUnit.FirstOrDefault(f => f.Id == managementUnitId);

            if (mu != null)
                mu.Id = costCenterId;


            Context.SaveChanges();

        }

        public void DeleteAcquisitionUnits(int acquisitionId)
        {
            var acqs = Context.AcquisitionUnit.FirstOrDefault(w => !w.Deleted && w.Id == acquisitionId);

            if (acqs != null)
            {
                acqs.Deleted = true;
            }

            Context.SaveChanges();
        }

        public void UpdateGeneralDetails(int acquisitionId, PropertyGeneralDetailsDto propertyGeneralDetailsDto)
        {
            var aq = Context.AcquisitionUnit.FirstOrDefault(a => a.Id == acquisitionId);

            //  var managementUnit = Context.ManagementUnit.FirstOrDefault(f => f.Id == aq.ManagementUnitId);

            //    AdminArea = "unk location",
            //    DirectorySuppressed = false,
            //    GeneralPotSite = false,



            //var propertyGeneralDetailsDto = new PropertyGeneralDetailsDto
            //{
            //    AllowPOSO = managementUnit.AllowPoso,
            //    PotSite = managementUnit.IsPotSite,
            //    WCBudget = managementUnit.Wcbudget,
            //};

            aq.AdministrationArea = propertyGeneralDetailsDto.AdminArea;

            aq.AdministrationAreaId = propertyGeneralDetailsDto.AdminAreaId == 0 ? null : (int?)propertyGeneralDetailsDto.AdminAreaId;
            //    Id = aq.Id,
            //    NonFSC = aq.NonFsc.GetValueOrDefault(),
            aq.NonFsc = propertyGeneralDetailsDto.NonFSC;
            //    NonFSCDate = aq.NonFscasOfDate.GetValueOrDefault(),
            aq.NonFscasOfDate = propertyGeneralDetailsDto.NonFSCDate.Correct1918();
            //    NonFSCHa = aq.NonFscinHectares.GetValueOrDefault(),
            aq.NonFscinHectares = propertyGeneralDetailsDto.NonFSCHa;
            //    NonFSCType = aq.NonFsctypeId.GetValueOrDefault(),
            aq.NonFsctypeId = propertyGeneralDetailsDto.NonFSCType == 0 ? null : (int?)propertyGeneralDetailsDto.NonFSCType;
            //    Parish = aq.Parish,
            aq.Parish = propertyGeneralDetailsDto.Parish;
            //    LADistrict = aq.District
            aq.District = propertyGeneralDetailsDto.LADistrict;
            //    Disposed = aq.DateDisposed.HasValue ? true : false,
            // if(propertyGeneralDetailsDto.Disposed != aq.DateDisposed.GetValueOrDefault())
            //   aq.DateDisposed = DateTime.Today;

            aq.NonFsccomments = propertyGeneralDetailsDto.Comments;
            //    Comments = aq.NonFsccomments,

            aq.CountyId = propertyGeneralDetailsDto.County == 0 ? null : (int?)Context.County.First().Id;

            //    County = aq.CountyId.GetValueOrDefault(),


            Context.SaveChanges();

        }
        public void UpdateLegalTitle(int acquisitionId, PropertyLegalTitleDto propertyGeneralDetailsDto)
        {
            //Region = managementUnit.RegionId.GetValueOrDefault(),
            //CostCentre = aq.ManagementUnitId.ToString(),
            //ApplicationId = -1, //todo
            //    LandRegistryNumbers = "unknown field",

            var tenureId = Context.Tenure.First().Id;

            var aq = Context.AcquisitionUnit.Include(f => f.Farming)
                .FirstOrDefault(a => a.Id == acquisitionId);


            aq.DateDisposed = propertyGeneralDetailsDto.DateDisposed;

            //    AcquisitionTypeId = aq.TypeId,
            aq.TypeId = propertyGeneralDetailsDto.AcquisitionTypeId;

            //    DateCompleted = aq.DateContractCompleted.GetValueOrDefault(),
            aq.DateContractCompleted = propertyGeneralDetailsDto.DateCompleted;

            //    DateExchanged = aq.DateContractExchanged.GetValueOrDefault(),
            aq.DateContractExchanged = propertyGeneralDetailsDto.DateExchanged;

            //    DateLeasedTo3rdParty = aq.DateLeasedTo3rdParty.GetValueOrDefault(),
            aq.DateLeasedTo3rdParty = propertyGeneralDetailsDto.DateLeasedTo3rdParty;

            //    LeaseEnd = aq.LeaseEndDate.GetValueOrDefault(),
            aq.LeaseEndDate = propertyGeneralDetailsDto.LeaseEnd;

            //    LeaseStart = aq.LeaseStartDate.GetValueOrDefault(),
            aq.LeaseStartDate = propertyGeneralDetailsDto.LeaseStart;

            //    LeaseTerm = aq.LeaseTerm.GetValueOrDefault(),
            aq.LeaseTerm = propertyGeneralDetailsDto.LeaseTerm;

            //    Lessee = aq.Lessee,
            aq.Lessee = propertyGeneralDetailsDto.Lessee;

            //    Lessor = aq.Lessor,
            aq.Lessor = propertyGeneralDetailsDto.Lessor;

            //    MTMApprovalDate = aq.MtmdateApproved.GetValueOrDefault(),
            aq.MtmdateApproved = propertyGeneralDetailsDto.MTMApprovalDate;

            //    PurchasePrice = aq.PurchasePrice.GetValueOrDefault(),
            aq.PurchasePrice = propertyGeneralDetailsDto.PurchasePrice;

            //    Rent = aq.Rent.GetValueOrDefault(),
            aq.Rent = propertyGeneralDetailsDto.Rent;

            //    Tenure = aq.TenureId.GetValueOrDefault(),
            aq.TenureId = propertyGeneralDetailsDto.Tenure;

            //    ThirdPartyLeaseTerm = aq.ThirdPartyLeaseTerm.GetValueOrDefault(),
            aq.ThirdPartyLeaseTerm = propertyGeneralDetailsDto.ThirdPartyLeaseTerm;

            //    WTSolicitorsName = aq.WtsolicitorsName,
            aq.WtsolicitorsName = propertyGeneralDetailsDto.WTSolicitorsName;

            //    CLT = aq.Clt.GetValueOrDefault()
            aq.Clt = propertyGeneralDetailsDto.CLT;

            aq.TenureId = propertyGeneralDetailsDto.Tenure == 0 ? null : (int?)tenureId;



            Context.SaveChanges();

        }

        public void UpdateFarming(int acquisitionId, PropertyFarmingDto propertyGeneralDetailsDto)
        {
            var aq = Context.AcquisitionUnit.Include(f => f.Farming)
                .FirstOrDefault(a => a.Id == acquisitionId);

            if (aq.FarmingId != null)
            {
                //ARP = aq.Farming.Arp,
                aq.Farming.Arp = propertyGeneralDetailsDto.ARP;


                //CPHNO = aq.Farming.Cphno,
                aq.Farming.Cphno = propertyGeneralDetailsDto.CPHNO;

                //CSS = aq.Farming.Css,
                aq.Farming.Css = propertyGeneralDetailsDto.CSS;

                //CSSSRDPDate = aq.Farming.Cssdate.GetValueOrDefault(),
                aq.Farming.Cssdate = propertyGeneralDetailsDto.CSSSRDPDate;

                //CSSSRDP_RefNo = aq.Farming.CssrefNo,
                aq.Farming.CssrefNo = propertyGeneralDetailsDto.CSSSRDP_RefNo;

                //ELS = aq.Farming.Els,
                aq.Farming.Els = propertyGeneralDetailsDto.ELS;

                //ELSSRDPDate = aq.Farming.Elsdate.GetValueOrDefault(),
                aq.Farming.Elsdate = propertyGeneralDetailsDto.ELSSRDPDate;

                //ELSSRDP_RefNo = aq.Farming.ElsrefNo,
                aq.Farming.ElsrefNo = propertyGeneralDetailsDto.ELSSRDP_RefNo;

                //FWPS = aq.Farming.Fwps,
                aq.Farming.Fwps = propertyGeneralDetailsDto.FWPS;

                //GlastirAWE = aq.Farming.GlastirAwe,
                aq.Farming.GlastirAwe = propertyGeneralDetailsDto.GlastirAWE;

                //GlastirAWEDate = aq.Farming.GlastirAwedate.GetValueOrDefault(),
                aq.Farming.GlastirAwedate = propertyGeneralDetailsDto.GlastirAWEDate;

                //GlastirAWE_RefNo = aq.Farming.GlastirTerefNo,
                aq.Farming.GlastirAwerefNo = propertyGeneralDetailsDto.GlastirAWE_RefNo;



                //GlastirTE = aq.Farming.GlastirTe,
                aq.Farming.GlastirTe = propertyGeneralDetailsDto.GlastirTE;

                //GlastirTEDate = aq.Farming.GlastirTedate.GetValueOrDefault(),
                aq.Farming.GlastirTedate = propertyGeneralDetailsDto.GlastirTEDate;

                //GlastirTE_RefNo = aq.Farming.GlastirTerefNo,
                aq.Farming.GlastirTerefNo = propertyGeneralDetailsDto.GlastirTE_RefNo;

                //GlastirWCP = aq.Farming.GlastirWcp,
                aq.Farming.GlastirWcp = propertyGeneralDetailsDto.GlastirWCP;

                //HLS = aq.Farming.Hls,
                aq.Farming.Hls = propertyGeneralDetailsDto.HLS;

                //HLSSRDPDate = aq.Farming.Hlsdate.GetValueOrDefault(),
                aq.Farming.Hlsdate = propertyGeneralDetailsDto.HLSSRDPDate;

                //HLSSRDP_RefNo = aq.Farming.HlsrefNo,
                aq.Farming.HlsrefNo = propertyGeneralDetailsDto.HLSSRDP_RefNo;

                //ILP = aq.Farming.Ilp,
                aq.Farming.Ilp = propertyGeneralDetailsDto.ILP;

                //LFA = aq.Farming.Lfa,
                aq.Farming.Lfa = propertyGeneralDetailsDto.LFA;

                //Registered = aq.Farming.Registered,
                aq.Farming.Registered = propertyGeneralDetailsDto.Registered;

                //SBIBRNCRN = aq.Farming.Sbibrncrn,
                aq.Farming.Sbibrncrn = propertyGeneralDetailsDto.SBIBRNCRN;

                //SFPS = aq.Farming.Sfps,
                aq.Farming.Sfps = propertyGeneralDetailsDto.SFPS;

                //SRDP = aq.Farming.Srdp,
                aq.Farming.Srdp = propertyGeneralDetailsDto.SRDP;

                //VendorNo = aq.Farming.VendorNo.GetValueOrDefault(),
                aq.Farming.VendorNo = propertyGeneralDetailsDto.VendorNo;

                //WTFarmingLtd = aq.Farming.WtfarmingLtd
                aq.Farming.WtfarmingLtd = propertyGeneralDetailsDto.WTFarmingLtd;

                Context.SaveChanges();
            }
            else
            {
                var farm = new EDC_Estate.Models.DB.Farming()
                {
                    Arp = propertyGeneralDetailsDto.ARP,


                    //CPHNO = Cphno,
                    Cphno = propertyGeneralDetailsDto.CPHNO,

                    //CSS = Css,
                    Css = propertyGeneralDetailsDto.CSS,

                    //CSSSRDPDate = Cssdate.GetValueOrDefault(),
                    Cssdate = propertyGeneralDetailsDto.CSSSRDPDate,

                    //CSSSRDP_RefNo = CssrefNo,
                    CssrefNo = propertyGeneralDetailsDto.CSSSRDP_RefNo,

                    //ELS = Els,
                    Els = propertyGeneralDetailsDto.ELS,

                    //ELSSRDPDate = Elsdate.GetValueOrDefault(),
                    Elsdate = propertyGeneralDetailsDto.ELSSRDPDate,

                    //ELSSRDP_RefNo = ElsrefNo,
                    ElsrefNo = propertyGeneralDetailsDto.ELSSRDP_RefNo,

                    //FWPS = Fwps,
                    Fwps = propertyGeneralDetailsDto.FWPS,

                    //GlastirAWE = GlastirAwe,
                    GlastirAwe = propertyGeneralDetailsDto.GlastirAWE,

                    //GlastirAWEDate = GlastirAwedate.GetValueOrDefault(),
                    GlastirAwedate = propertyGeneralDetailsDto.GlastirAWEDate,

                    //GlastirAWE_RefNo = GlastirTerefNo,
                    GlastirTerefNo = propertyGeneralDetailsDto.GlastirAWE_RefNo,

                    //GlastirTE = GlastirTe,
                    GlastirTe = propertyGeneralDetailsDto.GlastirTE,

                    //GlastirTEDate = GlastirTedate.GetValueOrDefault(),
                    GlastirTedate = propertyGeneralDetailsDto.GlastirTEDate,

                    //GlastirTE_RefNo = GlastirTerefNo,

                    //GlastirWCP = GlastirWcp,
                    GlastirWcp = propertyGeneralDetailsDto.GlastirWCP,

                    //HLS = Hls,
                    Hls = propertyGeneralDetailsDto.HLS,

                    //HLSSRDPDate = Hlsdate.GetValueOrDefault(),
                    Hlsdate = propertyGeneralDetailsDto.HLSSRDPDate,

                    //HLSSRDP_RefNo = HlsrefNo,
                    HlsrefNo = propertyGeneralDetailsDto.HLSSRDP_RefNo,

                    //ILP = Ilp,
                    Ilp = propertyGeneralDetailsDto.ILP,

                    //LFA = Lfa,
                    Lfa = propertyGeneralDetailsDto.LFA,

                    //Registered = Registered,
                    Registered = propertyGeneralDetailsDto.Registered,

                    //SBIBRNCRN = Sbibrncrn,
                    Sbibrncrn = propertyGeneralDetailsDto.SBIBRNCRN,

                    //SFPS = Sfps,
                    Sfps = propertyGeneralDetailsDto.SFPS,

                    //SRDP = Srdp,
                    Srdp = propertyGeneralDetailsDto.SRDP,

                    //VendorNo = VendorNo.GetValueOrDefault(),
                    VendorNo = propertyGeneralDetailsDto.VendorNo,

                    //WTFarmingLtd = WtfarmingLtd
                    WtfarmingLtd = propertyGeneralDetailsDto.WTFarmingLtd,
                };

                Context.Farming.Add(farm);

                Context.SaveChanges();

                aq.FarmingId = farm.Id;

                Context.SaveChanges();


            }





        }

        public bool ValidateCostCenter(string costCenter)
        {
            int costCenterId = 0;

            bool invalidNumber = int.TryParse(costCenter, out costCenterId);

            if (!invalidNumber) return false;


            var existingUnits = Context.ManagementUnit.Select(m => m.Id).ToList();

            if (existingUnits.Contains(costCenterId)) return false;

            return true;

        }

        public void UpdateProperty(int acquisitionId, MainSectionDto propertyGeneralDetailsDto)
        {


            //WoodNo = aq.Id.ToString(),
            var aq = Context.AcquisitionUnit.Include(f => f.Farming)
                .FirstOrDefault(a => a.Id == acquisitionId);


            var mu = Context.ManagementUnit.First(f => f.Id == aq.ManagementUnitId);

            mu.RegionId = propertyGeneralDetailsDto.Region == 0 ? null : (int?)propertyGeneralDetailsDto.Region;

            var countyId = Context.County.First().Id;

            aq.WoodlandOfficerId = propertyGeneralDetailsDto.Manager;
            aq.AcquisitionOfficerId = propertyGeneralDetailsDto.LPM;
            aq.CountyId = propertyGeneralDetailsDto.County == 0 ? null : (int?)countyId;

            aq.TypeId = propertyGeneralDetailsDto.AcquisitionTypeId;
            aq.ManagedById = propertyGeneralDetailsDto.ManagedBy;
            aq.Location = propertyGeneralDetailsDto.Location;
            aq.GridReference = propertyGeneralDetailsDto.GridReference;
            aq.Name = propertyGeneralDetailsDto.SiteName;
            aq.GisareaInHectares = propertyGeneralDetailsDto.GISHa;
            aq.AreaInHectares = propertyGeneralDetailsDto.LandHa;
            aq.WoodAreaInHectares = propertyGeneralDetailsDto.WoodHa;
            aq.IsDefaultValue = propertyGeneralDetailsDto.SetAsMainAcquisitionUnit;
            aq.PostCode = propertyGeneralDetailsDto.PostCode;

            Context.SaveChanges();
        }

       

        #endregion
    }
}
