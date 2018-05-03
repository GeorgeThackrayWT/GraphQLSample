//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using Abstractions;
//using Abstractions.Stores;
//using DataObjects;
//using DataObjects.DAOS;
//using DataObjects.DTOS;
//using DataObjects.DTOS.AdministrationArea;
//using DataObjects.DTOS.ManagementPlans.Administration.Editors;
//using MvvmHelpers;
//using Stores;
//using UIKit;
//using Utils;

//namespace SQLite
//{
//    public class AdminStore : BaseStore, IAdminStore
//    {
//        public AdminStore(IDBPlatformSettings platform, ISQLiteCache iCache)
//        {
//            _platform = platform;

//            _iCache = iCache;

//            _sqLiteAsyncConnection = GetConnection();

//            _sqLiteSyncConnection = GetSynchConnection();
//        }

//        public AdminDocumentsDTO GetAdminDocumentsDto(int configurationID)
//        {
//            var result = new AdminDocumentsDTO();

//            return result;
//        }

//        public AdminEditDTO GetAdminEditDTO(int managementUnitID)
//        {
//            var adminEditDTO = new AdminEditDTO();



//            var featureData = _sqLiteSyncConnection.Query<Feature>(@"SELECT ID, AimID FROM Feature WHERE Deleted =0 AND ManagementUnitID = " + managementUnitID).ToList();

//            var manu = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == managementUnitID);

//            var manplan = _iCache.ManagementPlans.FirstOrDefault(p => p.Id== manu.ManagementPlanId.GetValueOrDefault());

//          //  var clumpedWith = _iCache.ManagementUnits.FirstOrDefault(p => p.Id == manu.ClumpedManagementUnitId.GetValueOrDefault());

//            adminEditDTO.ManagementUnitID = manu.Id;
//            adminEditDTO.AccessCategory = manu.AccessCategory;
//            adminEditDTO.Aim1Creation = featureData.Exists(e => e.AimID == 1);
//            adminEditDTO.Aim2Biodiversity = featureData.Exists(e => e.AimID == 2);
//            adminEditDTO.Aim3PeopleEngagement = featureData.Exists(e => e.AimID == 3);
//            adminEditDTO.NewEstateCategory = manu.NewEstateCategory;
//            adminEditDTO.AccessCategory = manu.AccessCategory;
//            adminEditDTO.EstateCategory = manu.EstateCategory;
//            adminEditDTO.InterimCategory = manu.InterimCategory;
//            adminEditDTO.MainClumpedSite = manu.IsMainClumpedSite;
//            adminEditDTO.PartOfClumpedSite = false;
//            adminEditDTO.ClumpedWith = manu.ClumpedManagementUnitId.GetValueOrDefault();

//            if (manplan != null)
//            {
//                adminEditDTO.From = manplan.PeriodFrom;
//                adminEditDTO.To = manplan.PeriodTo;
//                adminEditDTO.ApprovedDate = manplan.DateApproved;
//                adminEditDTO.ApprovedBy = manplan.ApprovedByID.GetValueOrDefault();
//                adminEditDTO.UnderReview = manplan.UnderReview;
//                adminEditDTO.ReviewDeadline = manplan.ReviewDeadline;
//                adminEditDTO.UnderConsultation = manplan.UnderConsultation;
//                adminEditDTO.ConsultationDeadline = manplan.ConsultationEndDate;
//            }

//            adminEditDTO.SiteName = manu.Name;
//            adminEditDTO.ManagerID = manu.WoodlandOfficerId;
//            adminEditDTO.DeputyManagerID = manu.DeputyId.GetValueOrDefault();
//            adminEditDTO.Directions = manu.DirectionsToMainEntrance;


//            return adminEditDTO;
//        }

//        public AdminExpenditureProductsDto GetAdminExpenditureProductsDto(int configurationID)
//        {
//            var result = new AdminExpenditureProductsDto();

//            return result;
//        }

//        public AdminFundedProjectSitesDto GetAdminFundedProjectSitesDto(int configurationID)
//        {
//            var result = new AdminFundedProjectSitesDto();

//            return result;
//        }

//        public AdminGeneralDetailsDto GetAdminGeneralDetailsDto(int configurationID)
//        {
         

//            string sqlString = @"SELECT ID ,CurrentYear ,PurchaseOrderMajorNumber ,SalesOrderMajorNumber
//                                  ,FirstExpAccountCode ,OrdersDropDirectory ,PurchaseFilename
//                                  ,SalesFilename ,BudgetLock ,FutureBudgetLock
//                                  ,ChalaraWorkOrderCode ,VATGuideURL
//                                  ,DisablePO ,DisableSO ,DisablePOMessage
//                                  ,DisableSOMessage ,ReportServer ,ReportPath
//                                  ,ReportDropDirectory ,ReportTimeout
//                                  ,TasksCutOffDate ,SafetyTasksCutOffDate ,TreePlantingTasksCutOffDate
//                                  ,PEResNo ,NEDResNo ,AWRResNo ,LastAppliedAt
//                                  ,Deleted ,LMDT ,LMUID ,CRDT ,CRUID ,DLDT  ,DLUID FROM Configuration";

