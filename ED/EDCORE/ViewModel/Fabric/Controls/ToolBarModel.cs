using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class HeaderBarModel : GeneralModelBase, IHeaderBarModel, ISubscriber<EdMessage>
    {
        private string _screenName = "";
        private string _label = "";
        private string _subLabel = "";
        private InstanceData _parent = new InstanceData();

        public HeaderBarModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation, iPageMessageBus, iTelerikConvertors, iCache)
        {
        }

        public string ScreenName
        {
            get { return _screenName; }

            set
            {
                _screenName = value;
                OnPropertyChanged();
            }
        }
        public string Label
        {
            get { return _label; }

            set
            {
                _label = value;
                OnPropertyChanged();
            }
        }
        public string SubLabel
        {
            get { return _subLabel; }

            set
            {
                _subLabel = value;
                OnPropertyChanged();
            }
        }


        public InstanceData Parent
        {
            get
            {
                return _parent;

            }
            set
            {
                _parent = value;
                OnPropertyChanged();
            }
        }


        public void ProgressLoaded()
        {
            throw new NotImplementedException();
        }


    }

    public class ToolBarModel : GeneralModelBase, IToolBarModel, ISubscriber<EdMessage>
    {
  
        private bool _saveRequired = true; 
        private bool _addRequired = true;   
        private bool _delRequired = true; 
        private bool _closeRequired = true; 

        private bool _cancelItemsRequired = true;
        private bool _addTreesRequired = true;
        private bool _duplicateFourRequired = true; 
        private bool _duplicateSingleRequired = true; 
        private bool _duplicateRequired = true; 
        private bool _searchRequired = true;   
        private bool _helpRequired = true;
        private bool _showPleaseWait = false;

        private string _selectionInfo = "";


        private InstanceData _parent = new InstanceData();
        
        


        public InstanceData Parent {
            get
            {
                return _parent;
                
            }
            set
            {
                _parent = value;
                OnPropertyChanged();
            }
        }



        #region required field properties
        public bool AddTreesRequired
        {
            get { return _addTreesRequired; }
            set
            {
                _addTreesRequired = value;
                OnPropertyChanged();
            }
        }


        public bool CancelItemsRequired
        {
            get { return _cancelItemsRequired; }
            set
            {
                _cancelItemsRequired = value;
                OnPropertyChanged();
            }
        }

         

        public bool DuplicateSingleRequired
        {
            get { return _duplicateSingleRequired; }
            set
            {
                _duplicateSingleRequired = value;
                OnPropertyChanged();
            }
        }

        public bool DuplicateFourRequired
        {
            get { return _duplicateFourRequired; }
            set
            {
                _duplicateFourRequired = value;
                OnPropertyChanged();
            }
        }

        public bool DuplicateRequired
        {
            get { return _duplicateRequired; }
            set
            {
                _duplicateRequired = value;
                OnPropertyChanged();
            }
        }

        public bool HelpRequired
        {
            get { return _helpRequired; }
            set
            {
                _helpRequired = value;
                OnPropertyChanged();
            }
        }

        public bool SearchRequired
        {
            get { return _searchRequired; }
            set
            {
                _searchRequired = value;
                OnPropertyChanged();
            }
        }


        public bool SaveRequired
        {
            get { return _saveRequired; }
            set
            {
                _saveRequired = value;
                OnPropertyChanged();
            }
        }


        public bool AddRequired
        {
            get { return _addRequired; }
            set
            {
                _addRequired = value;
                OnPropertyChanged();
            }
        }
        public bool DelRequired
        {
            get { return _delRequired; }
            set
            {
                _delRequired = value;
                OnPropertyChanged();
            }
        }
        public bool CloseRequired
        {
            get { return _closeRequired; }
            set
            {
                _closeRequired = value;
                OnPropertyChanged();
            }
        }

        public string SelectionInfo
        {
            get { return _selectionInfo; }
            set
            {
                _selectionInfo = value;
                OnPropertyChanged();
            }

        }

        public bool PleaseWaitVisible
        {
            get { return _showPleaseWait; }
            set
            {
                if (_showPleaseWait == value) return;

                _showPleaseWait =value; 

                OnPropertyChanged();
            }
        }

        #endregion


        public ToolBarModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
        
            InstanceID = GetType().Name + Guid.NewGuid();

            AddCommand = new RelayCommand((x) =>
            {   
                Debug.WriteLine("add button clicked message sent");

                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.AddButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });

            DeleteCommand = new RelayCommand((x) =>
            { 
                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.DeleteButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });

            SaveCommand = new RelayCommand((x) =>
            {        
                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.SaveButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,           
                });
            });

            DuplicateCommand = new RelayCommand((x) =>
            {           
                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.DuplicateButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });


            DuplicateSingleCommand = new RelayCommand((x) =>
            {           
                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.DuplicateButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });

            DuplicateFourCommand = new RelayCommand((x) =>
            {         
                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.DuplicateFourButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });

            AddTreesCommand = new RelayCommand((x) =>
            {
                //Debug.WriteLine("Add Tree Command with parent: " + Parent);

                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.AddTreesButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });


            CancelItemsCommand = new RelayCommand((x) =>
            {
                //Debug.WriteLine("Cancel Command with parent: " + Parent);

                PageMessageBus.Publish(new EdMessage()
                {
                    EdEvent = EdEvent.CancelButtonClicked,
                    InstanceId = Guid.NewGuid(),
                    Data = Parent,
                });
            });

            
        }


        public void ProgressLoaded()
        {
            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.WaitDisplayed,
                Data = FocusedInstanceID,
                InstanceId = Guid.NewGuid()
            });
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            switch (message.EdEvent)
            {
                case EdEvent.NoValidData:
                    AddEnabled = false;
                    DelEnabled = false;
                    SaveEnabled = false;
                    break;
             
                case EdEvent.SaveAllowed:
                    AddEnabled = true;
                    DelEnabled = true;
                    SaveEnabled = true;
                    break;


                case EdEvent.InstanceChanged:

                    //var message2 = (InstanceData) message.Data;

                    //Debug.WriteLine("Set parent instance to: " + message2.ControlName + " " + message2.InstanceID);

                    InstanceData instanceData = (InstanceData) message.Data;

                    if (message.Data != null) Parent = instanceData;

                    SelectionInfo = instanceData.InstanceID;

                    break;

                case EdEvent.ShowWait:
               //     Debug.WriteLine("Received show wait");
                    PleaseWaitVisible = true;

                   
                    break;

                case EdEvent.HideWait:
                 //   Debug.WriteLine("Received hide wait");
              //      Task.Delay(2000);

                    PleaseWaitVisible = false;

                    break;


            }

            
        }
    }
}