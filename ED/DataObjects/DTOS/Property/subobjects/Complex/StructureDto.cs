using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using Abstractions;
using System.ComponentModel;

namespace DataObjects.DTOS
{
    public class StructureDto : BaseDto, IRecord
    {
        public int Id { get; set; }

        public int StructureTypeId { get; set; }

        public string Description { get; set; }

        public int StructureConditionId { get; set; }

        public double RebuildCost { get; set; }

        public bool Responsibility { get; set; }

        public string ResponsibilityDescription { get; set; }

        public double AnnualMaintenanceCosts { get; set; }

        public DateTime? LastInspectionDate { get; set; }

        public DateTime? NextInspectionDate { get; set; }

        public string ReportAuthor { get; set; }

        public string BriefReportSummary { get; set; }
        public bool Completed { get; set; }

        public bool ExternalSurveyorRequired { get; set; }

        public StructureDto Clone()
        {
            return new StructureDto()
            {
                Id = this.Id,
                StructureTypeId = this.StructureTypeId,
                Description = this.Description,
                StructureConditionId = this.StructureConditionId,
                RebuildCost = this.RebuildCost,
                Responsibility = this.Responsibility,
                ResponsibilityDescription = this.ResponsibilityDescription,
                AnnualMaintenanceCosts = this.AnnualMaintenanceCosts,
                LastInspectionDate = this.LastInspectionDate,
                NextInspectionDate = this.NextInspectionDate,
                ReportAuthor = this.ReportAuthor,
                BriefReportSummary = this.BriefReportSummary,
                Completed = this.Completed,
                ExternalSurveyorRequired = this.ExternalSurveyorRequired,
            };
        }//endofclonemethods
    }

    public class StructureEdit : PropertyBase<StructureEdit>, IDuplicate
    {

        private StructureDto _dto;


