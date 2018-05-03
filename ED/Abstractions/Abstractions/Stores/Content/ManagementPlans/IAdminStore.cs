using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Stores
{
    public interface IGeneralAdminStore
    {        
        List<SectionDescriptionDto> GetSectionLookups();

        AdminGeneralDetailsDto GetAdminGeneralDetailsDto(int configurationID);

        List<AdminDocumentsDTO> GetAdminDocumentsDto(int configurationID);

        void UpdateAdminDocumentsDTO(List<AdminDocumentsDTO> records, int recordId);

        AdminExpenditureProductsDto GetAdminExpenditureProductsDto(int configurationID);

        AdminFundedProjectSitesDto GetAdminFundedProjectSitesDto(int configurationID);

        AdminIncomeProductsDTO GetAdminIncomeProductsDTO(int conigurationID);

        AdminLookupEditorDTO GetAdminLookupEditorDTO(int configurationID);

        AdminReportsDTO GetAdminReportsDTO(int configurationID);

        AdminUserDto GetAdminUserDto(int configurationID);

        AdminUserGroupDto GetAdminUserGroupDto(int configurationID);

        AdminVATCodeCollection GetAdminVATCodes(int configurationID);

        AdminVATRateLocks GetAdminVATRateLocks();

        AdminWorkProgrammeDTO GetAdminWorkProgrammeDTO();

        AdminWTFLSitesDTO GetAdminWTFLSitesDTO();

    }
}