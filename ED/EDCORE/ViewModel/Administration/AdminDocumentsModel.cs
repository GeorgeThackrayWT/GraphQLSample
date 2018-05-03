using System.Linq;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.Admin;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DTOS.AdministrationArea;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.Administration
{


    public class AdminDocumentsModel : FlipModelBase<AdminDocumentsDTOEdit>, IAdminDocumentsModel
    {
        private readonly IUserPermissions _iUserStore;

        private IGeneralAdminStore _iAdminStore;

        public AdminDocumentsModel(IWTTimer iWTimer, IPlatformEventHandling iPlatformEventHandling, IUserPermissions iUserStore, object iDialogService,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  IGeneralAdminStore iAdminStore,
            ITelerikConvertors iTelerikConvertors, ICache iCache) 
            : base(iWTimer, iPlatformEventHandling,  iUserStore, iDialogService, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            _iAdminStore = iAdminStore;

            _iUserStore = iUserStore;
            
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    RecordsFlip.ReplaceRange(AdminDocumentsDTOEdit.MakeCollection(_iAdminStore.GetAdminDocumentsDto(0)));
                    EditRecord = RecordsFlip?.First();
                    SaveEnabled = false;

                    if (State.NewRecord)
                    {
                        State.NewRecord = false;

                        AddNew();
                    }

                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                //     if (!_iUserStore.Check(UserActions.GroupB)) return;


                if (!RecordsFlip.Errors())
                    _iAdminStore.UpdateAdminDocumentsDTO(RecordsFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);
            });
        }

        protected override void AddNew()
        {
            var newRecord = new AdminDocumentsDTOEdit();
            newRecord.Make(new AdminDocumentsDTO());

            RecordsFlip.AddItem(newRecord, true);

            EditRecord = newRecord;
        }
    }
}