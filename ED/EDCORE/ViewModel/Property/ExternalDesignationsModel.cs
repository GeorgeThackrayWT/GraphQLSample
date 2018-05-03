using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Property
{
    public class ExternalDesignationsModel : GeneralModelBase, IExternalDesignationsModel
    {
     //   private List<EventRecord> _desigEventLog = new List<EventRecord>();

        private IDesignationStore _iDesignationStore;
        private ILookupStore _iLookupStore;
        private List<ComboBoxValue> _designationTypes;

        private ExternalDesignationEdit _designatorDto;
        private AUIDEdit _parentAcquistionUnit;
        private int _lastEditId = 0;

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

        public ExtRangeCollection<ExternalDesignationEdit> Records { get; set; } 



        public AUIDEdit ParentAcquistionUnit
        {
            get
            {
                return _parentAcquistionUnit;
            }

            set
            {
                if (_parentAcquistionUnit != value)
                {
                    // dont set it to null
                    if (value == null) return;

                    _parentAcquistionUnit = value;

                    if (_parentAcquistionUnit != null)
                    {
                        if (_parentAcquistionUnit.Id.Value != _localId)
                            LocalId = _parentAcquistionUnit.Id.Value;
                    }


                    OnPropertyChanged();
                }
            }
        }

        public ExternalDesignationEdit EditRecord
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

      
        public ExternalDesignationsModel(IDesignationStore iDesignationStore, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, IWTTimer iWTimer,
            object iDialogService,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            
            InstanceID = GetType().Name + Guid.NewGuid();


       //     Debug.WriteLine("created: " + InstanceID);


            _iDesignationStore = iDesignationStore;
            _iLookupStore = iLookupStore;

            Records = new ExtRangeCollection<ExternalDesignationEdit>(iDialogService);


            _designationTypes = iLookupStore.GetExtDesignationTypeDtos();

            // load data when acquisition id property is set
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "LocalId")
                {
                  //  Debug.WriteLine("ParentAcquistionUnit EDM set : " + LocalId);

                    var result = _iDesignationStore.GetExtDesignationDtos(LocalId);

                    var resultCollection = ExternalDesignationEdit.MakeCollection(result);
                    
                    Records.ReplaceRange(resultCollection);

                    if (Records.Count > 0)
                        EditRecord = Records.First();

                    OnPropertyChanged("Records");
                }
            };
            
           
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

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            //not related to messages as such
            //just put it here because this is frequently triggered
            UpdateDesignationDescription();

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;
             
            switch (message.EdEvent)
            {
                case EdEvent.SaveButtonClicked:
              //      Debug.WriteLine("ext desig sav: ");
                    _iDesignationStore.UpdateExternalDesignation(Records.Select(c => c.ConvertToDto()).ToList(), ParentAcquistionUnit.Id.Value);
                    OnPropertyChanged("LocalId");
                    break;

             //   case EdEvent.AcquisitionUnitChanged:
             ////       Debug.WriteLine("acq changed:" + message.Data);
             //       ParentAcquistionUnit.Id.Value = (int)message.Data;
             //       break;

                case EdEvent.BackButtonClicked:
                    if(IsCorrectInstance())
                        _iNavigation.GoBack();
                    break;
                    
                case EdEvent.DeleteButtonClicked:
                    if (IsCorrectInstance())
                    {
                        Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith(
                            (a) =>
                            {
                                _iDesignationStore.UpdateExternalDesignation(Records.Select(c => c.ConvertToDto()).ToList(), ParentAcquistionUnit.Id.Value);

                                OnPropertyChanged("LocalId");

                                return EditRecord = a.Result;
                            }, TaskScheduler.FromCurrentSynchronizationContext());

                        
                    }

                    break;
                case EdEvent.AddButtonClicked:
                    if(IsCorrectInstance())
                        AddNew();
                    break;
            }
   
        }

        private void UpdateDesignationDescription()
        {
            if (this.EditRecord != null)
            {
                if (this.EditRecord.DesignationTypeId == null) return;

                if (this.EditRecord.DesignationTypeId.Value != this._lastEditId)
                {
                    this._lastEditId = this.EditRecord.DesignationTypeId.Value;

                    var selectedDesignationType =
                        _designationTypes.FirstOrDefault(f => f.ID == this._lastEditId);


                    this.EditRecord.DesignationDescription.Value = selectedDesignationType?.Description;
                }
            }
        }

        protected void AddNew()
        {

            if (ParentAcquistionUnit.Id.Value <= 0)
            {
                Debug.WriteLine("Cannot add External Designation (No valid acquisition ID) : " + ParentAcquistionUnit.Id.Value);
                return;
            }

            //update local id if its wrong.
            if (this.LocalId != ParentAcquistionUnit.Id.Value)
                this.LocalId = ParentAcquistionUnit.Id.Value;

            var designationTypes = _iLookupStore.GetExtDesignationTypeDtos().Where(i=>i.ID!=0);
            var designations = _iLookupStore.GetDesignatorDtos().Where(i => i.ID != 0);
           
            var newRec =new ExternalDesignationDto()
            {
                  Comments = "new rec comm",
                  DesignationTypeId = designationTypes.First().ID,
                  DesignatorID = designations.First().ID,
                  DesignatedAreaName = "new rec name",
                  SSSICitation = "new sssi citation",
                  SitePartDescription = "new site part desc"
            };
            
            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            _iDesignationStore.UpdateExternalDesignation(reclist, ParentAcquistionUnit.Id.Value);

            OnPropertyChanged("LocalId");
            
        }

        public override void Dispose()
        {
            _iDesignationStore = null;
            _iLookupStore = null;
            _designationTypes = null;
             _designatorDto = null;

            _parentAcquistionUnit.Dispose();
            _parentAcquistionUnit = null;
            Records.Dispose();
            Records = null;
            base.Dispose();
        }


    }
}