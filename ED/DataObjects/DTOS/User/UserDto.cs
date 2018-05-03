using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace EDCORE.ViewModel
{
    public enum PermissionGroup
    {
        GroupA = 1,
        GroupB = 2,
        GroupC = 3,
        GroupD = 4,
        GroupE = 5,
        GroupF = 6,
        GroupG = 7,
        GroupH = 8,
        GroupI = 9,
        GroupJ = 10,
        GroupK = 11,
        GroupL = 12,
        GroupM = 13,
        GroupN = 14,
        GroupO = 15,
        GroupP = 16,
        GroupQ = 17,
        GroupR = 18,
        GroupS = 19,
        GroupT = 20
        
    }


    public class UserDto : BaseDto, IRecord, IComboBoxValue
    {
        public int ID { get; set; }

        public int RegionId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LoginName { get; set; }

        public string DisplayName { get; set; }


        public UserDto Clone()
        {
            return new UserDto()
            {
                ID = this.ID,
                Name = this.Name,
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class UserEdit : PropertyBase<UserEdit>, IDuplicate
    {

        private UserDto _dto;


        public UserEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Name { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public UserDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ID = ID.Value;
            returnVal.Name = Name.Value;
            returnVal.Description = Description.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (UserEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(UserDto test)
        {
            this.ID = Property<int>.Make(test.ID);
            this.Name = Property<string>.Make(test.Name);
            this.Description = Property<string>.Make(test.Description);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ID.Revert();
            Name.Revert();
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<UserEdit> MakeCollection(List<UserDto> records)
        {

            var newData = new ExtRangeCollection<UserEdit>();

            foreach (var rec in records)
            {
                var e = new UserEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class UserEditList : ListObj<UserDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private UserDto _dto;


        public UserEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ID { get => _current.ID; set { _current.ID = value; OnPropertyChanged(); } }

        public string Name { get => _current.Name; set { _current.Name = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public UserDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ID = this.ID;
            returnVal.Name = this.Name;
            returnVal.Description = this.Description;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (UserEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(UserDto test)
        {
            _original.ID = test.ID;
            _current.ID = test.ID;
            _original.Name = test.Name;
            _current.Name = test.Name;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<UserEditList> MakeCollection(List<UserDto> records)
        {

            var newData = new ExtRangeCollection<UserEditList>();

            foreach (var rec in records)
            {
                var e = new UserEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}