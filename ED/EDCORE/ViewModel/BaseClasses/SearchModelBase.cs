using System;
using System.Diagnostics;
using System.Windows.Input;
using Abstractions;
using Abstractions.Navigation;
using DataObjects;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel
{
    public class SearchModelBase<T>: GeneralModelBase where T :class, new()
    {
        private IPlatformEventHandling _iPlatformEventHandling;

        protected T _selectedRecord;

        private bool _isDetailOpen;

        public ObservableRangeCollection<T> SelectedRecords { get; set; }
            = new ObservableRangeCollection<T>();

        public ObservableRangeCollection<T> SearchData { get; set; }
            = new ObservableRangeCollection<T>();

        public ICommand LoadData { get; set; }

        public ICommand AddData { get; set; }

        public SearchModelBase( IPlatformEventHandling iPlatformEventHandling, IWTTimer iWTimer,
            INavigation iNavigation,
            IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors,
            ICache iCache) : base(iPlatformEventHandling, iWTimer, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();
            _iPlatformEventHandling = iPlatformEventHandling;
        }

        public override void HandleMessage(EdMessage message)
        {
            //Debug.WriteLine("my instance : " + InstanceID + " " + message.EdEvent);

            if (IsDisposed) return;

            if (MessageFilter.FilterHandledMessages(message, InstanceID)) return;

            if (message.Data != null && message.Data is InstanceData instanceData && instanceData.InstanceID != InstanceID) return;



            if (message.EdEvent == EdEvent.PageChanged)
            {

            //    Debug.WriteLine("Search base : " +_iNavigation.CurrentLocation + message.Data);

                switch (_iNavigation.CurrentLocation)
                {
                    case "SafetyPage":
                      //  HeaderHeight = 36;
                        break;
                    case "TreePlantingSearchPage":
                   //     HeaderHeight = 36;
                        break;
                    case "PublicInformationPage":
                  //      HeaderHeight = 36;
                        break;
                    case "ManagementPlansPage":
                //        HeaderHeight = 36;
                        break;
                    case "InternalAuditsPage":
                    //    HeaderHeight = 36;
                        break;
                    case "AdminGeneralDetails":
                    //    HeaderHeight = 75;
                        break;
                    case "AdministrationList":
                    //    HeaderHeight = 75;
                        break;
                    case "GrantContractsList":
                   //     HeaderHeight = 36;
                        break;
                    case "ConditionAssessment":
                    //    HeaderHeight = 36;
                        break;
                    case "SummaryDescriptionList":
                    //    HeaderHeight = 36;
                        break;
                    case "ObjectivesKFList":
                   //     HeaderHeight = 36;
                        break;
                    case "WorkProgrammeList":
                      //  HeaderHeight = 36;
                        break;
                    case "PurchaseOrdersList":
                  //      HeaderHeight = 36;
                        break;
                    case "SalesOrdersList":
                   //     HeaderHeight = 36;
                        break;
                    case "MonitoringList":
               //         HeaderHeight = 36;
                        break;
                    case "HarvestingList":
                   //     HeaderHeight = 36;
                        break;
                    case "Tasks":
                  //      HeaderHeight = 36;
                        break;
                    case "PropertyPage":
                 //       HeaderHeight = 36;
                        break;
                    case "ReferenceInformationList":
                    //    HeaderHeight = 36;
                        break;
                    case "TreePlantingPage":
                   //     HeaderHeight = 36;
                        break;


                    default:
                     //   HeaderHeight = 36;
                        break;
                }
            }

            switch (message.EdEvent)
            {
                case EdEvent.PaneButtonClicked:
                    IsDetailOpen = !IsDetailOpen;
                    break;
                case EdEvent.AddButtonClicked:
                    AddData?.Execute(message);
                    break;
            }


           
        }


        public void RadGridSelectionChanged(object sender, object e)
        {
            var selectedRecords = _iPlatformEventHandling.IRadGridEventHandler.Process(sender, e);


            SelectedRecords.Clear();

            foreach (var a in selectedRecords.AddedRecords)
            {
                SelectedRecords.Add((T)a);
            }

            SelectedRecord = (T)selectedRecords.SelectedRecord;

            OnPropertyChanged("SelectedRecords");
            OnPropertyChanged("SelectedRecord");
        }

        public T SelectedRecord
        {
            get
            {
                if (SearchData.Count > 0)
                    return _selectedRecord ?? SearchData[0];
                else
                    return _selectedRecord;
            }
            set
            {
                if (_selectedRecord == value) return;
                _selectedRecord = value;
                OnPropertyChanged();
            }
        }

        public bool IsDetailOpen
        {
            get
            {
                return _isDetailOpen;
            }
            set
            {
                if (_isDetailOpen == value) return;

                Debug.WriteLine("IsDetailOpen : " + _isDetailOpen);

                _isDetailOpen = value;
                OnPropertyChanged();
            }
        }
    }
}