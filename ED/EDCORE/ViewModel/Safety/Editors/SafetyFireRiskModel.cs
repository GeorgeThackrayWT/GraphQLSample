using System;
using System.Diagnostics;
using Abstractions;
using Abstractions.Models.Safety.Editors;
using Abstractions.Navigation;
using Abstractions.Stores.Content.Safety;
using DataObjects.DTOS.SafetyObjects.Editors;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Safety.Editors
{
    public class SafetyFireRiskModel : GeneralModelBase, ISafetyFireRiskModel
    {
        private int _hazardID;

        private ISafetyStore _safetyStore;

        private FireRiskCollectionEdit _fireRisksCollection;

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

        public FireRiskCollectionEdit Record
        {
            get => _fireRisksCollection;
            set
            {
                if (_fireRisksCollection == value) return;

                _fireRisksCollection = value;

                OnPropertyChanged();
            }
        }

        public SafetyFireRiskModel(IWTTimer iWTimer, ISafetyStore safetyStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _safetyStore = safetyStore;

            Record = new FireRiskCollectionEdit();
         
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "HazardID")
                {
                    if (HazardID != 0)
                    {
                        Debug.WriteLine("fire risk model id: " + HazardID);

                        var result = _safetyStore.GetFireRiskCollectionDto(HazardID);

                        Record.Make(result);

                        OnPropertyChanged("Record");
                    }

                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("test fire safety save");
             //   _safetyStore.UpdateRiskAssessment(ParentID, Record.ConvertToDto());

             
            });


        }
    }
}