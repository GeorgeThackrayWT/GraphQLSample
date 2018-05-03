using System.Collections.ObjectModel;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;
using Abstractions.Stores.Content;
using DataObjects.DTOS;
using EDCORE.Helpers;

namespace EDCORE.ViewModel
{



    public class DocumentsModel : GeneralModelBase, IDocumentsModel
    {     
        private readonly IMockData _mockData;

        public DocumentsModel(IMockData iMockData, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _mockData = iMockData;
        }

        public ObservableCollection<DocumentDto> DocumentsList => _mockData.Documents;
    }
}