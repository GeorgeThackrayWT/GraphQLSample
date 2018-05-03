using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class DrainageRateDto : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; }

        public string Body { get; set; }

        public double Amount { get; set; }

        public DateTime? DateDue { get; set; }

        public DrainageRateDto Clone()
        {
            return new DrainageRateDto()
            {
                Id = this.Id,
                ReferenceNumber = this.ReferenceNumber,
                Body = this.Body,
                Amount = this.Amount,
                DateDue = this.DateDue,
            };
        }//endofclonemethods
    }

    public class DrainageRateEdit : PropertyBase<DrainageRateEdit>, IDuplicate
    {

        private DrainageRateDto _dto;


        public DrainageRateEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> ReferenceNumber { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Body { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> Amount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<DateTime?> DateDue { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };


        public int RecordId => Id.Value;


        public DrainageRateDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.ReferenceNumber = ReferenceNumber.Value;
            returnVal.Body = Body.Value;
            returnVal.Amount = Amount.Value;
            returnVal.DateDue = DateDue.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (DrainageRateEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(DrainageRateDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.ReferenceNumber = Property<string>.Make(test.ReferenceNumber,ReferenceNumber);
            this.Body = Property<string>.Make(test.Body,Body);
            this.Amount = Property<double>.Make(test.Amount,Amount);
            this.DateDue = Property<DateTime?>.Make(test.DateDue,DateDue);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            ReferenceNumber.Revert();
            Body.Revert();
            Amount.Revert();
            DateDue.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<DrainageRateEdit> MakeCollection(List<DrainageRateDto> records)
        {

            var newData = new ExtRangeCollection<DrainageRateEdit>();

            foreach (var rec in records)
            {
                var e = new DrainageRateEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class DrainageRateEditList : ListObj<DrainageRateDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private DrainageRateDto _dto;


        public DrainageRateEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public string ReferenceNumber { get => _current.ReferenceNumber; set { _current.ReferenceNumber = value; OnPropertyChanged(); } }

        public string Body { get => _current.Body; set { _current.Body = value; OnPropertyChanged(); } }

        public double Amount { get => _current.Amount; set { _current.Amount = value; OnPropertyChanged(); } }

        public DateTime? DateDue { get => _current.DateDue; set { _current.DateDue = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public DrainageRateDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.ReferenceNumber = this.ReferenceNumber;
            returnVal.Body = this.Body;
            returnVal.Amount = this.Amount;
            returnVal.DateDue = this.DateDue;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (DrainageRateEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(DrainageRateDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.ReferenceNumber = test.ReferenceNumber;
            _current.ReferenceNumber = test.ReferenceNumber;
            _original.Body = test.Body;
            _current.Body = test.Body;
            _original.Amount = test.Amount;
            _current.Amount = test.Amount;
            _original.DateDue = test.DateDue;
            _current.DateDue = test.DateDue;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<DrainageRateEditList> MakeCollection(List<DrainageRateDto> records)
        {

            var newData = new ExtRangeCollection<DrainageRateEditList>();

            foreach (var rec in records)
            {
                var e = new DrainageRateEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}