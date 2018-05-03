using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using EFStores.Fabric;
using Microsoft.EntityFrameworkCore;
using MvvmHelpers;

namespace EFStores
{
    public class HarvestingEFStore : BaseEFStore, IHarvestingStore
    {
        private ILookupStore _iLookupStore;

        public HarvestingEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore, ILookupStore iLookupStore) :
            base(ec,iCache)
        {
            _iLookupStore = iLookupStore;
            _iUserStore = iUserStore;
        }

        public List<HarvestingEditDTO> GetHarvestingEditContainerDTOForYear(int managementUnitID, int year)
        {
            var harvestingEditorList = new List<HarvestingEditDTO>();

            var features = Context.Harvesting.Include(i => i.Type).Include(s => s.SubCompartment)
                .Where(m => m.ManagementUnitId == managementUnitID && !m.Deleted).Select(s => new HarvestingEditDTO()
                {
                    Id = s.Id,
                    ManagementUnitID = s.ManagementUnitId,
                    TypeID = new ComboBoxValue() { ID = s.TypeId, Description = s.Type.Description, Name = s.Type.Description },
                    SubCompartmentID = new ComboBoxValue() { ID = s.SubCompartmentId, Description = s.SubCompartment.Compartment + s.SubCompartment.Reference, Name = s.SubCompartment.Reference },
                    WorkAreaInHectares = s.WorkAreaInHectares,
                    ActualAmount = s.ActualAmount.GetValueOrDefault(),
                    Comments = s.Comments,
                    CompletionDate = s.CompletionDate,
                    EstimatedAmount = s.EstimatedAmount,
                    ForecastYear = new ComboBoxValue() { ID = s.ForecastYear.GetValueOrDefault(), Description = s.ForecastYear.GetValueOrDefault().ToString(), Name = s.ForecastYear.GetValueOrDefault().ToString() },
                    VolumeHa = 0,
                    m3 = (s.Unit == "M3"),
                    t = (s.Unit == "t")
                });


            features = features.Where(w => w.ForecastYear.ID == year);

            harvestingEditorList.AddRange(features.ToList());

            return harvestingEditorList;
        }

        public List<HarvestingEditDTO> GetHarvestingEditContainerDTO(int managementUnitID, int option)
        {
         
            //    ID = 0,
            //    Name = "Historic",
       
            //    ID = 1,
            //    Name = "2018",
        
            //    ID = 2,
            //    Name = "Next 5 Years",
         
            //    ID = 3,
            //    Name = "All Years",
          


          //  var options = _iLookupStore.GetHarvestingYearOptions();

            var harvestingEditorList = new List<HarvestingEditDTO>();
            
            var features = Context.Harvesting.Include(i=>i.Type).Include(s=>s.SubCompartment)
                .Where(m => m.ManagementUnitId == managementUnitID && !m.Deleted).Select(s => new HarvestingEditDTO()
                {
                    Id = s.Id,
                    ManagementUnitID = s.ManagementUnitId,
                    TypeID = new ComboBoxValue() {ID = s.TypeId, Description = s.Type.Description, Name = s.Type.Description},
                    SubCompartmentID = new ComboBoxValue(){ID = s.SubCompartmentId , Description = s.SubCompartment.Compartment + s.SubCompartment.Reference, Name = s.SubCompartment.Reference} ,
                    WorkAreaInHectares = s.WorkAreaInHectares,
                    ActualAmount = s.ActualAmount.GetValueOrDefault(),
                    Comments = s.Comments,
                    CompletionDate = s.CompletionDate,
                    EstimatedAmount = s.EstimatedAmount,
                    ForecastYear = new ComboBoxValue(){ID = s.ForecastYear.GetValueOrDefault() , Description = s.ForecastYear.GetValueOrDefault().ToString() , Name = s.ForecastYear.GetValueOrDefault().ToString() } ,
                    VolumeHa = 0,
                    m3 = (s.Unit == "M3"),
                    t = (s.Unit == "t")
                });


            switch (option)
            {
                case 0:
                    features = features.Where(w => w.ForecastYear.ID < 2018);
                    break;
                case 1:
                    features = features.Where(w => w.ForecastYear.ID == 2018);
                    break;
                case 2:
                    features = features.Where(w => w.ForecastYear.ID >= 2018 && w.ForecastYear.ID <= 2023);
                    break;                
            }

            harvestingEditorList.AddRange(features.ToList());

            return harvestingEditorList;
        }

