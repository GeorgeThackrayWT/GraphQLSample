using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans.SearchScreens;
using EDCORE.ViewModel;
using MvvmHelpers;
using Stores;

namespace SQLite
{
    public class SummaryStore : BaseStore, ISummaryStore
    {
        

        public SummaryStore(IDBPlatformSettings platform, ISQLiteCache iCache, ILookupStore iLookupStore)
        {
            _platform = platform;

            _iCache = iCache;

            _iLookupStore = iLookupStore;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public List<SummaryDescriptiontListDTO> GetSummaryDescriptiontListDtos()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetSummaryDescriptiontListDtos started");

            var retData = new List<SummaryDescriptiontListDTO>();

            string magicString = "SELECT        mau.MainAcquisitionUnitID AS AcquisitionUnitID, " +
                                 "mu.ID AS ManagementUnitID," +
                                 " SUM(CASE dt.Reference WHEN \'SSSI\' THEN 1 ELSE 0 END) AS CountSSSI," +
                                 " CAST(MAX(CASE dt.Reference WHEN \'SSSI\' THEN 1 ELSE 0 END) \r\n                         AS BIT) AS IsSSSI," +
                                 " SUM(CASE dt.Reference WHEN \'TPO\' THEN 1 ELSE 0 END) AS CountTPO, CAST(MAX(CASE dt.Reference WHEN \'TPO\' THEN 1 ELSE 0 END) AS BIT) AS IsTPO," +
                                 " \r\n                         SUM(CASE dt.Reference WHEN \'AWS\' THEN 1 ELSE 0 END) AS CountAWS, " +
                                 "CAST(MAX(CASE dt.Reference WHEN \'AWS\' THEN 1 ELSE 0 END) AS BIT) AS IsAWS, " +
                                 "\r\n                         SUM(CASE dt.Reference WHEN \'AONB\' THEN 1 ELSE 0 END) AS CountAONB, " +
                                 "CAST(MAX(CASE dt.Reference WHEN \'AONB\' THEN 1 ELSE 0 END) AS BIT) AS IsAONB, \r\n                         " +
                                 "SUM(CASE dt.Reference WHEN \'NP\' THEN 1 ELSE 0 END) AS CountNP, " +
                                 "CAST(MAX(CASE dt.Reference WHEN \'NP\' THEN 1 ELSE 0 END) AS BIT) AS IsNP, " +
                                 "SUM(CASE dt.Reference WHEN \'SAM\' THEN 1 ELSE 0 END)\r\n                          AS CountSAM, " +
                                 "CAST(MAX(CASE dt.Reference WHEN \'SAM\' THEN 1 ELSE 0 END) AS BIT) AS IsSAM, " +
                                 "intDesignStats.AWR, " +
                                 "intDesignStats.[DEMO W/C], " +
                                 "intDesignStats.[DEMO AWR], " +
                                 "intDesignStats.DIO, \r\n                         " +
                                 "intDesignStats.DEST," +
                                 " intDesignStats.FA, " +
                                 "intDesignStats.FWW, " +
                                 "intDesignStats.LTM, " +
                                 "intDesignStats.PPP, " +
                                 "intDesignStats.PRP, " +
                                 "intDesignStats.T4A, " +
                                 "intDesignStats.TRAF AS Trafalgar," +
                                 " intDesignStats.WOYD," +
                                 " \r\n                         intDesignStats.WSP," +
                                 " MAX(sc.PAWSStatus) AS PAWSStatus, " +
                                 "CAST(CASE WHEN COUNT(dt.ID) > 7 THEN 1 ELSE 0 END AS BIT) AS MoreDesignations\r\n" +
                                 "FROM            (seLECT ID AS MainAcquisitionUnitID, ManagementUnitID\r\n" +
                                 "FROM            AcquisitionUnit) AS mau INNER JOIN\r\n                         ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID INNER JOIN                         \r\n\t\t\t\t\t\t (SELECT        au.ManagementUnitID AS [Cost Centre], CAST(SUM(CASE WHEN d .TypeID = 1 THEN 1 ELSE 0 END) AS BIT) AS AWR, CAST(SUM(CASE WHEN d .TypeID = 2 THEN 1 ELSE 0 END) AS BIT) AS [DEMO W/C], \r\n                         CAST(SUM(CASE WHEN d .TypeID = 3 THEN 1 ELSE 0 END) AS BIT) AS [DEMO AWR], CAST(SUM(CASE WHEN d .TypeID = 4 THEN 1 ELSE 0 END) AS BIT) AS DIO, \r\n                         CAST(SUM(CASE WHEN d .TypeID = 5 THEN 1 ELSE 0 END) AS BIT) AS DEST, CAST(SUM(CASE WHEN d .TypeID = 6 THEN 1 ELSE 0 END) AS BIT) AS FA, CAST(SUM(CASE WHEN d .TypeID = 7 THEN 1 ELSE 0 END)\r\n                          AS BIT) AS FWW, CAST(SUM(CASE WHEN d .TypeID = 8 THEN 1 ELSE 0 END) AS BIT) AS LTM, CAST(SUM(CASE WHEN d .TypeID = 9 THEN 1 ELSE 0 END) AS BIT) AS PPP, \r\n                         CAST(SUM(CASE WHEN d .TypeID = 10 THEN 1 ELSE 0 END) AS BIT) AS PRP, CAST(SUM(CASE WHEN d .TypeID = 11 THEN 1 ELSE 0 END) AS BIT) AS T4A, \r\n                         CAST(SUM(CASE WHEN d .TypeID = 12 THEN 1 ELSE 0 END) AS BIT) AS TRAF, CAST(SUM(CASE WHEN d .TypeID = 13 THEN 1 ELSE 0 END) AS BIT) AS WOYD, \r\n                         CAST(SUM(CASE WHEN d .TypeID = 14 THEN 1 ELSE 0 END) AS BIT) AS WSP\r\nFROM            AcquisitionUnit AS au LEFT OUTER JOIN\r\n                         InternalDesignation AS d ON d.AcquisitionUnitID = au.ID\r\nGROUP BY au.ManagementUnitID) AS intDesignStats \t\t\t\t\t\t \t\t\t\t\t\t \r\n\t\t\t\t\t\t ON intDesignStats.[Cost Centre] = mu.ID LEFT OUTER JOIN\r\n                         SubCompartment AS sc ON sc.ManagementUnitID = mu.ID AND sc.Deleted = 0 LEFT OUTER JOIN\r\n                         AcquisitionUnit AS au ON au.ManagementUnitID = mu.ID AND au.Deleted = 0 LEFT OUTER JOIN\r\n                         Designation AS ds ON ds.AcquisitionUnitID = au.ID AND ds.Deleted = 0 LEFT OUTER JOIN\r\n                         DesignationType AS dt ON dt.ID = ds.TypeID AND dt.Deleted = 0\r\nGROUP BY mau.MainAcquisitionUnitID, mu.ID, intDesignStats.AWR, intDesignStats.[DEMO W/C], intDesignStats.[DEMO AWR], intDesignStats.DIO, intDesignStats.DEST, intDesignStats.FA, intDesignStats.FWW, \r\n                         intDesignStats.LTM, intDesignStats.PPP, intDesignStats.PRP, intDesignStats.T4A, intDesignStats.TRAF, intDesignStats.WOYD, intDesignStats.WSP";



            var data = _sqLiteSyncConnection.Query<SummaryDescriptiont>(magicString).ToList();


            //hack alert!!!

            List<int> addedAcqs = new List<int>();

            foreach (var v in data)
            {

                if (addedAcqs.Contains(v.ManagementUnitID)) continue;

                addedAcqs.Add(v.ManagementUnitID);


                var areaTotal =
                    _iCache.AcquisitionUnits.Where(a => a.ManagementUnitID == v.ManagementUnitID).Sum(s => s.GISAreaInHectares.GetValueOrDefault());


                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == v.ManagementUnitID);


                var locat = _iCache.AcquisitionUnits.FirstOrDefault(a => a.ID == v.AcquisitionUnitID);

                var sum = new SummaryDescriptiontListDTO
                {
                    ManagementUnitID = v.ManagementUnitID,
                    CostCentre = v.ManagementUnitID,
                    Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                    Name = manu.Name,
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



            stopwatch.Stop();

            Debug.WriteLine("GetSummaryDescriptiontListDtos ended in: " + stopwatch.ElapsedMilliseconds);


            return retData.OrderBy(p=>p.Name).ToList();
        }

        public SummaryOverviewDto GetSummaryDescriptionContainerEditDto(int managementUnitID)
        {
            managementUnitID = 4354;
            
            var mainSpeciesLookup = _iLookupStore.GetMainSpeciesDTOs();
            var managementRegionsLookup = _iLookupStore.GetManagementRegimeDTOs();
            var managementConstraintTypesLookup = _iLookupStore.GetManagementConstraints(0);
            var conservationTypesLookup = _iLookupStore.GetConservationFeatures(0);


            var designationsLookup = _iLookupStore.GetDesignations(0);
            var yearsLookup = _iLookupStore.GetYears();

            var acqu = _iCache.AcquisitionUnits.FirstOrDefault(
                a => a.ManagementUnitID == managementUnitID && a.SummaryDescription != null);




            var summaryDescriptiontEditContainerDto =
                new SummaryOverviewDto
                {
                //    SummariesList = new ObservableRangeCollection<SummaryDto>(),
                    SummaryDescription = acqu.SummaryDescription,
                    LongTermPolicyConclusions = _iCache.ManagementUnits.First(f=>f.Id == managementUnitID).LongTermIntentions
                };



            var magicString = @"SELECT ID,Year, AreaInHectares,Compartment,Description,MainSpeciesID,SecondSpeciesID,ManagementRegimeID,Reference FROM SubCompartment WHERE ManagementUnitID = " + managementUnitID;

            var conditions = _sqLiteSyncConnection.Query<SubCompartment>(magicString).ToList();
            //select d.TypeID from SubCompartment sc join SubCompartmentDesignationMap sm on sc.ID = sm.SubCompartmentID join Designation d on sm.DesignationID = d.ID where sc.ID = 4262
            foreach (var sc in conditions)
            {
                Debug.WriteLine(sc.ID + " IDs ");

                var designations = new ObservableRangeCollection<SummaryDesignationDto>();

                designations.AddRange(_sqLiteSyncConnection.Query<SummaryDesignationDto>(@"select d.TypeID AS ID  from SubCompartment sc join SubCompartmentDesignationMap sm on sc.ID = sm.SubCompartmentID join Designation d on sm.DesignationID = d.ID where sc.ID = " + sc.ID).ToList());

                var conservationFeatures = new ObservableRangeCollection<SummaryFeatureDto>();

                conservationFeatures.AddRange(_sqLiteSyncConnection.Query<SummaryFeatureDto>(@"SELECT sm.ID, FeatureID, sm.[Description], Confidential, MapRef from SubCompartment sc join SubCompartmentFeatureMap sm on sc.ID = sm.SubCompartmentID WHERE sc.ID = " + sc.ID).ToList());

                //ManagementConstraintLookupDTO
                var managementConstraintLookupDTOs = new ObservableRangeCollection<SummaryConstraintDto>();

                managementConstraintLookupDTOs.AddRange(_sqLiteSyncConnection.Query<SummaryConstraintDto>(@"select mm.ID, TypeID, mm.Confidential, mm.OtherDescription from SubCompartment sc
	                                                                                                        join MajorManagementConstraintMap mmc
	                                                                                                        on sc.ID = mmc.SubCompartmentID
	                                                                                                        join MajorManagementConstraint mm
	                                                                                                        on mmc.MajorManagementConstraintTypeID = mm.ID WHERE sc.ID = " + sc.ID).ToList());


                foreach (var cf in conservationFeatures)
                {
                    cf.Feature = conservationTypesLookup.FirstOrDefault(f => f.ID == cf.FeatureId);
                }

                foreach (var mc in managementConstraintLookupDTOs)
                {
                    mc.Type = managementConstraintTypesLookup.FirstOrDefault(f => f.ID == mc.TypeID);
                }

                foreach (var des in designations)
                {
                    des.Description = designationsLookup.FirstOrDefault(f => f.ID == des.Id);
                }


                //summaryDescriptiontEditContainerDto.SummariesList.Add(new SummaryDto()
                //{
                //    Year = sc.Year.GetValueOrDefault(),
                //    YearLookup = yearsLookup.FirstOrDefault(f=>f.ID == sc.Year.GetValueOrDefault()),

                //    AreaHa = sc.AreaInHectares,
                //    Compartment = sc.Compartment,
                //    CompartmentDescription = sc.Description,

                //    MainSpeciesID = sc.MainSpeciesID.GetValueOrDefault(),
                //    MainSpecies = mainSpeciesLookup.FirstOrDefault(i=>i.ID == sc.MainSpeciesID.GetValueOrDefault()),

                //    SecondarySpeciesID = sc.SecondSpeciesID.GetValueOrDefault(),
                //    SecondarySpecies = mainSpeciesLookup.FirstOrDefault(i => i.ID == sc.SecondSpeciesID.GetValueOrDefault()),

                //    ManagementRegimeID = sc.ManagementRegimeID.GetValueOrDefault(),
                //    ManagementRegime = managementRegionsLookup.FirstOrDefault(i => i.ID == sc.ManagementRegimeID.GetValueOrDefault()),


                //    SubCompartmentID = sc.ID,

                //    SubCompartmentRef = sc.Reference,
                //    Designations = designations,
                //    ConservationFeatures = conservationFeatures,
                //    MajorManagementConstraints = managementConstraintLookupDTOs
                //});


            }




            return summaryDescriptiontEditContainerDto;
        }

        public List<SummaryDto> GetSummaries(int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<SummaryConstraintDto> GetSummaryConstraints(int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public List<SummaryFeatureDto> GetSummaryFeatures(int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public List<SummaryDesignationDto> GetSummaryDesignations(int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSummaryDescriptionOverview(SummaryOverviewDto editSet, int managementId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSummaries(List<SummaryDto> editSet, int managementId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSummaryConstraints(List<SummaryConstraintDto> editSet, int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSummaryFeatures(List<SummaryFeatureDto> editSet, int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSummaryDesignations(List<SummaryDesignationDto> editSet, int subCompartmentId)
        {
            throw new System.NotImplementedException();
        }

        public List<SummaryDescriptiontListDTO> GetSummaryDescriptiontListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}