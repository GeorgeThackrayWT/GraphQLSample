using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.Safety.Editors;
using Abstractions.Navigation;

using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;
using MvvmHelpers;

namespace EDCORE.ViewModel.TreePlanting.Editors
{
    public class TreePlantingEditorModel : GeneralModelBase, ITreePlantingEditorModel
    {


        private TreePlantEditList _selectedRow;

        private ITreePlantingStore _iTreePlantingStore;

        public ObservableRangeCollection<ComboBoxValue> PlantedByLookup { get; } = new ObservableRangeCollection<ComboBoxValue>();

        public ObservableRangeCollection<ComboBoxValue> PlantingTypeLookup { get; } = new ObservableRangeCollection<ComboBoxValue>();

        public ObservableRangeCollection<SubCompartmentLookupDto> SubCompartmentsLookup { get; } = new ObservableRangeCollection<SubCompartmentLookupDto>();


        public ExtRangeCollection<TreePlantEditList> Records { get; set; }

      

        public ICommand LoadData { get; protected set; }

        public TreePlantingEditorModel(IWTTimer iWTimer,ITreePlantingStore iTreePlantingStore, IPlatformEventHandling iPlatformEventHandling,
                                       INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
                                       ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();


            Records = new ExtRangeCollection<TreePlantEditList>(iDialogService);

            _iTreePlantingStore = iTreePlantingStore;

            PlantedByLookup.ReplaceRange(_iTreePlantingStore.GetPlantedByDtos());

            PlantingTypeLookup.ReplaceRange(_iTreePlantingStore.GetPlantTypeDtos());

            SubCompartmentsLookup.ReplaceRange(_iTreePlantingStore.GetSubCompartmentLookupDtos());

            PropertyChanged += (sender, e) =>
            {
                //load data here

                switch (e.PropertyName)
                {
                    case "State":
                        Debug.WriteLine("loading tree planting editor");
                        var tp = _iTreePlantingStore.GetTreePlantDtos(ParentID);                        
                        Records.ReplaceRange(TreePlantEditList.MakeCollection(tp));
                        break;
                    default:
                        break;
                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                _iTreePlantingStore.UpdateTreePlantDtos(ParentID, Records.Select(s => s.ConvertToDto()).ToList());
            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
            
            });

            RefreshParent = new RelayCommand((x) =>
            {
                if(x.ToString()=="TREEPLANTING")
                    OnPropertyChanged("State");
            });

            LoadData = new RelayCommand((x) =>
            {

            });
        }

        protected void AddNew()
        {            
            var newRecord = new TreePlantEditList();
            newRecord.Make(new TreePlantDto()
            {
                AreaHa                    = 0.0,
                PlantedByID = PlantedByLookup.First(f=>f.ID!=0),
                PlantingTypeID = PlantingTypeLookup.First(a=>a.ID!=0),
                SubCompartmentID = SubCompartmentsLookup.FirstOrDefault(b=>b.Id!=0)
            });

            Records.AddItem(newRecord, true);

            EditRecord = newRecord;
            
        }

        public TreePlantEditList EditRecord
        {
            get
            {
                if (Records.Count == 0)
                {
                    return null;
                }
                else
                {
                    return _selectedRow ?? Records[0];
                }
                
            }

            set
            {
                if (_selectedRow == value) return;
                _selectedRow = value;

                // _hazardFireRiskSelection = new HazardFireRiskSelection(_selectedRow);

                OnPropertyChanged();
            }
        }

        
         
    }
}
