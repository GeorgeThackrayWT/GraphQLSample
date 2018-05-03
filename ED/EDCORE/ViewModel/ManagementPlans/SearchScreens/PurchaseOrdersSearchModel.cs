using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.lookups;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{

    public class PurchaseOrdersSearchModel : SearchModelBase<PurchaseOrderListDTO>, IPurchaseOrdersSearchModel
    {
        private readonly IPurchasesStore _purchasesStore;

        private List<PurchaseOrderListDTO> _purchaseOrderBoundObject =  new List<PurchaseOrderListDTO>();

        private List<PurchaseOrderListDTO> _purchaseOrderListCache = new List<PurchaseOrderListDTO>();


        private List<PurchaseOrderDateOptionsDTO> _purchaseOrderDateOptions = new List<PurchaseOrderDateOptionsDTO>();

        private int _selectedPOGenOption;

        private string _tenderName;

        private TenderDto _selectedTender;

        public List<TenderDto> TenderList { get; set; }
        

        public PurchaseOrdersSearchModel(IPurchasesStore iPurchasesStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {

            SearchData.Add(new PurchaseOrderListDTO());

            Links = iManagementPlanLinkContainer;

            InstanceID = GetType().Name + Guid.NewGuid();

            _purchasesStore = iPurchasesStore;


            _purchaseOrderDateOptions = iLookupStore.GetPurchaseOrderDateOptionsDtos();
             

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "SelectedPoGenOptions")
                {
                    GetData(iCache);
                }

                if (e.PropertyName == "SelectedPoGenOptions")
                {

                }

                if (e.PropertyName == "SelectedTender")
                {
                    Debug.WriteLine("Selected Tender changed: " + _selectedTender.Id);

                    OnPropertyChanged("TenderName");
                }


                if (e.PropertyName == "SelectedRecords")
                {
                    var latestSelection = this.SelectedRecords.LastOrDefault(l=>l.TenderName!="");

                    if (latestSelection != null)
                    {
                        var selection = TenderList.FirstOrDefault(f => f.TenderNumber == latestSelection.TenderName);

                        if (selection != null)
                        {
                            SelectedTender = selection;
                        }
                    }

                }

                if (e.PropertyName == "SelectedRecord")
                {
                    Debug.WriteLine("SelectedRecord:" + _selectedRecord.TenderName);
                }
            };

            LoadData = new RelayCommand((x) =>
            {
                _iNavigation.Navigate(iManagementPlanLinkContainer.PurchaseOrder.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });


            AddLine = new RelayCommand((x) =>
            {
                if (_selectedTender != null)
                {
                    Debug.WriteLine(_selectedTender.Id);

                    _purchasesStore.AddToTender(_selectedTender.Id, SelectedRecords.Select(s=>s.Id).ToList());
                    GetData(iCache);
                }
                else
                {
                    Debug.WriteLine("no selected tender");
                }
            });

            RemoveLine = new RelayCommand((x) =>
            {
                if (_selectedTender != null)
                {
                    _purchasesStore.RemoveFromTender(_selectedTender.Id, SelectedRecords.Select(s => s.Id).ToList());
                    GetData(iCache);
                }
                else
                {
                    Debug.WriteLine("no selected tender");
                }
            });

            SelectAllLines = new RelayCommand((x) =>
            {

            });

            DeSelectAllLines = new RelayCommand((x) =>
            {

            });





            GetData(iCache);
        }

        private void GetData(ICache iCache)
        {
            var poOption = _purchaseOrderDateOptions.FirstOrDefault(f => f.ID == _selectedPOGenOption);

            if (poOption != null)
            {
                _purchaseOrderListCache =
                    _purchasesStore.GetPurchaseOrderListDtos(poOption.OrdersSelectionCriterion, iCache.CurrentUserRole(), iCache.CurrentUser(),
                        iCache.GetApplication(), iCache.CurrentUserRegion());
            }
            else
            {
                _purchaseOrderListCache = _purchasesStore.GetPurchaseOrderListDtos(OrdersSelectionCriterion.CurrentYear, iCache.CurrentUserRole(), iCache.CurrentUser(),
                    iCache.GetApplication(), iCache.CurrentUserRegion());

            }

            SearchData = new ObservableRangeCollection<PurchaseOrderListDTO>();
            SearchData.ReplaceRange(_purchaseOrderListCache);

            if (SearchData.Count > 0)
                SelectedRecord = SearchData.First();

            TenderList = _purchasesStore.GetTenders();

            if (TenderList.Count > 0)
            {
                SelectedTender = TenderList.First();
            }

            OnPropertyChanged("SearchData");
        }


        public int SelectedPoGenOptions
        {
            get
            {
                return _selectedPOGenOption;
            }

            set
            {
                _selectedPOGenOption = value;
                OnPropertyChanged();
            }
        }

        public TenderDto SelectedTender
        {
            get
            {
                return _selectedTender;
            }

            set
            {
                _selectedTender = value;
                OnPropertyChanged();
            }
        }

        public string TenderName => SelectedTender != null ? SelectedTender.TenderNumber : "";

        public ILinkContainer Links { get; set; }
        public ICommand AddLine { get; set; }
        public ICommand RemoveLine { get; set; }
        public ICommand SelectAllLines { get; set; }
        public ICommand DeSelectAllLines { get; set; }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}