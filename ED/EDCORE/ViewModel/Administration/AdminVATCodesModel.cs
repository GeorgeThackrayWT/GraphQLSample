using Abstractions;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Administration
{
    public class AdminVATCodesModel : GeneralModelBase, IAdminVATCodesModel
    {
        private IGeneralAdminStore _iAdminStore;

        private ObservableRangeCollection<SectionDescriptionDto> _sectionLookupCollection = new ObservableRangeCollection<SectionDescriptionDto>();

          

        public AdminVATCodesModel(IGeneralAdminStore iAdminStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors, iCache)
        {
            _iAdminStore = iAdminStore;

            _sectionLookupCollection.AddRange(iAdminStore.GetSectionLookups());

             VatCodes = _iAdminStore.GetAdminVATCodes(0);
        }

        public AdminVATCodeCollection VatCodes { get; set; }

        public ObservableRangeCollection<SectionDescriptionDto> SectionLookup
        {
            get { return _sectionLookupCollection; }

            set { _sectionLookupCollection = value; }
        }
    }
}