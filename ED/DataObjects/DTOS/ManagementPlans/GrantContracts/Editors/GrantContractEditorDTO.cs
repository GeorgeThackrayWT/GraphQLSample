using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Abstractions;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class GrantContractEditorDto : BaseDto, IRecord
    {
        public int GrantBodyId { get; set; }

        public int SchemeId { get; set; }

        public string Reference { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string GrantPeriod { get; set; }

        public bool MainContract { get; set; }

        public bool ClumpedWith { get; set; }

        public int ClumpedWithId { get; set; }

        public bool Contract { get; set; }

        public string Notes { get; set; }

        public int CheckedBy { get; set; }

        public DateTime? CheckedByOn { get; set; }

        public int AuthorisedBy { get; set; }

        public DateTime? AuthorisedByOn { get; set; }

        public int ArchivedBy { get; set; }

        public DateTime? ArchivedByOn { get; set; }

        public GrantContractEditorDto Clone()
        {
            return new GrantContractEditorDto()
            {
                GrantBodyId = this.GrantBodyId,
                SchemeId = this.SchemeId,
                Reference = this.Reference,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                GrantPeriod = this.GrantPeriod,
                MainContract = this.MainContract,
                ClumpedWith = this.ClumpedWith,
                ClumpedWithId = this.ClumpedWithId,
                Contract = this.Contract,
                Notes = this.Notes,
                CheckedBy = this.CheckedBy,
                CheckedByOn = this.CheckedByOn,
                AuthorisedBy = this.AuthorisedBy,
                AuthorisedByOn = this.AuthorisedByOn,
                ArchivedBy = this.ArchivedBy,
                ArchivedByOn = this.ArchivedByOn,
            };
        }//endofclonemethods
    }


    public class GrantContractEditorEdit : PropertyBase<GrantContractEditorEdit>, IDuplicate
    {

        private GrantContractEditorDto _dto;


        public GrantContractEditorEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> GrantBodyId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> SchemeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Reference { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> StartDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> EndDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> GrantPeriod { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> MainContract { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> ClumpedWith { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> ClumpedWithId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> Contract { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> Notes { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> CheckedBy { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> CheckedByOn { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> AuthorisedBy { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> AuthorisedByOn { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> ArchivedBy { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> ArchivedByOn { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };



        public int RecordId => Id.Value;


        public GrantContractEditorDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GrantBodyId = GrantBodyId.Value;
            returnVal.SchemeId = SchemeId.Value;
            returnVal.Reference = Reference.Value;
            returnVal.StartDate = StartDate.Value;
            returnVal.EndDate = EndDate.Value;
            returnVal.GrantPeriod = GrantPeriod.Value;
            returnVal.MainContract = MainContract.Value;
            returnVal.ClumpedWith = ClumpedWith.Value;
            returnVal.ClumpedWithId = ClumpedWithId.Value;
            returnVal.Contract = Contract.Value;
            returnVal.Notes = Notes.Value;
            returnVal.CheckedBy = CheckedBy.Value;
            returnVal.CheckedByOn = CheckedByOn.Value;
            returnVal.AuthorisedBy = AuthorisedBy.Value;
            returnVal.AuthorisedByOn = AuthorisedByOn.Value;
            returnVal.ArchivedBy = ArchivedBy.Value;
            returnVal.ArchivedByOn = ArchivedByOn.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (GrantContractEditorEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(GrantContractEditorDto test)
        {
            this.GrantBodyId = Property<int>.Make(test.GrantBodyId,GrantBodyId,"GrantId");
            this.SchemeId = Property<int>.Make(test.SchemeId,SchemeId, "SchemeId");
            this.Reference = Property<string>.Make(test.Reference,Reference, "Reference");
            this.StartDate = Property<DateTime?>.Make(test.StartDate,StartDate, "StartDate");
            this.EndDate = Property<DateTime?>.Make(test.EndDate,EndDate, "EndDate");
            this.GrantPeriod = Property<string>.Make(test.GrantPeriod,GrantPeriod, "GrantPeriod");
            this.MainContract = Property<bool>.Make(test.MainContract,MainContract, "MainContract");
            this.ClumpedWith = Property<bool>.Make(test.ClumpedWith,ClumpedWith, "ClumpedWith");
            this.ClumpedWithId = Property<int>.Make(test.ClumpedWithId,ClumpedWithId, "ClumpedWithId");
            this.Contract = Property<bool>.Make(test.Contract,Contract, "Contract");
            this.Notes = Property<string>.Make(test.Notes,Notes, "Notes");
            this.CheckedBy = Property<int>.Make(test.CheckedBy,CheckedBy, "CheckedBy");
            this.CheckedByOn = Property<DateTime?>.Make(test.CheckedByOn,CheckedByOn, "CheckedByOn");
            this.AuthorisedBy = Property<int>.Make(test.AuthorisedBy,AuthorisedBy, "AuthorisedBy");
            this.AuthorisedByOn = Property<DateTime?>.Make(test.AuthorisedByOn,AuthorisedByOn, "AuthorisedByOn");
            this.ArchivedBy = Property<int>.Make(test.ArchivedBy,ArchivedBy, "ArchivedBy");
            this.ArchivedByOn = Property<DateTime?>.Make(test.ArchivedByOn,ArchivedByOn, "ArchivedByOn");
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            GrantBodyId.Revert();
            SchemeId.Revert();
            Reference.Revert();
            StartDate.Revert();
            EndDate.Revert();
            GrantPeriod.Revert();
            MainContract.Revert();
            ClumpedWith.Revert();
            ClumpedWithId.Revert();
            Contract.Revert();
            Notes.Revert();
            CheckedBy.Revert();
            CheckedByOn.Revert();
            AuthorisedBy.Revert();
            AuthorisedByOn.Revert();
            ArchivedBy.Revert();
            ArchivedByOn.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<GrantContractEditorEdit> MakeCollection(List<GrantContractEditorDto> records)
        {

            var newData = new ExtRangeCollection<GrantContractEditorEdit>();

            foreach (var rec in records)
            {
                var e = new GrantContractEditorEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class GrantContractEditorEditList : ListObj<GrantContractEditorDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private GrantContractEditorDto _dto;


        public GrantContractEditorEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };

            this.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                switch (e.PropertyName)
                {
                    case "CheckedBy":
                        this.CheckedByOn = DateTime.Today;
                        break;
                    case "AuthorisedBy":
                        this.AuthorisedByOn = DateTime.Today;
                        break;
                    case "ArchivedBy":
                        this.ArchivedByOn = DateTime.Today;
                        break;
                }
            };

        }//endofconstructor

        public int GrantBodyId { get => _current.GrantBodyId; set { _current.GrantBodyId = value; OnPropertyChanged(); } }

        public int SchemeId { get => _current.SchemeId; set { _current.SchemeId = value; OnPropertyChanged(); } }

        public string Reference { get => _current.Reference; set { _current.Reference = value; OnPropertyChanged(); } }

        public DateTime? StartDate { get => _current.StartDate; set { _current.StartDate = value; OnPropertyChanged(); } }

        public DateTime? EndDate { get => _current.EndDate; set { _current.EndDate = value; OnPropertyChanged(); } }

        public string GrantPeriod { get => _current.GrantPeriod; set { _current.GrantPeriod = value; OnPropertyChanged(); } }

        public bool MainContract { get => _current.MainContract; set { _current.MainContract = value; OnPropertyChanged(); } }

        public bool ClumpedWith { get => _current.ClumpedWith; set { _current.ClumpedWith = value; OnPropertyChanged(); } }

        public int ClumpedWithId { get => _current.ClumpedWithId; set { _current.ClumpedWithId = value; OnPropertyChanged(); } }

        public bool Contract { get => _current.Contract; set { _current.Contract = value; OnPropertyChanged(); } }

        public string Notes { get => _current.Notes; set { _current.Notes = value; OnPropertyChanged(); } }

        public int CheckedBy { get => _current.CheckedBy; set { _current.CheckedBy = value; OnPropertyChanged(); } }

        public DateTime? CheckedByOn { get => _current.CheckedByOn; set { _current.CheckedByOn = value; OnPropertyChanged(); } }

        public int AuthorisedBy { get => _current.AuthorisedBy; set { _current.AuthorisedBy = value; OnPropertyChanged(); } }

        public DateTime? AuthorisedByOn { get => _current.AuthorisedByOn; set { _current.AuthorisedByOn = value; OnPropertyChanged(); } }

        public int ArchivedBy { get => _current.ArchivedBy; set { _current.ArchivedBy = value; OnPropertyChanged(); } }

        public DateTime? ArchivedByOn { get => _current.ArchivedByOn; set { _current.ArchivedByOn = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public GrantContractEditorDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GrantBodyId = this.GrantBodyId;
            returnVal.SchemeId = this.SchemeId;
            returnVal.Reference = this.Reference;
            returnVal.StartDate = this.StartDate;
            returnVal.EndDate = this.EndDate;
            returnVal.GrantPeriod = this.GrantPeriod;
            returnVal.MainContract = this.MainContract;
            returnVal.ClumpedWith = this.ClumpedWith;
            returnVal.ClumpedWithId = this.ClumpedWithId;
            returnVal.Contract = this.Contract;
            returnVal.Notes = this.Notes;
            returnVal.CheckedBy = this.CheckedBy;
            returnVal.CheckedByOn = this.CheckedByOn;
            returnVal.AuthorisedBy = this.AuthorisedBy;
            returnVal.AuthorisedByOn = this.AuthorisedByOn;
            returnVal.ArchivedBy = this.ArchivedBy;
            returnVal.ArchivedByOn = this.ArchivedByOn;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (GrantContractEditorEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(GrantContractEditorDto test)
        {
            _original.GrantBodyId = test.GrantBodyId;
            _current.GrantBodyId = test.GrantBodyId;
            _original.SchemeId = test.SchemeId;
            _current.SchemeId = test.SchemeId;
            _original.Reference = test.Reference;
            _current.Reference = test.Reference;
            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.GrantPeriod = test.GrantPeriod;
            _current.GrantPeriod = test.GrantPeriod;
            _original.MainContract = test.MainContract;
            _current.MainContract = test.MainContract;
            _original.ClumpedWith = test.ClumpedWith;
            _current.ClumpedWith = test.ClumpedWith;
            _original.ClumpedWithId = test.ClumpedWithId;
            _current.ClumpedWithId = test.ClumpedWithId;
            _original.Contract = test.Contract;
            _current.Contract = test.Contract;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.CheckedBy = test.CheckedBy;
            _current.CheckedBy = test.CheckedBy;
            _original.CheckedByOn = test.CheckedByOn;
            _current.CheckedByOn = test.CheckedByOn;
            _original.AuthorisedBy = test.AuthorisedBy;
            _current.AuthorisedBy = test.AuthorisedBy;
            _original.AuthorisedByOn = test.AuthorisedByOn;
            _current.AuthorisedByOn = test.AuthorisedByOn;
            _original.ArchivedBy = test.ArchivedBy;
            _current.ArchivedBy = test.ArchivedBy;
            _original.ArchivedByOn = test.ArchivedByOn;
            _current.ArchivedByOn = test.ArchivedByOn;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<GrantContractEditorEditList> MakeCollection(List<GrantContractEditorDto> records)
        {

            var newData = new ExtRangeCollection<GrantContractEditorEditList>();

            foreach (var rec in records)
            {
                var e = new GrantContractEditorEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}
