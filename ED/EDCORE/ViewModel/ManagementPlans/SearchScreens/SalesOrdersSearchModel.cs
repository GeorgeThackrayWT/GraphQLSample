using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.lookups;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{


    public class SalesOrdersSearchModel : SearchModelBase<SalesOrdersListDTO>, ISalesOrdersSearchModel
    {
        private ILookupStore _iLookupStore;
        private ISalesStore _iSalesStore;
        private int _selectedSoGenOptions;

        public SalesOrdersSearchModel(ISalesStore iSalesStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _iSalesStore = iSalesStore;

            _iLookupStore = iLookupStore;

            InstanceID = GetType().Name + Guid.NewGuid();

            PropertyChanged += (sender, e) =>
            { 
                switch (e.PropertyName)
                {
                    case "SelectedSoGenOptions":
                        

                        GetData(iCache, _iLookupStore, _iSalesStore);

                        break;
                }

            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.SalesOrder.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });


            GetData(iCache, _iLookupStore, _iSalesStore);

        }

        private void GetData(ICache iCache, ILookupStore iLookupStore, ISalesStore salesStore)
        {
            var salesOrderDateOptionsDtos = iLookupStore.GetSalesOrderDateOptionsDtos();

            var option = salesOrderDateOptionsDtos.FirstOrDefault(s => s.ID == _selectedSoGenOptions);


            if (option != null)
            {
                var salesOrders = salesStore.GetSalesOrdersListDtos(option.OrdersSelectionCriterion, iCache.CurrentUserRole(), iCache.CurrentUser(),
                    iCache.GetApplication(), iCache.CurrentUserRegion());

                SearchData = new ObservableRangeCollection<SalesOrdersListDTO>();
                SearchData.ReplaceRange(salesOrders);

                if (SearchData.Count > 0)
                    this.SelectedRecord = SearchData.First();
            }
            else
            {
                var items = salesStore.GetSalesOrdersListDtos(OrdersSelectionCriterion.CurrentYear, iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(), iCache.CurrentUserRegion());

                SearchData = new ObservableRangeCollection<SalesOrdersListDTO>();
                SearchData.ReplaceRange(items);

                if (items.Count > 0)
                    this.SelectedRecord = items.First();

            }

            OnPropertyChanged("SearchData");
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iCache, _iLookupStore, _iSalesStore);
            }
            else
            {
                base.HandleMessage(message);
            }
        }

        public int SelectedSoGenOptions
        {
            get { return _selectedSoGenOptions; }

            set
            {
                if (_selectedSoGenOptions != value)
                {                   
                    _selectedSoGenOptions = value;

                    OnPropertyChanged();
                }

            }
        }
    }
}