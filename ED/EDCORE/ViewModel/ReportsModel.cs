using System.Collections.ObjectModel;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using Abstractions.Stores.Content;
using DataObjects.DTOS;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{
    public class ReportsModel : GeneralModelBase, IReportsModel
    {
        private readonly IMockData _idal;

        public ObservableCollection<ReportDto> ReportsList => _idal.Reports;

        public ReportsModel(IWTTimer iWTimer, IMockData iMockData, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _idal = iMockData;
        }

        
    }
}