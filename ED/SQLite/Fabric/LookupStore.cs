using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS;
using DataObjects.DTOS.InternalAudits;
using DataObjects.DTOS.lookups;
using DataObjects.DTOS.SafetyObjects.Editors;
using DataObjects.DTOS.TreePlanting;
using EDCORE.ViewModel;
using Stores;

namespace SQLite
{

    //public class ComboBoxValue : IComboBoxValue
    //{
    //    public string Description { get; set; }

    //    public int ID { get; set; }

    //    public string Name { get; set; }
    //}

    public class LookupStore : BaseStore, ILookupStore
    {
        private List<ComboBoxValue> _results = new List<ComboBoxValue>();
        private readonly ISQLiteCache _iCache;

        public LookupStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _sqLiteSyncConnection = GetSynchConnection();

            _iCache = iCache;
        }

        private void preRun()
        {
            _results = new List<ComboBoxValue>();

            _results.Add(new ComboBoxValue()
            {
                ID = 0,
                Name = "Not Set"
            });
        }


        //special case
        public List<PurchaseOrderDateOptionsDTO> GetPurchaseOrderDateOptionsDtos()
        {
            //PurchaseOrderDateOptionsDTO
            preRun();

            var purchaseOrderOptions = new List<PurchaseOrderDateOptionsDTO>
            {
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 1,
                    Name = "2017",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.CurrentYear
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 2,
                    Name = "EMC 2017",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.EMCCurrentYear
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 3,
                    Name = "2018",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.NextYear
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 4,
                    Name = "EMC 2018",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.EMCNextYear
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 6,
                    Name = "All Years",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.AllYears
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 7,
                    Name = "EMC All Years",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.EMCAllYears
                },
                new PurchaseOrderDateOptionsDTO()
                {
                    ID = 8,
                    Name = "Non EMC",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.NonEMC
                }
            };

            

