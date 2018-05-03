using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.PublicInformation;
using Abstractions.Navigation;
using Abstractions.Stores.Content.PublicInformation;
using DataObjects;
using DataObjects.DTOS.PublicInformationDtos;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.PublicInformation
{


    public class PublicInformationSearchModel : SearchModelBase<PublicInformationSearchDto>, IPublicInformationSearch<PublicInformationSearchDto>
    {
        private IPublicInformationStore _iSafetyStore;
        private bool _directionVisible;
        private string _directionsDescription;
   
        public PublicInformationSearchModel(IWTTimer iWTimer, IPublicInformationStore iSafetyStore, IPlatformEventHandling iPlatformEventHandling, 
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

            _iSafetyStore = iSafetyStore;

            GetData(_iSafetyStore, iCache);

            LoadData = new RelayCommand((x) =>
            {
                var column = iTelerikConvertors.GetCellColumnName(x);

                if (column == "map" || column == "view")
                {

                }
                else
                {
                    _iNavigation.Navigate(iLinkContainer.PublicInfoEditor.Editor(), StateContainer.Create(SelectedRecord.ID, false));
                }
                
            });

            ViewDirections = new RelayCommand((x) =>
            {
                var selection = (PublicInformationSearchDto)iTelerikConvertors.GetCellItem(x);
                var column = iTelerikConvertors.GetCellColumnName(x);

                if (column == "view")
                {
                    DirectionsFieldVisible = !DirectionsFieldVisible;


                    DirectionsDescription = selection.DirectionDescription;
                }

                Debug.WriteLine("View Directions: " + column);
            });

            ViewLocations = new RelayCommand((x) =>
            {
                var selection = _iTelerikConvertors.GetCellItem(x);
                var column = _iTelerikConvertors.GetCellColumnName(x);

                if (column == "map")
                {
                    // go to url here
                }

                Debug.WriteLine("View Locations");
            });
        }

        private void GetData(IPublicInformationStore iSafetyStore, ICache iCache)
        {
            SearchData = new ObservableRangeCollection<PublicInformationSearchDto>();

            SearchData.AddRange(iSafetyStore.GetPublicInformationDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion()));

            OnPropertyChanged("SearchData");
        }


        public ICommand ViewDirections { get; set; }

        public ICommand ViewLocations { get; set; }

        public bool DirectionsFieldVisible
        {
            get
            {
                return _directionVisible;
            }

            set
            {
                _directionVisible = value;
                OnPropertyChanged();
            }
        }

        public string DirectionsDescription
        {
            get
            {
                return _directionsDescription;
            }

            set
            {
                _directionsDescription = value;
                OnPropertyChanged();
            }
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iSafetyStore, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}
