using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class PartDisposalDto : BaseDto, IRecord
    { 
        public DateTime? DateOfDisposal { get; set; }

        public int InterestDisposalId { get; set; }

        public string Name { get; set; }

        public string Organisation { get; set; }

        public string Address { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string Postcode { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public double TotalConsiderationReceivable { get; set; }


        public PartDisposalDto Clone()
        {
            return new PartDisposalDto()
            {
                Id = this.Id,
                DateOfDisposal = this.DateOfDisposal,
                InterestDisposalId = this.InterestDisposalId,
                Name = this.Name,
                Organisation = this.Organisation,
                Address = this.Address,
                Town = this.Town,
                County = this.County,
                Postcode = this.Postcode,
                Telephone = this.Telephone,
                Email = this.Email,
                Description = this.Description,
                TotalConsiderationReceivable = this.TotalConsiderationReceivable,
            };
        }//endofclonemethods
    }


    public class PartDisposalEdit : PropertyBase<PartDisposalEdit>, IDuplicate
    {

        private PartDisposalDto _dto;


        public PartDisposalEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<DateTime?> DateOfDisposal { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> InterestDisposalId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Name { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Organisation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Address { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Town { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> County { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Postcode { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Telephone { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Email { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> TotalConsiderationReceivable { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };



        public int RecordId => Id.Value;


        public PartDisposalDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.DateOfDisposal = DateOfDisposal.Value;
            returnVal.InterestDisposalId = InterestDisposalId.Value;
            returnVal.Name = Name.Value;
            returnVal.Organisation = Organisation.Value;
            returnVal.Address = Address.Value;
            returnVal.Town = Town.Value;
            returnVal.County = County.Value;
            returnVal.Postcode = Postcode.Value;
            returnVal.Telephone = Telephone.Value;
            returnVal.Email = Email.Value;
            returnVal.Description = Description.Value;
            returnVal.TotalConsiderationReceivable = TotalConsiderationReceivable.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PartDisposalEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PartDisposalDto test)
        {
            this.DateOfDisposal = Property<DateTime?>.Make(test.DateOfDisposal,DateOfDisposal);
            this.InterestDisposalId = Property<int>.Make(test.InterestDisposalId,InterestDisposalId);
            this.Name = Property<string>.Make(test.Name,Name);
            this.Organisation = Property<string>.Make(test.Organisation,Organisation);
            this.Address = Property<string>.Make(test.Address,Address);
            this.Town = Property<string>.Make(test.Town,Town);
            this.County = Property<string>.Make(test.County,County);
            this.Postcode = Property<string>.Make(test.Postcode,Postcode);
            this.Telephone = Property<string>.Make(test.Telephone,Telephone);
            this.Email = Property<string>.Make(test.Email,Email);
            this.Description = Property<string>.Make(test.Description,Description);
            this.TotalConsiderationReceivable = Property<double>.Make(test.TotalConsiderationReceivable,TotalConsiderationReceivable);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            DateOfDisposal.Revert();
            InterestDisposalId.Revert();
            Name.Revert();
            Organisation.Revert();
            Address.Revert();
            Town.Revert();
            County.Revert();
            Postcode.Revert();
            Telephone.Revert();
            Email.Revert();
            Description.Revert();
            TotalConsiderationReceivable.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PartDisposalEdit> MakeCollection(List<PartDisposalDto> records)
        {

            var newData = new ExtRangeCollection<PartDisposalEdit>();

            foreach (var rec in records)
            {
                var e = new PartDisposalEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PartDisposalEditList : ListObj<PartDisposalDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PartDisposalDto _dto;


        public PartDisposalEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public DateTime? DateOfDisposal { get => _current.DateOfDisposal; set { _current.DateOfDisposal = value; OnPropertyChanged(); } }

        public int InterestDisposalId { get => _current.InterestDisposalId; set { _current.InterestDisposalId = value; OnPropertyChanged(); } }

        public string Name { get => _current.Name; set { _current.Name = value; OnPropertyChanged(); } }

        public string Organisation { get => _current.Organisation; set { _current.Organisation = value; OnPropertyChanged(); } }

        public string Address { get => _current.Address; set { _current.Address = value; OnPropertyChanged(); } }

        public string Town { get => _current.Town; set { _current.Town = value; OnPropertyChanged(); } }

        public string County { get => _current.County; set { _current.County = value; OnPropertyChanged(); } }

        public string Postcode { get => _current.Postcode; set { _current.Postcode = value; OnPropertyChanged(); } }

        public string Telephone { get => _current.Telephone; set { _current.Telephone = value; OnPropertyChanged(); } }

        public string Email { get => _current.Email; set { _current.Email = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public double TotalConsiderationReceivable { get => _current.TotalConsiderationReceivable; set { _current.TotalConsiderationReceivable = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public PartDisposalDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.DateOfDisposal = this.DateOfDisposal;
            returnVal.InterestDisposalId = this.InterestDisposalId;
            returnVal.Name = this.Name;
            returnVal.Organisation = this.Organisation;
            returnVal.Address = this.Address;
            returnVal.Town = this.Town;
            returnVal.County = this.County;
            returnVal.Postcode = this.Postcode;
            returnVal.Telephone = this.Telephone;
            returnVal.Email = this.Email;
            returnVal.Description = this.Description;
            returnVal.TotalConsiderationReceivable = this.TotalConsiderationReceivable;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PartDisposalEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PartDisposalDto test)
        {
            _original.DateOfDisposal = test.DateOfDisposal;
            _current.DateOfDisposal = test.DateOfDisposal;
            _original.InterestDisposalId = test.InterestDisposalId;
            _current.InterestDisposalId = test.InterestDisposalId;
            _original.Name = test.Name;
            _current.Name = test.Name;
            _original.Organisation = test.Organisation;
            _current.Organisation = test.Organisation;
            _original.Address = test.Address;
            _current.Address = test.Address;
            _original.Town = test.Town;
            _current.Town = test.Town;
            _original.County = test.County;
            _current.County = test.County;
            _original.Postcode = test.Postcode;
            _current.Postcode = test.Postcode;
            _original.Telephone = test.Telephone;
            _current.Telephone = test.Telephone;
            _original.Email = test.Email;
            _current.Email = test.Email;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.TotalConsiderationReceivable = test.TotalConsiderationReceivable;
            _current.TotalConsiderationReceivable = test.TotalConsiderationReceivable;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PartDisposalEditList> MakeCollection(List<PartDisposalDto> records)
        {

            var newData = new ExtRangeCollection<PartDisposalEditList>();

            foreach (var rec in records)
            {
                var e = new PartDisposalEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}