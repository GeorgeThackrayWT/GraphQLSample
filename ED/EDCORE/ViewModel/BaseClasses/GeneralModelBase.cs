using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public abstract class GeneralModelBase : BindableBase, ICommonInterface, IBaseModel, ISubscriber<EdMessage>
    {
        private bool _isDisposed = false;

        protected FocusParser focusParser;

 
        public MessageFilter MessageFilter = new MessageFilter();
        public PleaseWaitHelper PleaseWaitHelper;


        public static InstanceData FocusedInstanceID { get; set; }
        protected IPlatformEventHandling _iPlatformEventHandling;
    
        protected IPageMessageBus PageMessageBus;

        protected INavigation _iNavigation;
        protected ICache _iCache;
        protected ITelerikConvertors _iTelerikConvertors;

    
        public string InstanceID { get;  set; }

        public IBaseModel ParentInstance {

            get { return _parentInstance; }
            set
            {
                _parentInstance = value;
                OnPropertyChanged();
            }
        }

        protected bool _disposed = false;
        private bool _cancelItemsEnabled = true;
        private bool _addTreesEnabled = true;
        private bool _duplicateSingleEnabled = true;
        private bool _duplicateFourEnabled = true;
        private bool _duplicateEnabled = true;
        private bool _searchEnabled = true;
        private bool _helpEnabled = true;
        private bool _saveEnabled = true;
        private bool _addEnabled = true;
        private bool _delEnabled = true;
        private bool _closeEnabled = true;
        private int _parentID = 0;
        private IBaseModel _parentInstance;

        public bool IsDisposed
        {
            get { return _isDisposed; }
        }

        private StateContainer _state;


        public GeneralModelBase( IPlatformEventHandling iPlatformEventHandling, IWTTimer timer,
            INavigation iNavigation, 
            IPageMessageBus iPageMessageBus, 
            ITelerikConvertors iTelerikConvertors,
            ICache iCache )
        {
            //remember we dont want to be polluting our portable view models with
            //crappy platform specfic windows references
            // so inject this functionality.
            // which should really be done in derived constructor not here!
            //but im lazy for now will leave here

            focusParser = new FocusParser(timer,iPlatformEventHandling, iTelerikConvertors);
            PleaseWaitHelper = new PleaseWaitHelper(iPageMessageBus, timer);

            _iPlatformEventHandling = iPlatformEventHandling;
            _iNavigation = iNavigation;
            PageMessageBus = iPageMessageBus;
         
            _iCache = iCache;
            _iTelerikConvertors = iTelerikConvertors;
         
            SubscriberId = GetType().Name + Guid.NewGuid();

            PageMessageBus.Subscribe(this);

            
        }

        public string ModelName
        {
            get { return GetType().Name; }
        }


        #region message bus stuff

        public void Unsubscribe()
        {
            PageMessageBus.UnSubscribe(this);
         
        }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public string SubscriberId { get; set; }

        #endregion



        public int ParentID => _state.RecordId;

        public StateContainer State
        {
            get => _state;

            set
            {
            //    if ( _state!=null && _state.Equals(value)) return;

                _state = value;
                OnPropertyChanged();
            }
        }


 


        #region commands
        public ICommand DataCommand { get; set; }

        public virtual ICommand FocusCommand { get; set; }

        public  ICommand SaveCommand { get; set; }

        public  ICommand DuplicateCommand { get; set; }

        public  ICommand DuplicateSingleCommand { get; set; }

        public  ICommand DuplicateFourCommand { get; set; }

        public  ICommand AddCommand { get; set; }

        public  ICommand AddTreesCommand { get; set; }

        public  ICommand DeleteCommand { get; set; }

        public  ICommand CancelCommand { get; set; }

        public  ICommand Loaded { get; set; }

        public  ICommand SearchCommand { get; set; }
        
        public  ICommand CancelItemsCommand { get; set; }

        public  ICommand HelpCommand { get; set; }

        public ICommand RefreshParent { get; set; }

        #endregion



        public bool IsCorrectInstance()
        {
            if (FocusedInstanceID == null || InstanceID != FocusedInstanceID.InstanceID)
                return false;

            return true;
        }

        #region handlemessage forcerefresh selected and focused methods


        public virtual void HandleMessage(EdMessage message)
        {
            //REMEMBER
            //if we override this method in a derived class 
            //then messages will need to be handled at that point
            //so for example an addcommand would need to be 
            //invoked at that point.

            //       Debug.WriteLine("received on: "+ InstanceID);

            if (this._disposed)
            {
                Debug.WriteLine("Message received on disposed object:" + InstanceID);
                return;
            }

            InstanceData messageInstanceData = message.Data as InstanceData;

            if (message.BaseIgnore) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;


            // so unless its an instance changed event. ie we are changing the focused (the instance variable) control 
            // then we want to check the buttons are being clicked on the focused instance.
            if (EdEvent.InstanceChanged != message.EdEvent)
            {
               // Debug.WriteLine(InstanceID + " " + messageInstanceData?.InstanceID);

                if (messageInstanceData != null && InstanceID != messageInstanceData.InstanceID)
                {
                    return;
                }

                
            }
           

            switch (message.EdEvent)
            {
                //case EdEvent.WaitDisplayed:              
                //    if (_saveAction != null && IsSaving)
                //    {
                //        //start the save code
                //        var t = Task.Factory.StartNew(_saveAction);
                //        t.Wait();

                //        HideWait();
                //        // we dont want to inadvertantly call this again somehow.
                //        _saveAction = null;
                //        IsSaving = false;                      
                //    }
                //    else
                //    {
                //        HideWait();
                //    }
                    
                //    break;

                case EdEvent.SaveButtonClicked:
                    SaveCommand?.Execute(message.Data);
                    break;
                case EdEvent.AddButtonClicked:
                    AddCommand?.Execute(message.Data);
                    break;                 
                case EdEvent.DeleteButtonClicked:
                    DeleteCommand?.Execute(message.Data);
                    break;
                case EdEvent.DuplicateButtonClicked:
                    DuplicateCommand?.Execute(message.Data);
                    break;
                case EdEvent.DuplicateFourButtonClicked:
                    DuplicateFourCommand?.Execute(message.Data);
                    break;
                case EdEvent.AddTreesButtonClicked:
                    AddTreesCommand?.Execute(message.Data);
                    break;
                case EdEvent.CancelButtonClicked:
                    CancelCommand?.Execute(message.Data);
                    break;
                case EdEvent.InstanceChanged:
                    FocusCommand?.Execute(message.Data);
                    break;
                case EdEvent.RefreshParent:
                    RefreshParent?.Execute(message.Data);
                    break;
            }
        }

        protected string GetMessageSource(EdMessage message)
        {
            if (!(message.Data is InstanceData idata))
                return "";

            if (idata.InstanceID == null) return "";

            return idata.InstanceID;
        }


        public virtual void ForceRefresh(object sender, object e)
        {
            //refresh bindings.
            OnPropertyChanged();
        }
        
        public virtual void Focused(object sender, object e)
        {
            // this is called when a control has got the focus, so that the program knows what 
            // to save on.
            // normally wired into grid onfocus event or something like that.
            

            focusParser.Parse(sender,e);

            if (focusParser.ButtonClicked) return;

            if (focusParser.Parent == "PART_ColumnHeadersHost") return;

            var instanceClicked = "";


            switch (focusParser.Parent)
            {                                     
                case "SafetyFurtherActionsModel":
                    instanceClicked = "SafetyFurtherActionsModel";
                    break;
                case "SafetyIncidentModel":
                    instanceClicked = "SafetyIncidentModel";
                    break;
                default:
                    instanceClicked = InstanceID;
                    break;
            }

            
            FocusedInstanceID = focusParser.MakeInstanceData(instanceClicked);


            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.InstanceChanged,
                Data = FocusedInstanceID,
                InstanceId = Guid.NewGuid()
            });


        
    
            //Debug.WriteLine("focused instanceid :" + FocusedInstanceID.InstanceID + " _ " + FocusedInstanceID.ControlName + " _ " + FocusedInstanceID.Element + " _ " + focusParser.Parent + " " );
            
        }


        public virtual void Refresh(string token)
        {
            PageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.RefreshParent,
                Data = token
            });
        }

        #endregion


        #region enable booleans

        public bool AddTreesEnabled
        {
            get { return _addTreesEnabled; }
            set
            {
                if (_addTreesEnabled == value) return;
                _addTreesEnabled = value;
                OnPropertyChanged();
            }
        }


        public bool CancelItemsEnabled
        {
            get { return _cancelItemsEnabled; }
            set
            {
                if (_cancelItemsEnabled == value) return;

                _cancelItemsEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool DuplicateSingleEnabled
        {
            get { return _duplicateSingleEnabled; }
            set
            {
                if (_duplicateSingleEnabled == value) return;
                _duplicateSingleEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool DuplicateFourEnabled
        {
            get { return _duplicateFourEnabled; }
            set
            {
                if (_duplicateFourEnabled == value) return;
                _duplicateFourEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool DuplicateEnabled
        {
            get { return _duplicateEnabled; }
            set
            {
                if (_duplicateEnabled == value) return;
                _duplicateEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool HelpEnabled
        {
            get { return _helpEnabled; }
            set
            {
                if (_helpEnabled == value) return;
                _helpEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool SearchEnabled
        {
            get { return _searchEnabled; }
            set
            {
                if (_searchEnabled == value) return;
                _searchEnabled = value;
                OnPropertyChanged();
            }
        }


        public bool SaveEnabled
        {
            get { return _saveEnabled; }
            set
            {

                if (_saveEnabled == value) return;

                _saveEnabled = value;
                OnPropertyChanged();
            }
        }


        public bool AddEnabled
        {
            get { return _addEnabled; }
            set
            {
                if (_addEnabled == value) return;
                _addEnabled = value;
                OnPropertyChanged();
            }
        }
        public bool DelEnabled
        {
            get { return _delEnabled; }
            set
            {
                if (_delEnabled == value) return;
                _delEnabled = value;
                OnPropertyChanged();
            }
        }
        public bool CloseEnabled
        {
            get { return _closeEnabled; }
            set
            {
                if (_closeEnabled == value) return;
                _closeEnabled = value;
                OnPropertyChanged();
            }
        }

        public string hack => "";
        #endregion




        public virtual void Dispose()
        {
            this.ClearPropertyChanged();
            this._iCache = null;
            this._iNavigation = null;
            this._iPlatformEventHandling = null;
            this._iTelerikConvertors = null;
            this._isDisposed = true;
            this.SaveCommand = null;


            DataCommand  =null;

            FocusCommand  =null;

            SaveCommand  =null;

            DuplicateCommand  =null;

            DuplicateSingleCommand  =null;

            DuplicateFourCommand  =null;

            AddCommand  =null;

            AddTreesCommand  =null;

            DeleteCommand  =null;

            CancelCommand  =null;

            Loaded  =null;

            SearchCommand  =null;

            CancelItemsCommand  =null;

            HelpCommand  =null;

            RefreshParent  =null;

            _parentInstance = null;

            this.Unsubscribe();
            this.MessageFilter = null;

            PleaseWaitHelper?.Dispose();

            this.PleaseWaitHelper = null;
            _disposed = true;
        }

    }




    
}
