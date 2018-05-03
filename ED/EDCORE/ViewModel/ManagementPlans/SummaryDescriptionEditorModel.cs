using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Fabric;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class SummaryDescriptionEditorModel : GeneralModelBase, ISummaryDescriptionEditorModel
    {
        private ISummaryStore _summaryStore;



        //summaryedit
        public SummaryOverviewEdit SummaryOverviewEdit { get; set; } = new SummaryOverviewEdit();

        //summarylist
        public ExtRangeCollection<SummaryEditList> SummariesList { get; set; }
        private SummaryEditList _selectedSummary;
        public SummaryEditList SelectedSummary
        {
            get
            {
                if (_selectedSummary == null && SummariesList.Count > 0)
                    return SummariesList[0];
                else
                    return _selectedSummary ?? new SummaryEditList();
            }
            set
            {
                if (value != null && _selectedSummary != null)
                {
                    if (value.Id == _selectedSummary.Id) return;
                }

                if (_selectedSummary == value) return;

                if (value == null) return;

                _selectedSummary = value;
                OnPropertyChanged();
            }
        }

        //constraintlist
        public ExtRangeCollection<SummaryConstraintEditList> MajorManagementConstraintsList { get; set; }
        private SummaryConstraintEditList _selectedConstraint;
        public SummaryConstraintEditList SelectedConstraint
        {
            get
            {
                if (_selectedConstraint == null && MajorManagementConstraintsList.Count == 0) return null;

                return _selectedConstraint ?? MajorManagementConstraintsList[0];
            }
            set
            {
                if (_selectedConstraint == value) return;
                _selectedConstraint = value;
                OnPropertyChanged();
            }
        }

        //featurelist
        public ExtRangeCollection<SummaryFeatureEditList> ConservationFeaturesList { get; set; }
        private SummaryFeatureEditList _selectedFeature;
        public SummaryFeatureEditList SelectedFeature
        {
            get
            {


                if(_selectedFeature == null && ConservationFeaturesList.Count == 0) return null;


                return _selectedFeature ?? ConservationFeaturesList[0];
            }
            set
            {
                if (_selectedFeature == value) return;
                _selectedFeature = value;
                OnPropertyChanged();
            }
        }
        
        //designationlist
        public ExtRangeCollection<SummaryDesignationEditList> DesignationsList { get; set; }
        private SummaryDesignationEditList _selectedDesignation;
        public SummaryDesignationEditList SelectedDesignation
        {
            get
            {
                if (_selectedDesignation == null && DesignationsList.Count == 0) return null;


                return _selectedDesignation ?? DesignationsList[0];
            }
            set
            {
                if (_selectedDesignation == value) return;
                _selectedDesignation = value;
                OnPropertyChanged();
            }
        }




        


        public SummaryDescriptionEditorModel(ISummaryStore isummaryStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _summaryStore = isummaryStore;


            SummariesList = new ExtRangeCollection<SummaryEditList>(iDialogService);
            MajorManagementConstraintsList = new ExtRangeCollection<SummaryConstraintEditList>(iDialogService);
            ConservationFeaturesList  = new ExtRangeCollection<SummaryFeatureEditList>(iDialogService);
            DesignationsList = new ExtRangeCollection<SummaryDesignationEditList>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                //load data here
            
                switch (e.PropertyName)
                {
                    case "State":
                        Debug.WriteLine(ParentID);
                        DesignationsLookup = iLookupStore.GetDesignations(ParentID).ToList<ComboBoxValue>();


                        MajorManagementConstraintsList.ReplaceRange(SummaryConstraintEditList.MakeCollection(new List<SummaryConstraintDto>()));
                        ConservationFeaturesList.ReplaceRange(SummaryFeatureEditList.MakeCollection(new List<SummaryFeatureDto>()));
                        DesignationsList.ReplaceRange(SummaryDesignationEditList.MakeCollection(new List<SummaryDesignationDto>()));

                        SummaryOverviewEdit.Make(_summaryStore.GetSummaryDescriptionContainerEditDto(ParentID));
                        SummariesList.ReplaceRange(SummaryEditList.MakeCollection(_summaryStore.GetSummaries(ParentID)));
                        if(SummariesList.Count >0)
                            SelectedSummary = SummariesList.First();
                      
                        break;
                    case "SelectedSummary":
                        MajorManagementConstraintsList.ReplaceRange(SummaryConstraintEditList.MakeCollection(_summaryStore.GetSummaryConstraints(SelectedSummary.SubCompartmentID)));
                        if (MajorManagementConstraintsList!=null && MajorManagementConstraintsList.Count >0)
                            SelectedConstraint = MajorManagementConstraintsList.First();

                        ConservationFeaturesList.ReplaceRange(SummaryFeatureEditList.MakeCollection(_summaryStore.GetSummaryFeatures(SelectedSummary.SubCompartmentID)));
                        if (ConservationFeaturesList != null && ConservationFeaturesList.Count > 0)
                            SelectedFeature = ConservationFeaturesList?.First();

                        DesignationsList.ReplaceRange(SummaryDesignationEditList.MakeCollection(_summaryStore.GetSummaryDesignations(SelectedSummary.SubCompartmentID)));
                        if (DesignationsList != null && DesignationsList.Count > 0)
                            SelectedDesignation = DesignationsList?.First();
                        
                        break;
                }


            };

            LongTermPolicy = new HiddenPanel((result) =>
            {
               
            });

            SummaryDescription = new HiddenPanel((result) =>
            {
                OnPropertyChanged("SummaryDescription");

            });

            PAWSMap = new RelayCommand((x) =>
            {
                Debug.WriteLine("PAWS Clicked");
              
            });

            CompartmentMap = new RelayCommand((x) =>
            {
                Debug.WriteLine("CompartmentMap Clicked");
            });

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("Save Clicked");

                _summaryStore.UpdateSummaries(SummariesList.Select(v => v.ConvertToDto()).ToList(), ParentID);
                OnPropertyChanged("State");

                _summaryStore.UpdateSummaryConstraints(MajorManagementConstraintsList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                _summaryStore.UpdateSummaryFeatures(ConservationFeaturesList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                _summaryStore.UpdateSummaryDesignations(DesignationsList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                OnPropertyChanged("SelectedSummary");

                //var a = (InstanceData)x;

                //switch (a.ControlName)
                //{
                //    case "SummariesList":
                //        _summaryStore.UpdateSummaries(SummariesList.Select(v => v.ConvertToDto()).ToList(), ParentID);
                //        OnPropertyChanged("State");
                //        break;
                //    case "MajorManagementConstraintsList":
                //        _summaryStore.UpdateSummaryConstraints(MajorManagementConstraintsList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                //        OnPropertyChanged("SelectedSummary");
                //        break;
                //    case "ConservationFeaturesList":
                //        _summaryStore.UpdateSummaryFeatures(ConservationFeaturesList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                //        OnPropertyChanged("SelectedSummary");
                //        break;
                //    case "DesignationsList":
                //        _summaryStore.UpdateSummaryDesignations(DesignationsList.Select(v => v.ConvertToDto()).ToList(), SelectedSummary.SubCompartmentID);
                //        OnPropertyChanged("SelectedSummary");
                //        break;


                //}

                
            });

            AddCommand = new RelayCommand((x) =>
            {
                var a = (InstanceData) x;

              //  Debug.WriteLine(a.InstanceID + " - " + a.ControlName + " - " + a.Element);

                switch (a.ControlName)
                {
                    case "SummariesList":
                        AddSummary();
                        break;
                    case "MajorManagementConstraintsList":
                        AddConstraint();
                        break;
                    case "ConservationFeaturesList":
                        AddFeature();
                        break;
                    case "DesignationsList":
                        AddDesignation();
                        break;
                }
            });


            DeleteCommand = new RelayCommand((x) =>
            {
                var a1 = (InstanceData)x;


                Debug.WriteLine("Delete Handled");

                switch (a1.ControlName)
                {
                    case "SummariesList":
                        SummariesList.Delete((p) => p.Id == SelectedSummary.Id).ContinueWith((a) => SelectedSummary = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                        break;
                    case "MajorManagementConstraintsList":
                        MajorManagementConstraintsList.Delete((p) => p.Id == SelectedConstraint.Id).ContinueWith((a) => SelectedConstraint = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                        break;
                    case "ConservationFeaturesList":
                        ConservationFeaturesList.Delete((p) => p.Id == SelectedFeature.Id).ContinueWith((a) => SelectedFeature = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                        break;
                    case "DesignationsList":
                        DesignationsList.Delete((p) => p.Id == SelectedDesignation.Id).ContinueWith((a) => SelectedDesignation = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                        break;
                }
            });



            YearsLookup = iLookupStore.GetYears().ToList<ComboBoxValue>();
            MainSpeciesLookup = iLookupStore.GetMainSpeciesDTOs().ToList<ComboBoxValue>();
            ManagementRegionsLookup = iLookupStore.GetManagementRegimeDTOs().ToList<ComboBoxValue>();

            
            ManagementConstraintTypesLookup = new List<ComboBoxValue>();

            foreach (var comboBoxValue in iLookupStore.GetManagementConstraints(0))
            {
                ManagementConstraintTypesLookup.Add(new ComboBoxValue()
                {
                    ID = comboBoxValue.ID,
                    Description = comboBoxValue.Description,
                    Name = comboBoxValue.Name
                });
            }



            ConservationTypesLookup = iLookupStore.GetConservationFeatures(0).ToList<ComboBoxValue>();
           
            
        }

        private void AddSummary()
        {
            var newRecord = new SummaryEditList();
            newRecord.Make(new SummaryDto()
            {
                ManagementRegime = ManagementRegionsLookup.FirstOrDefault(),
                MainSpecies = MainSpeciesLookup.FirstOrDefault(),
                SecondarySpecies = MainSpeciesLookup.FirstOrDefault(),
                YearLookup = YearsLookup.FirstOrDefault(),                
            });
            SummariesList.AddItem(newRecord, true);
            SelectedSummary = newRecord;
        }

        private void AddConstraint()
        {
            if (SummariesList.ChangeCount > 0) return;

            if (ManagementConstraintTypesLookup.Count == 0) return;


            var newRecord = new SummaryConstraintEditList();

            newRecord.Make(new SummaryConstraintDto()
            {
               Type = ManagementConstraintTypesLookup.FirstOrDefault(),
               TypeID = ManagementConstraintTypesLookup.FirstOrDefault().ID
            });

          //  newRecord.Make(new SummaryConstraintDto());
            MajorManagementConstraintsList.AddItem(newRecord, true);
            SelectedConstraint = newRecord;
        }

        private void AddFeature()
        {
            if (SummariesList.ChangeCount > 0) return;

            var newRecord = new SummaryFeatureEditList();
            newRecord.Make(new SummaryFeatureDto()
            {
                FeatureId = this.ConservationTypesLookup.First().ID,
                Feature = this.ConservationTypesLookup.First(),
                Description = "",                
            });
            ConservationFeaturesList.AddItem(newRecord, true);
            SelectedFeature = newRecord;
        }

        private void AddDesignation()
        {
            if (SummariesList.ChangeCount > 0) return;

            var newRecord = new SummaryDesignationEditList();
            newRecord.Make(new SummaryDesignationDto()
            {
                Description = this.DesignationsLookup.FirstOrDefault(),                
            });
            DesignationsList.AddItem(newRecord, true);
            SelectedDesignation = newRecord;
        }

        public ICommand PAWSMap { get; }
        public ICommand CompartmentMap { get; }

        public IHiddenPanel LongTermPolicy { get; }

        public IHiddenPanel SummaryDescription { get; }
        
       



        public List<ComboBoxValue> YearsLookup { get; set; }
        public List<ComboBoxValue> MainSpeciesLookup { get; set; }
 
        public List<ComboBoxValue> ManagementRegionsLookup { get; set; }
        public List<ComboBoxValue> ManagementConstraintTypesLookup { get; set; }
        public List<ComboBoxValue> ConservationTypesLookup { get; set; }
        public List<ComboBoxValue> DesignationsLookup { get; set; }
    }
}