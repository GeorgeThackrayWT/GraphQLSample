using System;
using System.ComponentModel;
using System.Diagnostics;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.PropertyInfos;

namespace EDCORE.ViewModel.Property.Interfaces
{



    public class PropertyBase : GeneralModelBase,  IPropInfoBase
    {
        protected IPropertyStore _iPropertyStore;

        public SubAcquisitionUnitEdit SubAcquisitionUnitEdit { get; set; } = new SubAcquisitionUnitEdit();



        //protected IPropertyStore _iPropertyStore;

        public PropertyBase(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILookupStore iLookupStore,
            ITelerikConvertors iTelerikConvertors, ICache iCache, IPropertyStore iPropertyStore) 
            : base(iPlatformEventHandling, iWTimer,iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iPropertyStore = iPropertyStore;

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    SubAcquisitionUnitEdit.Make(iPropertyStore.GetSubAcquisitionUnit(ParentID));
                    
                }

                // problem is here
                // make creates whole new set of properties
                // we need to update existing ones somehow.
            };

            
        }
        

        protected void ProcessMessage(EdMessage message)
        {
            // Debug.WriteLine("prop base proc message: "+  message.Data.ToString() + " " + InstanceID);

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;


            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;



            var t = this.GetType().Name + Guid.NewGuid();

            switch (message.EdEvent)
            {
                case EdEvent.BackButtonClicked:
                    //Debug.WriteLine("go back to :" + message.Data);
                    _iNavigation.GoBack();


                    break;
                case EdEvent.SaveButtonClicked:
                //    Debug.WriteLine(t + " save clicked :");
                    _iPropertyStore.UpdateSubAcquisitionUnit(ParentID, SubAcquisitionUnitEdit.ConvertToDto());

                    break;

                case EdEvent.DeleteButtonClicked:
                    //Debug.WriteLine(t + " del clicked :");

                    break;
                case EdEvent.AddButtonClicked:
                    //Debug.WriteLine(t + " add clicked :");

                    break;
            }
        }
    }
}