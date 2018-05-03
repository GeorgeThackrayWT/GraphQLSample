using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores.Content.InternalAudits;
using DataObjects.DAOS;
using DataObjects.DTOS.InternalAudits;
using EDCORE.ViewModel;
using MvvmHelpers;
using SQLite.DataTypes;
using Stores;

namespace SQLite.Content.InternalAudits
{
    public class InternalAuditStoreStore : BaseStore, IInternalAuditStore
    {
       
        private readonly ILookupStore _lookupStore;

        public InternalAuditStoreStore(IDBPlatformSettings platform, ISQLiteCache iCache, ILookupStore iLookupStore)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _lookupStore = iLookupStore;

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public InternalAuditsObservationEditDto GetInternalAuditsObservations(int observationID)
        {     
            var iao = _sqLiteSyncConnection.Table<InternalAuditObservation>().FirstOrDefault(f => f.InternalAuditID == observationID);

            var internalAuditsObservationEditDto = new InternalAuditsObservationEditDto();

            if (iao != null)
            {
                internalAuditsObservationEditDto = new InternalAuditsObservationEditDto()
                {
                    Id = iao.ID,
                    InternalAuditID = iao.InternalAuditID,
                    ActionByID = iao.ActionByID.GetValueOrDefault(),
                    ClosedDate = iao.ClosedDate,
                    ClosingComments = iao.ClosingComments,
                    CorrectiveAction = iao.CorrectiveAction,
                    DueDate = iao.DueDate,
                    GradeID = iao.GradeID.GetValueOrDefault(),
                    Observation = iao.Observation,
                    UKWASTrustProcedure = iao.UKWASTrustProcedure
                };
            }
          

            return internalAuditsObservationEditDto;
        }
   
        public InternalAuditsEditDto GetInternalAuditsEditDtos(int internalAuditID)
        {

            var ia =_sqLiteSyncConnection.Table<InternalAudit>().FirstOrDefault(f => f.ID == internalAuditID);

            var iaos = _sqLiteSyncConnection.Query<InternalAuditsObservationEditDto>("Select ID from InternalAuditObservation").Where(f => f.InternalAuditID == internalAuditID);

            var i2 = new ObservableRangeCollection<InternalAuditsObservationEditDto>();
            i2.ReplaceRange(iaos.ToList());

            if(i2.Count ==0) i2.Add(new InternalAuditsObservationEditDto() {Id= 9});

            var internalAuditsEditDto = new InternalAuditsEditDto()
            {
                Id = ia.ID,
                CertifiedByID = ia.CertifiedByID.GetValueOrDefault(),
                AuthoriseDate = ia.AuthoriseDate,
                CertifyDate = ia.CertifyDate,
                AuthorisedByID = ia.AuthorisedByID.GetValueOrDefault(),
                SiteManagerID = ia.SiteManagerID.GetValueOrDefault(),
                AuditDate = ia.AuditDate,
                SecondAuditorID = ia.SecondAuditorID.GetValueOrDefault(),
                SecondAuditor = ia.SecondAuditor,
                FirstAuditor = ia.FirstAuditor,
                FirstAuditorID = ia.FirstAuditorID.GetValueOrDefault(),
                GeneralSummary = ia.GeneralSummary,
                Published = ia.Published,
                PublishedByID = ia.PublishedByID.GetValueOrDefault(),
                PublishingDate = ia.PublishingDate,
                SiteManager = ia.SiteManager
            };
            
            return internalAuditsEditDto;
        }

        public List<InternalAuditsSearchDto> GetInternalAuditsSearchDtos()
        {
            var internalAudits = _sqLiteSyncConnection.Query<InternalAuditSearchResult>(@"SELECT DISTINCT ia.ID ,AuditDate ,SiteManagerID ,SiteManager
                                                                                                            ,FirstAuditorID ,FirstAuditor
                                                                                                            ,SecondAuditorID ,SecondAuditor
                                                                                                            ,GeneralSummary ,CertifiedByID
                                                                                                            ,CertifyDate ,AuthorisedByID
                                                                                                            ,AuthoriseDate ,Published
                                                                                                            ,PublishedByID ,PublishingDate,mu.RegionID
                                                                                                  FROM InternalAudit  ia
                                                                                                  JOIN AcquisitionUnitInternalAuditMap auiam
                                                                                                  on ia.ID = auiam.InternalAuditID
	                                                                                                JOIN AcquisitionUnit au
	                                                                                                on au.ID = auiam.AcquisitionUnitID
	                                                                                                JOIN ManagementUnit mu
	                                                                                                on au.ManagementUnitID = mu.ID");



            List<InternalAuditsSearchDto> results = new List<InternalAuditsSearchDto>();

            

            foreach (var io in internalAudits)
            {
            //    var user = _iCache.Users.FirstOrDefault(u => u.ID == io.SiteManagerID);

             
                results.Add(new InternalAuditsSearchDto()
                {
                    ID = io.ID,
                    //Name = io.n
                    AuditDate = io.AuditDate,
                    AutherisedCorrectDate = io.AuthoriseDate,
                    AuthorisedCorrectBy = _iCache.UserLookup[io.AuthorisedByID.GetValueOrDefault()],
                    CertifiedCorrectBy = _iCache.UserLookup[io.CertifiedByID.GetValueOrDefault()],
                    CertifiedCorrectDate = io.CertifyDate,
                    Name = "N/A",
                    ManagementUnitID = 0,
                    Region = _iCache.RegionLookup[io.RegionID.GetValueOrDefault()],
                    Manager = _iCache.UserLookup[io.SiteManagerID.GetValueOrDefault()],
                    CostCentre = 0,
                    Location = "",
                    LeadAuditor = _iCache.UserLookup[io.FirstAuditorID.GetValueOrDefault()],
                    SecondAuditor = _iCache.UserLookup[io.SecondAuditorID.GetValueOrDefault()],

                });
            }

            return results;
        }

        public List<InternalAuditsWoodlist> GetAuditWoods(int internalAuditID)
        {
            var ia = _sqLiteSyncConnection.Table<AcquisitionUnitInternalAuditMap>().Where(f => f.InternalAuditID == internalAuditID);



            var woods = new List<InternalAuditsWoodlist>();

            foreach (var rec in ia)
            {

                var acq = _iCache.AcquisitionUnits.FirstOrDefault(f => f.ID == rec.ID);

                if (acq != null)
                {
                    woods.Add(new InternalAuditsWoodlist()
                    {
                        Id = rec.ID,
                        CostCentre = acq.ManagementUnitID,
                        AcquisitionUnitID = acq.ID,
                        WoodNumber = 0,
                        WoodName = acq.Name
                    });
                }
            }

            if (woods.Count == 0)
            {
                woods.Add(new InternalAuditsWoodlist()
                {
                    Id = 1,
                    CostCentre = 1,
                    AcquisitionUnitID = 1,
                    WoodName = "Sample Data",
                    WoodNumber = 1
                });
            }

            return woods;
        }

        public List<InternalAuditsObservationEditDto> GetInternalAuditsObservationList(int internalAuditID)
        {
            throw new NotImplementedException();
        }

        public List<InternalAuditsSearchDto> GetInternalAuditsSearchDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }
    }
}
