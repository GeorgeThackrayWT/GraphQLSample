using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class HazardActionDto : BaseDto, IRecord
    {
        public int HazardId { get; set; }

        public string Description { get; set; }

        public int SeverityProbabilityOfHarmId { get; set; }

        public string FurtherAction { get; set; }

        public DateTime? InspectionDeadlineDate { get; set; }

        public DateTime? InspectionActualDate { get; set; }

        public bool InspectionReportMap { get; set; }

        public int ResidualRiskLevel { get; set; }

        public int FollowOnActionId { get; set; }

        public DateTime? FollowOnDeadlineDate { get; set; }

        public DateTime? FollowOnCompleteDate { get; set; }

        public int ResidualRiskLevelId { get; set; }
        public HazardActionDto Clone()
        {
            return new HazardActionDto()
            {
                HazardId = this.HazardId,
                Description = this.Description,
                SeverityProbabilityOfHarmId = this.SeverityProbabilityOfHarmId,
                FurtherAction = this.FurtherAction,
                InspectionDeadlineDate = this.InspectionDeadlineDate,
                InspectionActualDate = this.InspectionActualDate,
                InspectionReportMap = this.InspectionReportMap,
                ResidualRiskLevel = this.ResidualRiskLevel,
                FollowOnActionId = this.FollowOnActionId,
                FollowOnDeadlineDate = this.FollowOnDeadlineDate,
                FollowOnCompleteDate = this.FollowOnCompleteDate,
                ResidualRiskLevelId = this.ResidualRiskLevelId,
            };
        }//endofclonemethods
    }

    public class HazardActionEdit : PropertyBase<HazardActionEdit>, IDuplicate
    {

        private HazardActionDto _dto;


        public HazardActionEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> HazardId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> SeverityProbabilityOfHarmId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> FurtherAction { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> InspectionDeadlineDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> InspectionActualDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> InspectionReportMap { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> ResidualRiskLevel { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> FollowOnActionId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> FollowOnDeadlineDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> FollowOnCompleteDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> ResidualRiskLevelId { get; set; } = new Property<int>() { Value = 0, Original = 0 };


        public int RecordId => Id.Value;


        public HazardActionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.HazardId = HazardId.Value;
            returnVal.Description = Description.Value;
            returnVal.SeverityProbabilityOfHarmId = SeverityProbabilityOfHarmId.Value;
            returnVal.FurtherAction = FurtherAction.Value;
            returnVal.InspectionDeadlineDate = InspectionDeadlineDate.Value;
            returnVal.InspectionActualDate = InspectionActualDate.Value;
            returnVal.InspectionReportMap = InspectionReportMap.Value;
            returnVal.ResidualRiskLevel = ResidualRiskLevel.Value;
            returnVal.FollowOnActionId = FollowOnActionId.Value;
            returnVal.FollowOnDeadlineDate = FollowOnDeadlineDate.Value;
            returnVal.FollowOnCompleteDate = FollowOnCompleteDate.Value;
            returnVal.ResidualRiskLevelId = ResidualRiskLevelId.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardActionEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardActionDto test)
        {
            this.HazardId = Property<int>.Make(test.HazardId);
            this.Description = Property<string>.Make(test.Description);
            this.SeverityProbabilityOfHarmId = Property<int>.Make(test.SeverityProbabilityOfHarmId);
            this.FurtherAction = Property<string>.Make(test.FurtherAction);
            this.InspectionDeadlineDate = Property<DateTime?>.Make(test.InspectionDeadlineDate);
            this.InspectionActualDate = Property<DateTime?>.Make(test.InspectionActualDate);
            this.InspectionReportMap = Property<bool>.Make(test.InspectionReportMap);
            this.ResidualRiskLevel = Property<int>.Make(test.ResidualRiskLevel);
            this.FollowOnActionId = Property<int>.Make(test.FollowOnActionId);
            this.FollowOnDeadlineDate = Property<DateTime?>.Make(test.FollowOnDeadlineDate);
            this.FollowOnCompleteDate = Property<DateTime?>.Make(test.FollowOnCompleteDate);
            this.ResidualRiskLevelId = Property<int>.Make(test.ResidualRiskLevelId);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            HazardId.Revert();
            Description.Revert();
            SeverityProbabilityOfHarmId.Revert();
            FurtherAction.Revert();
            InspectionDeadlineDate.Revert();
            InspectionActualDate.Revert();
            InspectionReportMap.Revert();
            ResidualRiskLevel.Revert();
            FollowOnActionId.Revert();
            FollowOnDeadlineDate.Revert();
            FollowOnCompleteDate.Revert();
            ResidualRiskLevelId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<HazardActionEdit> MakeCollection(List<HazardActionDto> records)
        {

            var newData = new ExtRangeCollection<HazardActionEdit>();

            foreach (var rec in records)
            {
                var e = new HazardActionEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class HazardActionEditList : ListObj<HazardActionDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private HazardActionDto _dto;


        public HazardActionEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int HazardId { get => _current.HazardId; set { _current.HazardId = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public int SeverityProbabilityOfHarmId { get => _current.SeverityProbabilityOfHarmId; set { _current.SeverityProbabilityOfHarmId = value; OnPropertyChanged(); } }

        public string FurtherAction { get => _current.FurtherAction; set { _current.FurtherAction = value; OnPropertyChanged(); } }

        public DateTime? InspectionDeadlineDate { get => _current.InspectionDeadlineDate; set { _current.InspectionDeadlineDate = value; OnPropertyChanged(); } }

        public DateTime? InspectionActualDate { get => _current.InspectionActualDate; set { _current.InspectionActualDate = value; OnPropertyChanged(); } }

        public bool InspectionReportMap { get => _current.InspectionReportMap; set { _current.InspectionReportMap = value; OnPropertyChanged(); } }

        public int ResidualRiskLevel { get => _current.ResidualRiskLevel; set { _current.ResidualRiskLevel = value; OnPropertyChanged(); } }

        public int FollowOnActionId { get => _current.FollowOnActionId; set { _current.FollowOnActionId = value; OnPropertyChanged(); } }

        public DateTime? FollowOnDeadlineDate { get => _current.FollowOnDeadlineDate; set { _current.FollowOnDeadlineDate = value; OnPropertyChanged(); } }

        public DateTime? FollowOnCompleteDate { get => _current.FollowOnCompleteDate; set { _current.FollowOnCompleteDate = value; OnPropertyChanged(); } }

        public int ResidualRiskLevelId { get => _current.ResidualRiskLevelId; set { _current.ResidualRiskLevelId = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public HazardActionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.HazardId = this.HazardId;
            returnVal.Description = this.Description;
            returnVal.SeverityProbabilityOfHarmId = this.SeverityProbabilityOfHarmId;
            returnVal.FurtherAction = this.FurtherAction;
            returnVal.InspectionDeadlineDate = this.InspectionDeadlineDate;
            returnVal.InspectionActualDate = this.InspectionActualDate;
            returnVal.InspectionReportMap = this.InspectionReportMap;
            returnVal.ResidualRiskLevel = this.ResidualRiskLevel;
            returnVal.FollowOnActionId = this.FollowOnActionId;
            returnVal.FollowOnDeadlineDate = this.FollowOnDeadlineDate;
            returnVal.FollowOnCompleteDate = this.FollowOnCompleteDate;
            returnVal.ResidualRiskLevelId = this.ResidualRiskLevelId;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardActionEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardActionDto test)
        {
            _original.HazardId = test.HazardId;
            _current.HazardId = test.HazardId;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.SeverityProbabilityOfHarmId = test.SeverityProbabilityOfHarmId;
            _current.SeverityProbabilityOfHarmId = test.SeverityProbabilityOfHarmId;
            _original.FurtherAction = test.FurtherAction;
            _current.FurtherAction = test.FurtherAction;
            _original.InspectionDeadlineDate = test.InspectionDeadlineDate;
            _current.InspectionDeadlineDate = test.InspectionDeadlineDate;
            _original.InspectionActualDate = test.InspectionActualDate;
            _current.InspectionActualDate = test.InspectionActualDate;
            _original.InspectionReportMap = test.InspectionReportMap;
            _current.InspectionReportMap = test.InspectionReportMap;
            _original.ResidualRiskLevel = test.ResidualRiskLevel;
            _current.ResidualRiskLevel = test.ResidualRiskLevel;
            _original.FollowOnActionId = test.FollowOnActionId;
            _current.FollowOnActionId = test.FollowOnActionId;
            _original.FollowOnDeadlineDate = test.FollowOnDeadlineDate;
            _current.FollowOnDeadlineDate = test.FollowOnDeadlineDate;
            _original.FollowOnCompleteDate = test.FollowOnCompleteDate;
            _current.FollowOnCompleteDate = test.FollowOnCompleteDate;
            _original.ResidualRiskLevelId = test.ResidualRiskLevelId;
            _current.ResidualRiskLevelId = test.ResidualRiskLevelId;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<HazardActionEditList> MakeCollection(List<HazardActionDto> records)
        {

            var newData = new ExtRangeCollection<HazardActionEditList>();

            foreach (var rec in records)
            {
                var e = new HazardActionEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}