using System;
using System.Linq;
using Abstractions;
using Abstractions.Models;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class ObjectivesKfEditorModel : FlipModelBase<ObjectivesDTOEdit>, IObjectivesKfEditorModel
    {

        private readonly IUserPermissions _iUserStore;

        private IObjectiveStore _iObjectiveStore;
        private ILookupStore _iLookupStore;


        public ObjectivesKfEditorModel(IObjectiveStore iObjectiveStore, IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, ILookupStore iLookupStore,
            IUserPermissions iUserStore, object iDialogService,
            ICache iCache) : base(iWTimer, iPlatformEventHandling, iUserStore, iDialogService, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _iObjectiveStore = iObjectiveStore;

            _iUserStore = iUserStore;

            _iLookupStore = iLookupStore;

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    RecordsFlip.ReplaceRange(ObjectivesDTOEdit.MakeCollection(iObjectiveStore.GetObjectivesContainerEditDto(ParentID)));
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
                {
                    iObjectiveStore.UpdateObjectivesDTO(RecordsFlip.Select(v => v.ConvertToDto()).ToList(), ParentID);
                    OnPropertyChanged("State");
                }
            });

             
        }

        protected override void AddNew()
        {
            var fs = _iLookupStore.GetFeatures().Where(a=>a.ID >0);
            var ais = _iLookupStore.GetAIMDtos().Where(a => a.ID > 0);


            var newRecord = new ObjectivesDTOEdit();
            newRecord.Make(new ObjectivesDTO()
            {
                AimID = ais.First().ID,             
                KeyFeatureTypeID = fs.First().ID,
                Ref = "New Record"
            });

            RecordsFlip.AddItem(newRecord, true);

            EditRecord = newRecord;
        }

    }
}