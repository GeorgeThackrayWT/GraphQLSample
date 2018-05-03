using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using Abstractions.Stores.Content.Safety;
using DataObjects.DTOS.SafetyObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.Safety
{
    public class SafetyEFStore : BaseEFStore, ISafetyStore
    {
        private readonly IManagementPlanAdminEFStore _adminStore;

        public SafetyEFStore(EstateContext ec, ICache iCache, IManagementPlanAdminEFStore iAdminStore, IUserStore iUserStore) : 
            base(ec, iCache)
        {
            _adminStore = iAdminStore;
            _iUserStore = iUserStore;
        }



        public List<SafetyDto> GetSafetyDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            List<SafetyDto> safetyDtos = new List<SafetyDto>();
         
            var riskAssessments = Context.RiskAssessment.ToList();       
            var hazardList = Context.Hazard.ToList();
            var biozones = Context.BiosecurityZone.ToList();
            var firezones = Context.FireAssessment.ToList();

            var managementUnits = _adminStore.GetAdminListDtos( userRole,userId,  application,  regionId);

            foreach (var m in managementUnits)
            {
                if (m.RiskID != null)
                {
                    var ra = riskAssessments.FirstOrDefault(f => f.Id == m.RiskID.Value);

                    var biozone = biozones.FirstOrDefault(f => f.Id == ra.BiosecurityZoneId.GetValueOrDefault());

                    var firezone = firezones.FirstOrDefault(f => f.Id == ra.FireAssessmentId.GetValueOrDefault());

                    var hazardCount = hazardList.Count(c => c.ManagementUnitId == m.ManagementUnitID);

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
                        RegionId =  m.RegionId,
                        DeputyID = m.DeputyID,
                        WoodlandOfficerID = m.WoodlandOfficerID,
                        AcquisitionOfficerID = m.AcquisitionOfficerID,
                        ApplicationId = m.ApplicationId,
                        CostCentre = m.CostCentre,
                        Manager = m.Manager,
                        Name = m.Name
                    });
                }
            }


            return safetyDtos.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o=>o.Name).ToList();
        }

        public List<HazardDto> GetHazardDtos(int managementUnitID)
        {
            var hazardList = Context.Hazard.Where(h => h.ManagementUnitId == managementUnitID).ToList();
            
            var types = this.GetHazardTypeDtos();
            var owners = this.GetHazardOwnershipDtos();

            return (from haz in hazardList
                let hazType = types.FirstOrDefault(w => w.Id == haz.TypeId.GetValueOrDefault()) ?? types.FirstOrDefault(w => w.Id == 0)
                let ownerShip = owners.FirstOrDefault(f => f.Id == haz.OwnershipId.GetValueOrDefault()) ?? owners.FirstOrDefault(f => f.Id == 0)
                select new HazardDto()
                {
                    Id = haz.Id,
                    ManagementUnitId = haz.ManagementUnitId,
                    Description = haz.Description,
                    HazardType = hazType,
                    WholeSite = haz.AppliesToEntireSite,
                    Ownership = ownerShip,
                    GridReference = haz.Easting + ";" + haz.Northing + ";" + haz.SiteCentreEasting + ";" + haz.SiteCentreNorthing,
                    MapRef = haz.MapReference,
                }).ToList();
        }

        public void UpdateHazards(int managementUnitId, List<HazardDto> editSet)
        {
            var existingHarvestings = Context.Hazard.Where(h => h.ManagementUnitId == managementUnitId).ToList();

            var currentUserId = _iUserStore.CurrentUserId();

           
            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingHarvestings.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingHarvestings
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();

            foreach (var hazard in existingHarvestings)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == hazard.Id);

                //   if (matchedRecord == null) continue;

                if (matchedRecord != null)
                {
                   
                    hazard.Description = matchedRecord.Description;
                    hazard.MapReference = matchedRecord.MapRef;
                    hazard.OwnershipId = matchedRecord.Ownership.Id == 0 ? null : (int?) matchedRecord.Ownership.Id;
                    hazard.TypeId = matchedRecord.HazardType.Id == 0 ? null : (int?) matchedRecord.HazardType.Id;
                    hazard.AppliesToEntireSite = matchedRecord.WholeSite;

                }

                if (deletedRecords.Any(f => f == hazard.Id))
                {
                    hazard.Deleted = true;
                    hazard.Dldt = DateTime.Today;
                    hazard.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new Hazard()
            {
                Description = nr.Description,
                MapReference = nr.MapRef,
                OwnershipId = nr.Ownership.Id == 0 ? null : (int?)nr.Ownership.Id,
                TypeId = nr.HazardType.Id == 0 ? null : (int?)nr.HazardType.Id,
                AppliesToEntireSite = nr.WholeSite,

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

        public RiskAssessmentDto GetRiskAssessmentDto(int managementUnitId)
        {
            var result = new RiskAssessmentDto();


            var manu = Context.ManagementUnit.FirstOrDefault(f => f.Id == managementUnitId);


            var ra = Context.RiskAssessment.FirstOrDefault(r => r.Id == manu.RiskAssessmentId && !r.Deleted);

            if (ra == null) return result;


            result.Id = ra.Id;
            result.CompletedByWoodlandOfficerId = ra.CompletedByWoodlandOfficerId;
            result.DateCompleted = ra.DateCompleted;
            result.Authorised = ra.Authorised;
            result.DateAuthorised = ra.DateAuthorised;
            result.AuthorisedByRegionalManagerId = ra.AuthorisedByRegionalManagerId;
            result.FireAssessmentId = ra.FireAssessmentId;
            result.BiosecurityZoneId = ra.BiosecurityZoneId;
            result.ReviewDate = ra.ReviewDate;
            result.PersonalIssues = ra.PersonalIssues;
                
            var measures = Context.ControlMeasure.Where(w => !w.Deleted && w.Id == ra.Id).ToList();

            result.IsContractorBasedWork = measures.Any(m => m.ControlMeasureTypeId == 1);
            result.IsVolunteerWork = measures.Any(m => m.ControlMeasureTypeId == 2);
            result.IsLicensed = measures.Any(m => m.ControlMeasureTypeId == 3);
            result.IsSiteInspection = measures.Any(m => m.ControlMeasureTypeId == 4);
            result.IsVoluntaryWarden = measures.Any(m => m.ControlMeasureTypeId == 5);
            result.IsAccidentReportingSystem = measures.Any(m => m.ControlMeasureTypeId == 6);
            result.IsWtSigns = measures.Any(m => m.ControlMeasureTypeId == 7);
            result.IsEmcwcContract = measures.Any(m => m.ControlMeasureTypeId == 8);

            if (ra.BiosecurityZoneId == null) return result;


            result.Amber = ra.BiosecurityZoneId == 2;
            result.Red = ra.BiosecurityZoneId == 1;
            result.Green = ra.BiosecurityZoneId == 3;


            return result;
        }


        public void UpdateRiskAssessment(int managementUnitId, RiskAssessmentDto riskAssessmentDto)
        {
          

            var ra = Context.RiskAssessment.FirstOrDefault(f => f.Id == riskAssessmentDto.Id);

            if (ra == null)
            {
                ra = new RiskAssessment();

            }

            if (riskAssessmentDto.FireAssessmentId == null)
                riskAssessmentDto.FireAssessmentId = 0;
            
            ra.CompletedByWoodlandOfficerId = riskAssessmentDto.CompletedByWoodlandOfficerId;
            ra.DateCompleted = riskAssessmentDto.DateCompleted;
            ra.Authorised = riskAssessmentDto.Authorised;
            ra.DateAuthorised = riskAssessmentDto.DateAuthorised;
            ra.AuthorisedByRegionalManagerId = riskAssessmentDto.AuthorisedByRegionalManagerId;
            ra.FireAssessmentId = riskAssessmentDto.FireAssessmentId == 0 ? 1: (int?)riskAssessmentDto.FireAssessmentId;
            ra.BiosecurityZoneId = riskAssessmentDto.BiosecurityZoneId;
            ra.ReviewDate = riskAssessmentDto.ReviewDate;
            ra.PersonalIssues = riskAssessmentDto.PersonalIssues;


            if (riskAssessmentDto.Amber)
                ra.BiosecurityZoneId = 2;

            if (riskAssessmentDto.Red)
                ra.BiosecurityZoneId = 1;

            if (riskAssessmentDto.Green)
                ra.BiosecurityZoneId = 3;

            foreach (var c in Context.ControlMeasure.Where(w => w.RiskAssessmentId == ra.Id))
            {
                c.Deleted = true;
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var cbw = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 1);                
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = cbw.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });

            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var ivw = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 2);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = ivw.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var isl = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 3);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = isl.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var isi = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 4);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = isi.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var ivwa = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 5);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = ivwa.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var iar = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 6);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = iar.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var iws = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 7);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = iws.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if (riskAssessmentDto.IsContractorBasedWork)
            {
                var iec = Context.ControlMeasureType.FirstOrDefault(f => f.Id == 8);
                Context.Add(new ControlMeasure()
                {
                    ControlMeasureTypeId = iec.Id,
                    RiskAssessmentId = riskAssessmentDto.Id
                });
            }

            if(ra.Id<0)
                Context.RiskAssessment.Add(ra);


            Context.SaveChanges();


            var manu = Context.ManagementUnit.FirstOrDefault(f => f.Id == managementUnitId);

            if (manu != null)
            {
                manu.RiskAssessmentId = ra.Id;
                Context.SaveChanges();
            }
            //return result;
        }

        public List<HazardTypeDtoLookup> GetHazardTypeDtos()
        {
            var hazardTypeDtos = new List<HazardTypeDtoLookup>
            {
                new HazardTypeDtoLookup
                {
                    CategoryId = 0,
                    Description = "Not Set",
                    Id = 0
                }
            };

            hazardTypeDtos.AddRange(Context.HazardType.Select(hazt => new HazardTypeDtoLookup
            {
                CategoryId = hazt.CategoryId,
                Description = hazt.Description,
                Id = hazt.Id
            }));


            return hazardTypeDtos;
        }

        public List<HazardCategoryDtoLookup> GetHazardCategoryDtos()
        {
            var hazardTypeDtos = new List<HazardCategoryDtoLookup>
            {
                new HazardCategoryDtoLookup()
                {
                    Description = "Not Set",
                    Id = 0
                }
            };

            hazardTypeDtos.AddRange(Context.HazardCategory.Select(hazt => new HazardCategoryDtoLookup
            {
                Description = hazt.Description,
                Id = hazt.Id
            }));

            return hazardTypeDtos;
        }

        public List<HazardOwnershipDtoLookup> GetHazardOwnershipDtos()
        {
            var hazardOwnershipDtos = new List<HazardOwnershipDtoLookup>
            {
                new HazardOwnershipDtoLookup()
                {
                    Description = "Not Set",
                    Id = 0
                }
            };
            
            hazardOwnershipDtos.AddRange(Context.HazardOwnership.Select(hazt => new HazardOwnershipDtoLookup()
            {
                Description = hazt.Description,
                Id = hazt.Id
            }));

            return hazardOwnershipDtos;
        }

        public List<HazardActionDto> GetHazardActionDtos(int hazardID)
        {
            var result = new List<HazardActionDto>();
            
            foreach (var hazAct in Context.HazardAction.Where(h=> h.HazardId == hazardID))
            {
                result.Add(new HazardActionDto()
                {
                    Id = hazAct.Id,
                    Description = hazAct.Description,
                    FollowOnActionId = hazAct.FollowOnActionId.GetValueOrDefault(),
                    FollowOnCompleteDate = hazAct.FollowOnComplete,
                    FollowOnDeadlineDate = hazAct.FollowOnDeadline,
                    FurtherAction = hazAct.FurtherAction,
                    HazardId = hazAct.HazardId,
                    InspectionActualDate = hazAct.ActualDate,
                    InspectionDeadlineDate = hazAct.DeadlineDate,
                    SeverityProbabilityOfHarmId = hazAct.SeverityProbabilityOfHarmId.GetValueOrDefault()
                });
            }

            return result;
        }

        public void UpdateHazardActions(int hazardId, List<HazardActionDto> editSet)
        {
            
            var existingHarvestings = Context.HazardAction.Where(h => h.Id == hazardId).ToList();

            var currentUserId = _iUserStore.CurrentUserId();


            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingHarvestings.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingHarvestings
                                    where !editSetIds.Contains(existingRecord.Id)
                                    select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();

            foreach (var hazAction in existingHarvestings)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == hazAction.Id);

                //   if (matchedRecord == null) continue;

                if (matchedRecord != null)
                {

                    hazAction.Description = matchedRecord.Description;
                    hazAction.ActualDate = matchedRecord.InspectionActualDate;
                    hazAction.FollowOnDeadline = matchedRecord.FollowOnDeadlineDate;
                    hazAction.FollowOnActionId = matchedRecord.FollowOnActionId == 0 ? null : (int?)matchedRecord.FollowOnActionId;
                    hazAction.FollowOnComplete = matchedRecord.FollowOnCompleteDate;
                    hazAction.FurtherAction = matchedRecord.FurtherAction;
                    hazAction.HazardId = hazardId;
                    hazAction.SeverityProbabilityOfHarmId = hazAction.SeverityProbabilityOfHarmId ==0 ?null :(int?)hazAction.SeverityProbabilityOfHarmId;
                }

                if (deletedRecords.Any(f => f == hazAction.Id))
                {
                    hazAction.Deleted = true;
                    hazAction.Dldt = DateTime.Today;
                    hazAction.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new HazardAction()
            {
                Description = nr.Description,
                //hazAction.ActualDate = matchedRecord.InspectionActualDate;
                ActualDate = nr.InspectionActualDate,

                //hazAction.FollowOnDeadline = matchedRecord.FollowOnDeadlineDate;
                FollowOnDeadline = nr.FollowOnDeadlineDate,

                //hazAction.FollowOnActionId = matchedRecord.FollowOnActionId;
                FollowOnActionId = nr.FollowOnActionId == 0 ? null : (int?)nr.FollowOnActionId,

                //hazAction.FollowOnComplete = matchedRecord.FollowOnCompleteDate;
                FollowOnComplete = nr.FollowOnCompleteDate,

                //hazAction.FurtherAction = matchedRecord.FurtherAction;
                FurtherAction = nr.FurtherAction,

                //hazAction.HazardId = hazardId;
                HazardId = hazardId,

                //hazAction.SeverityProbabilityOfHarmId = hazAction.SeverityProbabilityOfHarmId;
                SeverityProbabilityOfHarmId = nr.SeverityProbabilityOfHarmId == 0 ? null : (int?)nr.SeverityProbabilityOfHarmId,

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


        public List<HazardIncidentDto> GetHazardIncidentDtos(int hazardID)
        {
            var result = new List<HazardIncidentDto>();
   
            foreach (var hazAct in Context.HazardIncidentHistory.Where(h=>h.HazardId == hazardID))
            {
                result.Add(new HazardIncidentDto()
                {
                    Id = hazAct.Id,
                    Description = hazAct.Description,
                    HazardId = hazAct.HazardId,
                    DateRecorded = hazAct.DateRecorded
                });
            }


            return result;
        }

        public void UpdateHazardIncidents(int hazardId, List<HazardIncidentDto> editSet)
        {

        }

        public FireRiskCollectionDto GetFireRiskCollectionDto(int hazardID)
        { 
            return GetFireHazards(Context.HazardFireRisk.Where(w => w.HazardId == hazardID).Select(s => s.FireRiskTypeId).ToList());
        }


        private static FireRiskCollectionDto GetFireHazards(List<int> fireRiskTypes)
        {
            FireRiskCollectionDto fireRiskCollectionDto = new FireRiskCollectionDto()
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
                WoodlandCreationSiteId = 19
            };


            fireRiskCollectionDto.OneSigRiskFiveYears =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.OneSigRiskFiveYearsId);

            fireRiskCollectionDto.OneSigRiskFiveYears =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.OneSigRiskFiveYearsId);

            fireRiskCollectionDto.OneSigRiskType =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.OneSigRiskTypeId);

            fireRiskCollectionDto.NoSigInFiveYears =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.NoSigInFiveYearsId);

            fireRiskCollectionDto.Houses25M =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.Houses25MId);

            fireRiskCollectionDto.HousingAdjoiningSite =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.HousingAdjoiningSiteId);

            fireRiskCollectionDto.NoHousing =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.NoHousingId);

            fireRiskCollectionDto.NewCampFiresAnnually =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.NewCampFiresAnnuallyId);

            fireRiskCollectionDto.HistoryOfAccidentalFires =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.HistoryOfAccidentalFiresId);

            fireRiskCollectionDto.CampFiresOccasionally =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.CampFiresOccasionallyId);

            fireRiskCollectionDto.HistoryAccidentalFires =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.HistoryAccidentalFiresId);

            fireRiskCollectionDto.NoHistoryOfAccidentalFires =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.NoHistoryOfAccidentalFiresId);

            fireRiskCollectionDto.SiteContainsConiferBlocks25 =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteContainsConiferBlocks25Id);

            fireRiskCollectionDto.SiteContainsHeathland =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteContainsHeathlandId);

            fireRiskCollectionDto.SiteContainsBrash =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteContainsBrashId);

            fireRiskCollectionDto.SiteSoilsArePeat =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteSoilsArePeatId);

            fireRiskCollectionDto.SiteContainsMixedConifer =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteContainsMixedConiferId);

            fireRiskCollectionDto.SiteContainsSomeContinous =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.SiteContainsSomeContinousId);

            fireRiskCollectionDto.GroundFloraIncludes =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.GroundFloraIncludesId);

            fireRiskCollectionDto.PureBlWoodland =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.PureBlWoodlandId);

            fireRiskCollectionDto.LittleOrNoContinousArea =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.LittleOrNoContinousAreaId);

            fireRiskCollectionDto.WetThroughSummerMonths =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.WetThroughSummerMonthsId);

            fireRiskCollectionDto.WoodlandCreationSite =
                fireRiskTypes.Any(i => i == fireRiskCollectionDto.WoodlandCreationSiteId);

            return fireRiskCollectionDto;
        }

    }
}