            return purchaseOrderOptions;
        }
        //special case
        public List<SalesOrderDateOptionsDTO> GetSalesOrderDateOptionsDtos()
        {
            var salesOrderDateOptionsDtos = new List<SalesOrderDateOptionsDTO>();

            salesOrderDateOptionsDtos.AddRange(new List<SalesOrderDateOptionsDTO>
            {
                new SalesOrderDateOptionsDTO()
                {
                    ID = 1,
                    Name = "2017",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.CurrentYear
                },
                new SalesOrderDateOptionsDTO()
                {
                    ID = 2,
                    Name = "2018",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.NextYear
                },
                new SalesOrderDateOptionsDTO()
                {
                    ID = 3,
                    Name = "All Years",
                    Description = "",
                    OrdersSelectionCriterion = OrdersSelectionCriterion.AllYears
                }

            });

            return salesOrderDateOptionsDtos;
        }

        public List<ComboBoxValue> GetManagedByDtos()
        {
            preRun();

            var temp = new List<ComboBoxValue>
            {
                new ComboBoxValue
                {
                    ID = 1,
                    Name = "Woodland Trust",
                    Description = ""
                },
                new ComboBoxValue
                {
                    ID = 2,
                    Name = "Third Party Management",
                    Description = ""
                }
            };

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetWorkProgrammeOptions()
        {
            preRun();

            _results.AddRange(new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 1,
                    Name = "2017",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 2,
                    Name = "2018",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 3,
                    Name = "All Years",
                    Description = ""
                }
            });

            return _results;
        }

        public List<ComboBoxValue> GetYears()
        {

            int idx = 1900;
            preRun();

            while (idx < 2050)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = idx,
                    Name = idx.ToString(),
                    Description = ""
                });

                idx++;
            }

            return _results;
        }

        public List<ComboBoxValue> GetVATRates()
        {
            preRun();

            _results.AddRange(new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 1,
                    Name = "Outside Scope Related Sales",
                    Description = ""
                }
            });

            return _results;
        }

        public List<ComboBoxValue> GetCAStratums()
        {
            preRun();

            _results.AddRange(new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 1,
                    Name = "D",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 2,
                    Name = "A",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 3,
                    Name = "F",
                    Description = ""
                },new ComboBoxValue()
                {
                    ID = 2,
                    Name = "O",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 3,
                    Name = "R",
                    Description = ""
                }

            });

            return _results;
        }

        public List<ComboBoxValue> GetUnitsDTOs()
        {
            preRun();

            _results.AddRange(new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 1,
                    Name = "kg",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 2,
                    Name = "litres",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 3,
                    Name = "pellets",
                    Description = ""
                }
            });

            return _results;
        }

        public List<ComboBoxValue> GetHarvestingOptionsDTOs()
        {
            preRun();

            _results.AddRange(new List<ComboBoxValue>
            {
                new ComboBoxValue()
                {
                    ID = 0,
                    Name = "Historic",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 1,
                    Name = "2017",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 2,
                    Name = "Next 5 Years",
                    Description = ""
                },
                new ComboBoxValue()
                {
                    ID = 3,
                    Name = "All Years",
                    Description = ""
                }
            });

            return _results;
        }







        public List<ComboBoxValue> GetTenures()
        {
            preRun();

            var tenureTask = _sqLiteSyncConnection.Table<Tenure>();

            var temp = tenureTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetNonFSCTypes()
        {
            preRun();

            var tenureTask = _sqLiteSyncConnection.Table<NonFSCType>();

            var temp = tenureTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetAcquisitionTypes()
        {
            preRun();

            var acquisitionTask = _sqLiteSyncConnection.Table<AcquisitionType>();

            var temp = acquisitionTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetCountyDtos()
        {
            preRun();

            var countyTask = _sqLiteSyncConnection.Table<County>();

            var temp = countyTask.Select(county => new ComboBoxValue()
            {
                ID = county.ID,
                Name = county.Code,
                Description = county.Description
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }
     
        public List<ComboBoxValue> GetApplicationDtos()
        {
            preRun();

            var designationTypes = _sqLiteSyncConnection.Table<Application>().ToList();

            var temp = designationTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Name,
                Description = tenure.Description

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetUserDtos()
        {
            preRun();

            var temp = _iCache.Users.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.DisplayName,
                Description = tenure.Email

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetExtDesignationTypeDtos()
        {
            preRun();

            var designationTypes = _sqLiteSyncConnection.Table<DesignationType>().ToList();

            var temp = designationTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Reference,
                Description = tenure.Description

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetIntDesignationTypesDtos()
        {
            preRun();

            var internalDesignationTypes = _sqLiteSyncConnection.Table<InternalDesignationType>().ToList();

            var temp = internalDesignationTypes.Select(i => new ComboBoxValue()
            {
                ID = i.ID,
                Name = i.Reference,
                Description = i.Description

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetDesignatorDtos()
        {
            preRun();

            var designators = _sqLiteSyncConnection.Table<Designator>().ToList();

            var temp = designators.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetInterestDisposed()
        {
            preRun();

            var contactStatuses = _sqLiteSyncConnection.Table<DisposedInterest>().ToList();

            var temp = contactStatuses.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetContactStatuses()
        {

            preRun();


            var contactStatuses = _sqLiteSyncConnection.Table<ContactStatus>().ToList();

            var temp = contactStatuses.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetFundingTypes()
        {
            preRun();

            var fundingTypes = _sqLiteSyncConnection.Table<FundingType>().ToList();

            var temp = fundingTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList(); ;

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetFundingStatuses()
        {
            preRun();

            var fundingTypes = _sqLiteSyncConnection.Table<FundingStatus>().ToList();

            var fundingTypesDtos = fundingTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(fundingTypesDtos);

            return _results;
        }

        //highwayacttype
        public List<ComboBoxValue> GetHighwayActTypes()
        {
            preRun();

            var highwayAuthorities = _sqLiteSyncConnection.Table<HighwayAuthority>().ToList();

            var highwayAuthoritiesDtos = highwayAuthorities.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(highwayAuthoritiesDtos);

            return _results;
        }

        //rightstype
        public List<ComboBoxValue> GetRightsType()
        {

            preRun();

            var highwayAuthorities = _sqLiteSyncConnection.Table<RightsType>().ToList();

            var highwayAuthoritiesDtos = highwayAuthorities.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(highwayAuthoritiesDtos);

            return _results;
        }

        //servicetype
        public List<ComboBoxValue> GetThirdPartyServiceTypes()
        {
            preRun();

            var thirdPartyServices = _sqLiteSyncConnection.Table<ThirdPartyService>().ToList();

            var thirdPartyServiceDtos = thirdPartyServices.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyServiceDtos);

            return _results;
        }

        //ThirdPartyAgreementTypeDto
        public List<ComboBoxValue> GetAgreementTypes()
        {
            preRun();

            var thirdPartyAgreements = _sqLiteSyncConnection.Table<ThirdPartyAgreement>().ToList();

            var thirdPartyAgreementsdtos = thirdPartyAgreements.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyAgreementsdtos);

            return _results;
        }

        public List<ComboBoxValue> GetThirdPartyTypeDtos()
        {
            preRun();

            var thirdPartyTypes = _sqLiteSyncConnection.Table<ThirdPartyType>().ToList();

            var thirdPartyTypesdtos = thirdPartyTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyTypesdtos);

            return _results;
        }

        //structuretype
        public List<ComboBoxValue> GetStructureTypeDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<StructureType>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetStructureConditionDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<StructureCondition>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyAgreementDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<LicenceAgreement>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyCommentsOnTermDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<CommentsOnTerm>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyFishingTypeDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<FishingType>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyInterestLetDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<FishingType>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyRentReviewDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<RentReview>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyPeriodDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<LicencePeriod>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyNoticeOfTerminationDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<NoticeOfTermination>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancySizeInDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<SizeIn>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyTypeDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<LicenceType>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetKeyFeatureDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<FeatureType>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAIMDtos()
        {
            preRun();

            var structureTypes = _sqLiteSyncConnection.Table<Aim>().ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.ID,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetGrantBodies()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<GrantBody>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetSchemes()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<AwardingScheme>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }



        public List<ComboBoxValue> GetMainSpeciesDTOs()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<Species>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetManagementRegimeDTOs()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<ManagementRegime>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetManagementConstraints(int filter)
        {
            preRun();


            //MajorManagementConstraintType
            var grantBodies = _sqLiteSyncConnection.Table<MajorManagementConstraintType>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetConservationFeatures(int filter)
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<ConservationFeature>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetDesignations(int filter)
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<DesignationType>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }



      

        public List<ComboBoxValue> GetProducts()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<IncomeProduct>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetTaxRates()
        {
            preRun();

            var grantBodies = _sqLiteSyncConnection.Table<TaxCode>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Description,
                    Description = body.VATCode
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetWorkOrders()
        {
            preRun();
        
            var grantBodies = _sqLiteSyncConnection.Table<WorkOrder>().ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.ID,
                    Name = body.Code,
                    Description = body.Description
                });
            }

            return _results;
        }

       



        public List<ComboBoxValue> GetGrantReferenceLookupDTO(int filter)
        {
            preRun();

            var magicString = @"SELECT m.ID as ManagementUnitID ,m.ManagementPlanID as ManagementPlanID ,GrantBodyID AS ID ,Reference as Name	 
                          FROM Grant g
                          join ManagementUnit m
                          on g.ManagementPlanID = m.ManagementPlanID WHERE m.ID = " + filter;

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetObservationTypeDTOs(int filter)
        {
            preRun();

            var magicString = @"SELECT ft.ID,ft.Description AS Name FROM FeatureType ft JOIN Feature f on f.TypeID = ft.id
                                        WHERE f.ManagementUnitID = " + filter;

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetCompartmentLookupDTOs(int filter)
        {
            preRun();

            var magicString = @"SELECT ID, Compartment || Reference AS Name, Description FROM SubCompartment where ManagementUnitID = " + filter;

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetHarvestingObservationTypeDTOs(int filter)
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM HarvestingOperationType";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetTypeOfInformation(int filter)
        {
            preRun();

            //EvaluationTypeID
            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM TypeOfInformation";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }


        public List<ComboBoxValue> GetApplicationTypeDTOs()
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM ApplicationType";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return grantBodies;
        }

        public List<ComboBoxValue> GetApplicationMethodDTOs()
        {

            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM ApplicationMethod";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        //xxxxx
        public List<ComboBoxValue> GetActiveIngredientDTOs()
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM ActiveIngredient";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetTargetSpeciesDTOs()
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM TargetSpecies";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetUsageReasonsDTOs()
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM ReasonForUse";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        public List<ComboBoxValue> GetSiteTypesDTOs()
        {
            preRun();

            var magicString = @"SELECT ID,Description AS Name,'' AS Description FROM SiteClassification";

            var grantBodies = _sqLiteSyncConnection.Query<ComboBoxValue>(magicString).ToList();

            _results.AddRange(grantBodies);

            return _results;
        }

        //public List<ComboBoxValue> GetCAKeyFeatures(int filter)
        //{
        //    preRun();

        //    var featStr = @"SELECT wc.ID, ft.Description AS Name FROM  WoodlandConditionSubSection wc
        //                    JOIN  Feature f on wc.KeyFeatureID = f.ID
        //                    JOIN FeatureType ft on f.TypeID= ft.ID
        //                    WHERE wc.FeatureMonitoringID = " + filter;

        //    _results.AddRange(_sqLiteSyncConnection.Query<ComboBoxValue>(featStr).ToList());

        //    return _results;
        //}

    
        public List<ComboBoxValue> GetFollowOnActionTypeDtos()
        {
            preRun();

            var hazardList = _sqLiteSyncConnection.Query<FollowOnActionType>(@"SELECT ID ,Description FROM FollowOnActionType");


            foreach (var hazAct in hazardList)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetSeverityProbabilityOfHarmDtos()
        {
            preRun();

            var hazardList = _sqLiteSyncConnection.Query<SeverityProbabilityOfHarm>(@"SELECT ID,Severity FROM SeverityProbabilityOfHarm");

            foreach (var hazAct in hazardList)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.Severity,
                    Name = hazAct.Severity
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetAuditors()
        {
            //filter this list to auditors when
            //we know what makes an auditors
            preRun();

            foreach (var hazAct in _iCache.Users)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.DisplayName,
                    Name = hazAct.Email
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetSitemanagers()
        {
            //filter this list to site managers when
            //we know what makes an auditors
            preRun();

            foreach (var hazAct in _iCache.Users)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.DisplayName,
                    Name = hazAct.Email
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetAuditGradeLookups()
        {
            preRun();


            var internalAuditGrades = _sqLiteSyncConnection.Query<ComboBoxValue>(@"SELECT ID, Description AS Name, Description FROM InternalAuditGrade");

            _results.AddRange(internalAuditGrades);

            return _results;
        }

        public List<ComboBoxValue> GetIncomeProducts()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetExpenditureProducts()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetManagementUnits()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetClumpedWith()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetFeatures()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetAdminAreas()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetRegions()
        {
            throw new NotImplementedException();
        }

        public List<SalesOrderDateOptionsDTO> GetHarvestingOptions()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetHarvestingYearOptions()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetUserDtosByGroup(int roleGroupId, int regionId)
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetDesignationForCache()
        {
            throw new NotImplementedException();
        }

        public ILookup<int, string> GetRegionsForCache()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetAgTenancyNoticePeriodOfTerminationDtos()
        {
            throw new NotImplementedException();
        }

        public List<ComboBoxValue> GetInterestLet()
        {
            throw new NotImplementedException();
        }
    }
}