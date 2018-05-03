using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using MvvmHelpers;
using Stores;

namespace SQLite
{
    public class HarvestingStore : BaseStore, IHarvestingStore
    {
        public HarvestingStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _sqLiteSyncConnection = GetSynchConnection();
        }

       
        public List<HarvestingEditDTO> GetHarvestingEditContainerDTO(int managementUnitID)
        {

            var harvestingEditorList = new List<HarvestingEditDTO>();
            
            var magicString = @"SELECT ID,TypeID,ManagementUnitID,SubCompartmentID,WorkAreaInHectares,0 AS VolHa,EstimatedAmount,ActualAmount,ForecastYear,CompletionDate
	                              ,CASE Unit WHEN 't' then 1 else 0 end as t
	                              ,CASE Unit WHEN 'M3' then 1 else 0 end as m3
                              FROM Harvesting WHERE ManagementUnitID = " + managementUnitID;

            var features = _sqLiteSyncConnection.Query<HarvestingEditDTO>(magicString).ToList();

            harvestingEditorList.AddRange(features);

            return harvestingEditorList;
        }


        public List<HarvestingListDTO> GetHarvestingListDtos()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Debug.WriteLine("GetHarvestingListDtos started");

            List<HarvestingListDTO> retList = new List<HarvestingListDTO>();

            var magicstring = @"SELECT mau1.MainAcquisitionUnitID AS ID, mu1.ID AS ManagementUnitID
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) > hv.ForecastYear THEN ifnull(hv.ActualAmount, 0.0)
				                            ELSE 0.0
			                            END) HistoricAmount
		                            , strftime('%Y', date('now')) as Year1
		
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) = hv.ForecastYear THEN ifnull(hv.ActualAmount, ifnull(hv.EstimatedAmount,0.0))
				                            ELSE 0.0
			                            END) Year1Amount
		                            , (strftime('%Y', date('now')) + 1) as Year2
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) + 1 = hv.ForecastYear THEN ifnull(hv.ActualAmount, ifnull(hv.EstimatedAmount,0.0))
				                            ELSE 0.0
			                            END) Year2Amount
		                            , (strftime('%Y', date('now')) + 2) as Year3
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) + 2 = hv.ForecastYear THEN ifnull(hv.ActualAmount, ifnull(hv.EstimatedAmount,0.0))
				                            ELSE 0.0
			                            END) Year3Amount
		                            , (strftime('%Y', date('now')) + 3) as Year4
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) + 3 = hv.ForecastYear THEN ifnull(hv.ActualAmount, ifnull(hv.EstimatedAmount,0.0))
				                            ELSE 0.0
			                            END) Year4Amount
		                            , (strftime('%Y', date('now')))as Year5
		                            , SUM(
			                            CASE 
				                            WHEN strftime('%Y', date('now')) + 5 = hv.ForecastYear THEN ifnull(hv.ActualAmount, ifnull(hv.EstimatedAmount,0.0))
				                            ELSE 0.0
			                            END) Year5Amount
		                            , 0 as AWR
		
                            FROM    (SELECT ID AS MainAcquisitionUnitID, ManagementUnitID FROM AcquisitionUnit) AS mau1
		                            INNER JOIN ManagementUnit AS mu1 ON mu1.ID = mau1.ManagementUnitID
		                            LEFT OUTER JOIN Harvesting AS hv ON hv.ManagementUnitID = mu1.ID AND hv.Deleted = 0
                            GROUP BY mau1.MainAcquisitionUnitID, mu1.ID";


            var data = _sqLiteSyncConnection.Query<HarvestListDTO>(magicstring).ToList();

            foreach (var v in data)
            {


                var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == v.ManagementUnitID);


                var sum = new HarvestingListDTO
                {
                    ManagementUnitID = v.ManagementUnitID,
                    CostCentre = v.ManagementUnitID,
                    Region = _iCache.RegionLookup[manu.RegionId.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[manu.WoodlandOfficerId],
                    PAWS = false,
                    Name = manu.Name,
                    Historic = (int)v.HistoricAmount,
                    ProductionForecastNext0 = (int)v.Year1Amount,
                    ProductionForecastNext1 = (int)v.Year2Amount,
                    ProductionForecastNext2 = (int)v.Year3Amount,
                    ProductionForecastNext3 = (int)v.Year4Amount,
                    ProductionForecastNext4 = (int)v.Year5Amount

                };

                retList.Add(sum);
            }
            //GetHarvestingListDtos
            stopwatch.Stop();

            Debug.WriteLine("GetHarvestingListDtos ended in: " + stopwatch.ElapsedMilliseconds);



            return retList.OrderBy(p=>p.Name).ToList();
        }

        public List<ComboBoxValue> GetHarvestingOperations()
        {
            throw new System.NotImplementedException();
        }

        public List<ComboBoxValue> GetCompartments(int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<ComboBoxValue> GetYears()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateHarvestingObjects(List<HarvestingEditDTO> harvestingEditDtos, int managementUnitId)
        {
            throw new System.NotImplementedException();
        }

        public List<HarvestingEditDTO> GetHarvestingEditContainerDTO(int managementUnitID, int option)
        {
            throw new System.NotImplementedException();
        }

        public List<HarvestingEditDTO> GetHarvestingEditContainerDTOForYear(int managementUnitID, int option)
        {
            throw new System.NotImplementedException();
        }

        public List<HarvestingListDTO> GetHarvestingListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new System.NotImplementedException();
        }
    }
}