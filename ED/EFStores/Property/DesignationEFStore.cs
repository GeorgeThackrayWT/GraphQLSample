using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects.DTOS;
using EDC_Estate.Models.DB;

namespace EFStores.Property
{
    public class DesignationEFStore : BaseEFStore , IDesignationStore
    {
        private ILookupStore _iLookupStore;
     

        public DesignationEFStore(EstateContext ec,ICache iCache, ILookupStore iLookupStore, IUserStore iUserStore) : 
            base(ec,iCache)
        {
            _iLookupStore = iLookupStore;
            _iUserStore = iUserStore;
        }

        public List<InternalDesignationDto> GetIntDesignationDtos(int acquistionId)
        {    
            var result = Context.InternalDesignation.Select(idd => new InternalDesignationDto()
            {
                Id = idd.Id,
                Comments = idd.Comments,
                AcquisitionUnitID = idd.AcquisitionUnitId,
                InternalDesignationTypeId = idd.TypeId.GetValueOrDefault(),
                Deleted = idd.Deleted
            }).Where(a => !a.Deleted && a.AcquisitionUnitID == acquistionId );

            return result.ToList();
        }

        public void UpdateInternalDesignation(List<InternalDesignationDto> editSet, int acquisitionId)
        {

            var currentUserId = _iUserStore.CurrentUserId();
            var existingRecords = Context.InternalDesignation.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);

                if (matchedRecord != null)
                {

                    xRec.Comments = matchedRecord.Comments;
                    xRec.TypeId = matchedRecord.InternalDesignationTypeId == 0
                        ? null
                        : (int?) matchedRecord.InternalDesignationTypeId;
                }
                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.InternalDesignation()
            {
                AcquisitionUnitId = acquisitionId,
                Comments = nr.Comments,
                TypeId = nr.InternalDesignationTypeId == 0
                    ? null
                    : (int?)nr.InternalDesignationTypeId,

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

        public List<ExternalDesignationDto> GetExtDesignationDtos(int acquistionId)
        {
            var types = _iLookupStore.GetExtDesignationTypeDtos();

            return Context.Designation.Where(a=>a.AcquisitionUnitId == acquistionId && !a.Deleted).Select(t => new ExternalDesignationDto()
            {
                Id = t.Id,
                AcquisitionUnitID = t.AcquisitionUnitId,
                Comments = t.Comments,
                DesignatedAreaName = t.AreaName,
                DesignationTypeId = t.TypeId.GetValueOrDefault(),
                DesignatorID = t.DesignatorId.GetValueOrDefault(),
                Hectares = t.Hectares.GetValueOrDefault(),
                SitePartDescription = t.SiteDescription,
                DesignationDescription = types.First(f=>f.ID == t.TypeId.GetValueOrDefault()).Description
            }).ToList();
        }

        public void UpdateExternalDesignation(List<ExternalDesignationDto> editSet, int acquisitionId)
        {
            var currentUserId = _iUserStore.CurrentUserId();

            var existingRecords = Context.Designation.Where(e => !e.Deleted && e.AcquisitionUnitId == acquisitionId);

            List<int> editSetIds = editSet.Select(i => i.Id).ToList();
            List<int> existingRecordIds = existingRecords.Select(i => i.Id).ToList();


            var deletedRecords = (from existingRecord in existingRecords
                                  where !editSetIds.Contains(existingRecord.Id)
                                  select existingRecord.Id).ToList();

            var newRecords = editSet.Where(edittedRecord => !existingRecordIds.Contains(edittedRecord.Id))
                .ToList();



            foreach (var xRec in existingRecords)
            {
                var matchedRecord = editSet.FirstOrDefault(f => f.Id == xRec.Id);


                if (deletedRecords.Any(f => f == xRec.Id))
                {
                    xRec.Deleted = true;
                    xRec.Dldt = DateTime.Today;
                    xRec.Dluid = currentUserId;
                }

                if (matchedRecord == null) continue;


                xRec.AreaName = matchedRecord.DesignatedAreaName;
                xRec.Comments = matchedRecord.Comments;
                xRec.DesignatorId = matchedRecord.DesignatorID == 0 ? null : (int?) matchedRecord.DesignatorID;
                xRec.Hectares = matchedRecord.Hectares;
                xRec.SiteDescription = matchedRecord.SitePartDescription;
                xRec.TypeId = matchedRecord.DesignationTypeId == 0 ? null : (int?) matchedRecord.DesignationTypeId;
                
               
            }

            var recordsToAdd = newRecords.Select(nr => new EDC_Estate.Models.DB.Designation()
            {
                AreaName = nr.DesignatedAreaName,
                Comments = nr.Comments,
                DesignatorId = nr.DesignatorID == 0 ? null : (int?)nr.DesignatorID,
                Hectares = nr.Hectares,
                SiteDescription = nr.SitePartDescription,
                TypeId = nr.DesignationTypeId == 0 ? null : (int?)nr.DesignationTypeId,
                AcquisitionUnitId = acquisitionId,
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
