using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using Abstractions;
using System.ComponentModel;

namespace DataObjects.DTOS.InternalAudits
{
    public class InternalAuditsObservationEditDto : BaseDto, IRecord
    {
        public int InternalAuditID { get; set; }

        public string UKWASTrustProcedure { get; set; }
        public string Observation { get; set; }
        public string CorrectiveAction { get; set; }
        public DateTime? DueDate { get; set; }
        public int ActionByID { get; set; }

        public ComboBoxValue ActionBy { get; set; }

        public DateTime? ClosedDate { get; set; }
        public string ClosingComments { get; set; }
        public int GradeID { get; set; }

        public ComboBoxValue Grade { get; set; }


        public InternalAuditsObservationEditDto Clone()
        {
            return new InternalAuditsObservationEditDto()
            {
                InternalAuditID = this.InternalAuditID,
                UKWASTrustProcedure = this.UKWASTrustProcedure,
                Observation = this.Observation,
                CorrectiveAction = this.CorrectiveAction,
                DueDate = this.DueDate,
                ActionByID = this.ActionByID,
                ActionBy = this.ActionBy,
                ClosedDate = this.ClosedDate,
                ClosingComments = this.ClosingComments,
                GradeID = this.GradeID,
                Grade = this.Grade,
            };
        }//endofclonemethods
    }

    public class InternalAuditsObservationEditEdit : PropertyBase<InternalAuditsObservationEditEdit>, IDuplicate
    {

        private InternalAuditsObservationEditDto _dto;


        public InternalAuditsObservationEditEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> InternalAuditID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> UKWASTrustProcedure { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Observation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> CorrectiveAction { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<DateTime?> DueDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<int> ActionByID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> ActionBy { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<DateTime?> ClosedDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<string> ClosingComments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> GradeID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> Grade { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };




        public int RecordId => Id.Value;


        public InternalAuditsObservationEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.InternalAuditID = InternalAuditID.Value;
            returnVal.UKWASTrustProcedure = UKWASTrustProcedure.Value;
            returnVal.Observation = Observation.Value;
            returnVal.CorrectiveAction = CorrectiveAction.Value;
            returnVal.DueDate = DueDate.Value;
            returnVal.ActionByID = ActionByID.Value;
            returnVal.ActionBy = ActionBy.Value;
            returnVal.ClosedDate = ClosedDate.Value;
            returnVal.ClosingComments = ClosingComments.Value;
            returnVal.GradeID = GradeID.Value;
            returnVal.Grade = Grade.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsObservationEditEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsObservationEditDto test)
        {
            this.InternalAuditID = Property<int>.Make(test.InternalAuditID);
            this.UKWASTrustProcedure = Property<string>.Make(test.UKWASTrustProcedure);
            this.Observation = Property<string>.Make(test.Observation);
            this.CorrectiveAction = Property<string>.Make(test.CorrectiveAction);
            this.DueDate = Property<DateTime?>.Make(test.DueDate);
            this.ActionByID = Property<int>.Make(test.ActionByID);
            this.ActionBy = Property<ComboBoxValue>.Make(test.ActionBy);
            this.ClosedDate = Property<DateTime?>.Make(test.ClosedDate);
            this.ClosingComments = Property<string>.Make(test.ClosingComments);
            this.GradeID = Property<int>.Make(test.GradeID);
            this.Grade = Property<ComboBoxValue>.Make(test.Grade);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            InternalAuditID.Revert();
            UKWASTrustProcedure.Revert();
            Observation.Revert();
            CorrectiveAction.Revert();
            DueDate.Revert();
            ActionByID.Revert();
            ActionBy.Revert();
            ClosedDate.Revert();
            ClosingComments.Revert();
            GradeID.Revert();
            Grade.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsObservationEditEdit> MakeCollection(List<InternalAuditsObservationEditDto> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsObservationEditEdit>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsObservationEditEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class InternalAuditsObservationEditEditList : ListObj<InternalAuditsObservationEditDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private InternalAuditsObservationEditDto _dto;


        public InternalAuditsObservationEditEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int InternalAuditID { get => _current.InternalAuditID; set { _current.InternalAuditID = value; OnPropertyChanged(); } }

        public string UKWASTrustProcedure { get => _current.UKWASTrustProcedure; set { _current.UKWASTrustProcedure = value; OnPropertyChanged(); } }
        public string Observation { get => _current.Observation; set { _current.Observation = value; OnPropertyChanged(); } }
        public string CorrectiveAction { get => _current.CorrectiveAction; set { _current.CorrectiveAction = value; OnPropertyChanged(); } }
        public DateTime? DueDate { get => _current.DueDate; set { _current.DueDate = value; OnPropertyChanged(); } }
        public int ActionByID { get => _current.ActionByID; set { _current.ActionByID = value; OnPropertyChanged(); } }

        public ComboBoxValue ActionBy { get => _current.ActionBy; set { _current.ActionBy = value; OnPropertyChanged(); } }

        public DateTime? ClosedDate { get => _current.ClosedDate; set { _current.ClosedDate = value; OnPropertyChanged(); } }
        public string ClosingComments { get => _current.ClosingComments; set { _current.ClosingComments = value; OnPropertyChanged(); } }
        public int GradeID { get => _current.GradeID; set { _current.GradeID = value; OnPropertyChanged(); } }

        public ComboBoxValue Grade { get => _current.Grade; set { _current.Grade = value; OnPropertyChanged(); } }




        public int RecordId => Id;


        public InternalAuditsObservationEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.InternalAuditID = this.InternalAuditID;
            returnVal.UKWASTrustProcedure = this.UKWASTrustProcedure;
            returnVal.Observation = this.Observation;
            returnVal.CorrectiveAction = this.CorrectiveAction;
            returnVal.DueDate = this.DueDate;
            returnVal.ActionByID = this.ActionByID;
            returnVal.ActionBy = this.ActionBy;
            returnVal.ClosedDate = this.ClosedDate;
            returnVal.ClosingComments = this.ClosingComments;
            returnVal.GradeID = this.GradeID;
            returnVal.Grade = this.Grade;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsObservationEditEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsObservationEditDto test)
        {
            _original.InternalAuditID = test.InternalAuditID;
            _current.InternalAuditID = test.InternalAuditID;
            _original.UKWASTrustProcedure = test.UKWASTrustProcedure;
            _current.UKWASTrustProcedure = test.UKWASTrustProcedure;
            _original.Observation = test.Observation;
            _current.Observation = test.Observation;
            _original.CorrectiveAction = test.CorrectiveAction;
            _current.CorrectiveAction = test.CorrectiveAction;
            _original.DueDate = test.DueDate;
            _current.DueDate = test.DueDate;
            _original.ActionByID = test.ActionByID;
            _current.ActionByID = test.ActionByID;
            _original.ActionBy = test.ActionBy;
            _current.ActionBy = test.ActionBy;
            _original.ClosedDate = test.ClosedDate;
            _current.ClosedDate = test.ClosedDate;
            _original.ClosingComments = test.ClosingComments;
            _current.ClosingComments = test.ClosingComments;
            _original.GradeID = test.GradeID;
            _current.GradeID = test.GradeID;
            _original.Grade = test.Grade;
            _current.Grade = test.Grade;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsObservationEditEditList> MakeCollection(List<InternalAuditsObservationEditDto> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsObservationEditEditList>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsObservationEditEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}