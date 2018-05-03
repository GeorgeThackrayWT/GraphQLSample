using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores.Content.PublicInformation;
using DataObjects.DTOS.PublicInformationDtos;
using EDCORE.ViewModel;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.PublicInformation
{
    public class PublicInformationEFStore: BaseEFStore, IPublicInformationStore
    {
        public PublicInformationEFStore(EstateContext ec,ICache iCache) : 
            base(ec,iCache)
        {
        }

        public List<PublicInformationSearchDto> GetPublicInformationDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            List<PublicInformationSearchDto> results = new List<PublicInformationSearchDto>();

            foreach (var a in Context.AcquisitionUnit.Include(i=>i.ManagementUnit))
            {
                results.Add(new PublicInformationSearchDto()
                {
                    ID = a.ManagementUnitId,
                    Name = a.Name,
                    ManagementUnitID = a.ManagementUnitId,
                    RegionId = a.ManagementUnit.RegionId.GetValueOrDefault(),
                    ApplicationId = a.ManagementUnit.ApplicationId,
                    Region = RegionName(a.ManagementUnit.RegionId),
                    Manager =UserName(a.ManagementUnit.WoodlandOfficerId),
                    CostCentre = a.ManagementUnitId,
                    Location = a.Location,
                    PhotoLibrary = a.HasPhotos,
                    GridReference = a.GridReference,
                    PostCode = a.PostCode,
                    DirectionDescription = a.PublicAccessDescription,
                    DeputyID = a.ManagementUnit.DeputyId.GetValueOrDefault(),
                    WoodlandOfficerID = a.WoodlandOfficerId,
                    AcquisitionOfficerID = a.AcquisitionOfficerId.GetValueOrDefault(),
                    
                });
            }

            return results.Where(a => a.ValidManagementUnit(userRole,userId, application, regionId)).OrderBy(o => o.Name).ToList();
        }

        public PublicInformationDto GetPublicInformationDto(int managementID)
        {

            var countyList = Context.County.ToList();
            var au =
                       Context.AcquisitionUnit.Where(a => a.ManagementUnitId == managementID)
                           .OrderBy(a => a.Id)
                           .FirstOrDefault();

            var mu = _cache.ManagementUnitDtos.FirstOrDefault(m => m.Id == managementID);

            var mp = Context.ManagementPlan.FirstOrDefault(m => m.Id == mu.ManagementPlanId);


            var county = countyList.FirstOrDefault(t => t.Id == au.CountyId);

            var pit = Context.PublicInfo.FirstOrDefault(f => f.ManagementUnitId == managementID);



            PublicInformationExtendedInfoDto pi = new PublicInformationExtendedInfoDto();

            if (pit != null)
            {
                pi = new PublicInformationExtendedInfoDto()
                {
                    AccessWalks = pit.AccessWalks,
                    ExtendedDescription = pit.ExtendedDescription,
                    Folklore = pit.Folklore,
                    GettingThere = pit.GettingThere,
                    History = pit.History,
                    NearestAmenities = pit.NearestAmenities,
                    OriginOfName = pit.OriginOfName,
                    Setting = pit.Setting,
                    SummaryDescription = au.SummaryDescription,
                    TreesAndPlants = pit.TreesAndPlants,
                    Wildlife = pit.Wildlife
                };
            }

            PublicInformationDto publicInformationDto = new PublicInformationDto
            {
                ATHRegister = false,
                AcquisitionUnitID = au.Id,
                AntiSocialIssues = mu.AntisocialIssues,
                AntiSocialIssuesPopulated = !string.IsNullOrEmpty(mu.AntisocialIssues),
                Area = au.AreaInHectares,
                ConsultationDeadline = mp.ReviewDeadline,
                DirectoryInfo = DirectoryInfo.DirectoryInfoFactory(au.DirectoryInformation),
                GridRef = au.GridReference,
                Landranger = au.Landranger,
                Explorer = au.Explorer,
                LocalName = mu.LocalName,
                LocalNameReason = mu.LocalNameDesc,
                Location = au.Location,
                County = county != null ? county.Description : "",
                PhotoLibrary = au.HasPhotos,
                NonStandardKey = mu.NonStandardKey,
                OperationsPosters = false, //unknown field,
                OtherSiteMaterial = false,//unknown field,
                Combination = "",//unknown field,
                Postcode = mu.PostCode,
                PartOf = "",// unknown field
                PublicEvents = false, //unknown fields
                SpecialSiteFeatures = mu.SpecialSiteFeatures,
                SpecialSiteFeaturesPopulated = !string.IsNullOrEmpty(mu.SpecialSiteFeatures),
                SuitableForFilming = mu.SuitableForFilming,
                SuitableForFilmingPopulated = !string.IsNullOrEmpty(mu.SuitableForFilming),
                UnderReview = mp.UnderReview,
                WebsiteCount = mu.WebsiteVisits,
                WoodMicrosite = mu.MicrositeURL,
                AccessWalks = pi.AccessWalks,
                ExtendedDescription = pi.ExtendedDescription,
                Folklore = pi.Folklore,
                GettingThere = pi.GettingThere,
                History = pi.History,
                NearestAmenities = pi.NearestAmenities,
                OriginOfName = pi.OriginOfName,
                Setting = pi.Setting,
                SummaryDescription = au.SummaryDescription,
                TreesAndPlants = pi.TreesAndPlants,
                Wildlife = pi.Wildlife
            };

            return publicInformationDto;
        }

        public string GetDirections(int managementID)
        {
            var au =
                Context.AcquisitionUnit.Where(a => a.ManagementUnitId == managementID)
                    .OrderBy(a => a.Id)
                    .FirstOrDefault();

            return au != null ? au.PublicAccessDescription : "";
        }

        public void UpdatePublicInformation(PublicInformationDto publicInformationDto, int managementId)
        {
            var au =
                Context.AcquisitionUnit.Where(a => a.ManagementUnitId == managementId)
                    .OrderBy(a => a.Id)
                    .FirstOrDefault();

            var mu = Context.ManagementUnit.FirstOrDefault(m => m.Id == managementId);

            var mp = Context.ManagementPlan.FirstOrDefault(m => m.Id == mu.ManagementPlanId);


          
            var pit = Context.PublicInfo.FirstOrDefault(f => f.ManagementUnitId == managementId);

            if (pit != null)
            {             
                pit.AccessWalks = publicInformationDto.AccessWalks;
                pit.ExtendedDescription = publicInformationDto.ExtendedDescription;
                pit.Folklore = publicInformationDto.Folklore;
                pit.GettingThere = publicInformationDto.GettingThere;
                pit.History = publicInformationDto.History;
                pit.NearestAmenities = publicInformationDto.NearestAmenities;
                pit.OriginOfName = publicInformationDto.OriginOfName;
                pit.Setting = publicInformationDto.Setting;
                au.SummaryDescription = publicInformationDto.SummaryDescription;
                pit.TreesAndPlants = publicInformationDto.TreesAndPlants;
                pit.Wildlife = publicInformationDto.Wildlife;

            }


            mu.AntisocialIssues = publicInformationDto.AntiSocialIssues;
            mu.LocalName = publicInformationDto.LocalName;     
            mu.LocalNameDesc = publicInformationDto.LocalNameReason;   
            mu.NonStandardKey = publicInformationDto.NonStandardKey;   
            mu.PostCode = publicInformationDto.Postcode;     
            mu.SpecialSiteFeatures = publicInformationDto.SpecialSiteFeatures;       
            mu.SuitableForFilming = publicInformationDto.SuitableForFilming;
            mu.WebsiteVisits = publicInformationDto.WebsiteCount;        
            mu.MicrositeUrl = publicInformationDto.WoodMicrosite;
       


            au.AreaInHectares = publicInformationDto.Area;

         
            au.DirectoryInformation = publicInformationDto.DirectoryInfo.ToBitMap();

       
            au.GridReference = publicInformationDto.GridRef;
          
            au.Landranger = publicInformationDto.Landranger;
      
            au.Explorer = publicInformationDto.Explorer;
       
            au.Location = publicInformationDto.Location;
      
            au.HasPhotos = publicInformationDto.PhotoLibrary;
            
            mp.UnderReview = publicInformationDto.UnderReview;

            mp.ReviewDeadline = publicInformationDto.ConsultationDeadline;


            Context.SaveChanges();
        }
    }
}