//            var data = _sqLiteSyncConnection.Query<Configuration>(sqlString).ToList();

//            var result = new AdminGeneralDetailsDto();

//            if (data.Count > 0)
//            {
//                result.ConfigID = data[0].ID;
//                result.CurrentYear = data[0].CurrentYear;
//                result.IsBudgetLocked = data[0].BudgetLock;
//                result.IsBudgetLockedForFutureYears = data[0].FutureBudgetLock;
//                result.DoNotShowTasksBefore = data[0].TasksCutOffDate;
//                result.DoNotShowSafetyTasksBefore = data[0].SafetyTasksCutOffDate;
//                result.DoNotShowTreePlantingTasksBefore = data[0].TreePlantingTasksCutOffDate;
              
//            }

//            return result;
//        }

//        public AdminIncomeProductsDTO GetAdminIncomeProductsDTO(int conigurationID)
//        {
//            var result = new AdminIncomeProductsDTO();

//            return result;
//        }

//        public List<AdminListDTO> GetAdminListDtos()
//        {
//            var returnList = new List<AdminListDTO>();

//            //  var data = _sqLiteSyncConnection.Table<ManagementUnit>().ToList();

//            Stopwatch stopwatch = Stopwatch.StartNew();

//            Debug.WriteLine("GetAdminListDtos started");



//            foreach (var v in _iCache.ManagementUnits)
//            {

//                var manu = _iCache.ManagementPlans.FirstOrDefault(p => p.Id == v.ManagementPlanId.GetValueOrDefault());

//                var areaTotal =
//                    _iCache.AcquisitionUnits.Where(a => a.ManagementUnitID == v.Id).Sum(s => s.AreaInHectares);




//                if (manu != null)
//                {
//                    returnList.Add(new AdminListDTO()
//                    {
//                        CostCentre = v.Id,
//                        Region = _iCache.RegionLookup[v.RegionId.GetValueOrDefault()],
//                        Manager = _iCache.UserLookup[v.WoodlandOfficerId],
//                        ManagementUnitID = v.Id,
//                        Location = v.Name,//todo remove
//                        Name = v.Name,
//                        AccessCat = v.AccessCategory,
//                        ApprovedBy = _iCache.UserLookup[manu.ApprovedByID.GetValueOrDefault()],

//                        ApprovedDate = manu.DateApproved.Validate(),

//                        AreaHa = areaTotal,
//                        ConsultationDeadline = manu.ConsultationEndDate.Validate(),
//                        EstateCat = v.EstateCategory,
//                        NewEstateCat = v.NewEstateCategory,
//                        PlanFrom = manu.PeriodFrom.GetValueOrDefault().Year,
//                        PlanTo = manu.PeriodTo.GetValueOrDefault().Year,
//                        UnderConsultation = manu.UnderConsultation,
//                        RiskID = v.RiskAssessmentId
//                    });
//                }
//            }

//            stopwatch.Stop();

//            Debug.WriteLine("GetAdminListDtos ended in: " + stopwatch.ElapsedMilliseconds);

//            return returnList.OrderBy(o => o.Location).ToList();
//        }

//        public AdminLookupEditorDTO GetAdminLookupEditorDTO(int configurationID)
//        {
//            var result = new AdminLookupEditorDTO();

//            return result;
//        }

//        public AdminReportsDTO GetAdminReportsDTO(int configurationID)
//        {
//            string sqlString = @"SELECT ID,ReportServer,ReportPath,ReportDropDirectory,ReportTimeout FROM Configuration";

//            var data = _sqLiteSyncConnection.Query<Configuration>(sqlString).ToList();

//            var result = new AdminReportsDTO();

//            if (data.Count > 0)
//            {
//                result.ID = data[0].ID;
//                result.ReportServer = data[0].ReportServer;
//                result.ReportsDropPath = data[0].ReportDropDirectory;
//                result.ReportsPath = data[0].ReportPath;
//                result.Timeout = data[0].ReportTimeout;
//            }

//            return result;
//        }

//        public AdminUserDto GetAdminUserDto(int configurationID)
//        {
//            var result = new AdminUserDto();

//            return result;
//        }

//        public AdminUserGroupDto GetAdminUserGroupDto(int configurationID)
//        {
//            var result = new AdminUserGroupDto();

//            return result;
//        }

//        public List<SectionDescriptionDto> GetSectionLookups()
//        {
//            var result = new List<SectionDescriptionDto>
//            {
//                new SectionDescriptionDto()
//                {
//                    SectionID = "SO",
//                    SectionDescription = "Sales Orders"
//                },
//                new SectionDescriptionDto()
//                {
//                    SectionID = "PO",
//                    SectionDescription = "Purchase Orders"
//                }
//            };

//            return result;
//        }

