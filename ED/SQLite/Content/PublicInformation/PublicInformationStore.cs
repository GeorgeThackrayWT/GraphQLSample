using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Stores.Content.PublicInformation;
using DataObjects.DAOS;
using DataObjects.DTOS.PublicInformationDtos;
using EDCORE.ViewModel;
using Stores;

namespace SQLite.Content.PublicInformation
{
    public class PublicInformationStore : BaseStore,  IPublicInformationStore
    {
        private readonly ISQLiteCache _iCache;
        private readonly ILookupStore _lookupStore;

        public PublicInformationStore(IDBPlatformSettings platform, ISQLiteCache iCache, ILookupStore iLookupStore)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteAsyncConnection = GetConnection();

            _lookupStore = iLookupStore;

            _sqLiteSyncConnection = GetSynchConnection();
        }

        public string GetDirections(int managementID)
        {
            var au =
                _iCache.AcquisitionUnits.Where(a => a.ManagementUnitID == managementID)
                    .OrderBy(a => a.ID)
                    .FirstOrDefault();

            if (au != null)
                return au.PublicAccessDescription;
            else
                return "";
        }

        public PublicInformationDto GetPublicInformationDto(int managementID)
        {
            

            var countyList  = _sqLiteSyncConnection.Table<County>();
            var au =
                       _iCache.AcquisitionUnits.Where(a => a.ManagementUnitID == managementID)
                           .OrderBy(a => a.ID)
                           .FirstOrDefault();

            var mu = _iCache.ManagementUnits.FirstOrDefault(m => m.Id == managementID);

            var mp = _iCache.ManagementPlans.FirstOrDefault(m => m.Id == mu.ManagementPlanId);


            var county = countyList.FirstOrDefault(t => t.ID == au.CountyID);

            var pit = _sqLiteSyncConnection.Table<PublicInfo>().FirstOrDefault(f=>f.ManagementUnitID == managementID);

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
                AcquisitionUnitID = au.ID,
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
                County = county!=null? county.Description : "",
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
      
            };
            
            return publicInformationDto;
        }

        public List<PublicInformationSearchDto> GetPublicInformationDtos()
        {
          
            List<PublicInformationSearchDto> results = new List<PublicInformationSearchDto>();

            foreach (var a in _iCache.AcquisitionUnits)
            {
                results.Add(new PublicInformationSearchDto()
                {
                    ID = a.ManagementUnitID,
                    Name = a.Name,
                    ManagementUnitID = a.ManagementUnitID,
                    Region = _iCache.RegionLookup[_iCache.ManagementUnits.First(f => f.Id == a.ManagementUnitID) .RegionId.GetValueOrDefault()],
                    Manager =  _iCache.UserLookup[a.WoodlandOfficerID],
                    CostCentre = a.ManagementUnitID,
                    Location = a.Location,
                    PhotoLibrary = a.HasPhotos,
                    GridReference = a.GridReference,
                    PostCode = a.PostCode,
                    DirectionDescription = a.PublicAccessDescription
                });
            }

            return results;
        }

        public List<PublicInformationSearchDto> GetPublicInformationDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublicInformation(PublicInformationDto publicInformationDto, int managementId)
        {
            throw new NotImplementedException();
        }
    }
}
