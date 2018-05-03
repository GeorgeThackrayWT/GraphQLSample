using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using Stores;

namespace SQLite
{
    public class ObjectiveStore : BaseStore, IObjectiveStore
    {
        public ObjectiveStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public ObjectivesContainerEditDto GetObjectivesContainerEditDto(int managementUnitID)
        {
            var result = new ObjectivesContainerEditDto { ObjectivesFlip = new List<ObjectivesDTO>() };


            var edata = _sqLiteSyncConnection.Query<Feature>("SELECT ID,Reference ,OtherTypeDescription ,TypeID ,AimID ,Description ," +
                                                             "Confidential,ConstraintsAndOpportunities ,ShortTermObjective ,LongTermObjective  ," +
                                                             "AppliesToEntireSite ,Significance ,FactorsCausingChange ,0 AS WoodProduction " +
                                                             "FROM Feature where Deleted =0 AND ManagementUnitID = " + managementUnitID).ToList();

            foreach (var f in edata)
            {
                result.ObjectivesFlip.Add(new ObjectivesDTO()
                {
                    Description = f.Description,
                    FeatureID = f.ID,
                    AimID = f.AimID.GetValueOrDefault(),
                    ConditionAssessment = "",
                    FactorsCausingChange = f.FactorsCausingChange,
                    IsConfidential = f.Confidential,
                    IsWholeSite = f.AppliesToEntireSite.GetValueOrDefault(),
                    IsWoodProduction = f.WoodProduction.GetValueOrDefault(),
                    KeyFeatureTypeID = f.TypeID.GetValueOrDefault(),
                    LongTermObjective = f.LongTermObjective,
                    OpportunitiesAndConstraints = f.ConstraintsAndOpportunities,
                    Ref = f.Reference,
                    ShortTermObjective = f.ShortTermObjective,
                    Significance = f.Significance

                });
            }

            return result;
        }

        public void UpdateObjectivesDTO(List<ObjectivesDTO> objectivesDtos, int recordId)
        {
            throw new System.NotImplementedException();
        }

        List<ObjectivesDTO> IObjectiveStore.GetObjectivesContainerEditDto(int managementUnitID)
        {
            throw new System.NotImplementedException();
        }

        public List<ObjectiveKFListDTO> GetObjectiveKfListDtos()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetObjectiveKfListDtos started");


            var featureTypes = _sqLiteSyncConnection.Table<FeatureType>().ToList();

            var features = _sqLiteSyncConnection.Table<Feature>().ToList();


            //var mainData = _sqLiteSyncConnection.Query<ObjectiveKFListData>(magicString).ToList();
            var retList = new List<ObjectiveKFListDTO>();


            foreach (var m in _iCache.ManagementUnits.OrderBy(o=>o.Name))
            {
                var objectiveKFListDTO = new ObjectiveKFListDTO();
                var mfeatures = features.Where(f => f.ManagementUnitID == m.Id).ToList();

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
                    if (feature.AimID == 2)
                        objectiveKFListDTO.Aim2Biodiversity = true;

                    if (feature.AimID == 1)
                        objectiveKFListDTO.Aim1Creation = true;

                    if (feature.AimID == 3)
                        objectiveKFListDTO.Aim3People = true;

                    var ftlookup = featureTypes.FirstOrDefault(ft => ft.ID == feature.TypeID.GetValueOrDefault());

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
                objectiveKFListDTO.Name = m.Name;
                objectiveKFListDTO.Manager = _iCache.UserLookup[m.WoodlandOfficerId];
                objectiveKFListDTO.Region = _iCache.RegionLookup[m.RegionId.GetValueOrDefault()];

                retList.Add(objectiveKFListDTO);
            }




            stopwatch.Stop();

            Debug.WriteLine("GetObjectiveKfListDtos ended in: " + stopwatch.ElapsedMilliseconds);


            return retList;
        }

        public List<ObjectiveKFListDTO> GetObjectiveKfListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}