//        public AdminVATCodeCollection GetAdminVATCodes(int configurationID)
//        {
//            var result = new AdminVATCodeCollection {AdminVatCodesList = new ObservableRangeCollection<AdminVATCodes>()};

//            var taxCodes = _sqLiteSyncConnection.Query<TaxCode>(@"SELECT ID ,Section ,VATCode ,TaxRate ,VATRate ,Description ,IsDefaultValue FROM TaxCode").ToList();


//            var sectionLookups = GetSectionLookups();

//            foreach (var tc in taxCodes)
//            {
//                result.AdminVatCodesList.Add(new AdminVATCodes()
//                {
//                    ID = tc.ID,
//                    Description = tc.Description,
//                    Section = sectionLookups.First(t=>t.SectionID == tc.Section) ,
//                    VATCode = tc.VATCode,
//                    VATImpact = tc.TaxRate,
//                    VATIsDefault = tc.IsDefaultValue
//                });
//            }



//            return result;
//        }

//        public AdminVATRateLocks GetAdminVATRateLocks()
//        {
//            var result = new AdminVATRateLocks();

//            return result;
//        }

//        public AdminWorkProgrammeDTO GetAdminWorkProgrammeDTO()
//        {
//            string sqlString = @"SELECT ID, AWRResNo, PEResNo, NEDResNo, ChalaraWorkOrderCode,DisablePO,DisableSO,DisablePOMessage,DisableSOMessage,
//                                FirstExpAccountCode,PurchaseOrderMajorNumber,SalesOrderMajorNumber,OrdersDropDirectory FROM Configuration";

//            var data = _sqLiteSyncConnection.Query<Configuration>(sqlString).ToList();

//            var result = new AdminWorkProgrammeDTO();

//            if (data.Count > 0)
//            {
//                result.ID = data[0].ID;
//                result.AWRRESNO = data[0].AWRResNo;
//                result.PERESNO = data[0].PEResNo;
//                result.NEDRESNO = data[0].NEDResNo;
//                result.ChalaraWorkOrderCode = data[0].ChalaraWorkOrderCode;
//                result.DisablePO = data[0].DisablePO;
//                result.DisablePOMessage = data[0].DisablePOMessage;
//                result.DisableSO = data[0].DisableSO;
//                result.DisableSOMessage = data[0].DisableSOMessage;
//                result.FirstExpenditureAccountCode = data[0].FirstExpAccountCode;
//                result.LastPurchaseOrderNo = data[0].PurchaseOrderMajorNumber;
//                result.LastSalesOrderNo = data[0].SalesOrderMajorNumber;
//                result.OrdersDropPath = data[0].OrdersDropDirectory;
                
//                result.VATGuideURL = data[0].VATGuideURL;
                
//            }


//            return result;
//        }

//        public AdminWTFLSitesDTO GetAdminWTFLSitesDTO()
//        {
//            var result = new AdminWTFLSitesDTO();

//            return result;
//        }

//        public PesticideAdminContainerDto GetPesticideAdminDto(int managementUnitID)
//        {

//            var pesticideAdminDTO = new PesticideAdminContainerDto();

//            pesticideAdminDTO.PesticideAdminsFlip = new ObservableRangeCollection<PesticideAdminDto>();

//            var featureData = _sqLiteSyncConnection.Query<PesticideAdminDto>(@"SELECT ID AS PesticideID,ContractorName,ContractorCode
//                                                          ,ManagementUnitID ,OldPONumber ,SurplusDisposed
//                                                          ,Comments ,SiteClassificationID ,ReasonForUseID
//                                                          ,TargetSpeciesID,ProductID,ProductDescr,NetAreaTreatedHa ,ConcentrateQuantity,ApplicationRate,ApplicationUnitID
//                                                          ,LocationInSite,ActiveIngredientID,OtherIngredient ,ApplicationTypeID ,ApplicationMethodID,WeatherConditions
//                                                      FROM Pesticide WHERE ManagementUnitID = " + managementUnitID).ToList();


//            var testData = new PesticideAdminDto()
//            {
//                Comments = "comments",
//                ActiveIngredient = 1,
//                ApplicationMethodId = 1,
//                ApplicationRate = 1.1,
//                ApplicationTypeId = 1,
//                ConcentrationQuantityUsed = 2.2,
//                ContractorName = "contractor name",
//                HowDisposed = "how disposed",
//                LocationInSite = "locat in site",
//                NetAreaTreatedHa = 3.3,
//                PesticideId = 1,
//                Product = "prod string",
//                PurchaseOrderNo = "pur order no",
//                ReasonForUse = 1,
//                TargetSpecies = 1,
//                TypeOfSite = 1,
//                UnitId = 1,
//                WeatherConditions = "weather cond",
//                WoodNumber = "wood no"
//            };

//            featureData.Add(testData);

//            pesticideAdminDTO.PesticideAdminsFlip.AddRange(featureData);

//            return pesticideAdminDTO;
//        }
//    }
//}