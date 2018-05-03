using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.ManagementPlans.Editors;
using Abstractions.Navigation;
using Abstractions.Stores;
using DataObjects;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.ManagementPlans
{
    public class AdminListEditModel : GeneralModelBase, IAdministrationEditorModel
    {
        private IManagementPlanAdminEFStore _adminStore;

        public AdminListEditModel(IWTTimer iWTimer, IManagementPlanAdminEFStore adminStore, IPlatformEventHandling iPlatformEventHandling,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ILinkContainer iManagementPlanLinkContainer, ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(  iPlatformEventHandling,iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _adminStore = adminStore;

            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "State")
                {
                    var adminEditDto = _adminStore.GetAdminEditDTO(ParentID);

                    //load data here
                    AdminEditDTO.Make(adminEditDto);
                }
            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("save command");

                _adminStore.UpdateAdminEditDTO(AdminEditDTO.ConvertToDto(),ParentID);

                OnPropertyChanged("State");
            });

            LoadPesticides = new RelayCommand((x) =>
            {           
                _iNavigation.Navigate(iManagementPlanLinkContainer.Pesticide.Editor(), StateContainer.Create(AdminEditDTO.ManagementUnitID.Value, false));
            });
        }

        public AdminEditDTOEdit AdminEditDTO { get; set; } = new AdminEditDTOEdit();

        public ICommand LoadPesticides { get; private set; }

        
    }
}
