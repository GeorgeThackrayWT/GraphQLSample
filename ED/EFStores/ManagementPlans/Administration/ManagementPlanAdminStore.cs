using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Administration.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;
using MvvmHelpers;

namespace EFStores
{
    public class ManagementPlanAdminStore : BaseEFStore, IManagementPlanAdminEFStore
    {
        public ManagementPlanAdminStore(EstateContext ec, ICache iCache, IUserStore iUserStore) :
            base(ec, iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<PesticideAdminDto> GetPesticideAdminDto(int managementUnitID)
        {
          
            var t = Context.Pesticide.Where(p => p.ManagementUnitId == managementUnitID).Select(x =>
                new PesticideAdminDto()
                {

                    Comments = x.Comments,
                    Product = x.ProductDescr,
                    ActiveIngredient = x.ActiveIngredientId.GetValueOrDefault(),
                    ApplicationMethodId = x.ApplicationMethodId.GetValueOrDefault(),
                    ApplicationRate = x.ApplicationRate,
                    ApplicationTypeId = x.ApplicationTypeId.GetValueOrDefault(),
                    ConcentrationQuantityUsed = x.ConcentrateQuantity,
                    ContractorName = x.ContractorName,
                    HowDisposed = x.SurplusDisposed,
                    LocationInSite = x.LocationInSite,
                    NetAreaTreatedHa = x.NetAreaTreatedHa.GetValueOrDefault(),
                    PesticideId = x.Id,
                    PurchaseOrderNo = x.OldPonumber,
                    ReasonForUse = x.ReasonForUseId.GetValueOrDefault(),
                    TargetSpecies = x.TargetSpeciesId.GetValueOrDefault(),
                    TypeOfSite = x.SiteClassificationId.GetValueOrDefault(),
                    UnitId = 0,
                    WeatherConditions = x.WeatherConditions,
                    WoodNumber = ""


                }).ToList();

            var testData = new PesticideAdminDto()
            {
                Comments = "comments",
                ActiveIngredient = 1,
                ApplicationMethodId = 1,
                ApplicationRate = 1.1,
                ApplicationTypeId = 1,
                ConcentrationQuantityUsed = 2.2,
                ContractorName = "contractor name",
                HowDisposed = "how disposed",
                LocationInSite = "locat in site",
                NetAreaTreatedHa = 3.3,
                PesticideId = 1,
                Product = "prod string",
                PurchaseOrderNo = "pur order no",
                ReasonForUse = 1,
                TargetSpecies = 1,
                TypeOfSite = 1,
                UnitId = 1,
                WeatherConditions = "weather cond",
                WoodNumber = "wood no"
            };

            t.Add(testData);
            
            return t;
        }

        public void UpdatePesticides(int managementUnitId, List<PesticideAdminDto> pesticideAdminDtos)
        {

            var currentUserId = _iUserStore.CurrentUserId();



            var existingData = Context.Pesticide.Where(i => i.ManagementUnitId == managementUnitId && !i.Deleted);

            List<int> editSetIds = pesticideAdminDtos.Select(i => i.Id).ToList();

            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = pesticideAdminDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();

            foreach (var xRec in existingData)
            {
                var matchedRecord = pesticideAdminDtos.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;
                    xRec.ActiveIngredientId = matchedRecord.ActiveIngredient == 0
                        ? null
                        : (int?) matchedRecord.ActiveIngredient;
                    xRec.ApplicationMethodId = matchedRecord.ApplicationMethodId == 0
                        ? null
                        : (int?) matchedRecord.ApplicationMethodId;
                    xRec.ApplicationRate = matchedRecord.ApplicationRate;
                    xRec.ApplicationTypeId = matchedRecord.ApplicationTypeId == 0
                        ? null
                        : (int?) matchedRecord.ApplicationTypeId;

                    xRec.Comments = matchedRecord.Comments;

                    xRec.ConcentrateQuantity = matchedRecord.ConcentrationQuantityUsed;
                    xRec.ContractorName = matchedRecord.ContractorName;
                    xRec.LocationInSite = matchedRecord.LocationInSite;
                    xRec.NetAreaTreatedHa = matchedRecord.NetAreaTreatedHa;
                    xRec.ProductDescr = matchedRecord.Product;
                    xRec.WeatherConditions = matchedRecord.WeatherConditions;
                    xRec.TargetSpeciesId = matchedRecord.TargetSpecies == 0 ? null : (int?) matchedRecord.TargetSpecies;
                    xRec.NetAreaTreatedHa = matchedRecord.NetAreaTreatedHa;
                    xRec.ReasonForUseId = matchedRecord.ReasonForUse ==0  ?null : (int?)matchedRecord.ReasonForUse;
                    xRec.ApplicationUnitId = matchedRecord.UnitId == 0 ? null : (int?) matchedRecord.UnitId;                    
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new Pesticide()
            {

                ActiveIngredientId = nr.ActiveIngredient == 0
                    ? null
                    : (int?)nr.ActiveIngredient,



                ApplicationMethodId = nr.ApplicationMethodId == 0
                ? null
                : (int?)nr.ApplicationMethodId,
                ApplicationRate = nr.ApplicationRate,
                ApplicationTypeId = nr.ApplicationTypeId == 0
                ? null
                : (int?)nr.ApplicationTypeId,

                Comments = nr.Comments,

                ConcentrateQuantity = nr.ConcentrationQuantityUsed,
                ContractorName = nr.ContractorName,
                LocationInSite = nr.LocationInSite,
        
                ProductDescr = nr.Product,
                WeatherConditions = nr.WeatherConditions,
                TargetSpeciesId = nr.TargetSpecies == 0 ? null : (int?)nr.TargetSpecies,
              
                ReasonForUseId = nr.ReasonForUse == 0 ? null : (int?)nr.ReasonForUse,
                ApplicationUnitId = nr.UnitId == 0 ? null : (int?)nr.UnitId,

                
                Lmdt = DateTime.Today,

                Lmuid = currentUserId,
                Cruid = currentUserId,
                Crdt = DateTime.Today,
                Dldt = DateTime.Today,
                Dluid = currentUserId
            }).ToList();

            Context.AddRange(recordsToAdd);

            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PesticideEntryDto> GetPesticideEntrys(int pesticideId)
        {
            var ps = Context.PesticideEntry.Where(w => w.PesticideId == pesticideId).Select(s => new PesticideEntryDto()
            {
                Id = s.Id,
                Date = s.Date,
                HoursWorked = s.HoursWorked,
                Operator = s.Operator
            }).ToList();

            return ps;
        }

        public void UpdatePesticideEntries(int pesticideId, List<PesticideEntryDto> pesticideEntryDtos)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = Context.PesticideEntry.Where(i => i.PesticideId == pesticideId && !i.Deleted);

            List<int> editSetIds = pesticideEntryDtos.Select(i => i.Id).ToList();

            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = pesticideEntryDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();

            foreach (var xRec in existingData)
            {
                var matchedRecord = pesticideEntryDtos.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;
                    xRec.PesticideId = matchedRecord.PesticideId;
                    xRec.HoursWorked = matchedRecord.HoursWorked;
                    xRec.Operator = matchedRecord.Operator;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }



            var recordsToAdd = newRecords.Select(nr => new PesticideEntry()
            {

                PesticideId = nr.PesticideId,
                HoursWorked = nr.HoursWorked,
                Operator = nr.Operator,

                Lmdt = DateTime.Today,

                Lmuid = currentUserId,
                Cruid = currentUserId,
                Crdt = DateTime.Today,
                Dldt = DateTime.Today,
                Dluid = currentUserId
            }).ToList();

            Context.AddRange(recordsToAdd);

            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateAdminEditDTO(AdminEditDTO adminEditDTO, int managementUnitId)
        {
            var manplan = Context.ManagementPlan.FirstOrDefault(p => p.Id == managementUnitId);
            var manu = Context.ManagementUnit.FirstOrDefault(p => p.Id == managementUnitId);

            if (manu != null)
            {
                manu.AccessCategory = adminEditDTO.AccessCategory;
                manu.NewEstateCategory = adminEditDTO.NewEstateCategory;
                manu.EstateCategory = adminEditDTO.EstateCategory;
                manu.InterimCategory = adminEditDTO.InterimCategory;
                manu.IsMainClumpedSite = adminEditDTO.MainClumpedSite;

                manu.ClumpedManagementUnitId = adminEditDTO.ClumpedWith == 0 ? null : (int?)adminEditDTO.ClumpedWith;
                manu.Name = adminEditDTO.SiteName;
                manu.WoodlandOfficerId = adminEditDTO.ManagerID;
                manu.DeputyId = adminEditDTO.DeputyManagerID == 0 ? null : (int?)adminEditDTO.DeputyManagerID;
                manu.DirectionsToMainEntrance = adminEditDTO.Directions;

            }

            if (manplan != null)
            {

                manplan.PeriodFrom = adminEditDTO.From;
                manplan.PeriodTo = adminEditDTO.To;
                manplan.DateApproved = adminEditDTO.ApprovedDate;
                manplan.ApprovedById = adminEditDTO.ApprovedBy;
                manplan.UnderReview = adminEditDTO.UnderReview;
                manplan.ReviewDeadline = adminEditDTO.ReviewDeadline;
                manplan.UnderConsultation = adminEditDTO.UnderConsultation;
                manplan.ConsultationEndDate = adminEditDTO.ConsultationDeadline;

            }

            Context.SaveChanges();


        }

        public List<AdminListDTO> GetAdminListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            //  var returnList = new List<AdminListDTO>();

            //var manu =Context.ManagementPlan.FirstOrDefault(p => p.Id == v.ManagementPlanId.GetValueOrDefault());

            // var areaTotal = Context.AcquisitionUnit.Where(a => a.ManagementUnitId == v.Id).Sum(s => s.AreaInHectares);

            Debug.WriteLine("GetAdminListDtos");

            var acqCache = Context.AcquisitionUnit.Include(i => i.Tenure).Where(d => !d.Deleted).Select(s => new
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

            var returnList = Context.ManagementUnit
                .Include(mp => mp.ManagementPlan).Include(mp => mp.Region).Include(u => u.WoodlandOfficer)
                .Where(p => p.ManagementPlanId != null && p.RegionId != null && p.Id >0)
                .OrderBy(o => o.Name)
                .Select(v => new AdminListDTO()
                {
                    CostCentre = v.Id,
                    Region = v.Region.Description,
                    RegionId = v.RegionId.GetValueOrDefault(),
                    ApplicationId = v.ApplicationId,
                    Manager = v.WoodlandOfficer.DisplayName,
                    WoodlandOfficerID = v.WoodlandOfficerId,
                    DeputyID = v.DeputyId.GetValueOrDefault(),
                    ManagementUnitID = v.Id,
                    Location = acqCache.Any(x=>x.ManagementUnitId == v.Id && x.Location!="")? acqCache.First(f=>f.ManagementUnitId == v.Id).Location :  "Unknown Location",
                    AcquisitionOfficerID = acqCache.Any(x => x.ManagementUnitId == v.Id ) ? acqCache.First(f => f.ManagementUnitId == v.Id).AcquisitionOfficerId.GetValueOrDefault() : 0,
                    Name = v.Name,
                    AccessCat = v.AccessCategory,
                    ApprovedBy = UserName(v.ManagementPlan.ApprovedById),
                    ApprovedDate = v.ManagementPlan.DateApproved,
                    ConsultationDeadline = v.ManagementPlan.ConsultationEndDate,
                    EstateCat = v.EstateCategory,
                    NewEstateCat = v.NewEstateCategory,
                    PlanFrom = v.ManagementPlan.PeriodFrom == null ? 0 : v.ManagementPlan.PeriodFrom.Value.Year,
                    PlanTo = v.ManagementPlan.PeriodTo == null ? 0 : v.ManagementPlan.PeriodTo.Value.Year,
                    UnderConsultation = v.ManagementPlan.UnderConsultation,
                    RiskID = v.RiskAssessmentId
                }).ToList();
            
            return returnList.Where(a=>a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public AdminEditDTO GetAdminEditDTO(int managementUnitID)
        {
            var adminEditDto = new AdminEditDTO();



            var featureData = Context.Feature.Where(f => !f.Deleted && f.ManagementUnitId == managementUnitID);

            var manu = Context.ManagementUnit.FirstOrDefault(p => p.Id == managementUnitID);

            var manplan = Context.ManagementPlan.FirstOrDefault(p => p.Id == manu.ManagementPlanId.GetValueOrDefault());


            adminEditDto.ManagementUnitID = manu.Id;
            adminEditDto.AccessCategory = manu.AccessCategory;
            adminEditDto.NewEstateCategory = manu.NewEstateCategory;
            adminEditDto.EstateCategory = manu.EstateCategory;
            adminEditDto.InterimCategory = manu.InterimCategory;
            adminEditDto.MainClumpedSite = manu.IsMainClumpedSite;
            adminEditDto.PartOfClumpedSite = false;
            adminEditDto.ClumpedWith = manu.ClumpedManagementUnitId.GetValueOrDefault();

            adminEditDto.Aim1Creation = featureData.Any(e => e.AimId == 1);
            adminEditDto.Aim2Biodiversity = featureData.Any(e => e.AimId == 2);
            adminEditDto.Aim3PeopleEngagement = featureData.Any(e => e.AimId == 3);

            if (manplan != null)
            {
                adminEditDto.From = manplan.PeriodFrom;
                adminEditDto.To = manplan.PeriodTo;
                adminEditDto.ApprovedDate = manplan.DateApproved;
                adminEditDto.ApprovedBy = manplan.ApprovedById.GetValueOrDefault();
                adminEditDto.UnderReview = manplan.UnderReview;
                adminEditDto.ReviewDeadline = manplan.ReviewDeadline;
                adminEditDto.UnderConsultation = manplan.UnderConsultation;
                adminEditDto.ConsultationDeadline = manplan.ConsultationEndDate;
            }

            adminEditDto.SiteName = manu.Name;
            adminEditDto.ManagerID = manu.WoodlandOfficerId;
            adminEditDto.DeputyManagerID = manu.DeputyId.GetValueOrDefault();
            adminEditDto.Directions = manu.DirectionsToMainEntrance;


            return adminEditDto;
        }        
    }
}