using System;
using Abstractions;
using Abstractions.Models.Safety.Editors;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class SafetyActionModel : GeneralModelBase, ISafetyActionModel
    {
        private int _hazardID;

        private ISafetyStore _safetyStore;

        private HazardActionDto _hazardActionDto;

        private ObservableRangeCollection<HazardActionDto> _hazardCollection;

        public ObservableRangeCollection<HazardActionDto> HazardActions { get; set; } = new ObservableRangeCollection<HazardActionDto>();


        public SafetyActionModel(IWTTimer iWTimer, ISafetyStore safetyStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _safetyStore = safetyStore;
 
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "HazardID")
                {
                    if (HazardID != 0)
                    {
                        var result = _safetyStore.GetHazardActionDtos(HazardID);
                        HazardActions.ReplaceRange(result);
                    }

                }

            };
        }


        public int HazardID
        {
            get
            {
                return _hazardID;
            }
            set
            {
                if (_hazardID == value) return;
                _hazardID = value;

                OnPropertyChanged();
            }
        }

        public int ID { get; set; }

        public HazardActionDto SelectedHazardActionDto
        {
            get { return _hazardActionDto; }
            set
            {
                if (_hazardActionDto == value) return;

                _hazardActionDto = value;

                OnPropertyChanged();
            }
        }
    }
}