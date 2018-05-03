using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Property
{
    public enum WorkProgrammeEditorComponents
    {
        Expenditures,
        Incomes,
        TopLevel
    }


    public class WorkProgrammeEditorModel : GeneralModelBase, IWorkProgrammeEditorModel
    {        
        private WorkProgrammeEditorComponents _focusedComponent;

        private int _yearOption;
        private int _managementUnitId;

        private readonly IUserPermissions _iUserStore;
        private readonly IPurchasesStore _purchasesStore;
        private readonly ISalesStore _salesStore;
      
        private ExtRangeCollection<ExpenditureEditList> _displayExpenditure;

        private ExtRangeCollection<IncomeEditList> _displayIncomes;

        private ExtRangeCollection<ExpenditureEditList> _cacheExpenditures = new ExtRangeCollection<ExpenditureEditList>();
        private ExtRangeCollection<IncomeEditList> _cacheIncomes = new ExtRangeCollection<IncomeEditList>();

        
        private WPSummaryDTO _incSumMySites;
        private WPSummaryDTO _incSumThisSite;
        private WPSummaryDTO _expSumMySites;
        private WPSummaryDTO _expSumThisSite;

        public ExtRangeCollection<ExpenditureEditList> ExpenditureList
        {
            get => _displayExpenditure;
            set
            {
                _displayExpenditure = value;
                OnPropertyChanged();
            }
        }

        public ExtRangeCollection<IncomeEditList> IncomesList
        {
            get => _displayIncomes;
            set
            {
                _displayIncomes = value;
                OnPropertyChanged();
            }
        }

        public WorkProgrammeEditorModel(ISalesStore salesStore, IPurchasesStore purchasesStore, IPlatformEventHandling iPlatformEventHandling,
            ILookupStore iLookupStore, ITelerikConvertors iTelerikConvertors, IUserPermissions iUserStore, object iDialogService,    
            INavigation iNavigation, IPageMessageBus iPageMessageBus ,  ILinkContainer iLinkContainer, IWTTimer iWTimer,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iUserStore = iUserStore;
       
            _salesStore = salesStore;
          
            _purchasesStore = purchasesStore;
            
            var years = iLookupStore.GetWorkProgrammeOptions();

            ExpenditureList = new ExtRangeCollection<ExpenditureEditList>(iDialogService);

            IncomesList = new ExtRangeCollection<IncomeEditList>(iDialogService);


            ExpenditureList.OnValidation += (e,s)=>{
                Debug.WriteLine("_displayExpenditure validated");
            };

            IncomesList.OnValidation += (e, s) => {
                Debug.WriteLine("_displayIncomes validated");
            };

         


            // load data when acquisition id property is set
            PropertyChanged += (sender, e) =>
            {

             
                var properties = this.GetType().GetRuntimeProperties();
                           
                Debug.WriteLine("property changed: " + e.PropertyName);

                if(properties.Any(a => a.DeclaringType.Name == "WorkProgrammeEditorModel" && a.Name == e.PropertyName))
                    _focusedComponent = WorkProgrammeEditorComponents.TopLevel;





                if (e.PropertyName == "YearOption")
                {
                    int year = 0;
                    
                    var lookup = years.FirstOrDefault(f => f.ID == _yearOption);

                    if (lookup != null)
                    {
                        int.TryParse(lookup.Name, out year);
                    }

                    filterDataByYear(year);
                }

                if (e.PropertyName == "State")
                {

                    var exps = _purchasesStore.GetExpenditures(ParentID);

                    _incSumMySites = _salesStore.GetWpIncomesSummaryMySites(ParentID);


                    _incSumThisSite = _salesStore.GetWpIncomesSummaryMySites(ParentID);


                    _expSumMySites = _purchasesStore.GetWPExpendituresSummaryMySites(exps);

                    _expSumThisSite = _purchasesStore.GetWPExpendituresSummaryThisSite(exps);


                    IncomesList.ReplaceRange(IncomeEditList.MakeCollection(_salesStore.GetWpIncomes(ParentID)));
                    ExpenditureList.ReplaceRange(ExpenditureEditList.MakeCollection(exps));
                    
                    SaveEnabled = false;
                }


                
            };

            LoadIncome = new RelayCommand((x) =>
            {             
                var col = _iTelerikConvertors.GetCellColumnName(x);               
                var edittableFields = new List<string> { "StartDate", "EndDate", "Forecast", "Description" };

                

                if (!edittableFields.Contains(col))
                    _iNavigation.Navigate(iLinkContainer.SalesOrder.Editor(), StateContainer.Create(ParentID, false));
                 
            });

            LoadExpenditure = new RelayCommand((x) =>
            {
                var col = _iTelerikConvertors.GetCellColumnName(x);

                var edittableFields = new List<string> { "StartDate", "EndDate", "Budget", "Description" };

                Debug.WriteLine("LoadExpenditure: " + col);

                

                if (!edittableFields.Contains(col))
                    _iNavigation.Navigate(iLinkContainer.PurchaseOrder.Editor(), StateContainer.Create(ParentID, false));
                
            });
            
            AddCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("Component: " + _focusedComponent.ToString("g"));

                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        _iNavigation.Navigate(iLinkContainer.SalesOrder.Editor(), StateContainer.Create(ParentID, true));                        
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        _iNavigation.Navigate(iLinkContainer.PurchaseOrder.Editor(), StateContainer.Create(ParentID, true));                        
                        break;
                }

                SaveEnabled = true;
            });

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("Component: " + _focusedComponent.ToString("g"));

                if (!_iUserStore.Check(UserActions.GroupB)) return;

                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        if (!IncomesList.Errors())
                            _salesStore.UpdateIncomes(IncomesList.Select(v => v.ConvertToDto()).ToList(), ParentID);
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        if (!ExpenditureList.Errors())
                            _purchasesStore.UpdateExpenditures(ExpenditureList.Select(v => v.ConvertToDto()).ToList(), ParentID);
                        break;
                }
            });
            


            DataCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("commit changed : ");

                SaveEnabled = true;

            });
            
            IncomesFocused = new RelayCommand((x) =>
            {
                 Debug.WriteLine("IncomesFocused celltap");

                _focusedComponent = WorkProgrammeEditorComponents.Incomes;

            });

            ExpendituresFocused = new RelayCommand((x) =>
            {
                Debug.WriteLine("ExpendituresFocused celltap");

                _focusedComponent = WorkProgrammeEditorComponents.Expenditures;
            });

            DuplicateCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("DuplicateCommand: ");
                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:                   
                        IncomesList.AddDuplicate(SelectedWpIncomeDto,1);
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:     
                        ExpenditureList.AddDuplicate(SelectedWpExpenditureDto, 1);
                        break;
                }

                SaveEnabled = true;
            });

            DuplicateSingleCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("DuplicateCommand: ");
                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        IncomesList.AddDuplicate(SelectedWpIncomeDto, 2);
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        ExpenditureList.AddDuplicate(SelectedWpExpenditureDto, 2);
                        break;
                }

                SaveEnabled = true;
            });

            DuplicateFourCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("DuplicateCommand: ");
                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        IncomesList.AddDuplicate(SelectedWpIncomeDto, 4);
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        ExpenditureList.AddDuplicate(SelectedWpExpenditureDto, 4);
                        break;
                }

                SaveEnabled = true;

            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("Delete Command: ");

                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        IncomesList.Delete(p => p.Id == SelectedWpIncomeDto.Id).ContinueWith((a) => SelectedWpIncomeDto = a.Result, TaskScheduler.FromCurrentSynchronizationContext()); ;
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        ExpenditureList.Delete(p => p.Id == SelectedWpExpenditureDto.Id).ContinueWith((a) => SelectedWpExpenditureDto = a.Result, TaskScheduler.FromCurrentSynchronizationContext()); ;
                        
                        break;
                }

                SaveEnabled = true;
            });

            CancelCommand = new RelayCommand((x) =>
            {
                switch (_focusedComponent)
                {
                    case WorkProgrammeEditorComponents.Incomes:
                        IncomesList.Rollback();
                        break;

                    case WorkProgrammeEditorComponents.Expenditures:
                        ExpenditureList.Rollback();

                        break;
                }
            });

        }
  
        private void filterDataByYear(int year)
        {

            //check if the existing data has been editted
            //if so then update those edits into cache
            //then filter cache 
            //what if idiots have added new records or deleted.

            //_incomes
            //_expenditure
            if (year == 0)
            {
                if(_cacheExpenditures.Count >0)
                    ExpenditureList.ReplaceRange(_cacheExpenditures);

                if (_cacheIncomes.Count > 0)
                    IncomesList.ReplaceRange(_cacheIncomes);

            }
            else
            {
               
                // so now display expenditures should contain everything 

                //now find the new records we want to remove(make invisible)
                var removedExpendituresRecords = ExpenditureList.Where(w => w.StartDate.GetValueOrDefault().Year != year && w.EndDate.GetValueOrDefault().Year != year).ToList();
                var recordsExpendituresToKeep = ExpenditureList.Where(w => w.StartDate.GetValueOrDefault().Year == year && w.EndDate.GetValueOrDefault().Year == year).ToList();

                foreach (var v in removedExpendituresRecords)
                {
                    if (_cacheExpenditures.All(a => a.Id != v.Id))
                    {
                        _cacheExpenditures.AddItem(v);
                    }
                }

                ExpenditureList.ReplaceRange(recordsExpendituresToKeep);
                
                var removedIncomesRecords = IncomesList.Where(w => w.StartDate.GetValueOrDefault().Year != year && w.EndDate.GetValueOrDefault().Year != year).ToList();
                var recordsIncomesToKeep = IncomesList.Where(w => w.StartDate.GetValueOrDefault().Year == year && w.EndDate.GetValueOrDefault().Year == year).ToList();

                foreach (var v in removedIncomesRecords)
                {
                    if (_cacheIncomes.All(a => a.Id != v.Id))
                    {
                        _cacheIncomes.AddItem(v);
                    }
                }
                
                IncomesList.ReplaceRange(recordsIncomesToKeep);
                
                var incRecs = _cacheIncomes.Where(w => w.StartDate.GetValueOrDefault().Year == year || w.EndDate.GetValueOrDefault().Year == year).ToList();

                IncomesList.ReplaceRange(incRecs);
            }
        }
        
        public int ManagementUnitId
        {
            get
            {
                return _managementUnitId;
            }

            set
            {
                _managementUnitId = value;
                OnPropertyChanged();
            }
        }

        public int YearOption
        {
            get
            {
                return _yearOption;
            }

            set
            {
                _yearOption = value;
                OnPropertyChanged();
            }
        }



        public ICommand ExpendituresFocused { get; }
        public ICommand IncomesFocused { get; }

        public ICommand LoadIncome { get; protected set; }

        public ICommand LoadExpenditure { get; protected set; }



        public ExpenditureEditList SelectedWpExpenditureDto { get; set; }

        public IncomeEditList SelectedWpIncomeDto { get; set; }
        
        public WPSummaryDTO IncomeTotalsThisSite => _incSumThisSite;

        public WPSummaryDTO IncomeTotalsMySites => _incSumMySites;

        public WPSummaryDTO ExpenditureTotalsThisSite => _expSumThisSite;

        public WPSummaryDTO ExpenditureTotalsMySites => _expSumMySites;




    }
}