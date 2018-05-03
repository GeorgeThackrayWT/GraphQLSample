using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS
{
    public class ThirdPartyRightDto : BaseDto, IRecord
    {
        public int ServiceId { get; set; }

        public int RightsTypeId { get; set; }

        public int AgreementTypeId { get; set; }

        public string AgreementWith { get; set; }

        public DateTime? CurrentPaymentDate { get; set; }

        public double CurrentPaymentAmount { get; set; }

        public DateTime? CurrentReceivementDate { get; set; }


        public DateTime? ForecastPaymentDate { get; set; }

        public double ForecastPaymentAmount { get; set; }

        public DateTime? ForecastReceivementDate { get; set; }


        public DateTime? InitialEnquiry { get; set; }

        public DateTime? ResponsiveReceived { get; set; }

        public DateTime? ResponsiveReceivedTarget { get; set; }

        public bool ResponseResult { get; set; }

        public DateTime? MTMApproval { get; set; }

        public DateTime? MTMApprovalTarget { get; set; }


        public DateTime? SouthernElectric { get; set; }

        public DateTime? SouthernElectricTarget { get; set; }

        public DateTime? WT { get; set; }

        public DateTime? WTTarget { get; set; }


        public DateTime? AgreementFrom { get; set; }

        public string Comments { get; set; }



        public ThirdPartyRightDto Clone()
        {
            return new ThirdPartyRightDto()
            {
                ServiceId = this.ServiceId,
                RightsTypeId = this.RightsTypeId,
                AgreementTypeId = this.AgreementTypeId,
                AgreementWith = this.AgreementWith,
                CurrentPaymentDate = this.CurrentPaymentDate,
                CurrentPaymentAmount = this.CurrentPaymentAmount,
                CurrentReceivementDate = this.CurrentReceivementDate,
                ForecastPaymentDate = this.ForecastPaymentDate,
                ForecastPaymentAmount = this.ForecastPaymentAmount,
                ForecastReceivementDate = this.ForecastReceivementDate,
                InitialEnquiry = this.InitialEnquiry,
                ResponsiveReceived = this.ResponsiveReceived,
                ResponsiveReceivedTarget = this.ResponsiveReceivedTarget,
                ResponseResult = this.ResponseResult,
                MTMApproval = this.MTMApproval,
                MTMApprovalTarget = this.MTMApprovalTarget,
                SouthernElectric = this.SouthernElectric,
                SouthernElectricTarget = this.SouthernElectricTarget,
                WT = this.WT,
                WTTarget = this.WTTarget,
                AgreementFrom = this.AgreementFrom,
                Comments = this.Comments,
            };
        }//endofclonemethods
    }

    public class ThirdPartyRightEdit : PropertyBase<ThirdPartyRightEdit>, IDuplicate
    {

        private ThirdPartyRightDto _dto;


        public ThirdPartyRightEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ServiceId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> RightsTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> AgreementTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> AgreementWith { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> CurrentPaymentDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<double> CurrentPaymentAmount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<DateTime?> CurrentReceivementDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };


        public Property<DateTime?> ForecastPaymentDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<double> ForecastPaymentAmount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<DateTime?> ForecastReceivementDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };


        public Property<DateTime?> InitialEnquiry { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> ResponsiveReceived { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> ResponsiveReceivedTarget { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> ResponseResult { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> MTMApproval { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> MTMApprovalTarget { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };


        public Property<DateTime?> SouthernElectric { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> SouthernElectricTarget { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> WT { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> WTTarget { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };


        public Property<DateTime?> AgreementFrom { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };





        public int RecordId => Id.Value;


        public ThirdPartyRightDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ServiceId = ServiceId.Value;
            returnVal.RightsTypeId = RightsTypeId.Value;
            returnVal.AgreementTypeId = AgreementTypeId.Value;
            returnVal.AgreementWith = AgreementWith.Value;
            returnVal.CurrentPaymentDate = CurrentPaymentDate.Value;
            returnVal.CurrentPaymentAmount = CurrentPaymentAmount.Value;
            returnVal.CurrentReceivementDate = CurrentReceivementDate.Value;
            returnVal.ForecastPaymentDate = ForecastPaymentDate.Value;
            returnVal.ForecastPaymentAmount = ForecastPaymentAmount.Value;
            returnVal.ForecastReceivementDate = ForecastReceivementDate.Value;
            returnVal.InitialEnquiry = InitialEnquiry.Value;
            returnVal.ResponsiveReceived = ResponsiveReceived.Value;
            returnVal.ResponsiveReceivedTarget = ResponsiveReceivedTarget.Value;
            returnVal.ResponseResult = ResponseResult.Value;
            returnVal.MTMApproval = MTMApproval.Value;
            returnVal.MTMApprovalTarget = MTMApprovalTarget.Value;
            returnVal.SouthernElectric = SouthernElectric.Value;
            returnVal.SouthernElectricTarget = SouthernElectricTarget.Value;
            returnVal.WT = WT.Value;
            returnVal.WTTarget = WTTarget.Value;
            returnVal.AgreementFrom = AgreementFrom.Value;
            returnVal.Comments = Comments.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ThirdPartyRightEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ThirdPartyRightDto test)
        {
            this.ServiceId = Property<int>.Make(test.ServiceId,ServiceId);
            this.RightsTypeId = Property<int>.Make(test.RightsTypeId,RightsTypeId);
            this.AgreementTypeId = Property<int>.Make(test.AgreementTypeId,AgreementTypeId);
            this.AgreementWith = Property<string>.Make(test.AgreementWith,AgreementWith);
            this.CurrentPaymentDate = Property<DateTime?>.Make(test.CurrentPaymentDate,CurrentPaymentDate);
            this.CurrentPaymentAmount = Property<double>.Make(test.CurrentPaymentAmount,CurrentPaymentAmount);
            this.CurrentReceivementDate = Property<DateTime?>.Make(test.CurrentReceivementDate,CurrentReceivementDate);
            this.ForecastPaymentDate = Property<DateTime?>.Make(test.ForecastPaymentDate,ForecastPaymentDate);
            this.ForecastPaymentAmount = Property<double>.Make(test.ForecastPaymentAmount,ForecastPaymentAmount);
            this.ForecastReceivementDate = Property<DateTime?>.Make(test.ForecastReceivementDate,ForecastReceivementDate);
            this.InitialEnquiry = Property<DateTime?>.Make(test.InitialEnquiry,InitialEnquiry);
            this.ResponsiveReceived = Property<DateTime?>.Make(test.ResponsiveReceived,ResponsiveReceived);
            this.ResponsiveReceivedTarget = Property<DateTime?>.Make(test.ResponsiveReceivedTarget,ResponsiveReceivedTarget);
            this.ResponseResult = Property<bool>.Make(test.ResponseResult,ResponseResult);
            this.MTMApproval = Property<DateTime?>.Make(test.MTMApproval,MTMApproval);
            this.MTMApprovalTarget = Property<DateTime?>.Make(test.MTMApprovalTarget,MTMApprovalTarget);
            this.SouthernElectric = Property<DateTime?>.Make(test.SouthernElectric,SouthernElectric);
            this.SouthernElectricTarget = Property<DateTime?>.Make(test.SouthernElectricTarget,SouthernElectricTarget);
            this.WT = Property<DateTime?>.Make(test.WT,WT);
            this.WTTarget = Property<DateTime?>.Make(test.WTTarget,WTTarget);
            this.AgreementFrom = Property<DateTime?>.Make(test.AgreementFrom,AgreementFrom);
            this.Comments = Property<string>.Make(test.Comments,Comments);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ServiceId.Revert();
            RightsTypeId.Revert();
            AgreementTypeId.Revert();
            AgreementWith.Revert();
            CurrentPaymentDate.Revert();
            CurrentPaymentAmount.Revert();
            CurrentReceivementDate.Revert();
            ForecastPaymentDate.Revert();
            ForecastPaymentAmount.Revert();
            ForecastReceivementDate.Revert();
            InitialEnquiry.Revert();
            ResponsiveReceived.Revert();
            ResponsiveReceivedTarget.Revert();
            ResponseResult.Revert();
            MTMApproval.Revert();
            MTMApprovalTarget.Revert();
            SouthernElectric.Revert();
            SouthernElectricTarget.Revert();
            WT.Revert();
            WTTarget.Revert();
            AgreementFrom.Revert();
            Comments.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ThirdPartyRightEdit> MakeCollection(List<ThirdPartyRightDto> records)
        {

            var newData = new ExtRangeCollection<ThirdPartyRightEdit>();

            foreach (var rec in records)
            {
                var e = new ThirdPartyRightEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class ThirdPartyRightEditList : ListObj<ThirdPartyRightDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ThirdPartyRightDto _dto;


        public ThirdPartyRightEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ServiceId { get => _current.ServiceId; set { _current.ServiceId = value; OnPropertyChanged(); } }

        public int RightsTypeId { get => _current.RightsTypeId; set { _current.RightsTypeId = value; OnPropertyChanged(); } }

        public int AgreementTypeId { get => _current.AgreementTypeId; set { _current.AgreementTypeId = value; OnPropertyChanged(); } }

        public string AgreementWith { get => _current.AgreementWith; set { _current.AgreementWith = value; OnPropertyChanged(); } }

        public DateTime? CurrentPaymentDate { get => _current.CurrentPaymentDate; set { _current.CurrentPaymentDate = value; OnPropertyChanged(); } }

        public double CurrentPaymentAmount { get => _current.CurrentPaymentAmount; set { _current.CurrentPaymentAmount = value; OnPropertyChanged(); } }

        public DateTime? CurrentReceivementDate { get => _current.CurrentReceivementDate; set { _current.CurrentReceivementDate = value; OnPropertyChanged(); } }


        public DateTime? ForecastPaymentDate { get => _current.ForecastPaymentDate; set { _current.ForecastPaymentDate = value; OnPropertyChanged(); } }

        public double ForecastPaymentAmount { get => _current.ForecastPaymentAmount; set { _current.ForecastPaymentAmount = value; OnPropertyChanged(); } }

        public DateTime? ForecastReceivementDate { get => _current.ForecastReceivementDate; set { _current.ForecastReceivementDate = value; OnPropertyChanged(); } }


        public DateTime? InitialEnquiry { get => _current.InitialEnquiry; set { _current.InitialEnquiry = value; OnPropertyChanged(); } }

        public DateTime? ResponsiveReceived { get => _current.ResponsiveReceived; set { _current.ResponsiveReceived = value; OnPropertyChanged(); } }

        public DateTime? ResponsiveReceivedTarget { get => _current.ResponsiveReceivedTarget; set { _current.ResponsiveReceivedTarget = value; OnPropertyChanged(); } }

        public bool ResponseResult { get => _current.ResponseResult; set { _current.ResponseResult = value; OnPropertyChanged(); } }

        public DateTime? MTMApproval { get => _current.MTMApproval; set { _current.MTMApproval = value; OnPropertyChanged(); } }

        public DateTime? MTMApprovalTarget { get => _current.MTMApprovalTarget; set { _current.MTMApprovalTarget = value; OnPropertyChanged(); } }


        public DateTime? SouthernElectric { get => _current.SouthernElectric; set { _current.SouthernElectric = value; OnPropertyChanged(); } }

        public DateTime? SouthernElectricTarget { get => _current.SouthernElectricTarget; set { _current.SouthernElectricTarget = value; OnPropertyChanged(); } }

        public DateTime? WT { get => _current.WT; set { _current.WT = value; OnPropertyChanged(); } }

        public DateTime? WTTarget { get => _current.WTTarget; set { _current.WTTarget = value; OnPropertyChanged(); } }


        public DateTime? AgreementFrom { get => _current.AgreementFrom; set { _current.AgreementFrom = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }





        public int RecordId => Id;


        public ThirdPartyRightDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ServiceId = this.ServiceId;
            returnVal.RightsTypeId = this.RightsTypeId;
            returnVal.AgreementTypeId = this.AgreementTypeId;
            returnVal.AgreementWith = this.AgreementWith;
            returnVal.CurrentPaymentDate = this.CurrentPaymentDate;
            returnVal.CurrentPaymentAmount = this.CurrentPaymentAmount;
            returnVal.CurrentReceivementDate = this.CurrentReceivementDate;
            returnVal.ForecastPaymentDate = this.ForecastPaymentDate;
            returnVal.ForecastPaymentAmount = this.ForecastPaymentAmount;
            returnVal.ForecastReceivementDate = this.ForecastReceivementDate;
            returnVal.InitialEnquiry = this.InitialEnquiry;
            returnVal.ResponsiveReceived = this.ResponsiveReceived;
            returnVal.ResponsiveReceivedTarget = this.ResponsiveReceivedTarget;
            returnVal.ResponseResult = this.ResponseResult;
            returnVal.MTMApproval = this.MTMApproval;
            returnVal.MTMApprovalTarget = this.MTMApprovalTarget;
            returnVal.SouthernElectric = this.SouthernElectric;
            returnVal.SouthernElectricTarget = this.SouthernElectricTarget;
            returnVal.WT = this.WT;
            returnVal.WTTarget = this.WTTarget;
            returnVal.AgreementFrom = this.AgreementFrom;
            returnVal.Comments = this.Comments;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ThirdPartyRightEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ThirdPartyRightDto test)
        {
            _original.ServiceId = test.ServiceId;
            _current.ServiceId = test.ServiceId;
            _original.RightsTypeId = test.RightsTypeId;
            _current.RightsTypeId = test.RightsTypeId;
            _original.AgreementTypeId = test.AgreementTypeId;
            _current.AgreementTypeId = test.AgreementTypeId;
            _original.AgreementWith = test.AgreementWith;
            _current.AgreementWith = test.AgreementWith;
            _original.CurrentPaymentDate = test.CurrentPaymentDate;
            _current.CurrentPaymentDate = test.CurrentPaymentDate;
            _original.CurrentPaymentAmount = test.CurrentPaymentAmount;
            _current.CurrentPaymentAmount = test.CurrentPaymentAmount;
            _original.CurrentReceivementDate = test.CurrentReceivementDate;
            _current.CurrentReceivementDate = test.CurrentReceivementDate;
            _original.ForecastPaymentDate = test.ForecastPaymentDate;
            _current.ForecastPaymentDate = test.ForecastPaymentDate;
            _original.ForecastPaymentAmount = test.ForecastPaymentAmount;
            _current.ForecastPaymentAmount = test.ForecastPaymentAmount;
            _original.ForecastReceivementDate = test.ForecastReceivementDate;
            _current.ForecastReceivementDate = test.ForecastReceivementDate;
            _original.InitialEnquiry = test.InitialEnquiry;
            _current.InitialEnquiry = test.InitialEnquiry;
            _original.ResponsiveReceived = test.ResponsiveReceived;
            _current.ResponsiveReceived = test.ResponsiveReceived;
            _original.ResponsiveReceivedTarget = test.ResponsiveReceivedTarget;
            _current.ResponsiveReceivedTarget = test.ResponsiveReceivedTarget;
            _original.ResponseResult = test.ResponseResult;
            _current.ResponseResult = test.ResponseResult;
            _original.MTMApproval = test.MTMApproval;
            _current.MTMApproval = test.MTMApproval;
            _original.MTMApprovalTarget = test.MTMApprovalTarget;
            _current.MTMApprovalTarget = test.MTMApprovalTarget;
            _original.SouthernElectric = test.SouthernElectric;
            _current.SouthernElectric = test.SouthernElectric;
            _original.SouthernElectricTarget = test.SouthernElectricTarget;
            _current.SouthernElectricTarget = test.SouthernElectricTarget;
            _original.WT = test.WT;
            _current.WT = test.WT;
            _original.WTTarget = test.WTTarget;
            _current.WTTarget = test.WTTarget;
            _original.AgreementFrom = test.AgreementFrom;
            _current.AgreementFrom = test.AgreementFrom;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ThirdPartyRightEditList> MakeCollection(List<ThirdPartyRightDto> records)
        {

            var newData = new ExtRangeCollection<ThirdPartyRightEditList>();

            foreach (var rec in records)
            {
                var e = new ThirdPartyRightEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}