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
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public class LicenseModel : PropertyBase, ILicenseModel
    {      
        public ExtRangeCollection<LicenseEdit> Records { get; set; }
     
        private string _licenseTypeLabel = "Other";

        private List<int> GetAgreemenTypes(string licenseType)
        {
            var requiredAgreementTypes = new List<int>();

            switch (licenseType)
            {
                case "Other":
                    requiredAgreementTypes = new List<int>{4};
                    break;
                case "Tenancies":
                case "Tenancy":
                    requiredAgreementTypes = new List<int>{0,1};
                    break;
                case "Grazing":
                    requiredAgreementTypes = new List<int>{2};
                    break;
                case "Fishing":
                    requiredAgreementTypes = new List<int>{3};
                    break;

            }

            return requiredAgreementTypes;
        }

        private LicenseEdit _editRecord;
        
        public string LicenseTypeLabel
        {
            get
            {
                return _licenseTypeLabel;
            }

            set
            {
                SetProperty(ref _licenseTypeLabel, value);
            }
        }
        
        public LicenseEdit EditRecord
        {
            get
            {
                if (Records.Count == 0) return null;

                return _editRecord ?? Records[0];
            }
            set
            {
                if (_editRecord?.Id == value?.Id) return;

                _editRecord = value;

                OnPropertyChanged();
            }
        }



        public LicenseModel(IWTTimer iWTimer, IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService, 
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,  iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {            
            InstanceID = GetType().Name + Guid.NewGuid();

            Records = new ExtRangeCollection<LicenseEdit>(iDialogService);
            
            _iPropertyStore = iPropertyStore;
        
            PropertyChanged += (sender, e) =>
            {             
                switch (e.PropertyName)
                {
                    case "State":
                        var data = iPropertyStore.GetLicenseDto(this.State.RecordId, GetAgreemenTypes(this.LicenseTypeLabel));

                        Records.ReplaceRange(LicenseEdit.MakeCollection(data));

                        if (Records.Count > 0)
                            EditRecord = Records.First();

                        OnPropertyChanged("Records");
                        break;
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
            // we only want messages that have been sent to us.         
            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            if (this.IsDisposed) return;

            switch (message.EdEvent)
            {
                case EdEvent.BackButtonClicked:
                    if (IsCorrectInstance())
                        _iNavigation.GoBack();
                    break;

                case EdEvent.SaveButtonClicked:
                    SaveData();                   
                    break;
                 
                case EdEvent.DeleteButtonClicked:
                    if (IsCorrectInstance())
                    {
                        Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) =>
                        {
                            SaveData();

                            if (Records.Count > 0)
                                EditRecord = Records.Last();
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                    }

                    break;
                case EdEvent.AddButtonClicked:
                    if (IsCorrectInstance())
                        AddNew();
                    break;
            }

        }

        private void SaveData()
        {
            _iPropertyStore.UpdateLicenses(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {        
            var newRec = new LicenseDto()
            {
                Comments = "new rec comm",
                AgreementId = GetAgreemenTypes(this.LicenseTypeLabel).First()
            };

            var reclist = Records.Select(s => s.ConvertToDto()).ToList();

            reclist.Add(newRec);

            Records.ReplaceRange(LicenseEdit.MakeCollection(reclist));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();

        }

     
    }
}