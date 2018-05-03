using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.InternalAudits;
using Abstractions.Navigation;

using Abstractions.Stores.Content.InternalAudits;
using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.InternalAudits;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.InternalAudits
{
    public class InternalAuditEditModel : GeneralModelBase, IInternalAuditEditorModel
    {

        private IInternalAuditStore _internalAuditStore;

        private InternalAuditsEditEdit _internalAuditsEditDto;

        public ExtRangeCollection<InternalAuditsObservationEditEdit> Records { get; set; }

        public InternalAuditsObservationEditEdit EditRecord { get; set; }


        public ICommand Publish { get; }

        public ICommand AutheriseCorrect { get; }

        public ICommand CertifyCorrect { get; }

        private int _internalAuditID;

        public InternalAuditEditModel(IInternalAuditStore internalAuditStore, IWTTimer iWTimer,
            IPlatformEventHandling iPlatformEventHandling, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<InternalAuditsObservationEditEdit>(iDialogService);

            _internalAuditStore = internalAuditStore;

            this.InternalAuditsEditDto = new InternalAuditsEditEdit();

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        var record = _internalAuditStore.GetInternalAuditsEditDtos(State.RecordId);

                        InternalAuditsEditDto.Make(record);

                        var auditRecords = _internalAuditStore.GetInternalAuditsObservationList(record.Id);

                        
                        Records.ReplaceRange(InternalAuditsObservationEditEdit.MakeCollection(auditRecords));

                        OnPropertyChanged("Records");

                        break;
                }

            };
         

        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            //not related to messages as such
            //just put it here because this is frequently triggered
        
            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            switch (message.EdEvent)
            {
                case EdEvent.SaveButtonClicked:
                    //      Debug.WriteLine("ext desig sav: ");
               //     _iDesignationStore.UpdateExternalDesignation(Records.Select(c => c.ConvertToDto()).ToList(), ParentAcquistionUnit.Id.Value);
                    OnPropertyChanged("LocalId");
                    break;
                    

                case EdEvent.BackButtonClicked:
                    if (IsCorrectInstance())
                        _iNavigation.GoBack();
                    break;

                case EdEvent.DeleteButtonClicked:
                    if (IsCorrectInstance())
                    {
                        Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith(
                            (a) =>
                            {
                         //       _iDesignationStore.UpdateExternalDesignation(Records.Select(c => c.ConvertToDto()).ToList(), ParentAcquistionUnit.Id.Value);

                                OnPropertyChanged("LocalId");

                                return EditRecord = a.Result;
                            }, TaskScheduler.FromCurrentSynchronizationContext());


                    }

                    break;
                case EdEvent.AddButtonClicked:
                    if (IsCorrectInstance())
                        AddNew();
                    break;
            }

        }

        protected void AddNew()
        {


            var newRec = new InternalAuditsObservationEditEdit()
            {
                
            };

            //var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            //reclist.Add(newRec);

            //_iDesignationStore.UpdateExternalDesignation(reclist, ParentAcquistionUnit.Id.Value);

            //OnPropertyChanged("LocalId");

        }

        public override void Dispose()
        {
          
            Records.Dispose();
            Records = null;
            base.Dispose();
        }

        public int InternalAuditID
        {
            get => _internalAuditID;

            set
            {
                _internalAuditID = value;
                OnPropertyChanged();
            }
        }

        public InternalAuditsEditEdit InternalAuditsEditDto
        {
            get => _internalAuditsEditDto;

            set
            {
                _internalAuditsEditDto = value;
                OnPropertyChanged();

            }
        }
    }

}
