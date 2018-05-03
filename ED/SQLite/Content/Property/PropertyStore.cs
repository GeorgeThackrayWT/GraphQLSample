 using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using DataObjects.DAOS;
using DataObjects.DTOS;
using DataObjects.DTOS.property.subobjects;
 using EDCORE.ViewModel;
 using Stores;
using Utils;
using ManagementUnit = DataObjects.DAOS.ManagementUnit;

namespace SQLite
{
    public class PropertyStore : BaseStore, IPropertyStore
    {
        private readonly ISQLiteCache _iCache;
        private readonly ILookupStore _lookupStore;

        public PropertyStore(IDBPlatformSettings platform, ISQLiteCache iCache, ILookupStore iLookupStore)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _lookupStore = iLookupStore;

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public void UpdateAcquisitionUnitParent(int managementUnitId, List<AUID> editSet)
        {
            throw new System.NotImplementedException();
        }

        public List<AcquisitionUnit> GetAcquisitionUnits()
        {
            return _sqLiteSyncConnection.Table<AcquisitionUnit>().ToList();
        }

        public List<ManagementUnit> GetManagementUnits()
        {
            return _sqLiteSyncConnection.Table<ManagementUnit>().ToList();
        }

        public List<PropertyDto> GetPropertyList()
        {
            var returnList0 = new List<PropertyDto>();
            Stopwatch stopwatch = Stopwatch.StartNew();

            //Debug.WriteLine("cached value: " + _iCache.GetValue());

            var managedBys = _lookupStore.GetManagedByDtos();

            foreach (var v in _iCache.AcquisitionUnits)
            {
                var propertyDto = new PropertyDto();

                if (v.TenureID != null)
                    propertyDto.TenureDescription = _iCache.TenureLookup[v.TenureID.Value];

                propertyDto.LeaseTermYrs = v.LeaseTerm;

                propertyDto.ID = v.ID;
                propertyDto.SiteName = v.Name;
                propertyDto.GridReference = v.GridReference;
                propertyDto.Acquired = v.DateContractCompleted.GetValueOrDefault();

                propertyDto.LPMDescription = _iCache.UserLookup[v.AcquisitionOfficerID.GetValueOrDefault()];

                propertyDto.Manager = _iCache.UserLookup[v.WoodlandOfficerID];

                propertyDto.Location = v.Location;

                propertyDto.AreaHa = v.AreaInHectares;

                propertyDto.Region = _iCache.RegionLookup[
                    _iCache.ManagementUnits.First(f => f.Id == v.ManagementUnitID)
                        .RegionId.GetValueOrDefault()];

                var firstOrDefault = managedBys.FirstOrDefault(f => f.ID == v.ManagedByID);

                if (firstOrDefault != null)
                    propertyDto.ManagedBy = firstOrDefault.Name;

                propertyDto.CostCentre = v.ManagementUnitID;

                returnList0.Add(propertyDto);
            }

            stopwatch.Stop();

            //Debug.WriteLine("Time: " + stopwatch.ElapsedMilliseconds);

            return returnList0;
        }
        
