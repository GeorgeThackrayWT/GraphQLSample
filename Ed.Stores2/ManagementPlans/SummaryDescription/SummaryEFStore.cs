using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using EFStores.Fabric;
using Microsoft.EntityFrameworkCore;
using MvvmHelpers;

namespace EFStores
{
    public class SummaryEFStore : BaseEFStore, ISummaryStore
    {
        private readonly ILookupStore _iLookupStore;

        public SummaryEFStore(EstateContext ec,ICache iCache, ILookupStore iLookupStore, IUserStore iUserStore) :
            base(ec,iCache)
        {
            _iLookupStore = iLookupStore;
            _iUserStore = iUserStore;
        }



        public SummaryOverviewDto GetSummaryDescriptionContainerEditDto(int managementUnitID)
        {
            
     
            var acqu = Context.AcquisitionUnit.FirstOrDefault(
                a => a.ManagementUnitId == managementUnitID);
            

            var summaryDescriptiontEditContainerDto =
                new SummaryOverviewDto
                {
                    ManagementUnitId = managementUnitID,
                    SummaryDescription = acqu.SummaryDescription ?? "",
                    LongTermPolicyConclusions = _cache.ManagementUnitDtos.First(f => f.Id == managementUnitID).LongTermIntentions
                };

   
            return summaryDescriptiontEditContainerDto;
        }

        public List<SummaryDescriptiontListDTO> GetSummaryDescriptiontListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
        
            var retData = new List<SummaryDescriptiontListDTO>();

            string magicString = "SELECT        mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID, SUM(CASE dt.Reference WHEN \'SSSI\' THEN 1 ELSE 0 END) AS CountSSSI, CAST(MAX(CASE dt.Reference WHEN \'SSSI\' THEN 1 ELSE 0 END) AS BIT) AS IsSSSI, \r\n                         SUM(CASE dt.Reference WHEN \'TPO\' THEN 1 ELSE 0 END) AS CountTPO, CAST(MAX(CASE dt.Reference WHEN \'TPO\' THEN 1 ELSE 0 END) AS BIT) AS IsTPO, SUM(CASE dt.Reference WHEN \'AWS\' THEN 1 ELSE 0 END) \r\n                         AS CountAWS, CAST(MAX(CASE dt.Reference WHEN \'AWS\' THEN 1 ELSE 0 END) AS BIT) AS IsAWS, SUM(CASE dt.Reference WHEN \'AONB\' THEN 1 ELSE 0 END) AS CountAONB, \r\n                         CAST(MAX(CASE dt.Reference WHEN \'AONB\' THEN 1 ELSE 0 END) AS BIT) AS IsAONB, SUM(CASE dt.Reference WHEN \'NP\' THEN 1 ELSE 0 END) AS CountNP, CAST(MAX(CASE dt.Reference WHEN \'NP\' THEN 1 ELSE 0 END) \r\n                         AS BIT) AS IsNP, SUM(CASE dt.Reference WHEN \'SAM\' THEN 1 ELSE 0 END) AS CountSAM, CAST(MAX(CASE dt.Reference WHEN \'SAM\' THEN 1 ELSE 0 END) AS BIT) AS IsSAM, intDesignStats.AWR, intDesignStats.[DEMO W/C], \r\n                         intDesignStats.[DEMO AWR], intDesignStats.DIO, intDesignStats.DEST, intDesignStats.FA, intDesignStats.FWW, intDesignStats.LTM, intDesignStats.PPP, intDesignStats.PRP, intDesignStats.T4A, \r\n                         intDesignStats.TRAF AS Trafalgar, intDesignStats.WOYD, intDesignStats.WSP, MAX(sc.PAWSStatus) AS PAWSStatus, CAST(CASE WHEN COUNT(dt.ID) > 7 THEN 1 ELSE 0 END AS BIT) AS MoreDesignations\r\nFROM            dbo.vw_MainAcquisitionUnit AS mau INNER JOIN\r\n                         dbo.ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID INNER JOIN\r\n                         dbo.vw_InternalDesignationStats AS intDesignStats ON intDesignStats.[Cost Centre] = mu.ID LEFT OUTER JOIN\r\n                         dbo.SubCompartment AS sc ON sc.ManagementUnitID = mu.ID AND sc.Deleted = 0 LEFT OUTER JOIN\r\n                         dbo.AcquisitionUnit AS au ON au.ManagementUnitID = mu.ID AND au.Deleted = 0 LEFT OUTER JOIN\r\n                         dbo.Designation AS ds ON ds.AcquisitionUnitID = au.ID AND ds.Deleted = 0 LEFT OUTER JOIN\r\n                         dbo.DesignationType AS dt ON dt.ID = ds.TypeID AND dt.Deleted = 0\r\nGROUP BY mau.MainAcquisitionUnitID, mu.ID, intDesignStats.AWR, intDesignStats.[DEMO W/C], intDesignStats.[DEMO AWR], intDesignStats.DIO, intDesignStats.DEST, intDesignStats.FA, intDesignStats.FWW, intDesignStats.LTM, \r\n                         intDesignStats.PPP, intDesignStats.PRP, intDesignStats.T4A, intDesignStats.TRAF, intDesignStats.WOYD, intDesignStats.WSP";

