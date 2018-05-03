using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VTextBoxModel : GeneralModelBase, IVTextBoxModel
    {
        private Property<string> _selectionText;
        private string _label;
        private bool _readOnly;

        public VTextBoxModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            ReadOnly = false;
        }

        public Property<string> Text
        {
            get => _selectionText;
            set => SetProperty(ref _selectionText, value);
        }

        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }


        public void Selected(object sender, object e)
        {
        }
    }
}