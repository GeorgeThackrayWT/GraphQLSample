using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models.ManagementPlans;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Administration.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{



    public class PesticideEditorModel : GeneralModelBase, IPesticideEditorModel
    {
        public ExtRangeCollection<PesticideEntryEditList> PesticideEntryRecords { get; set; }
        public ExtRangeCollection<PesticideAdminEdit> Records { get; set; }

        private PesticideAdminEdit _editRecord;

        private PesticideEntryEditList _pesticideEntryEditRecord;
        
        private IManagementPlanAdminEFStore _adminStore;

        private ExtRangeCollection<PesticideEntryEdit> _pesticideEntryEdits;


        public PesticideEditorModel(IManagementPlanAdminEFStore iAdminStore, IPlatformEventHandling iPlatformEventHandling,
            object iDialogService,
                    INavigation iNavigation, IPageMessageBus iPageMessageBus,  IWTTimer timer, ITelerikConvertors iTelerikConvertors,
                    ICache iCache) : base(iPlatformEventHandling, timer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<PesticideAdminEdit>(iDialogService);

            PesticideEntryRecords = new ExtRangeCollection<PesticideEntryEditList>(iDialogService);

            _adminStore = iAdminStore;

            PropertyChanged += (sender, e) =>
            {
                //load data here
              
                if (e.PropertyName == "State")
                {
                    Records.ReplaceRange(PesticideAdminEdit.MakeCollection(_adminStore.GetPesticideAdminDto(State.RecordId)) );

                    var pesticide = Records?.FirstOrDefault();

                    if (pesticide != null)
                    {
                        EditRecord = pesticide;
                    }

                }

                if (e.PropertyName == "EditRecord")
                {
                    if (EditRecord == null) return;

                    var t = _adminStore.GetPesticideEntrys(EditRecord.PesticideId.Value);

                    t.Add(new PesticideEntryDto()
                    {
                        Id = 0,
                        Operator = "hello"
                    });

                    PesticideEntryRecords.ReplaceRange(PesticideEntryEditList.MakeCollection(t));

                    var pesticideEntry = PesticideEntryRecords?.FirstOrDefault();

                    if (pesticideEntry != null)
                    {
                        PesticideEntryEditRecord = pesticideEntry;
                    }

                    OnPropertyChanged("PesticideEntryRecords");
                }

            };

            AddCommand = new RelayCommand((x) =>
            {                
                var i = (InstanceData)x;
                switch (i.Element)
                {
                    case "EntriesGrid":
                        AddPesticideEntryNew();
                        break;

                    default:
                        AddPesticideNew();
                        break;
                }
            });

            DeleteCommand = new RelayCommand((x) =>
            {                
                var i = (InstanceData)x;
                switch (i.Element)
                {
                    case "EntriesGrid":
                        PesticideEntryRecords.Delete(p => p.Id == PesticideEntryEditRecord.Id).ContinueWith((a) => PesticideEntryEditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());
                        break;

                    default:
                       
                        Records.Delete(p => p.Id == EditRecord.Id).ContinueWith((a) => EditRecord = a.Result, TaskScheduler.FromCurrentSynchronizationContext());

                        break;
                }

            });

            SaveCommand = new RelayCommand((x) =>
            {
                //     if (!_iUserStore.Check(UserActions.GroupB)) return;


                var i = (InstanceData) x;

                switch (i.Element)
                {
                    case "EntriesGrid":
                        _adminStore.UpdatePesticideEntries(this.EditRecord.RecordId, this.PesticideEntryRecords.Select(s=>s.ConvertToDto()).ToList());
                        break;
                       
                    default:
                        _adminStore.UpdatePesticides(this.ParentID, this.Records.Select(p => p.ConvertToDto()).ToList());
                        break;
                }

                Debug.WriteLine(x.ToString());


                if (!Records.Errors())
                {
                    //salesStore.UpdateIncomes(IncomesFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);

                    State.NewRecord = false;
                    OnPropertyChanged("State");
                }


            });


        }

        private void AddPesticideNew()
        {
            var newRecord = new PesticideAdminEdit();
            newRecord.Make(new PesticideAdminDto());

            Records.AddItem(newRecord, true);

            EditRecord = newRecord;
        }

        private void AddPesticideEntryNew()
        {
            var newRecord = new PesticideEntryEditList();
            newRecord.Make(new PesticideEntryDto());

            PesticideEntryRecords.AddItem(newRecord, true);

            PesticideEntryEditRecord = newRecord;
        }


        public PesticideAdminEdit EditRecord
        {
            get { return _editRecord; }

            set
            {

                if (_editRecord == value) return;

                _editRecord = value;
                OnPropertyChanged();
            }
        }

        public PesticideEntryEditList PesticideEntryEditRecord
        {
            get { return _pesticideEntryEditRecord; }

            set
            {


                _pesticideEntryEditRecord = value;
                OnPropertyChanged();
            }

        }
    }
}
