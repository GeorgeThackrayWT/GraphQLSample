using System.Collections.Generic;
using DataObjects.DTOS;
using DataObjects.DTOS.property.subobjects;
using EDCORE.ViewModel;

namespace Abstractions
{
    public interface IPropertyStore : IBaseStore
    {
        bool ValidateCostCenter(string costCenter);

        SubAcquisitionUnit GetSubAcquisitionUnit(int acquisitionId);

        void UpdateSubAcquisitionUnit(int acquisitionId, SubAcquisitionUnit subAcquisitionUnit);

        List<AUID> GetAcquisitionIds(int managementUnitId);

        int SaveNewAcquisitionUnit(int managementUnitId, AUID auid);
   
        List<LicenseDto> GetLicenseDto(int acquisitionId, List<int> licenseTypes);

        void UpdateLicenses(int acquisitionId, List<LicenseDto> editSet);

        List<PropertyDto> GetPropertyList(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        AcquisitionUnitDto GetAcquisitionUnit(int acquisitionUnitId);

        //BoundariesAndPlansDto
        List<BoundariesAndPlanDto> GetBoundariesAndPlansDto(int acquisitionId);

        //ContactsDto
        List<ContactDto> GetContactsDto(int acquisitionId);

        //DrainageRatesDto
        List<DrainageRateDto> GetDrainageRatesDto(int acquisitionId);

        //FundingDtos
        List<FundingDto> GetFundingDtos(int acquisitionId);

        //PartDisposal
        List<PartDisposalDto> GetPartDisposal(int acquisitionId);

        //PublicRightsOfWayDto
        List<PublicRightOfWayDto> GetPublicRightsOfWayDto(int acquisitionId);

        //StructuresDto
        List<StructureDto> GetStructuresDto(int acquisitionId);

        //ThirdPartyRightDtos
        List<ThirdPartyRightDto> GetThirdPartyRightDtos(int acquisitionId);

        DirectoryInfoDto GetDirectoryInfo(int acquisitionId);

        void DeleteAcquisitionUnits(int acquisitionId);

        void UpdateGeneralDetails(int acquisitionId, PropertyGeneralDetailsDto propertyGeneralDetailsDto);

        void UpdateLegalTitle(int acquisitionId, PropertyLegalTitleDto propertyGeneralDetailsDto);

        void UpdateFarming(int acquisitionId, PropertyFarmingDto propertyGeneralDetailsDto);

        void UpdateCostCenter(int managementUnitId, string costCenter);

        void UpdateProperty(int acquisitionId, MainSectionDto propertyGeneralDetailsDto);

        void UpdateThirdPartyRights(int acquisitionId, List<ThirdPartyRightDto> editSet);

        void UpdateStructures(int acquisitionId, List<StructureDto> editSet);

        void UpdatePublicRightsOfWay(int acquisitionId, List<PublicRightOfWayDto> editSet);

        void UpdatePartDisposal(int acquisitionId, List<PartDisposalDto> editSet);

        void UpdateFundings(int acquisitionId, List<FundingDto> editSet);


        void UpdateDrainages(int acquisitionId, List<DrainageRateDto> editSet);

        void UpdateContacts(int acquisitionId, List<ContactDto> editSet);

        void UpdateBoundariesAndPlansDto(int acquisitionId, List<BoundariesAndPlanDto> editSet);

    }
}