using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class PropertyModel : SearchModelBase<PropertyDto>, IPropertySearch<PropertyDto>
    {
        private IPropertyStore _iPropertyStore;
        private string _findQuery;

        public PropertyModel(IWTTimer iWTimer, IManagementUnitStore iManagementUnitStore,
            IPropertyStore iPropertyStore,
            ILinkContainer iPropertyEditPage,
            INavigation iNavigation, IPlatformEventHandling iPlatformEventHandling,
            IPageMessageBus iPageMessageBus, 
            ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation, iPageMessageBus, 
            iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iPropertyStore = iPropertyStore;

            PropertyChanged += (sender, e) =>
            {
                //if (e.PropertyName == "FindQuery")
                //{
                //    if (FindQuery != "")
                //    {
                //        var results = iManagementUnitStore.GetFilteredManagementUnits(FindQuery);

                //        FindResults.ReplaceRange(results);

                //    }
                //}
            };

            LoadData = new RelayCommand((x) =>
            {

                _iNavigation.Navigate(iPropertyEditPage.PropertyPageEditor.Editor(),
                    StateContainer.Create(_selectedRecord.CostCentre, false));
            });


            AddData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iPropertyEditPage.PropertyPageEditor.Editor(),
                    StateContainer.Create(_selectedRecord.CostCentre, true));
            });


            FindCommand = new RelayCommand((x) =>
            {
                if (FindQuery != "")
                {
                    var results = iManagementUnitStore.GetFilteredManagementUnits(FindQuery);

                    FindResults.ReplaceRange(results);

                }
            });

            SelectCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("select command: " + SelectedManagementUnitDto.Id);

                _iNavigation.Navigate(iPropertyEditPage.PropertyPageEditor.Editor(), StateContainer.Create(SelectedManagementUnitDto.Id, true));
            });


            NewComand = new RelayCommand((x) =>
            {
                Debug.WriteLine("new command");

          


                _iNavigation.Navigate(iPropertyEditPage.PropertyPageEditor.Editor(), StateContainer.Create(0, true));
            });



            GetData(_iPropertyStore, _iCache);
        }

        private void GetData(IPropertyStore iPropertyStore, ICache  iCache)
        {
          
            var items = iPropertyStore.GetPropertyList(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),iCache.CurrentUserRegion());

            

            SearchData = new ObservableRangeCollection<PropertyDto>();

            FindResults = new ObservableRangeCollection<ManagementUnitDto>();

            SearchData.ReplaceRange(items);

            OnPropertyChanged("SearchData");


            if (SearchData.Count > 0)
                this.SelectedRecord = items.First();
        }


        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iPropertyStore,_iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }

        public ObservableRangeCollection<ManagementUnitDto> FindResults { get; set; }

        public string FindQuery
        {
            get { return _findQuery; }

            set
            {
                _findQuery = value;
                OnPropertyChanged();
            }
        }

        public ICommand FindCommand { get; set; }
        public ICommand SelectCommand { get; set; }
        public ICommand NewComand { get; set; }
        public ManagementUnitDto SelectedManagementUnitDto { get; set; }
    }
}