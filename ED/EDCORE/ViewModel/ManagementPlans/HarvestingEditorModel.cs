using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    //HarvestingEditDTOEditList
    //: FlipModelBase<EvaluationEditEdit>, IEvaluationModel
    public class HarvestingEditorModel : FlipModelBase<HarvestingEditDTOEditList>, IHarvestingEditorModel
    { 
        private int _selectedYearOption;
        private int _selectedTotalYear;


        private double _workAreaTotal;
        private double _estimatedTotalQuantity;
        private double _actualTotalQuantity;
        private double _byYearWorkAreaTotal;
        private double _byYearEstimatedTotalQuantity;
        private double _byYearActualTotalQuantity;

        //        public ObservableRangeCollection<HarvestingEditDTO> HarvestingEditorList { get; set; } = new ObservableRangeCollection<HarvestingEditDTO>();

        public ObservableRangeCollection<ComboBoxValue> Years { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public ObservableRangeCollection<ComboBoxValue> HarvestingOperationTypes { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public ObservableRangeCollection<ComboBoxValue> Compartments { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public int SelectedTotalYear
        {
            get { return _selectedTotalYear; }
            set
            {
                if (_selectedTotalYear == value) return;

                _selectedTotalYear = value;
                OnPropertyChanged();
            }
        }

        public HarvestingEditorModel(IWTTimer iWTimer, IHarvestingStore iHarvestingStore, IPlatformEventHandling iPlatformEventHandling, IUserPermissions iUserStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iUserStore, iDialogService, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Years.ReplaceRange(iHarvestingStore.GetYears());
            HarvestingOperationTypes.ReplaceRange(iHarvestingStore.GetHarvestingOperations());


            PropertyChanged += (sender, e) =>
            {
                //load data here

                Debug.WriteLine("prop changed: " + e.PropertyName);

                if (e.PropertyName == "SelectedTotalYear")
                {
                    var result = iHarvestingStore.GetHarvestingEditContainerDTOForYear(ParentID, SelectedTotalYear);

                    ByYearWorkAreaTotal          = result.Sum(w => w.WorkAreaInHectares);
                    ByYearActualTotalQuantity    = result.Sum(w => w.ActualAmount);
                    ByYearEstimatedTotalQuantity = result.Sum(w => w.EstimatedAmount);

                }

                if (e.PropertyName == "State" || e.PropertyName == "SelectedYearOption") 
                {
                   
                    Compartments.ReplaceRange(iHarvestingStore.GetCompartments(ParentID));

                    var harvestingresult = iHarvestingStore.GetHarvestingEditContainerDTO(ParentID, SelectedYearOption);

                    WorkAreaTotal = harvestingresult.Sum(w => w.WorkAreaInHectares);
                    ActualTotalQuantity = harvestingresult.Sum(w => w.ActualAmount);
                    EstimatedTotalQuantity = harvestingresult.Sum(w => w.EstimatedAmount);

                    RecordsFlip.ReplaceRange(HarvestingEditDTOEditList.MakeCollection(harvestingresult));

                    RecordsFlip.OnValidation += (object arg1, object arg2) =>
                    {
                        Debug.WriteLine("harv validating");
                    };

                    RecordsFlip.OnCollectionUpdated += (object arg1, string arg2) =>
                    {
                        Debug.WriteLine("harv collec updated");
                    };

                    if (RecordsFlip!=null && RecordsFlip.Count >0)
                        EditRecord = RecordsFlip.First();

                    if (State.NewRecord)
                    {
                        State.NewRecord = false;

                        AddNew();
                    }
                }
            };

            LoadData = new RelayCommand((x) =>
            {

            });

            SaveCommand = new RelayCommand((x) =>
            {
                //     if (!_iUserStore.Check(UserActions.GroupB)) return;


                if (!RecordsFlip.Errors())
                    iHarvestingStore.UpdateHarvestingObjects(RecordsFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);
            });
        }
     
        public ICommand LoadData { get; protected set; }

        public double WorkAreaTotal
        {
            get => _workAreaTotal;
            set
            {
                if (_workAreaTotal == value) return;

                _workAreaTotal = value;
                OnPropertyChanged();
            }
        }
        public double EstimatedTotalQuantity
        {
            get => _estimatedTotalQuantity;
            set
            {
                if (_estimatedTotalQuantity == value) return;

                _estimatedTotalQuantity = value;
                OnPropertyChanged();
            }
        }
        public double ActualTotalQuantity
        {
            get => _actualTotalQuantity;
            set
            {
                if (_actualTotalQuantity == value) return;

                _actualTotalQuantity = value;
                OnPropertyChanged();
            }
        }

        public double ByYearWorkAreaTotal
        {
            get => _byYearWorkAreaTotal;
            set
            {
                if (_byYearWorkAreaTotal == value) return;

                _byYearWorkAreaTotal = value;
                OnPropertyChanged();
            }
        }
        public double ByYearEstimatedTotalQuantity
        {
            get => _byYearEstimatedTotalQuantity;
            set
            {
                if (_byYearEstimatedTotalQuantity == value) return;

                _byYearEstimatedTotalQuantity = value;
                OnPropertyChanged();
            }
        }
        public double ByYearActualTotalQuantity
        {
            get => _byYearActualTotalQuantity;
            set
            {
                if (_byYearActualTotalQuantity == value) return;

                _byYearActualTotalQuantity = value;
                OnPropertyChanged();
            }
        }

        public int SelectedYearOption {
            get => _selectedYearOption;
            set
            {
                if(_selectedYearOption==value) return;

                _selectedYearOption = value;
                OnPropertyChanged();
            }
        }

        protected override void AddNew()
        {
            var newRecord = new HarvestingEditDTOEditList();
            newRecord.Make(new HarvestingEditDTO()
            {
                ForecastYear = Years.FirstOrDefault(f=>f.ID == DateTime.Today.Year),
                SubCompartmentID = Compartments.FirstOrDefault(),
                TypeID = HarvestingOperationTypes.FirstOrDefault(),
                ManagementUnitID = ParentID,
                ActualAmount = 100

            });

            RecordsFlip.AddItem(newRecord, true);

            EditRecord = newRecord;
        }
    }



}