        public List<HarvestingListDTO> GetHarvestingListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            var magicstring = @"SELECT mau.MainAcquisitionUnitID AS ID, mu.ID AS ManagementUnitID
		                            , SUM(CASE WHEN DATEPART(year, GETDATE()) > hv.ForecastYear THEN ISNULL(hv.ActualAmount, 0.0) ELSE 0.0 END) AS HistoricAmount, DATEPART(year, 
                         GETDATE()) AS Year1, SUM(CASE WHEN DATEPART(year, GETDATE()) = hv.ForecastYear THEN ISNULL(hv.ActualAmount, ISNULL(hv.EstimatedAmount, 0.0)) ELSE 0.0 END) AS Year1Amount, DATEPART(year, GETDATE()) 
                         + 1 AS Year2, SUM(CASE WHEN DATEPART(year, GETDATE()) + 1 = hv.ForecastYear THEN ISNULL(hv.ActualAmount, ISNULL(hv.EstimatedAmount, 0.0)) ELSE 0.0 END) AS Year2Amount, DATEPART(year, GETDATE()) 
                         + 2 AS Year3, SUM(CASE WHEN DATEPART(year, GETDATE()) + 2 = hv.ForecastYear THEN ISNULL(hv.ActualAmount, ISNULL(hv.EstimatedAmount, 0.0)) ELSE 0.0 END) AS Year3Amount, DATEPART(year, GETDATE()) 
                         + 3 AS Year4, SUM(CASE WHEN DATEPART(year, GETDATE()) + 3 = hv.ForecastYear THEN ISNULL(hv.ActualAmount, ISNULL(hv.EstimatedAmount, 0.0)) ELSE 0.0 END) AS Year4Amount, DATEPART(year, GETDATE()) AS Year5, 
                         SUM(CASE WHEN DATEPART(year, GETDATE()) + 5 = hv.ForecastYear THEN ISNULL(hv.ActualAmount, ISNULL(hv.EstimatedAmount, 0.0)) ELSE 0.0 END) AS Year5Amount,
                             (SELECT        TOP (1) AWR
                               FROM            dbo.vw_SummaryDescriptionStats AS sds
                               WHERE        (ManagementUnitID = mu.ID)) AS AWR
FROM            dbo.vw_MainAcquisitionUnit AS mau INNER JOIN
                         dbo.ManagementUnit AS mu ON mu.ID = mau.ManagementUnitID LEFT OUTER JOIN
                         dbo.Harvesting AS hv ON hv.ManagementUnitID = mu.ID AND hv.Deleted = 0
GROUP BY mau.MainAcquisitionUnitID, mu.ID";
            
            var data = ExecSQL<HarvestListDTO>(magicstring, Context).ToList();

            foreach (var d in data)
            {
                var manu = _cache.ManagementUnitDtos.FirstOrDefault(x => x.Id == d.ManagementUnitID);

                if (manu != null)
                {
                    d.ApplicationId = manu.ApplicationId;
                    d.RegionId = manu.RegionId.GetValueOrDefault();
                    d.WoodlandOfficerId = manu.WoodlandOfficerId;
                    d.Name = manu.Name;
                   
                }



            }


