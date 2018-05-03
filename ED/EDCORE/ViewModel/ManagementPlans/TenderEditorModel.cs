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
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class TenderEditorModel : GeneralModelBase, ITenderEditorModel
    {
        private SupplierDto _selectedSupplier;

        public IPurchasesStore _purchasesStore;
        private ICache _cache;
        private TenderExpenditureEditList _editRecord;
        public ExtRangeCollection<TenderExpenditureEditList> Records { get; set; }

        public ObservableRangeCollection<ComboBoxValue> VatRates { get; set; } = new ObservableRangeCollection<ComboBoxValue>();

        public TenderExpenditureEditList EditRecord {
            get => _editRecord;

            set
            {
                _editRecord = value;
                OnPropertyChanged();
            }
        }

        public TenderEdit Tenure { get; set; } = new TenderEdit();
        public SupplierDto SelectedSupplier {

            get => _selectedSupplier;

            set
            {
                _selectedSupplier = value;

                OnPropertyChanged();
            }

        }
        public List<SupplierDto> SupplierList { get; set; }
        public ICommand RemoveFromTender { get; set; }
        public ICommand PrintTender { get; set; }
        public ICommand SubmitOrder { get; set; }

        public TenderEditorModel(IPurchasesStore iPurchasesStore, ILookupStore iLookupStore,
            IPlatformEventHandling iPlatformEventHandling,
            object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus, IWTTimer timer,
            ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, timer, iNavigation, iPageMessageBus, iTelerikConvertors,
            iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
            _purchasesStore = iPurchasesStore;
            _cache = iCache;

            Records = new ExtRangeCollection<TenderExpenditureEditList>(iDialogService);

            SupplierList = new List<SupplierDto>();

            SupplierList = _purchasesStore.GetSuppliers();

            VatRates.ReplaceRange(iLookupStore.GetTaxRates());

            RemoveFromTender = new RelayCommand((x) =>
            {
               Debug.WriteLine("RemoveFromTender");



                Records.Delete(p => p.Id == EditRecord.Id).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext()); ;

            });

            PrintTender = new RelayCommand((x) =>
            {
                Debug.WriteLine("PrintTender");
            });

            SubmitOrder = new RelayCommand((x) =>
            {
                Debug.WriteLine("SubmitOrder");
            });
            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("tender saved");

                _purchasesStore.UpdateTender(Tenure.ConvertToDto(), this.ParentID, _cache.CurrentUser());

                var saveList = Records.Select(s => s.ConvertToDto()).ToList();


                _purchasesStore.UpdateTenderExpenditures(this.ParentID,saveList);

                OnPropertyChanged("State");
            });


            PropertyChanged += (sender, e) =>
            {
                //load data here

            
                switch (e.PropertyName)
                {
                    case "State":
                        var tenderDto = _purchasesStore.GetTender(this.ParentID, _cache.CurrentUser());

                        Tenure.Make(tenderDto);

                        var results = _purchasesStore.GetTenderExpenditures(this.ParentID);

                        Records.ReplaceRange(TenderExpenditureEditList.MakeCollection(results));
                        break;
                    case "SelectedSupplier":

                        this.Tenure.SupplierRef.Value = this.SelectedSupplier.Name;
                        this.Tenure.SupplierId.Value = this.SelectedSupplier.Id;

                        this.OnPropertyChanged("Tenure");

                        break;
                }


            };


        }


        public override void HandleMessage(EdMessage message)
        {
            //REMEMBER
            //if we override this method in a derived class 
            //then messages will need to be handled at that point
            //so for example an addcommand would need to be 
            //invoked at that point.

            //       Debug.WriteLine("received on: "+ InstanceID);

            if (this._disposed)
            {
                Debug.WriteLine("Message received on disposed object:" + InstanceID);
                return;
            }

            InstanceData messageInstanceData = message.Data as InstanceData;

            if (message.BaseIgnore) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;


            // so unless its an instance changed event. ie we are changing the focused (the instance variable) control 
            // then we want to check the buttons are being clicked on the focused instance.
 

            switch (message.EdEvent)
            {

                case EdEvent.SaveButtonClicked:
                    SaveCommand?.Execute(message.Data);
                    break;
        
            }
        }

    }
}