            var data = ExecSQL<SummaryDescriptiont>(magicString, Context);

            //hack alert!!!

          //  List<int> addedAcqs = new List<int>();


            foreach (var v in data)
            {
                var manu = _cache.ManagementUnitDtos.FirstOrDefault(p => p.Id == v.ManagementUnitID);

                v.RegionId = manu.RegionId;
                v.WoodlandOfficerId = manu.WoodlandOfficerId;
                v.Name = manu.Name;
                v.ApplicationId = manu.ApplicationId;
                v.DeputyID = manu.DeputyId;
            }

            var acqCache = Context.AcquisitionUnit
                .Select(s => new {s.Id, s.ManagementUnitId, s.GisareaInHectares, s.Location, s.AcquisitionOfficerId}).ToList();

            foreach (var v in data)
            {

              //  if (addedAcqs.Contains(v.ManagementUnitID)) continue;

              //  addedAcqs.Add(v.ManagementUnitID);

                var areaTotal = acqCache.Where(a => a.ManagementUnitId == v.ManagementUnitID && a.GisareaInHectares!=null).Sum(s => s.GisareaInHectares.Value);
                
                var locat = acqCache.FirstOrDefault(a => a.Id == v.AcquisitionUnitID);

                var sum = new SummaryDescriptiontListDTO
                {
                    ManagementUnitID = v.ManagementUnitID,
                    CostCentre = v.ManagementUnitID,
                    Region = RegionName(v.RegionId),
                    RegionId = v.RegionId.GetValueOrDefault(),
                    DeputyID = v.DeputyID.GetValueOrDefault(),
                    WoodlandOfficerID = v.WoodlandOfficerId.GetValueOrDefault(),
                    ApplicationId = v.ApplicationId.GetValueOrDefault(),
                    AcquisitionOfficerID = locat!=null ? locat.AcquisitionOfficerId.GetValueOrDefault():0,
                    Manager = UserName(v.WoodlandOfficerId),
                    Name = v.Name == "" ? "No name entered" : v.Name,
                    Location = locat?.Location,
                    AONB = v.IsAONB.GetValueOrDefault(),
                    Ancient = v.AWR.GetValueOrDefault(),
                    AreaHa = areaTotal,
                    MoreDesignations = v.MoreDesignations.GetValueOrDefault(),
                    NP = v.IsNP.GetValueOrDefault(),
                    PAWS = v.PPP.GetValueOrDefault(),
                    PAWStatus = v.PAWSStatus.GetValueOrDefault().ToString(),
                    SAM = v.IsSAM.GetValueOrDefault(),
                    SSSI = v.IsSSSI.GetValueOrDefault(),
                    TPO = v.IsTPO.GetValueOrDefault()
                };

                retData.Add(sum);
            }
            
            return retData.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(p => p.Name).ToList();
        }