            var retList = data.Select(v => new HarvestingListDTO
                {
                    ManagementUnitID = v.ManagementUnitID,
                    CostCentre = v.ManagementUnitID,
                    Region = RegionName(v.RegionId),
                    RegionId = v.RegionId,
                    ApplicationId = v.ApplicationId.GetValueOrDefault(),
                    Manager = UserName(v.WoodlandOfficerId),
                    PAWS = false,
                    Name = v.Name == "" ? "Name not entered" : v.Name,
                    Historic = (int) v.HistoricAmount,
                    ProductionForecastNext0 = (int) v.Year1Amount,
                    ProductionForecastNext1 = (int) v.Year2Amount,
                    ProductionForecastNext2 = (int) v.Year3Amount,
                    ProductionForecastNext3 = (int) v.Year4Amount,
                    ProductionForecastNext4 = (int) v.Year5Amount
                })
                .ToList();
          
            return retList.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(p => p.Name).ToList();
        }

        public List<ComboBoxValue> GetHarvestingOperations()
        {
            var results = new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Name = "Not Set"
                }
            };

            foreach (var hazAct in Context.HarvestingOperationType)
            {
                results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return results;
        }

        public List<ComboBoxValue> GetCompartments(int managementUnitId)
        {
            var results = new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Name = "Not Set"
                }
            };

            foreach (var hazAct in Context.SubCompartment.Where(m => m.ManagementUnitId == managementUnitId))
            {
                results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Compartment + "" + hazAct.Reference,
                    Name = hazAct.Reference
                });
            }

            return results;
        }

        public void UpdateHarvestingObjects(List<HarvestingEditDTO> harvestingEditDtos, int managementUnitId)
        {
            //throw new System.NotImplementedException();

            var currentUserId = _iUserStore.CurrentUserId();

            var existingHarvestings = Context.Harvesting.Where(e =>  !e.Deleted && e.ManagementUnitId == managementUnitId);

            List<int> editSetIds = harvestingEditDtos.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingHarvestings.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingHarvestings
                                  where !editSetIds.Contains(existingRecord.Id)
                select existingRecord.Id).ToList();

            var newRecords = harvestingEditDtos.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();
            
            foreach (var harvesting in existingHarvestings)
            {
                var matchedRecord = harvestingEditDtos.FirstOrDefault(f => f.Id == harvesting.Id);

             //   if (matchedRecord == null) continue;
              
                if (matchedRecord != null)
                {
                    var unitStr = "T";

                    if (matchedRecord.m3)
                        unitStr = "M3";

                    harvesting.ActualAmount = matchedRecord.ActualAmount;
                    harvesting.Comments = matchedRecord.Comments;
                    harvesting.CompletionDate = matchedRecord.CompletionDate;
                    harvesting.EstimatedAmount = matchedRecord.EstimatedAmount;
                    harvesting.ForecastYear = Convert.ToInt32(matchedRecord.ForecastYear.Name);
                    harvesting.WorkAreaInHectares = matchedRecord.WorkAreaInHectares;
                    harvesting.TypeId = matchedRecord.TypeID.ID;
                    harvesting.Type =
                        Context.HarvestingOperationType.FirstOrDefault(t => t.Id == matchedRecord.TypeID.ID);
                    harvesting.Unit = unitStr;                    
                }

                if (deletedRecords.Any(f => f == harvesting.Id))
                {
                    harvesting.Deleted = true;
                    harvesting.Dldt = DateTime.Today;
                    harvesting.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new Harvesting()
            {
           
                ManagementUnit = Context.ManagementUnit.First(f=>f.Id == managementUnitId),
                ActualAmount = nr.ActualAmount,
                Comments = nr.Comments,
                CompletionDate = nr.CompletionDate,
                EstimatedAmount = nr.EstimatedAmount,
                ForecastYear = nr.ForecastYear.ID,
                SubCompartment = Context.SubCompartment.First(f=>f.Id == nr.SubCompartmentID.ID),
                SubCompartmentId = nr.SubCompartmentID.ID,
                Type = Context.HarvestingOperationType.First(g=>g.Id == nr.TypeID.ID),
                TypeId = nr.TypeID.ID,
                Unit = nr.m3 ? "M3" : "T",
                WorkAreaInHectares = nr.WorkAreaInHectares,
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