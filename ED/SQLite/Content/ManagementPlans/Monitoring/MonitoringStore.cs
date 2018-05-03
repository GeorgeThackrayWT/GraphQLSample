using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using EDCORE.ViewModel;
using MvvmHelpers;
using SQLite.DataTypes;
using Stores;
using Utils;

namespace SQLite
{
    public class MonitoringStore : BaseStore, IMonitoringStore
    {
        public MonitoringStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public MonitoringEditContainerDto GetMonitoringEditContainerDto(int managementUnitId)
        {
            var monitoringEditContainerDTO = new MonitoringEditContainerDto()
            {
                ObservationsList = new ObservableRangeCollection<MonitoringEditDto>()
            };

            var magicString = @"SELECT f.ManagementUnitID,f.TypeID ,fm.FeatureID, fm.PlannedObservationDate,fm.ActualObservationDate, fm.DeadlineActionDate,fm.ActualActionDate, fm.PredictionShortTermObjective, fm.PlannedObservation, fm.ActualObservation, fm.SuggestionsAndActions
                                  FROM FeatureMonitoring fm join Feature f on f.ID = fm.FeatureID
                                  WHERE f.TypeID is not null and  f.ManagementUnitID = " + managementUnitId;

            var features = _sqLiteSyncConnection.Query<MonitoringEditDto>(magicString).ToList();

            monitoringEditContainerDTO.ObservationsList.AddRange(features);


            return monitoringEditContainerDTO;
        }

        public List<MonitoringListDTO> GetMonitoringListDtos()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetMonitoringListDtos started");

            var magicString = @"SELECT  mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID, mu.Name AS Name
		, SUM(case 
				when (ft.TypeID IS NOT NULL OR ft.AimID IS NOT NULL) AND fm.ID IS NOT NULL then 1
				else 0
			  end) CountKFObservations		
		, SUM(case 
				when ft.TypeID IS NULL AND ft.AimID IS NULL AND ft.ID IS NOT NULL AND fm.ID IS NOT NULL then 1
				else 0
			  end) CountWCObservations
		, MIN(case when fm.ActualObservationDate IS NULL then fm.PlannedObservationDate else NULL end) NextObservationDate
		, MIN(case when fm.ActualActionDate IS NULL then fm.DeadlineActionDate else NULL end) NextActionDate
		, SUM ( case 
					when fm.ActualObservationDate IS NULL AND fm.PlannedObservationDate < date('now') then 1
					when fm.ActualActionDate IS NULL AND fm.DeadlineActionDate < date('now') then 1
					else 0
				  end) CountOverdue
FROM    (SELECT    ID AS MainAcquisitionUnitID, ManagementUnitID
FROM     AcquisitionUnit) AS mau 
		INNER JOIN ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID
		LEFT OUTER JOIN Feature AS ft ON ft.ManagementUnitID = mu.ID AND ft.Deleted = 0
		LEFT OUTER JOIN FeatureMonitoring AS fm ON fm.FeatureID = ft.ID AND fm.Deleted = 0
GROUP BY mau.MainAcquisitionUnitID, mu.ID";

            var data = _sqLiteSyncConnection.Query<MonitoringData>(magicString).ToList();

            var monitoringList = new List<MonitoringListDTO>();

            foreach (var a in data)
            {
                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == a.ManagementUnitID);


                var monitoringListDto = new MonitoringListDTO()
                {
                    ManagementUnitID = a.ManagementUnitID,
                    NextActionDate = a.NextActionDate.Validate(),
                    Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                    CostCentre = a.ManagementUnitID,
                    Name = a.Name,
                    NextObservableDate = a.NextObservationDate.Validate(),
                    NoOfKFAimObservations = a.CountKFObservations,
                    NoOfWCObservations = a.CountWCObservations,
                    Overdue = a.CountOverdue,
                    Summary = ""

                };
                monitoringList.Add(monitoringListDto);
            }

            stopwatch.Stop();

            Debug.WriteLine("GetMonitoringListDtos ended in: " + stopwatch.ElapsedMilliseconds);


            return monitoringList.OrderBy(o=>o.Name).ToList();
        }

        public List<MonitoringListDTO> GetMonitoringListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }

        public List<ComboBoxValue> GetObservationTypeDtos(int filter)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateMonitoring(int managementUnitId, List<MonitoringEditDto> monitoringEditDtos)
        {
            throw new System.NotImplementedException();
        }

        List<MonitoringEditDto> IMonitoringStore.GetMonitoringEditContainerDto(int managementUnitId)
        {
            throw new System.NotImplementedException();
        }
    }
}