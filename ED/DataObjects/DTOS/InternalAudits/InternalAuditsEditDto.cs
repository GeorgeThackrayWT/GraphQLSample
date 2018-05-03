using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace DataObjects.DTOS.InternalAudits
{
    public class InternalAuditsEditDto : BaseDto, IRecord
    {

        public DateTime? AuditDate { get; set; }
        public int SiteManagerID { get; set; }
        public string SiteManager { get; set; }
        public int FirstAuditorID { get; set; }
        public string FirstAuditor { get; set; }
        public int SecondAuditorID { get; set; }
        public string SecondAuditor { get; set; }
        public string GeneralSummary { get; set; }
        public int CertifiedByID { get; set; }
        public DateTime? CertifyDate { get; set; }
        public int AuthorisedByID { get; set; }
        public DateTime? AuthoriseDate { get; set; }
        public bool Published { get; set; }
        public int PublishedByID { get; set; }
        public DateTime? PublishingDate { get; set; }

        public InternalAuditsEditDto Clone()
        {
            return new InternalAuditsEditDto()
            {
                Id = this.Id,
                AuditDate = this.AuditDate,
                SiteManagerID = this.SiteManagerID,
                SiteManager = this.SiteManager,
                FirstAuditorID = this.FirstAuditorID,
                FirstAuditor = this.FirstAuditor,
                SecondAuditorID = this.SecondAuditorID,
                SecondAuditor = this.SecondAuditor,
                GeneralSummary = this.GeneralSummary,
                CertifiedByID = this.CertifiedByID,
                CertifyDate = this.CertifyDate,
                AuthorisedByID = this.AuthorisedByID,
                AuthoriseDate = this.AuthoriseDate,
                Published = this.Published,
                PublishedByID = this.PublishedByID,
                PublishingDate = this.PublishingDate,
            };
        }//endofclonemethods
    }

    public class InternalAuditsEditEdit : PropertyBase<InternalAuditsEditEdit>, IDuplicate
    {

        private InternalAuditsEditDto _dto;


        public InternalAuditsEditEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<DateTime?> AuditDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<int> SiteManagerID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> SiteManager { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> FirstAuditorID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> FirstAuditor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> SecondAuditorID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> SecondAuditor { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> GeneralSummary { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> CertifiedByID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<DateTime?> CertifyDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<int> AuthorisedByID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<DateTime?> AuthoriseDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<bool> Published { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> PublishedByID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<DateTime?> PublishingDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };



        public int RecordId => Id.Value;


        public InternalAuditsEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.AuditDate = AuditDate.Value;
            returnVal.SiteManagerID = SiteManagerID.Value;
            returnVal.SiteManager = SiteManager.Value;
            returnVal.FirstAuditorID = FirstAuditorID.Value;
            returnVal.FirstAuditor = FirstAuditor.Value;
            returnVal.SecondAuditorID = SecondAuditorID.Value;
            returnVal.SecondAuditor = SecondAuditor.Value;
            returnVal.GeneralSummary = GeneralSummary.Value;
            returnVal.CertifiedByID = CertifiedByID.Value;
            returnVal.CertifyDate = CertifyDate.Value;
            returnVal.AuthorisedByID = AuthorisedByID.Value;
            returnVal.AuthoriseDate = AuthoriseDate.Value;
            returnVal.Published = Published.Value;
            returnVal.PublishedByID = PublishedByID.Value;
            returnVal.PublishingDate = PublishingDate.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsEditEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsEditDto test)
        {
            this.Id = Property<int>.Make(test.Id);
            this.AuditDate = Property<DateTime?>.Make(test.AuditDate);
            this.SiteManagerID = Property<int>.Make(test.SiteManagerID);
            this.SiteManager = Property<string>.Make(test.SiteManager);
            this.FirstAuditorID = Property<int>.Make(test.FirstAuditorID);
            this.FirstAuditor = Property<string>.Make(test.FirstAuditor);
            this.SecondAuditorID = Property<int>.Make(test.SecondAuditorID);
            this.SecondAuditor = Property<string>.Make(test.SecondAuditor);
            this.GeneralSummary = Property<string>.Make(test.GeneralSummary);
            this.CertifiedByID = Property<int>.Make(test.CertifiedByID);
            this.CertifyDate = Property<DateTime?>.Make(test.CertifyDate);
            this.AuthorisedByID = Property<int>.Make(test.AuthorisedByID);
            this.AuthoriseDate = Property<DateTime?>.Make(test.AuthoriseDate);
            this.Published = Property<bool>.Make(test.Published);
            this.PublishedByID = Property<int>.Make(test.PublishedByID);
            this.PublishingDate = Property<DateTime?>.Make(test.PublishingDate);
            this.Id = Property<int>.Make(test.Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            AuditDate.Revert();
            SiteManagerID.Revert();
            SiteManager.Revert();
            FirstAuditorID.Revert();
            FirstAuditor.Revert();
            SecondAuditorID.Revert();
            SecondAuditor.Revert();
            GeneralSummary.Revert();
            CertifiedByID.Revert();
            CertifyDate.Revert();
            AuthorisedByID.Revert();
            AuthoriseDate.Revert();
            Published.Revert();
            PublishedByID.Revert();
            PublishingDate.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsEditEdit> MakeCollection(List<InternalAuditsEditDto> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsEditEdit>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsEditEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class InternalAuditsEditEditList : ListObj<InternalAuditsEditDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private InternalAuditsEditDto _dto;


        public InternalAuditsEditEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor
        
        public DateTime? AuditDate { get => _current.AuditDate; set { _current.AuditDate = value; OnPropertyChanged(); } }
        public int SiteManagerID { get => _current.SiteManagerID; set { _current.SiteManagerID = value; OnPropertyChanged(); } }
        public string SiteManager { get => _current.SiteManager; set { _current.SiteManager = value; OnPropertyChanged(); } }
        public int FirstAuditorID { get => _current.FirstAuditorID; set { _current.FirstAuditorID = value; OnPropertyChanged(); } }
        public string FirstAuditor { get => _current.FirstAuditor; set { _current.FirstAuditor = value; OnPropertyChanged(); } }
        public int SecondAuditorID { get => _current.SecondAuditorID; set { _current.SecondAuditorID = value; OnPropertyChanged(); } }
        public string SecondAuditor { get => _current.SecondAuditor; set { _current.SecondAuditor = value; OnPropertyChanged(); } }
        public string GeneralSummary { get => _current.GeneralSummary; set { _current.GeneralSummary = value; OnPropertyChanged(); } }
        public int CertifiedByID { get => _current.CertifiedByID; set { _current.CertifiedByID = value; OnPropertyChanged(); } }
        public DateTime? CertifyDate { get => _current.CertifyDate; set { _current.CertifyDate = value; OnPropertyChanged(); } }
        public int AuthorisedByID { get => _current.AuthorisedByID; set { _current.AuthorisedByID = value; OnPropertyChanged(); } }
        public DateTime? AuthoriseDate { get => _current.AuthoriseDate; set { _current.AuthoriseDate = value; OnPropertyChanged(); } }
        public bool Published { get => _current.Published; set { _current.Published = value; OnPropertyChanged(); } }
        public int PublishedByID { get => _current.PublishedByID; set { _current.PublishedByID = value; OnPropertyChanged(); } }
        public DateTime? PublishingDate { get => _current.PublishingDate; set { _current.PublishingDate = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public InternalAuditsEditDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.AuditDate = this.AuditDate;
            returnVal.SiteManagerID = this.SiteManagerID;
            returnVal.SiteManager = this.SiteManager;
            returnVal.FirstAuditorID = this.FirstAuditorID;
            returnVal.FirstAuditor = this.FirstAuditor;
            returnVal.SecondAuditorID = this.SecondAuditorID;
            returnVal.SecondAuditor = this.SecondAuditor;
            returnVal.GeneralSummary = this.GeneralSummary;
            returnVal.CertifiedByID = this.CertifiedByID;
            returnVal.CertifyDate = this.CertifyDate;
            returnVal.AuthorisedByID = this.AuthorisedByID;
            returnVal.AuthoriseDate = this.AuthoriseDate;
            returnVal.Published = this.Published;
            returnVal.PublishedByID = this.PublishedByID;
            returnVal.PublishingDate = this.PublishingDate;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsEditEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsEditDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.AuditDate = test.AuditDate;
            _current.AuditDate = test.AuditDate;
            _original.SiteManagerID = test.SiteManagerID;
            _current.SiteManagerID = test.SiteManagerID;
            _original.SiteManager = test.SiteManager;
            _current.SiteManager = test.SiteManager;
            _original.FirstAuditorID = test.FirstAuditorID;
            _current.FirstAuditorID = test.FirstAuditorID;
            _original.FirstAuditor = test.FirstAuditor;
            _current.FirstAuditor = test.FirstAuditor;
            _original.SecondAuditorID = test.SecondAuditorID;
            _current.SecondAuditorID = test.SecondAuditorID;
            _original.SecondAuditor = test.SecondAuditor;
            _current.SecondAuditor = test.SecondAuditor;
            _original.GeneralSummary = test.GeneralSummary;
            _current.GeneralSummary = test.GeneralSummary;
            _original.CertifiedByID = test.CertifiedByID;
            _current.CertifiedByID = test.CertifiedByID;
            _original.CertifyDate = test.CertifyDate;
            _current.CertifyDate = test.CertifyDate;
            _original.AuthorisedByID = test.AuthorisedByID;
            _current.AuthorisedByID = test.AuthorisedByID;
            _original.AuthoriseDate = test.AuthoriseDate;
            _current.AuthoriseDate = test.AuthoriseDate;
            _original.Published = test.Published;
            _current.Published = test.Published;
            _original.PublishedByID = test.PublishedByID;
            _current.PublishedByID = test.PublishedByID;
            _original.PublishingDate = test.PublishingDate;
            _current.PublishingDate = test.PublishingDate;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsEditEditList> MakeCollection(List<InternalAuditsEditDto> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsEditEditList>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsEditEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}