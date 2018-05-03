using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using EFStores.Fabric;
using Microsoft.EntityFrameworkCore;
using MvvmHelpers;
using Utils;

namespace EFStores
{
    class MonitoringData
    {
        public int ID { get; set; }

        public string Name { get; set; }



        public int? RegionId { get; set; }

        public int? WoodlandOfficerId { get; set; }

        public int ManagementUnitID { get; set; }

        public int CountKFObservations { get; set; }

        public int CountWCObservations { get; set; }

        public DateTime? NextObservationDate { get; set; }

        public DateTime? NextActionDate { get; set; }

        public int CountOverdue { get; set; }

    }



    public class MonitoringEFStore : BaseEFStore, IMonitoringStore
    {
        public MonitoringEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) :
            base(ec,iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<MonitoringEditDto> GetMonitoringEditContainerDto(int managementUnitId)
        {            
            var features = Context.FeatureMonitoring.Include(fm => fm.Feature)
                .Where(f => f.Feature.TypeId != null && f.Feature.ManagementUnitId == managementUnitId)
                .Select(s => new MonitoringEditDto()
                {

                    Id = s.Id,
                    ManagementUnitId = s.Feature.ManagementUnitId,
                    FeatureType = new ComboBoxValue(){
                        ID = s.Feature.TypeId.Value,
                        Description = s.Feature.Type.Description,
                        Name = s.Feature.Type.Description                        
                    },
                    FeatureID = s.FeatureId,
                    PlannedObservationDate = s.PlannedObservationDate,
                    ActualObservationDate = s.ActualObservationDate,
                    DeadlineActionDate = s.DeadlineActionDate,
                    ActualActionDate = s.ActualObservationDate,
                    PredictionShortTermObjective = s.PredictionShortTermObjective,
                    PlannedObservation = s.PlannedObservation,
                    ActualObservation = s.ActualObservation,
                    SuggestionsAndActions = s.SuggestionsAndActions
                }).ToList();
          
            return features;
        }

        public void UpdateMonitoring(int managementUnitId, List<MonitoringEditDto> monitoringEditDtos)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingData = Context.FeatureMonitoring.Include(f=>f.Feature).Where(i => i.Feature.ManagementUnitId == managementUnitId && !i.Deleted);

            List<int> editSetIds = monitoringEditDtos.Select(i => i.Id).ToList();

            List<int> existingRecordIds = existingData.Select(i => i.Id).ToList();

            //how do we find the new records
            //look through edit set and any that are not in existing data add

            var deletedRecords = (from existingRecord in existingData where !editSetIds.Contains(existingRecord.Id) select existingRecord.Id).ToList();

            var newRecords = monitoringEditDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id)).ToList();




            foreach (var xRec in existingData)
            {
                var matchedRecord = monitoringEditDtos.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {
                    xRec.Id = matchedRecord.Id;
                    xRec.ActualActionDate = matchedRecord.ActualActionDate;
                    xRec.ActualObservation = matchedRecord.ActualObservation;
                    xRec.ActualObservationDate = matchedRecord.ActualObservationDate;
                    xRec.DeadlineActionDate = matchedRecord.DeadlineActionDate;
                    xRec.PlannedObservation = matchedRecord.PlannedObservation;
                    xRec.PlannedObservationDate = matchedRecord.PlannedObservationDate;
                    xRec.PredictionShortTermObjective = matchedRecord.PredictionShortTermObjective;
                    xRec.SuggestionsAndActions = matchedRecord.SuggestionsAndActions;
                    xRec.Feature = Context.Feature.FirstOrDefault(f => f.Id == matchedRecord.FeatureID);
                    xRec.FeatureId = matchedRecord.FeatureID;
                }

                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                }
            }



            var recordsToAdd = newRecords.Select(nr => new FeatureMonitoring()
            {

                ActualActionDate = nr.ActualActionDate,
                ActualObservation = nr.ActualObservation,
                ActualObservationDate = nr.ActualObservationDate,
                DeadlineActionDate = nr.DeadlineActionDate,
                PlannedObservation = nr.PlannedObservation,
                PlannedObservationDate = nr.PlannedObservationDate.Year == 1 ? DateTime.Today : nr.PlannedObservationDate,
                PredictionShortTermObjective = nr.PredictionShortTermObjective,
                SuggestionsAndActions = nr.SuggestionsAndActions,
                Feature = Context.Feature.FirstOrDefault(f => f.Id == nr.FeatureID),
                FeatureId = nr.FeatureID,
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


        public List<MonitoringListDTO> GetMonitoringListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {


           
            var magicstring = @"SELECT        mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID, SUM(CASE WHEN (ft.TypeID IS NOT NULL OR
                         ft.AimID IS NOT NULL) AND fm.ID IS NOT NULL THEN 1 ELSE 0 END) AS CountKFObservations, SUM(CASE WHEN ft.TypeID IS NULL AND ft.AimID IS NULL AND ft.ID IS NOT NULL AND fm.ID IS NOT NULL THEN 1 ELSE 0 END) 
                         AS CountWCObservations, MIN(CASE WHEN fm.ActualObservationDate IS NULL THEN fm.PlannedObservationDate ELSE NULL END) AS NextObservationDate, MIN(CASE WHEN fm.ActualActionDate IS NULL 
                         THEN fm.DeadlineActionDate ELSE NULL END) AS NextActionDate, SUM(CASE WHEN fm.ActualObservationDate IS NULL AND fm.PlannedObservationDate < GETDATE() THEN 1 WHEN fm.ActualActionDate IS NULL AND 
                         fm.DeadlineActionDate < GETDATE() THEN 1 ELSE 0 END) AS CountOverdue
FROM            dbo.vw_MainAcquisitionUnit AS mau INNER JOIN
                         dbo.ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID LEFT OUTER JOIN
                         dbo.Feature AS ft ON ft.ManagementUnitID = mu.ID AND ft.Deleted = 0 LEFT OUTER JOIN
                         dbo.FeatureMonitoring AS fm ON fm.FeatureID = ft.ID AND fm.Deleted = 0
GROUP BY mau.MainAcquisitionUnitID, mu.ID";

            var data = ExecSQL<MonitoringData>(magicstring, Context).ToList();

            foreach (var d in data)
            {
                d.RegionId = _cache.ManagementUnitDtos.FirstOrDefault(x=>x.Id == d.ManagementUnitID)?.RegionId;
                d.WoodlandOfficerId = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID)?.WoodlandOfficerId;
                d.Name = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID)?.Name;

            }

            var monitoringList = data.Select(a => new MonitoringListDTO()
                {
                    ManagementUnitID = a.ManagementUnitID,
                    NextActionDate = a.NextActionDate.Validate(),
                    Region = RegionName(a.RegionId),
                    Manager = UserName(a.WoodlandOfficerId),
                    CostCentre = a.ManagementUnitID,
                    Name = a.Name == "" ? "Name not entered" : a.Name,
                    NextObservableDate = a.NextObservationDate.Validate(),
                    NoOfKFAimObservations = a.CountKFObservations,
                    NoOfWCObservations = a.CountWCObservations,
                    Overdue = a.CountOverdue,
                    Summary = ""
                })
                .ToList();


            return monitoringList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public List<ComboBoxValue> GetObservationTypeDtos(int filter)
        {
            var results = new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Description = "Not Set",
                    Name = "Not Set"
                }
            };

            foreach (var hazAct in Context.Feature.Include(f => f.Type).Where(m => m.ManagementUnitId == filter && m.TypeId != null))
            {
                results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Type.Description,
                    Name = hazAct.Type.Description
                });
            }

            return results;
        }
    }
}