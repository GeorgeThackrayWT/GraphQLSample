using System.Collections.Generic;
using System.Data;
using System.Linq;
using Abstractions;
using Abstractions.Stores.Content.InternalAudits;
using DataObjects;
using DataObjects.DTOS.InternalAudits;
using EDC_Estate.Models.DB;
using EDCORE.ViewModel;
using Microsoft.EntityFrameworkCore;
using MvvmHelpers;

namespace EFStores
{
    public class InternalAuditEfStore : BaseEFStore, IInternalAuditStore
    {
        private readonly ICache _iCache;
        
        public InternalAuditEfStore(EstateContext ec, ICache iCache) :
            base (ec,iCache)
        {         
         
        }

        public InternalAuditsObservationEditDto GetInternalAuditsObservations(int observationID)
        {
            var iao = Context.InternalAuditObservation.FirstOrDefault(p => p.InternalAuditId == observationID);

            var internalAuditsObservationEditDto = new InternalAuditsObservationEditDto();

            if (iao != null)
            {
                internalAuditsObservationEditDto = new InternalAuditsObservationEditDto()
                {
                    Id = iao.Id,
                    InternalAuditID = iao.InternalAuditId,
                    ActionByID = iao.ActionById.GetValueOrDefault(),
                    ClosedDate = iao.ClosedDate,
                    ClosingComments = iao.ClosingComments,
                    CorrectiveAction = iao.CorrectiveAction,
                    DueDate = iao.DueDate,
                    GradeID = iao.GradeId.GetValueOrDefault(),
                    Observation = iao.Observation,
                    UKWASTrustProcedure = iao.UkwastrustProcedure
                };
            }

            return internalAuditsObservationEditDto;
        }


        public List<InternalAuditsObservationEditDto> GetInternalAuditsObservationList(int internalAuditID)
        {           
            var relatedIds = Context.InternalAuditObservation.Where(z => z.InternalAuditId == internalAuditID).Select(i => new InternalAuditsObservationEditDto()
            {
                Id = i.Id,
                ActionByID = i.ActionById.GetValueOrDefault(),
                ClosedDate = i.ClosedDate,
                ClosingComments = i.ClosingComments,
                CorrectiveAction = i.CorrectiveAction,
                DueDate = i.DueDate,
                GradeID = i.GradeId.GetValueOrDefault(),
                LMDT = i.Lmdt,
                Observation = i.Observation,
                InternalAuditID = internalAuditID,
                UKWASTrustProcedure = i.UkwastrustProcedure
            }).ToList();

            foreach(var ob in relatedIds)
            {
                var actionedBy = new ComboBoxValue()
                {
                    ID = 0,
                    Description = "Not Set",
                    Name = "Not Set"
                };

                var internalGrade = new ComboBoxValue()
                {
                    ID = 0,
                    Description = "Not Set",
                    Name = "Not Set"
                };

                if (ob.ActionByID != 0)
                {
                    var user = Context.User.FirstOrDefault(f => f.Id == ob.ActionByID);

                    if (user != null)
                    {
                        actionedBy = new ComboBoxValue()
                        {
                            ID = ob.ActionByID,
                            Description = user.DisplayName,
                            Name = user.DisplayName
                        };
                    }
                }
            

                if (ob.GradeID != 0)
                {
                    var iGrade = Context.InternalAuditGrade.FirstOrDefault(f => f.Id == ob.ActionByID);

                    if (iGrade != null)
                    {
                        internalGrade = new ComboBoxValue()
                        {
                            ID = ob.GradeID,
                            Description = iGrade.Description,
                            Name = iGrade.Description
                        };
                    }
                }


                ob.ActionBy = actionedBy;

                ob.Grade = internalGrade;


            }

            return relatedIds;
        }

        public InternalAuditsEditDto GetInternalAuditsEditDtos(int internalAuditID)
        {
            var internalAudit = Context.InternalAudit.FirstOrDefault(f => f.Id == internalAuditID);
        
            var internalAuditsEditDto = new InternalAuditsEditDto()
            {  
                Id = internalAudit.Id,
                CertifiedByID = internalAudit.CertifiedById.GetValueOrDefault(),
                AuthoriseDate = internalAudit.AuthoriseDate,
                CertifyDate = internalAudit.CertifyDate,
                AuthorisedByID = internalAudit.AuthorisedById.GetValueOrDefault(),
                SiteManagerID = internalAudit.SiteManagerId.GetValueOrDefault(),
                AuditDate = internalAudit.AuditDate,
                SecondAuditorID = internalAudit.SecondAuditorId.GetValueOrDefault(),
                SecondAuditor = internalAudit.SecondAuditor,
                FirstAuditor = internalAudit.FirstAuditor,
                FirstAuditorID = internalAudit.FirstAuditorId.GetValueOrDefault(),
                GeneralSummary = internalAudit.GeneralSummary,
                Published = internalAudit.Published,
                PublishedByID = internalAudit.PublishedById.GetValueOrDefault(),
                PublishingDate = internalAudit.PublishingDate,
                SiteManager = internalAudit.SiteManager 
            };

            return internalAuditsEditDto;
        }

        public List<InternalAuditsSearchDto> GetInternalAuditsSearchDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {            
            var regionLookup = Context.AcquisitionUnitInternalAuditMap.Include(p=>p.AcquisitionUnit).ThenInclude(s=>s.ManagementUnit).ThenInclude(w=>w.Region)
                .Select(x=>new {x.InternalAuditId, x.AcquisitionUnit.ManagementUnit.Region.Name}).AsEnumerable()
                .ToLookup(kvp => kvp.InternalAuditId, kvp => kvp.Name);

            var data = Context.InternalAudit.Select(io => new InternalAuditsSearchDto()
            {
                ID = io.Id,               
                AuditDate = io.AuditDate,
                AutherisedCorrectDate = io.AuthoriseDate,
                AuthorisedCorrectBy = UserName(io.AuthorisedById),
                CertifiedCorrectBy = UserName(io.CertifiedById), 
                CertifiedCorrectDate = io.CertifyDate,
                Name = "N/A",
                ManagementUnitID = 0,
                Region = this.Lookup(io.SiteManagerId, regionLookup),
                Manager = UserName(io.SiteManagerId),
                CostCentre = 0,
                Location = "",
                LeadAuditor = io.FirstAuditor,
                SecondAuditor =io.SecondAuditor 
            }).ToList();


            if (regionId !=0)
            {
                data = data.Where(w => w.RecordId == regionId).ToList();
            }

            return data;
        }



        public List<InternalAuditsWoodlist> GetAuditWoods(int internalAuditID)
        {
            return new List<InternalAuditsWoodlist>();
        }
    }
}
