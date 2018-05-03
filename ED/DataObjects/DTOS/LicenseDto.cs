using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class LicenseDto : BaseDto, IRecord
    {
        public double AreaHa { get; set; }

        public int AgreementId { get; set; }

        public int InterestLetId { get; set; }

        public int TypeId { get; set; }

        public int FishingSize { get; set; }

        public int SizeInId { get; set; }

        public int FishingTypeId { get; set; }

        public string TenantLicensee { get; set; }

        public string Address { get; set; }

        public DateTime? CommencementDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int NoticeOfTerminationId { get; set; }

        public int CommentsOnTermId { get; set; }

        public bool AgentExists { get; set; }
        public string Agent { get; set; }

        public double RentFee { get; set; }

        public int PerioId { get; set; }

        public int RentReviewId { get; set; }

        public DateTime? RentReviewDate { get; set; }

        public int NoticeProvisionsId { get; set; }

        public string RentReviewCycle { get; set; }

        public string Comments { get; set; }
        public LicenseDto Clone()
        {
            return new LicenseDto()
            {
                AreaHa = this.AreaHa,
                AgreementId = this.AgreementId,
                InterestLetId = this.InterestLetId,
                TypeId = this.TypeId,
                FishingSize = this.FishingSize,
                SizeInId = this.SizeInId,
                FishingTypeId = this.FishingTypeId,
                TenantLicensee = this.TenantLicensee,
                Address = this.Address,
                CommencementDate = this.CommencementDate,
                ExpiryDate = this.ExpiryDate,
                NoticeOfTerminationId = this.NoticeOfTerminationId,
                CommentsOnTermId = this.CommentsOnTermId,
                AgentExists = this.AgentExists,
                Agent = this.Agent,
                RentFee = this.RentFee,
                PerioId = this.PerioId,
                RentReviewId = this.RentReviewId,
                RentReviewDate = this.RentReviewDate,
                NoticeProvisionsId = this.NoticeProvisionsId,
                RentReviewCycle = this.RentReviewCycle,
                Comments = this.Comments,
            };
        }//endofclonemethods
    }

    public class LicenseEdit : PropertyBase<LicenseEdit>, IDuplicate
    {

        private LicenseDto _dto;


        public LicenseEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<double> AreaHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> AgreementId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> InterestLetId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> FishingSize { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> SizeInId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> FishingTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> TenantLicensee { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Address { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> CommencementDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> ExpiryDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> NoticeOfTerminationId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> CommentsOnTermId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> AgentExists { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<string> Agent { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> RentFee { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> PerioId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> RentReviewId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> RentReviewDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> NoticeProvisionsId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> RentReviewCycle { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public LicenseDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AreaHa = AreaHa.Value;
            returnVal.AgreementId = AgreementId.Value;
            returnVal.InterestLetId = InterestLetId.Value;
            returnVal.TypeId = TypeId.Value;
            returnVal.FishingSize = FishingSize.Value;
            returnVal.SizeInId = SizeInId.Value;
            returnVal.FishingTypeId = FishingTypeId.Value;
            returnVal.TenantLicensee = TenantLicensee.Value;
            returnVal.Address = Address.Value;
            returnVal.CommencementDate = CommencementDate.Value;
            returnVal.ExpiryDate = ExpiryDate.Value;
            returnVal.NoticeOfTerminationId = NoticeOfTerminationId.Value;
            returnVal.CommentsOnTermId = CommentsOnTermId.Value;
            returnVal.AgentExists = AgentExists.Value;
            returnVal.Agent = Agent.Value;
            returnVal.RentFee = RentFee.Value;
            returnVal.PerioId = PerioId.Value;
            returnVal.RentReviewId = RentReviewId.Value;
            returnVal.RentReviewDate = RentReviewDate.Value;
            returnVal.NoticeProvisionsId = NoticeProvisionsId.Value;
            returnVal.RentReviewCycle = RentReviewCycle.Value;
            returnVal.Comments = Comments.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (LicenseEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(LicenseDto test)
        {
            this.AreaHa = Property<double>.Make(test.AreaHa);
            this.AgreementId = Property<int>.Make(test.AgreementId);
            this.InterestLetId = Property<int>.Make(test.InterestLetId);
            this.TypeId = Property<int>.Make(test.TypeId);
            this.FishingSize = Property<int>.Make(test.FishingSize);
            this.SizeInId = Property<int>.Make(test.SizeInId);
            this.FishingTypeId = Property<int>.Make(test.FishingTypeId);
            this.TenantLicensee = Property<string>.Make(test.TenantLicensee);
            this.Address = Property<string>.Make(test.Address);
            this.CommencementDate = Property<DateTime?>.Make(test.CommencementDate);
            this.ExpiryDate = Property<DateTime?>.Make(test.ExpiryDate);
            this.NoticeOfTerminationId = Property<int>.Make(test.NoticeOfTerminationId);
            this.CommentsOnTermId = Property<int>.Make(test.CommentsOnTermId);
            this.AgentExists = Property<bool>.Make(test.AgentExists);
            this.Agent = Property<string>.Make(test.Agent);
            this.RentFee = Property<double>.Make(test.RentFee);
            this.PerioId = Property<int>.Make(test.PerioId);
            this.RentReviewId = Property<int>.Make(test.RentReviewId);
            this.RentReviewDate = Property<DateTime?>.Make(test.RentReviewDate);
            this.NoticeProvisionsId = Property<int>.Make(test.NoticeProvisionsId);
            this.RentReviewCycle = Property<string>.Make(test.RentReviewCycle);
            this.Comments = Property<string>.Make(test.Comments);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AreaHa.Revert();
            AgreementId.Revert();
            InterestLetId.Revert();
            TypeId.Revert();
            FishingSize.Revert();
            SizeInId.Revert();
            FishingTypeId.Revert();
            TenantLicensee.Revert();
            Address.Revert();
            CommencementDate.Revert();
            ExpiryDate.Revert();
            NoticeOfTerminationId.Revert();
            CommentsOnTermId.Revert();
            AgentExists.Revert();
            Agent.Revert();
            RentFee.Revert();
            PerioId.Revert();
            RentReviewId.Revert();
            RentReviewDate.Revert();
            NoticeProvisionsId.Revert();
            RentReviewCycle.Revert();
            Comments.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<LicenseEdit> MakeCollection(List<LicenseDto> records)
        {

            var newData = new ExtRangeCollection<LicenseEdit>();

            foreach (var rec in records)
            {
                var e = new LicenseEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class LicenseEditList : ListObj<LicenseDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private LicenseDto _dto;


        public LicenseEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public double AreaHa { get => _current.AreaHa; set { _current.AreaHa = value; OnPropertyChanged(); } }

        public int AgreementId { get => _current.AgreementId; set { _current.AgreementId = value; OnPropertyChanged(); } }

        public int InterestLetId { get => _current.InterestLetId; set { _current.InterestLetId = value; OnPropertyChanged(); } }

        public int TypeId { get => _current.TypeId; set { _current.TypeId = value; OnPropertyChanged(); } }

        public int FishingSize { get => _current.FishingSize; set { _current.FishingSize = value; OnPropertyChanged(); } }

        public int SizeInId { get => _current.SizeInId; set { _current.SizeInId = value; OnPropertyChanged(); } }

        public int FishingTypeId { get => _current.FishingTypeId; set { _current.FishingTypeId = value; OnPropertyChanged(); } }

        public string TenantLicensee { get => _current.TenantLicensee; set { _current.TenantLicensee = value; OnPropertyChanged(); } }

        public string Address { get => _current.Address; set { _current.Address = value; OnPropertyChanged(); } }

        public DateTime? CommencementDate { get => _current.CommencementDate; set { _current.CommencementDate = value; OnPropertyChanged(); } }

        public DateTime? ExpiryDate { get => _current.ExpiryDate; set { _current.ExpiryDate = value; OnPropertyChanged(); } }

        public int NoticeOfTerminationId { get => _current.NoticeOfTerminationId; set { _current.NoticeOfTerminationId = value; OnPropertyChanged(); } }

        public int CommentsOnTermId { get => _current.CommentsOnTermId; set { _current.CommentsOnTermId = value; OnPropertyChanged(); } }

        public bool AgentExists { get => _current.AgentExists; set { _current.AgentExists = value; OnPropertyChanged(); } }
        public string Agent { get => _current.Agent; set { _current.Agent = value; OnPropertyChanged(); } }

        public double RentFee { get => _current.RentFee; set { _current.RentFee = value; OnPropertyChanged(); } }

        public int PerioId { get => _current.PerioId; set { _current.PerioId = value; OnPropertyChanged(); } }

        public int RentReviewId { get => _current.RentReviewId; set { _current.RentReviewId = value; OnPropertyChanged(); } }

        public DateTime? RentReviewDate { get => _current.RentReviewDate; set { _current.RentReviewDate = value; OnPropertyChanged(); } }

        public int NoticeProvisionsId { get => _current.NoticeProvisionsId; set { _current.NoticeProvisionsId = value; OnPropertyChanged(); } }

        public string RentReviewCycle { get => _current.RentReviewCycle; set { _current.RentReviewCycle = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public LicenseDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AreaHa = this.AreaHa;
            returnVal.AgreementId = this.AgreementId;
            returnVal.InterestLetId = this.InterestLetId;
            returnVal.TypeId = this.TypeId;
            returnVal.FishingSize = this.FishingSize;
            returnVal.SizeInId = this.SizeInId;
            returnVal.FishingTypeId = this.FishingTypeId;
            returnVal.TenantLicensee = this.TenantLicensee;
            returnVal.Address = this.Address;
            returnVal.CommencementDate = this.CommencementDate;
            returnVal.ExpiryDate = this.ExpiryDate;
            returnVal.NoticeOfTerminationId = this.NoticeOfTerminationId;
            returnVal.CommentsOnTermId = this.CommentsOnTermId;
            returnVal.AgentExists = this.AgentExists;
            returnVal.Agent = this.Agent;
            returnVal.RentFee = this.RentFee;
            returnVal.PerioId = this.PerioId;
            returnVal.RentReviewId = this.RentReviewId;
            returnVal.RentReviewDate = this.RentReviewDate;
            returnVal.NoticeProvisionsId = this.NoticeProvisionsId;
            returnVal.RentReviewCycle = this.RentReviewCycle;
            returnVal.Comments = this.Comments;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (LicenseEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(LicenseDto test)
        {
            _original.AreaHa = test.AreaHa;
            _current.AreaHa = test.AreaHa;
            _original.AgreementId = test.AgreementId;
            _current.AgreementId = test.AgreementId;
            _original.InterestLetId = test.InterestLetId;
            _current.InterestLetId = test.InterestLetId;
            _original.TypeId = test.TypeId;
            _current.TypeId = test.TypeId;
            _original.FishingSize = test.FishingSize;
            _current.FishingSize = test.FishingSize;
            _original.SizeInId = test.SizeInId;
            _current.SizeInId = test.SizeInId;
            _original.FishingTypeId = test.FishingTypeId;
            _current.FishingTypeId = test.FishingTypeId;
            _original.TenantLicensee = test.TenantLicensee;
            _current.TenantLicensee = test.TenantLicensee;
            _original.Address = test.Address;
            _current.Address = test.Address;
            _original.CommencementDate = test.CommencementDate;
            _current.CommencementDate = test.CommencementDate;
            _original.ExpiryDate = test.ExpiryDate;
            _current.ExpiryDate = test.ExpiryDate;
            _original.NoticeOfTerminationId = test.NoticeOfTerminationId;
            _current.NoticeOfTerminationId = test.NoticeOfTerminationId;
            _original.CommentsOnTermId = test.CommentsOnTermId;
            _current.CommentsOnTermId = test.CommentsOnTermId;
            _original.AgentExists = test.AgentExists;
            _current.AgentExists = test.AgentExists;
            _original.Agent = test.Agent;
            _current.Agent = test.Agent;
            _original.RentFee = test.RentFee;
            _current.RentFee = test.RentFee;
            _original.PerioId = test.PerioId;
            _current.PerioId = test.PerioId;
            _original.RentReviewId = test.RentReviewId;
            _current.RentReviewId = test.RentReviewId;
            _original.RentReviewDate = test.RentReviewDate;
            _current.RentReviewDate = test.RentReviewDate;
            _original.NoticeProvisionsId = test.NoticeProvisionsId;
            _current.NoticeProvisionsId = test.NoticeProvisionsId;
            _original.RentReviewCycle = test.RentReviewCycle;
            _current.RentReviewCycle = test.RentReviewCycle;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<LicenseEditList> MakeCollection(List<LicenseDto> records)
        {

            var newData = new ExtRangeCollection<LicenseEditList>();

            foreach (var rec in records)
            {
                var e = new LicenseEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}