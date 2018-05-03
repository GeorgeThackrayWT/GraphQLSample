using System;
using Abstractions;
using Abstractions.Models.InternalAudits;
using Abstractions.Navigation;
using Abstractions.Stores.Content.InternalAudits;
using DataObjects;
using DataObjects.DTOS.InternalAudits;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class InternalAuditWoodListModel : GeneralModelBase, IInternalAuditWoodListModel
    {
        private readonly IInternalAuditStore _internalAuditStoreStore;

        private ObservableRangeCollection<InternalAuditsWoodlist> _auditsWoodlists = new ObservableRangeCollection<InternalAuditsWoodlist>();

        private int _internalAuditID;

        private InternalAuditsWoodlist _selectedAuditsWoodlist;

        public ObservableRangeCollection<InternalAuditsWoodlist> InternalAuditsWoodList
        {
            get { return _auditsWoodlists; }
            set
            {
                if (_auditsWoodlists == value) return;

                _auditsWoodlists = value;

                OnPropertyChanged();
            }
        }

        public int InternalAuditId
        {
            get { return _internalAuditID; }

            set
            {
                _internalAuditID = value;
                OnPropertyChanged();
            }
        }

        public InternalAuditsWoodlist SelectedAuditsWoodlist
        {
            get
            {
                return _selectedAuditsWoodlist ?? InternalAuditsWoodList[0];
            }
            set
            {
                if (_selectedAuditsWoodlist == value) return;
                _selectedAuditsWoodlist = value;
                OnPropertyChanged();
            }
        }

        public InternalAuditWoodListModel(IWTTimer iWTimer, IInternalAuditStore internalAuditStoreStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _internalAuditStoreStore = internalAuditStoreStore;

            InstanceID = GetType().Name + Guid.NewGuid();

 
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "InternalAuditID")
                {
                    if (InternalAuditId != 0)
                    {
                        var result = _internalAuditStoreStore.GetAuditWoods(InternalAuditId);
                        InternalAuditsWoodList.ReplaceRange(result);
                    }

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
    }
}