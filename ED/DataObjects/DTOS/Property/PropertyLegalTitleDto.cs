using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class PropertyLegalTitleDto : BaseDto, IRecord
    {
        public int AcquisitionTypeId { get; set; }

        public double PurchasePrice { get; set; }

        public int Tenure { get; set; }

        public int LeaseTerm { get; set; }

        public DateTime? LeaseStart { get; set; }

        public DateTime? LeaseEnd { get; set; }

        public double Rent { get; set; }

        public string Lessor { get; set; }

        public DateTime? MTMApprovalDate { get; set; }

        public DateTime? DateExchanged { get; set; }

        public DateTime? DateCompleted { get; set; }

        public DateTime? DateDisposed { get; set; }

        public string LandRegistryNumbers { get; set; }

        public DateTime? DateLeasedTo3rdParty { get; set; }

        public int ThirdPartyLeaseTerm { get; set; }

        public string Lessee { get; set; }

        public string WTSolicitorsName { get; set; }

        public bool CLT { get; set; }


        public PropertyLegalTitleDto Clone()
        {
            return new PropertyLegalTitleDto()
            {
                AcquisitionTypeId = this.AcquisitionTypeId,
                PurchasePrice = this.PurchasePrice,
                Tenure = this.Tenure,
                LeaseTerm = this.LeaseTerm,
                LeaseStart = this.LeaseStart,
                LeaseEnd = this.LeaseEnd,
                Rent = this.Rent,
                Lessor = this.Lessor,
                MTMApprovalDate = this.MTMApprovalDate,
                DateExchanged = this.DateExchanged,
                DateCompleted = this.DateCompleted,
                DateDisposed = this.DateDisposed,
                LandRegistryNumbers = this.LandRegistryNumbers,
                DateLeasedTo3rdParty = this.DateLeasedTo3rdParty,
                ThirdPartyLeaseTerm = this.ThirdPartyLeaseTerm,
                Lessee = this.Lessee,
                WTSolicitorsName = this.WTSolicitorsName,
                CLT = this.CLT,
            };
        }//endofclonemethods
    }

    public class PropertyLegalTitleEdit : PropertyBase<PropertyLegalTitleEdit>, IDuplicate
    {

        private PropertyLegalTitleDto _dto;


        public PropertyLegalTitleEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> AcquisitionTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> PurchasePrice { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> Tenure { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> LeaseTerm { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> LeaseStart { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> LeaseEnd { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<double> Rent { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<string> Lessor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> MTMApprovalDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateExchanged { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateCompleted { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> DateDisposed { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> LandRegistryNumbers { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> DateLeasedTo3rdParty { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> ThirdPartyLeaseTerm { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Lessee { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> WTSolicitorsName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> CLT { get; set; } = new Property<bool>() { Value = false, Original = false };




        public int RecordId => Id.Value;


        public PropertyLegalTitleDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionTypeId = AcquisitionTypeId.Value;
            returnVal.PurchasePrice = PurchasePrice.Value;
            returnVal.Tenure = Tenure.Value;
            returnVal.LeaseTerm = LeaseTerm.Value;
            returnVal.LeaseStart = LeaseStart.Value;
            returnVal.LeaseEnd = LeaseEnd.Value;
            returnVal.Rent = Rent.Value;
            returnVal.Lessor = Lessor.Value;
            returnVal.MTMApprovalDate = MTMApprovalDate.Value;
            returnVal.DateExchanged = DateExchanged.Value;
            returnVal.DateCompleted = DateCompleted.Value;
            returnVal.DateDisposed = DateDisposed.Value;
            returnVal.LandRegistryNumbers = LandRegistryNumbers.Value;
            returnVal.DateLeasedTo3rdParty = DateLeasedTo3rdParty.Value;
            returnVal.ThirdPartyLeaseTerm = ThirdPartyLeaseTerm.Value;
            returnVal.Lessee = Lessee.Value;
            returnVal.WTSolicitorsName = WTSolicitorsName.Value;
            returnVal.CLT = CLT.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyLegalTitleEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyLegalTitleDto test)
        {
            this.AcquisitionTypeId = Property<int>.Make(test.AcquisitionTypeId,AcquisitionTypeId);
            this.PurchasePrice = Property<double>.Make(test.PurchasePrice,PurchasePrice);
            this.Tenure = Property<int>.Make(test.Tenure,Tenure);
            this.LeaseTerm = Property<int>.Make(test.LeaseTerm,LeaseTerm);
            this.LeaseStart = Property<DateTime?>.Make(test.LeaseStart,LeaseStart);
            this.LeaseEnd = Property<DateTime?>.Make(test.LeaseEnd,LeaseEnd);
            this.Rent = Property<double>.Make(test.Rent,Rent);
            this.Lessor = Property<string>.Make(test.Lessor,Lessor);
            this.MTMApprovalDate = Property<DateTime?>.Make(test.MTMApprovalDate,MTMApprovalDate);
            this.DateExchanged = Property<DateTime?>.Make(test.DateExchanged,DateExchanged);
            this.DateCompleted = Property<DateTime?>.Make(test.DateCompleted,DateCompleted);
            this.DateDisposed = Property<DateTime?>.Make(test.DateDisposed,DateDisposed);
            this.LandRegistryNumbers = Property<string>.Make(test.LandRegistryNumbers,LandRegistryNumbers);
            this.DateLeasedTo3rdParty = Property<DateTime?>.Make(test.DateLeasedTo3rdParty, DateLeasedTo3rdParty);
            this.ThirdPartyLeaseTerm = Property<int>.Make(test.ThirdPartyLeaseTerm,ThirdPartyLeaseTerm);
            this.Lessee = Property<string>.Make(test.Lessee,Lessee);
            this.WTSolicitorsName = Property<string>.Make(test.WTSolicitorsName,WTSolicitorsName);
            this.CLT = Property<bool>.Make(test.CLT,CLT);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AcquisitionTypeId.Revert();
            PurchasePrice.Revert();
            Tenure.Revert();
            LeaseTerm.Revert();
            LeaseStart.Revert();
            LeaseEnd.Revert();
            Rent.Revert();
            Lessor.Revert();
            MTMApprovalDate.Revert();
            DateExchanged.Revert();
            DateCompleted.Revert();
            DateDisposed.Revert();
            LandRegistryNumbers.Revert();
            DateLeasedTo3rdParty.Revert();
            ThirdPartyLeaseTerm.Revert();
            Lessee.Revert();
            WTSolicitorsName.Revert();
            CLT.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PropertyLegalTitleEdit> MakeCollection(List<PropertyLegalTitleDto> records)
        {

            var newData = new ExtRangeCollection<PropertyLegalTitleEdit>();

            foreach (var rec in records)
            {
                var e = new PropertyLegalTitleEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PropertyLegalTitleEditList : ListObj<PropertyLegalTitleDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PropertyLegalTitleDto _dto;


        public PropertyLegalTitleEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int AcquisitionTypeId { get => _current.AcquisitionTypeId; set { _current.AcquisitionTypeId = value; OnPropertyChanged(); } }

        public double PurchasePrice { get => _current.PurchasePrice; set { _current.PurchasePrice = value; OnPropertyChanged(); } }

        public int Tenure { get => _current.Tenure; set { _current.Tenure = value; OnPropertyChanged(); } }

        public int LeaseTerm { get => _current.LeaseTerm; set { _current.LeaseTerm = value; OnPropertyChanged(); } }

        public DateTime? LeaseStart { get => _current.LeaseStart; set { _current.LeaseStart = value; OnPropertyChanged(); } }

        public DateTime? LeaseEnd { get => _current.LeaseEnd; set { _current.LeaseEnd = value; OnPropertyChanged(); } }

        public double Rent { get => _current.Rent; set { _current.Rent = value; OnPropertyChanged(); } }

        public string Lessor { get => _current.Lessor; set { _current.Lessor = value; OnPropertyChanged(); } }

        public DateTime? MTMApprovalDate { get => _current.MTMApprovalDate; set { _current.MTMApprovalDate = value; OnPropertyChanged(); } }

        public DateTime? DateExchanged { get => _current.DateExchanged; set { _current.DateExchanged = value; OnPropertyChanged(); } }

        public DateTime? DateCompleted { get => _current.DateCompleted; set { _current.DateCompleted = value; OnPropertyChanged(); } }

        public DateTime? DateDisposed { get => _current.DateDisposed; set { _current.DateDisposed = value; OnPropertyChanged(); } }

        public string LandRegistryNumbers { get => _current.LandRegistryNumbers; set { _current.LandRegistryNumbers = value; OnPropertyChanged(); } }

        public DateTime? DateLeasedTo3rdParty { get => _current.DateLeasedTo3rdParty; set { _current.DateLeasedTo3rdParty = value; OnPropertyChanged(); } }

        public int ThirdPartyLeaseTerm { get => _current.ThirdPartyLeaseTerm; set { _current.ThirdPartyLeaseTerm = value; OnPropertyChanged(); } }

        public string Lessee { get => _current.Lessee; set { _current.Lessee = value; OnPropertyChanged(); } }

        public string WTSolicitorsName { get => _current.WTSolicitorsName; set { _current.WTSolicitorsName = value; OnPropertyChanged(); } }

        public bool CLT { get => _current.CLT; set { _current.CLT = value; OnPropertyChanged(); } }




        public int RecordId => Id;


        public PropertyLegalTitleDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionTypeId = this.AcquisitionTypeId;
            returnVal.PurchasePrice = this.PurchasePrice;
            returnVal.Tenure = this.Tenure;
            returnVal.LeaseTerm = this.LeaseTerm;
            returnVal.LeaseStart = this.LeaseStart;
            returnVal.LeaseEnd = this.LeaseEnd;
            returnVal.Rent = this.Rent;
            returnVal.Lessor = this.Lessor;
            returnVal.MTMApprovalDate = this.MTMApprovalDate;
            returnVal.DateExchanged = this.DateExchanged;
            returnVal.DateCompleted = this.DateCompleted;
            returnVal.DateDisposed = this.DateDisposed;
            returnVal.LandRegistryNumbers = this.LandRegistryNumbers;
            returnVal.DateLeasedTo3rdParty = this.DateLeasedTo3rdParty;
            returnVal.ThirdPartyLeaseTerm = this.ThirdPartyLeaseTerm;
            returnVal.Lessee = this.Lessee;
            returnVal.WTSolicitorsName = this.WTSolicitorsName;
            returnVal.CLT = this.CLT;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyLegalTitleEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyLegalTitleDto test)
        {
            _original.AcquisitionTypeId = test.AcquisitionTypeId;
            _current.AcquisitionTypeId = test.AcquisitionTypeId;
            _original.PurchasePrice = test.PurchasePrice;
            _current.PurchasePrice = test.PurchasePrice;
            _original.Tenure = test.Tenure;
            _current.Tenure = test.Tenure;
            _original.LeaseTerm = test.LeaseTerm;
            _current.LeaseTerm = test.LeaseTerm;
            _original.LeaseStart = test.LeaseStart;
            _current.LeaseStart = test.LeaseStart;
            _original.LeaseEnd = test.LeaseEnd;
            _current.LeaseEnd = test.LeaseEnd;
            _original.Rent = test.Rent;
            _current.Rent = test.Rent;
            _original.Lessor = test.Lessor;
            _current.Lessor = test.Lessor;
            _original.MTMApprovalDate = test.MTMApprovalDate;
            _current.MTMApprovalDate = test.MTMApprovalDate;
            _original.DateExchanged = test.DateExchanged;
            _current.DateExchanged = test.DateExchanged;
            _original.DateCompleted = test.DateCompleted;
            _current.DateCompleted = test.DateCompleted;
            _original.DateDisposed = test.DateDisposed;
            _current.DateDisposed = test.DateDisposed;
            _original.LandRegistryNumbers = test.LandRegistryNumbers;
            _current.LandRegistryNumbers = test.LandRegistryNumbers;
            _original.DateLeasedTo3rdParty = test.DateLeasedTo3rdParty;
            _current.DateLeasedTo3rdParty = test.DateLeasedTo3rdParty;
            _original.ThirdPartyLeaseTerm = test.ThirdPartyLeaseTerm;
            _current.ThirdPartyLeaseTerm = test.ThirdPartyLeaseTerm;
            _original.Lessee = test.Lessee;
            _current.Lessee = test.Lessee;
            _original.WTSolicitorsName = test.WTSolicitorsName;
            _current.WTSolicitorsName = test.WTSolicitorsName;
            _original.CLT = test.CLT;
            _current.CLT = test.CLT;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PropertyLegalTitleEditList> MakeCollection(List<PropertyLegalTitleDto> records)
        {

            var newData = new ExtRangeCollection<PropertyLegalTitleEditList>();

            foreach (var rec in records)
            {
                var e = new PropertyLegalTitleEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}