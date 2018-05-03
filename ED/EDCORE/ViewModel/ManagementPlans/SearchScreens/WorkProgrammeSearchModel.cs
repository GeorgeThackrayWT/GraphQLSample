﻿using System;
using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class WorkProgrammeSearchModel : SearchModelBase<WorkProgrammeListDTO>, IGeneralManagementPlanSearchModel<WorkProgrammeListDTO>
    {
        private IManagementPlanStore _iStoreManager;

        public WorkProgrammeSearchModel(IManagementPlanStore iStoreManager, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iStoreManager = iStoreManager;

            PropertyChanged += (sender, e) =>
            {

            };

            LoadData = new RelayCommand((x) =>
            {
                if(_selectedRecord!=null)
                    _iNavigation.Navigate(iManagementPlanLinkContainer.WorkProgramme.Editor(), StateContainer.Create(_selectedRecord.ManagementUnitID, false));
            });
            
            GetData(_iStoreManager, iCache);
        }

        private void GetData(IManagementPlanStore iStoreManager, ICache iCache)
        {
            var items = iStoreManager.GetWorkProgrammeListDtos(iCache.CurrentUserRole(), iCache.CurrentUser(), iCache.GetApplication(),
                iCache.CurrentUserRegion());

            SearchData = new ObservableRangeCollection<WorkProgrammeListDTO>();

            SearchData.ReplaceRange(items);

            if (SearchData.Count > 0)
                this.SelectedRecord = SearchData.First();

            OnPropertyChanged("SearchData");
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (message.EdEvent == EdEvent.ApplicationChanged)
            {
                if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

                GetData(_iStoreManager, _iCache);
            }
            else
            {
                base.HandleMessage(message);
            }
        }
    }
}