using System;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;
using System.Threading.Tasks;


namespace EDCORE.ViewModel.Property
{
    public class InternalDesignationsModel : GeneralModelBase, IInternalDesignationsModel
    {
      
        private ILookupStore _iLookupStore;

        private IDesignationStore _designationStore;
            
        private InternalDesignationEdit _designatorDto ;
        private AUIDEdit _parentAcquistionUnit;

        private int _localId = 0;


        public int LocalId
        {
            get => _localId;
            set
            {
                _localId = value;
                OnPropertyChanged();
            }
        }

        public ExtRangeCollection<InternalDesignationEdit> Records { get; set; }

        
        public AUIDEdit ParentAcquistionUnit
        {
            get
            {
                return _parentAcquistionUnit;
            }

            set
            {
                _parentAcquistionUnit = value;

                if (_parentAcquistionUnit != null)
                {
                    if (_parentAcquistionUnit.Id.Value != _localId)
                        LocalId = _parentAcquistionUnit.Id.Value;
                }


                OnPropertyChanged();
            }
        }

        public InternalDesignationEdit EditRecord
        {
            get
            {
                if (Records.Count == 0) return null;

                return _designatorDto ?? Records[0];
            }
            set
            {
                if (_designatorDto == value) return;
                _designatorDto = value;

                OnPropertyChanged();
            }
        }
        
        public InternalDesignationsModel(IDesignationStore iDesignationStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _designationStore = iDesignationStore;

            Records  = new ExtRangeCollection<InternalDesignationEdit>(iDialogService);

            _iLookupStore = iLookupStore;

            PropertyChanged += (sender, e) =>
            {

                if (e.PropertyName == "LocalId")
                {
              //      Debug.WriteLine("ParentAcquistionUnit IDM set : " + LocalId + "     "+ InstanceID);

                    var results = _designationStore.GetIntDesignationDtos(LocalId);

                    Records.ReplaceRange(InternalDesignationEdit.MakeCollection(results));

                    if (Records.Count > 0)
                        EditRecord = Records.First();
                }
            };
            
        
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;


            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            //if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;

            //if (FocusedInstanceID == null) return;

            //if (InstanceID != FocusedInstanceID.InstanceID) return;


 
            switch (message.EdEvent)
            {
     //           case EdEvent.AcquisitionUnitChanged:
     ////               Debug.WriteLine("acq changed:" + message.Data);
     //               ParentAcquistionUnit.Id.Value = (int)message.Data;
     //               break;


                case EdEvent.SaveButtonClicked:

           //         Debug.WriteLine("int desig sav: ");
                    var tpRecs = Records.Select(c => c.ConvertToDto()).ToList();

                    _designationStore.UpdateInternalDesignation(tpRecs, ParentAcquistionUnit.Id.Value);
                    OnPropertyChanged("ParentAcquistionUnit");

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
                                var recordsDtos = Records.Select(c => c.ConvertToDto()).ToList();

                                _designationStore.UpdateInternalDesignation(recordsDtos, ParentAcquistionUnit.Id.Value);
                                OnPropertyChanged("ParentAcquistionUnit");

                                return EditRecord = a.Result;
                            }, TaskScheduler.FromCurrentSynchronizationContext());
                    }

                    break;
                case EdEvent.AddButtonClicked:
                    if (IsCorrectInstance())
                        AddNew();
                    break;
            }

            //       ProcessMessage(message);
        }

        protected void AddNew()
        {

            if (ParentAcquistionUnit.Id.Value <= 0)
            {
                Debug.WriteLine("Cannot add Internal Designation (No valid acquisition ID) : " + ParentAcquistionUnit.Id.Value);
                return;
            }

            if (this.LocalId != ParentAcquistionUnit.Id.Value)
                this.LocalId = ParentAcquistionUnit.Id.Value;

            var designationTypes = _iLookupStore.GetIntDesignationTypesDtos().Where(i => i.ID != 0);
  
            
            var newRec =new InternalDesignationDto()
            {
                Comments = "new rec comm",   
                InternalDesignationTypeId = designationTypes.First().ID,
                AcquisitionUnitID = ParentAcquistionUnit.Id.Value                
            };
  
            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            _designationStore.UpdateInternalDesignation(reclist, ParentAcquistionUnit.Id.Value);

            OnPropertyChanged("LocalId");

     
        }

        public override void Focused(object sender, object e)
        {
            focusParser.Parse(sender, e);

            if (focusParser.ButtonClicked) return;

            FocusedInstanceID = focusParser.MakeInstanceData(InstanceID);

            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.InstanceChanged,
                Data = FocusedInstanceID,
                InstanceId = Guid.NewGuid()
            });
        }


        public override void Dispose()
        {
            _iLookupStore = null;
            _designationStore = null;
            _designatorDto = null;
            _parentAcquistionUnit.Dispose();
            _parentAcquistionUnit = null;
            Records.Dispose();
            Records = null;
            base.Dispose();
        }

    }
}