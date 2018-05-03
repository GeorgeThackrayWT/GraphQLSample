using System.Collections.Generic;
using System.Linq;
using DataObjects;
using DataObjects.DTOS.lookups;

namespace Abstractions
{
    public interface ILookupStore : IBaseStore
    {
        List<ComboBoxValue> GetDesignationForCache();

        ILookup<int, string> GetRegionsForCache();

        List<PurchaseOrderDateOptionsDTO> GetPurchaseOrderDateOptionsDtos();

        List<SalesOrderDateOptionsDTO> GetSalesOrderDateOptionsDtos();

        List<SalesOrderDateOptionsDTO> GetHarvestingOptions();

        List<ComboBoxValue> GetAdminAreas();

        List<ComboBoxValue> GetClumpedWith();

        List<ComboBoxValue> GetManagementUnits();

        List<ComboBoxValue> GetAuditors();

        List<ComboBoxValue> GetRegions();

        List<ComboBoxValue> GetSitemanagers();

        List<ComboBoxValue> GetAuditGradeLookups();

        List<ComboBoxValue> GetSchemes();

        List<ComboBoxValue> GetGrantBodies();

        List<ComboBoxValue> GetFeatures();

        List<ComboBoxValue> GetIntDesignationTypesDtos();

        List<ComboBoxValue> GetExtDesignationTypeDtos();

        List<ComboBoxValue> GetDesignatorDtos();

        List<ComboBoxValue> GetInterestDisposed();

        List<ComboBoxValue> GetUserDtosByGroup(int roleGroupId, int regionId);

        List<ComboBoxValue> GetUserDtos();

        List<ComboBoxValue> GetFollowOnActionTypeDtos();

        List<ComboBoxValue> GetSeverityProbabilityOfHarmDtos();

        List<ComboBoxValue> GetApplicationDtos();

        List<ComboBoxValue> GetManagedByDtos();

        List<ComboBoxValue> GetCountyDtos();

        List<ComboBoxValue> GetAcquisitionTypes();

        List<ComboBoxValue> GetTenures();

        List<ComboBoxValue> GetNonFSCTypes();

        List<ComboBoxValue> GetContactStatuses();
        List<ComboBoxValue> GetFundingTypes();

        List<ComboBoxValue> GetFundingStatuses();

        List<ComboBoxValue> GetHighwayActTypes();
        List<ComboBoxValue> GetRightsType();
        List<ComboBoxValue> GetThirdPartyServiceTypes();
        List<ComboBoxValue> GetAgreementTypes();
        List<ComboBoxValue> GetThirdPartyTypeDtos();
        List<ComboBoxValue> GetStructureTypeDtos();
        List<ComboBoxValue> GetStructureConditionDtos();


        List<ComboBoxValue> GetAgTenancyAgreementDtos();
        List<ComboBoxValue> GetAgTenancyCommentsOnTermDtos();
        List<ComboBoxValue> GetAgTenancyFishingTypeDtos();
        List<ComboBoxValue> GetAgTenancyInterestLetDtos();
        List<ComboBoxValue> GetAgTenancyRentReviewDtos();
        List<ComboBoxValue> GetAgTenancyPeriodDtos();
        List<ComboBoxValue> GetAgTenancyNoticeOfTerminationDtos();

        List<ComboBoxValue> GetAgTenancyNoticePeriodOfTerminationDtos();


        List<ComboBoxValue> GetAgTenancySizeInDtos();
        List<ComboBoxValue> GetAgTenancyTypeDtos();

        List<ComboBoxValue> GetKeyFeatureDtos();

        List<ComboBoxValue> GetAIMDtos();




        List<ComboBoxValue> GetMainSpeciesDTOs();
 
        List<ComboBoxValue> GetManagementRegimeDTOs();

        List<ComboBoxValue> GetYears();

        List<ComboBoxValue> GetWorkProgrammeOptions();

        List<ComboBoxValue> GetHarvestingYearOptions();

        List<ComboBoxValue> GetManagementConstraints(int filter);

        List<ComboBoxValue> GetConservationFeatures(int filter);

        List<ComboBoxValue> GetDesignations(int filter);


        List<ComboBoxValue> GetIncomeProducts();

        List<ComboBoxValue> GetExpenditureProducts();

        List<ComboBoxValue> GetVATRates();

        List<ComboBoxValue> GetTaxRates();

        List<ComboBoxValue> GetWorkOrders();

        List<ComboBoxValue> GetGrantReferenceLookupDTO(int filter);

      //  List<ComboBoxValue> GetObservationTypeDTOs(int filter);

        List<ComboBoxValue> GetCompartmentLookupDTOs(int filter);

      //  List<ComboBoxValue> GetHarvestingObservationTypeDTOs(int filter);

        List<ComboBoxValue> GetTypeOfInformation(int filter);

        List<ComboBoxValue> GetHarvestingOptionsDTOs();

        List<ComboBoxValue> GetApplicationTypeDTOs();

        List<ComboBoxValue> GetApplicationMethodDTOs();

        List<ComboBoxValue> GetActiveIngredientDTOs();

        List<ComboBoxValue> GetTargetSpeciesDTOs();

        List<ComboBoxValue> GetUsageReasonsDTOs();

        List<ComboBoxValue> GetSiteTypesDTOs();

        List<ComboBoxValue> GetUnitsDTOs();

        List<ComboBoxValue> GetCAStratums();


        List<ComboBoxValue> GetInterestLet();

        //List<ComboBoxValue> GetCAKeyFeatures(int filter);

    }
}