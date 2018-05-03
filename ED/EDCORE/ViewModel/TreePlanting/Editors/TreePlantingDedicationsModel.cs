using System;
using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using DataObjects.DTOS.TreePlanting;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class TreePlantingDedicationsModel : GeneralModelBase, ITreePlantingDedicationsModel
    {
        private TreePlantDedicationsDto _selectedRow;
        private TreePlantEditList _treePlantingID;

        private ITreePlantingStore _treePlantingStore;

        public TreePlantEditList TreePlantingID
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

        public ObservableRangeCollection<TreePlantDedicationsDto> Dedications { get; set; } = new ObservableRangeCollection<TreePlantDedicationsDto>();



        public TreePlantingDedicationsModel(IWTTimer iWTimer, ITreePlantingStore safetyStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _treePlantingStore = safetyStore;

          
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "TreePlantingID")
                {
                    if (TreePlantingID.Id != 0)
                    {
                        var result = _treePlantingStore.GetTreePlantDedicationsDtos(TreePlantingID.Id);
                        Dedications.ReplaceRange(result);
                    }

                }

            };


        }


        public TreePlantDedicationsDto SelectedDedication
        {
            get
            {
                if (Dedications.Count == 0)
                {
                    return null;
                }
                else
                {
                    return _selectedRow ?? Dedications[0];
                }

            }

            set
            {
                if (_selectedRow == value) return;
                _selectedRow = value;

                OnPropertyChanged();
            }
        }

    }
}