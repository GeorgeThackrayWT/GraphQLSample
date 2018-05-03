using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using Abstractions.Models.PublicInformation;
using Abstractions.Navigation;
using Abstractions.Stores.Content.PublicInformation;
using DataObjects;
using DataObjects.DTOS.PublicInformationDtos;
using EDCORE.Helpers;
using EDCORE.ViewModel.Property.Interfaces;

namespace EDCORE.ViewModel.PublicInformation.Editors
{
    public class PublicInfoEditorModel : GeneralModelBase, IPublicInfoEditorModel
    {
        private bool _suitableForFilmingVisible;
        private bool _specialSiteFeaturesVisible;
        private bool _partOfVisible;
        private bool _localNameWhyVisible;
        private bool _directoryInfoVisible;
        private bool _antiSocialVisible;
        private bool _extendedInfoVisible =true;

        private PublicInformationEdit _selectedRow;

        private IPublicInformationStore _publicInformationStore;


        public PublicInformationEdit EditRecord
        {
            get
            {
                return _selectedRow;
            }

            set
            {
                _selectedRow =value;
                OnPropertyChanged();
            }
        }

        #region commands
        public ICommand ExtendedInfo { get; }
        public ICommand AntiSocialIssues { get; }
        public ICommand ATHRegister { get; }
        public ICommand DirectoryInfo { get; }
        public ICommand PartOf { get; }
        public ICommand LocalNameWhy { get; }
        public ICommand LocationMap { get; }
        public ICommand OperationsPosters { get; }
        public ICommand OtherSiteMaterial { get; }
        public ICommand PhotoLibrary { get; }
        public ICommand PublicEvents { get; }
        public ICommand SpecialSiteFeatures { get; }
        public ICommand SuitableForFilming { get; }
        public ICommand VisitorAccessMap { get; }
        public ICommand WoodMicrosite { get; }

        #endregion

        public PublicInfoEditorModel(IWTTimer iWTimer, IPublicInformationStore iPublicInformationStore, IPlatformEventHandling iPlatformEventHandling,
               INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
               ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _publicInformationStore = iPublicInformationStore;

            EditRecord = new PublicInformationEdit();

            PropertyChanged += (sender, e) =>
            {
                switch (e.PropertyName)
                {
                    case "State":
                        var publicInformationRecord = _publicInformationStore.GetPublicInformationDto(ParentID);
                        EditRecord.Make(publicInformationRecord) ;
                        break;
                }

            };

            SaveCommand = new RelayCommand((x) =>
            {
                Debug.WriteLine("tender saved");

                _publicInformationStore.UpdatePublicInformation(EditRecord.ConvertToDto(),ParentID);

                OnPropertyChanged("State");
            });

            //hide show
            PartOf = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                LocalNameWhyVisible = false;
                AntiSocialVisible = false;
                SpecialSiteFeaturesVisible = false;
                SuitableForFilmingVisible = false;
                DirectoryInfoVisible = false;

                PartOfVisible = !PartOfVisible;

                if (!PartOfVisible) ExtendedInfoVisible = true;
            });

            ExtendedInfo = new RelayCommand((x) =>
            {
                AntiSocialVisible = false;
                SpecialSiteFeaturesVisible = false;
                SuitableForFilmingVisible = false;
                DirectoryInfoVisible = false;
                PartOfVisible = false;
                LocalNameWhyVisible = false;

                ExtendedInfoVisible = !ExtendedInfoVisible;

               // if (!ExtendedInfoVisible) ExtendedInfoVisible = true;
            });

            LocalNameWhy = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                AntiSocialVisible = false;
                SpecialSiteFeaturesVisible = false;
                SuitableForFilmingVisible = false;
                DirectoryInfoVisible = false;
                PartOfVisible = false;

                LocalNameWhyVisible = !LocalNameWhyVisible;

