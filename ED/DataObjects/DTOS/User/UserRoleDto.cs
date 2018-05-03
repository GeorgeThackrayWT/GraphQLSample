using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class UserRoleDto : BaseDto, IRecord
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public string DisplayName { get; set; }

        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public int? RegionID { get; set; }

        public string RegionName { get; set; }

        public int? CountryID { get; set; }

        public string CountryName { get; set; }

        public UserRoleDto Clone()
        {
            return new UserRoleDto()
            {
                ID = this.ID,
                UserID = this.UserID,
                DisplayName = this.DisplayName,
                RoleID = this.RoleID,
                RoleName = this.RoleName,
                RegionID = this.RegionID,
                RegionName = this.RegionName,
                CountryID = this.CountryID,
                CountryName = this.CountryName,
            };
        }//endofclonemethods
    }

    public class UserRoleEdit : PropertyBase<UserRoleEdit>, IDuplicate
    {

        private UserRoleDto _dto;


        public UserRoleEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> UserID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> DisplayName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> RoleID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> RoleName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int?> RegionID { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<string> RegionName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int?> CountryID { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<string> CountryName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public UserRoleDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ID = ID.Value;
            returnVal.UserID = UserID.Value;
            returnVal.DisplayName = DisplayName.Value;
            returnVal.RoleID = RoleID.Value;
            returnVal.RoleName = RoleName.Value;
            returnVal.RegionID = RegionID.Value;
            returnVal.RegionName = RegionName.Value;
            returnVal.CountryID = CountryID.Value;
            returnVal.CountryName = CountryName.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (UserRoleEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(UserRoleDto test)
        {
            this.ID = Property<int>.Make(test.ID);
            this.UserID = Property<int>.Make(test.UserID);
            this.DisplayName = Property<string>.Make(test.DisplayName);
            this.RoleID = Property<int>.Make(test.RoleID);
            this.RoleName = Property<string>.Make(test.RoleName);
            this.RegionID = Property<int?>.Make(test.RegionID);
            this.RegionName = Property<string>.Make(test.RegionName);
            this.CountryID = Property<int?>.Make(test.CountryID);
            this.CountryName = Property<string>.Make(test.CountryName);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ID.Revert();
            UserID.Revert();
            DisplayName.Revert();
            RoleID.Revert();
            RoleName.Revert();
            RegionID.Revert();
            RegionName.Revert();
            CountryID.Revert();
            CountryName.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<UserRoleEdit> MakeCollection(List<UserRoleDto> records)
        {

            var newData = new ExtRangeCollection<UserRoleEdit>();

            foreach (var rec in records)
            {
                var e = new UserRoleEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class UserRoleEditList : ListObj<UserRoleDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private UserRoleDto _dto;


        public UserRoleEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ID { get => _current.ID; set { _current.ID = value; OnPropertyChanged(); } }

        public int UserID { get => _current.UserID; set { _current.UserID = value; OnPropertyChanged(); } }

        public string DisplayName { get => _current.DisplayName; set { _current.DisplayName = value; OnPropertyChanged(); } }

        public int RoleID { get => _current.RoleID; set { _current.RoleID = value; OnPropertyChanged(); } }

        public string RoleName { get => _current.RoleName; set { _current.RoleName = value; OnPropertyChanged(); } }

        public int? RegionID { get => _current.RegionID; set { _current.RegionID = value; OnPropertyChanged(); } }

        public string RegionName { get => _current.RegionName; set { _current.RegionName = value; OnPropertyChanged(); } }

        public int? CountryID { get => _current.CountryID; set { _current.CountryID = value; OnPropertyChanged(); } }

        public string CountryName { get => _current.CountryName; set { _current.CountryName = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public UserRoleDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ID = this.ID;
            returnVal.UserID = this.UserID;
            returnVal.DisplayName = this.DisplayName;
            returnVal.RoleID = this.RoleID;
            returnVal.RoleName = this.RoleName;
            returnVal.RegionID = this.RegionID;
            returnVal.RegionName = this.RegionName;
            returnVal.CountryID = this.CountryID;
            returnVal.CountryName = this.CountryName;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (UserRoleEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(UserRoleDto test)
        {
            _original.ID = test.ID;
            _current.ID = test.ID;
            _original.UserID = test.UserID;
            _current.UserID = test.UserID;
            _original.DisplayName = test.DisplayName;
            _current.DisplayName = test.DisplayName;
            _original.RoleID = test.RoleID;
            _current.RoleID = test.RoleID;
            _original.RoleName = test.RoleName;
            _current.RoleName = test.RoleName;
            _original.RegionID = test.RegionID;
            _current.RegionID = test.RegionID;
            _original.RegionName = test.RegionName;
            _current.RegionName = test.RegionName;
            _original.CountryID = test.CountryID;
            _current.CountryID = test.CountryID;
            _original.CountryName = test.CountryName;
            _current.CountryName = test.CountryName;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<UserRoleEditList> MakeCollection(List<UserRoleDto> records)
        {

            var newData = new ExtRangeCollection<UserRoleEditList>();

            foreach (var rec in records)
            {
                var e = new UserRoleEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}