        public StructureEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> StructureTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> StructureConditionId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> RebuildCost { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<bool> Responsibility { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> ResponsibilityDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> AnnualMaintenanceCosts { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<DateTime?> LastInspectionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> NextInspectionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> ReportAuthor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> BriefReportSummary { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<bool> Completed { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> ExternalSurveyorRequired { get; set; } = new Property<bool>() { Value = false, Original = false };



        public int RecordId => Id.Value;


        public StructureDto ConvertToDto()
        {

        
            var returnVal = _dto.Clone();

            returnVal.Id = Id.Value;
            returnVal.StructureTypeId = StructureTypeId.Value;
            returnVal.Description = Description.Value;
            returnVal.StructureConditionId = StructureConditionId.Value;
            returnVal.RebuildCost = RebuildCost.Value;
            returnVal.Responsibility = Responsibility.Value;
            returnVal.ResponsibilityDescription = ResponsibilityDescription.Value;
            returnVal.AnnualMaintenanceCosts = AnnualMaintenanceCosts.Value;
            returnVal.LastInspectionDate = LastInspectionDate.Value;
            returnVal.NextInspectionDate = NextInspectionDate.Value;
            returnVal.ReportAuthor = ReportAuthor.Value;
            returnVal.BriefReportSummary = BriefReportSummary.Value;
            returnVal.Completed = Completed.Value;
            returnVal.ExternalSurveyorRequired = ExternalSurveyorRequired.Value;
            returnVal.Id = Id.Value;

            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (StructureEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(StructureDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.StructureTypeId = Property<int>.Make(test.StructureTypeId,StructureTypeId);
            this.Description = Property<string>.Make(test.Description,Description);
            this.StructureConditionId = Property<int>.Make(test.StructureConditionId,StructureConditionId);
            this.RebuildCost = Property<double>.Make(test.RebuildCost,RebuildCost);
            this.Responsibility = Property<bool>.Make(test.Responsibility,Responsibility);
            this.ResponsibilityDescription = Property<string>.Make(test.ResponsibilityDescription,ResponsibilityDescription);
            this.AnnualMaintenanceCosts = Property<double>.Make(test.AnnualMaintenanceCosts,AnnualMaintenanceCosts);
            this.LastInspectionDate = Property<DateTime?>.Make(test.LastInspectionDate,LastInspectionDate);
            this.NextInspectionDate = Property<DateTime?>.Make(test.NextInspectionDate,NextInspectionDate);
            this.ReportAuthor = Property<string>.Make(test.ReportAuthor,ReportAuthor);
            this.BriefReportSummary = Property<string>.Make(test.BriefReportSummary,BriefReportSummary);
            this.Completed = Property<bool>.Make(test.Completed,Completed);
            this.ExternalSurveyorRequired = Property<bool>.Make(test.ExternalSurveyorRequired,ExternalSurveyorRequired);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            StructureTypeId.Revert();
            Description.Revert();
            StructureConditionId.Revert();
            RebuildCost.Revert();
            Responsibility.Revert();
            ResponsibilityDescription.Revert();
            AnnualMaintenanceCosts.Revert();
            LastInspectionDate.Revert();
            NextInspectionDate.Revert();
            ReportAuthor.Revert();
            BriefReportSummary.Revert();
            Completed.Revert();
            ExternalSurveyorRequired.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<StructureEdit> MakeCollection(List<StructureDto> records)
        {

            var newData = new ExtRangeCollection<StructureEdit>();

            foreach (var rec in records)
            {
                var e = new StructureEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class StructureEditList : ListObj<StructureDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private StructureDto _dto;


        public StructureEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public int StructureTypeId { get => _current.StructureTypeId; set { _current.StructureTypeId = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public int StructureConditionId { get => _current.StructureConditionId; set { _current.StructureConditionId = value; OnPropertyChanged(); } }

        public double RebuildCost { get => _current.RebuildCost; set { _current.RebuildCost = value; OnPropertyChanged(); } }

        public bool Responsibility { get => _current.Responsibility; set { _current.Responsibility = value; OnPropertyChanged(); } }

        public string ResponsibilityDescription { get => _current.ResponsibilityDescription; set { _current.ResponsibilityDescription = value; OnPropertyChanged(); } }

        public double AnnualMaintenanceCosts { get => _current.AnnualMaintenanceCosts; set { _current.AnnualMaintenanceCosts = value; OnPropertyChanged(); } }

        public DateTime? LastInspectionDate { get => _current.LastInspectionDate; set { _current.LastInspectionDate = value; OnPropertyChanged(); } }

        public DateTime? NextInspectionDate { get => _current.NextInspectionDate; set { _current.NextInspectionDate = value; OnPropertyChanged(); } }

        public string ReportAuthor { get => _current.ReportAuthor; set { _current.ReportAuthor = value; OnPropertyChanged(); } }

        public string BriefReportSummary { get => _current.BriefReportSummary; set { _current.BriefReportSummary = value; OnPropertyChanged(); } }
        public bool Completed { get => _current.Completed; set { _current.Completed = value; OnPropertyChanged(); } }

        public bool ExternalSurveyorRequired { get => _current.ExternalSurveyorRequired; set { _current.ExternalSurveyorRequired = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public StructureDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.StructureTypeId = this.StructureTypeId;
            returnVal.Description = this.Description;
            returnVal.StructureConditionId = this.StructureConditionId;
            returnVal.RebuildCost = this.RebuildCost;
            returnVal.Responsibility = this.Responsibility;
            returnVal.ResponsibilityDescription = this.ResponsibilityDescription;
            returnVal.AnnualMaintenanceCosts = this.AnnualMaintenanceCosts;
            returnVal.LastInspectionDate = this.LastInspectionDate;
            returnVal.NextInspectionDate = this.NextInspectionDate;
            returnVal.ReportAuthor = this.ReportAuthor;
            returnVal.BriefReportSummary = this.BriefReportSummary;
            returnVal.Completed = this.Completed;
            returnVal.ExternalSurveyorRequired = this.ExternalSurveyorRequired;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (StructureEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(StructureDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.StructureTypeId = test.StructureTypeId;
            _current.StructureTypeId = test.StructureTypeId;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.StructureConditionId = test.StructureConditionId;
            _current.StructureConditionId = test.StructureConditionId;
            _original.RebuildCost = test.RebuildCost;
            _current.RebuildCost = test.RebuildCost;
            _original.Responsibility = test.Responsibility;
            _current.Responsibility = test.Responsibility;
            _original.ResponsibilityDescription = test.ResponsibilityDescription;
            _current.ResponsibilityDescription = test.ResponsibilityDescription;
            _original.AnnualMaintenanceCosts = test.AnnualMaintenanceCosts;
            _current.AnnualMaintenanceCosts = test.AnnualMaintenanceCosts;
            _original.LastInspectionDate = test.LastInspectionDate;
            _current.LastInspectionDate = test.LastInspectionDate;
            _original.NextInspectionDate = test.NextInspectionDate;
            _current.NextInspectionDate = test.NextInspectionDate;
            _original.ReportAuthor = test.ReportAuthor;
            _current.ReportAuthor = test.ReportAuthor;
            _original.BriefReportSummary = test.BriefReportSummary;
            _current.BriefReportSummary = test.BriefReportSummary;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;
            _original.ExternalSurveyorRequired = test.ExternalSurveyorRequired;
            _current.ExternalSurveyorRequired = test.ExternalSurveyorRequired;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<StructureEditList> MakeCollection(List<StructureDto> records)
        {

            var newData = new ExtRangeCollection<StructureEditList>();

            foreach (var rec in records)
            {
                var e = new StructureEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}