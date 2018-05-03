using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS.AdministrationArea;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.AdministrationArea
{
    public class AdminDocumentsDTO : BaseDto, IRecord
    {
  
        public int CabinetID { get; set; }

        public bool SchemeHttp { get; set; }

        public string IntegrationIdentifier { get; set; }

        public string ServerName { get; set; }

        public string TargetDirectory { get; set; }

        public string PathExtension { get; set; }

        public string ResultList { get; set; }

        public int LoginID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string LoginKey { get; set; }

        public string LoginToken { get; set; }


        public AdminDocumentsDTO Clone()
        {
            return new AdminDocumentsDTO()
            {
                Id = Id,
                CabinetID = CabinetID,
                SchemeHttp = SchemeHttp,
                IntegrationIdentifier = IntegrationIdentifier,
                ServerName = ServerName,
                TargetDirectory = TargetDirectory,
                PathExtension = PathExtension,
                ResultList = ResultList,
                LoginID = LoginID,
                Username = Username,
                Password = Password,
                LoginKey = LoginKey,
                LoginToken = LoginToken,
            };
        }//endofclonemethods
    }


    public class AdminDocumentsDTOEdit : PropertyBase<AdminDocumentsDTOEdit>, IDuplicate
    {

        private AdminDocumentsDTO _dto;


        public AdminDocumentsDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> CabinetID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> SchemeHttp { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> IntegrationIdentifier { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> ServerName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> TargetDirectory { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> PathExtension { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> ResultList { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> LoginID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Username { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Password { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> LoginKey { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> LoginToken { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public AdminDocumentsDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.CabinetID = CabinetID.Value;
            returnVal.SchemeHttp = SchemeHttp.Value;
            returnVal.IntegrationIdentifier = IntegrationIdentifier.Value;
            returnVal.ServerName = ServerName.Value;
            returnVal.TargetDirectory = TargetDirectory.Value;
            returnVal.PathExtension = PathExtension.Value;
            returnVal.ResultList = ResultList.Value;
            returnVal.LoginID = LoginID.Value;
            returnVal.Username = Username.Value;
            returnVal.Password = Password.Value;
            returnVal.LoginKey = LoginKey.Value;
            returnVal.LoginToken = LoginToken.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (AdminDocumentsDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(AdminDocumentsDTO test)
        {
            
            this.CabinetID = Property<int>.Make(test.CabinetID,CabinetID);
            this.SchemeHttp = Property<bool>.Make(test.SchemeHttp,SchemeHttp);
            this.IntegrationIdentifier = Property<string>.Make(test.IntegrationIdentifier,IntegrationIdentifier);
            this.ServerName = Property<string>.Make(test.ServerName,ServerName);
            this.TargetDirectory = Property<string>.Make(test.TargetDirectory,TargetDirectory);
            this.PathExtension = Property<string>.Make(test.PathExtension,PathExtension);
            this.ResultList = Property<string>.Make(test.ResultList,ResultList);
            this.LoginID = Property<int>.Make(test.LoginID,LoginID);
            this.Username = Property<string>.Make(test.Username,Username);
            this.Password = Property<string>.Make(test.Password,Password);
            this.LoginKey = Property<string>.Make(test.LoginKey,LoginKey);
            this.LoginToken = Property<string>.Make(test.LoginToken,LoginToken);
            this.Id = Property<int>.Make(test.Id,Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            CabinetID.Revert();
            SchemeHttp.Revert();
            IntegrationIdentifier.Revert();
            ServerName.Revert();
            TargetDirectory.Revert();
            PathExtension.Revert();
            ResultList.Revert();
            LoginID.Revert();
            Username.Revert();
            Password.Revert();
            LoginKey.Revert();
            LoginToken.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<AdminDocumentsDTOEdit> MakeCollection(List<AdminDocumentsDTO> records)
        {

            var newData = new ExtRangeCollection<AdminDocumentsDTOEdit>();

            foreach (var rec in records)
            {
                var e = new AdminDocumentsDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class AdminDocumentsDTOEditList : ListObj<AdminDocumentsDTOEditList>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private AdminDocumentsDTO _dto;

        public AdminDocumentsDTOEditList()
        {
            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };
        }//endofconstructor
 
        public int CabinetID { get => _current.CabinetID; set { _current.CabinetID = value; OnPropertyChanged(); } }

        public bool SchemeHttp { get => _current.SchemeHttp; set { _current.SchemeHttp = value; OnPropertyChanged(); } }

        public string IntegrationIdentifier { get => _current.IntegrationIdentifier; set { _current.IntegrationIdentifier = value; OnPropertyChanged(); } }

        public string ServerName { get => _current.ServerName; set { _current.ServerName = value; OnPropertyChanged(); } }

        public string TargetDirectory { get => _current.TargetDirectory; set { _current.TargetDirectory = value; OnPropertyChanged(); } }

        public string PathExtension { get => _current.PathExtension; set { _current.PathExtension = value; OnPropertyChanged(); } }

        public string ResultList { get => _current.ResultList; set { _current.ResultList = value; OnPropertyChanged(); } }

        public int LoginID { get => _current.LoginID; set { _current.LoginID = value; OnPropertyChanged(); } }

        public string Username { get => _current.Username; set { _current.Username = value; OnPropertyChanged(); } }

        public string Password { get => _current.Password; set { _current.Password = value; OnPropertyChanged(); } }

        public string LoginKey { get => _current.LoginKey; set { _current.LoginKey = value; OnPropertyChanged(); } }

        public string LoginToken { get => _current.LoginToken; set { _current.LoginToken = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public AdminDocumentsDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.CabinetID = this.CabinetID;
            returnVal.SchemeHttp = this.SchemeHttp;
            returnVal.IntegrationIdentifier = this.IntegrationIdentifier;
            returnVal.ServerName = this.ServerName;
            returnVal.TargetDirectory = this.TargetDirectory;
            returnVal.PathExtension = this.PathExtension;
            returnVal.ResultList = this.ResultList;
            returnVal.LoginID = this.LoginID;
            returnVal.Username = this.Username;
            returnVal.Password = this.Password;
            returnVal.LoginKey = this.LoginKey;
            returnVal.LoginToken = this.LoginToken;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (AdminDocumentsDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(AdminDocumentsDTO test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.CabinetID = test.CabinetID;
            _current.CabinetID = test.CabinetID;
            _original.SchemeHttp = test.SchemeHttp;
            _current.SchemeHttp = test.SchemeHttp;
            _original.IntegrationIdentifier = test.IntegrationIdentifier;
            _current.IntegrationIdentifier = test.IntegrationIdentifier;
            _original.ServerName = test.ServerName;
            _current.ServerName = test.ServerName;
            _original.TargetDirectory = test.TargetDirectory;
            _current.TargetDirectory = test.TargetDirectory;
            _original.PathExtension = test.PathExtension;
            _current.PathExtension = test.PathExtension;
            _original.ResultList = test.ResultList;
            _current.ResultList = test.ResultList;
            _original.LoginID = test.LoginID;
            _current.LoginID = test.LoginID;
            _original.Username = test.Username;
            _current.Username = test.Username;
            _original.Password = test.Password;
            _current.Password = test.Password;
            _original.LoginKey = test.LoginKey;
            _current.LoginKey = test.LoginKey;
            _original.LoginToken = test.LoginToken;
            _current.LoginToken = test.LoginToken;
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<AdminDocumentsDTOEditList> MakeCollection(List<AdminDocumentsDTO> records)
        {

            var newData = new ExtRangeCollection<AdminDocumentsDTOEditList>();

            foreach (var rec in records)
            {
                var e = new AdminDocumentsDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}