        public List<SummaryDto> GetSummaries(int managementUnitId)
        {
           // managementUnitId = 4354;

            var mainSpeciesLookup = _iLookupStore.GetMainSpeciesDTOs();
            var managementRegionsLookup = _iLookupStore.GetManagementRegimeDTOs();        
            var yearsLookup = _iLookupStore.GetYears();
           
            var summaryDescriptiontEditContainerDto = new List<SummaryDto>();
               

            var conditions = Context.SubCompartment.Where(m => m.ManagementUnitId == managementUnitId && !m.Deleted).ToList();



            foreach (var sc in conditions)
            {

                summaryDescriptiontEditContainerDto.Add(new SummaryDto()
                {
                    Id = sc.Id,
                    Year = sc.Year.GetValueOrDefault(),
                    YearLookup = yearsLookup.FirstOrDefault(f => f.ID == sc.Year.GetValueOrDefault()),

                    AreaHa = sc.AreaInHectares,
                    Compartment = sc.Compartment,
                    CompartmentDescription = sc.Description,

                    MainSpeciesID = sc.MainSpeciesId.GetValueOrDefault(),
                    MainSpecies = mainSpeciesLookup.FirstOrDefault(i => i.ID == sc.MainSpeciesId.GetValueOrDefault()),

                    SecondarySpeciesID = sc.SecondSpeciesId.GetValueOrDefault(),
                    SecondarySpecies = mainSpeciesLookup.FirstOrDefault(i => i.ID == sc.SecondSpeciesId.GetValueOrDefault()),

                    ManagementRegimeID = sc.ManagementRegimeId.GetValueOrDefault(),
                    ManagementRegime = managementRegionsLookup.FirstOrDefault(i => i.ID == sc.ManagementRegimeId.GetValueOrDefault()),


                    SubCompartmentID = sc.Id,
                    ManagementUnitId = managementUnitId,
                    SubCompartmentRef = sc.Reference
                });
                
            }

            return summaryDescriptiontEditContainerDto;
        }

        public List<SummaryDesignationDto> GetSummaryDesignations(int subCompartmentId)
        {
            var designationCache = Context.SubCompartmentDesignationMap.Include(i => i.Designation)
                .Include(ti => ti.SubCompartment).Where(s=>s.SubCompartmentId == subCompartmentId).Where(w=>!w.Deleted)
                .Select(s => new { SubCompartmentId = s.SubCompartment.Id, s.DesignationId, s.Designation.TypeId, s.Id }).ToList();

            var tp = designationCache.Where(w => w.TypeId != null).Select(d => new SummaryDesignationDto()
            {
                Id = d.Id,
                Description = new ComboBoxValue()
                {
                    ID = d.DesignationId,
                    Description = Context.DesignationType.FirstOrDefault(f => f.Id == d.TypeId.Value).Description,
                    Name = Context.DesignationType.FirstOrDefault(f => f.Id == d.TypeId.Value).Description
                }
            }).ToList();

            return tp;
        }

        public List<SummaryFeatureDto> GetSummaryFeatures(int subCompartmentId)
        {
            var conservationFeatures = new List<SummaryFeatureDto>();

            var conservationFeatureCache = Context.SubCompartmentFeatureMap.Include(f => f.SubCompartment)
                .Select(s => new SummaryFeatureDto()
                {
                    Id = s.Id,
                    Feature = new ComboBoxValue()
                    {
                        ID = s.FeatureId,
                        Description = Context.FeatureType.FirstOrDefault(f => f.Id == s.FeatureId).Description,
                        Name = Context.FeatureType.FirstOrDefault(f => f.Id == s.FeatureId).Description

                    },
                    FeatureId = s.FeatureId,
                    Description = s.Description,
                    Confidential = s.Confidential,
                    MapRef = s.MapRef,
                    SubCompartmentId = s.SubCompartmentId
                }).ToList();

            foreach (var d in conservationFeatureCache.Where(w => w.SubCompartmentId == subCompartmentId && !w.Deleted))
                conservationFeatures.Add(d);

            return conservationFeatures;
        }
        
        public List<SummaryConstraintDto> GetSummaryConstraints(int subCompartmentId)
        {
            var constraintTypes = Context.MajorManagementConstraintType.ToList();

            Debug.WriteLine("GetSummaryConstraints: " +subCompartmentId);

            var debugdata = Context.MajorManagementConstraintMap.Include(f => f.SubCompartment).Include(i => i.MajorManagementConstraint)
                .Where(w => w.SubCompartmentId == subCompartmentId && !w.Deleted)
                .ToList();



            var constraintCache = Context.MajorManagementConstraintMap.Include(f => f.SubCompartment).Include(i => i.MajorManagementConstraint)
                .Where(w => w.SubCompartmentId == subCompartmentId && !w.Deleted)
                .Select(s => new SummaryConstraintDto()
                {
                    Id = s.Id,
                    Confidential = s.MajorManagementConstraint.Confidential,
                    TypeID = s.MajorManagementConstraintTypeId,
                    OtherDescription = s.MajorManagementConstraint.OtherDescription,
                    SubCompartmentId = s.SubCompartmentId,
                    Type = new ComboBoxValue()
                    {
                        ID = s.MajorManagementConstraintTypeId,
                        Description = constraintTypes.FirstOrDefault(f => f.Id == s.MajorManagementConstraintTypeId).Description,
                        Name = constraintTypes.FirstOrDefault(f => f.Id == s.MajorManagementConstraintTypeId).Description
                    }
                }).ToList();

            return constraintCache;
        }

