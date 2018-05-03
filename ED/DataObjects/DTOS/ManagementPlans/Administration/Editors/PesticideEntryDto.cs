using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.Administration.Editors
{
    public class PesticideEntryDto : BaseDto, IRecord
    {
        public int PesticideId { get; set; }

        public DateTime? Date { get; set; }

        public string Operator { get; set; }

        public double? HoursWorked { get; set; }
        public PesticideEntryDto Clone()
        {
            return new PesticideEntryDto()
            {
                PesticideId = this.PesticideId,
                Date = this.Date,
                Operator = this.Operator,
                HoursWorked = this.HoursWorked,
            };
        }//endofclonemethods
    }

    public class PesticideEntryEdit : PropertyBase<PesticideEntryEdit>, IDuplicate
    {

        private PesticideEntryDto _dto;


        public PesticideEntryEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> PesticideId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> Date { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> Operator { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double?> HoursWorked { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };


        public int RecordId => Id.Value;


        public PesticideEntryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PesticideId = PesticideId.Value;
            returnVal.Date = Date.Value;
            returnVal.Operator = Operator.Value;
            returnVal.HoursWorked = HoursWorked.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PesticideEntryEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PesticideEntryDto test)
        {
            this.PesticideId = Property<int>.Make(test.PesticideId,PesticideId);
            this.Date = Property<DateTime?>.Make(test.Date,Date);
            this.Operator = Property<string>.Make(test.Operator,Operator);
            this.HoursWorked = Property<double?>.Make(test.HoursWorked,HoursWorked);
            this.Id = Property<int>.Make(test.Id,Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            PesticideId.Revert();
            Date.Revert();
            Operator.Revert();
            HoursWorked.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PesticideEntryEdit> MakeCollection(List<PesticideEntryDto> records)
        {

            var newData = new ExtRangeCollection<PesticideEntryEdit>();

            foreach (var rec in records)
            {
                var e = new PesticideEntryEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass
    
    public class PesticideEntryEditList : ListObj<PesticideEntryDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private PesticideEntryDto _dto;

        public PesticideEntryEditList()
        {
            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };
        }//endofconstructor

        public int PesticideId { get => _current.PesticideId; set { _current.PesticideId = value; OnPropertyChanged(); } }

        public DateTime? Date { get => _current.Date; set { _current.Date = value; OnPropertyChanged(); } }

        public string Operator { get => _current.Operator; set { _current.Operator = value; OnPropertyChanged(); } }

        public double? HoursWorked { get => _current.HoursWorked; set { _current.HoursWorked = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PesticideEntryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PesticideId = this.PesticideId;
            returnVal.Date = this.Date;
            returnVal.Operator = this.Operator;
            returnVal.HoursWorked = this.HoursWorked;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PesticideEntryEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PesticideEntryDto test)
        {
            _original.PesticideId = test.PesticideId;
            _current.PesticideId = test.PesticideId;
            _original.Date = test.Date;
            _current.Date = test.Date;
            _original.Operator = test.Operator;
            _current.Operator = test.Operator;
            _original.HoursWorked = test.HoursWorked;
            _current.HoursWorked = test.HoursWorked;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PesticideEntryEditList> MakeCollection(List<PesticideEntryDto> records)
        {

            var newData = new ExtRangeCollection<PesticideEntryEditList>();

            foreach (var rec in records)
            {
                var e = new PesticideEntryEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}