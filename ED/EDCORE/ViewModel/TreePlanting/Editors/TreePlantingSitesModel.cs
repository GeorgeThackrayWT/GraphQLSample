using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using Abstractions.Stores.Content.Safety;
using DataObjects;
using DataObjects.DTOS.TreePlanting;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class TreePlantingSitesModel : GeneralModelBase, ITreePlantingSitesModel
    {

        private TreePlantEditList _treePlantingID;

        private TreePlantDetailEditList _selectedRow;

        private ITreePlantingStore _treePlantingStore;

        public TreePlantEditList TreePlantingId
        {
            get
            {
                return _treePlantingID;
            }

            set
            {
                _treePlantingID = value;
                OnPropertyChanged();
            }
        }

        public ExtRangeCollection<TreePlantDetailEditList> Records { get; set; } 

        public ObservableRangeCollection<TreePlantAccessDto> TreePlantAccessLookup { get; set; } = new ObservableRangeCollection<TreePlantAccessDto>();

        public ObservableRangeCollection<TreePlantTerrainDto> TreePlantTerrainLookup { get; set; } = new ObservableRangeCollection<TreePlantTerrainDto>();

        public TreePlantingSitesModel(IWTTimer iWTimer,ITreePlantingStore safetyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,   ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<TreePlantDetailEditList>(iDialogService);

            _treePlantingStore = safetyStore;

            TreePlantAccessLookup.ReplaceRange(_treePlantingStore.GetTreePlantAccessDtos());

            TreePlantTerrainLookup.ReplaceRange(_treePlantingStore.GetTreePlantTerrainDtos());
 
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "TreePlantingId")
                {
                    Debug.WriteLine("sites id:" + TreePlantingId.Id);

                    if (TreePlantingId.Id != 0)
                    {
                        var result = _treePlantingStore.GetTreePlantDetailDtos(TreePlantingId.Id);

                        Records.ReplaceRange(TreePlantDetailEditList.MakeCollection(result));
                    }

                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                _treePlantingStore.UpdateTreePlantDetailsDtos(TreePlantingId.Id, Records.Select(s => s.ConvertToDto()).ToList());

                Refresh("TREEPLANTING");
            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
               
            });


        }

        protected void AddNew()
        {
            var newRecord = new TreePlantDetailEditList();

            newRecord.Make(new TreePlantDetailDto()
            {
                AccessID = this.TreePlantAccessLookup.First(f=>f.Id !=0),
                TerrainID = this.TreePlantTerrainLookup.First(t=>t.Id!=0),
                Comments = "new comment",
                
            });

            Records.AddItem(newRecord, true);

            EditRecord = newRecord;

        }

        public TreePlantDetailEditList EditRecord
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