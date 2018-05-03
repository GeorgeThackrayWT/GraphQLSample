using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public abstract class FlipModelBase<T> : GeneralModelBase where T : class, IDuplicate, IModel, new()
    {

        private T editRecord;

        public ExtRangeCollection<T> RecordsFlip { get; set; }

        public T EditRecord
        {
            get
            {
                return editRecord;
            }

            set
            {
                if (value == null) return;

                if (editRecord != null)
                {
                    if(editRecord.RecordId == value.RecordId) return;
                }
        
                
                editRecord = value;
                OnPropertyChanged();
            }
        }

        public FlipModelBase(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, IUserPermissions iUserStore,
            object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus, 
            ITelerikConvertors iTelerikConvertors, ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,  iPageMessageBus, iTelerikConvertors, iCache)
        {
            RecordsFlip = new ExtRangeCollection<T>(iDialogService);

            RecordsFlip.OnValidation += (obj, args) =>
            {
                var a = (ValidationArgs)args;
                this.SaveEnabled = a.IsValidToSave;
                this.DelEnabled = a.IsValidToDelete;
            };

            DeleteCommand = new RelayCommand((x) =>
            {
                RecordsFlip.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
            });

            DuplicateCommand = new RelayCommand((x) =>
            {
                RecordsFlip.AddDuplicate(EditRecord, 1);
            });

            DuplicateSingleCommand = new RelayCommand((x) =>
            {
                RecordsFlip.AddDuplicate(EditRecord, 2);
            });

            DuplicateFourCommand = new RelayCommand((x) =>
            {
                RecordsFlip.AddDuplicate(EditRecord, 4);
            });

            AddTreesCommand = new RelayCommand((x) =>
            {

            });

            CancelCommand = new RelayCommand((x) =>
            {
                RecordsFlip.Rollback();
            });

            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });
        }

        protected virtual void AddNew()
        {

        }
      
    }
}