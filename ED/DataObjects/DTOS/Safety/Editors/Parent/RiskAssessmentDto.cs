using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class RiskAssessmentDto : BaseDto, IRecord
    {
        public int? CompletedByWoodlandOfficerId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool Authorised { get; set; }
        public DateTime? DateAuthorised { get; set; }
        public int? AuthorisedByRegionalManagerId { get; set; }
        public int? FireAssessmentId { get; set; }
        public int? BiosecurityZoneId { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string PersonalIssues { get; set; }

        public bool Red { get; set; }

        public bool Amber { get; set; }

        public bool Green { get; set; }

        public bool IsContractorBasedWork { get; set; }

        public bool IsVolunteerWork { get; set; }

        public bool IsLicensed { get; set; }

        public bool IsSiteInspection { get; set; }

        public bool IsVoluntaryWarden { get; set; }

        public bool IsAccidentReportingSystem { get; set; }

        public bool IsWtSigns { get; set; }

        public bool IsEmcwcContract { get; set; }




        public string FireAssessment
        {
            get
            {
                if (FireAssessmentId == 1) return "Low";
                if (FireAssessmentId == 2) return "Medium";
                if (FireAssessmentId == 3) return "High";

                return "Low";


            }
        }


        public RiskAssessmentDto Clone()
        {
            return new RiskAssessmentDto()
            {
                CompletedByWoodlandOfficerId = this.CompletedByWoodlandOfficerId,
                DateCompleted = this.DateCompleted,
                Authorised = this.Authorised,
                DateAuthorised = this.DateAuthorised,
                AuthorisedByRegionalManagerId = this.AuthorisedByRegionalManagerId,
                FireAssessmentId = this.FireAssessmentId,
                BiosecurityZoneId = this.BiosecurityZoneId,
                ReviewDate = this.ReviewDate,
                PersonalIssues = this.PersonalIssues,
                Red = this.Red,
                Amber = this.Amber,
                Green = this.Green,
                IsContractorBasedWork = this.IsContractorBasedWork,
                IsVolunteerWork = this.IsVolunteerWork,
                IsLicensed = this.IsLicensed,
                IsSiteInspection = this.IsSiteInspection,
                IsVoluntaryWarden = this.IsVoluntaryWarden,
                IsAccidentReportingSystem = this.IsAccidentReportingSystem,
                IsWtSigns = this.IsWtSigns,
                IsEmcwcContract = this.IsEmcwcContract,              
            };
        }//endofclonemethods
    }

    public class RiskAssessmentEdit : PropertyBase<RiskAssessmentEdit>, IDuplicate
    {

        private RiskAssessmentDto _dto;


        public RiskAssessmentEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int?> CompletedByWoodlandOfficerId { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<DateTime?> DateCompleted { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<bool> Authorised { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<DateTime?> DateAuthorised { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<int?> AuthorisedByRegionalManagerId { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<int?> FireAssessmentId { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<int?> BiosecurityZoneId { get; set; } = new Property<int?>() { Value = 0, Original = 0 };
        public Property<DateTime?> ReviewDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<string> PersonalIssues { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Red { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Amber { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Green { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsContractorBasedWork { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsVolunteerWork { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsLicensed { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsSiteInspection { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsVoluntaryWarden { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsAccidentReportingSystem { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsWtSigns { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsEmcwcContract { get; set; } = new Property<bool>() { Value = false, Original = false };

        private string _fireAssessment
        {
            get
            {
                if (FireAssessmentId.Value == 1) return "Low";
                if (FireAssessmentId.Value == 2) return "Medium";
                if (FireAssessmentId.Value == 3) return "High";

                return "Low";
            }
        }

        public Property<string> FireAssessment => new Property<string>()
        {
            Value = _fireAssessment
        };


        public int RecordId => Id.Value;


        public RiskAssessmentDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.CompletedByWoodlandOfficerId = CompletedByWoodlandOfficerId.Value;
            returnVal.DateCompleted = DateCompleted.Value;
            returnVal.Authorised = Authorised.Value;
            returnVal.DateAuthorised = DateAuthorised.Value;
            returnVal.AuthorisedByRegionalManagerId = AuthorisedByRegionalManagerId.Value;
            returnVal.FireAssessmentId = FireAssessmentId.Value;
            returnVal.BiosecurityZoneId = BiosecurityZoneId.Value;
            returnVal.ReviewDate = ReviewDate.Value;
            returnVal.PersonalIssues = PersonalIssues.Value;
            returnVal.Red = Red.Value;
            returnVal.Amber = Amber.Value;
            returnVal.Green = Green.Value;
            returnVal.IsContractorBasedWork = IsContractorBasedWork.Value;
            returnVal.IsVolunteerWork = IsVolunteerWork.Value;
            returnVal.IsLicensed = IsLicensed.Value;
            returnVal.IsSiteInspection = IsSiteInspection.Value;
            returnVal.IsVoluntaryWarden = IsVoluntaryWarden.Value;
            returnVal.IsAccidentReportingSystem = IsAccidentReportingSystem.Value;
            returnVal.IsWtSigns = IsWtSigns.Value;
            returnVal.IsEmcwcContract = IsEmcwcContract.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (RiskAssessmentEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(RiskAssessmentDto test)
        {
            this.CompletedByWoodlandOfficerId = Property<int?>.Make(test.CompletedByWoodlandOfficerId);
            this.DateCompleted = Property<DateTime?>.Make(test.DateCompleted);
            this.Authorised = Property<bool>.Make(test.Authorised);
            this.DateAuthorised = Property<DateTime?>.Make(test.DateAuthorised);
            this.AuthorisedByRegionalManagerId = Property<int?>.Make(test.AuthorisedByRegionalManagerId);
            this.FireAssessmentId = Property<int?>.Make(test.FireAssessmentId);
            this.BiosecurityZoneId = Property<int?>.Make(test.BiosecurityZoneId);
            this.ReviewDate = Property<DateTime?>.Make(test.ReviewDate);
            this.PersonalIssues = Property<string>.Make(test.PersonalIssues);
            this.Red = Property<bool>.Make(test.Red);
            this.Amber = Property<bool>.Make(test.Amber);
            this.Green = Property<bool>.Make(test.Green);
            this.IsContractorBasedWork = Property<bool>.Make(test.IsContractorBasedWork);
            this.IsVolunteerWork = Property<bool>.Make(test.IsVolunteerWork);
            this.IsLicensed = Property<bool>.Make(test.IsLicensed);
            this.IsSiteInspection = Property<bool>.Make(test.IsSiteInspection);
            this.IsVoluntaryWarden = Property<bool>.Make(test.IsVoluntaryWarden);
            this.IsAccidentReportingSystem = Property<bool>.Make(test.IsAccidentReportingSystem);
            this.IsWtSigns = Property<bool>.Make(test.IsWtSigns);
            this.IsEmcwcContract = Property<bool>.Make(test.IsEmcwcContract);
            this.Id = Property<int>.Make(test.Id);


            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            CompletedByWoodlandOfficerId.Revert();
            DateCompleted.Revert();
            Authorised.Revert();
            DateAuthorised.Revert();
            AuthorisedByRegionalManagerId.Revert();
            FireAssessmentId.Revert();
            BiosecurityZoneId.Revert();
            ReviewDate.Revert();
            PersonalIssues.Revert();
            Red.Revert();
            Amber.Revert();
            Green.Revert();
            IsContractorBasedWork.Revert();
            IsVolunteerWork.Revert();
            IsLicensed.Revert();
            IsSiteInspection.Revert();
            IsVoluntaryWarden.Revert();
            IsAccidentReportingSystem.Revert();
            IsWtSigns.Revert();
            IsEmcwcContract.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<RiskAssessmentEdit> MakeCollection(List<RiskAssessmentDto> records)
        {

            var newData = new ExtRangeCollection<RiskAssessmentEdit>();

            foreach (var rec in records)
            {
                var e = new RiskAssessmentEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class RiskAssessmentEditList : ListObj<RiskAssessmentDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private RiskAssessmentDto _dto;


        public RiskAssessmentEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int? CompletedByWoodlandOfficerId { get => _current.CompletedByWoodlandOfficerId; set { _current.CompletedByWoodlandOfficerId = value; OnPropertyChanged(); } }
        public DateTime? DateCompleted { get => _current.DateCompleted; set { _current.DateCompleted = value; OnPropertyChanged(); } }
        public bool Authorised { get => _current.Authorised; set { _current.Authorised = value; OnPropertyChanged(); } }
        public DateTime? DateAuthorised { get => _current.DateAuthorised; set { _current.DateAuthorised = value; OnPropertyChanged(); } }
        public int? AuthorisedByRegionalManagerId { get => _current.AuthorisedByRegionalManagerId; set { _current.AuthorisedByRegionalManagerId = value; OnPropertyChanged(); } }
        public int? FireAssessmentId { get => _current.FireAssessmentId; set { _current.FireAssessmentId = value; OnPropertyChanged(); } }
        public int? BiosecurityZoneId { get => _current.BiosecurityZoneId; set { _current.BiosecurityZoneId = value; OnPropertyChanged(); } }
        public DateTime? ReviewDate { get => _current.ReviewDate; set { _current.ReviewDate = value; OnPropertyChanged(); } }
        public string PersonalIssues { get => _current.PersonalIssues; set { _current.PersonalIssues = value; OnPropertyChanged(); } }

        public bool Red { get => _current.Red; set { _current.Red = value; OnPropertyChanged(); } }

        public bool Amber { get => _current.Amber; set { _current.Amber = value; OnPropertyChanged(); } }

        public bool Green { get => _current.Green; set { _current.Green = value; OnPropertyChanged(); } }

        public bool IsContractorBasedWork { get => _current.IsContractorBasedWork; set { _current.IsContractorBasedWork = value; OnPropertyChanged(); } }

        public bool IsVolunteerWork { get => _current.IsVolunteerWork; set { _current.IsVolunteerWork = value; OnPropertyChanged(); } }

        public bool IsLicensed { get => _current.IsLicensed; set { _current.IsLicensed = value; OnPropertyChanged(); } }

        public bool IsSiteInspection { get => _current.IsSiteInspection; set { _current.IsSiteInspection = value; OnPropertyChanged(); } }

        public bool IsVoluntaryWarden { get => _current.IsVoluntaryWarden; set { _current.IsVoluntaryWarden = value; OnPropertyChanged(); } }

        public bool IsAccidentReportingSystem { get => _current.IsAccidentReportingSystem; set { _current.IsAccidentReportingSystem = value; OnPropertyChanged(); } }

        public bool IsWtSigns { get => _current.IsWtSigns; set { _current.IsWtSigns = value; OnPropertyChanged(); } }

        public bool IsEmcwcContract { get => _current.IsEmcwcContract; set { _current.IsEmcwcContract = value; OnPropertyChanged(); } }



        public int RecordId => Id;

        public string FireAssessment
        {
            get
            {
                if (FireAssessmentId.GetValueOrDefault() == 1) return "Low";
                if (FireAssessmentId.GetValueOrDefault() == 2) return "Medium";
                if (FireAssessmentId.GetValueOrDefault() == 3) return "High";

                return "Low";
            }
        }


        public RiskAssessmentDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.CompletedByWoodlandOfficerId = this.CompletedByWoodlandOfficerId;
            returnVal.DateCompleted = this.DateCompleted;
            returnVal.Authorised = this.Authorised;
            returnVal.DateAuthorised = this.DateAuthorised;
            returnVal.AuthorisedByRegionalManagerId = this.AuthorisedByRegionalManagerId;
            returnVal.FireAssessmentId = this.FireAssessmentId;
            returnVal.BiosecurityZoneId = this.BiosecurityZoneId;
            returnVal.ReviewDate = this.ReviewDate;
            returnVal.PersonalIssues = this.PersonalIssues;
            returnVal.Red = this.Red;
            returnVal.Amber = this.Amber;
            returnVal.Green = this.Green;
            returnVal.IsContractorBasedWork = this.IsContractorBasedWork;
            returnVal.IsVolunteerWork = this.IsVolunteerWork;
            returnVal.IsLicensed = this.IsLicensed;
            returnVal.IsSiteInspection = this.IsSiteInspection;
            returnVal.IsVoluntaryWarden = this.IsVoluntaryWarden;
            returnVal.IsAccidentReportingSystem = this.IsAccidentReportingSystem;
            returnVal.IsWtSigns = this.IsWtSigns;
            returnVal.IsEmcwcContract = this.IsEmcwcContract;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (RiskAssessmentEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(RiskAssessmentDto test)
        {
            _original.CompletedByWoodlandOfficerId = test.CompletedByWoodlandOfficerId;
            _current.CompletedByWoodlandOfficerId = test.CompletedByWoodlandOfficerId;
            _original.DateCompleted = test.DateCompleted;
            _current.DateCompleted = test.DateCompleted;
            _original.Authorised = test.Authorised;
            _current.Authorised = test.Authorised;
            _original.DateAuthorised = test.DateAuthorised;
            _current.DateAuthorised = test.DateAuthorised;
            _original.AuthorisedByRegionalManagerId = test.AuthorisedByRegionalManagerId;
            _current.AuthorisedByRegionalManagerId = test.AuthorisedByRegionalManagerId;
            _original.FireAssessmentId = test.FireAssessmentId;
            _current.FireAssessmentId = test.FireAssessmentId;
            _original.BiosecurityZoneId = test.BiosecurityZoneId;
            _current.BiosecurityZoneId = test.BiosecurityZoneId;
            _original.ReviewDate = test.ReviewDate;
            _current.ReviewDate = test.ReviewDate;
            _original.PersonalIssues = test.PersonalIssues;
            _current.PersonalIssues = test.PersonalIssues;
            _original.Red = test.Red;
            _current.Red = test.Red;
            _original.Amber = test.Amber;
            _current.Amber = test.Amber;
            _original.Green = test.Green;
            _current.Green = test.Green;
            _original.IsContractorBasedWork = test.IsContractorBasedWork;
            _current.IsContractorBasedWork = test.IsContractorBasedWork;
            _original.IsVolunteerWork = test.IsVolunteerWork;
            _current.IsVolunteerWork = test.IsVolunteerWork;
            _original.IsLicensed = test.IsLicensed;
            _current.IsLicensed = test.IsLicensed;
            _original.IsSiteInspection = test.IsSiteInspection;
            _current.IsSiteInspection = test.IsSiteInspection;
            _original.IsVoluntaryWarden = test.IsVoluntaryWarden;
            _current.IsVoluntaryWarden = test.IsVoluntaryWarden;
            _original.IsAccidentReportingSystem = test.IsAccidentReportingSystem;
            _current.IsAccidentReportingSystem = test.IsAccidentReportingSystem;
            _original.IsWtSigns = test.IsWtSigns;
            _current.IsWtSigns = test.IsWtSigns;
            _original.IsEmcwcContract = test.IsEmcwcContract;
            _current.IsEmcwcContract = test.IsEmcwcContract;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<RiskAssessmentEditList> MakeCollection(List<RiskAssessmentDto> records)
        {

            var newData = new ExtRangeCollection<RiskAssessmentEditList>();

            foreach (var rec in records)
            {
                var e = new RiskAssessmentEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}