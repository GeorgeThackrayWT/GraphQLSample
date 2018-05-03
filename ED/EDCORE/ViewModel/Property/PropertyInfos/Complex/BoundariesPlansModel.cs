using System;
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
    public class BoundariesPlansModel : PropertyBase, IBoundariesPlansModel
    {
        public ExtRangeCollection<BoundariesAndPlanEdit> Records { get; set; }

        private BoundariesAndPlanEdit _editRecord;

        public BoundariesAndPlanEdit EditRecord
        {
            get => _editRecord;

            set
            {
                if (_editRecord?.Id != value?.Id)
                {
                    _editRecord = value;
                    OnPropertyChanged();
                }
            }
        }

        public BoundariesPlansModel(IPropertyStore iPropertyStore, IPlatformEventHandling iPlatformEventHandling, object iDialogService, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iNavigation,iPageMessageBus,iLookupStore, iTelerikConvertors,iCache, iPropertyStore)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
            
            Records = new ExtRangeCollection<BoundariesAndPlanEdit>(iDialogService);

            PropertyChanged += (sender, e) =>
            {
                //load data here        
                switch (e.PropertyName)
                {
                    case "State":
                        var data = iPropertyStore.GetBoundariesAndPlansDto(State.RecordId);

                        Records.ReplaceRange(BoundariesAndPlanEdit.MakeCollection(data));

                        if (Records.Count > 0)
                            EditRecord = Records.First();
                        break;
                }               
            };
            
        }
 
        public override void HandleMessage(EdMessage message)
        {
            // we only want messages that have been sent to us.
            if (IsDisposed) return;

            PleaseWaitHelper.ClearWait(message);

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;
                     
            switch (message.EdEvent)
            {   
                case EdEvent.BackButtonClicked:                   
                     _iNavigation.GoBack();                    
                    break;
                case EdEvent.SaveButtonClicked:
                    Debug.WriteLine("Save Clicked");

                    PleaseWaitHelper.ShowWait(InstanceID, () =>
                    {
                        SaveData();
                        return;
                    });


                    break;

                case EdEvent.DeleteButtonClicked:
                    Records.Delete(p => p.RecordId == EditRecord.RecordId).ContinueWith((a) =>
                    {
                        SaveData();

                        if (Records.Count > 0)
                            EditRecord = Records.Last();
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    break;
                case EdEvent.AddButtonClicked:
                    AddNew();

                    break;
            }
        }




        private void SaveData()
        {
            _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());
            _iPropertyStore.UpdateBoundariesAndPlansDto(ParentID, Records.Select(c => c.ConvertToDto()).ToList());
        }

        protected void AddNew()
        {
            var records = Records.Select(c => c.ConvertToDto()).ToList();

            records.Add(new BoundariesAndPlanDto()
            {
                Description = "new rec desc",
                Responsibility = false,
                BoundaryDescription = "new bound desc"
            });



            Records.ReplaceRange(BoundariesAndPlanEdit.MakeCollection(records));

            SaveData();

            if (Records.Count > 0)
                EditRecord = Records.Last();


        }
    }


}
