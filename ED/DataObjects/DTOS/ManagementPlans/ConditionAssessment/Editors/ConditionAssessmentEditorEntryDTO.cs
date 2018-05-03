using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace DataObjects
{
    public class ConditionAssessmentEditorEntryDto : BaseDto, IRecord
    {
        public int FeatureMonitoringID { get; set; }
        public int FeatureID { get; set; }
        public string Description { get; set; }
        public int? WoodlandConditionExtensionID { get; set; }
        public DateTime PlannedObservationDate { get; set; }
        public DateTime? ActualObservationDate { get; set; }
        public DateTime? DeadlineActionDate { get; set; }
        public DateTime? ActualActionDate { get; set; }
        public string PredictionShortTermObjective { get; set; }
        public string ActualObservation { get; set; }
        public string PlannedObservation { get; set; }
        public string SuggestionsAndActions { get; set; }
        public string Surveyor { get; set; }//
        public double? AreaHa { get; set; }//
        public double? AreaAWHa { get; set; }//
        public double? ChangeInAreaAWSinceLastSurveyHa { get; set; }//
        public double? ChangeInAreaSinceLastSurveyHa { get; set; }//
        public bool? OverallDesirable { get; set; }//
        public bool? OverallAchievable { get; set; }//
        public string ConclusionsAndRecommendations { get; set; }//

        public ConditionAssessmentEditorEntryDto Clone()
        {
            return new ConditionAssessmentEditorEntryDto()
            {
                FeatureMonitoringID = this.FeatureMonitoringID,
                FeatureID = this.FeatureID,
                Description = this.Description,
                WoodlandConditionExtensionID = this.WoodlandConditionExtensionID,
                PlannedObservationDate = this.PlannedObservationDate,
                ActualObservationDate = this.ActualObservationDate,
                DeadlineActionDate = this.DeadlineActionDate,
                ActualActionDate = this.ActualActionDate,
                PredictionShortTermObjective = this.PredictionShortTermObjective,
                ActualObservation = this.ActualObservation,
                PlannedObservation = this.PlannedObservation,
                SuggestionsAndActions = this.SuggestionsAndActions,
                Surveyor = this.Surveyor,
                AreaHa = this.AreaHa,
                AreaAWHa = this.AreaAWHa,
                ChangeInAreaAWSinceLastSurveyHa = this.ChangeInAreaAWSinceLastSurveyHa,
                ChangeInAreaSinceLastSurveyHa = this.ChangeInAreaSinceLastSurveyHa,
                OverallDesirable = this.OverallDesirable,
                OverallAchievable = this.OverallAchievable,
                ConclusionsAndRecommendations = this.ConclusionsAndRecommendations,
            };
        }//endofclonemethods
    }

    public class ConditionAssessmentEditorEntryDtoEdit : PropertyBase<ConditionAssessmentEditorEntryDtoEdit>, IDuplicate
    {

        private ConditionAssessmentEditorEntryDto _dto;


        public ConditionAssessmentEditorEntryDtoEdit()
        {

            this.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
            //    Debug.WriteLine("hello there: " + e.PropertyName);
            };

            this.Validator = e =>
            {
                
            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor
 

        public Property<int> FeatureMonitoringID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> FeatureID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int?> WoodlandConditionExtensionID { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<DateTime> PlannedObservationDate { get; set; } = new Property<DateTime>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> ActualObservationDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> DeadlineActionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> ActualActionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<string> PredictionShortTermObjective { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> ActualObservation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> PlannedObservation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> SuggestionsAndActions { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Surveyor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<double?> AreaHa { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> AreaAWHa { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> ChangeInAreaAWSinceLastSurveyHa { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> ChangeInAreaSinceLastSurveyHa { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<bool?> OverallDesirable { get; set; } = new Property<bool?>() { Value = false, Original = false };
        public Property<bool?> OverallAchievable { get; set; } = new Property<bool?>() { Value = false, Original = false };
        public Property<string> ConclusionsAndRecommendations { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public ConditionAssessmentEditorEntryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureMonitoringID = FeatureMonitoringID.Value;
            returnVal.FeatureID = FeatureID.Value;
            returnVal.Description = Description.Value;
            returnVal.WoodlandConditionExtensionID = WoodlandConditionExtensionID.Value;
            returnVal.PlannedObservationDate = PlannedObservationDate.Value;
            returnVal.ActualObservationDate = ActualObservationDate.Value;
            returnVal.DeadlineActionDate = DeadlineActionDate.Value;
            returnVal.ActualActionDate = ActualActionDate.Value;
            returnVal.PredictionShortTermObjective = PredictionShortTermObjective.Value;
            returnVal.ActualObservation = ActualObservation.Value;
            returnVal.PlannedObservation = PlannedObservation.Value;
            returnVal.SuggestionsAndActions = SuggestionsAndActions.Value;
            returnVal.Surveyor = Surveyor.Value;
            returnVal.AreaHa = AreaHa.Value;
            returnVal.AreaAWHa = AreaAWHa.Value;
            returnVal.ChangeInAreaAWSinceLastSurveyHa = ChangeInAreaAWSinceLastSurveyHa.Value;
            returnVal.ChangeInAreaSinceLastSurveyHa = ChangeInAreaSinceLastSurveyHa.Value;
            returnVal.OverallDesirable = OverallDesirable.Value;
            returnVal.OverallAchievable = OverallAchievable.Value;
            returnVal.ConclusionsAndRecommendations = ConclusionsAndRecommendations.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ConditionAssessmentEditorEntryDtoEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ConditionAssessmentEditorEntryDto test)
        {
            this.FeatureMonitoringID = Property<int>.Make(test.FeatureMonitoringID,FeatureMonitoringID);
            this.FeatureID = Property<int>.Make(test.FeatureID,FeatureID);
            this.Description = Property<string>.Make(test.Description,Description);
            this.WoodlandConditionExtensionID = Property<int?>.Make(test.WoodlandConditionExtensionID,WoodlandConditionExtensionID);
            this.PlannedObservationDate = Property<DateTime>.Make(test.PlannedObservationDate,PlannedObservationDate);
            this.ActualObservationDate = Property<DateTime?>.Make(test.ActualObservationDate,ActualObservationDate);
            this.DeadlineActionDate = Property<DateTime?>.Make(test.DeadlineActionDate,DeadlineActionDate);
            this.ActualActionDate = Property<DateTime?>.Make(test.ActualActionDate,ActualActionDate);
            this.PredictionShortTermObjective = Property<string>.Make(test.PredictionShortTermObjective,PredictionShortTermObjective);
            this.ActualObservation = Property<string>.Make(test.ActualObservation,ActualObservation);
            this.PlannedObservation = Property<string>.Make(test.PlannedObservation,PlannedObservation);
            this.SuggestionsAndActions = Property<string>.Make(test.SuggestionsAndActions,SuggestionsAndActions);
            this.Surveyor = Property<string>.Make(test.Surveyor, Surveyor, "Surveyor");
            this.AreaHa = Property<double?>.Make(test.AreaHa,AreaHa);
            this.AreaAWHa = Property<double?>.Make(test.AreaAWHa,AreaAWHa);
            this.ChangeInAreaAWSinceLastSurveyHa = Property<double?>.Make(test.ChangeInAreaAWSinceLastSurveyHa,ChangeInAreaAWSinceLastSurveyHa);
            this.ChangeInAreaSinceLastSurveyHa = Property<double?>.Make(test.ChangeInAreaSinceLastSurveyHa,ChangeInAreaSinceLastSurveyHa);
            this.OverallDesirable = Property<bool?>.Make(test.OverallDesirable,OverallDesirable);
            this.OverallAchievable = Property<bool?>.Make(test.OverallAchievable,OverallAchievable);
            this.ConclusionsAndRecommendations = Property<string>.Make(test.ConclusionsAndRecommendations,ConclusionsAndRecommendations);
            this.Id = Property<int>.Make(test.Id,Id);

            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            FeatureMonitoringID.Revert();
            FeatureID.Revert();
            Description.Revert();
            WoodlandConditionExtensionID.Revert();
            PlannedObservationDate.Revert();
            ActualObservationDate.Revert();
            DeadlineActionDate.Revert();
            ActualActionDate.Revert();
            PredictionShortTermObjective.Revert();
            ActualObservation.Revert();
            PlannedObservation.Revert();
            SuggestionsAndActions.Revert();
            Surveyor.Revert();
            AreaHa.Revert();
            AreaAWHa.Revert();
            ChangeInAreaAWSinceLastSurveyHa.Revert();
            ChangeInAreaSinceLastSurveyHa.Revert();
            OverallDesirable.Revert();
            OverallAchievable.Revert();
            ConclusionsAndRecommendations.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ConditionAssessmentEditorEntryDtoEdit> MakeCollection(List<ConditionAssessmentEditorEntryDto> records)
        {

            var newData = new ExtRangeCollection<ConditionAssessmentEditorEntryDtoEdit>();

            foreach (var rec in records)
            {
                var e = new ConditionAssessmentEditorEntryDtoEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class ConditionAssessmentEditorEntryDtoEditList : ListObj<ConditionAssessmentEditorEntryDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ConditionAssessmentEditorEntryDto _dto;


        public ConditionAssessmentEditorEntryDtoEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int FeatureMonitoringID { get => _current.FeatureMonitoringID; set { _current.FeatureMonitoringID = value; OnPropertyChanged(); } }
        public int FeatureID { get => _current.FeatureID; set { _current.FeatureID = value; OnPropertyChanged(); } }
        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }
        public int? WoodlandConditionExtensionID { get => _current.WoodlandConditionExtensionID; set { _current.WoodlandConditionExtensionID = value; OnPropertyChanged(); } }
        public DateTime PlannedObservationDate { get => _current.PlannedObservationDate; set { _current.PlannedObservationDate = value; OnPropertyChanged(); } }
        public DateTime? ActualObservationDate { get => _current.ActualObservationDate; set { _current.ActualObservationDate = value; OnPropertyChanged(); } }
        public DateTime? DeadlineActionDate { get => _current.DeadlineActionDate; set { _current.DeadlineActionDate = value; OnPropertyChanged(); } }
        public DateTime? ActualActionDate { get => _current.ActualActionDate; set { _current.ActualActionDate = value; OnPropertyChanged(); } }
        public string PredictionShortTermObjective { get => _current.PredictionShortTermObjective; set { _current.PredictionShortTermObjective = value; OnPropertyChanged(); } }
        public string ActualObservation { get => _current.ActualObservation; set { _current.ActualObservation = value; OnPropertyChanged(); } }
        public string PlannedObservation { get => _current.PlannedObservation; set { _current.PlannedObservation = value; OnPropertyChanged(); } }
        public string SuggestionsAndActions { get => _current.SuggestionsAndActions; set { _current.SuggestionsAndActions = value; OnPropertyChanged(); } }
        public string Surveyor { get => _current.Surveyor; set { _current.Surveyor = value; OnPropertyChanged(); } }
        public double? AreaHa { get => _current.AreaHa; set { _current.AreaHa = value; OnPropertyChanged(); } }
        public double? AreaAWHa { get => _current.AreaAWHa; set { _current.AreaAWHa = value; OnPropertyChanged(); } }
        public double? ChangeInAreaAWSinceLastSurveyHa { get => _current.ChangeInAreaAWSinceLastSurveyHa; set { _current.ChangeInAreaAWSinceLastSurveyHa = value; OnPropertyChanged(); } }
        public double? ChangeInAreaSinceLastSurveyHa { get => _current.ChangeInAreaSinceLastSurveyHa; set { _current.ChangeInAreaSinceLastSurveyHa = value; OnPropertyChanged(); } }
        public bool? OverallDesirable { get => _current.OverallDesirable; set { _current.OverallDesirable = value; OnPropertyChanged(); } }
        public bool? OverallAchievable { get => _current.OverallAchievable; set { _current.OverallAchievable = value; OnPropertyChanged(); } }
        public string ConclusionsAndRecommendations { get => _current.ConclusionsAndRecommendations; set { _current.ConclusionsAndRecommendations = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public ConditionAssessmentEditorEntryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureMonitoringID = this.FeatureMonitoringID;
            returnVal.FeatureID = this.FeatureID;
            returnVal.Description = this.Description;
            returnVal.WoodlandConditionExtensionID = this.WoodlandConditionExtensionID;
            returnVal.PlannedObservationDate = this.PlannedObservationDate;
            returnVal.ActualObservationDate = this.ActualObservationDate;
            returnVal.DeadlineActionDate = this.DeadlineActionDate;
            returnVal.ActualActionDate = this.ActualActionDate;
            returnVal.PredictionShortTermObjective = this.PredictionShortTermObjective;
            returnVal.ActualObservation = this.ActualObservation;
            returnVal.PlannedObservation = this.PlannedObservation;
            returnVal.SuggestionsAndActions = this.SuggestionsAndActions;
            returnVal.Surveyor = this.Surveyor;
            returnVal.AreaHa = this.AreaHa;
            returnVal.AreaAWHa = this.AreaAWHa;
            returnVal.ChangeInAreaAWSinceLastSurveyHa = this.ChangeInAreaAWSinceLastSurveyHa;
            returnVal.ChangeInAreaSinceLastSurveyHa = this.ChangeInAreaSinceLastSurveyHa;
            returnVal.OverallDesirable = this.OverallDesirable;
            returnVal.OverallAchievable = this.OverallAchievable;
            returnVal.ConclusionsAndRecommendations = this.ConclusionsAndRecommendations;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ConditionAssessmentEditorEntryDtoEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ConditionAssessmentEditorEntryDto test)
        {
            _original.FeatureMonitoringID = test.FeatureMonitoringID;
            _current.FeatureMonitoringID = test.FeatureMonitoringID;
            _original.FeatureID = test.FeatureID;
            _current.FeatureID = test.FeatureID;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.WoodlandConditionExtensionID = test.WoodlandConditionExtensionID;
            _current.WoodlandConditionExtensionID = test.WoodlandConditionExtensionID;
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
            _original.ActualObservation = test.ActualObservation;
            _current.ActualObservation = test.ActualObservation;
            _original.PlannedObservation = test.PlannedObservation;
            _current.PlannedObservation = test.PlannedObservation;
            _original.SuggestionsAndActions = test.SuggestionsAndActions;
            _current.SuggestionsAndActions = test.SuggestionsAndActions;
            _original.Surveyor = test.Surveyor;
            _current.Surveyor = test.Surveyor;
            _original.AreaHa = test.AreaHa;
            _current.AreaHa = test.AreaHa;
            _original.AreaAWHa = test.AreaAWHa;
            _current.AreaAWHa = test.AreaAWHa;
            _original.ChangeInAreaAWSinceLastSurveyHa = test.ChangeInAreaAWSinceLastSurveyHa;
            _current.ChangeInAreaAWSinceLastSurveyHa = test.ChangeInAreaAWSinceLastSurveyHa;
            _original.ChangeInAreaSinceLastSurveyHa = test.ChangeInAreaSinceLastSurveyHa;
            _current.ChangeInAreaSinceLastSurveyHa = test.ChangeInAreaSinceLastSurveyHa;
            _original.OverallDesirable = test.OverallDesirable;
            _current.OverallDesirable = test.OverallDesirable;
            _original.OverallAchievable = test.OverallAchievable;
            _current.OverallAchievable = test.OverallAchievable;
            _original.ConclusionsAndRecommendations = test.ConclusionsAndRecommendations;
            _current.ConclusionsAndRecommendations = test.ConclusionsAndRecommendations;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList> MakeCollection(List<ConditionAssessmentEditorEntryDto> records)
        {

            var newData = new ExtRangeCollection<ConditionAssessmentEditorEntryDtoEditList>();

            foreach (var rec in records)
            {
                var e = new ConditionAssessmentEditorEntryDtoEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}