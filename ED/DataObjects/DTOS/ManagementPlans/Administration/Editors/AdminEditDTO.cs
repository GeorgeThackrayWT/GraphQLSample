using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

 
namespace DataObjects
{ 
    public class AdminEditDTO : SearchBase, IRecord
    {
        public int ManagementPlanID { get; set; }

        public bool Aim1Creation { get; set; }

        public bool Aim2Biodiversity { get; set; }

        public bool Aim3PeopleEngagement { get; set; }

        public string NewEstateCategory { get; set; }

        public string AccessCategory { get; set; }

        public string EstateCategory { get; set; }

        public string InterimCategory { get; set; }

        public bool MainClumpedSite { get; set; }

        public bool PartOfClumpedSite { get; set; }

        public int ClumpedWith { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int ApprovedBy { get; set; }

        public bool UnderReview { get; set; }

        public DateTime? ReviewDeadline { get; set; }

        public bool UnderConsultation { get; set; }

        public DateTime? ConsultationDeadline { get; set; }

        public string SiteName { get; set; }

        public int ManagerID { get; set; }

        public int DeputyManagerID { get; set; }

        public string Directions { get; set; }
        public AdminEditDTO Clone()
        {
            return new AdminEditDTO()
            {
                ManagementPlanID = this.ManagementPlanID,
                Aim1Creation = this.Aim1Creation,
                Aim2Biodiversity = this.Aim2Biodiversity,
                Aim3PeopleEngagement = this.Aim3PeopleEngagement,
                NewEstateCategory = this.NewEstateCategory,
                AccessCategory = this.AccessCategory,
                EstateCategory = this.EstateCategory,
                InterimCategory = this.InterimCategory,
                MainClumpedSite = this.MainClumpedSite,
                PartOfClumpedSite = this.PartOfClumpedSite,
                ClumpedWith = this.ClumpedWith,
                From = this.From,
                To = this.To,
                ApprovedDate = this.ApprovedDate,
                ApprovedBy = this.ApprovedBy,
                UnderReview = this.UnderReview,
                ReviewDeadline = this.ReviewDeadline,
                UnderConsultation = this.UnderConsultation,
                ConsultationDeadline = this.ConsultationDeadline,
                SiteName = this.SiteName,
                ManagerID = this.ManagerID,
                DeputyManagerID = this.DeputyManagerID,
                Directions = this.Directions,
            };
        }//endofclonemethods
    }


    public class AdminEditDTOEdit : PropertyBase<AdminEditDTOEdit>, IDuplicate
    {

        private AdminEditDTO _dto;


