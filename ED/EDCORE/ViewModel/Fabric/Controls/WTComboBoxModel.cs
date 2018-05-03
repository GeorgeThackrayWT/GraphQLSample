using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Widgets
{
    public class WTComboBoxModel: GeneralModelBase, IWTComboBoxModel
    {        
        protected object _parent;

        protected object _filter;

        protected ComboBoxValue _selection;

        protected ObservableRangeCollection<ComboBoxValue> _source;

        protected ILookupStore _designationStore;
      
        public Dictionary<string, Func<ILookupStore,int, List<ComboBoxValue>>> DataMethods { get; private set; }

        public object Filter
        {
            get
            {
                return _filter;
            }

            set
            {
                SetProperty(ref _filter, value);
            }
        }

        public object Parent
        {
            get
            {
                return _parent;
            }

            set
            {                
                SetProperty(ref _parent, value); 
            }
        }
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }

        public WTComboBoxModel(ILookupStore iDesignationStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += WTComboBoxModel_PropertyChanged;

            DataMethods = new Dictionary<string, Func<ILookupStore,int, List<ComboBoxValue>>>();

            _designationStore = iDesignationStore;
         
            // make this a dependency

            // so we take 

            LoadData();
        }

        private void LoadData()
        {
            DataMethods.Add("InternalDesignation", (x,y) =>
            {
                var result = x.GetIntDesignationTypesDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ExternalDesignationType", (x, y) =>
            {
                var result = x.GetExtDesignationTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Designators", (x, y) =>
            {
                var result = x.GetDesignatorDtos();

                return result.ToList<ComboBoxValue>();
            });

         

            DataMethods.Add("SafetyActionLookup", (x, y) =>
            {
                var result = x.GetFollowOnActionTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ResidualRiskLevelLookup", (x, y) =>
            {
                var result = x.GetSeverityProbabilityOfHarmDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Auditors", (x, y) =>
            {
                var result = x.GetAuditors();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("IAGrade", (x, y) =>
            {
                var result = x.GetAuditGradeLookups();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("SiteManager", (x, y) =>
            {
                var result = x.GetUserDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ActionedBy", (x, y) =>
            {
                var result = x.GetUserDtos();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("LPM", (x, y) =>
            {
                var result = x.GetUserDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Applications", (x, y) =>
            {
                var result = x.GetApplicationDtos();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("HarvestingLookupTypes", (x, y) =>
            {
                var result = x.GetHarvestingYearOptions();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ManagedBy", (x, y) =>
            {
                var result = x.GetManagedByDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Countys", (x, y) =>
            {
                var result = x.GetCountyDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("AcquisitionTypes", (x, y) =>
            {
                var result = x.GetAcquisitionTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Tenures", (x, y) =>
            {
                var result = x.GetTenures();

                return result.ToList<ComboBoxValue>();
            });
            //NonFSCTYpe
            DataMethods.Add("NONFSCTYPE", (x, y) =>
            {
                var result = x.GetNonFSCTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ThirdPartyAgreementTypeDto", (x, y) =>
            {
                var result = x.GetAgreementTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ThirdPartyServiceTypeDto", (x, y) =>
            {
                var result = x.GetThirdPartyServiceTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ThirdPartyTypeDtos", (x, y) =>
            {
                var result = x.GetThirdPartyTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("StructureTypeDtos", (x, y) =>
            {
                var result = x.GetStructureTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("StructureConditionDto", (x, y) =>
            {
                var result = x.GetStructureConditionDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ContactStatuses", (x, y) =>
            {
                var result = x.GetContactStatuses();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("FundingTypes", (x, y) =>
            {
                var result = x.GetFundingTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("FundingStatus", (x, y) =>
            {
                var result = x.GetFundingStatuses();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("HighwayActTypes", (x, y) =>
            {
                var result = x.GetHighwayActTypes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("RightsType", (x, y) =>
            {
                var result = x.GetRightsType();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("InterestDisposal", (x, y) =>
            {
                var result = x.GetInterestDisposed();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseAgreementAgTen", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos();

                return result.ToList<ComboBoxValue>();
            });
            DataMethods.Add("LicenseAgreementGraz", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos();

                return result.ToList<ComboBoxValue>();
            });
            DataMethods.Add("LicenseAgreementFish", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos();

                return result.ToList<ComboBoxValue>();
            });
            DataMethods.Add("LicenseAgreementOther", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos();

                return result.ToList<ComboBoxValue>();
            });



            DataMethods.Add("LicenseInterestLet", (x, y) =>
            {
                var result = x.GetAgTenancyInterestLetDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseType", (x, y) =>
            {
                var result = x.GetAgTenancyTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseSizeIn", (x, y) =>
            {
                var result = x.GetAgTenancySizeInDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseFishingType", (x, y) =>
            {
                var result = x.GetAgTenancyFishingTypeDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseNoticeOfTermination", (x, y) =>
            {
                var result = x.GetAgTenancyNoticeOfTerminationDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseCommentsOnTerm", (x, y) =>
            {
                var result = x.GetAgTenancyCommentsOnTermDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicensePeriod", (x, y) =>
            {
                var result = x.GetAgTenancyPeriodDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("LicenseRentReview", (x, y) =>
            {
                var result = x.GetAgTenancyRentReviewDtos();

                return result.ToList<ComboBoxValue>();
            });



            DataMethods.Add("Tenancies", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos().Where(a => a.ID == 0 || a.ID == 1);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Grazing", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos().Where(a => a.ID == 2);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Fishing", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos().Where(a => a.ID == 3);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Other", (x, y) =>
            {
                var result = x.GetAgTenancyAgreementDtos().Where(a => a.ID == 4);

                return result.ToList<ComboBoxValue>();
            });

            //PurchaseOrderDateOptionsDTO
            DataMethods.Add("PurchaseOrderDateOptions", (x, y) =>
            {
                var result = x.GetPurchaseOrderDateOptionsDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("SalesOrderDateOptions", (x, y) =>
            {
                var result = x.GetSalesOrderDateOptionsDtos();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("GrantBodies", (x, y) =>
            {
                var result = x.GetGrantBodies();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Schemes", (x, y) =>
            {
                var result = x.GetSchemes();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("KeyFeatures", (x, y) =>
            {
                var result = x.GetGrantBodies();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Aims", (x, y) =>
            {
                var result = x.GetSchemes();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("ManagementConstraintTypes", (x, y) =>
            {
                var result = x.GetManagementConstraints(y);

                return result.ToList<ComboBoxValue>();
            });



            DataMethods.Add("ConservationTypes", (x, y) =>
            {
                var result = x.GetConservationFeatures(y);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Designations", (x, y) =>
            {
                var result = x.GetDesignations(y);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("MainSpecies", (x, y) =>
            {
                var result = x.GetMainSpeciesDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("SecondarySpecies", (x, y) =>
            {
                var result = x.GetMainSpeciesDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ManagementRegions", (x, y) =>
            {
                var result = x.GetManagementRegimeDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Years", (x, y) =>
            {
                var result = x.GetYears();

                return result.ToList<ComboBoxValue>();
            });

            //GetWorkProgrammeOptions

            DataMethods.Add("WorkProgrammeOptions", (x, y) =>
            {
                var result = x.GetWorkProgrammeOptions();

                return result.ToList<ComboBoxValue>();
            });

            // product

            DataMethods.Add("Products", (x, y) =>
            {
                var result = x.GetIncomeProducts();

                return result.ToList<ComboBoxValue>();
            });

            // vat rate
            DataMethods.Add("VATRates", (x, y) =>
            {
                var result = x.GetVATRates();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("TAXCodes", (x, y) =>
            {
                var result = x.GetTaxRates();

                return result.ToList<ComboBoxValue>();
            });

            // grant reference
            DataMethods.Add("GrantReference", (x, y) =>
            {
                var result = x.GetGrantReferenceLookupDTO(y);

                return result.ToList<ComboBoxValue>();
            });

            //DataMethods.Add("ObservationTypes", (x, y) =>
            //{
            //    var result = x.GetObservationTypeDTOs(y);

            //    return result.ToList<ComboBoxValue>();
            //});

            DataMethods.Add("CompartmentLookups", (x, y) =>
            {
                var result = x.GetCompartmentLookupDTOs(y);

                return result.ToList<ComboBoxValue>();
            });

            //DataMethods.Add("HarvestingOperationType", (x, y) =>
            //{
            //    var result = x.GetHarvestingObservationTypeDTOs(y);

            //    return result.ToList<ComboBoxValue>();
            //});

            DataMethods.Add("HarvestingOptions", (x, y) =>
            {
                var result = x.GetHarvestingOptionsDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("TypeInformation", (x, y) =>
            {
                var result = x.GetTypeOfInformation(y);

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("ApplicationType", (x, y) =>
            {
                var result = x.GetApplicationTypeDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ApplicationMethod", (x, y) =>
            {
                var result = x.GetApplicationMethodDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ActiveIngredient", (x, y) =>
            {
                var result = x.GetActiveIngredientDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("TargetSpecies", (x, y) =>
            {
                var result = x.GetTargetSpeciesDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("UsageReasons", (x, y) =>
            {
                var result = x.GetUsageReasonsDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("SiteTypes", (x, y) =>
            {
                var result = x.GetSiteTypesDTOs();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("Units", (x, y) =>
            {
                var result = x.GetUnitsDTOs();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Stratums", (x, y) =>
            {
                var result = x.GetCAStratums();

                return result.ToList<ComboBoxValue>();
            });

            //DataMethods.Add("CAKeyFeatures", (x, y) =>
            //{
            //    var result = x.GetCAKeyFeatures(y);

            //    return result.ToList<ComboBoxValue>();
            //});

            //List<UnitsDTO> GetUnitsDTOs()


        }


        private void WTComboBoxModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {            
            //Debug.WriteLine("WTComboBoxModel_PropertyChanged: " + e.PropertyName);

            if (e.PropertyName == "Parent" || e.PropertyName =="Filter")
            {

                if (Parent.ToString() == "CAKeyFeatures")
                {
                    Debug.WriteLine("Filter:" + this.Filter + " Parent: " + Parent);
                }
                //var p = Parent as CmbFilter;
                //CAKeyFeatures

                //var result = p != null ? DataMethods[p.Name].Invoke(_designationStore, p.FilterID) : DataMethods[Parent.ToString()].Invoke(_designationStore, 0);


                int filterInt = 0;

                var filter = this.Filter;

                if (filter != null)
                    Int32.TryParse(filter.ToString(), out filterInt);

                var result = DataMethods[Parent.ToString()].Invoke(_designationStore, filterInt);

                _source = new ObservableRangeCollection<ComboBoxValue>();

                //Debug.WriteLine("WTComboBoxModel_PropertyChanged got data: " + result.Count);

                

                _source.ReplaceRange(result);


                // we need to refresh this because the
                // the selection object needs to point 
                // to an item in sources collection
                if (CachedSelectionID != 0)
                {
                    var selectedValueInItemCollection = Source.FirstOrDefault(f => f.ID == CachedSelectionID);

                    if (selectedValueInItemCollection != null)
                        Selection = selectedValueInItemCollection;
                }
            }

            if (e.PropertyName == "Selection")
            {
              
            }

        }
            
        public ComboBoxValue Selection
        {
            get
            {
                if (_selection != null)
                    return _selection;
                else
                    return _source[0];
            }
            set
            {
                SetProperty(ref _selection, value);
            }
        }

        public ObservableRangeCollection<ComboBoxValue> Source
        {
            get
            {
                var returnVals = new ObservableRangeCollection<ComboBoxValue>();

                if(_source ==null) return returnVals;

                foreach (var comboBoxValue in _source)
                {
                    returnVals.Add(comboBoxValue);
                }

                return returnVals;
            }
        }

        public string Label { get; set; }

        public int CachedSelectionID { get; set; }
    }
}