using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.ManagementPlans
{

    public class SalesOrderEditorModel : GeneralModelBase, ISalesOrderEditorModel
    {
        private readonly IUserPermissions _iUserStore;

        private IncomeEdit _selectedIncomeEdit;
   
        public ExtRangeCollection<IncomeEdit> IncomesFlip { get; set; }

        public IncomeEdit SelectedIncomeEdit
        {
            get => _selectedIncomeEdit;

            set => SetProperty(ref _selectedIncomeEdit, value);
        }

        public SalesOrderEditorModel(ISalesStore salesStore, IPlatformEventHandling iPlatformEventHandling,object iDialogService, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, IUserPermissions iUserStore,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iUserStore = iUserStore;

            IncomesFlip = new ExtRangeCollection<IncomeEdit>(iDialogService);
            
            IncomesFlip.OnValidation += (obj,args) =>
            {
                var a = (ValidationArgs) args;
                this.SaveEnabled = a.IsValidToSave;
                this.DelEnabled = a.IsValidToDelete;
            };
            
            PropertyChanged += (sender, e) =>
            {                
                if (e.PropertyName == "State")
                {
                  

                    IncomesFlip.ReplaceRange(IncomeEdit.MakeCollection(salesStore.GetIncomes(ParentID)));
                    SelectedIncomeEdit = IncomesFlip?.First();
                    SaveEnabled = false;

                    if (State.NewRecord)
                    {
                        State.NewRecord = false;

                        AddNew();
                    }
                    
                }
            };

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                IncomesFlip.Delete(p => p.Id == SelectedIncomeEdit.Id).ContinueWith((a) => SelectedIncomeEdit = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

                if (!IncomesFlip.Errors())
                    salesStore.UpdateIncomes(IncomesFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);


            });

            SaveCommand = new RelayCommand((x) =>
            {
                //     if (!_iUserStore.Check(UserActions.GroupB)) return;


                if (!IncomesFlip.Errors())
                {
                    salesStore.UpdateIncomes(IncomesFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);

                    State.NewRecord = false;
                    OnPropertyChanged("State");
                }


            });

            DuplicateCommand = new RelayCommand((x) =>
            {
                IncomesFlip.AddDuplicate(SelectedIncomeEdit, 1);
            });

            DuplicateSingleCommand = new RelayCommand((x) =>
            {
                IncomesFlip.AddDuplicate(SelectedIncomeEdit, 2);
            });

            DuplicateFourCommand = new RelayCommand((x) =>
            {
                IncomesFlip.AddDuplicate(SelectedIncomeEdit, 4);
            });

            AddTreesCommand = new RelayCommand((x) =>
            {

            });

            CancelCommand = new RelayCommand((x) =>
            {
                IncomesFlip.Rollback();
            });
        }

    

        private void AddNew()
        {
            var newRecord = new IncomeEdit();
            newRecord.Make(new IncomeDto());


            IncomesFlip.AddItem(newRecord, true);

            SelectedIncomeEdit = newRecord;
        }
    }
}