using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class FundingDto : BaseDto, IRecord
    {
      
        public ComboBoxValue FundingTypeId { get; set; }

        public string NameOfDonor { get; set; }

        public double Amount { get; set; }

        public double GiftAidOfferAmount { get; set; }

        public DateTime? DateOffered { get; set; }

        public DateTime? DateConditionsApproved { get; set; }

        public DateTime? DateFoundingConfirmed { get; set; }

        public DateTime? DateClaimed { get; set; }

        public DateTime? PaymentReceivedDate { get; set; }

        public bool GrantConditionsExist { get; set; }

        public string GrantConditionsDescription { get; set; }
        public FundingDto Clone()
        {
            return new FundingDto()
            {
                Id = this.Id,
                FundingTypeId = this.FundingTypeId,
                NameOfDonor = this.NameOfDonor,
                Amount = this.Amount,
                GiftAidOfferAmount = this.GiftAidOfferAmount,
                DateOffered = this.DateOffered,
                DateConditionsApproved = this.DateConditionsApproved,
                DateFoundingConfirmed = this.DateFoundingConfirmed,
                DateClaimed = this.DateClaimed,
                PaymentReceivedDate = this.PaymentReceivedDate,
                GrantConditionsExist = this.GrantConditionsExist,
                GrantConditionsDescription = this.GrantConditionsDescription,
            };
        }//endofclonemethods
    }

    public class FundingEdit : PropertyBase<FundingEdit>, IDuplicate
    {

        private FundingDto _dto;


        public FundingEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

       
        public Property<ComboBoxValue> FundingTypeId { get; set; } = new Property<ComboBoxValue>() { Value = new ComboBoxValue(){ID = 0,Description = "",Name = ""}, Original = new ComboBoxValue() { ID = 0, Description = "", Name = "" } };

        public Property<string> NameOfDonor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> Amount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> GiftAidOfferAmount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<DateTime?> DateOffered { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateConditionsApproved { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateFoundingConfirmed { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateClaimed { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> PaymentReceivedDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> GrantConditionsExist { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> GrantConditionsDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public FundingDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.FundingTypeId = FundingTypeId.Value;
            returnVal.NameOfDonor = NameOfDonor.Value;
            returnVal.Amount = Amount.Value;
            returnVal.GiftAidOfferAmount = GiftAidOfferAmount.Value;
            returnVal.DateOffered = DateOffered.Value;
            returnVal.DateConditionsApproved = DateConditionsApproved.Value;
            returnVal.DateFoundingConfirmed = DateFoundingConfirmed.Value;
            returnVal.DateClaimed = DateClaimed.Value;
            returnVal.PaymentReceivedDate = PaymentReceivedDate.Value;
            returnVal.GrantConditionsExist = GrantConditionsExist.Value;
            returnVal.GrantConditionsDescription = GrantConditionsDescription.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (FundingEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(FundingDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.FundingTypeId = Property<ComboBoxValue>.Make(test.FundingTypeId,FundingTypeId);
            this.NameOfDonor = Property<string>.Make(test.NameOfDonor,NameOfDonor);
            this.Amount = Property<double>.Make(test.Amount,Amount);
            this.GiftAidOfferAmount = Property<double>.Make(test.GiftAidOfferAmount,GiftAidOfferAmount);
            this.DateOffered = Property<DateTime?>.Make(test.DateOffered,DateOffered);
            this.DateConditionsApproved = Property<DateTime?>.Make(test.DateConditionsApproved,DateConditionsApproved);
            this.DateFoundingConfirmed = Property<DateTime?>.Make(test.DateFoundingConfirmed,DateFoundingConfirmed);
            this.DateClaimed = Property<DateTime?>.Make(test.DateClaimed,DateClaimed);
            this.PaymentReceivedDate = Property<DateTime?>.Make(test.PaymentReceivedDate,PaymentReceivedDate);
            this.GrantConditionsExist = Property<bool>.Make(test.GrantConditionsExist,GrantConditionsExist);
            this.GrantConditionsDescription = Property<string>.Make(test.GrantConditionsDescription,GrantConditionsDescription);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            FundingTypeId.Revert();
            NameOfDonor.Revert();
            Amount.Revert();
            GiftAidOfferAmount.Revert();
            DateOffered.Revert();
            DateConditionsApproved.Revert();
            DateFoundingConfirmed.Revert();
            DateClaimed.Revert();
            PaymentReceivedDate.Revert();
            GrantConditionsExist.Revert();
            GrantConditionsDescription.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<FundingEdit> MakeCollection(List<FundingDto> records)
        {

            var newData = new ExtRangeCollection<FundingEdit>();

            foreach (var rec in records)
            {
                var e = new FundingEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class FundingEditList : ListObj<FundingDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private FundingDto _dto;


        public FundingEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

       
        public ComboBoxValue FundingTypeId { get => _current.FundingTypeId; set { _current.FundingTypeId = value; OnPropertyChanged(); } }

        public string NameOfDonor { get => _current.NameOfDonor; set { _current.NameOfDonor = value; OnPropertyChanged(); } }

        public double Amount { get => _current.Amount; set { _current.Amount = value; OnPropertyChanged(); } }

        public double GiftAidOfferAmount { get => _current.GiftAidOfferAmount; set { _current.GiftAidOfferAmount = value; OnPropertyChanged(); } }

        public DateTime? DateOffered { get => _current.DateOffered; set { _current.DateOffered = value; OnPropertyChanged(); } }

        public DateTime? DateConditionsApproved { get => _current.DateConditionsApproved; set { _current.DateConditionsApproved = value; OnPropertyChanged(); } }

        public DateTime? DateFoundingConfirmed { get => _current.DateFoundingConfirmed; set { _current.DateFoundingConfirmed = value; OnPropertyChanged(); } }

        public DateTime? DateClaimed { get => _current.DateClaimed; set { _current.DateClaimed = value; OnPropertyChanged(); } }

        public DateTime? PaymentReceivedDate { get => _current.PaymentReceivedDate; set { _current.PaymentReceivedDate = value; OnPropertyChanged(); } }

        public bool GrantConditionsExist { get => _current.GrantConditionsExist; set { _current.GrantConditionsExist = value; OnPropertyChanged(); } }

        public string GrantConditionsDescription { get => _current.GrantConditionsDescription; set { _current.GrantConditionsDescription = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public FundingDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.FundingTypeId = this.FundingTypeId;
            returnVal.NameOfDonor = this.NameOfDonor;
            returnVal.Amount = this.Amount;
            returnVal.GiftAidOfferAmount = this.GiftAidOfferAmount;
            returnVal.DateOffered = this.DateOffered;
            returnVal.DateConditionsApproved = this.DateConditionsApproved;
            returnVal.DateFoundingConfirmed = this.DateFoundingConfirmed;
            returnVal.DateClaimed = this.DateClaimed;
            returnVal.PaymentReceivedDate = this.PaymentReceivedDate;
            returnVal.GrantConditionsExist = this.GrantConditionsExist;
            returnVal.GrantConditionsDescription = this.GrantConditionsDescription;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (FundingEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(FundingDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.FundingTypeId = test.FundingTypeId;
            _current.FundingTypeId = test.FundingTypeId;
            _original.NameOfDonor = test.NameOfDonor;
            _current.NameOfDonor = test.NameOfDonor;
            _original.Amount = test.Amount;
            _current.Amount = test.Amount;
            _original.GiftAidOfferAmount = test.GiftAidOfferAmount;
            _current.GiftAidOfferAmount = test.GiftAidOfferAmount;
            _original.DateOffered = test.DateOffered;
            _current.DateOffered = test.DateOffered;
            _original.DateConditionsApproved = test.DateConditionsApproved;
            _current.DateConditionsApproved = test.DateConditionsApproved;
            _original.DateFoundingConfirmed = test.DateFoundingConfirmed;
            _current.DateFoundingConfirmed = test.DateFoundingConfirmed;
            _original.DateClaimed = test.DateClaimed;
            _current.DateClaimed = test.DateClaimed;
            _original.PaymentReceivedDate = test.PaymentReceivedDate;
            _current.PaymentReceivedDate = test.PaymentReceivedDate;
            _original.GrantConditionsExist = test.GrantConditionsExist;
            _current.GrantConditionsExist = test.GrantConditionsExist;
            _original.GrantConditionsDescription = test.GrantConditionsDescription;
            _current.GrantConditionsDescription = test.GrantConditionsDescription;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<FundingEditList> MakeCollection(List<FundingDto> records)
        {

            var newData = new ExtRangeCollection<FundingEditList>();

            foreach (var rec in records)
            {
                var e = new FundingEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}