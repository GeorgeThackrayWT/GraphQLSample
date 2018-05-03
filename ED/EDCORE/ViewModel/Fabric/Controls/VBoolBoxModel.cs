using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VBoolBoxModel : GeneralModelBase, IVBoolBoxModel
    {
        private Property<bool> _selectionBool;
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VBoolBoxModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();


        }

        public Property<bool> Bool
        {
            get => _selectionBool;
            set => SetProperty(ref _selectionBool, value);
        }

        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        public void Selected(object sender, object e)
        {
        }
    }

    public class VBoolBoxNullableModel : GeneralModelBase, IVBoolBoxNullableModel
    {
        private Property<bool?> _selectionBool;
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VBoolBoxNullableModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }

        public Property<bool?> Bool
        {
            get => _selectionBool;
            set => SetProperty(ref _selectionBool, value);
        }

        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }

        public void Selected(object sender, object e)
        {         
        }

    }
}