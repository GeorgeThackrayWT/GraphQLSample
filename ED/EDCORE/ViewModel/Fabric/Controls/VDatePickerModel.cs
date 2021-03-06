﻿using System;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Widgets
{
    public class VDatePickerModel : GeneralModelBase, IVDatePickerModel
    {
        private Property<DateTime?> _selection;
        private string _label;
        private bool _readOnly;

        public bool ReadOnly
        {
            get => _readOnly;
            set => SetProperty(ref _readOnly, value);
        }
        public VDatePickerModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
        }

        public Property<DateTime?> Selection
        {
            get => _selection;
            set => SetProperty(ref _selection, value);
        }

        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }


        public void Selected(object sender, object e)
        {
            _iPlatformEventHandling.DatePickerArgsHandler.Process(sender, e);

        }
    }
}