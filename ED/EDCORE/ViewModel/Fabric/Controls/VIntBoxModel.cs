using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VIntBoxModel : GeneralModelBase, IVIntBoxModel
    {
        private Property<int> _selectionInt;
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VIntBoxModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }
      
        public Property<int> Int
        {
            get => _selectionInt;
            set => SetProperty(ref _selectionInt, value);
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

    public class VIntBoxNullableModel : GeneralModelBase, IVIntBoxNullableModel
    {
        private Property<int?> _selectionInt;
        private string _label;

        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }

        public VIntBoxNullableModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }

        public Property<int?> Int
        {
            get => _selectionInt;
            set => SetProperty(ref _selectionInt, value);
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