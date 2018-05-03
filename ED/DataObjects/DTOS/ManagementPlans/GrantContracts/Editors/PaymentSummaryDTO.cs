using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class PaymentSummaryDTO : BaseDto, IRecord
    {
        public int? GrantId { get; set; }
        public int PaymentID { get; set; }
        public DateTime? Year { get; set; } = DateTime.Today;
        public double? Budget { get; set; } = 0.0;
        public double? Forecast { get; set; } = 0.0;
        public double? Claimed { get; set; } = 0.0;
        public double? Actual { get; set; } = 0.0;
        public PaymentSummaryDTO Clone()
        {
            return new PaymentSummaryDTO()
            {
                GrantId = this.GrantId,
                PaymentID = this.PaymentID,
                Year = this.Year,
                Budget = this.Budget,
                Forecast = this.Forecast,
                Claimed = this.Claimed,
                Actual = this.Actual,
            };
        }//endofclonemethods
    }
    public class PaymentSummaryDTOEdit : PropertyBase<PaymentSummaryDTOEdit>, IDuplicate
    {

        private PaymentSummaryDTO _dto;


        public PaymentSummaryDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int?> GrantId { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<int> PaymentID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<DateTime?> Year { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<double?> Budget { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> Forecast { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> Claimed { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };
        public Property<double?> Actual { get; set; } = new Property<double?>() { Value = 0.0, Original = 0.0 };


        public int RecordId => Id.Value;


        public PaymentSummaryDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GrantId = GrantId.Value;
            returnVal.PaymentID = PaymentID.Value;
            returnVal.Year = Year.Value;
            returnVal.Budget = Budget.Value;
            returnVal.Forecast = Forecast.Value;
            returnVal.Claimed = Claimed.Value;
            returnVal.Actual = Actual.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PaymentSummaryDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PaymentSummaryDTO test)
        {
            this.GrantId = Property<int?>.Make(test.GrantId,GrantId);
            this.PaymentID = Property<int>.Make(test.PaymentID,PaymentID);
            this.Year = Property<DateTime?>.Make(test.Year,Year);
            this.Budget = Property<double?>.Make(test.Budget,Budget);
            this.Forecast = Property<double?>.Make(test.Forecast,Forecast);
            this.Claimed = Property<double?>.Make(test.Claimed,Claimed);
            this.Actual = Property<double?>.Make(test.Actual,Actual);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            GrantId.Revert();
            PaymentID.Revert();
            Year.Revert();
            Budget.Revert();
            Forecast.Revert();
            Claimed.Revert();
            Actual.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PaymentSummaryDTOEdit> MakeCollection(List<PaymentSummaryDTO> records)
        {

            var newData = new ExtRangeCollection<PaymentSummaryDTOEdit>();

            foreach (var rec in records)
            {
                var e = new PaymentSummaryDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PaymentSummaryDTOEditList : ListObj<PaymentSummaryDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PaymentSummaryDTO _dto;


        public PaymentSummaryDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int? GrantId { get => _current.GrantId; set { _current.GrantId = value; OnPropertyChanged(); } }
        public int PaymentID { get => _current.PaymentID; set { _current.PaymentID = value; OnPropertyChanged(); } }
        public DateTime? Year { get => _current.Year; set { _current.Year = value; OnPropertyChanged(); } }
        public double? Budget { get => _current.Budget; set { _current.Budget = value; OnPropertyChanged(); } }
        public double? Forecast { get => _current.Forecast; set { _current.Forecast = value; OnPropertyChanged(); } }
        public double? Claimed { get => _current.Claimed; set { _current.Claimed = value; OnPropertyChanged(); } }
        public double? Actual { get => _current.Actual; set { _current.Actual = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PaymentSummaryDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GrantId = this.GrantId;
            returnVal.PaymentID = this.PaymentID;
            returnVal.Year = this.Year;
            returnVal.Budget = this.Budget;
            returnVal.Forecast = this.Forecast;
            returnVal.Claimed = this.Claimed;
            returnVal.Actual = this.Actual;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PaymentSummaryDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PaymentSummaryDTO test)
        {
            _original.GrantId = test.GrantId;
            _current.GrantId = test.GrantId;
            _original.PaymentID = test.PaymentID;
            _current.PaymentID = test.PaymentID;
            _original.Year = test.Year;
            _current.Year = test.Year;
            _original.Budget = test.Budget;
            _current.Budget = test.Budget;
            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;
            _original.Claimed = test.Claimed;
            _current.Claimed = test.Claimed;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PaymentSummaryDTOEditList> MakeCollection(List<PaymentSummaryDTO> records)
        {

            var newData = new ExtRangeCollection<PaymentSummaryDTOEditList>();

            foreach (var rec in records)
            {
                var e = new PaymentSummaryDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}