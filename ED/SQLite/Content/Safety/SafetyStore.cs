using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Stores;
using DataObjects.DAOS;
using DataObjects.DTOS.SafetyObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using Stores;
using Abstractions.Stores.Content.Safety;
using EDCORE.ViewModel;

namespace SQLite.Content.Safety
{
    public class SafetyStore : BaseStore, ISafetyStore
    {

        private readonly ICache _iCache;
        private readonly IManagementPlanAdminEFStore _adminStore;

        public SafetyStore(IDBPlatformSettings platform, IManagementPlanAdminEFStore iAdminStore, ICache iCache)
        {
            _platform = platform;
            _iCache = iCache;
            _adminStore = iAdminStore;
            _sqLiteAsyncConnection = GetConnection();
            _sqLiteSyncConnection = GetSynchConnection();
        }

        public List<SafetyDto> GetSafetyDtos()
        {

            List<SafetyDto> safetyDtos = new List<SafetyDto>();

            var riskAssessments = _sqLiteSyncConnection.Query<RiskAssessment>(@"SELECT ID ,CompletedByWoodlandOfficerID ,DateCompleted ,Authorised ,DateAuthorised ,AuthorisedByRegionalManagerID ,FireAssessmentID ,BiosecurityZoneID ,ReviewDate ,PersonalIssues     
                                                                                    FROM RiskAssessment");

            var hazardList = _sqLiteSyncConnection.Query<Hazard>(@"SELECT ID, ManagementUnitID, TypeID FROM Hazard");


            var biozones = _sqLiteSyncConnection.Table<BiosecurityZone>();

            var firezones = _sqLiteSyncConnection.Table<FireAssessment>();

            var managementUnits = _adminStore.GetAdminListDtos(_iCache.CurrentUserRole(), _iCache.CurrentUser(), _iCache.GetApplication(), _iCache.CurrentUserRegion());

            foreach (var m in managementUnits)
            {
                if (m.RiskID != null)
                {
                    var ra = riskAssessments.FirstOrDefault(f => f.ID == m.RiskID.Value);

                    var biozone = biozones.FirstOrDefault(f => f.ID == ra.BiosecurityZoneID.GetValueOrDefault());

                    var firezone = firezones.FirstOrDefault(f=>f.ID == ra.FireAssessmentID.GetValueOrDefault());

                    var hazardCount = hazardList.Count(c => c.ManagementUnitID == m.ManagementUnitID);

                    safetyDtos.Add(new SafetyDto()
                    {
                        ID = m.ManagementUnitID,
                        Location = m.Location,
                        Authorised = true, //todo work this out
                        AuthorisedBy = m.ApprovedBy,
                        AuthorisedDate = m.ApprovedDate.GetValueOrDefault(),
                        ReviewDate = ra?.ReviewDate,
                        BiosecurityZone = biozone?.Description,
                        FireRisk = firezone?.Description,
                        MapUrl = "",
                        HazardCount = hazardCount,
                        Region = m.Region,
                        CostCentre = m.CostCentre,
                        Manager = m.Manager
                    });
                }
            }


            return safetyDtos;
        }

        public RiskAssessmentDto GetRiskAssessmentDto(int managementUnitID)
        {
            RiskAssessmentDto result = new RiskAssessmentDto();

            var riskAssessment = _sqLiteSyncConnection.Query<RiskAssessment>(@"SELECT ra.ID
                                                                  ,ra.CompletedByWoodlandOfficerID
                                                                  ,ra.DateCompleted
                                                                  ,ra.Authorised
                                                                  ,ra.DateAuthorised
                                                                  ,ra.AuthorisedByRegionalManagerID
                                                                  ,ra.FireAssessmentID
                                                                  ,ra.BiosecurityZoneID
                                                                  ,ra.ReviewDate
                                                                  ,ra.PersonalIssues   
                                                              FROM RiskAssessment ra
                                                              join ManagementUnit mu
                                                              on ra.ID  = mu.RiskAssessmentID where mu.ID = " + managementUnitID);



            if (riskAssessment.Count > 0)
            {
                result.Id = riskAssessment.First().ID;
                result.CompletedByWoodlandOfficerId = riskAssessment.First().CompletedByWoodlandOfficerID;
                result.DateCompleted = riskAssessment.First().DateCompleted;
                result.Authorised = riskAssessment.First().Authorised;
                result.DateAuthorised = riskAssessment.First().DateAuthorised;
                result.AuthorisedByRegionalManagerId = riskAssessment.First().AuthorisedByRegionalManagerID;
                result.FireAssessmentId = riskAssessment.First().FireAssessmentID;
                result.BiosecurityZoneId = riskAssessment.First().BiosecurityZoneID;
                result.ReviewDate = riskAssessment.First().ReviewDate;
                result.PersonalIssues = riskAssessment.First().PersonalIssues;


                var measures = _sqLiteSyncConnection.Query<ControlMeasure>(@"SELECT ID,RiskAssessmentID,ControlMeasureTypeID                                                                
                                                              FROM ControlMeasure where Deleted = 0 AND RiskAssessmentID = " + result.Id);
           
                result.IsContractorBasedWork = measures.Any(m => m.ControlMeasureTypeID == 1);
                result.IsVolunteerWork = measures.Any(m => m.ControlMeasureTypeID == 2);
                result.IsLicensed = measures.Any(m => m.ControlMeasureTypeID == 3);
                result.IsSiteInspection = measures.Any(m => m.ControlMeasureTypeID == 4);
                result.IsVoluntaryWarden = measures.Any(m => m.ControlMeasureTypeID == 5);
                result.IsAccidentReportingSystem = measures.Any(m => m.ControlMeasureTypeID == 6);
                result.IsWtSigns = measures.Any(m => m.ControlMeasureTypeID == 7);
                result.IsEmcwcContract = measures.Any(m => m.ControlMeasureTypeID == 8);

                if (riskAssessment.First().BiosecurityZoneID != null)
                {
                    result.Amber = riskAssessment.First().BiosecurityZoneID == 2 ? true : false;
                    result.Red = riskAssessment.First().BiosecurityZoneID == 1 ? true : false;
                    result.Green = riskAssessment.First().BiosecurityZoneID == 3 ? true : false;
                }

            }
            

            return result;
        }

        public List<HazardDto> GetHazardDtos(int managementUnitID)
        {
            List<HazardDto> hazardsDtos = new List<HazardDto>();

            var hazardList = _sqLiteSyncConnection.Query<Hazard>(@"SELECT ID ,ManagementUnitID,TypeID,OwnershipID,LocationId,Description,MapReference,Easting,Northing,SiteCentreEasting     
                                                                    FROM Hazard where ManagementUnitID = " + managementUnitID);



           


            var types = this.GetHazardTypeDtos();
            var owners = this.GetHazardOwnershipDtos();
            
            foreach (var haz in hazardList)
            {

                var hazType = types.FirstOrDefault(w => w.Id == haz.TypeID.GetValueOrDefault()) ??
                              types.FirstOrDefault(w => w.Id == 0);

                var ownerShip = owners.FirstOrDefault(f => f.Id == haz.OwnershipID.GetValueOrDefault()) ??
                                owners.FirstOrDefault(f => f.Id == 0);

                
                hazardsDtos.Add(new HazardDto()
                {
                    Id = haz.ID,
                    ManagementUnitId = haz.ManagementUnitID,
                    Description = haz.Description,
                    HazardType = hazType,
                    WholeSite = haz.AppliesToEntireSite,
                    Ownership = ownerShip,
                    GridReference = haz.Easting + ";" + haz.Northing + ";" + haz.SiteCentreEasting + ";" + haz.SiteCentreNorthing,              
                    MapRef = haz.MapReference,              
                });


            }
            
            return hazardsDtos;
        }


        public FireRiskCollectionDto GetFireRiskCollectionDto(int hazardID)
        {
            var firehazList = _sqLiteSyncConnection.Query<FireRiskDto>(@"SELECT FireRiskTypeID FROM HazardFireRisk WHERE HazardID = " + hazardID);


            return GetFireHazards(firehazList.Select(s=>s.FireRiskTypeId).ToList());

        }


        private static FireRiskCollectionDto GetFireHazards(List<int> fireRiskTypes)
        {
            FireRiskCollectionDto fireRiskCollectionDto = new FireRiskCollectionDto();


            //fireRiskCollectionDto.HazFireIncidentHistory.OneSigRiskFiveYears.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireIncidentHistory.OneSigRiskFiveYears.Id);

            //fireRiskCollectionDto.HazFireIncidentHistory.OneSigRiskType.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireIncidentHistory.OneSigRiskType.Id);

            //fireRiskCollectionDto.HazFireIncidentHistory.NoSigInFiveYears.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireIncidentHistory.NoSigInFiveYears.Id);


            //fireRiskCollectionDto.HazFirePotentialDamage.Houses25M.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFirePotentialDamage.Houses25M.Id);

            //fireRiskCollectionDto.HazFirePotentialDamage.HousingAdjoiningSite.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFirePotentialDamage.HousingAdjoiningSite.Id);

            //fireRiskCollectionDto.HazFirePotentialDamage.NoHousing.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFirePotentialDamage.NoHousing.Id);


            //fireRiskCollectionDto.HazFireSource.NewCampFiresAnnually.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireSource.NewCampFiresAnnually.Id);

            //fireRiskCollectionDto.HazFireSource.HistoryOfAccidentalFires.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireSource.HistoryOfAccidentalFires.Id);

            //fireRiskCollectionDto.HazFireSource.CampFiresOccasionally.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireSource.CampFiresOccasionally.Id);

            //fireRiskCollectionDto.HazFireSource.HistoryAccidentalFires.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireSource.HistoryAccidentalFires.Id);

            //fireRiskCollectionDto.HazFireSource.NoHistoryOfAccidentalFires.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireSource.NoHistoryOfAccidentalFires.Id);


            //fireRiskCollectionDto.HazFireTakingHold.SiteContainsConiferBlocks25.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteContainsConiferBlocks25.Id);

            //fireRiskCollectionDto.HazFireTakingHold.SiteContainsHeathland.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteContainsHeathland.Id);

            //fireRiskCollectionDto.HazFireTakingHold.SiteContainsBrash.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteContainsBrash.Id);

            //fireRiskCollectionDto.HazFireTakingHold.SiteSoilsArePeat.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteSoilsArePeat.Id);

            //fireRiskCollectionDto.HazFireTakingHold.SiteContainsMixedConifer.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteContainsMixedConifer.Id);

            //fireRiskCollectionDto.HazFireTakingHold.SiteContainsSomeContinous.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.SiteContainsSomeContinous.Id);

            //fireRiskCollectionDto.HazFireTakingHold.GroundFloraIncludes.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.GroundFloraIncludes.Id);

            //fireRiskCollectionDto.HazFireTakingHold.PureBlWoodland.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.PureBlWoodland.Id);

            //fireRiskCollectionDto.HazFireTakingHold.LittleOrNoContinousArea.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.LittleOrNoContinousArea.Id);

            //fireRiskCollectionDto.HazFireTakingHold.WetThroughSummerMonths.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.WetThroughSummerMonths.Id);

            //fireRiskCollectionDto.HazFireTakingHold.WoodlandCreationSite.IsSelected =
            //    fireRiskTypes.Any(i => i == fireRiskCollectionDto.HazFireTakingHold.WoodlandCreationSite.Id);

            return fireRiskCollectionDto;
        }


        public FireRiskCollectionDto CreateFireIncidentHistory()
        {
            FireRiskCollectionDto temp = new FireRiskCollectionDto
            {              
                OneSigRiskTypeId = 1,
                OneSigRiskFiveYearsId = 2,
                NoSigInFiveYearsId = 3,
                HousingAdjoiningSiteId = 19,
                Houses25MId = 20,
                NoHousingId = 21,
                NewCampFiresAnnuallyId = 4,
                HistoryOfAccidentalFiresId = 5,
                CampFiresOccasionallyId = 6,
                HistoryAccidentalFiresId = 7,
                NoHistoryOfAccidentalFiresId = 8,
                SiteContainsConiferBlocks25Id = 9,
                SiteContainsHeathlandId = 10,
                SiteContainsBrashId = 11,
                SiteSoilsArePeatId = 12,
                SiteContainsMixedConiferId = 13,
                SiteContainsSomeContinousId = 14,
                GroundFloraIncludesId = 15,
                PureBlWoodlandId = 16,
                LittleOrNoContinousAreaId = 17,
                WetThroughSummerMonthsId = 18,
                WoodlandCreationSiteId = 19,

                //HazFireIncidentHistory =
                //{
                //    OneSigRiskType = new FireRiskType() {Id = 1},
                //    OneSigRiskFiveYears = new FireRiskType() {Id = 2},
                //    NoSigInFiveYears = new FireRiskType() {Id = 3}
                //},

                //HazFirePotentialDamage =
                //{
                //    HousingAdjoiningSite = new FireRiskType() {Id = 19},
                //    Houses25M = new FireRiskType() {Id = 20},
                //    NoHousing = new FireRiskType() {Id = 21}
                //},

                //HazFireSource =
                //{
                //    NewCampFiresAnnually = new FireRiskType() {Id = 4},
                //    HistoryOfAccidentalFires = new FireRiskType() {Id = 5},
                //    CampFiresOccasionally = new FireRiskType() {Id = 6},
                //    HistoryAccidentalFires = new FireRiskType() {Id = 7},
                //    NoHistoryOfAccidentalFires = new FireRiskType() {Id = 8}
                //},

                //HazFireTakingHold =
                //{
                //    SiteContainsConiferBlocks25 = new FireRiskType() {Id = 9},
                //    SiteContainsHeathland = new FireRiskType() {Id = 10},
                //    SiteContainsBrash = new FireRiskType() {Id = 11},
                //    SiteSoilsArePeat = new FireRiskType() {Id = 12},
                //    SiteContainsMixedConifer = new FireRiskType() {Id = 13},
                //    SiteContainsSomeContinous = new FireRiskType() {Id = 14},
                //    GroundFloraIncludes = new FireRiskType() {Id = 15},
                //    PureBlWoodland = new FireRiskType() {Id = 16},
                //    LittleOrNoContinousArea = new FireRiskType() {Id = 17},
                //    WetThroughSummerMonths = new FireRiskType() {Id = 18},
                //    WoodlandCreationSite = new FireRiskType() {Id = 19}
                //}
            };
            
            return temp;
        }

        public List<HazardTypeDtoLookup> GetHazardTypeDtos()
        {

            List<HazardTypeDtoLookup> hazardTypeDtos = new List<HazardTypeDtoLookup>();

            var hazardList = _sqLiteSyncConnection.Query<HazardType>(@"Select ID,Description,CategoryID FROM HazardType");

            hazardTypeDtos.Add(new HazardTypeDtoLookup()
            {
                CategoryId = 0,
                Description = "Not Set",
                Id = 0
            });

            foreach (var hazt in hazardList)
            {
                hazardTypeDtos.Add(new HazardTypeDtoLookup()
                {
                    CategoryId = hazt.CategoryID,
                    Description = hazt.Description,
                    Id = hazt.ID
                });
            }

            return hazardTypeDtos;
        }

        public List<HazardCategoryDtoLookup> GetHazardCategoryDtos()
        {
            List<HazardCategoryDtoLookup> hazardTypeDtos = new List<HazardCategoryDtoLookup>();

            var hazardList = _sqLiteSyncConnection.Query<HazardCategory>(@"Select ID, Description FROM HazardCategory");

            hazardTypeDtos.Add(new HazardCategoryDtoLookup()
            {
                Description = "Not Set",
                Id = 0
            });


            foreach (var hazt in hazardList)
            {
                hazardTypeDtos.Add(new HazardCategoryDtoLookup()
                {                
                    Description = hazt.Description,
                    Id = hazt.ID
                });
            }

            return hazardTypeDtos;
        }

        public List<HazardIncidentDto> GetHazardIncidentDtos(int hazardID)
        {
            var result = new List<HazardIncidentDto>();

            var hazardList = _sqLiteSyncConnection.Query<HazardIncidentHistory>(@"SELECT ID,HazardID,Description,DateRecorded FROM HazardIncidentHistory WHERE HazardID  = " + hazardID);


            foreach (var hazAct in hazardList)
            {
                result.Add(new HazardIncidentDto()
                {
                    Id = hazAct.ID,
                    Description = hazAct.Description,               
                    HazardId = hazAct.HazardID,
                    DateRecorded = hazAct.DateRecorded
                });
            }


            return result;
        }

        public List<HazardActionDto> GetHazardActionDtos(int hazardID)
        {
            var result = new List<HazardActionDto>();

            var hazardList = _sqLiteSyncConnection.Query<HazardAction>(@"SELECT ID ,HazardID ,Description ,SeverityProbabilityOfHarmID
                                                          ,FurtherAction ,DeadlineDate ,ActualDate ,FollowOnActionID ,FollowOnDeadline ,FollowOnComplete   
                                                      FROM HazardAction
                                                      where HazardID  = " + hazardID);

            
            foreach (var hazAct in hazardList)
            {
                result.Add(new HazardActionDto()
                {
                    Id = hazAct.ID,
                    Description = hazAct.Description,
                    FollowOnActionId = hazAct.FollowOnActionID.GetValueOrDefault(),
                    FollowOnCompleteDate = hazAct.FollowOnComplete,
                    FollowOnDeadlineDate = hazAct.FollowOnDeadline,
                    FurtherAction = hazAct.FurtherAction,
                    HazardId = hazAct.HazardID,
                    InspectionActualDate = hazAct.ActualDate,
                    InspectionDeadlineDate = hazAct.DeadlineDate
                });
            }

            return result;
        }




        public List<HazardOwnershipDtoLookup> GetHazardOwnershipDtos()
        {

            List<HazardOwnershipDtoLookup> hazardOwnershipDtos = new List<HazardOwnershipDtoLookup>();

            var hazardList = _sqLiteSyncConnection.Query<HazardCategory>(@"Select ID, Description FROM HazardCategory");


            hazardOwnershipDtos.Add(new HazardOwnershipDtoLookup()
            {
                Description = "Not Set",
                Id = 0
            });

            foreach (var hazt in hazardList)
            {
                hazardOwnershipDtos.Add(new HazardOwnershipDtoLookup()
                {
                    Description = hazt.Description,
                    Id = hazt.ID
                });
            }

            return hazardOwnershipDtos;
        }

        public void UpdateHazards(int managementUnitId, List<HazardDto> editSet)
        {
            throw new NotImplementedException();
        }

        public void UpdateRiskAssessment(int managementUnitId, RiskAssessmentDto riskAssessmentDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateHazardActions(int hazardId, List<HazardActionDto> editSet)
        {
            throw new NotImplementedException();
        }

        public void UpdateHazardIncidents(int hazardId, List<HazardIncidentDto> editSet)
        {
            throw new NotImplementedException();
        }

        public List<SafetyDto> GetSafetyDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }


}


 