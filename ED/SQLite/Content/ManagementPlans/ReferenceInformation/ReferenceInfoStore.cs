using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using SQLite.DataTypes;
using Stores;

namespace SQLite
{
    public class ReferenceInfoStore : BaseStore, IReferenceInfoStore
    {
        public ReferenceInfoStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }
        
        public List<ReferenceInfoListDTO> GetReferenceInfoListDtos()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetReferenceInfoListDtos started");


            var magicString = @"SELECT     distinct mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 1)) AS WindlifeConservation,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 2)) AS RecreationAndAccess,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 3)) AS Landscape,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 4)) AS ArchaeologyAndHistory,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 5)) AS Community,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 6)) AS ManagementHistory,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 7)) AS MapsAndPhotographs,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          Evaluation AS ev
                            WHERE      (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 8)) AS SurveyAndConsultation
FROM         (SELECT    ID AS MainAcquisitionUnitID, ManagementUnitID
FROM      AcquisitionUnit) AS mau INNER JOIN
                      ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID LEFT OUTER JOIN
                      Evaluation AS ev ON ev.AcquisitionUnitID = mau.MainAcquisitionUnitID";

            var refs = new List<ReferenceInfoListDTO>();


            var data = _sqLiteSyncConnection.Query<ReferenceInfoListData>(magicString).ToList();


            foreach (var d in data)
            {
                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == d.ManagementUnitID);

                var newRecord = new ReferenceInfoListDTO()
                {
                    CostCentre = d.ManagementUnitID,
                    Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                    Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                    ManagementUnitID = d.ManagementUnitID,
                    ArchaeologyHistory = d.ArchaeologyHistory > 0,
                    Community = d.Community > 0,
                    Landscape = d.Landscape > 0,
                    ManagementHistory = d.ManagementHistory > 0,
                    MapsPhotography = d.MapsPhotography > 0,
                    RecreationAndAccess = d.RecreationAndAccess > 0,
                    SurveyConsultation = d.SurveyConsultation > 0,
                    WildlifeConservation = d.WildlifeConservation > 0
                };

                refs.Add(newRecord);
            }

            stopwatch.Stop();

            Debug.WriteLine("GetReferenceInfoListDtos ended in: " + stopwatch.ElapsedMilliseconds);

            return refs;
        }
        
        public List<EvaluationEditDto> GetEvaluations(int managementUnitID, int evaluationTypeID)
        {
            var result = new List<EvaluationEditDto>();

            var sqlStr = "SELECT e.ID,EvaluationTypeID,TypeOfInformationID,Author,Confidential,DateOfRecord,e.Location,Detail,SuppliedBy ,AcquisitionUnitID\r\n" +
                         "FROM Evaluation e\r\n" +
                         "JOIN AcquisitionUnit a\r\n" +
                         "ON e.AcquisitionUnitID = a.ID\r\n" +
                         "WHERE e.Deleted =0 AND a.ManagementUnitID =" + managementUnitID + " AND EvaluationTypeID = " + evaluationTypeID;

            Debug.WriteLine(sqlStr);

            var edata = _sqLiteSyncConnection.Query<EvaluationEditDto>(sqlStr).ToList();


            return edata;
        }

        public void UpdateEvaluations(List<EvaluationEditDto> evaluationDtos, int evaluationTypeID, int managementId)
        {
            throw new System.NotImplementedException();
        }

        public List<ReferenceInfoListDTO> GetReferenceInfoListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}