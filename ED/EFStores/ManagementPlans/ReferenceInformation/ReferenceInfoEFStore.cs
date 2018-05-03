using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores
{
    public class SummaryDescriptiont
    {
        public int? RegionId { get; set; }

        public int? WoodlandOfficerId { get; set; }
        public int? ApplicationId { get; set; }
        public string Name { get; set; }


        public int? WoodlandOfficerID { get; set; }
        public int? DeputyID { get; set; }


        public int AcquisitionUnitID { get; set; }
        public int ManagementUnitID { get; set; }
        public int? CountSSSI { get; set; }
        public bool? IsSSSI { get; set; }
        public int? CountTPO { get; set; }
        public bool? IsTPO { get; set; }
        public int? CountAWS { get; set; }
        public bool? IsAWS { get; set; }
        public int? CountAONB { get; set; }
        public bool? IsAONB { get; set; }
        public int? CountNP { get; set; }
        public bool? IsNP { get; set; }
        public int? CountSAM { get; set; }
        public bool? IsSAM { get; set; }
        public bool? AWR { get; set; }
        public bool? DEMOWC { get; set; }

        public bool? DEMOAWR { get; set; }
        public bool? DIO { get; set; }
        public bool? DEST { get; set; }
        public bool? FA { get; set; }
        public bool? FWW { get; set; }
        public bool? LTM { get; set; }
        public bool? PPP { get; set; }
        public bool? PRP { get; set; }
        public bool? T4A { get; set; }
        public bool? Trafalgar { get; set; }
        public bool? WOYD { get; set; }
        public bool? WSP { get; set; }
        public int? PAWSStatus { get; set; }
        public bool? MoreDesignations { get; set; }
    }

    public class ReferenceInfoEFStore : BaseEFStore, IReferenceInfoStore
    {
        private IUserStore _iUserStore;

        public ReferenceInfoEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : base(ec, iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<EvaluationEditDto> GetEvaluations(int managementUnitID, int evaluationTypeID)
        {
            var edata = Context.Evaluation.Include(i => i.AcquisitionUnit).Where(d =>
                    !d.Deleted && d.AcquisitionUnit.ManagementUnitId == managementUnitID &&
                    d.EvaluationTypeId == evaluationTypeID)
                .Select(s => new EvaluationEditDto()
                {
                    Id = s.Id,
                    EvaluationTypeID = s.EvaluationTypeId,
                    Confidential = s.Confidential.GetValueOrDefault(),
                    Author = s.Author,
                    DateOfRecord = s.DateOfRecord,
                    Detail = s.Detail,
                    Location = s.Location,
                    SuppliedBy = s.SuppliedBy,
                    TypeOfInformationID = s.TypeOfInformationId.GetValueOrDefault()
                }).ToList();

            return edata;
        }



        public List<ReferenceInfoListDTO> GetReferenceInfoListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            var magicString = @"SELECT DISTINCT mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 1)) AS WindlifeConservation,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 2)) AS RecreationAndAccess,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 3)) AS Landscape,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 4)) AS ArchaeologyAndHistory,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 5)) AS Community,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 6)) AS ManagementHistory,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 7)) AS MapsAndPhotographs,
                             (SELECT        COUNT(*) AS Expr1
                               FROM            dbo.Evaluation AS ev
                               WHERE        (AcquisitionUnitID = mau.MainAcquisitionUnitID) AND (Deleted = 0) AND (EvaluationTypeID = 8)) AS SurveyAndConsultation
FROM            dbo.vw_MainAcquisitionUnit AS mau INNER JOIN
                         dbo.ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID LEFT OUTER JOIN
                         dbo.Evaluation AS ev ON ev.AcquisitionUnitID = mau.MainAcquisitionUnitID";

            var refs = new List<ReferenceInfoListDTO>();

            var data = ExecSQL<ReferenceInfoListData>(magicString, Context);

            foreach (var d in data)
            {
                var manu = _cache.ManagementUnitDtos.FirstOrDefault();

                if (manu != null)
                {
                    d.RegionId = manu.RegionId;
                    d.WoodlandOfficerId = manu.WoodlandOfficerId;
                    d.Name = manu.Name;
                    d.ApplicationId = manu.ApplicationId;
                    d.WoodlandOfficerID = manu.WoodlandOfficerId;
                    d.DeputyID = manu.DeputyId.GetValueOrDefault();
                }
            }


            foreach (var d in data)
            {

                var newRecord = new ReferenceInfoListDTO()
                {
                    CostCentre = d.ManagementUnitID,
                    Manager = UserName(d.WoodlandOfficerId),
                    Region = RegionName(d.RegionId),
                    RegionId = d.RegionId.GetValueOrDefault(),
                    ApplicationId = d.ApplicationId.GetValueOrDefault(),
                    ManagementUnitID = d.ManagementUnitID,
                    ArchaeologyHistory = d.ArchaeologyHistory > 0,
                    Community = d.Community > 0,
                    Landscape = d.Landscape > 0,
                    ManagementHistory = d.ManagementHistory > 0,
                    MapsPhotography = d.MapsPhotography > 0,
                    RecreationAndAccess = d.RecreationAndAccess > 0,
                    SurveyConsultation = d.SurveyConsultation > 0,
                    WildlifeConservation = d.WildlifeConservation > 0,
                    WoodlandOfficerID = d.WoodlandOfficerID.GetValueOrDefault(),
                    AcquisitionOfficerID = _cache.AcquisitionOfficerLookup.ContainsKey(d.ManagementUnitID)? _cache.AcquisitionOfficerLookup[d.ManagementUnitID] :0,
                    DeputyID = d.DeputyID.GetValueOrDefault()
                };

                refs.Add(newRecord);
            }

            return refs.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList(); ;
        }

        public void UpdateEvaluations(List<EvaluationEditDto> evaluationDtos, int evaluationTypeID, int managementId)
        {
            // find out if we've deleted anything
            // find out if we've added anything
            // make any updates.


            //get main acquisition unit id 

            var acquisitionId = 0;


            var manu = Context.AcquisitionUnit.Where(f => f.ManagementUnitId == managementId);

            if (manu.Any())
                acquisitionId = manu.First().Id;

            foreach(var man in manu)
            {
                if ((man.DirectoryInformation & 8388608) == 8388608)
                {
                    acquisitionId = man.Id;
                }
            }


            var currentUserId = _iUserStore.CurrentUserId();

            var existingEvaluations = Context.Evaluation.Where(e => e.AcquisitionUnitId == acquisitionId 
                                                                    && e.EvaluationTypeId == evaluationTypeID 
                                                                    && !e.Deleted);



            List<int> editSetIds = evaluationDtos.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingEvaluations.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingEvaluations
                where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = evaluationDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var evaluation in existingEvaluations)
            {
                var matchedRecord = evaluationDtos.FirstOrDefault(f => f.Id == evaluation.Id);

                if (matchedRecord != null)
                {                    
                    

                    evaluation.Id = matchedRecord.Id;
               
                    evaluation.EvaluationTypeId = matchedRecord.EvaluationTypeID;
                    evaluation.EvaluationType =
                        Context.EvaluationType.FirstOrDefault(f => f.Id == matchedRecord.EvaluationTypeID);
                    evaluation.TypeOfInformationId = matchedRecord.TypeOfInformationID !=0 ? (int?)matchedRecord.TypeOfInformationID : null;
                    evaluation.TypeOfInformation =
                        Context.TypeOfInformation.FirstOrDefault(t => t.Id == matchedRecord.TypeOfInformationID);
                    evaluation.Author = matchedRecord.Author;
                    evaluation.Confidential = matchedRecord.Confidential;
                    evaluation.DateOfRecord = matchedRecord.DateOfRecord;
                    evaluation.Location = matchedRecord.Location;
                    evaluation.Detail = matchedRecord.Detail;
                    evaluation.SuppliedBy = matchedRecord.SuppliedBy;


                }

                if (deletedRecords.Any(f => f == evaluation.Id))
                {
                    evaluation.Deleted = true;
                    evaluation.Dldt = DateTime.Today;
                    evaluation.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new Evaluation()
            {     
                AcquisitionUnitId = acquisitionId,
                AcquisitionUnit = Context.AcquisitionUnit.First(f=>f.Id == acquisitionId),
                Author = nr.Author,
                Cost = 0.0,
                DateOfRecord = nr.DateOfRecord,
                Detail = nr.Detail,
                EvaluationTypeId = nr.EvaluationTypeID,
                EvaluationType = Context.EvaluationType.First(e=>e.Id == nr.EvaluationTypeID),
                Location = nr.Location,
                SuppliedBy = nr.SuppliedBy,
                TypeOfInformationId = nr.TypeOfInformationID,
                TypeOfInformation = Context.TypeOfInformation.First(d=>d.Id == nr.TypeOfInformationID),
                Deleted = false,        
                Confidential = nr.Confidential,        
                IsDefaultValue = false,
                IsHistorical = false,
                IsProtected = false,   
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
    }

}
