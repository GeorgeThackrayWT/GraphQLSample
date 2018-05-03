using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.TreePlanting
{
    public class TreePlantingEFStore : BaseEFStore, ITreePlantingStore
    {
        public TreePlantingEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : base(ec,iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<TreePlantingSearchDto> GetTreePlantingDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            var results = new List<TreePlantingSearchDto>();


            // TO FIX THE MISSING FOREIGN KEY IN TREEPLANTINGDETAILS!!!!!!!
            // WHEN YOU GET THE ERROR!

            //GO
            //    ALTER TABLE dbo.TreePlantingDetail
            //    ADD CONSTRAINT FK_TreePlantingDetail_TreePlanting FOREIGN KEY(TreePlantingID)
            //REFERENCES dbo.TreePlanting(ID)
            //ON DELETE CASCADE
            //    ON UPDATE CASCADE
            //    ;
            //GO


            //GO
            //    ALTER TABLE dbo.TreePlantingDetail
            //    ADD CONSTRAINT FK_TreePlantingDetail_PlantingAccessType FOREIGN KEY(AccessTypeID)
            //REFERENCES dbo.PlantingAccessType(ID)
            //ON DELETE CASCADE
            //    ON UPDATE CASCADE
            //    ;
            //GO

            //GO
            //    ALTER TABLE dbo.TreePlantingDetail
            //    ADD CONSTRAINT FK_TreePlantingDetail_TerrainType FOREIGN KEY(TerrainTypeID)
            //REFERENCES dbo.TerrainType(ID)
            //ON DELETE CASCADE
            //    ON UPDATE CASCADE
            //    ;
            //GO

            var treePlantingLookup = Context.TreePlantingDetail.Include(tpd => tpd.TreePlanting).ThenInclude(tp => tp.SubCompartment).Where(w=>!w.Deleted).Select(
                p =>
                new {
                    p.TreePlanting.SubCompartment.ManagementUnit.Id,
                    p.PlantedArea, 
                    p.PlantingArea,
                    p.TreesToPlant,
                    p.TreePlanting.Completed
                }).ToList();


            //            var treeplanting = _sqLiteSyncConnection.Query<TPTempDto>(@"select sc.ManagementUnitID,tp.SuitableToBeSold,tp.Completed FROM SubCompartment AS sc 
            //--INNER JOIN  TreePlanting AS tp ON sc.ID = tp.SubCompartmentID WHERE sc.Deleted = 0 AND tp.Deleted = 0").ToList();

            var treeplanting = Context.TreePlanting.Include(tp => tp.SubCompartment)
                .Where(w => !w.Deleted && !w.SubCompartment.Deleted).Select(
                    p =>
                        new
                        {
                            p.SubCompartment.ManagementUnitId,
                            p.SuitableToBeSold,
                            p.Completed
                        }
                ).ToList();


            foreach (var c in _cache.ManagementUnitDtos)
            {

                var plantingDetailForMu = treePlantingLookup.Where(w => w.Id == c.Id).ToList();
                
                var wcAreaToPlant = plantingDetailForMu.Sum(p => p.PlantingArea.GetValueOrDefault());

                var wcAreaPlanted = plantingDetailForMu.Where(w => w.Completed).Sum(p => p.PlantingArea.GetValueOrDefault());

                var wcAreaAvailable = plantingDetailForMu.Where(w => !w.Completed).Sum(p => p.PlantingArea.GetValueOrDefault());

                var treeNumbersToPlant = plantingDetailForMu.Where(w => w.Completed).Sum(p => p.TreesToPlant.GetValueOrDefault());

                var treeNumbersAvailable = plantingDetailForMu.Where(w => !w.Completed).Sum(p => p.TreesToPlant.GetValueOrDefault());

                var plantingForMu = treeplanting.Where(w => w.ManagementUnitId == c.Id).ToList();

                var plantingComplete = plantingForMu.Any(p => p.Completed);

                var suitableToBeSold = plantingForMu.Any(p => p.SuitableToBeSold);


                results.Add(new TreePlantingSearchDto()
                {
                    ManagementUnitID = c.Id,
                    CostCentre = c.Id,
                    PlantingComplete = plantingComplete,
                    SuitableToBeSold = suitableToBeSold,
                    TreeNumbersPlanted = treeNumbersToPlant,
                    TreeNumbersAvailable = treeNumbersAvailable,
                    WCAreaAvailable = wcAreaAvailable,
                    WCAreaPlanted = wcAreaPlanted,
                    WCAreaToPlant = wcAreaToPlant,
                    Region = RegionName(c.RegionId),
                    RegionId = c.RegionId.GetValueOrDefault(),
                    DeputyID = c.DeputyId.GetValueOrDefault(),
                    WoodlandOfficerID = c.WoodlandOfficerId,
                    AcquisitionOfficerID = _cache.AcquisitionOfficerLookup.ContainsKey(c.Id) ? _cache.AcquisitionOfficerLookup[c.Id] :0,
                    ApplicationId = c.ApplicationId,
                    Manager =UserName(c.WoodlandOfficerId),
                    Location = c.Name,
                });
            }


            return results.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public List<TreePlantDto> GetTreePlantDtos(int managementUnitID)
        {
 
            List<TreePlantDto> results = new List<TreePlantDto>();

            foreach (var s in Context.TreePlanting.Include(tp => tp.SubCompartment)
                .Where(w => w.SubCompartment.ManagementUnitId == managementUnitID && !w.Deleted))
            {
                var lookupList = Context.TreePlantingDetail.Where(tpd => tpd.TreePlantingId == s.Id);
                var wcArea = 0.0;
                var area = 0.0;

                if (lookupList.Any())
                {
                    wcArea = lookupList.Sum(p => p.PlantedArea);
                    area = lookupList.Where(a => a.PlantingArea != null).Sum(p => p.PlantingArea.Value);
                }



                var newRecord = new TreePlantDto()
                {
                    Id = s.Id,
                    SubCompartmentID = new SubCompartmentLookupDto()
                    {
                        Id = s.SubCompartmentId,
                        Description = s.SubCompartment.Description,
                        AreaInHectares = s.SubCompartment.AreaInHectares,
                        Reference = s.SubCompartment.Reference,
                    },
                    PlantingDate = s.PlantingDate,
                    PlantedByID = new ComboBoxValue()
                    {
                        ID = s.PlantedBy.Id,
                        Description = s.PlantedBy.Description,
                    },

                    PlantingTypeID = new ComboBoxValue()
                    {
                        ID = s.PlantingType.Id,
                        Description = s.PlantingType.Description,
                    },
                    Completed = s.Completed,
                    SuitableToBeSold = s.SuitableToBeSold,
                    WCAreaHa = wcArea,
                    AreaHa = area

                };

                results.Add(newRecord);

            }




            //.Select(s => new TreePlantDto()
            //{
            //    Id = s.Id,               
            //    SubCompartmentID = new SubCompartmentLookupDto()
            //    {
            //        Id = s.SubCompartmentId,
            //        Description = s.SubCompartment.Description,
            //        AreaInHectares = s.SubCompartment.AreaInHectares,
            //        Reference = s.SubCompartment.Reference,
            //    },
            //    PlantingDate = s.PlantingDate,
            //    PlantedByID = new ComboBoxValue()
            //    {
            //        ID = s.PlantedBy.Id,
            //        Description = s.PlantedBy.Description,                    
            //    },
            //    //PlantedByID = s.PlantedById,
            //    //PlantingTypeID = s.PlantingTypeId,
            //    PlantingTypeID = new ComboBoxValue()
            //    {
            //        ID = s.PlantingType.Id,
            //        Description = s.PlantingType.Description,
            //    },
            //    Completed = s.Completed,
            //    SuitableToBeSold = s.SuitableToBeSold,
            //    WCAreaHa = s.TreePlantingDetails.Sum(p=>p.PlantedArea),
            //    AreaHa = s.TreePlantingDetails.Where(a=>a.PlantingArea!=null).Sum(p => p.PlantingArea.Value)

            //}).ToList();


            return results;
        }

        public void UpdateTreePlantDtos(int managementUnitID, List<TreePlantDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.TreePlanting.Include(tp => tp.SubCompartment)
                .Where(w => w.SubCompartment.ManagementUnitId == managementUnitID && !w.Deleted);

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

                xRec.PlantedById = matchedRecord.PlantedByID.ID;
                xRec.PlantingDate = matchedRecord.PlantingDate;
                xRec.Completed = matchedRecord.Completed;
                xRec.PlantingTypeId = matchedRecord.PlantingTypeID.ID;
                xRec.SubCompartmentId = matchedRecord.SubCompartmentID.Id;
                xRec.SuitableToBeSold = matchedRecord.SuitableToBeSold;

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.TreePlanting()
            {
             
                Completed = nr.Completed,
                PlantedById = nr.PlantedByID.ID,
                PlantingDate = nr.PlantingDate,
                PlantingTypeId = nr.PlantingTypeID.ID,
                SubCompartmentId = nr.SubCompartmentID.Id,
                SuitableToBeSold = nr.SuitableToBeSold,

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
        
        public List<TreePlantDetailDto> GetTreePlantDetailDtos(int treePlantingID)
        {
            var results = new List<TreePlantDetailDto>();

            Debug.WriteLine("getting details for : " + treePlantingID);

            foreach (var r in Context.TreePlantingDetail.Include(i => i.PlantingAccessType).Include(x => x.TerrainType).Where(tpd => !tpd.Deleted && tpd.TreePlantingId == treePlantingID))
            {
                results.Add(new TreePlantDetailDto()
                {
                    Id = r.Id,
                    Comments = r.Comments,
                    AccessID = new TreePlantAccessDto()
                    {
                        Id = r.PlantingAccessType.Id,
                        Description = r.PlantingAccessType.Description
                    },
                    AdultsCount = r.Adults,
                    AreaPlanted = r.PlantedArea,
                    AreaToPlant = r.PlantingArea,
                    ChildrenCount = r.Children,
                    DensityHa = 0,
                    TerrainID = new TreePlantTerrainDto()
                    {
                        Id = r.TerrainType.Id,
                        Description = r.TerrainType.Description
                    },
                    TreesAllocated = r.TreesAllocated,
                    TreesPlanted = r.TreesPlanted,
                    TreesToPlant = r.TreesToPlant
                });
            }

            return results;
        }

        public void UpdateTreePlantDetailsDtos(int treePlantingID, List<TreePlantDetailDto> editSet)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.TreePlantingDetail.Include(i => i.PlantingAccessType).Include(x => x.TerrainType)
                .Where(tpd => !tpd.Deleted && tpd.TreePlantingId == treePlantingID);

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

                xRec.AccessTypeId = matchedRecord.AccessID.Id;
                xRec.Adults = matchedRecord.AdultsCount;
                xRec.Comments = matchedRecord.Comments;
                xRec.Children = matchedRecord.ChildrenCount;
                xRec.PlantedArea = matchedRecord.AreaPlanted.GetValueOrDefault();
                xRec.PlantingArea = matchedRecord.AreaToPlant.GetValueOrDefault();
                //xRec.

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.TreePlantingDetail()
            {
                AccessTypeId = nr.AccessID.Id,
                TerrainTypeId = nr.TerrainID.Id,
                Adults = nr.AdultsCount,
                Children = nr.ChildrenCount,
                Comments = nr.Comments,
                PlantedArea = nr.AreaPlanted.GetValueOrDefault(),
                PlantingArea = nr.AreaToPlant.GetValueOrDefault(),
                TreesAllocated = nr.TreesAllocated,
                TreesPlanted = nr.TreesPlanted,
                TreesToPlant = nr.TreesToPlant,
                TreePlantingId = treePlantingID,
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


        public List<ComboBoxValue> GetPlantedByDtos()
        {
            var results = new List<ComboBoxValue>();
           
            foreach (var tree in Context.PlantedBy.Where(w=>!w.Deleted))
            {
                results.Add(new ComboBoxValue()
                {
                    ID = tree.Id,
                    Description = tree.Description
                });
            }

            return results;
        }

        public List<ComboBoxValue> GetPlantTypeDtos()
        {
            var results = new List<ComboBoxValue>();

            foreach (var tree in Context.PlantingType.Where(w=>!w.Deleted))
            {
                results.Add(new ComboBoxValue()
                {
                    ID = tree.Id,
                    Description = tree.Description
                });
            }

            return results;
        }

        public List<SubCompartmentLookupDto> GetSubCompartmentLookupDtos()
        {
            var results = new List<SubCompartmentLookupDto>();

            foreach (var r in Context.SubCompartment.Where(s=>!s.Deleted))
            {
                results.Add(new SubCompartmentLookupDto()
                {
                    Id = r.Id,
                    Reference = r.Reference
                });
            }

            return results;
        }

        public List<TreePlantDedicationsDto> GetTreePlantDedicationsDtos(int treePlantingID)
        {
            var results = new List<TreePlantDedicationsDto>();

            return results;
        }



        public List<TreePlantAccessDto> GetTreePlantAccessDtos()
        {         
            return Context.PlantingAccessType.Select(r => new TreePlantAccessDto()
            {
                Id = r.Id,
                Description = r.Description,
            }).ToList();
        }

        public List<TreePlantTerrainDto> GetTreePlantTerrainDtos()
        {        
            return Context.TerrainType.Select(r => new TreePlantTerrainDto()
            {
                Id = r.Id,
                Description = r.Description,
            }).ToList();
        }
    }
}
