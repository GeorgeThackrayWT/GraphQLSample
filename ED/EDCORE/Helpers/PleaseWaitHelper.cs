using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Abstractions;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public class PleaseWaitHelper
    {
 
        private IPageMessageBus _pageMessageBus;
        private IWTTimer _timer;
        protected bool _isSaving = false;
        protected bool WaitDisplayed = false;

        protected event PropertyChangedEventHandler SaveCompleted;
        protected Action _saveAction;
        
        public bool IsSaving
        {
            get => _isSaving;
            set
            {
                _isSaving = value;
                SaveCompleted?.Invoke(this, new PropertyChangedEventArgs("IsSaving"));
            }
        }

        public PleaseWaitHelper(IPageMessageBus iPageMessageBus, IWTTimer timer)
        {
            _pageMessageBus = iPageMessageBus;
            _timer = timer;

            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, object e)
        {
            _timer.Stop();

            HideWait();
        }

        public void ClearWait(EdMessage message)
        {
            //why are we handling this here and no where else?
            //because this code always needs to be run in the base class
            // sometimes the handle message method is overridden
            //this should always get called though.
            if (message.EdEvent == EdEvent.WaitDisplayed)
            {
                if (_saveAction != null && IsSaving)
                {
                    //start the save code
                    var t = Task.Factory.StartNew(_saveAction);
                    t.Wait();

                    HideWait();
                    // we dont want to inadvertantly call this again somehow.
                    _saveAction = null;
                    IsSaving = false;
                }
                else
                {
                    HideWait();
                }
            }
        }

        public void HideWait()
        {
            if (_pageMessageBus == null) return;

            _pageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.HideWait,
                Data = GeneralModelBase.FocusedInstanceID,
                InstanceId = Guid.NewGuid()
            });
        }

        public void ShowWait(string key, Action action)
        {
            if (_pageMessageBus == null) return;

            IsSaving = true;
            _saveAction = action;

            //show the wait screen
            _pageMessageBus.Publish(new EdMessage
            {
                EdEvent = EdEvent.ShowWait,
                Data = GeneralModelBase.FocusedInstanceID,
                InstanceId = Guid.NewGuid()
            });

            _timer.Interval = new TimeSpan(0,0,60);

            _timer.Start();

            
        }


        public void Dispose()
        {
            this._pageMessageBus = null;

        }
    }
}