        public void UpdateSummaryDescriptionOverview(SummaryOverviewDto editSet, int managementId)
        {
            //  throw new System.NotImplementedException();

            var acqu = Context.AcquisitionUnit.FirstOrDefault(a => a.ManagementUnitId == managementId);

            acqu.SummaryDescription = editSet.SummaryDescription;

            var manu = Context.ManagementUnit.FirstOrDefault(f => f.Id == managementId);


            if (manu != null)
            {
                manu.LongTermIntentions = editSet.LongTermPolicyConclusions;
            }

            Context.SaveChanges();
        }

        public void UpdateSummaries(List<SummaryDto> editSet, int managementId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var xSubComps = Context.SubCompartment.Where(m => m.ManagementUnitId == managementId && !m.Deleted);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = xSubComps.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in xSubComps
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            foreach (var xRec in xSubComps)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);


                if (matchedRecord != null)
                {
                    xRec.AreaInHectares = matchedRecord.AreaHa;
                    xRec.Compartment = matchedRecord.Compartment;
                    xRec.Description = matchedRecord.CompartmentDescription;
                    xRec.MainSpeciesId = matchedRecord.MainSpecies.ID == 0
                        ? null
                        : (int?) matchedRecord.MainSpecies.ID;
                    xRec.SecondSpeciesId = matchedRecord.SecondarySpecies.ID == 0
                        ? null
                        : (int?) matchedRecord.SecondarySpecies.ID;
                    xRec.ManagementRegimeId = matchedRecord.ManagementRegime.ID == 0
                        ? null
                        : (int?) matchedRecord.ManagementRegime.ID;
                    xRec.Reference = matchedRecord.SubCompartmentRef;
                    xRec.Year = matchedRecord.YearLookup.ID;

                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {



                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }

            }


            var recordsToAdd = newRecords.Select(nr => new SubCompartment()
            {

                AreaInHectares = nr.AreaHa,
                Compartment = nr.Compartment,
                Description = nr.CompartmentDescription,
                MainSpeciesId = nr.MainSpecies.ID == 0
                    ? null
                    : (int?)nr.MainSpecies.ID,
                SecondSpeciesId = nr.SecondarySpecies.ID == 0
                ? null
                : (int?)nr.SecondarySpecies.ID,
                ManagementRegimeId = nr.ManagementRegime.ID == 0
                ? null
                : (int?)nr.ManagementRegime.ID,
                Reference = nr.SubCompartmentRef,
                ManagementUnitId =  managementId,
                Year = nr.YearLookup.ID,

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

        public void UpdateSummaryConstraints(List<SummaryConstraintDto> editSet, int subCompartmentId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var xSubComps = Context.MajorManagementConstraintMap.Where(e => !e.Deleted && e.SubCompartmentId == subCompartmentId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = xSubComps.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in xSubComps
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();



            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            foreach (var xRec in xSubComps)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);


                if (matchedRecord != null)
                {
                    xRec.MajorManagementConstraintTypeId = matchedRecord.TypeID; 
                    
                    xRec.SubCompartmentId = subCompartmentId;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }

            }


            var newTypesToAdd = newRecords.Select(s => s.TypeID);

            foreach (var record in Context.MajorManagementConstraintMap.Where(e =>
                e.Deleted && e.SubCompartmentId == subCompartmentId))
            {
                if (newTypesToAdd.Contains(record.MajorManagementConstraintTypeId))
                {
                    Context.Remove(record);
                }
            }

            Context.SaveChanges();
 

            List<int> typeRecord = new List<int>();

           
            foreach (var temp in newRecords)
            {
                if(typeRecord.Contains( temp.Type.ID)) continue;

                var record = new MajorManagementConstraintMap()
                {

                    SubCompartmentId = subCompartmentId,
                    MajorManagementConstraintTypeId = temp.Type.ID,

                    Lmdt = DateTime.Today,
                    Lmuid = currentUserId,
                    Crdt = DateTime.Today,
                    Cruid = currentUserId,
                    Dldt = null,
                    Dluid = null,

                };

                typeRecord.Add(temp.Type.ID);

                Context.Add(record);
            }

            Context.SaveChanges();
        }

        public void UpdateSummaryFeatures(List<SummaryFeatureDto> editSet, int subCompartmentId)
        {        
            var currentUserId = _iUserStore.CurrentUserId();

            var xSubComps = Context.SubCompartmentFeatureMap.Where(e => !e.Deleted);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = xSubComps.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in xSubComps
                                  where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            foreach (var xRec in xSubComps)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);


                if (matchedRecord != null)
                {
                    xRec.Confidential = matchedRecord.Confidential;
                    xRec.Description = matchedRecord.Description;
                    xRec.FeatureId = matchedRecord.FeatureId;
                    xRec.MapRef = matchedRecord.MapRef;
                    xRec.SubCompartmentId = matchedRecord.SubCompartmentId;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }

            }