        public AdminEditDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> ManagementPlanID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> Aim1Creation { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Aim2Biodiversity { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Aim3PeopleEngagement { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> NewEstateCategory { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> AccessCategory { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> EstateCategory { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> InterimCategory { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> MainClumpedSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> PartOfClumpedSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> ClumpedWith { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<DateTime?> From { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> To { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime?> ApprovedDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> ApprovedBy { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> UnderReview { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> ReviewDeadline { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> UnderConsultation { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> ConsultationDeadline { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> SiteName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> ManagerID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> DeputyManagerID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Directions { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public AdminEditDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitID = ManagementUnitID.Value;
            returnVal.ManagementPlanID = ManagementPlanID.Value;
            returnVal.Aim1Creation = Aim1Creation.Value;
            returnVal.Aim2Biodiversity = Aim2Biodiversity.Value;
            returnVal.Aim3PeopleEngagement = Aim3PeopleEngagement.Value;
            returnVal.NewEstateCategory = NewEstateCategory.Value;
            returnVal.AccessCategory = AccessCategory.Value;
            returnVal.EstateCategory = EstateCategory.Value;
            returnVal.InterimCategory = InterimCategory.Value;
            returnVal.MainClumpedSite = MainClumpedSite.Value;
            returnVal.PartOfClumpedSite = PartOfClumpedSite.Value;
            returnVal.ClumpedWith = ClumpedWith.Value;
            returnVal.From = From.Value;
            returnVal.To = To.Value;
            returnVal.ApprovedDate = ApprovedDate.Value;
            returnVal.ApprovedBy = ApprovedBy.Value;
            returnVal.UnderReview = UnderReview.Value;
            returnVal.ReviewDeadline = ReviewDeadline.Value;
            returnVal.UnderConsultation = UnderConsultation.Value;
            returnVal.ConsultationDeadline = ConsultationDeadline.Value;
            returnVal.SiteName = SiteName.Value;
            returnVal.ManagerID = ManagerID.Value;
            returnVal.DeputyManagerID = DeputyManagerID.Value;
            returnVal.Directions = Directions.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (AdminEditDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(AdminEditDTO test)
        {
            this.ManagementUnitID = Property<int>.Make(test.ManagementUnitID,ManagementUnitID);
            this.ManagementPlanID = Property<int>.Make(test.ManagementPlanID,ManagementPlanID);
            this.Aim1Creation = Property<bool>.Make(test.Aim1Creation, Aim1Creation);
            this.Aim2Biodiversity = Property<bool>.Make(test.Aim2Biodiversity, Aim2Biodiversity);
            this.Aim3PeopleEngagement = Property<bool>.Make(test.Aim3PeopleEngagement, Aim3PeopleEngagement);
            this.NewEstateCategory = Property<string>.Make(test.NewEstateCategory,NewEstateCategory);
            this.AccessCategory = Property<string>.Make(test.AccessCategory,AccessCategory);
            this.EstateCategory = Property<string>.Make(test.EstateCategory,EstateCategory);
            this.InterimCategory = Property<string>.Make(test.InterimCategory,InterimCategory);
            this.MainClumpedSite = Property<bool>.Make(test.MainClumpedSite,MainClumpedSite);
            this.PartOfClumpedSite = Property<bool>.Make(test.PartOfClumpedSite,PartOfClumpedSite);
            this.ClumpedWith = Property<int>.Make(test.ClumpedWith,ClumpedWith);
            this.From = Property<DateTime?>.Make(test.From,From);
            this.To = Property<DateTime?>.Make(test.To,To);
            this.ApprovedDate = Property<DateTime?>.Make(test.ApprovedDate,ApprovedDate);
            this.ApprovedBy = Property<int>.Make(test.ApprovedBy,ApprovedBy);
            this.UnderReview = Property<bool>.Make(test.UnderReview,UnderReview);
            this.ReviewDeadline = Property<DateTime?>.Make(test.ReviewDeadline,ReviewDeadline);
            this.UnderConsultation = Property<bool>.Make(test.UnderConsultation,UnderConsultation);
            this.ConsultationDeadline = Property<DateTime?>.Make(test.ConsultationDeadline,ConsultationDeadline);
            this.SiteName = Property<string>.Make(test.SiteName,SiteName);
            this.ManagerID = Property<int>.Make(test.ManagerID,ManagerID);
            this.DeputyManagerID = Property<int>.Make(test.DeputyManagerID,DeputyManagerID);
            this.Directions = Property<string>.Make(test.Directions,Directions);
            this.Id = Property<int>.Make(test.Id,Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitID.Revert();
            ManagementPlanID.Revert();
            Aim1Creation.Revert();
            Aim2Biodiversity.Revert();
            Aim3PeopleEngagement.Revert();
            NewEstateCategory.Revert();
            AccessCategory.Revert();
            EstateCategory.Revert();
            InterimCategory.Revert();
            MainClumpedSite.Revert();
            PartOfClumpedSite.Revert();
            ClumpedWith.Revert();
            From.Revert();
            To.Revert();
            ApprovedDate.Revert();
            ApprovedBy.Revert();
            UnderReview.Revert();
            ReviewDeadline.Revert();
            UnderConsultation.Revert();
            ConsultationDeadline.Revert();
            SiteName.Revert();
            ManagerID.Revert();
            DeputyManagerID.Revert();
            Directions.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<AdminEditDTOEdit> MakeCollection(List<AdminEditDTO> records)
        {

            var newData = new ExtRangeCollection<AdminEditDTOEdit>();

            foreach (var rec in records)
            {
                var e = new AdminEditDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class AdminEditDTOEditList : ListObj<AdminEditDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private AdminEditDTO _dto;


      public AdminEditDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ManagementUnitID { get => _current.ManagementUnitID; set { _current.ManagementUnitID = value; OnPropertyChanged(); } }

        public int ManagementPlanID { get => _current.ManagementPlanID; set { _current.ManagementPlanID = value; OnPropertyChanged(); } }

        public bool Aim1Creation { get => _current.Aim1Creation; set { _current.Aim1Creation = value; OnPropertyChanged(); } }

        public bool Aim2Biodiversity { get => _current.Aim2Biodiversity; set { _current.Aim2Biodiversity = value; OnPropertyChanged(); } }

        public bool Aim3PeopleEngagement { get => _current.Aim3PeopleEngagement; set { _current.Aim3PeopleEngagement = value; OnPropertyChanged(); } }

        public string NewEstateCategory { get => _current.NewEstateCategory; set { _current.NewEstateCategory = value; OnPropertyChanged(); } }

        public string AccessCategory { get => _current.AccessCategory; set { _current.AccessCategory = value; OnPropertyChanged(); } }

        public string EstateCategory { get => _current.EstateCategory; set { _current.EstateCategory = value; OnPropertyChanged(); } }

        public string InterimCategory { get => _current.InterimCategory; set { _current.InterimCategory = value; OnPropertyChanged(); } }

        public bool MainClumpedSite { get => _current.MainClumpedSite; set { _current.MainClumpedSite = value; OnPropertyChanged(); } }

        public bool PartOfClumpedSite { get => _current.PartOfClumpedSite; set { _current.PartOfClumpedSite = value; OnPropertyChanged(); } }

        public int ClumpedWith { get => _current.ClumpedWith; set { _current.ClumpedWith = value; OnPropertyChanged(); } }

        public DateTime? From { get => _current.From; set { _current.From = value; OnPropertyChanged(); } }

        public DateTime? To { get => _current.To; set { _current.To = value; OnPropertyChanged(); } }

        public DateTime? ApprovedDate { get => _current.ApprovedDate; set { _current.ApprovedDate = value; OnPropertyChanged(); } }

        public int ApprovedBy { get => _current.ApprovedBy; set { _current.ApprovedBy = value; OnPropertyChanged(); } }

        public bool UnderReview { get => _current.UnderReview; set { _current.UnderReview = value; OnPropertyChanged(); } }

        public DateTime? ReviewDeadline { get => _current.ReviewDeadline; set { _current.ReviewDeadline = value; OnPropertyChanged(); } }

        public bool UnderConsultation { get => _current.UnderConsultation; set { _current.UnderConsultation = value; OnPropertyChanged(); } }

        public DateTime? ConsultationDeadline { get => _current.ConsultationDeadline; set { _current.ConsultationDeadline = value; OnPropertyChanged(); } }

        public string SiteName { get => _current.SiteName; set { _current.SiteName = value; OnPropertyChanged(); } }

        public int ManagerID { get => _current.ManagerID; set { _current.ManagerID = value; OnPropertyChanged(); } }

        public int DeputyManagerID { get => _current.DeputyManagerID; set { _current.DeputyManagerID = value; OnPropertyChanged(); } }

        public string Directions { get => _current.Directions; set { _current.Directions = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public AdminEditDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitID = this.ManagementUnitID;
            returnVal.ManagementPlanID = this.ManagementPlanID;
            returnVal.Aim1Creation = this.Aim1Creation;
            returnVal.Aim2Biodiversity = this.Aim2Biodiversity;
            returnVal.Aim3PeopleEngagement = this.Aim3PeopleEngagement;
            returnVal.NewEstateCategory = this.NewEstateCategory;
            returnVal.AccessCategory = this.AccessCategory;
            returnVal.EstateCategory = this.EstateCategory;
            returnVal.InterimCategory = this.InterimCategory;
            returnVal.MainClumpedSite = this.MainClumpedSite;
            returnVal.PartOfClumpedSite = this.PartOfClumpedSite;
            returnVal.ClumpedWith = this.ClumpedWith;
            returnVal.From = this.From;
            returnVal.To = this.To;
            returnVal.ApprovedDate = this.ApprovedDate;
            returnVal.ApprovedBy = this.ApprovedBy;
            returnVal.UnderReview = this.UnderReview;
            returnVal.ReviewDeadline = this.ReviewDeadline;
            returnVal.UnderConsultation = this.UnderConsultation;
            returnVal.ConsultationDeadline = this.ConsultationDeadline;
            returnVal.SiteName = this.SiteName;
            returnVal.ManagerID = this.ManagerID;
            returnVal.DeputyManagerID = this.DeputyManagerID;
            returnVal.Directions = this.Directions;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (AdminEditDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(AdminEditDTO test)
        {
            _original.ManagementUnitID = test.ManagementUnitID;
            _current.ManagementUnitID = test.ManagementUnitID;
            _original.ManagementPlanID = test.ManagementPlanID;
            _current.ManagementPlanID = test.ManagementPlanID;
            _original.Aim1Creation = test.Aim1Creation;
            _current.Aim1Creation = test.Aim1Creation;
            _original.Aim2Biodiversity = test.Aim2Biodiversity;
            _current.Aim2Biodiversity = test.Aim2Biodiversity;
            _original.Aim3PeopleEngagement = test.Aim3PeopleEngagement;
            _current.Aim3PeopleEngagement = test.Aim3PeopleEngagement;
            _original.NewEstateCategory = test.NewEstateCategory;
            _current.NewEstateCategory = test.NewEstateCategory;
            _original.AccessCategory = test.AccessCategory;
            _current.AccessCategory = test.AccessCategory;
            _original.EstateCategory = test.EstateCategory;
            _current.EstateCategory = test.EstateCategory;
            _original.InterimCategory = test.InterimCategory;
            _current.InterimCategory = test.InterimCategory;
            _original.MainClumpedSite = test.MainClumpedSite;
            _current.MainClumpedSite = test.MainClumpedSite;
            _original.PartOfClumpedSite = test.PartOfClumpedSite;
            _current.PartOfClumpedSite = test.PartOfClumpedSite;
            _original.ClumpedWith = test.ClumpedWith;
            _current.ClumpedWith = test.ClumpedWith;
            _original.From = test.From;
            _current.From = test.From;
            _original.To = test.To;
            _current.To = test.To;
            _original.ApprovedDate = test.ApprovedDate;
            _current.ApprovedDate = test.ApprovedDate;
            _original.ApprovedBy = test.ApprovedBy;
            _current.ApprovedBy = test.ApprovedBy;
            _original.UnderReview = test.UnderReview;
            _current.UnderReview = test.UnderReview;
            _original.ReviewDeadline = test.ReviewDeadline;
            _current.ReviewDeadline = test.ReviewDeadline;
            _original.UnderConsultation = test.UnderConsultation;
            _current.UnderConsultation = test.UnderConsultation;
            _original.ConsultationDeadline = test.ConsultationDeadline;
            _current.ConsultationDeadline = test.ConsultationDeadline;
            _original.SiteName = test.SiteName;
            _current.SiteName = test.SiteName;
            _original.ManagerID = test.ManagerID;
            _current.ManagerID = test.ManagerID;
            _original.DeputyManagerID = test.DeputyManagerID;
            _current.DeputyManagerID = test.DeputyManagerID;
            _original.Directions = test.Directions;
            _current.Directions = test.Directions;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<AdminEditDTOEditList> MakeCollection(List<AdminEditDTO> records)
        {

            var newData = new ExtRangeCollection<AdminEditDTOEditList>();

            foreach (var rec in records)
            {
                var e = new AdminEditDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}