                if (!LocalNameWhyVisible) ExtendedInfoVisible = true;
            });

            AntiSocialIssues = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                SpecialSiteFeaturesVisible = false;
                SuitableForFilmingVisible = false;
                DirectoryInfoVisible = false;
                PartOfVisible = false;
                LocalNameWhyVisible = false;

                AntiSocialVisible = !AntiSocialVisible;

                if (!AntiSocialVisible) ExtendedInfoVisible = true;
            });

            SpecialSiteFeatures = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                SuitableForFilmingVisible = false;
                DirectoryInfoVisible = false;
                PartOfVisible = false;
                LocalNameWhyVisible = false;
                AntiSocialVisible = false;

                SpecialSiteFeaturesVisible = !SpecialSiteFeaturesVisible;

                if (!SpecialSiteFeaturesVisible) ExtendedInfoVisible = true;
            });

            SuitableForFilming = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                DirectoryInfoVisible = false;
                PartOfVisible = false;
                LocalNameWhyVisible = false;
                AntiSocialVisible = false;
                SpecialSiteFeaturesVisible = false;

                SuitableForFilmingVisible = !SuitableForFilmingVisible;

                if (!SuitableForFilmingVisible) ExtendedInfoVisible = true;
            });

            DirectoryInfo = new RelayCommand((x) =>
            {
                ExtendedInfoVisible = false;
                PartOfVisible = false;
                LocalNameWhyVisible = false;
                AntiSocialVisible = false;
                SpecialSiteFeaturesVisible = false;
                SuitableForFilmingVisible = false;

                DirectoryInfoVisible = !DirectoryInfoVisible;

                if (!DirectoryInfoVisible) ExtendedInfoVisible = true;
            });
            

            #region external event calls

            VisitorAccessMap = new RelayCommand((x) =>
            {

            });
            
            PublicEvents = new RelayCommand((x) =>
            {

            });
            LocationMap = new RelayCommand((x) =>
            {

            });
            OperationsPosters = new RelayCommand((x) =>
            {

            });

            OtherSiteMaterial = new RelayCommand((x) =>
            {

            });

            PhotoLibrary = new RelayCommand((x) =>
            {

            });
            WoodMicrosite = new RelayCommand((x) =>
            {

            });

            #endregion

        }


        public override void HandleMessage(EdMessage message)
        {
            //REMEMBER
            //if we override this method in a derived class 
            //then messages will need to be handled at that point
            //so for example an addcommand would need to be 
            //invoked at that point.

            //       Debug.WriteLine("received on: "+ InstanceID);

            if (this._disposed)
            {
                Debug.WriteLine("Message received on disposed object:" + InstanceID);
                return;
            }

            InstanceData messageInstanceData = message.Data as InstanceData;

            if (message.BaseIgnore) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;


            // so unless its an instance changed event. ie we are changing the focused (the instance variable) control 
            // then we want to check the buttons are being clicked on the focused instance.


            switch (message.EdEvent)
            {

                case EdEvent.SaveButtonClicked:
                    SaveCommand?.Execute(message.Data);
                    break;

            }
        }

        public bool PartOfVisible
        {
            get
            {
                return _partOfVisible;
            }

            set
            {
                _partOfVisible = value;
                OnPropertyChanged();
            }
        }

        public bool AntiSocialVisible
        {
            get
            {
               return _antiSocialVisible;
            }

            set
            {
                _antiSocialVisible = value;
                OnPropertyChanged();
            }
        }
        
        public bool DirectoryInfoVisible
        {
            get
            {
                return _directoryInfoVisible;
            }

            set
            {
                _directoryInfoVisible =value;
                OnPropertyChanged();
            }
        }
        
        public bool LocalNameWhyVisible
        {
            get
            {
                return _localNameWhyVisible;
            }

            set
            {
                _localNameWhyVisible = value;
                OnPropertyChanged();
            }
        }
        
        public bool SpecialSiteFeaturesVisible
        {
            get
            {
               return _specialSiteFeaturesVisible;
            }

            set
            {
                _specialSiteFeaturesVisible = value;
                OnPropertyChanged();
            }
        }

        
        public bool SuitableForFilmingVisible
        {
            get { return _suitableForFilmingVisible; }

            set
            {
                _suitableForFilmingVisible = value;
                OnPropertyChanged();
            }
        }

        public bool ExtendedInfoVisible
        {
            get { return _extendedInfoVisible; }

            set
            {
                _extendedInfoVisible = value;
                OnPropertyChanged();
            }
        }

       
    }
}
