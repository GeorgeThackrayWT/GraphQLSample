using System;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class PurchaseOrderEditorModel : GeneralModelBase, IPurchaseOrderEditorModel
    {
        private readonly IUserPermissions _iUserStore;

        private ExpenditureEdit _selectedExpenditureEditDto;

        public ExtRangeCollection<ExpenditureEdit> ExpenditureFlip { get; set; }
      
        public ExpenditureEdit SelectedExpenditureEditDto
        {
            get => _selectedExpenditureEditDto;

            set => SetProperty(ref _selectedExpenditureEditDto, value);
        }

        public PurchaseOrderEditorModel(IPurchasesStore purchasesStore, IPlatformEventHandling iPlatformEventHandling, IUserPermissions iUserStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iUserStore = iUserStore;

            ExpenditureFlip = new ExtRangeCollection<ExpenditureEdit>(iDialogService);

            ExpenditureFlip.OnValidation += (obj, args) =>
            {
                var a = (ValidationArgs)args;
                this.SaveEnabled = a.IsValidToSave;
                this.DelEnabled = a.IsValidToDelete;
            };


            PropertyChanged += (sender, e) =>
            {
                //load data here        
                if (e.PropertyName == "State")
                {                    
                    ExpenditureFlip.ReplaceRange(ExpenditureEdit.MakeCollection(purchasesStore.GetExpenditures(ParentID)));

                    SelectedExpenditureEditDto = ExpenditureFlip?.First();

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
                var newRecord = new ExpenditureEdit();
                newRecord.Make(new ExpenditureDto());

                ExpenditureFlip.AddItem(newRecord, true);
            });

            DeleteCommand = new RelayCommand((x) =>
            {
                ExpenditureFlip.Delete((p) => p.Id.Value == SelectedExpenditureEditDto.Id.Value).ContinueWith((a) => SelectedExpenditureEditDto = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

                if (!ExpenditureFlip.Errors())
                    purchasesStore.UpdateExpenditures(ExpenditureFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);
            });

            SaveCommand = new RelayCommand((x) =>
            {
                //    if (!_iUserStore.Check(UserActions.GroupB)) return;
                if (!ExpenditureFlip.Errors())
                {
                    purchasesStore.UpdateExpenditures(ExpenditureFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);

                    State.NewRecord = false;
                    OnPropertyChanged("State");
                }
            });

            DuplicateCommand = new RelayCommand((x) =>
            {
                ExpenditureFlip.AddDuplicate(SelectedExpenditureEditDto, 1);
            });

            DuplicateSingleCommand = new RelayCommand((x) =>
            {
                ExpenditureFlip.AddDuplicate(SelectedExpenditureEditDto, 2);
            });

            DuplicateFourCommand = new RelayCommand((x) =>
            {
                ExpenditureFlip.AddDuplicate(SelectedExpenditureEditDto, 4);
            });

            AddTreesCommand = new RelayCommand((x) =>
            {

            });

            CancelCommand = new RelayCommand((x) =>
            {
                ExpenditureFlip.Rollback();
            });


        }


        private void AddNew()
        {
            var newRecord = new ExpenditureEdit();
            newRecord.Make(new ExpenditureDto());


            ExpenditureFlip.AddItem(newRecord, true);

            SelectedExpenditureEditDto = newRecord;
        }



    }
}