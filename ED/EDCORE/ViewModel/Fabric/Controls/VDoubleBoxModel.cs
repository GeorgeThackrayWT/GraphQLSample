using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VDoubleBoxModel : GeneralModelBase, IVDoubleBoxModel
    {       
        private Property<double> _selectionDouble;        
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VDoubleBoxModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }

        public Property<double> Double
        {
            get => _selectionDouble;
            set => SetProperty(ref _selectionDouble, value);
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

    public class VDoubleBoxNullableModel : GeneralModelBase, IVDoubleBoxNullableModel
    {
        private Property<double?> _selectionDouble;
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VDoubleBoxNullableModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }

        public Property<double?> Double
        {
            get => _selectionDouble;
            set => SetProperty(ref _selectionDouble, value);
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