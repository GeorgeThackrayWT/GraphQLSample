using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DTOS.ManagementPlans;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores
{
    
    public class ManagementUnitEFStore : BaseEFStore, IManagementUnitStore
    {
        public ManagementUnitEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : 
            base(ec, iCache)
        {
            _iUserStore = iUserStore;
        }

        public List<ManagementUnitDto> GetFilteredManagementUnits(string filter)
        {
            return Context.ManagementUnit.Where(w=> w.Name.ToLower().Contains(filter.ToLower())).Select(x => new ManagementUnitDto()
            {
                Id = x.Id,
                Name = x.Name,
                
            }).ToList();
        }

        public List<ManagementPlanDto> GetManagementPlans()
        {
            return Context.ManagementPlan.Select(x => new ManagementPlanDto()
            {
                Id = x.Id,
                Deleted = x.Deleted,
                IsProtected = x.IsProtected,
                IsHistorical = x.IsHistorical,
                IsDefaultValue = x.IsDefaultValue,
                ULMDT = DateTime.Today,
                LMUID = 1,
                CRDT = x.Crdt,
                ULMUID = 1,
                CRUID = x.Cruid,
                DLUID = x.Dluid,
                LMDT = x.Lmdt,
                DLDT = x.Dldt,
                Approved = x.Approved,
                ApprovedByID = x.ApprovedById,
                ConsultationEndDate = x.ConsultationEndDate,
                DateApproved = x.DateApproved,
                LastExported = x.LastExported,
                PDFFile = x.Pdffile,
                PeriodFrom = x.PeriodFrom,
                PeriodTo = x.PeriodTo,
                ReviewDeadline = x.ReviewDeadline,
                UnderConsultation = x.UnderConsultation,
                UnderReview = x.UnderReview,
                WoodBoardJPGFile = x.WoodBoardJpgfile,
                WoodBoardPDFFile = x.WoodBoardPdffile

            }).ToList();
        }
        
    

        public int CreateManagementUnit(string costCenter)
        {
            int costCenterId = 0;

            bool invalidNumber = int.TryParse(costCenter, out costCenterId);

            var adminArea = Context.AdministrationArea.FirstOrDefault();
            var application = Context.Application.FirstOrDefault();
            var department = Context.Department.FirstOrDefault();
            var interimPortfolio = Context.PortfolioCategory.FirstOrDefault();
            var region = Context.Region.FirstOrDefault();
            var currentUserId = _iUserStore.CurrentUserId();
            var siteCategoryId = Context.SiteCategory.FirstOrDefault();
            var manplanId = Context.ManagementPlan.FirstOrDefault();

            if (!invalidNumber)
                costCenterId = Context.ManagementUnit.Max(m => m.Id)+1;

            var manu = new ManagementUnit()
            {
                Id = costCenterId,
                AccessCategory = "",
                Name ="new record",
                AdditionalInformation = "",
                AdministrationArea = "",
                AdministrationAreaId = adminArea.Id,
                AllowPoso = false,
                AntisocialIssues = "",
                ApplicationId = application.Id,
                Aspect = "",
                BoundariesDescription = "",
                ClumpedManagementUnitId = null,
                DeerCullPlan = "",
                DepartmentId = department.Id,
                DeputyId = currentUserId,
                DirectionsToMainEntrance = "",
                ExcludeFromAccountsReporting = false,
                EstateCategory = "",
                InterimPortfolioCategoryId = interimPortfolio.Id,
                ManagementPlanId =  manplanId.Id,
                PortfolioCategoryId = interimPortfolio.Id,
                RegionId = region.Id,
                Remarks = "remarkss",
                PreviousOfficerId = currentUserId,
                SiteCategoryId = siteCategoryId.Id,
                WoodlandOfficerId = currentUserId,
               
            };


            Context.Add(manu);

            Context.SaveChanges();

            return manu.Id;
        }

        public List<ManagementUnitShortDto> GetManagementUnitLookupData(int applicationId)
        {
            return _cache.ManagementUnitDtos.Where(m => m.ApplicationId == applicationId).Select(t =>
                new ManagementUnitShortDto()
                {
                    ManagementUnitId = t.Id,
                    Name = t.Name == "" ? "Name Not Entered" : t.Name,
                }).OrderBy(o=>o.Name).ToList();
        }

        public List<ManagementUnitShortDto> GetManagementUnitLookupData()
        {
            return _cache.ManagementUnitDtos.Select(t =>
                new ManagementUnitShortDto()
                {
                    ManagementUnitId = t.Id,
                    Name = t.Name == "" ? "Name Not Entered" : t.Name,
                }).OrderBy(o => o.Name).ToList();
        }

        public List<ManagementUnitDto> GetManagementUnits()
        {
            return _cache.ManagementUnitDtos;
        }

        public List<TenureDto> GetTenures()
        {
            return Context.Tenure.Select(s => new TenureDto()
            {
                Id = s.Id,
                Name = s.Description,
                Lmdt = s.Lmdt,
                Deleted = s.Deleted,
                Description = s.Description,
                
                IsProtected = s.IsProtected,
                Lmuid = s.Lmuid,
                Crdt = s.Crdt,

                Cruid = s.Cruid,
                Dluid = s.Dluid,
                IsHistorical = s.IsHistorical,
                Dldt = s.Dldt,
                IsDefaultValue = s.IsDefaultValue
            }).ToList();
        }

        public List<ManagementUnitDto> GetManagementUnitDtosForCache()
        {
            var managementUnitDtos = Context.ManagementUnit.AsNoTracking().ToList().Select(m => new ManagementUnitDto()
            {
                Id = m.Id,
                Deleted = m.Deleted,
                CRDT = m.Crdt,
                CRUID = m.Cruid,
                DLDT = m.Dldt,
                DLUID = m.Dluid,
                LMDT = m.Lmdt,
                LMUID = m.Lmuid,
                ULMDT = DateTime.Today,
                ULMUID = 1,

                Name = m.Name,
                AccessCategory = m.AccessCategory,
                AdditionalInformation = m.AdditionalInformation,
                AdministrationArea = m.AdministrationArea,
                AdministrationAreaId = m.AdministrationAreaId,
                AllowPOSO = m.AllowPoso,
                AntisocialIssues = m.AntisocialIssues,
                ApplicationId = m.ApplicationId,
                Aspect = m.Aspect,
                BoundariesDescription = m.BoundariesDescription,
                ClumpedManagementUnitId = m.ClumpedManagementUnitId,
                DeerCullPlan = m.DeerCullPlan,
                DepartmentId = m.DepartmentId,
                DeputyId = m.DeputyId,
                DirectionsToMainEntrance = m.DirectionsToMainEntrance,
                Disposed = m.Disposed,
                EstateCategory = m.EstateCategory,
                ExcludeFromAccountsReporting = m.ExcludeFromAccountsReporting,
                ForecastApproved = m.ForecastApproved,
                GridReference = m.GridReference,
                HarvestingComments = m.HarvestingComments,
                InterimCategory = m.InterimCategory,
                InterimPortfolioCategoryId = m.InterimPortfolioCategoryId,
                IsDefaultValue = m.IsDefaultValue,
                IsHistorical = m.IsHistorical,
                IsMainClumpedSite = m.IsMainClumpedSite,
                IsPAWS = m.IsPaws,
                IsPotSite = m.IsPotSite,
                IsProtected = m.IsProtected,
                LocalName = m.LocalName,
                LocalNameDesc = m.LocalNameDesc,
                LongTermIntentions = m.LongTermIntentions,
                MainAccessGridReference = m.MainAccessGridReference,
                ManagementAccessDescription = m.ManagementAccessDescription,
                ManagementPlanId = m.ManagementPlanId,
                MaximumAltitude = m.MaximumAltitude,
                MicrositeURL = m.MicrositeUrl,
                MinimumAltitude = m.MinimumAltitude,
                NavisionId = m.NavisionId,
                NewEstateCategory = m.NewEstateCategory,
                NonStandardKey = m.NonStandardKey,
                ParentManagementUnitId = m.ParentManagementUnitId,
                PortfolioCategoryId = m.PortfolioCategoryId,
                PostCode = m.PostCode,
                PreviousOfficerId = m.PreviousOfficerId,
                PublicAccessDescription = m.PublicAccessDescription,
                PublishedSummaryDescription = m.PublishedSummaryDescription,
                RegionId = m.RegionId,
                Remarks = m.Remarks,
                RiskAssessmentId = m.RiskAssessmentId,
                SiteCategoryId = m.SiteCategoryId,
                SpecialSiteFeatures = m.SpecialSiteFeatures,
                SuitableForFilming = m.SuitableForFilming,
                SummaryDescription = m.SummaryDescription,
                VATRecoverable = m.Vatrecoverable,
                WCBudget = m.Wcbudget,
                WebsiteVisits = m.WebsiteVisits,
                WoodlandOfficerId = m.WoodlandOfficerId
            }).ToList();

            return managementUnitDtos;
        }

        public Dictionary<int,int> GetAcquisitionUnitOfficers()
        {
            var acquisitionUnitOfficers  = new Dictionary<int, int>();

            var acqs = Context.AcquisitionUnit.AsNoTracking().ToList().Select(n => new
            {
                n.ManagementUnitId,
                n.AcquisitionOfficerId
            });


            foreach (var a in acqs)
            {
                if (!acquisitionUnitOfficers.ContainsKey(a.ManagementUnitId))
                {
                    acquisitionUnitOfficers.Add(a.ManagementUnitId,a.AcquisitionOfficerId.GetValueOrDefault());
                }
            }

            return acquisitionUnitOfficers;
        }
    }
}
