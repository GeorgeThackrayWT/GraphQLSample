using Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class EvaluationEditDto : BaseDto, IRecord
    {

        public int Id { get; set; }

        public int EvaluationTypeID { get; set; }

        public int TypeOfInformationID { get; set; }

        public string Author { get; set; }

        public bool Confidential { get; set; }

        public DateTime? DateOfRecord { get; set; }

        public string Location { get; set; }

        public string Detail { get; set; }

        public string SuppliedBy { get; set; }

        public EvaluationEditDto Clone()
        {
            return new EvaluationEditDto()
            {
                Id = this.Id,
                EvaluationTypeID = this.EvaluationTypeID,
                TypeOfInformationID = this.TypeOfInformationID,
                Author = this.Author,
                Confidential = this.Confidential,
                DateOfRecord = this.DateOfRecord,
                Location = this.Location,
                Detail = this.Detail,
                SuppliedBy = this.SuppliedBy,
            };
        }//endofclonemethods
    }



    public class EvaluationEditEdit : PropertyBase<EvaluationEditEdit>, IDuplicate
    {

        private EvaluationEditDto _dto;


        public EvaluationEditEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor


        public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> EvaluationTypeID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TypeOfInformationID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Author { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Confidential { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> DateOfRecord { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> Location { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Detail { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> SuppliedBy { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public EvaluationEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.EvaluationTypeID = EvaluationTypeID.Value;
            returnVal.TypeOfInformationID = TypeOfInformationID.Value;
            returnVal.Author = Author.Value;
            returnVal.Confidential = Confidential.Value;
            returnVal.DateOfRecord = DateOfRecord.Value;
            returnVal.Location = Location.Value;
            returnVal.Detail = Detail.Value;
            returnVal.SuppliedBy = SuppliedBy.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (EvaluationEditEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(EvaluationEditDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.EvaluationTypeID = Property<int>.Make(test.EvaluationTypeID,EvaluationTypeID);
            this.TypeOfInformationID = Property<int>.Make(test.TypeOfInformationID,TypeOfInformationID);
            this.Author = Property<string>.Make(test.Author,Author);
            this.Confidential = Property<bool>.Make(test.Confidential,Confidential);
            this.DateOfRecord = Property<DateTime?>.Make(test.DateOfRecord,DateOfRecord);
            this.Location = Property<string>.Make(test.Location,Location);
            this.Detail = Property<string>.Make(test.Detail,Detail);
            this.SuppliedBy = Property<string>.Make(test.SuppliedBy,SuppliedBy);

            SetPropChanged();


            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            EvaluationTypeID.Revert();
            TypeOfInformationID.Revert();
            Author.Revert();
            Confidential.Revert();
            DateOfRecord.Revert();
            Location.Revert();
            Detail.Revert();
            SuppliedBy.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<EvaluationEditEdit> MakeCollection(List<EvaluationEditDto> records)
        {

            var newData = new ExtRangeCollection<EvaluationEditEdit>();

            foreach (var rec in records)
            {
                var e = new EvaluationEditEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



    public class EvaluationEditEditList : ListObj<EvaluationEditDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private EvaluationEditDto _dto;


        public EvaluationEditEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public int EvaluationTypeID { get => _current.EvaluationTypeID; set { _current.EvaluationTypeID = value; OnPropertyChanged(); } }

        public int TypeOfInformationID { get => _current.TypeOfInformationID; set { _current.TypeOfInformationID = value; OnPropertyChanged(); } }

        public string Author { get => _current.Author; set { _current.Author = value; OnPropertyChanged(); } }

        public bool Confidential { get => _current.Confidential; set { _current.Confidential = value; OnPropertyChanged(); } }

        public DateTime? DateOfRecord { get => _current.DateOfRecord; set { _current.DateOfRecord = value; OnPropertyChanged(); } }

        public string Location { get => _current.Location; set { _current.Location = value; OnPropertyChanged(); } }

        public string Detail { get => _current.Detail; set { _current.Detail = value; OnPropertyChanged(); } }

        public string SuppliedBy { get => _current.SuppliedBy; set { _current.SuppliedBy = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public EvaluationEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.EvaluationTypeID = this.EvaluationTypeID;
            returnVal.TypeOfInformationID = this.TypeOfInformationID;
            returnVal.Author = this.Author;
            returnVal.Confidential = this.Confidential;
            returnVal.DateOfRecord = this.DateOfRecord;
            returnVal.Location = this.Location;
            returnVal.Detail = this.Detail;
            returnVal.SuppliedBy = this.SuppliedBy;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (EvaluationEditEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(EvaluationEditDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.EvaluationTypeID = test.EvaluationTypeID;
            _current.EvaluationTypeID = test.EvaluationTypeID;
            _original.TypeOfInformationID = test.TypeOfInformationID;
            _current.TypeOfInformationID = test.TypeOfInformationID;
            _original.Author = test.Author;
            _current.Author = test.Author;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.DateOfRecord = test.DateOfRecord;
            _current.DateOfRecord = test.DateOfRecord;
            _original.Location = test.Location;
            _current.Location = test.Location;
            _original.Detail = test.Detail;
            _current.Detail = test.Detail;
            _original.SuppliedBy = test.SuppliedBy;
            _current.SuppliedBy = test.SuppliedBy;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<EvaluationEditEditList> MakeCollection(List<EvaluationEditDto> records)
        {

            var newData = new ExtRangeCollection<EvaluationEditEditList>();

            foreach (var rec in records)
            {
                var e = new EvaluationEditEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass
}
