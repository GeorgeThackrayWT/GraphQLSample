//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Abstractions;
//using Abstractions.Stores;
//using DataObjects;
//using EDCORE.ViewModel;
//using EDC_Estate.Models.DB;
//using Microsoft.EntityFrameworkCore;
//using DataObjects.DTOS;
//using EDCORE.Helpers;

//namespace EDCORE
//{


//    public class Cache : ICache
//    {
    



//        public ILookup<int, string> UserLookup { get; set; }

//        public ILookup<int, string> RegionLookup { get; set; }

//        public List<ManagementUnitDto> ManagementUnitDtos { get; set; }

//        public List<ExpenditureDto> ExpendituresDtos { get; set; }

//        public List<UserDto> UserDtos { get; set; } = new List<UserDto>();

//        public List<UserRoleSmallDto> UserRoleSmallDtos { get; set; } = new List<UserRoleSmallDto>();

//        public List<ComboBoxValue> DesignationLookup { get; set; } = new List<ComboBoxValue>();



//        public Cache(IPageMessageBus iPageMessageBus)
//        {
        
//        }

//        public void Init()
//        {

//            using (var _ec = new EstateContext())
//            {

//                UserLookup = _ec.User.AsNoTracking().ToList().Select(p => new {p.Id, p.DisplayName})
//                    .AsEnumerable()
//                    .ToLookup(kvp => kvp.Id, kvp => kvp.DisplayName);

//                ManagementUnitDtos = _ec.ManagementUnit.AsNoTracking().ToList().Select(m => new ManagementUnitDto()
//                {
//                    Id = m.Id,
//                    Deleted = m.Deleted,
//                    CRDT = m.Crdt,
//                    CRUID = m.Cruid,
//                    DLDT = m.Dldt,
//                    DLUID = m.Dluid,
//                    LMDT = m.Lmdt,
//                    LMUID = m.Lmuid,
//                    ULMDT = DateTime.Today,
//                    ULMUID = 1,

//                    Name = m.Name,
//                    AccessCategory = m.AccessCategory,
//                    AdditionalInformation = m.AdditionalInformation,
//                    AdministrationArea = m.AdministrationArea,
//                    AdministrationAreaId = m.AdministrationAreaId,
//                    AllowPOSO = m.AllowPoso,
//                    AntisocialIssues = m.AntisocialIssues,
//                    ApplicationId = m.ApplicationId,
//                    Aspect = m.Aspect,
//                    BoundariesDescription = m.BoundariesDescription,
//                    ClumpedManagementUnitId = m.ClumpedManagementUnitId,
//                    DeerCullPlan = m.DeerCullPlan,
//                    DepartmentId = m.DepartmentId,
//                    DeputyId = m.DeputyId,
//                    DirectionsToMainEntrance = m.DirectionsToMainEntrance,
//                    Disposed = m.Disposed,
//                    EstateCategory = m.EstateCategory,
//                    ExcludeFromAccountsReporting = m.ExcludeFromAccountsReporting,
//                    ForecastApproved = m.ForecastApproved,
//                    GridReference = m.GridReference,
//                    HarvestingComments = m.HarvestingComments,
//                    InterimCategory = m.InterimCategory,
//                    InterimPortfolioCategoryId = m.InterimPortfolioCategoryId,
//                    IsDefaultValue = m.IsDefaultValue,
//                    IsHistorical = m.IsHistorical,
//                    IsMainClumpedSite = m.IsMainClumpedSite,
//                    IsPAWS = m.IsPaws,
//                    IsPotSite = m.IsPotSite,
//                    IsProtected = m.IsProtected,
//                    LocalName = m.LocalName,
//                    LocalNameDesc = m.LocalNameDesc,
//                    LongTermIntentions = m.LongTermIntentions,
//                    MainAccessGridReference = m.MainAccessGridReference,
//                    ManagementAccessDescription = m.ManagementAccessDescription,
//                    ManagementPlanId = m.ManagementPlanId,
//                    MaximumAltitude = m.MaximumAltitude,
//                    MicrositeURL = m.MicrositeUrl,
//                    MinimumAltitude = m.MinimumAltitude,
//                    NavisionId = m.NavisionId,
//                    NewEstateCategory = m.NewEstateCategory,
//                    NonStandardKey = m.NonStandardKey,
//                    ParentManagementUnitId = m.ParentManagementUnitId,
//                    PortfolioCategoryId = m.PortfolioCategoryId,
//                    PostCode = m.PostCode,
//                    PreviousOfficerId = m.PreviousOfficerId,
//                    PublicAccessDescription = m.PublicAccessDescription,
//                    PublishedSummaryDescription = m.PublishedSummaryDescription,
//                    RegionId = m.RegionId,
//                    Remarks = m.Remarks,
//                    RiskAssessmentId = m.RiskAssessmentId,
//                    SiteCategoryId = m.SiteCategoryId,
//                    SpecialSiteFeatures = m.SpecialSiteFeatures,
//                    SuitableForFilming = m.SuitableForFilming,
//                    SummaryDescription = m.SummaryDescription,
//                    VATRecoverable = m.Vatrecoverable,
//                    WCBudget = m.Wcbudget,
//                    WebsiteVisits = m.WebsiteVisits,
//                    WoodlandOfficerId = m.WoodlandOfficerId
//                }).ToList();

//                RegionLookup = _ec.Region.AsNoTracking().ToList().Select(r => new {r.Id, r.Description})
//                    .AsEnumerable()
//                    .ToLookup(rg => rg.Id, rg => rg.Description);


//                UserDtos = _ec.User.AsNoTracking().Select(us => new UserDto()
//                {
//                    ID = us.Id,
//                    LoginName = us.LoginName,
//                    DisplayName = us.DisplayName,
//                    Name = us.DisplayName

//                }).ToList();

//                UserRoleSmallDtos = _ec.UserRole.AsNoTracking().Select(u => new UserRoleSmallDto()
//                {
//                   UserId = u.UserId,
//                   Id = u.Id,
//                   RegionId = u.RegionId.GetValueOrDefault(),
//                   RoleId = u.RoleId

//                }).ToList();


//                DesignationLookup = _ec.DesignationType.AsNoTracking().Select(tenure => new ComboBoxValue()
//                {
//                    ID = tenure.Id,
//                    Name = tenure.Reference,
//                    Description = tenure.Description

//                }).ToList<ComboBoxValue>();

//            }
//        }

//        public SettngsDto GetSettings()
//        {
//            return LocalSettings.Instance.Settings;
//        }

//        public void SetSettings(SettngsDto settngsDto)
//        {
//            LocalSettings.Instance.Settings = settngsDto;
//        }
//    }
//}

