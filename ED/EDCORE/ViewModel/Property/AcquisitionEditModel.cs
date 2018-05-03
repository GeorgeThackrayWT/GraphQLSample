using System;
using System.Collections.Generic;
using System.Diagnostics;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Property
{
    public class AcquisitionEditModel : GeneralModelBase, IAcquisitionEditModel
    {
       
        private bool _costCenterReadOnly;
        public static int InstanceCount = 0;
        private AUIDEdit _record = new AUIDEdit();


        private AUIDEdit _parentMU;
       
        private ExtRangeCollection<AUIDEdit> _parentRecords;

        public ILinkContainer AcquisitionLinkContainer { get; set; }

        private IManagementUnitStore _iManagementUnitStore;
        private ILookupStore _iLookupStore;    

        public AUIDEdit Record
        {
            get => _record;

            set
            {
                if (_record == value) return;

                _record = value;

                OnPropertyChanged();
            }
        }

        public ExtRangeCollection<AUIDEdit> ParentRecords
        {
            get { return _parentRecords; }
            set
            {
                _parentRecords = value;
                OnPropertyChanged();
            }
        }

        public PropertyGeneralDetailsEdit PropertyGeneralDetails => Record.PropertyGeneralDetails;
        public PropertyLegalTitleEdit PropertyLegalTitle => Record.PropertyLegalTitle;
        public PropertyFarmingEdit PropertyFarming => Record.PropertyFarming;
        public MainSectionEdit AcquisitionMainSection => Record.AcquisitionMainSection;

        public int ManagementUnitId { get; set; }

        public AUIDEdit ParentMU
        {
            get => _parentMU;
            set
            {
                if (_parentMU != value)
                {
                    _parentMU = value;
                                        
                    OnPropertyChanged();
                }
            }
        }

        public int Id
        {
            get
            {
                if (Record == null)
                {
                    return 0;
                }

                return Record.Id.Value;
            }
        }




        public bool CostCenterReadOnly
        {
            get
            {
                return !this.Record.NewRecord.Value;
            }
        }

        public Property<string> ApplicationName
        {
            get
            {
                if (Record?.AcquisitionMainSection == null) return new Property<string>(){Value = ""};

                var appid = this.Record.AcquisitionMainSection.ApplicationId.Value;

                if (appid == 1) return new Property<string>() { Value = "ED" };
                if (appid == 2) return new Property<string>() { Value = "NED" };

                return new Property<string>() { Value = "All" };

            }
        }

        public Tuple<int, string> Grazing => new Tuple<int, string>(this.Id,"Grazing");

        public Tuple<int, string> Other => new Tuple<int, string>(this.Id, "Other");

        public Tuple<int, string> Fishing => new Tuple<int, string>(this.Id, "Fishing");

        public Tuple<int, string> Tenancy => new Tuple<int, string>(this.Id, "Tenancy");

        public AcquisitionEditModel( IPlatformEventHandling iPlatformEventHandling,INavigation iNavigation, IPageMessageBus iPageMessageBus,ILinkContainer iAcquisitionLinkContainer, ITelerikConvertors iTelerikConvertors, IWTTimer iWTimer,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

        //    Debug.WriteLine("AcquisitionEditModel Constructed: " + InstanceID);
          
      
            AcquisitionLinkContainer = iAcquisitionLinkContainer;
             
            PropertyChanged += (sender, e) =>
            {                
                if (e.PropertyName == "Record")
                {
             //       Debug.WriteLine("AcquisitionEditModel PropertyChanged Record: " + this.Record.Id + " on instance " + InstanceID);

                    OnPropertyChanged("CostCenterReadOnly");
                    OnPropertyChanged("PropertyGeneralDetails");
                    OnPropertyChanged("PropertyLegalTitle");
                    OnPropertyChanged("PropertyFarming");
                    OnPropertyChanged("AcquisitionMainSection");                    
                }

                if (e.PropertyName == "ParentMU")
                {
             //       Debug.WriteLine("AcquisitionEditModel ParentMU PropertyChanged: " + ParentMU.RecordId);
                    Focused(null, null);
                }

            };
        }

        public void Dispose()
        {
      
            this.AcquisitionLinkContainer = null;
            this._iLookupStore = null;
            this._iManagementUnitStore = null;

            if (this._parentMU != null)
            {

                this._parentMU.Dispose();
                this._parentMU = null;
            }

            if (this._parentRecords !=null)
            {
                this._parentRecords.Dispose();
                this._parentRecords = null;
            }
            this._record.Dispose();
            this._record = null;
    
            this.MessageFilter = null;
 

            base.Dispose();

        }






        //public override void HandleMessage(EdMessage message)
        //{


        //    if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;



        //    switch (message.EdEvent)
        //    {
        //        //case EdEvent.AcquisitionUnitChanged:
        //        //    if(Record.Id.Value.ToString() == message.Data.ToString())
        //        //        Focused(null,null);
        //        //    break;

        //        case EdEvent.SaveButtonClicked:                    
        //            if (message.BaseIgnore) return;

        //            if (FilterByMessageId(message)) return;

        //            if(ParentMU!=null)
        //            Debug.WriteLine("selection on parent: " + ParentMU.Id + " this id : " + Record.Id.Value);

        //            var d = message.Data as InstanceData;
        //            //only save stuff if the message comes from one of these models
        //            if (d.InstanceID.Contains("AcquisitionEditModel") ||
        //                d.InstanceID.Contains("InternalDesignationsModel") ||
        //                d.InstanceID.Contains("ExternalDesignationsModel"))
        //            {

        //                //Debug.WriteLine(d.Element + " " + d.InstanceID + " " + message.InstanceId + " " +
        //                //                message.BaseIgnore + " " + d.Element + " " + this.InstanceID);

        //                //Debug.WriteLine(ParentMU.Id.Value +  " " + this.Id);

        //                //SaveCommand?.Execute(message.Data);
        //            }
        //            break;


        //        default:
        //            base.HandleMessage(message);
        //            break;
        //    }

        //}

        //private bool FilterByMessageId(EdMessage message)
        //{
        //    if (_receivedList.Contains(message.InstanceId)) return true;

        //    _receivedList.Add(message.InstanceId);
        //    return false;
        //}

        //private void SendMessage(IPageMessageBus iPageMessageBus, EdEvent edEvent)
        //{


        //    iPageMessageBus.Publish(new EdMessage()
        //    {
        //        Data = new InstanceData()
        //        {
        //            ControlName = "",
        //            Element = Record.Id.Value.ToString(),
        //            InstanceID = ManagementUnitId.ToString(),

        //        },
        //        BaseIgnore = true,
        //        EdEvent = edEvent,
        //        InstanceId = Guid.NewGuid()
        //    });
        //}
    }
}