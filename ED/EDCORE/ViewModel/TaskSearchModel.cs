using System;
using System.Linq;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using DataObjects.DTOS;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{

    public class TaskSearchModel : SearchModelBase<EdTaskDto>, IGeneralManagementPlanSearchModel<EdTaskDto>
    {     
        private readonly ITaskStore _taskStore;
        private readonly ICache _iCache;

        public TaskSearchModel(IWTTimer iWTimer, ITaskStore iTaskStore, IPlatformEventHandling 
            iPlatformEventHandling, INavigation iNavigation, ITelerikConvertors iTelerikConvertors,
            IPageMessageBus iPageMessageBus,  ICache iCache) : 
            base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _taskStore = iTaskStore;
            _iCache = iCache;

            SearchRange = DateOption.Today;
            SelectedManagementUnit = 0;

            GetData();


            LoadData = new RelayCommand((x) =>
            {
         
            });
        }

        public DateOption SearchRange { get; set; }

        public int SelectedManagementUnit { get; set; }
        
        
        private void GetData()
        {
            var items = _taskStore.GetTasks(_iCache.CurrentUserRole(), _iCache.CurrentUser(), _iCache.GetApplication(), _iCache.CurrentUserRegion(),
                new DateRangeFilter {DateRange = this.SearchRange}, this.SelectedManagementUnit);

            SearchData = new ObservableRangeCollection<EdTaskDto>();
            SearchData.ReplaceRange(items);

            if (SearchData.Count > 0)
                this.SelectedRecord = SearchData.First();

            OnPropertyChanged("SearchData");
        }

        public override void HandleMessage(EdMessage message)
        {
            if (IsDisposed) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            switch (message.EdEvent)
            {
                case EdEvent.AppConSelectionChanged:

                    var menuItem = (MenuDTO) message.Data;
                    var tpRange = SearchRange;

                    switch (menuItem.Destination)
                    {
                        case "taskall":
                            tpRange = DateOption.All;
                            break;
                        case "taskyear":
                            tpRange = DateOption.Year;
                            break;
                        case "taskmonth":
                            tpRange = DateOption.Month;
                            break;
                        case "taskweek":
                            tpRange = DateOption.Week;
                            break;
                        case "taskstoday":
                            tpRange = DateOption.Today;
                            break;
                    }

                    if (tpRange != SearchRange)
                    {
                        SearchRange = tpRange;
                        GetData();
                    }

                    break;
                
                case EdEvent.ManagementUnitChanged:
                    int managementUnitId = (int)message.Data;
                    SelectedManagementUnit = managementUnitId;
  
                    break;

            }

            base.HandleMessage(message);

        }
    }
}
