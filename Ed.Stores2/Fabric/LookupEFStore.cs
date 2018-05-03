using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects;
using DataObjects.DTOS.lookups;
using EDC_Estate.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace EFStores.Fabric
{


    public class LookupEFStore : BaseEFStore, ILookupStore
    {
        private List<ComboBoxValue> _results = new List<ComboBoxValue>();

        public LookupEFStore(EstateContext ec, ICache iCache, IUserStore iUserStore) : 
            base(ec, iCache)
        {
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

        #region hardcoded

        public List<SalesOrderDateOptionsDTO> GetHarvestingOptions()
        {
            throw new System.NotImplementedException();
        }


        //special case
        public ILookup<int, string> GetRegionsForCache()
        {
            var regionLookup = Context.Region.AsNoTracking().ToList().Select(r => new { r.Id, r.Description })
                .AsEnumerable()
                .ToLookup(rg => rg.Id, rg => rg.Description);

            return regionLookup;
        }

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

        public List<ComboBoxValue> GetHarvestingYearOptions()
        {
        //    preRun();

            _results = new List<ComboBoxValue>();

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
                    Name = "2018",
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

            _results.AddRange(Context.WoodlandConditionStratum.Select(v => new ComboBoxValue()
            {
                ID = v.Id,
                Name = v.Description,
                Description = v.Description
            }));

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

        #endregion


        public List<ComboBoxValue> GetAdminAreas()
        {
            preRun();

            foreach (var hazAct in Context.AdministrationArea)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetUserDtosByGroup(int roleGroupId, int regionId)
        {
            preRun();

            var userlist = new List<int>();
              
            if (regionId == 0)
            {
                userlist = _cache.UserRoleSmallDtos.Where(ur => ur.RoleId == roleGroupId).Select(s => s.UserId)
                    .ToList();
            }
            else
            {
                userlist = _cache.UserRoleSmallDtos.Where(ur => ur.RoleId == roleGroupId && ur.RegionId == regionId).Select(s => s.UserId).ToList();
            }


            foreach (var hazAct in _cache.UserDtos)
            {


                if (userlist.Contains(hazAct.ID))
                {
                    _results.Add(new ComboBoxValue()
                    {
                        ID = hazAct.ID,
                        Description = hazAct.DisplayName,
                        Name = hazAct.DisplayName
                    });
                }
            }

            return _results;
        }

        public List<ComboBoxValue> GetUserDtos()
        {
            preRun();

        
            foreach (var hazAct in _cache.UserDtos)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.DisplayName,
                    Name = hazAct.DisplayName
                });
            }

            return _results;
        }


        public List<ComboBoxValue> GetAuditors()
        {
            //filter this list to auditors when
            //we know what makes an auditors
            preRun();

            foreach (var hazAct in _cache.UserDtos)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.ID,
                    Description = hazAct.DisplayName,
                    Name = hazAct.DisplayName
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetSitemanagers()
        {
            //filter this list to site managers when
            //we know what makes an auditors
            preRun();

            foreach (var hazAct in Context.User)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.DisplayName,
                    Name = hazAct.Email
                });
            }

            return _results;
        }







        public List<ComboBoxValue> GetTenures()
        {
            preRun();

            var tenureTask = Context.Tenure;

            var temp = tenureTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetNonFSCTypes()
        {
            preRun();

            var tenureTask = Context.NonFsctype;

            var temp = tenureTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetAcquisitionTypes()
        {
            preRun();

            var acquisitionTask = Context.AcquisitionType;

            var temp = acquisitionTask.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetCountyDtos()
        {
            preRun();

            var countyTask = Context.County;

            var temp = countyTask.Select(county => new ComboBoxValue()
            {
                ID = county.Id,
                Name = county.Code,
                Description = county.Description
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetApplicationDtos()
        {
            preRun();

            var designationTypes = Context.Application.ToList();

            var temp = designationTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Name,
                Description = tenure.Description

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }


        public List<ComboBoxValue> GetExtDesignationTypeDtos()
        {
            preRun();

            

            //var designationTypes = Context.DesignationType.ToList();

            //var temp = designationTypes.Select(tenure => new ComboBoxValue()
            //{
            //    ID = tenure.Id,
            //    Name = tenure.Reference,
            //    Description = tenure.Description

            //}).ToList<ComboBoxValue>();

            //cache frequent access items
            _results.AddRange(_cache.DesignationLookup);

            return _results;
        }

        public List<ComboBoxValue> GetIntDesignationTypesDtos()
        {
            preRun();

            var internalDesignationTypes = Context.InternalDesignationType.ToList();

            var temp = internalDesignationTypes.Select(i => new ComboBoxValue()
            {
                ID = i.Id,
                Name = i.Reference,
                Description = i.Description

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetDesignatorDtos()
        {
            preRun();

            var designators = Context.Designator.ToList();

            var temp = designators.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""
            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetInterestDisposed()
        {
            preRun();

            var contactStatuses = Context.DisposedInterest.ToList();

            var temp = contactStatuses.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetContactStatuses()
        {

            preRun();


            var contactStatuses = Context.ContactStatus.ToList();

            var temp = contactStatuses.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList<ComboBoxValue>();

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetFundingTypes()
        {
            preRun();

            var fundingTypes = Context.FundingType.ToList();

            var temp = fundingTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = tenure.Description

            }).ToList(); ;

            _results.AddRange(temp);

            return _results;
        }

        public List<ComboBoxValue> GetFundingStatuses()
        {
            preRun();

            var fundingTypes = Context.FundingStatus.ToList();

            var fundingTypesDtos = fundingTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
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

            var highwayAuthorities = Context.HighwayAuthority.ToList();

            var highwayAuthoritiesDtos = highwayAuthorities.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
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

            var highwayAuthorities = Context.RightsType.ToList();

            var highwayAuthoritiesDtos = highwayAuthorities.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(highwayAuthoritiesDtos);

            return _results;
        }

        //servicetype
        public List<ComboBoxValue> GetThirdPartyServiceTypes()
        {

            _results = new List<ComboBoxValue>();

            var thirdPartyServices = Context.ThirdPartyService.ToList();

            var thirdPartyServiceDtos = thirdPartyServices.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyServiceDtos);

            return _results;
        }

        //ThirdPartyAgreementTypeDto
        public List<ComboBoxValue> GetAgreementTypes()
        {
            _results = new List<ComboBoxValue>();
            var thirdPartyAgreements = Context.ThirdPartyAgreement.ToList();

            var thirdPartyAgreementsdtos = thirdPartyAgreements.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyAgreementsdtos);

            return _results;
        }

        public List<ComboBoxValue> GetThirdPartyTypeDtos()
        {
            _results = new List<ComboBoxValue>();
            var thirdPartyTypes = Context.ThirdPartyType.ToList();

            var thirdPartyTypesdtos = thirdPartyTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(thirdPartyTypesdtos);

            return _results;
        }

        //structuretype
        public List<ComboBoxValue> GetStructureTypeDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.StructureType.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetStructureConditionDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.StructureCondition.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyAgreementDtos()
        {
            _results = new List<ComboBoxValue>();

            var structureTypes = Context.LicenceAgreement.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyCommentsOnTermDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.CommentsOnTerm.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyFishingTypeDtos()
        {
            _results = new List<ComboBoxValue>();

            var structureTypes = Context.FishingType.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyInterestLetDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.InterestLet.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyRentReviewDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.RentReview.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyPeriodDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.LicencePeriod.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyNoticeOfTerminationDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.NoticeOfTermination.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyNoticePeriodOfTerminationDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.ProvisionsNotice.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancySizeInDtos()
        {
            _results = new List<ComboBoxValue>();
            var structureTypes = Context.SizeIn.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAgTenancyTypeDtos()
        {

            _results = new List<ComboBoxValue>();
            var structureTypes = Context.LicenceType.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetKeyFeatureDtos()
        {
            preRun();

            var structureTypes = Context.FeatureType.ToList();

            var structureTypesDtos = structureTypes.Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = ""

            }).ToList();

            _results.AddRange(structureTypesDtos);

            return _results;
        }

        public List<ComboBoxValue> GetAIMDtos()
        {
            preRun();

           // if (!Context.Aim.Any()) return _results;

            _results = new List<ComboBoxValue>();

            var aims = Context.Aim.Select(aim => new ComboBoxValue()
            {
                ID = aim.Id,
                Name = aim.LongDescription,
                Description = aim.LongDescription
            }).ToList();

            _results.AddRange(aims);

            return _results;
        }

        public List<ComboBoxValue> GetGrantBodies()
        {
            preRun();

            var grantBodies = Context.GrantBody.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetFeatures()
        {
            preRun();

            var featureTypes = Context.FeatureType.ToList();

          //  if (featureTypes.Count == 0) return _results;

          //  _results = new List<ComboBoxValue>();

            foreach (var body in featureTypes)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = body.Description
                });
            }

            return _results;
        }


        public List<ComboBoxValue> GetSchemes()
        {
            preRun();

            var grantBodies = Context.AwardingScheme.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }



        public List<ComboBoxValue> GetMainSpeciesDTOs()
        {
            preRun();

            var grantBodies = Context.Species.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetManagementRegimeDTOs()
        {
            preRun();

            var grantBodies = Context.ManagementRegime.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
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
            var grantBodies = Context.MajorManagementConstraintType.ToList();

            if (grantBodies.Count == 0) return _results;

            _results = new List<ComboBoxValue>();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetConservationFeatures(int filter)
        {
            // preRun();
            _results = new List<ComboBoxValue>();

             var grantBodies = Context.ConservationFeature.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetDesignations(int filter)
        {
            //  preRun();

            var acqu = Context.AcquisitionUnit.FirstOrDefault(
                a => a.ManagementUnitId == filter);

            _results = new List<ComboBoxValue>();

            var grantBodies = Context.Designation.Include(d => d.Type).Where(a => a.AcquisitionUnitId == acqu.Id);

            foreach (var body in grantBodies.ToList())
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Type==null ? "Unknown Type" : body.Type.Description,
                    Description = ""
                });
            }

            return _results;
        }


        public List<ComboBoxValue> GetExpenditureProducts()
        {
            preRun();

            var grantBodies = Context.ExpenditureProduct.Where(d=>!d.Deleted).ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }


        public List<ComboBoxValue> GetIncomeProducts()
        {
            preRun();

            var grantBodies = Context.IncomeProduct.Where(d => !d.Deleted).ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = ""
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetTaxRates()
        {
            preRun();

            var grantBodies = Context.TaxCode.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Description,
                    Description = body.Vatcode
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetWorkOrders()
        {
            preRun();

            var grantBodies = Context.WorkOrder.ToList();

            foreach (var body in grantBodies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = body.Id,
                    Name = body.Code,
                    Description = body.Description
                });
            }

            return _results;
        }




        public List<ComboBoxValue> GetGrantReferenceLookupDTO(int filter)
        {
            preRun();

            //var magicString = @"SELECT  Reference as Name	 
            //              FROM Grant g
            //              join ManagementUnit m
            //              on g.ManagementPlanID = m.ManagementPlanID WHERE m.ID = " + filter;


            foreach (var hazAct in Context.Grant.Include(i=>i.ManagementPlan).ThenInclude(ti=>ti.ManagementUnit).Where(w=>w.ManagementPlan.ManagementUnit.Any(a=>a.Id == filter)))
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Reference,
                    Name = hazAct.Reference
                });
            }

            return _results;
        }

        //public List<ComboBoxValue> GetObservationTypeDTOs(int filter)
        //{
        //    preRun();
             
        //    foreach (var hazAct in Context.Feature.Include(f=>f.Type).Where(m => m.ManagementUnitId == filter && m.TypeId!=null))
        //    {
        //        _results.Add(new ComboBoxValue()
        //        {
        //            ID = hazAct.Type.Id,
        //            Description = hazAct.Type.Description,
        //            Name = hazAct.Type.Description
        //        });
        //    }

        //    return _results;
        //}

        public List<ComboBoxValue> GetCompartmentLookupDTOs(int filter)
        {
            preRun();
         
            foreach (var hazAct in Context.SubCompartment.Where(m=>m.ManagementUnitId == filter))
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Reference
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetHarvestingObservationTypeDTOs(int filter)
        {
            preRun();
 

            foreach (var hazAct in Context.HarvestingOperationType)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetTypeOfInformation(int filter)
        {
            preRun();
  
            foreach (var hazAct in Context.TypeOfInformation)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return _results;
        }


        public List<ComboBoxValue> GetApplicationTypeDTOs()
        {
            preRun();

            foreach (var hazAct in Context.ApplicationType)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetApplicationMethodDTOs()
        {

            preRun();

         
            foreach (var hazAct in Context.ApplicationMethod)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return _results;
        }

        //xxxxx
        public List<ComboBoxValue> GetActiveIngredientDTOs()
        {
            preRun();
 
            foreach (var hazAct in Context.ActiveIngredient)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetTargetSpeciesDTOs()
        {
            preRun();

         

            foreach (var hazAct in Context.TargetSpecies)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetUsageReasonsDTOs()
        {
            preRun();

       
            foreach (var hazAct in Context.ReasonForUse)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetSiteTypesDTOs()
        {
            preRun();

          
            foreach (var hazAct in Context.SiteClassification)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }



            return _results;
        }

        //public List<ComboBoxValue> GetCAKeyFeatures(int filter)
        //{
        //    preRun();

        //   // Context.FeatureType.Include(i=>i.Feature)

        //    foreach (var hazAct in Context.FeatureType.Include(i => i.Feature))
        //    {

        //        foreach (var v in hazAct.Feature)
        //        {
        //            if (v.ManagementUnitId == filter)
        //            {
        //                _results.Add(new ComboBoxValue()
        //                {
        //                    ID = v.Id,
        //                    Description = hazAct.Description,
        //                    Name = hazAct.Description
        //                });
        //            }
        //        }

             
        //    }

        //    return _results;
        //}


        public List<ComboBoxValue> GetFollowOnActionTypeDtos()
        {
            preRun();

        
            foreach (var hazAct in Context.FollowOnActionType)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Description,
                    Name = hazAct.Description
                });
            }


            return _results;
        }

        public List<ComboBoxValue> GetSeverityProbabilityOfHarmDtos()
        {
            preRun();
       
            foreach (var hazAct in Context.SeverityProbabilityOfHarm)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Severity,
                    Name = hazAct.Severity
                });
            }

            return _results;
        }



        public List<ComboBoxValue> GetAuditGradeLookups()
        {
            preRun();

            _results.AddRange(Context.InternalAuditGrade.Select(s =>
                new ComboBoxValue() { ID = s.Id, Description = s.Description, Name = s.Description }).ToList());

            return _results;
        }

        public List<ComboBoxValue> GetManagementUnits()
        {
            //throw new System.NotImplementedException();

            preRun();

            foreach (var hazAct in Context.ManagementUnit)
            {
                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = hazAct.Name,
                    Name = hazAct.Name
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetClumpedWith()
        {         
            preRun();

            foreach (var hazAct in Context.Grant.Include(m=>m.ManagementPlan).ThenInclude(a=>a.ManagementUnit))
            {
                var manUnit = hazAct.ManagementPlan.ManagementUnit.First();

                _results.Add(new ComboBoxValue()
                {
                    ID = hazAct.Id,
                    Description = manUnit.Name + " " + manUnit.Id.ToString() + " " + hazAct.Reference,
                    Name = manUnit.Name + " " + manUnit.Id.ToString() + " " + hazAct.Reference
                });
            }

            return _results;
        }

        public List<ComboBoxValue> GetRegions()
        {
            var results = new List<ComboBoxValue>();

            foreach (var region in Context.Region)
            {
                results.Add(new ComboBoxValue()
                {
                    ID = region.Id,
                    Description = region.Name,
                    Name = region.Name
                });
            }

            return results;
        }

        public List<ComboBoxValue> GetDesignationForCache()
        {
            var designationLookup = Context.DesignationType.AsNoTracking().Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Reference,
                Description = tenure.Description

            }).ToList<ComboBoxValue>();

            return designationLookup;
        }

        public List<ComboBoxValue> GetInterestLet()
        {
            var designationLookup = Context.InterestLet.AsNoTracking().Select(tenure => new ComboBoxValue()
            {
                ID = tenure.Id,
                Name = tenure.Description,
                Description = tenure.Description

            }).ToList<ComboBoxValue>();

            return designationLookup;
        }
    }
}
