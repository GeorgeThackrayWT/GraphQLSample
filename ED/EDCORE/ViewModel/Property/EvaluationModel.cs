using System;
using System.Diagnostics;
using System.Linq;
using Abstractions;
using Abstractions.Models;
using Abstractions.Navigation;

using Abstractions.Stores;
using DataObjects.DTOS.ManagementPlans.Editors;
using EDCORE.Helpers;
using MvvmHelpers;

namespace EDCORE.ViewModel.Property
{
    public class EvaluationModel : FlipModelBase<EvaluationEditEdit>, IEvaluationModel
    {
        private IReferenceInfoStore _referenceInfoStore;
  //      private ObservableRangeCollection<EvaluationEditDto> _evaluationsCollection;
   //     public ObservableRangeCollection<EvaluationEditDto> EvaluationsFlip { get; } = new ObservableRangeCollection<EvaluationEditDto>();

     //   private EvaluationEditDto _evaluationEditDto;

        private int _parentAcquistionUnit;
        private int _evaluationTypeID;


        public EvaluationModel(IReferenceInfoStore referenceInfoStore, IPlatformEventHandling iPlatformEventHandling, IUserPermissions iUserStore, IWTTimer iWTimer,
            INavigation iNavigation, IPageMessageBus iPageMessageBus,  ITelerikConvertors iTelerikConvertors, object iDialogService,
            ICache iCache) : base(iWTimer, iPlatformEventHandling,iUserStore, iDialogService, iNavigation,iPageMessageBus, iTelerikConvertors,iCache)
        {
            InstanceID = GetType().Name + Guid.NewGuid();

            _referenceInfoStore = referenceInfoStore;

       
            AddCommand = new RelayCommand((x) =>
            {
                AddNew();
            });

            SaveCommand = new RelayCommand((x) =>
            {
                _referenceInfoStore.UpdateEvaluations(RecordsFlip.Select(v => v.ConvertToDto()).ToList(), this.EvaluationTypeId, ParentAcquistionUnit);          
            });

            // load data when acquisition id property is set
            PropertyChanged += (sender, e) =>
            {

                Debug.WriteLine("loading: " + this.EvaluationTypeId + " " + this.ParentAcquistionUnit);


                if (e.PropertyName == "EvaluationTypeID" || e.PropertyName == "ParentAcquistionUnit")
                {

                 
                    Debug.WriteLine("loading evaluationid : " + this.EvaluationTypeId);

                    if (ParentAcquistionUnit != 0 && EvaluationTypeId!=0)
                    {
                      //  var result = _referenceInfoStore.GetEvaluations(ParentAcquistionUnit, EvaluationTypeId);


                        RecordsFlip.ReplaceRange(EvaluationEditEdit.MakeCollection(_referenceInfoStore.GetEvaluations(ParentAcquistionUnit, EvaluationTypeId)));

                        if(RecordsFlip !=null && RecordsFlip.Count> 0)
                            EditRecord = RecordsFlip.First();

                        SaveEnabled = false;
 
                    }

                }


               
            };


        }
        
        protected override void AddNew()
        {
            var newRecord = new EvaluationEditEdit();
            newRecord.Make(new EvaluationEditDto()
            {
                DateOfRecord = DateTime.Today,
                EvaluationTypeID = EvaluationTypeId,
                TypeOfInformationID = 1
            });

            RecordsFlip.AddItem(newRecord, true);

            EditRecord = newRecord;
        }

        public int ParentAcquistionUnit
        {
            get
            {
                return _parentAcquistionUnit;
            }

            set
            {
                _parentAcquistionUnit = value;
                OnPropertyChanged();
            }
        }

        public int EvaluationTypeId
        {
            get
            {
                return _evaluationTypeID;
            }

            set
            {
                _evaluationTypeID = value;
                OnPropertyChanged();
            }
        }
    }
}