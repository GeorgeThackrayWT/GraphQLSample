using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;

namespace EFStores
{
    public class ReferenceInfoListData
    {
        public int ID { get; set; }

        public int? ApplicationId { get; set; }

        public int? RegionId { get; set; }

        public int? WoodlandOfficerId { get; set; }

        public string Name { get; set; }

        public int ManagementUnitID { get; set; }

        public int WildlifeConservation { get; set; }

        public int RecreationAndAccess { get; set; }

        public int Landscape { get; set; }

        public int ArchaeologyHistory { get; set; }

        public int Community { get; set; }

        public int ManagementHistory { get; set; }

        public int MapsPhotography { get; set; }

        public int SurveyConsultation { get; set; }

        public int? WoodlandOfficerID { get; set; }

        public int? DeputyID { get; set; }

    }


    public class ObjectiveEFStore : BaseEFStore, IObjectiveStore
    {
        public ObjectiveEFStore(EstateContext ec,ICache iCache, IUserStore iUserStore) : 
            base(ec,iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<ObjectivesDTO> GetObjectivesContainerEditDto(int managementUnitID)
        {
            
            var data = Context.Feature.Where(d => !d.Deleted && d.ManagementUnitId == managementUnitID)
                .Select(s => new ObjectivesDTO()
                {
                    Id=s.Id,
                    Description = s.Description,
                    FeatureID = s.Id,
                    AimID = s.AimId.GetValueOrDefault(),
                    ConditionAssessment = "",
                    FactorsCausingChange = s.FactorsCausingChange,
                    IsConfidential = s.Confidential,
                    IsWholeSite = s.AppliesToEntireSite.GetValueOrDefault(),
                    IsWoodProduction = s.WoodProduction,
                    KeyFeatureTypeID = s.TypeId.GetValueOrDefault(),
                    LongTermObjective = s.LongTermObjective,
                    OpportunitiesAndConstraints = s.ConstraintsAndOpportunities,
                    Ref = s.Reference,
                    ShortTermObjective = s.ShortTermObjective,
                    Significance = s.Significance
                }).ToList();

        
            return data;
        }

        public List<ObjectiveKFListDTO> GetObjectiveKfListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            var retList = new List<ObjectiveKFListDTO>();
            
            var featureTypes = Context.FeatureType.ToList();

            var features = Context.Feature.ToList();
            
            foreach (var m in _cache.ManagementUnitDtos.OrderBy(o => o.Name))
            {
                var objectiveKFListDTO = new ObjectiveKFListDTO();
                var mfeatures = features.Where(f => f.ManagementUnitId == m.Id).ToList();

                objectiveKFListDTO.Aim1Creation = false;
                objectiveKFListDTO.Aim2Biodiversity = false;
                objectiveKFListDTO.Aim3People = false;
                objectiveKFListDTO.KF1 = "";
                objectiveKFListDTO.KF2 = "";
                objectiveKFListDTO.KF3 = "";
                objectiveKFListDTO.KF4 = "";
                objectiveKFListDTO.KF5 = "";

                var listfts = new List<string>();

                foreach (var feature in mfeatures)
                {
                    if (feature.AimId == 2)
                        objectiveKFListDTO.Aim2Biodiversity = true;

                    if (feature.AimId == 1)
                        objectiveKFListDTO.Aim1Creation = true;

                    if (feature.AimId == 3)
                        objectiveKFListDTO.Aim3People = true;

                    var ftlookup = featureTypes.FirstOrDefault(ft => ft.Id == feature.TypeId.GetValueOrDefault());

                    if (ftlookup != null)
                        listfts.Add(ftlookup.Description);

                }


                if (listfts.Count > 0)
                    objectiveKFListDTO.KF1 = listfts[0];
                if (listfts.Count > 1)
                    objectiveKFListDTO.KF2 = listfts[1];
                if (listfts.Count > 2)
                    objectiveKFListDTO.KF3 = listfts[2];
                if (listfts.Count > 3)
                    objectiveKFListDTO.KF4 = listfts[3];
                if (listfts.Count > 4)
                    objectiveKFListDTO.KF5 = listfts[4];


                objectiveKFListDTO.EstateCategory = m.EstateCategory;

                objectiveKFListDTO.ManagementUnitID = m.Id;
                objectiveKFListDTO.CostCentre = m.Id;
                objectiveKFListDTO.Name = m.Name == "" ? "No name entered" : m.Name;
                objectiveKFListDTO.Manager = UserName(m.WoodlandOfficerId);
                objectiveKFListDTO.Region = RegionName(m.RegionId);
                objectiveKFListDTO.RegionId = m.RegionId.GetValueOrDefault();
                objectiveKFListDTO.WoodlandOfficerID = m.WoodlandOfficerId;
                objectiveKFListDTO.DeputyID = m.DeputyId.GetValueOrDefault();
                objectiveKFListDTO.AcquisitionOfficerID = _cache.AcquisitionOfficerLookup.ContainsKey(m.Id)? _cache.AcquisitionOfficerLookup[m.Id] :0;
                objectiveKFListDTO.ApplicationId = m.ApplicationId;
                retList.Add(objectiveKFListDTO);
            }


            return retList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o=>o.Name).ToList();
        }

