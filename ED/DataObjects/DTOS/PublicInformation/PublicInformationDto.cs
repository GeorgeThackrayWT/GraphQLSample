using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS.PublicInformationDtos
{
    public class PublicInformationDto : BaseDto, IRecord
    {
        public int AcquisitionUnitID { get; set; }

        public string GridRef { get; set; }

        public int? Landranger { get; set; }

        public int? Explorer { get; set; }

        public string Location { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }

        public double Area { get; set; }


        public string PartOf { get; set; }
        public string LocalName { get; set; }


        public string LocalNameReason { get; set; }

        public bool UnderReview { get; set; }

        public DateTime? ConsultationDeadline { get; set; }

        public string SpecialSiteFeatures { get; set; }

        public string SuitableForFilming { get; set; }

        public string AntiSocialIssues { get; set; }

        public int? WebsiteCount { get; set; }

        public string WoodMicrosite { get; set; }


        public bool PublicEvents { get; set; }

        public bool SpecialSiteFeaturesPopulated { get; set; }

        public bool SuitableForFilmingPopulated { get; set; }

        public bool AntiSocialIssuesPopulated { get; set; }


        public bool ATHRegister { get; set; }

        public bool? PhotoLibrary { get; set; }

        public bool OperationsPosters { get; set; }

        public bool OtherSiteMaterial { get; set; }

        public bool? NonStandardKey { get; set; }

        public string Combination { get; set; }

        public DirectoryInfo DirectoryInfo { get; set; }

        public string SummaryDescription { get; set; }
        public string ExtendedDescription { get; set; }
        public string Setting { get; set; }
        public string History { get; set; }
        public string Wildlife { get; set; }
        public string TreesAndPlants { get; set; }
        public string AccessWalks { get; set; }
        public string GettingThere { get; set; }
        public string NearestAmenities { get; set; }
        public string Folklore { get; set; }
        public string OriginOfName { get; set; }

        public PublicInformationDto Clone()
        {
            return new PublicInformationDto()
            {
                AcquisitionUnitID = this.AcquisitionUnitID,
                GridRef = this.GridRef,
                Landranger = this.Landranger,
                Explorer = this.Explorer,
                Location = this.Location,
                County = this.County,
                Postcode = this.Postcode,
                Area = this.Area,
                PartOf = this.PartOf,
                LocalName = this.LocalName,
                LocalNameReason = this.LocalNameReason,
                UnderReview = this.UnderReview,
                ConsultationDeadline = this.ConsultationDeadline,
                SpecialSiteFeatures = this.SpecialSiteFeatures,
                SuitableForFilming = this.SuitableForFilming,
                AntiSocialIssues = this.AntiSocialIssues,
                WebsiteCount = this.WebsiteCount,
                WoodMicrosite = this.WoodMicrosite,
                PublicEvents = this.PublicEvents,
                SpecialSiteFeaturesPopulated = this.SpecialSiteFeaturesPopulated,
                SuitableForFilmingPopulated = this.SuitableForFilmingPopulated,
                AntiSocialIssuesPopulated = this.AntiSocialIssuesPopulated,
                ATHRegister = this.ATHRegister,
                PhotoLibrary = this.PhotoLibrary,
                OperationsPosters = this.OperationsPosters,
                OtherSiteMaterial = this.OtherSiteMaterial,
                NonStandardKey = this.NonStandardKey,
                Combination = this.Combination,
                SummaryDescription = this.SummaryDescription,
                ExtendedDescription = this.ExtendedDescription,
                Setting = this.Setting,
                History = this.History,
                Wildlife = this.Wildlife,
                TreesAndPlants = this.TreesAndPlants,
                AccessWalks = this.AccessWalks,
                GettingThere = this.GettingThere,
                NearestAmenities = this.NearestAmenities,
                Folklore = this.Folklore,
                OriginOfName = this.OriginOfName,
            };
        }//endofclonemethods
    }

    public class PublicInformationEdit : PropertyBase<PublicInformationEdit>, IDuplicate
    {

        private PublicInformationDto _dto;


        public PublicInformationEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> AcquisitionUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> GridRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int?> Landranger { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<int?> Explorer { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<string> Location { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> County { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Postcode { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> Area { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


        public Property<string> PartOf { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> LocalName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public Property<string> LocalNameReason { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> UnderReview { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> ConsultationDeadline { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> SpecialSiteFeatures { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> SuitableForFilming { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> AntiSocialIssues { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int?> WebsiteCount { get; set; } = new Property<int?>() { Value = 0, Original = 0 };

        public Property<string> WoodMicrosite { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public Property<bool> PublicEvents { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> SpecialSiteFeaturesPopulated { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> SuitableForFilmingPopulated { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> AntiSocialIssuesPopulated { get; set; } = new Property<bool>() { Value = false, Original = false };


        public Property<bool> ATHRegister { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool?> PhotoLibrary { get; set; } = new Property<bool?>() { Value = false, Original = false };

        public Property<bool> OperationsPosters { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> OtherSiteMaterial { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool?> NonStandardKey { get; set; } = new Property<bool?>() { Value = false, Original = false };

        public Property<string> Combination { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public DirectoryInfo DirectoryInfo { get; set; }

        public Property<string> SummaryDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> ExtendedDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Setting { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> History { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Wildlife { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> TreesAndPlants { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> AccessWalks { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> GettingThere { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> NearestAmenities { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Folklore { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> OriginOfName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public PublicInformationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionUnitID = AcquisitionUnitID.Value;
            returnVal.GridRef = GridRef.Value;
            returnVal.Landranger = Landranger.Value;
            returnVal.Explorer = Explorer.Value;
            returnVal.Location = Location.Value;
            returnVal.County = County.Value;
            returnVal.Postcode = Postcode.Value;
            returnVal.Area = Area.Value;
            returnVal.PartOf = PartOf.Value;
            returnVal.LocalName = LocalName.Value;
            returnVal.LocalNameReason = LocalNameReason.Value;
            returnVal.UnderReview = UnderReview.Value;
            returnVal.ConsultationDeadline = ConsultationDeadline.Value;
            returnVal.SpecialSiteFeatures = SpecialSiteFeatures.Value;
            returnVal.SuitableForFilming = SuitableForFilming.Value;
            returnVal.AntiSocialIssues = AntiSocialIssues.Value;
            returnVal.WebsiteCount = WebsiteCount.Value;
            returnVal.WoodMicrosite = WoodMicrosite.Value;
            returnVal.PublicEvents = PublicEvents.Value;
            returnVal.SpecialSiteFeaturesPopulated = SpecialSiteFeaturesPopulated.Value;
            returnVal.SuitableForFilmingPopulated = SuitableForFilmingPopulated.Value;
            returnVal.AntiSocialIssuesPopulated = AntiSocialIssuesPopulated.Value;
            returnVal.ATHRegister = ATHRegister.Value;
            returnVal.PhotoLibrary = PhotoLibrary.Value;
            returnVal.OperationsPosters = OperationsPosters.Value;
            returnVal.OtherSiteMaterial = OtherSiteMaterial.Value;
            returnVal.NonStandardKey = NonStandardKey.Value;
            returnVal.Combination = Combination.Value;
            returnVal.SummaryDescription = SummaryDescription.Value;
            returnVal.ExtendedDescription = ExtendedDescription.Value;
            returnVal.Setting = Setting.Value;
            returnVal.History = History.Value;
            returnVal.Wildlife = Wildlife.Value;
            returnVal.TreesAndPlants = TreesAndPlants.Value;
            returnVal.AccessWalks = AccessWalks.Value;
            returnVal.GettingThere = GettingThere.Value;
            returnVal.NearestAmenities = NearestAmenities.Value;
            returnVal.Folklore = Folklore.Value;
            returnVal.OriginOfName = OriginOfName.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PublicInformationEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PublicInformationDto test)
        {
            this.AcquisitionUnitID = Property<int>.Make(test.AcquisitionUnitID);
            this.GridRef = Property<string>.Make(test.GridRef);
            this.Landranger = Property<int?>.Make(test.Landranger);
            this.Explorer = Property<int?>.Make(test.Explorer);
            this.Location = Property<string>.Make(test.Location);
            this.County = Property<string>.Make(test.County);
            this.Postcode = Property<string>.Make(test.Postcode);
            this.Area = Property<double>.Make(test.Area);
            this.PartOf = Property<string>.Make(test.PartOf);
            this.LocalName = Property<string>.Make(test.LocalName);
            this.LocalNameReason = Property<string>.Make(test.LocalNameReason);
            this.UnderReview = Property<bool>.Make(test.UnderReview);
            this.ConsultationDeadline = Property<DateTime?>.Make(test.ConsultationDeadline);
            this.SpecialSiteFeatures = Property<string>.Make(test.SpecialSiteFeatures);
            this.SuitableForFilming = Property<string>.Make(test.SuitableForFilming);
            this.AntiSocialIssues = Property<string>.Make(test.AntiSocialIssues);
            this.WebsiteCount = Property<int?>.Make(test.WebsiteCount);
            this.WoodMicrosite = Property<string>.Make(test.WoodMicrosite);
            this.PublicEvents = Property<bool>.Make(test.PublicEvents);
            this.SpecialSiteFeaturesPopulated = Property<bool>.Make(test.SpecialSiteFeaturesPopulated);
            this.SuitableForFilmingPopulated = Property<bool>.Make(test.SuitableForFilmingPopulated);
            this.AntiSocialIssuesPopulated = Property<bool>.Make(test.AntiSocialIssuesPopulated);
            this.ATHRegister = Property<bool>.Make(test.ATHRegister);
            this.PhotoLibrary = Property<bool?>.Make(test.PhotoLibrary);
            this.OperationsPosters = Property<bool>.Make(test.OperationsPosters);
            this.OtherSiteMaterial = Property<bool>.Make(test.OtherSiteMaterial);
            this.NonStandardKey = Property<bool?>.Make(test.NonStandardKey);
            this.Combination = Property<string>.Make(test.Combination);
            this.SummaryDescription = Property<string>.Make(test.SummaryDescription);
            this.ExtendedDescription = Property<string>.Make(test.ExtendedDescription);
            this.Setting = Property<string>.Make(test.Setting);
            this.History = Property<string>.Make(test.History);
            this.Wildlife = Property<string>.Make(test.Wildlife);
            this.TreesAndPlants = Property<string>.Make(test.TreesAndPlants);
            this.AccessWalks = Property<string>.Make(test.AccessWalks);
            this.GettingThere = Property<string>.Make(test.GettingThere);
            this.NearestAmenities = Property<string>.Make(test.NearestAmenities);
            this.Folklore = Property<string>.Make(test.Folklore);
            this.OriginOfName = Property<string>.Make(test.OriginOfName);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AcquisitionUnitID.Revert();
            GridRef.Revert();
            Landranger.Revert();
            Explorer.Revert();
            Location.Revert();
            County.Revert();
            Postcode.Revert();
            Area.Revert();
            PartOf.Revert();
            LocalName.Revert();
            LocalNameReason.Revert();
            UnderReview.Revert();
            ConsultationDeadline.Revert();
            SpecialSiteFeatures.Revert();
            SuitableForFilming.Revert();
            AntiSocialIssues.Revert();
            WebsiteCount.Revert();
            WoodMicrosite.Revert();
            PublicEvents.Revert();
            SpecialSiteFeaturesPopulated.Revert();
            SuitableForFilmingPopulated.Revert();
            AntiSocialIssuesPopulated.Revert();
            ATHRegister.Revert();
            PhotoLibrary.Revert();
            OperationsPosters.Revert();
            OtherSiteMaterial.Revert();
            NonStandardKey.Revert();
            Combination.Revert();
            SummaryDescription.Revert();
            ExtendedDescription.Revert();
            Setting.Revert();
            History.Revert();
            Wildlife.Revert();
            TreesAndPlants.Revert();
            AccessWalks.Revert();
            GettingThere.Revert();
            NearestAmenities.Revert();
            Folklore.Revert();
            OriginOfName.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PublicInformationEdit> MakeCollection(List<PublicInformationDto> records)
        {

            var newData = new ExtRangeCollection<PublicInformationEdit>();

            foreach (var rec in records)
            {
                var e = new PublicInformationEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PublicInformationEditList : ListObj<PublicInformationDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PublicInformationDto _dto;


        public PublicInformationEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int AcquisitionUnitID { get => _current.AcquisitionUnitID; set { _current.AcquisitionUnitID = value; OnPropertyChanged(); } }

        public string GridRef { get => _current.GridRef; set { _current.GridRef = value; OnPropertyChanged(); } }

        public int? Landranger { get => _current.Landranger; set { _current.Landranger = value; OnPropertyChanged(); } }

        public int? Explorer { get => _current.Explorer; set { _current.Explorer = value; OnPropertyChanged(); } }

        public string Location { get => _current.Location; set { _current.Location = value; OnPropertyChanged(); } }
        public string County { get => _current.County; set { _current.County = value; OnPropertyChanged(); } }
        public string Postcode { get => _current.Postcode; set { _current.Postcode = value; OnPropertyChanged(); } }

        public double Area { get => _current.Area; set { _current.Area = value; OnPropertyChanged(); } }


        public string PartOf { get => _current.PartOf; set { _current.PartOf = value; OnPropertyChanged(); } }
        public string LocalName { get => _current.LocalName; set { _current.LocalName = value; OnPropertyChanged(); } }


        public string LocalNameReason { get => _current.LocalNameReason; set { _current.LocalNameReason = value; OnPropertyChanged(); } }

        public bool UnderReview { get => _current.UnderReview; set { _current.UnderReview = value; OnPropertyChanged(); } }

        public DateTime? ConsultationDeadline { get => _current.ConsultationDeadline; set { _current.ConsultationDeadline = value; OnPropertyChanged(); } }

        public string SpecialSiteFeatures { get => _current.SpecialSiteFeatures; set { _current.SpecialSiteFeatures = value; OnPropertyChanged(); } }

        public string SuitableForFilming { get => _current.SuitableForFilming; set { _current.SuitableForFilming = value; OnPropertyChanged(); } }

        public string AntiSocialIssues { get => _current.AntiSocialIssues; set { _current.AntiSocialIssues = value; OnPropertyChanged(); } }

        public int? WebsiteCount { get => _current.WebsiteCount; set { _current.WebsiteCount = value; OnPropertyChanged(); } }

        public string WoodMicrosite { get => _current.WoodMicrosite; set { _current.WoodMicrosite = value; OnPropertyChanged(); } }


        public bool PublicEvents { get => _current.PublicEvents; set { _current.PublicEvents = value; OnPropertyChanged(); } }

        public bool SpecialSiteFeaturesPopulated { get => _current.SpecialSiteFeaturesPopulated; set { _current.SpecialSiteFeaturesPopulated = value; OnPropertyChanged(); } }

        public bool SuitableForFilmingPopulated { get => _current.SuitableForFilmingPopulated; set { _current.SuitableForFilmingPopulated = value; OnPropertyChanged(); } }

        public bool AntiSocialIssuesPopulated { get => _current.AntiSocialIssuesPopulated; set { _current.AntiSocialIssuesPopulated = value; OnPropertyChanged(); } }


        public bool ATHRegister { get => _current.ATHRegister; set { _current.ATHRegister = value; OnPropertyChanged(); } }

        public bool? PhotoLibrary { get => _current.PhotoLibrary; set { _current.PhotoLibrary = value; OnPropertyChanged(); } }

        public bool OperationsPosters { get => _current.OperationsPosters; set { _current.OperationsPosters = value; OnPropertyChanged(); } }

        public bool OtherSiteMaterial { get => _current.OtherSiteMaterial; set { _current.OtherSiteMaterial = value; OnPropertyChanged(); } }

        public bool? NonStandardKey { get => _current.NonStandardKey; set { _current.NonStandardKey = value; OnPropertyChanged(); } }

        public string Combination { get => _current.Combination; set { _current.Combination = value; OnPropertyChanged(); } }

        public DirectoryInfo DirectoryInfo { get; set; }

        public string SummaryDescription { get => _current.SummaryDescription; set { _current.SummaryDescription = value; OnPropertyChanged(); } }
        public string ExtendedDescription { get => _current.ExtendedDescription; set { _current.ExtendedDescription = value; OnPropertyChanged(); } }
        public string Setting { get => _current.Setting; set { _current.Setting = value; OnPropertyChanged(); } }
        public string History { get => _current.History; set { _current.History = value; OnPropertyChanged(); } }
        public string Wildlife { get => _current.Wildlife; set { _current.Wildlife = value; OnPropertyChanged(); } }
        public string TreesAndPlants { get => _current.TreesAndPlants; set { _current.TreesAndPlants = value; OnPropertyChanged(); } }
        public string AccessWalks { get => _current.AccessWalks; set { _current.AccessWalks = value; OnPropertyChanged(); } }
        public string GettingThere { get => _current.GettingThere; set { _current.GettingThere = value; OnPropertyChanged(); } }
        public string NearestAmenities { get => _current.NearestAmenities; set { _current.NearestAmenities = value; OnPropertyChanged(); } }
        public string Folklore { get => _current.Folklore; set { _current.Folklore = value; OnPropertyChanged(); } }
        public string OriginOfName { get => _current.OriginOfName; set { _current.OriginOfName = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public PublicInformationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionUnitID = this.AcquisitionUnitID;
            returnVal.GridRef = this.GridRef;
            returnVal.Landranger = this.Landranger;
            returnVal.Explorer = this.Explorer;
            returnVal.Location = this.Location;
            returnVal.County = this.County;
            returnVal.Postcode = this.Postcode;
            returnVal.Area = this.Area;
            returnVal.PartOf = this.PartOf;
            returnVal.LocalName = this.LocalName;
            returnVal.LocalNameReason = this.LocalNameReason;
            returnVal.UnderReview = this.UnderReview;
            returnVal.ConsultationDeadline = this.ConsultationDeadline;
            returnVal.SpecialSiteFeatures = this.SpecialSiteFeatures;
            returnVal.SuitableForFilming = this.SuitableForFilming;
            returnVal.AntiSocialIssues = this.AntiSocialIssues;
            returnVal.WebsiteCount = this.WebsiteCount;
            returnVal.WoodMicrosite = this.WoodMicrosite;
            returnVal.PublicEvents = this.PublicEvents;
            returnVal.SpecialSiteFeaturesPopulated = this.SpecialSiteFeaturesPopulated;
            returnVal.SuitableForFilmingPopulated = this.SuitableForFilmingPopulated;
            returnVal.AntiSocialIssuesPopulated = this.AntiSocialIssuesPopulated;
            returnVal.ATHRegister = this.ATHRegister;
            returnVal.PhotoLibrary = this.PhotoLibrary;
            returnVal.OperationsPosters = this.OperationsPosters;
            returnVal.OtherSiteMaterial = this.OtherSiteMaterial;
            returnVal.NonStandardKey = this.NonStandardKey;
            returnVal.Combination = this.Combination;
            returnVal.SummaryDescription = this.SummaryDescription;
            returnVal.ExtendedDescription = this.ExtendedDescription;
            returnVal.Setting = this.Setting;
            returnVal.History = this.History;
            returnVal.Wildlife = this.Wildlife;
            returnVal.TreesAndPlants = this.TreesAndPlants;
            returnVal.AccessWalks = this.AccessWalks;
            returnVal.GettingThere = this.GettingThere;
            returnVal.NearestAmenities = this.NearestAmenities;
            returnVal.Folklore = this.Folklore;
            returnVal.OriginOfName = this.OriginOfName;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PublicInformationEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PublicInformationDto test)
        {
            _original.AcquisitionUnitID = test.AcquisitionUnitID;
            _current.AcquisitionUnitID = test.AcquisitionUnitID;
            _original.GridRef = test.GridRef;
            _current.GridRef = test.GridRef;
            _original.Landranger = test.Landranger;
            _current.Landranger = test.Landranger;
            _original.Explorer = test.Explorer;
            _current.Explorer = test.Explorer;
            _original.Location = test.Location;
            _current.Location = test.Location;
            _original.County = test.County;
            _current.County = test.County;
            _original.Postcode = test.Postcode;
            _current.Postcode = test.Postcode;
            _original.Area = test.Area;
            _current.Area = test.Area;
            _original.PartOf = test.PartOf;
            _current.PartOf = test.PartOf;
            _original.LocalName = test.LocalName;
            _current.LocalName = test.LocalName;
            _original.LocalNameReason = test.LocalNameReason;
            _current.LocalNameReason = test.LocalNameReason;
            _original.UnderReview = test.UnderReview;
            _current.UnderReview = test.UnderReview;
            _original.ConsultationDeadline = test.ConsultationDeadline;
            _current.ConsultationDeadline = test.ConsultationDeadline;
            _original.SpecialSiteFeatures = test.SpecialSiteFeatures;
            _current.SpecialSiteFeatures = test.SpecialSiteFeatures;
            _original.SuitableForFilming = test.SuitableForFilming;
            _current.SuitableForFilming = test.SuitableForFilming;
            _original.AntiSocialIssues = test.AntiSocialIssues;
            _current.AntiSocialIssues = test.AntiSocialIssues;
            _original.WebsiteCount = test.WebsiteCount;
            _current.WebsiteCount = test.WebsiteCount;
            _original.WoodMicrosite = test.WoodMicrosite;
            _current.WoodMicrosite = test.WoodMicrosite;
            _original.PublicEvents = test.PublicEvents;
            _current.PublicEvents = test.PublicEvents;
            _original.SpecialSiteFeaturesPopulated = test.SpecialSiteFeaturesPopulated;
            _current.SpecialSiteFeaturesPopulated = test.SpecialSiteFeaturesPopulated;
            _original.SuitableForFilmingPopulated = test.SuitableForFilmingPopulated;
            _current.SuitableForFilmingPopulated = test.SuitableForFilmingPopulated;
            _original.AntiSocialIssuesPopulated = test.AntiSocialIssuesPopulated;
            _current.AntiSocialIssuesPopulated = test.AntiSocialIssuesPopulated;
            _original.ATHRegister = test.ATHRegister;
            _current.ATHRegister = test.ATHRegister;
            _original.PhotoLibrary = test.PhotoLibrary;
            _current.PhotoLibrary = test.PhotoLibrary;
            _original.OperationsPosters = test.OperationsPosters;
            _current.OperationsPosters = test.OperationsPosters;
            _original.OtherSiteMaterial = test.OtherSiteMaterial;
            _current.OtherSiteMaterial = test.OtherSiteMaterial;
            _original.NonStandardKey = test.NonStandardKey;
            _current.NonStandardKey = test.NonStandardKey;
            _original.Combination = test.Combination;
            _current.Combination = test.Combination;
            _original.SummaryDescription = test.SummaryDescription;
            _current.SummaryDescription = test.SummaryDescription;
            _original.ExtendedDescription = test.ExtendedDescription;
            _current.ExtendedDescription = test.ExtendedDescription;
            _original.Setting = test.Setting;
            _current.Setting = test.Setting;
            _original.History = test.History;
            _current.History = test.History;
            _original.Wildlife = test.Wildlife;
            _current.Wildlife = test.Wildlife;
            _original.TreesAndPlants = test.TreesAndPlants;
            _current.TreesAndPlants = test.TreesAndPlants;
            _original.AccessWalks = test.AccessWalks;
            _current.AccessWalks = test.AccessWalks;
            _original.GettingThere = test.GettingThere;
            _current.GettingThere = test.GettingThere;
            _original.NearestAmenities = test.NearestAmenities;
            _current.NearestAmenities = test.NearestAmenities;
            _original.Folklore = test.Folklore;
            _current.Folklore = test.Folklore;
            _original.OriginOfName = test.OriginOfName;
            _current.OriginOfName = test.OriginOfName;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PublicInformationEditList> MakeCollection(List<PublicInformationDto> records)
        {

            var newData = new ExtRangeCollection<PublicInformationEditList>();

            foreach (var rec in records)
            {
                var e = new PublicInformationEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}
