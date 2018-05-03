using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS
{
    public class ContactDto : BaseDto, IRecord
    {
        public string Name { get; set; }

        public int StatusId { get; set; }

        public string Other { get; set; }

        public string Organisation { get; set; }

        public string Address { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string Postcode { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Notes { get; set; }

        public ContactDto Clone()
        {
            return new ContactDto()
            {
                Name = this.Name,
                StatusId = this.StatusId,
                Other = this.Other,
                Organisation = this.Organisation,
                Address = this.Address,
                Town = this.Town,
                County = this.County,
                Postcode = this.Postcode,
                Telephone = this.Telephone,
                Email = this.Email,
                Notes = this.Notes,
            };
        }//endofclonemethods
    }

    public class ContactEdit : PropertyBase<ContactEdit>, IDuplicate
    {

        private ContactDto _dto;


        public ContactEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> Name { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> StatusId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Other { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Organisation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Address { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Town { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> County { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Postcode { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Telephone { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Email { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Notes { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public ContactDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Name = Name.Value;
            returnVal.StatusId = StatusId.Value;
            returnVal.Other = Other.Value;
            returnVal.Organisation = Organisation.Value;
            returnVal.Address = Address.Value;
            returnVal.Town = Town.Value;
            returnVal.County = County.Value;
            returnVal.Postcode = Postcode.Value;
            returnVal.Telephone = Telephone.Value;
            returnVal.Email = Email.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ContactEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ContactDto test)
        {
            this.Name = Property<string>.Make(test.Name,Name);
            this.StatusId = Property<int>.Make(test.StatusId,StatusId);
            this.Other = Property<string>.Make(test.Other,Other);
            this.Organisation = Property<string>.Make(test.Organisation,Organisation);
            this.Address = Property<string>.Make(test.Address,Address);
            this.Town = Property<string>.Make(test.Town,Town);
            this.County = Property<string>.Make(test.County,County);
            this.Postcode = Property<string>.Make(test.Postcode,Postcode);
            this.Telephone = Property<string>.Make(test.Telephone,Telephone);
            this.Email = Property<string>.Make(test.Email,Email);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Name.Revert();
            StatusId.Revert();
            Other.Revert();
            Organisation.Revert();
            Address.Revert();
            Town.Revert();
            County.Revert();
            Postcode.Revert();
            Telephone.Revert();
            Email.Revert();
            Notes.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ContactEdit> MakeCollection(List<ContactDto> records)
        {

            var newData = new ExtRangeCollection<ContactEdit>();

            foreach (var rec in records)
            {
                var e = new ContactEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class ContactEditList : ListObj<ContactDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ContactDto _dto;


        public ContactEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Name { get => _current.Name; set { _current.Name = value; OnPropertyChanged(); } }

        public int StatusId { get => _current.StatusId; set { _current.StatusId = value; OnPropertyChanged(); } }

        public string Other { get => _current.Other; set { _current.Other = value; OnPropertyChanged(); } }

        public string Organisation { get => _current.Organisation; set { _current.Organisation = value; OnPropertyChanged(); } }

        public string Address { get => _current.Address; set { _current.Address = value; OnPropertyChanged(); } }

        public string Town { get => _current.Town; set { _current.Town = value; OnPropertyChanged(); } }

        public string County { get => _current.County; set { _current.County = value; OnPropertyChanged(); } }

        public string Postcode { get => _current.Postcode; set { _current.Postcode = value; OnPropertyChanged(); } }

        public string Telephone { get => _current.Telephone; set { _current.Telephone = value; OnPropertyChanged(); } }

        public string Email { get => _current.Email; set { _current.Email = value; OnPropertyChanged(); } }

        public string Notes { get => _current.Notes; set { _current.Notes = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public ContactDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Name = this.Name;
            returnVal.StatusId = this.StatusId;
            returnVal.Other = this.Other;
            returnVal.Organisation = this.Organisation;
            returnVal.Address = this.Address;
            returnVal.Town = this.Town;
            returnVal.County = this.County;
            returnVal.Postcode = this.Postcode;
            returnVal.Telephone = this.Telephone;
            returnVal.Email = this.Email;
            returnVal.Notes = this.Notes;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ContactEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ContactDto test)
        {
            _original.Name = test.Name;
            _current.Name = test.Name;
            _original.StatusId = test.StatusId;
            _current.StatusId = test.StatusId;
            _original.Other = test.Other;
            _current.Other = test.Other;
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
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ContactEditList> MakeCollection(List<ContactDto> records)
        {

            var newData = new ExtRangeCollection<ContactEditList>();

            foreach (var rec in records)
            {
                var e = new ContactEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}