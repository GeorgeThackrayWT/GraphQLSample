using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VComboBoxModel : GeneralModelBase, IVComboBoxModel
    {
        protected object _parent;

        protected object _filter;

        protected ComboBoxValue _selection;

        protected ObservableRangeCollection<ComboBoxValue> _source;

        protected ILookupStore _designationStore;


        private Property<int> _selectedItem;

        private ICommand _selectionChanged;

        public Dictionary<string, Func<ILookupStore, int, List<ComboBoxValue>>> DataMethods { get; private set; }

        private bool _readOnly;
        private int _acqRegionHack;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }

        public object Filter
        {
            get => _filter;

            set => SetProperty(ref _filter, value);
        }

        public object Parent
        {
            get => _parent;

            set => SetProperty(ref _parent, value);
        }


        public VComboBoxModel(ILookupStore iDesignationStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {

            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += WTComboBoxModel_PropertyChanged;

            DataMethods = new Dictionary<string, Func<ILookupStore, int, List<ComboBoxValue>>>();

            _designationStore = iDesignationStore;

            _source = new ObservableRangeCollection<ComboBoxValue>();

            // make this a dependency

            // so we take 
            _acqRegionHack = 0;

            LoadData();
        }

       

        private void LoadData()
        {
            DataMethods.Add("AdminArea", (x, y) =>
            {
                var result = x.GetAdminAreas();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ClumpedWith", (x, y) =>
            {
                var result = x.GetClumpedWith();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ManagementUnits", (x, y) =>
            {
                var result = x.GetManagementUnits();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("InternalDesignation", (x, y) =>
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

                //_acqRegionHack
                var result = x.GetUserDtosByGroup(5, _acqRegionHack);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ActionedBy", (x, y) =>
            {
                var result = x.GetUserDtos();

                return result.ToList<ComboBoxValue>();
            });


            DataMethods.Add("LPM", (x, y) =>
            {
                var result = x.GetUserDtosByGroup(6,0);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Applications", (x, y) =>
            {
                var result = x.GetApplicationDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ManagedBy", (x, y) =>
            {
                var result = x.GetManagedByDtos();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Regions", (x, y) =>
            {
                var result = x.GetRegions();

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
                var result = x.GetInterestLet();

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

            DataMethods.Add("LicenseNoticePeriodOfTermination", (x, y) =>
            {
                var result = x.GetAgTenancyNoticePeriodOfTerminationDtos();

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



            DataMethods.Add("Tenancy", (x, y) =>
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

            DataMethods.Add("HarvestingDateOptions", (x, y) =>
            {
                var result = x.GetHarvestingOptions();

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
                var result = x.GetFeatures();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("Aims", (x, y) =>
            {
                var result = x.GetAIMDtos();

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

            DataMethods.Add("IncomeProducts", (x, y) =>
            {
                var result = x.GetIncomeProducts();

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("ExpenditureProducts", (x, y) =>
            {
                var result = x.GetExpenditureProducts();

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

            DataMethods.Add("WorkOrders", (x, y) =>
            {
                var result = x.GetWorkOrders();

                return result.ToList<ComboBoxValue>();
            });


            // grant reference
            DataMethods.Add("GrantReference", (x, y) =>
            {
                var result = x.GetGrantReferenceLookupDTO(y);

                return result.ToList<ComboBoxValue>();
            });

            DataMethods.Add("HarvestingLookupTypes", (x, y) =>
            {
                var result = x.GetHarvestingYearOptions();

                return result.ToList<ComboBoxValue>();
            });

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

            


     //       if (e.PropertyName == "ParentInstance")
       //     {
                var tp = ParentInstance as IAcquisitionEditModel;

                if (tp != null)
                {
                    tp.AcquisitionMainSection.PropertyChanged += (s, e2) =>
                        {
                            if (_acqRegionHack != tp.AcquisitionMainSection.Region.Value)
                            {

                                if (Parent.ToString() == "SiteManager")
                                {
                                    _acqRegionHack = tp.AcquisitionMainSection.Region.Value;

                                    var result = DataMethods[Parent.ToString()]
                                        .Invoke(_designationStore, _acqRegionHack);

                                    _source = new ObservableRangeCollection<ComboBoxValue>();

                                    _source.ReplaceRange(result);

                                    OnPropertyChanged("Source");
                                }

                                //  OnPropertyChanged("Source");
                            }
                        };
                }
      //      }



            if (e.PropertyName == "Parent" || e.PropertyName == "Filter")
            {

                int filterInt = 0;

                var filter = this.Filter;

                if (filter != null)
                    Int32.TryParse(filter.ToString(), out filterInt);



                var result = DataMethods[Parent.ToString()].Invoke(_designationStore, filterInt);

                _source = new ObservableRangeCollection<ComboBoxValue>();

                _source.ReplaceRange(result);

                OnPropertyChanged("Source");
                
            }

            if (e.PropertyName == "SelectedItem")
            {
                var selectedValueInItemCollection = Source.FirstOrDefault(f => f.ID == SelectedItem.Value);

                if (selectedValueInItemCollection != null && Selection.ID != selectedValueInItemCollection.ID)
                    Selection = selectedValueInItemCollection;
            }
                        
        }

        public void Dispose()
        {
            this._designationStore = null;
            this._filter = null;
            this._parent = null;

            this._selectedItem = null;
            this._selectionChanged = null;
            this._selection = null;
            
            this.DataMethods = null;
            this._source = null;
 
            base.Dispose();
        }

        public ComboBoxValue Selection
        {        
            get
            {

             
                if (_selection == null && !_source.Any()) return null;

                var retVal = _selection ?? _source[0];
                
                return retVal;
            }
      
            set
            {                
                if (_selection?.ID == value?.ID) return;

                _selection = value;

                //this will trigger test setter
                //but value shouldnt change for the selection property
                //thereby avoiding a stack overflow!
                SelectedItem.Value = Selection.ID;

                _selectionChanged?.Execute(SelectedItem);

                OnPropertyChanged();
            }
        }

        public ObservableRangeCollection<ComboBoxValue> Source
        {
            get
            {
                var returnVals = new ObservableRangeCollection<ComboBoxValue>();

                if (_source == null) return returnVals;

                foreach (var comboBoxValue in _source)
                {
                    returnVals.Add(comboBoxValue);
                }

                return returnVals;
            }
        }

        public string Label { get; set; }
        
        public Property<int> SelectedItem
        {
            get => _selectedItem;

            set
            {

                if (_selectedItem?.Value == value?.Value) return;

                _selectedItem = value;

                OnPropertyChanged();
            }
        }

        public ICommand SelectionChangedCommand
        {
            get => _selectionChanged;
            set => _selectionChanged = value;
        }
    }
}