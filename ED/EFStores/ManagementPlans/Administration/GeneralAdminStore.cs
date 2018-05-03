using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Stores;
using DataObjects.DTOS.AdministrationArea;
using EDC_Estate.Models.DB;
using MvvmHelpers;
using Utils;

namespace EFStores
{
    public class GeneralAdminStore : BaseEFStore, IGeneralAdminStore
    {

        public GeneralAdminStore(EstateContext ec, ICache iCache) : 
            base(ec, iCache)
        {
        }

        public List<AdminDocumentsDTO> GetAdminDocumentsDto(int configurationID)
        {
            var result = new AdminDocumentsDTO();

            return new List<AdminDocumentsDTO>(){result};
        }

 
        public void UpdateAdminDocumentsDTO(List<AdminDocumentsDTO> records, int recordId)
        {
            throw new System.NotImplementedException();
        }

   
        public AdminExpenditureProductsDto GetAdminExpenditureProductsDto(int configurationID)
        {
            var result = new AdminExpenditureProductsDto();

            return result;
        }

        public AdminFundedProjectSitesDto GetAdminFundedProjectSitesDto(int configurationID)
        {
            var result = new AdminFundedProjectSitesDto();

            return result;
        }

        public AdminGeneralDetailsDto GetAdminGeneralDetailsDto(int configurationID)
        {

            string sqlString = @"SELECT ID ,CurrentYear ,PurchaseOrderMajorNumber ,SalesOrderMajorNumber
                                  ,FirstExpAccountCode ,OrdersDropDirectory ,PurchaseFilename
                                  ,SalesFilename ,BudgetLock ,FutureBudgetLock
                                  ,ChalaraWorkOrderCode ,VATGuideURL
                                  ,DisablePO ,DisableSO ,DisablePOMessage
                                  ,DisableSOMessage ,ReportServer ,ReportPath
                                  ,ReportDropDirectory ,ReportTimeout
                                  ,TasksCutOffDate ,SafetyTasksCutOffDate ,TreePlantingTasksCutOffDate
                                  ,PEResNo ,NEDResNo ,AWRResNo ,LastAppliedAt
                                  ,Deleted ,LMDT ,LMUID ,CRDT ,CRUID ,DLDT  ,DLUID FROM Configuration";

            var data = Context.Configuration;

            var result = new AdminGeneralDetailsDto();

            if (data.Any())
            {
                result.ConfigID = data.First().Id;
                result.CurrentYear = data.First().CurrentYear;
                result.IsBudgetLocked = data.First().BudgetLock;
                result.IsBudgetLockedForFutureYears = data.First().FutureBudgetLock;
                result.DoNotShowTasksBefore = data.First().TasksCutOffDate;
                result.DoNotShowSafetyTasksBefore = data.First().SafetyTasksCutOffDate;
                result.DoNotShowTreePlantingTasksBefore = data.First().TreePlantingTasksCutOffDate;

            }

            return result;
        }

        public AdminIncomeProductsDTO GetAdminIncomeProductsDTO(int conigurationID)
        {
            var result = new AdminIncomeProductsDTO();

            return result;
        }

   

        public AdminLookupEditorDTO GetAdminLookupEditorDTO(int configurationID)
        {
            var result = new AdminLookupEditorDTO();

            return result;
        }

        public AdminReportsDTO GetAdminReportsDTO(int configurationID)
        {
            var data = Context.Configuration;

            var result = new AdminReportsDTO();

            if (data.Any())
            {
                result.ID = data.First().Id;
                result.ReportServer = data.First().ReportServer;
                result.ReportsDropPath = data.First().ReportDropDirectory;
                result.ReportsPath = data.First().ReportPath;
                result.Timeout = data.First().ReportTimeout;
            }

            return result;
        }

        public AdminUserDto GetAdminUserDto(int configurationID)
        {
            var result = new AdminUserDto();

            return result;
        }

        public AdminUserGroupDto GetAdminUserGroupDto(int configurationID)
        {
            var result = new AdminUserGroupDto();

            return result;
        }

        public AdminVATCodeCollection GetAdminVATCodes(int configurationID)
        {
            var result = new AdminVATCodeCollection { AdminVatCodesList = new ObservableRangeCollection<AdminVATCodes>() };

            //var taxCodes = _sqLiteSyncConnection.Query<TaxCode>(@"SELECT ID ,Section ,VATCode ,TaxRate ,VATRate ,Description ,IsDefaultValue FROM TaxCode").ToList();


            var sectionLookups = GetSectionLookups();

            foreach (var tc in Context.TaxCode)
            {
                result.AdminVatCodesList.Add(new AdminVATCodes()
                {
                    ID = tc.Id,
                    Description = tc.Description,
                    Section = sectionLookups.First(t => t.SectionID == tc.Section),
                    VATCode = tc.Vatcode,
                    VATImpact = tc.TaxRate,
                    VATIsDefault = tc.IsDefaultValue
                });
            }



            return result;
        }

        public AdminVATRateLocks GetAdminVATRateLocks()
        {
            var result = new AdminVATRateLocks();

            return result;
        }

        public AdminWorkProgrammeDTO GetAdminWorkProgrammeDTO()
        {
            string sqlString = @"SELECT ID, AWRResNo, PEResNo, NEDResNo, ChalaraWorkOrderCode,DisablePO,DisableSO,DisablePOMessage,DisableSOMessage,
                                FirstExpAccountCode,PurchaseOrderMajorNumber,SalesOrderMajorNumber,OrdersDropDirectory FROM Configuration";

            //   var data = _sqLiteSyncConnection.Query<Configuration>(sqlString).ToList();
            var data = Context.Configuration;

            var result = new AdminWorkProgrammeDTO();


         
            if (data.Any())
            {
                result.ID = data.First().Id;
                result.AWRRESNO = data.First().AwrresNo;
                result.PERESNO = data.First().PeresNo;
                result.NEDRESNO = data.First().NedresNo;
                result.ChalaraWorkOrderCode = data.First().ChalaraWorkOrderCode;
                result.DisablePO = data.First().DisablePo;
                result.DisablePOMessage = data.First().DisablePomessage;
                result.DisableSO = data.First().DisableSo;
                result.DisableSOMessage = data.First().DisableSomessage;
                result.FirstExpenditureAccountCode = data.First().FirstExpAccountCode;
                result.LastPurchaseOrderNo = data.First().PurchaseOrderMajorNumber;
                result.LastSalesOrderNo = data.First().SalesOrderMajorNumber;
                result.OrdersDropPath = data.First().OrdersDropDirectory;

                result.VATGuideURL = data.First().VatguideUrl;

            }


            return result;
        }

        public AdminWTFLSitesDTO GetAdminWTFLSitesDTO()
        {
            var result = new AdminWTFLSitesDTO();

            return result;
        }


        public List<SectionDescriptionDto> GetSectionLookups()
        {
            var result = new List<SectionDescriptionDto>
            {
                new SectionDescriptionDto()
                {
                    SectionID = "SO",
                    SectionDescription = "Sales Orders"
                },
                new SectionDescriptionDto()
                {
                    SectionID = "PO",
                    SectionDescription = "Purchase Orders"
                }
            };

            return result;
        }


    }
}
