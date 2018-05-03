using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;

using DataObjects;
using DataObjects.DTOS;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class PropertyEditModel : GeneralModelBase, IPropertyEditModel
    {
      
        private int _managementUnitID = 0;
        private AUIDEdit _editRecord;

        public int Id { get; set; }
     
        public double GisTotalAcres { get; set; }
        public double WoodTotalAcres { get; set; }
        public double LandTotalAcres { get; set; }


        private ExtRangeCollection<AUIDEdit> _records;

        public ExtRangeCollection<AUIDEdit> Records
        {
            get { return _records; }
            set
            {
                _records = value;

                OnPropertyChanged();
            }
        }



        public AUIDEdit EditRecord
        {
            get { return _editRecord; }

            set
            {
                if (value == null)
                {
                    _editRecord = value;
                }
                else
                {
                    if (_editRecord == null)
                    {
                        _editRecord = value;
                        OnPropertyChanged();
                      
                    }
                    else
                    {
                        if (_editRecord.Id != value.Id)
                        {
                            _editRecord = value;

                            OnPropertyChanged();
                        }
                    }
                 
                  
                }
                
            }

        }

        public IPropertyStore _PropertyStore;
        private readonly IManagementUnitStore _iManagementUnitStore;

        private ILookupStore _iLookupStore;

        public PropertyEditModel(IPropertyStore iStoreManager, IPlatformEventHandling iPlatformEventHandling, ILookupStore iLookupStore, IManagementUnitStore iManagementUnitStore,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService, IWTTimer iWTimer,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {          
            InstanceID = GetType().Name + Guid.NewGuid();
            Debug.WriteLine("PropertyEditModel Constructed: " + InstanceID);
            Records = new ExtRangeCollection<AUIDEdit>(iDialogService);

            _iLookupStore = iLookupStore;
            _PropertyStore = iStoreManager;
            _iManagementUnitStore = iManagementUnitStore;
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    Debug.WriteLine("propertyeditmodel state changed");

                    if (State.NewRecord)
                    {
                        if (Id == 0)
                        {
                            // we dont have a management unit!

                            Records = new ExtRangeCollection<AUIDEdit>();
                        }

                        AddNew();
                    }
                    else
                    {
                        var acqs = iStoreManager.GetAcquisitionIds(State.RecordId);
                        foreach (var a in acqs)
                        {
                            var tp = iStoreManager.GetAcquisitionUnit(a.Id);
                            a.AcquisitionMainSection = new MainSectionEdit(); 
                            a.AcquisitionMainSection.Make(tp.AcquisitionMainSectionDto);
                            a.AcquisitionMainSection.PropertyChanged += (s1, e1) =>
                            {
                                Debug.WriteLine("AcquisitionEditModel AcquisitionMainSection PropertyChanged: " + e1.PropertyName);
                                OnPropertyChanged("Region");
                            };

                            a.PropertyFarming = new PropertyFarmingEdit();
                            a.PropertyFarming.Make(tp.PropertyFarmingDto);
                            a.PropertyGeneralDetails = new PropertyGeneralDetailsEdit();
                            a.PropertyGeneralDetails.Make(tp.PropertyGeneralDetailsDto);
                            a.PropertyLegalTitle = new PropertyLegalTitleEdit();
                            a.PropertyLegalTitle.Make(tp.PropertyLegalTitleDto);

                         

                        }
                        
                        Records.ReplaceRange(AUIDEdit.MakeCollection(acqs));

                        EditRecord = Records.First();                        
                    }

                    PageMessageBus.Count();

                    //SystemWideMessageBus.Publish(new EdMessage
                    //{
                    //    EdEvent = EdEvent.PropertyLoaded,
                    //    Data = _managementUnitID
                    //});
                }

                //if (e.PropertyName == "EditRecord")
                //{
                //    SystemWideMessageBus.Publish(new EdMessage
                //    {
                //        EdEvent = EdEvent.AcquisitionUnitChanged,
                //        Data = EditRecord.Id.Value,
                //        BaseIgnore = true,
                //        InstanceId = Guid.NewGuid()
                //    });
                //}
            };
            
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            var source = GetMessageSource(message);

            if (source.Contains("AcquisitionEditModel") || source.Contains("PropertyEditModel"))
               PleaseWaitHelper.ClearWait(message);

            if (MessageFilter.FilterHandledMessages(message,InstanceID)) return;

            switch (message.EdEvent)
            {
                case EdEvent.SaveButtonClicked:
                    if (source.Contains("AcquisitionEditModel") || source.Contains("PropertyEditModel"))
                    {
                        PleaseWaitHelper.ShowWait(InstanceID, () =>
                        {
                            SaveAllDataSets(_PropertyStore, _iManagementUnitStore);
                            return;
                        });

                    }
                    
                    break;
                case EdEvent.AddButtonClicked:
            
                    if(source.Contains("AcquisitionEditModel") || source.Contains("PropertyEditModel"))
                        AddNew();
                    break;
                case EdEvent.DeleteButtonClicked:
                    if (source.Contains("AcquisitionEditModel") || source.Contains("PropertyEditModel"))
                    {
                        if (this.EditRecord.RecordId > -1000)
                        {
                            var deletionId = this.EditRecord.RecordId;

                            Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith(
                                (a) =>
                                {
                                    var existingRecords = Records.Select(c => c.RecordId).ToList();

                                     _PropertyStore.DeleteAcquisitionUnits(deletionId);

                                    OnPropertyChanged("State");

                                    return EditRecord = a.Result;
                                }, TaskScheduler.FromCurrentSynchronizationContext());
                        }
                    }
                    break;
            }

        }

     

        private void SaveAllDataSets(IPropertyStore iPropertyStore, IManagementUnitStore iManagementUnitStore)
        {
            //REMEMBER WE ARENT SAVING ALL ACQ UNITS


            foreach (var acqUnit in Records)
            {                
                // we dont have a management unit!
                if (acqUnit.ManagementUnitId.Value <= 0)
                {

                    if (!iPropertyStore.ValidateCostCenter(acqUnit.AcquisitionMainSection.CostCentre.Value)) continue;

                    var managementUnitId = iManagementUnitStore.CreateManagementUnit(EditRecord.AcquisitionMainSection.CostCentre.Value);

                    acqUnit.ManagementUnitId.Value = managementUnitId;

                    // so here we add the current acquisition unit to 
                    acqUnit.Id.Value = iPropertyStore.SaveNewAcquisitionUnit(managementUnitId, acqUnit.ConvertToDto());

                    acqUnit.NewRecord.Value = false;
                }

                if (acqUnit.Id.Value <= 0)
                {
                    acqUnit.Id.Value = iPropertyStore.SaveNewAcquisitionUnit(acqUnit.ManagementUnitId.Value, acqUnit.ConvertToDto());

                    acqUnit.NewRecord.Value = false;

                    acqUnit.AcquisitionMainSection.WoodNo.Value = acqUnit.Id.Value.ToString();
                }

                if (acqUnit.Id.Value > 0)
                {
                    iPropertyStore.UpdateFarming(acqUnit.Id.Value, acqUnit.PropertyFarming.ConvertToDto());                   
                    iPropertyStore.UpdateGeneralDetails(acqUnit.Id.Value, acqUnit.PropertyGeneralDetails.ConvertToDto());
                    iPropertyStore.UpdateLegalTitle(acqUnit.Id.Value, acqUnit.PropertyLegalTitle.ConvertToDto());
                    iPropertyStore.UpdateProperty(acqUnit.Id.Value, acqUnit.AcquisitionMainSection.ConvertToDto());                    
                }

            }


            OnPropertyChanged("State");
            OnPropertyChanged("Records");
        }

        protected void AddNew()
        {            
            var costCenter = "0";

            if (Records.Count > 0)
            {
                costCenter = Records.First().AcquisitionMainSection.CostCentre.Value;
            }
            
            var newRec = new AUID()
            {
  
                ManagedById = 1,
                ManagementUnitId = State.RecordId,             
                Name = "new acq unit",           
                NewRecord = Records.Count==0,
                AcquisitionMainSection = new MainSectionEdit(),
                PropertyFarming = new PropertyFarmingEdit(),
                PropertyGeneralDetails = new PropertyGeneralDetailsEdit(),
                PropertyLegalTitle = new PropertyLegalTitleEdit()
            };


            newRec.PropertyGeneralDetails.Make(new PropertyGeneralDetailsDto()
            {

            });

            newRec.PropertyLegalTitle.Make(new PropertyLegalTitleDto());
            newRec.PropertyFarming.Make(new PropertyFarmingDto());
            newRec.AcquisitionMainSection.Make(new MainSectionDto()
            {
                ManagedBy = 1,//woodland trust
                Region = 12,
                SiteName = "new acq unit",
                CostCentre = costCenter,
                WoodNo = "0"
            });
            
            
            var dtos = Records.Select(s => s.ConvertToDto()).ToList();

            dtos.Add(newRec);

            var col = AUIDEdit.MakeCollection(dtos);

            Records.ReplaceRange(col);

            EditRecord = Records.First(f => f.Id.Value == newRec.Id);


        }

        public override void Dispose()
        {          
            this._editRecord.Dispose();
            this._editRecord = null;
            this._PropertyStore = null;
            this._iLookupStore = null;
            this._records.Dispose();
            this._records = null;
            this._iCache = null;
            this._iNavigation = null;
            this._iPlatformEventHandling = null;
            this._iTelerikConvertors = null;
            this._iLookupStore = null;
        
            base.Dispose();
        }
    }
}