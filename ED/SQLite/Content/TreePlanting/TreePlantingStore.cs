using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.TreePlanting;
using EDCORE.ViewModel;
using Stores;

namespace SQLite.Content.TreePlanting
{
    public class TreePlantingStore : BaseStore, ITreePlantingStore
    {
        private readonly ISQLiteCache _iCache;
        private readonly IGeneralAdminStore _adminStore;

        public TreePlantingStore(IDBPlatformSettings platform, IGeneralAdminStore iAdminStore, ISQLiteCache iCache)
        {
            _platform = platform;
            _iCache = iCache;
            _adminStore = iAdminStore;
            _sqLiteAsyncConnection = GetConnection();
            _sqLiteSyncConnection = GetSynchConnection();
        }

        public List<TreePlantingSearchDto> GetTreePlantingDtos()
        {
            var results = new List<TreePlantingSearchDto>();

            
            var test = _sqLiteSyncConnection.Query<TPTempDto>(@"select tp.ID, PlantingArea,tp.Completed,tpd.TreesToPlant,tpd.TreesPlanted,tp.SuitableToBeSold,sc.ManagementUnitID FROM SubCompartment AS sc INNER JOIN TreePlanting AS tp ON sc.ID = tp.SubCompartmentID INNER JOIN
              TreePlantingDetail AS tpd ON tp.ID = tpd.TreePlantingID").ToList();


            var treeplanting = _sqLiteSyncConnection.Query<TPTempDto>(@"select sc.ManagementUnitID,tp.SuitableToBeSold,tp.Completed FROM SubCompartment AS sc INNER JOIN  TreePlanting AS tp ON sc.ID = tp.SubCompartmentID WHERE sc.Deleted = 0 AND tp.Deleted = 0").ToList();

            foreach (var c in _iCache.ManagementUnits)
            {
              
                var treePlants = test.Where(w => w.ManagementUnitID == c.Id).ToList();

                var tpForManagementID = treeplanting.Where(w => w.ManagementUnitID == c.Id).ToList();

                var WCAreaToPlant = treePlants.Sum(p => p.PlantingArea);

                var WCAreaPlanted = treePlants.Where(w => w.Completed).Sum(p => p.PlantingArea);

                var WCAreaAvailable = treePlants.Where(w => !w.Completed).Sum(p => p.PlantingArea);
                
                var TreeNumbersToPlant = treePlants.Where(w => w.Completed).Sum(p => p.TreesToPlant);

                var TreeNumbersAvailable = treePlants.Where(w => !w.Completed).Sum(p => p.TreesToPlant);

                var PlantingComplete = tpForManagementID.Any(p => p.Completed);


                var SuitableToBeSold = tpForManagementID.Any(p => p.SuitableToBeSold);

                
                results.Add(new TreePlantingSearchDto()
                {
                    ManagementUnitID = c.Id,

                    PlantingComplete = PlantingComplete,
                    SuitableToBeSold = SuitableToBeSold,
                    TreeNumbersPlanted = (int)TreeNumbersToPlant,
                    TreeNumbersAvailable = (int)TreeNumbersAvailable,
                    WCAreaAvailable = WCAreaAvailable,
                    WCAreaPlanted = WCAreaPlanted,
                    WCAreaToPlant = WCAreaToPlant,
                    Region = _iCache.RegionLookup[c.RegionId.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[c.WoodlandOfficerId],                 
                    Location = c.Name,
                });
            }

            
            return results;
        }

        public List<TreePlantDto> GetTreePlantDtos(int managementUnitID)
        {
            var results = new List<TreePlantDto>();

            var treeplantingdetailcache = _sqLiteSyncConnection.Query<TreePlantingDetail>(@"SELECT ID,TreePlantingID,PlantingArea,PlantedArea FROM TreePlantingDetail WHERE Deleted = 0").ToList();

            var subcompartmentCache = _sqLiteSyncConnection.Query<SubCompartmentLookupDto>(@"SELECT ID,AreaInHectares,Reference,Description FROM SubCompartment").ToList();



            var treeplanting = _sqLiteSyncConnection.Query<DataObjects.DAOS.TreePlanting>(@"SELECT tp.ID,SubCompartmentID,PlantingDate,Completed,
                                                                                    PlantingTypeID,PlantedByID,SuitableToBeSold 
                                                                            FROM TreePlanting tp
                                                                            JOIN SubCompartment sc
                                                                            on tp.SubCompartmentID = sc.ID WHERE tp.Deleted = 0 AND sc.ManagementUnitID = " + managementUnitID).ToList();


        
            foreach (var tp in treeplanting)
            {
                var WCArea = treeplantingdetailcache.Select(p=>p.PlantedArea).Sum();
                
                var firstOrDefault = subcompartmentCache.FirstOrDefault(a => a.Id == tp.SubCompartmentID);

                var Area = 0.0;

                if (firstOrDefault != null)
                {
                     Area = firstOrDefault.AreaInHectares;                    
                }
                
                results.Add(new TreePlantDto()
                {
                    AreaHa = Area,
                    SubCompartmentID = firstOrDefault,
                    WCAreaHa = WCArea,
                    Id = tp.ID,
                    Completed = tp.Completed,
                    SuitableToBeSold = tp.SuitableToBeSold,
                 
                    PlantingDate = tp.PlantingDate,
               
                });


            }

            return results;
        }



        public List<PlantedByDto> GetPlantedByDtos()
        {
            var results = new List<PlantedByDto>();

            var treeplanting = _sqLiteSyncConnection.Query<PlantedBy>(@"SELECT ID,Description FROM PlantedBy WHERE Deleted = 0").ToList();


            foreach (var tree in treeplanting)
            {
                results.Add(new PlantedByDto()
                {
                    Id = tree.ID,
                    Description = tree.Description
                });
            }

            return results;
        }

        public List<PlantTypeDto> GetPlantTypeDtos()
        {
            var results = new List<PlantTypeDto>();

            var treeplanting = _sqLiteSyncConnection.Query<PlantingType>(@"SELECT ID,Description FROM PlantingType WHERE Deleted = 0").ToList();

            foreach (var tree in treeplanting)
            {
                results.Add(new PlantTypeDto()
                {
                    Id = tree.ID,
                    Description = tree.Description
                });
            }

            return results;
        }

        public List<SubCompartmentLookupDto> GetSubCompartmentLookupDtos()
        {
            var results = new List<SubCompartmentLookupDto>();

            var subcompartmentCache = _sqLiteSyncConnection.Query<SubCompartment>(@"SELECT ID, Reference FROM SubCompartment").ToList();

            foreach (var r in subcompartmentCache)
            {
                results.Add(new SubCompartmentLookupDto()
                {
                    Id = r.ID,
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

        public List<TreePlantDetailDto> GetTreePlantDetailDtos(int treePlantingID)
        {
            var results = new List<TreePlantDetailDto>();

            var accessLookup = GetTreePlantAccessDtos();


            var terrainLookup = GetTreePlantTerrainDtos();


            var treePlantingDetail = _sqLiteSyncConnection.Query<TreePlantingDetail>(@"SELECT ID, TreePlantingID,TerrainTypeID,AccessTypeID,Adults,Children,PlantingArea,
TreesToPlant,TreesPlanted,TreesAllocated,Comments FROM TreePlantingDetail WHERE TreePlantingID = " + treePlantingID).ToList();



            foreach (var r in treePlantingDetail)
            {

                var acc = accessLookup.FirstOrDefault(f => f.Id == r.AccessTypeID);

                var terr = terrainLookup.FirstOrDefault(f => f.Id == r.TerrainTypeID);

                results.Add(new TreePlantDetailDto()
                {
                    Id = r.ID,
                    Comments = r.Comments,
                    AccessID = acc,
                    AdultsCount = r.Adults,
                    AreaPlanted = r.PlantingArea,
                    AreaToPlant = r.PlantingArea,
                    ChildrenCount = r.Children,
                    DensityHa = 0,
                    TerrainID = terr,
                    TreesAllocated = r.TreesAllocated,
                    TreesPlanted = r.TreesPlanted,
                    TreesToPlant = r.TreesToPlant
                });
            }

            return results;
        }

        public List<TreePlantAccessDto> GetTreePlantAccessDtos()
        {
            var treePlantingDetail = _sqLiteSyncConnection.Query<PlantingAccessType>(@"SELECT ID, Description FROM PlantingAccessType").ToList();


            return treePlantingDetail.Select(r => new TreePlantAccessDto()
            {
                Id = r.ID,
                Description = r.Description,
            }).ToList();
        }



        public List<TreePlantTerrainDto> GetTreePlantTerrainDtos()
        {
            var results = _sqLiteSyncConnection.Query<TerrainType>(@"SELECT ID, Description FROM TerrainType").ToList();




            return results.Select(r => new TreePlantTerrainDto()
            {
                Id = r.ID,
                Description = r.Description,
            }).ToList();
        }

        List<ComboBoxValue> ITreePlantingStore.GetPlantedByDtos()
        {
            throw new NotImplementedException();
        }

        List<ComboBoxValue> ITreePlantingStore.GetPlantTypeDtos()
        {
            throw new NotImplementedException();
        }

        public void UpdateTreePlantDtos(int managementUnitID, List<TreePlantDto> editSet)
        {
            throw new NotImplementedException();
        }

        public void UpdateTreePlantDetailsDtos(int treePlantingID, List<TreePlantDetailDto> editSet)
        {
            throw new NotImplementedException();
        }

        public List<TreePlantingSearchDto> GetTreePlantingDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }
}