        public void UpdateObjectivesDTO(List<ObjectivesDTO> objectivesDtos, int recordId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = Context.Feature.Where(i => i.ManagementUnitId == recordId && !i.Deleted);

            List<int> editSetIds = objectivesDtos.Select(i => i.Id).ToList();

            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = objectivesDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();


            foreach (var xRec in existingData)
            {
                var matchedRecord = objectivesDtos.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;
                    xRec.TypeId = matchedRecord.KeyFeatureTypeID == 0 ? null : (int?)matchedRecord.KeyFeatureTypeID;
                    xRec.AimId = matchedRecord.AimID ==0 ? null : (int?)matchedRecord.AimID;
                    xRec.Reference = matchedRecord.Ref;
                    xRec.Confidential = matchedRecord.IsConfidential;
                    xRec.WoodProduction = matchedRecord.IsWoodProduction;
                    xRec.Description = matchedRecord.Description;
                    xRec.Significance = matchedRecord.Significance;
                    xRec.ConstraintsAndOpportunities = matchedRecord.OpportunitiesAndConstraints;
                    xRec.FactorsCausingChange = matchedRecord.FactorsCausingChange;
                    xRec.LongTermObjective = matchedRecord.LongTermObjective;
                    xRec.ShortTermObjective = matchedRecord.ShortTermObjective;            
                  
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new Feature()
            {
                
                //xRec.TypeId = KeyFeatureTypeID;
                TypeId = nr.KeyFeatureTypeID == 0 ? null : (int?)nr.KeyFeatureTypeID,
                //xRec.AimId = AimID == 0 ? null : (int?)AimID;
                AimId =  nr.AimID,
                //xRec.Reference = Ref;
                Reference = "F"+ (existingRecordIds.Count+1).ToString(),
                //xRec.Confidential = IsConfidential;
                Confidential = nr.IsConfidential,
                //xRec.WoodProduction = IsWoodProduction;
                WoodProduction = nr.IsWoodProduction,
                //xRec.Description = Description;
                Description = nr.Description,
                //xRec.Significance = Significance;
                Significance = nr.Significance,
                //xRec.ConstraintsAndOpportunities = OpportunitiesAndConstraints;
                ConstraintsAndOpportunities = nr.OpportunitiesAndConstraints,
                //xRec.FactorsCausingChange = FactorsCausingChange;
                FactorsCausingChange = nr.FactorsCausingChange,
                //xRec.LongTermObjective = LongTermObjective;
                LongTermObjective = nr.LongTermObjective,
                //xRec.ShortTermObjective = ShortTermObjective;
                ShortTermObjective = nr.ShortTermObjective,

                ManagementUnitId = recordId,

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
    }
}