        public PropertyEditDto GetProperty(int costCentreId)
        {

            PropertyEditDto propertyDto = new PropertyEditDto();

            propertyDto.AcquisitionUnitsFlip = new List<AcquisitionUnitDto>();

            

            var acquistions = _sqLiteSyncConnection
                .Table<AcquisitionUnit>().Where(m => m.ManagementUnitID == costCentreId);

 

            var managementUnit = _iCache.ManagementUnits.FirstOrDefault(m => m.Id == costCentreId);
 
            if (managementUnit == null)
                return propertyDto;


            foreach (var aq in acquistions)
            {

                var propertyGeneralDetailsDto = new PropertyGeneralDetailsDto
                {
                    Id = aq.ID,
                    AllowPOSO = managementUnit.AllowPOSO,
                    AdminArea = "unk location",
                    Comments = aq.NonFSCComments,
                    County = aq.CountyID.GetValueOrDefault(),
                    DirectorySuppressed = false,
                    Disposed = aq.DateDisposed.HasValue ? true :false,
                    GeneralPotSite = false,
                    NonFSC = aq.NonFSC.GetValueOrDefault(),
                    NonFSCDate = aq.NonFSCAsOfDate.GetValueOrDefault(),
                    NonFSCHa = aq.NonFSCInHectares.GetValueOrDefault(),
                    NonFSCType = aq.NonFSCTypeID.GetValueOrDefault(),
                    Parish = aq.Parish,
                    PotSite = managementUnit.IsPotSite,
                    WCBudget = managementUnit.WCBudget,    
                    LADistrict = aq.District
                };
 
                var farm = _sqLiteSyncConnection.Table<Farming>().First(m => m.ID == aq.FarmingID.GetValueOrDefault());

                var propertyFarming = new PropertyFarmingDto()
                {
                    Id = farm.ID,
                    ARP = farm.ARP,
                    CPHNO = farm.CPHNo,
                    CSS = farm.CSS,
                    CSSSRDPDate = farm.CSSDate.GetValueOrDefault(),
                    CSSSRDP_RefNo = farm.CSSRefNo,
                    ELS = farm.ELS,
                    ELSSRDPDate = farm.ELSDate.GetValueOrDefault(),
                    ELSSRDP_RefNo = farm.ELSRefNo,
                    FWPS = farm.FWPS,
                    GlastirAWE = farm.GlastirAWE,
                    GlastirAWEDate = farm.GlastirAWEDate.GetValueOrDefault(),
                    GlastirAWE_RefNo = farm.GlastirAWERefNo,
                    GlastirTE = farm.GlastirTE,
                    GlastirTEDate = farm.GlastirTEDate.GetValueOrDefault(),
                    GlastirTE_RefNo = farm.GlastirTERefNo,
                    GlastirWCP = farm.GlastirWCP,
                    HLS = farm.HLS,
                    HLSSRDPDate = farm.HLSDate.GetValueOrDefault(),
                    HLSSRDP_RefNo = farm.HLSRefNo,
                    ILP = farm.ILP,
                    LFA = farm.LFA,
                    Registered = farm.Registered,
                    SBIBRNCRN = farm.SBIBRNCRN,
                    SFPS = farm.SFPS,
                    SRDP = farm.SRDP,
                    VendorNo = farm.VendorNo.GetValueOrDefault(),
                    WTFarmingLtd = farm.WTFarmingLtd
                };



                var propertyLegalTitle = new PropertyLegalTitleDto()
                {
                    Id = aq.ID,
                    DateDisposed = aq.DateDisposed.GetValueOrDefault(),
                    AcquisitionTypeId = aq.TypeID,
                    DateCompleted = aq.DateContractCompleted.GetValueOrDefault(),
                    DateExchanged = aq.DateContractExchanged.GetValueOrDefault(),
                    DateLeasedTo3rdParty = aq.DateLeasedTo3rdParty.GetValueOrDefault(),
                    LandRegistryNumbers = "unknown field",
                    LeaseEnd = aq.LeaseEndDate.GetValueOrDefault(),
                    LeaseStart = aq.LeaseStartDate.GetValueOrDefault(),
                    LeaseTerm = aq.LeaseTerm.GetValueOrDefault(),
                    Lessee = aq.Lessee,
                    Lessor = aq.Lessor,
                    MTMApprovalDate = aq.MTMDateApproved.GetValueOrDefault(),
                    PurchasePrice = aq.PurchasePrice.GetValueOrDefault(),
                    Rent = aq.Rent.GetValueOrDefault(),
                    Tenure = aq.TenureID.GetValueOrDefault(),
                    ThirdPartyLeaseTerm = aq.ThirdPartyLeaseTerm.GetValueOrDefault(),
                    WTSolicitorsName = aq.WTSolicitorsName,
                    CLT = aq.CLT.GetValueOrDefault()
                };
                
                var mainAcquisitionUnit = new MainSectionDto()
                {
                    Id = aq.ID,
                    Region = managementUnit.RegionId.GetValueOrDefault(),
                    Manager = aq.WoodlandOfficerID,
                    LPM = aq.LMUID,
                    County = aq.CountyID.GetValueOrDefault(),
                    AcquisitionTypeId = aq.TypeID,
                    ManagedBy = aq.ManagedByID,
                    CostCentre = aq.ManagementUnitID.ToString(),
                    Location = aq.Location,
                    WoodNo = aq.ID.ToString(),
                    GridReference = aq.GridReference,                   
                    SiteName = aq.Name,
                    ApplicationId = -1, //todo
                    GISHa = aq.GISAreaInHectares.GetValueOrDefault(),
                    LandHa = aq.AreaInHectares,
                    WoodHa = aq.WoodAreaInHectares.GetValueOrDefault(),
                    SetAsMainAcquisitionUnit = aq.IsDefaultValue,
                    PostCode = aq.PostCode
                };
                
                propertyDto.AcquisitionUnitsFlip.Add(new AcquisitionUnitDto()
                {
                    ManagementUnitId = aq.ManagementUnitID,
                    AcquisitionMainSectionDto = mainAcquisitionUnit,
                    PropertyFarmingDto = propertyFarming,
                    PropertyGeneralDetailsDto = propertyGeneralDetailsDto,
                    PropertyLegalTitleDto = propertyLegalTitle
                });
            }

            



            return propertyDto;
            
        }

  
        private AcquisitionUnit GetAcquisitionUnit(int acquisitionId)
        {
            AcquisitionUnit acu;

           

            if (_iCache == null)
            {
                acu = _sqLiteSyncConnection.Table<AcquisitionUnit>().Where(w => w.ID == acquisitionId).FirstOrDefault();
            }
            else
            {
                acu = _iCache.AcquisitionUnits.FirstOrDefault(a=>a.ID == acquisitionId);
            }
            return acu;
        }

    
    
       
        public DirectoryInfoDto GetDirectoryInfo(int acquisitionId)
        {
            var acu = GetAcquisitionUnit(acquisitionId);
             
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

      

        AcquisitionUnitDto IPropertyStore.GetAcquisitionUnit(int acquisitionUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetManagementUnitIds()
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetAcquisitionIds(int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateGeneralDetails(int acquisitionId, PropertyGeneralDetailsDto propertyGeneralDetailsDto)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLegalTitle(int acquisitionId, PropertyLegalTitleDto propertyGeneralDetailsDto)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFarming(int acquisitionId, PropertyFarmingDto propertyGeneralDetailsDto)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProperty(int acquisitionId, MainSectionDto propertyGeneralDetailsDto)
        {
            throw new System.NotImplementedException();
        }

    

     

        public SubAcquisitionUnit GetSubAcquisitionUnit(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSubAcquisitionUnit(int acquisitionId, SubAcquisitionUnit subAcquisitionUnit)
        {
            throw new System.NotImplementedException();
        }

        List<AUID> IPropertyStore.GetAcquisitionIds(int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<BoundariesAndPlanDto> GetBoundariesAndPlansDto(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<ContactDto> GetContactsDto(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<DrainageRateDto> GetDrainageRatesDto(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<FundingDto> GetFundingDtos(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<PartDisposalDto> GetPartDisposal(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<PublicRightOfWayDto> GetPublicRightsOfWayDto(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<StructureDto> GetStructuresDto(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<ThirdPartyRightDto> GetThirdPartyRightDtos(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateThirdPartyRights(int acquisitionId, List<ThirdPartyRightDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStructures(int acquisitionId, List<StructureDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePublicRightsOfWay(int acquisitionId, List<PublicRightOfWayDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePartDisposal(int acquisitionId, List<PartDisposalDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFundings(int acquisitionId, List<FundingDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDrainages(int acquisitionId, List<DrainageRateDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateContacts(int acquisitionId, List<ContactDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBoundariesAndPlansDto(int acquisitionId, List<BoundariesAndPlanDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        List<LicenseDto> IPropertyStore.GetLicenseDto(int acquisitionId, List<int> licenseTypes)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLicenses(int acquisitionId, List<LicenseDto> editSet)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateCostCenter(string costCenter)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCostCenter(int managementUnitId, string costCenter)
        {
            throw new System.NotImplementedException();
        }


        public int SaveNewAcquisitionUnit(int managementUnitId, AUID auid)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAcquisitionUnits(int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public List<PropertyDto> GetPropertyList(int applicationId)
        {
            throw new System.NotImplementedException();
        }

        public List<PropertyDto> GetPropertyList(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}