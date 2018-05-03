using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace DataObjects
{
    public class MonitoringEditDto : BaseDto, IRecord
    {
        public int ManagementUnitId { get; set; }
        public ComboBoxValue FeatureType { get; set; }
        public int FeatureID { get; set; }
        public DateTime PlannedObservationDate { get; set; }
        public DateTime? ActualObservationDate { get; set; }
        public DateTime? DeadlineActionDate { get; set; }
        public DateTime? ActualActionDate { get; set; }
        public string PredictionShortTermObjective { get; set; }
        public string PlannedObservation { get; set; }
        public string ActualObservation { get; set; }
        public string SuggestionsAndActions { get; set; }


        public MonitoringEditDto Clone()
        {
            return new MonitoringEditDto()
            {
                ManagementUnitId = this.ManagementUnitId,
                FeatureType = this.FeatureType,
                FeatureID = this.FeatureID,
                PlannedObservationDate = this.PlannedObservationDate,
                ActualObservationDate = this.ActualObservationDate,
                DeadlineActionDate = this.DeadlineActionDate,
                ActualActionDate = this.ActualActionDate,
                PredictionShortTermObjective = this.PredictionShortTermObjective,
                PlannedObservation = this.PlannedObservation,
                ActualObservation = this.ActualObservation,
                SuggestionsAndActions = this.SuggestionsAndActions,
            };
        }//endofclonemethods
    }


    public class MonitoringEditEdit : PropertyBase<MonitoringEditEdit>, IDuplicate
    {

        private MonitoringEditDto _dto;


        public MonitoringEditEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> FeatureType { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };
        public Property<int> FeatureID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<DateTime> PlannedObservationDate { get; set; } = new Property<DateTime>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> ActualObservationDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> DeadlineActionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> ActualActionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<string> PredictionShortTermObjective { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> PlannedObservation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> ActualObservation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> SuggestionsAndActions { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };




        public int RecordId => Id.Value;


        public MonitoringEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.FeatureType = FeatureType.Value;
            returnVal.FeatureID = FeatureID.Value;
            returnVal.PlannedObservationDate = PlannedObservationDate.Value;
            returnVal.ActualObservationDate = ActualObservationDate.Value;
            returnVal.DeadlineActionDate = DeadlineActionDate.Value;
            returnVal.ActualActionDate = ActualActionDate.Value;
            returnVal.PredictionShortTermObjective = PredictionShortTermObjective.Value;
            returnVal.PlannedObservation = PlannedObservation.Value;
            returnVal.ActualObservation = ActualObservation.Value;
            returnVal.SuggestionsAndActions = SuggestionsAndActions.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (MonitoringEditEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(MonitoringEditDto test)
        {
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId,ManagementUnitId);
            this.FeatureType = Property<ComboBoxValue>.Make(test.FeatureType,FeatureType);
            this.FeatureID = Property<int>.Make(test.FeatureID,FeatureID);
            this.PlannedObservationDate = Property<DateTime>.Make(test.PlannedObservationDate,PlannedObservationDate);
            this.ActualObservationDate = Property<DateTime?>.Make(test.ActualObservationDate,ActualObservationDate);
            this.DeadlineActionDate = Property<DateTime?>.Make(test.DeadlineActionDate,DeadlineActionDate);
            this.ActualActionDate = Property<DateTime?>.Make(test.ActualActionDate,ActualActionDate);
            this.PredictionShortTermObjective = Property<string>.Make(test.PredictionShortTermObjective,PredictionShortTermObjective);
            this.PlannedObservation = Property<string>.Make(test.PlannedObservation,PlannedObservation);
            this.ActualObservation = Property<string>.Make(test.ActualObservation,ActualObservation);
            this.SuggestionsAndActions = Property<string>.Make(test.SuggestionsAndActions,SuggestionsAndActions);
            this.Id = Property<int>.Make(test.Id,Id);

            this.SetPropChanged();

            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitId.Revert();
            FeatureType.Revert();
            FeatureID.Revert();
            PlannedObservationDate.Revert();
            ActualObservationDate.Revert();
            DeadlineActionDate.Revert();
            ActualActionDate.Revert();
            PredictionShortTermObjective.Revert();
            PlannedObservation.Revert();
            ActualObservation.Revert();
            SuggestionsAndActions.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<MonitoringEditEdit> MakeCollection(List<MonitoringEditDto> records)
        {

            var newData = new ExtRangeCollection<MonitoringEditEdit>();

            foreach (var rec in records)
            {
                var e = new MonitoringEditEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class MonitoringEditEditList : ListObj<MonitoringEditDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private MonitoringEditDto _dto;


        public MonitoringEditEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }
        public ComboBoxValue FeatureType { get => _current.FeatureType; set { _current.FeatureType = value; OnPropertyChanged(); } }
        public int FeatureID { get => _current.FeatureID; set { _current.FeatureID = value; OnPropertyChanged(); } }
        public DateTime PlannedObservationDate { get => _current.PlannedObservationDate; set { _current.PlannedObservationDate = value; OnPropertyChanged(); } }
        public DateTime? ActualObservationDate { get => _current.ActualObservationDate; set { _current.ActualObservationDate = value; OnPropertyChanged(); } }
        public DateTime? DeadlineActionDate { get => _current.DeadlineActionDate; set { _current.DeadlineActionDate = value; OnPropertyChanged(); } }
        public DateTime? ActualActionDate { get => _current.ActualActionDate; set { _current.ActualActionDate = value; OnPropertyChanged(); } }
        public string PredictionShortTermObjective { get => _current.PredictionShortTermObjective; set { _current.PredictionShortTermObjective = value; OnPropertyChanged(); } }
        public string PlannedObservation { get => _current.PlannedObservation; set { _current.PlannedObservation = value; OnPropertyChanged(); } }
        public string ActualObservation { get => _current.ActualObservation; set { _current.ActualObservation = value; OnPropertyChanged(); } }
        public string SuggestionsAndActions { get => _current.SuggestionsAndActions; set { _current.SuggestionsAndActions = value; OnPropertyChanged(); } }




        public int RecordId => Id;


        public MonitoringEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.FeatureType = this.FeatureType;
            returnVal.FeatureID = this.FeatureID;
            returnVal.PlannedObservationDate = this.PlannedObservationDate;
            returnVal.ActualObservationDate = this.ActualObservationDate;
            returnVal.DeadlineActionDate = this.DeadlineActionDate;
            returnVal.ActualActionDate = this.ActualActionDate;
            returnVal.PredictionShortTermObjective = this.PredictionShortTermObjective;
            returnVal.PlannedObservation = this.PlannedObservation;
            returnVal.ActualObservation = this.ActualObservation;
            returnVal.SuggestionsAndActions = this.SuggestionsAndActions;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (MonitoringEditEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(MonitoringEditDto test)
        {
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.FeatureType = test.FeatureType;
            _current.FeatureType = test.FeatureType;
            _original.FeatureID = test.FeatureID;
            _current.FeatureID = test.FeatureID;
            _original.PlannedObservationDate = test.PlannedObservationDate;
            _current.PlannedObservationDate = test.PlannedObservationDate;
            _original.ActualObservationDate = test.ActualObservationDate;
            _current.ActualObservationDate = test.ActualObservationDate;
            _original.DeadlineActionDate = test.DeadlineActionDate;
            _current.DeadlineActionDate = test.DeadlineActionDate;
            _original.ActualActionDate = test.ActualActionDate;
            _current.ActualActionDate = test.ActualActionDate;
            _original.PredictionShortTermObjective = test.PredictionShortTermObjective;
            _current.PredictionShortTermObjective = test.PredictionShortTermObjective;
            _original.PlannedObservation = test.PlannedObservation;
            _current.PlannedObservation = test.PlannedObservation;
            _original.ActualObservation = test.ActualObservation;
            _current.ActualObservation = test.ActualObservation;
            _original.SuggestionsAndActions = test.SuggestionsAndActions;
            _current.SuggestionsAndActions = test.SuggestionsAndActions;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<MonitoringEditEditList> MakeCollection(List<MonitoringEditDto> records)
        {

            var newData = new ExtRangeCollection<MonitoringEditEditList>();

            foreach (var rec in records)
            {
                var e = new MonitoringEditEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}