            var insertedRecords = new List<int>();

            foreach (var record in newRecords)
            {
                if(insertedRecords.Contains(record.Feature.ID)) continue;

                var newRecord = new SubCompartmentFeatureMap()
                {
                    Confidential = record.Confidential,
                    Description = record.Description,
                    FeatureId = record.Feature.ID,
                    MapRef = record.MapRef,
                    SubCompartmentId = subCompartmentId,
                    Lmdt = DateTime.Today,
                    Lmuid = currentUserId,
                    Crdt = DateTime.Today,
                    Cruid = currentUserId,
                    Dldt = null,
                    Dluid = null,

                };

                insertedRecords.Add(record.Feature.ID);

                Context.Add(newRecord);
            }


            Context.SaveChanges();

        }

        public void UpdateSummaryDesignations(List<SummaryDesignationDto> editSet, int subCompartmentId)
        {

            var dupeList = new List<int>();

            List<SummaryDesignationDto> dedupeeditSet = new List<SummaryDesignationDto>();

            foreach (var v in editSet)
            {
                if(dupeList.Contains(v.Description.ID)) continue;
                

                dedupeeditSet.Add(v);

                dupeList.Add(v.Description.ID);
            }

            editSet = dedupeeditSet;


            var currentUserId = _iUserStore.CurrentUserId();

            var xSubComps = Context.SubCompartmentDesignationMap.Where(e => !e.Deleted && e.SubCompartmentId == subCompartmentId);

            var xSubCompsIncludingDeletions = Context.SubCompartmentDesignationMap.Where(e => e.SubCompartmentId == subCompartmentId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = xSubComps.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in xSubComps
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();


            var existingRecords = xSubComps.Select(s => s.DesignationId).ToList();

          //  var existingRecordsIncludingDeletions = xSubCompsIncludingDeletions.Select(s => s.DesignationId).ToList();

            foreach (var xRec in xSubComps)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id && !existingRecords.Contains(f.Description.ID));

                

                if (matchedRecord != null)
                {
                    Debug.WriteLine(matchedRecord.Description.ID);
                    xRec.DesignationId = matchedRecord.Description.ID;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }

            }

            List<int> insertedRecords = new List<int>();


            foreach (var record in newRecords)
            {
                if(insertedRecords.Contains(record.Description.ID)) continue;
              

                //resurrect deleted records if we are adding a new record with the same id
                //as an old one.
                //this is because designations has double primary key that includes deleted records
                var existingDeletedDesignation = xSubCompsIncludingDeletions.FirstOrDefault(x => x.DesignationId == record.Description.ID);

                if (existingDeletedDesignation != null)
                {
                    existingDeletedDesignation.Deleted = false;
                    continue;
                }

                 

                var newRecord = new SubCompartmentDesignationMap()
                {
                    DesignationId = record.Description.ID,
                    SubCompartmentId = subCompartmentId,

                    Lmdt = DateTime.Today,
                    Lmuid = currentUserId,
                    Crdt = DateTime.Today,
                    Cruid = currentUserId,
                    Dldt = null,
                    Dluid = null,

                };


                insertedRecords.Add(record.Description.ID);

                Context.Add(newRecord);
            }

         


            
            Context.SaveChanges();

        }
    }
}