using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects.DAOS;
using DataObjects.DTOS;
using Stores;

namespace SQLite
{
    public class DesignationStore : BaseStore, IDesignationStore
    {
        private readonly ISQLiteCache _iCache;

        public DesignationStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteSyncConnection = GetSynchConnection();
        }
        
        public List<ExternalDesignationDto> GetExtDesignationDtos(int acquistionId)
        {
            var designations = _sqLiteSyncConnection.Table<Designation>().Where(a=>a.AcquisitionUnitID == acquistionId).ToList();
            //var designationTypes = _sqLiteSyncConnection.Table<DesignationType>().ToList();
            //var designators = _sqLiteSyncConnection.Table<Designator>().ToList();
            
            return designations.Select(t => new ExternalDesignationDto()
            {
                Id = t.ID,
                AcquisitionUnitID = t.AcquisitionUnitID,
                Comments = t.Comments,
                DesignatedAreaName = t.AreaName,
                DesignationTypeId = t.TypeID.GetValueOrDefault(),
                DesignatorID = t.DesignatorID.GetValueOrDefault(),
                Hectares = t.Hectares.GetValueOrDefault(),
                SitePartDescription = t.SiteDescription
            }).ToList();


        }


        public List<InternalDesignationDto> GetIntDesignationDtos(int acquistionId)
        {

            var internalDesignations = _sqLiteSyncConnection.Table<InternalDesignation>().ToList();

            var result = internalDesignations.Select(tenure => new InternalDesignationDto()
            {
                Id = tenure.ID,
                Comments = tenure.Comments,
                AcquisitionUnitID = tenure.AcquisitionUnitID,
                InternalDesignationTypeId = tenure.TypeID.GetValueOrDefault(),           
            }).Where(a => a.AcquisitionUnitID == acquistionId);


            return result.ToList();
        }

        public void UpdateExternalDesignation(List<ExternalDesignationDto> editSet, int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateInternalDesignation(List<InternalDesignationDto> editSet, int acquisitionId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateInternalExternalDesignation(List<ExternalDesignationDto> editSet, int acquisitionId)
        {
            throw new System.NotImplementedException();
        }
    }
}