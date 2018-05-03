using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class GrantContractsEditorModel : FlipModelBase<GrantContractEditorEdit>, IGrantContractsEditorModel
    {
        public ExtRangeCollection<PaymentSummaryDTOEditList> GrantPaymentsEditList { get; set; }


        protected IGrantStore _grantStore;
        protected ILookupStore _iLookupStore;

        public GrantContractsEditorModel(IWTTimer iWTimer, IGrantStore iGrantStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, IUserPermissions iUserStore, object iDialogService,
            ICache iCache) : base( iWTimer, iPlatformEventHandling, iUserStore, iDialogService, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iLookupStore = iLookupStore;

            RecordsFlip = new ExtRangeCollection<GrantContractEditorEdit>(iDialogService);

            GrantPaymentsEditList = new ExtRangeCollection<PaymentSummaryDTOEditList>(iDialogService);

            RecordsFlip.OnCollectionUpdated += (object obj, string field) =>
            {
                Debug.WriteLine("OnCollectionUpdated: " + field);
                 
                switch (field)
                {
                    case "CheckedBy":
                        this.EditRecord.CheckedByOn.Value = DateTime.Today;
                        break;
                    case "AuthorisedBy":
                        this.EditRecord.AuthorisedByOn.Value = DateTime.Today;
                        break;
                    case "ArchivedBy":
                        this.EditRecord.ArchivedByOn.Value = DateTime.Today;
                        break;

                }

                OnPropertyChanged("EditRecord");
            };
            
            _grantStore = iGrantStore;

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":                        
                        RecordsFlip.ReplaceRange(GrantContractEditorEdit.MakeCollection(_grantStore.GetGrantContract(ParentID)));

                        if (RecordsFlip.Count > 0)
                        {
                            EditRecord = RecordsFlip.First();
                        }
                        else
                        {
                            AddNew();
                        }
                        break;

                    case "EditRecord":
                        GrantPaymentsEditList.ReplaceRange(PaymentSummaryDTOEditList.MakeCollection(_grantStore.GetGrantPayments(this.EditRecord.RecordId)));
                        break;
                        
                }
                //load data here
                                 
            };

            AddCommand = new RelayCommand((x) =>
            {
                var data = (InstanceData) x;

                Debug.WriteLine("AddCommand: " + data.ControlName + " " + data.Element + " " + data.InstanceID);

                //remember we cant add  payments here only grants!
                AddNew();


            });


            SaveCommand = new RelayCommand((x) =>
            {
                var data = (InstanceData)x;

                Debug.WriteLine("SaveCommand: " + data.ControlName + " " + data.Element + " " + data.InstanceID);
                
                _grantStore.UpdatePayments(GrantPaymentsEditList.Select(v => v.ConvertToDto()).ToList(), ParentID);
                _grantStore.UpdateGrants(RecordsFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                var data = (InstanceData)x;

                if (data.Element == "paymentsGrid")
                {
                    //RecordsFlip.Delete()
                    GrantPaymentsEditList.Delete(p => p.RecordId == GrantPaymentsEditRecord.RecordId).ContinueWith((a) => GrantPaymentsEditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                    

                }
                else
                {
                    RecordsFlip.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                }
               
            });

        }

      


        protected override void AddNew()
        {
            var defaultGrant = _iLookupStore.GetGrantBodies().First(i => i.ID != 0);
            var defaultAward = _iLookupStore.GetSchemes().First(i => i.ID != 0);
          
            var reclist = RecordsFlip.Select(s => s.ConvertToDto()).ToList();
          
            var newRec = new GrantContractEditorDto()
            {
                SchemeId = defaultAward.ID,
                GrantBodyId = defaultGrant.ID
            };

            reclist.Add(newRec);

            _grantStore.UpdateGrants(reclist, ParentID);

            RecordsFlip.ReplaceRange(GrantContractEditorEdit.MakeCollection(_grantStore.GetGrantContract(ParentID)));

            EditRecord = RecordsFlip.Last();
        }





        public PaymentSummaryDTOEditList GrantPaymentsEditRecord { get; set; }

  //      public PaymentSummaryDTOEditList EditRecord { get; set; }
        public ICommand LoadData { get; }
    }
}