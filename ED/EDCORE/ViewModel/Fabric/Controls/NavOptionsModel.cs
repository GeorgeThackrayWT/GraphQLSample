using System;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Widgets.Interfaces;

namespace EDCORE.ViewModel.Widgets
{
    public class NavOptionsModel : GeneralModelBase, INavOptions, ISubscriber<EdMessage>
    {

        private string _parent = "";

        public ICommand BackCommand { get; }

        public string Parent
        {
            get => _parent;

            set
            {
                _parent = value;
                OnPropertyChanged();
            }
        }
    
        public NavOptionsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus,iTelerikConvertors,iCache)
        {
          
            InstanceID = GetType().Name + Guid.NewGuid();

            BackCommand = new RelayCommand((x) =>
            {
                //    //Debug.WriteLine("Add Command");

                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.BackButtonClicked,
                    Data = Parent,
                    InstanceId = Guid.NewGuid()
                });
            });
        }

        public void HandleMessage(EdMessage message)
        {


            switch (message.EdEvent)
            {               
                case EdEvent.InstanceChanged:

                    InstanceData instanceData = (InstanceData)message.Data;

                    if (message.Data != null) Parent = instanceData.InstanceID;

                    break;


            }


        }

    }
}
