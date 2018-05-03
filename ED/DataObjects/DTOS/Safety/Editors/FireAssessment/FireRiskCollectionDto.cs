using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.SafetyObjects.Editors
{

    public class FireRiskCollectionDto : BaseDto, IRecord
    {
        public bool OneSigRiskType { get; set; }
        public int OneSigRiskTypeId { get; set; }
        public bool OneSigRiskFiveYears { get; set; }
        public int OneSigRiskFiveYearsId { get; set; }
        public bool NoSigInFiveYears { get; set; }
        public int NoSigInFiveYearsId { get; set; }
        public bool NewCampFiresAnnually { get; set; }
        public int NewCampFiresAnnuallyId { get; set; }
        public bool HistoryOfAccidentalFires { get; set; }
        public int HistoryOfAccidentalFiresId { get; set; }
        public bool CampFiresOccasionally { get; set; }
        public int CampFiresOccasionallyId { get; set; }
        public bool HistoryAccidentalFires { get; set; }
        public int HistoryAccidentalFiresId { get; set; }
        public bool NoHistoryOfAccidentalFires { get; set; }
        public int NoHistoryOfAccidentalFiresId { get; set; }
        public bool SiteContainsConiferBlocks25 { get; set; }
        public int SiteContainsConiferBlocks25Id { get; set; }
        public bool SiteContainsHeathland { get; set; }
        public int SiteContainsHeathlandId { get; set; }
        public bool SiteContainsBrash { get; set; }
        public int SiteContainsBrashId { get; set; }
        public bool SiteSoilsArePeat { get; set; }
        public int SiteSoilsArePeatId { get; set; }
        public bool SiteContainsMixedConifer { get; set; }
        public int SiteContainsMixedConiferId { get; set; }
        public bool SiteContainsSomeContinous { get; set; }
        public int SiteContainsSomeContinousId { get; set; }
        public bool GroundFloraIncludes { get; set; }
        public int GroundFloraIncludesId { get; set; }
        public bool PureBlWoodland { get; set; }
        public int PureBlWoodlandId { get; set; }
        public bool LittleOrNoContinousArea { get; set; }
        public int LittleOrNoContinousAreaId { get; set; }
        public bool WetThroughSummerMonths { get; set; }
        public int WetThroughSummerMonthsId { get; set; }
        public bool WoodlandCreationSite { get; set; }
        public int WoodlandCreationSiteId { get; set; }
        public bool HousingAdjoiningSite { get; set; }
        public int HousingAdjoiningSiteId { get; set; }
        public bool Houses25M { get; set; }
        public int Houses25MId { get; set; }
        public bool NoHousing { get; set; }
        public int NoHousingId { get; set; }

        public FireRiskCollectionDto Clone()
        {
            return new FireRiskCollectionDto()
            {
                OneSigRiskType = this.OneSigRiskType,
                OneSigRiskTypeId = this.OneSigRiskTypeId,
                OneSigRiskFiveYears = this.OneSigRiskFiveYears,
                OneSigRiskFiveYearsId = this.OneSigRiskFiveYearsId,
                NoSigInFiveYears = this.NoSigInFiveYears,
                NoSigInFiveYearsId = this.NoSigInFiveYearsId,
                NewCampFiresAnnually = this.NewCampFiresAnnually,
                NewCampFiresAnnuallyId = this.NewCampFiresAnnuallyId,
                HistoryOfAccidentalFires = this.HistoryOfAccidentalFires,
                HistoryOfAccidentalFiresId = this.HistoryOfAccidentalFiresId,
                CampFiresOccasionally = this.CampFiresOccasionally,
                CampFiresOccasionallyId = this.CampFiresOccasionallyId,
                HistoryAccidentalFires = this.HistoryAccidentalFires,
                HistoryAccidentalFiresId = this.HistoryAccidentalFiresId,
                NoHistoryOfAccidentalFires = this.NoHistoryOfAccidentalFires,
                NoHistoryOfAccidentalFiresId = this.NoHistoryOfAccidentalFiresId,
                SiteContainsConiferBlocks25 = this.SiteContainsConiferBlocks25,
                SiteContainsConiferBlocks25Id = this.SiteContainsConiferBlocks25Id,
                SiteContainsHeathland = this.SiteContainsHeathland,
                SiteContainsHeathlandId = this.SiteContainsHeathlandId,
                SiteContainsBrash = this.SiteContainsBrash,
                SiteContainsBrashId = this.SiteContainsBrashId,
                SiteSoilsArePeat = this.SiteSoilsArePeat,
                SiteSoilsArePeatId = this.SiteSoilsArePeatId,
                SiteContainsMixedConifer = this.SiteContainsMixedConifer,
                SiteContainsMixedConiferId = this.SiteContainsMixedConiferId,
                SiteContainsSomeContinous = this.SiteContainsSomeContinous,
                SiteContainsSomeContinousId = this.SiteContainsSomeContinousId,
                GroundFloraIncludes = this.GroundFloraIncludes,
                GroundFloraIncludesId = this.GroundFloraIncludesId,
                PureBlWoodland = this.PureBlWoodland,
                PureBlWoodlandId = this.PureBlWoodlandId,
                LittleOrNoContinousArea = this.LittleOrNoContinousArea,
                LittleOrNoContinousAreaId = this.LittleOrNoContinousAreaId,
                WetThroughSummerMonths = this.WetThroughSummerMonths,
                WetThroughSummerMonthsId = this.WetThroughSummerMonthsId,
                WoodlandCreationSite = this.WoodlandCreationSite,
                WoodlandCreationSiteId = this.WoodlandCreationSiteId,
                HousingAdjoiningSite = this.HousingAdjoiningSite,
                HousingAdjoiningSiteId = this.HousingAdjoiningSiteId,
                Houses25M = this.Houses25M,
                Houses25MId = this.Houses25MId,
                NoHousing = this.NoHousing,
                NoHousingId = this.NoHousingId,
            };
        }//endofclonemethods
    }
    
    public class FireRiskCollectionEdit : PropertyBase<FireRiskCollectionEdit>, IDuplicate
    {

        private FireRiskCollectionDto _dto;


        public FireRiskCollectionEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<bool> OneSigRiskType { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> OneSigRiskTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> OneSigRiskFiveYears { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> OneSigRiskFiveYearsId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> NoSigInFiveYears { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> NoSigInFiveYearsId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> NewCampFiresAnnually { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> NewCampFiresAnnuallyId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> HistoryOfAccidentalFires { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> HistoryOfAccidentalFiresId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> CampFiresOccasionally { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> CampFiresOccasionallyId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> HistoryAccidentalFires { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> HistoryAccidentalFiresId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> NoHistoryOfAccidentalFires { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> NoHistoryOfAccidentalFiresId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteContainsConiferBlocks25 { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteContainsConiferBlocks25Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteContainsHeathland { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteContainsHeathlandId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteContainsBrash { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteContainsBrashId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteSoilsArePeat { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteSoilsArePeatId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteContainsMixedConifer { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteContainsMixedConiferId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SiteContainsSomeContinous { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> SiteContainsSomeContinousId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> GroundFloraIncludes { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> GroundFloraIncludesId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> PureBlWoodland { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> PureBlWoodlandId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> LittleOrNoContinousArea { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> LittleOrNoContinousAreaId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> WetThroughSummerMonths { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> WetThroughSummerMonthsId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> WoodlandCreationSite { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> WoodlandCreationSiteId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> HousingAdjoiningSite { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> HousingAdjoiningSiteId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> Houses25M { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> Houses25MId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> NoHousing { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<int> NoHousingId { get; set; } = new Property<int>() { Value = 0, Original = 0 };



        public int RecordId => Id.Value;


        public FireRiskCollectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.OneSigRiskType = OneSigRiskType.Value;
            returnVal.OneSigRiskTypeId = OneSigRiskTypeId.Value;
            returnVal.OneSigRiskFiveYears = OneSigRiskFiveYears.Value;
            returnVal.OneSigRiskFiveYearsId = OneSigRiskFiveYearsId.Value;
            returnVal.NoSigInFiveYears = NoSigInFiveYears.Value;
            returnVal.NoSigInFiveYearsId = NoSigInFiveYearsId.Value;
            returnVal.NewCampFiresAnnually = NewCampFiresAnnually.Value;
            returnVal.NewCampFiresAnnuallyId = NewCampFiresAnnuallyId.Value;
            returnVal.HistoryOfAccidentalFires = HistoryOfAccidentalFires.Value;
            returnVal.HistoryOfAccidentalFiresId = HistoryOfAccidentalFiresId.Value;
            returnVal.CampFiresOccasionally = CampFiresOccasionally.Value;
            returnVal.CampFiresOccasionallyId = CampFiresOccasionallyId.Value;
            returnVal.HistoryAccidentalFires = HistoryAccidentalFires.Value;
            returnVal.HistoryAccidentalFiresId = HistoryAccidentalFiresId.Value;
            returnVal.NoHistoryOfAccidentalFires = NoHistoryOfAccidentalFires.Value;
            returnVal.NoHistoryOfAccidentalFiresId = NoHistoryOfAccidentalFiresId.Value;
            returnVal.SiteContainsConiferBlocks25 = SiteContainsConiferBlocks25.Value;
            returnVal.SiteContainsConiferBlocks25Id = SiteContainsConiferBlocks25Id.Value;
            returnVal.SiteContainsHeathland = SiteContainsHeathland.Value;
            returnVal.SiteContainsHeathlandId = SiteContainsHeathlandId.Value;
            returnVal.SiteContainsBrash = SiteContainsBrash.Value;
            returnVal.SiteContainsBrashId = SiteContainsBrashId.Value;
            returnVal.SiteSoilsArePeat = SiteSoilsArePeat.Value;
            returnVal.SiteSoilsArePeatId = SiteSoilsArePeatId.Value;
            returnVal.SiteContainsMixedConifer = SiteContainsMixedConifer.Value;
            returnVal.SiteContainsMixedConiferId = SiteContainsMixedConiferId.Value;
            returnVal.SiteContainsSomeContinous = SiteContainsSomeContinous.Value;
            returnVal.SiteContainsSomeContinousId = SiteContainsSomeContinousId.Value;
            returnVal.GroundFloraIncludes = GroundFloraIncludes.Value;
            returnVal.GroundFloraIncludesId = GroundFloraIncludesId.Value;
            returnVal.PureBlWoodland = PureBlWoodland.Value;
            returnVal.PureBlWoodlandId = PureBlWoodlandId.Value;
            returnVal.LittleOrNoContinousArea = LittleOrNoContinousArea.Value;
            returnVal.LittleOrNoContinousAreaId = LittleOrNoContinousAreaId.Value;
            returnVal.WetThroughSummerMonths = WetThroughSummerMonths.Value;
            returnVal.WetThroughSummerMonthsId = WetThroughSummerMonthsId.Value;
            returnVal.WoodlandCreationSite = WoodlandCreationSite.Value;
            returnVal.WoodlandCreationSiteId = WoodlandCreationSiteId.Value;
            returnVal.HousingAdjoiningSite = HousingAdjoiningSite.Value;
            returnVal.HousingAdjoiningSiteId = HousingAdjoiningSiteId.Value;
            returnVal.Houses25M = Houses25M.Value;
            returnVal.Houses25MId = Houses25MId.Value;
            returnVal.NoHousing = NoHousing.Value;
            returnVal.NoHousingId = NoHousingId.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (FireRiskCollectionEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(FireRiskCollectionDto test)
        {
            this.OneSigRiskType = Property<bool>.Make(test.OneSigRiskType);
            this.OneSigRiskTypeId = Property<int>.Make(test.OneSigRiskTypeId);
            this.OneSigRiskFiveYears = Property<bool>.Make(test.OneSigRiskFiveYears);
            this.OneSigRiskFiveYearsId = Property<int>.Make(test.OneSigRiskFiveYearsId);
            this.NoSigInFiveYears = Property<bool>.Make(test.NoSigInFiveYears);
            this.NoSigInFiveYearsId = Property<int>.Make(test.NoSigInFiveYearsId);
            this.NewCampFiresAnnually = Property<bool>.Make(test.NewCampFiresAnnually);
            this.NewCampFiresAnnuallyId = Property<int>.Make(test.NewCampFiresAnnuallyId);
            this.HistoryOfAccidentalFires = Property<bool>.Make(test.HistoryOfAccidentalFires);
            this.HistoryOfAccidentalFiresId = Property<int>.Make(test.HistoryOfAccidentalFiresId);
            this.CampFiresOccasionally = Property<bool>.Make(test.CampFiresOccasionally);
            this.CampFiresOccasionallyId = Property<int>.Make(test.CampFiresOccasionallyId);
            this.HistoryAccidentalFires = Property<bool>.Make(test.HistoryAccidentalFires);
            this.HistoryAccidentalFiresId = Property<int>.Make(test.HistoryAccidentalFiresId);
            this.NoHistoryOfAccidentalFires = Property<bool>.Make(test.NoHistoryOfAccidentalFires);
            this.NoHistoryOfAccidentalFiresId = Property<int>.Make(test.NoHistoryOfAccidentalFiresId);
            this.SiteContainsConiferBlocks25 = Property<bool>.Make(test.SiteContainsConiferBlocks25);
            this.SiteContainsConiferBlocks25Id = Property<int>.Make(test.SiteContainsConiferBlocks25Id);
            this.SiteContainsHeathland = Property<bool>.Make(test.SiteContainsHeathland);
            this.SiteContainsHeathlandId = Property<int>.Make(test.SiteContainsHeathlandId);
            this.SiteContainsBrash = Property<bool>.Make(test.SiteContainsBrash);
            this.SiteContainsBrashId = Property<int>.Make(test.SiteContainsBrashId);
            this.SiteSoilsArePeat = Property<bool>.Make(test.SiteSoilsArePeat);
            this.SiteSoilsArePeatId = Property<int>.Make(test.SiteSoilsArePeatId);
            this.SiteContainsMixedConifer = Property<bool>.Make(test.SiteContainsMixedConifer);
            this.SiteContainsMixedConiferId = Property<int>.Make(test.SiteContainsMixedConiferId);
            this.SiteContainsSomeContinous = Property<bool>.Make(test.SiteContainsSomeContinous);
            this.SiteContainsSomeContinousId = Property<int>.Make(test.SiteContainsSomeContinousId);
            this.GroundFloraIncludes = Property<bool>.Make(test.GroundFloraIncludes);
            this.GroundFloraIncludesId = Property<int>.Make(test.GroundFloraIncludesId);
            this.PureBlWoodland = Property<bool>.Make(test.PureBlWoodland);
            this.PureBlWoodlandId = Property<int>.Make(test.PureBlWoodlandId);
            this.LittleOrNoContinousArea = Property<bool>.Make(test.LittleOrNoContinousArea);
            this.LittleOrNoContinousAreaId = Property<int>.Make(test.LittleOrNoContinousAreaId);
            this.WetThroughSummerMonths = Property<bool>.Make(test.WetThroughSummerMonths);
            this.WetThroughSummerMonthsId = Property<int>.Make(test.WetThroughSummerMonthsId);
            this.WoodlandCreationSite = Property<bool>.Make(test.WoodlandCreationSite);
            this.WoodlandCreationSiteId = Property<int>.Make(test.WoodlandCreationSiteId);
            this.HousingAdjoiningSite = Property<bool>.Make(test.HousingAdjoiningSite);
            this.HousingAdjoiningSiteId = Property<int>.Make(test.HousingAdjoiningSiteId);
            this.Houses25M = Property<bool>.Make(test.Houses25M);
            this.Houses25MId = Property<int>.Make(test.Houses25MId);
            this.NoHousing = Property<bool>.Make(test.NoHousing);
            this.NoHousingId = Property<int>.Make(test.NoHousingId);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            OneSigRiskType.Revert();
            OneSigRiskTypeId.Revert();
            OneSigRiskFiveYears.Revert();
            OneSigRiskFiveYearsId.Revert();
            NoSigInFiveYears.Revert();
            NoSigInFiveYearsId.Revert();
            NewCampFiresAnnually.Revert();
            NewCampFiresAnnuallyId.Revert();
            HistoryOfAccidentalFires.Revert();
            HistoryOfAccidentalFiresId.Revert();
            CampFiresOccasionally.Revert();
            CampFiresOccasionallyId.Revert();
            HistoryAccidentalFires.Revert();
            HistoryAccidentalFiresId.Revert();
            NoHistoryOfAccidentalFires.Revert();
            NoHistoryOfAccidentalFiresId.Revert();
            SiteContainsConiferBlocks25.Revert();
            SiteContainsConiferBlocks25Id.Revert();
            SiteContainsHeathland.Revert();
            SiteContainsHeathlandId.Revert();
            SiteContainsBrash.Revert();
            SiteContainsBrashId.Revert();
            SiteSoilsArePeat.Revert();
            SiteSoilsArePeatId.Revert();
            SiteContainsMixedConifer.Revert();
            SiteContainsMixedConiferId.Revert();
            SiteContainsSomeContinous.Revert();
            SiteContainsSomeContinousId.Revert();
            GroundFloraIncludes.Revert();
            GroundFloraIncludesId.Revert();
            PureBlWoodland.Revert();
            PureBlWoodlandId.Revert();
            LittleOrNoContinousArea.Revert();
            LittleOrNoContinousAreaId.Revert();
            WetThroughSummerMonths.Revert();
            WetThroughSummerMonthsId.Revert();
            WoodlandCreationSite.Revert();
            WoodlandCreationSiteId.Revert();
            HousingAdjoiningSite.Revert();
            HousingAdjoiningSiteId.Revert();
            Houses25M.Revert();
            Houses25MId.Revert();
            NoHousing.Revert();
            NoHousingId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<FireRiskCollectionEdit> MakeCollection(List<FireRiskCollectionDto> records)
        {

            var newData = new ExtRangeCollection<FireRiskCollectionEdit>();

            foreach (var rec in records)
            {
                var e = new FireRiskCollectionEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class FireRiskCollectionEditList : ListObj<FireRiskCollectionDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private FireRiskCollectionDto _dto;


        public FireRiskCollectionEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public bool OneSigRiskType { get => _current.OneSigRiskType; set { _current.OneSigRiskType = value; OnPropertyChanged(); } }
        public int OneSigRiskTypeId { get => _current.OneSigRiskTypeId; set { _current.OneSigRiskTypeId = value; OnPropertyChanged(); } }
        public bool OneSigRiskFiveYears { get => _current.OneSigRiskFiveYears; set { _current.OneSigRiskFiveYears = value; OnPropertyChanged(); } }
        public int OneSigRiskFiveYearsId { get => _current.OneSigRiskFiveYearsId; set { _current.OneSigRiskFiveYearsId = value; OnPropertyChanged(); } }
        public bool NoSigInFiveYears { get => _current.NoSigInFiveYears; set { _current.NoSigInFiveYears = value; OnPropertyChanged(); } }
        public int NoSigInFiveYearsId { get => _current.NoSigInFiveYearsId; set { _current.NoSigInFiveYearsId = value; OnPropertyChanged(); } }
        public bool NewCampFiresAnnually { get => _current.NewCampFiresAnnually; set { _current.NewCampFiresAnnually = value; OnPropertyChanged(); } }
        public int NewCampFiresAnnuallyId { get => _current.NewCampFiresAnnuallyId; set { _current.NewCampFiresAnnuallyId = value; OnPropertyChanged(); } }
        public bool HistoryOfAccidentalFires { get => _current.HistoryOfAccidentalFires; set { _current.HistoryOfAccidentalFires = value; OnPropertyChanged(); } }
        public int HistoryOfAccidentalFiresId { get => _current.HistoryOfAccidentalFiresId; set { _current.HistoryOfAccidentalFiresId = value; OnPropertyChanged(); } }
        public bool CampFiresOccasionally { get => _current.CampFiresOccasionally; set { _current.CampFiresOccasionally = value; OnPropertyChanged(); } }
        public int CampFiresOccasionallyId { get => _current.CampFiresOccasionallyId; set { _current.CampFiresOccasionallyId = value; OnPropertyChanged(); } }
        public bool HistoryAccidentalFires { get => _current.HistoryAccidentalFires; set { _current.HistoryAccidentalFires = value; OnPropertyChanged(); } }
        public int HistoryAccidentalFiresId { get => _current.HistoryAccidentalFiresId; set { _current.HistoryAccidentalFiresId = value; OnPropertyChanged(); } }
        public bool NoHistoryOfAccidentalFires { get => _current.NoHistoryOfAccidentalFires; set { _current.NoHistoryOfAccidentalFires = value; OnPropertyChanged(); } }
        public int NoHistoryOfAccidentalFiresId { get => _current.NoHistoryOfAccidentalFiresId; set { _current.NoHistoryOfAccidentalFiresId = value; OnPropertyChanged(); } }
        public bool SiteContainsConiferBlocks25 { get => _current.SiteContainsConiferBlocks25; set { _current.SiteContainsConiferBlocks25 = value; OnPropertyChanged(); } }
        public int SiteContainsConiferBlocks25Id { get => _current.SiteContainsConiferBlocks25Id; set { _current.SiteContainsConiferBlocks25Id = value; OnPropertyChanged(); } }
        public bool SiteContainsHeathland { get => _current.SiteContainsHeathland; set { _current.SiteContainsHeathland = value; OnPropertyChanged(); } }
        public int SiteContainsHeathlandId { get => _current.SiteContainsHeathlandId; set { _current.SiteContainsHeathlandId = value; OnPropertyChanged(); } }
        public bool SiteContainsBrash { get => _current.SiteContainsBrash; set { _current.SiteContainsBrash = value; OnPropertyChanged(); } }
        public int SiteContainsBrashId { get => _current.SiteContainsBrashId; set { _current.SiteContainsBrashId = value; OnPropertyChanged(); } }
        public bool SiteSoilsArePeat { get => _current.SiteSoilsArePeat; set { _current.SiteSoilsArePeat = value; OnPropertyChanged(); } }
        public int SiteSoilsArePeatId { get => _current.SiteSoilsArePeatId; set { _current.SiteSoilsArePeatId = value; OnPropertyChanged(); } }
        public bool SiteContainsMixedConifer { get => _current.SiteContainsMixedConifer; set { _current.SiteContainsMixedConifer = value; OnPropertyChanged(); } }
        public int SiteContainsMixedConiferId { get => _current.SiteContainsMixedConiferId; set { _current.SiteContainsMixedConiferId = value; OnPropertyChanged(); } }
        public bool SiteContainsSomeContinous { get => _current.SiteContainsSomeContinous; set { _current.SiteContainsSomeContinous = value; OnPropertyChanged(); } }
        public int SiteContainsSomeContinousId { get => _current.SiteContainsSomeContinousId; set { _current.SiteContainsSomeContinousId = value; OnPropertyChanged(); } }
        public bool GroundFloraIncludes { get => _current.GroundFloraIncludes; set { _current.GroundFloraIncludes = value; OnPropertyChanged(); } }
        public int GroundFloraIncludesId { get => _current.GroundFloraIncludesId; set { _current.GroundFloraIncludesId = value; OnPropertyChanged(); } }
        public bool PureBlWoodland { get => _current.PureBlWoodland; set { _current.PureBlWoodland = value; OnPropertyChanged(); } }
        public int PureBlWoodlandId { get => _current.PureBlWoodlandId; set { _current.PureBlWoodlandId = value; OnPropertyChanged(); } }
        public bool LittleOrNoContinousArea { get => _current.LittleOrNoContinousArea; set { _current.LittleOrNoContinousArea = value; OnPropertyChanged(); } }
        public int LittleOrNoContinousAreaId { get => _current.LittleOrNoContinousAreaId; set { _current.LittleOrNoContinousAreaId = value; OnPropertyChanged(); } }
        public bool WetThroughSummerMonths { get => _current.WetThroughSummerMonths; set { _current.WetThroughSummerMonths = value; OnPropertyChanged(); } }
        public int WetThroughSummerMonthsId { get => _current.WetThroughSummerMonthsId; set { _current.WetThroughSummerMonthsId = value; OnPropertyChanged(); } }
        public bool WoodlandCreationSite { get => _current.WoodlandCreationSite; set { _current.WoodlandCreationSite = value; OnPropertyChanged(); } }
        public int WoodlandCreationSiteId { get => _current.WoodlandCreationSiteId; set { _current.WoodlandCreationSiteId = value; OnPropertyChanged(); } }
        public bool HousingAdjoiningSite { get => _current.HousingAdjoiningSite; set { _current.HousingAdjoiningSite = value; OnPropertyChanged(); } }
        public int HousingAdjoiningSiteId { get => _current.HousingAdjoiningSiteId; set { _current.HousingAdjoiningSiteId = value; OnPropertyChanged(); } }
        public bool Houses25M { get => _current.Houses25M; set { _current.Houses25M = value; OnPropertyChanged(); } }
        public int Houses25MId { get => _current.Houses25MId; set { _current.Houses25MId = value; OnPropertyChanged(); } }
        public bool NoHousing { get => _current.NoHousing; set { _current.NoHousing = value; OnPropertyChanged(); } }
        public int NoHousingId { get => _current.NoHousingId; set { _current.NoHousingId = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public FireRiskCollectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.OneSigRiskType = this.OneSigRiskType;
            returnVal.OneSigRiskTypeId = this.OneSigRiskTypeId;
            returnVal.OneSigRiskFiveYears = this.OneSigRiskFiveYears;
            returnVal.OneSigRiskFiveYearsId = this.OneSigRiskFiveYearsId;
            returnVal.NoSigInFiveYears = this.NoSigInFiveYears;
            returnVal.NoSigInFiveYearsId = this.NoSigInFiveYearsId;
            returnVal.NewCampFiresAnnually = this.NewCampFiresAnnually;
            returnVal.NewCampFiresAnnuallyId = this.NewCampFiresAnnuallyId;
            returnVal.HistoryOfAccidentalFires = this.HistoryOfAccidentalFires;
            returnVal.HistoryOfAccidentalFiresId = this.HistoryOfAccidentalFiresId;
            returnVal.CampFiresOccasionally = this.CampFiresOccasionally;
            returnVal.CampFiresOccasionallyId = this.CampFiresOccasionallyId;
            returnVal.HistoryAccidentalFires = this.HistoryAccidentalFires;
            returnVal.HistoryAccidentalFiresId = this.HistoryAccidentalFiresId;
            returnVal.NoHistoryOfAccidentalFires = this.NoHistoryOfAccidentalFires;
            returnVal.NoHistoryOfAccidentalFiresId = this.NoHistoryOfAccidentalFiresId;
            returnVal.SiteContainsConiferBlocks25 = this.SiteContainsConiferBlocks25;
            returnVal.SiteContainsConiferBlocks25Id = this.SiteContainsConiferBlocks25Id;
            returnVal.SiteContainsHeathland = this.SiteContainsHeathland;
            returnVal.SiteContainsHeathlandId = this.SiteContainsHeathlandId;
            returnVal.SiteContainsBrash = this.SiteContainsBrash;
            returnVal.SiteContainsBrashId = this.SiteContainsBrashId;
            returnVal.SiteSoilsArePeat = this.SiteSoilsArePeat;
            returnVal.SiteSoilsArePeatId = this.SiteSoilsArePeatId;
            returnVal.SiteContainsMixedConifer = this.SiteContainsMixedConifer;
            returnVal.SiteContainsMixedConiferId = this.SiteContainsMixedConiferId;
            returnVal.SiteContainsSomeContinous = this.SiteContainsSomeContinous;
            returnVal.SiteContainsSomeContinousId = this.SiteContainsSomeContinousId;
            returnVal.GroundFloraIncludes = this.GroundFloraIncludes;
            returnVal.GroundFloraIncludesId = this.GroundFloraIncludesId;
            returnVal.PureBlWoodland = this.PureBlWoodland;
            returnVal.PureBlWoodlandId = this.PureBlWoodlandId;
            returnVal.LittleOrNoContinousArea = this.LittleOrNoContinousArea;
            returnVal.LittleOrNoContinousAreaId = this.LittleOrNoContinousAreaId;
            returnVal.WetThroughSummerMonths = this.WetThroughSummerMonths;
            returnVal.WetThroughSummerMonthsId = this.WetThroughSummerMonthsId;
            returnVal.WoodlandCreationSite = this.WoodlandCreationSite;
            returnVal.WoodlandCreationSiteId = this.WoodlandCreationSiteId;
            returnVal.HousingAdjoiningSite = this.HousingAdjoiningSite;
            returnVal.HousingAdjoiningSiteId = this.HousingAdjoiningSiteId;
            returnVal.Houses25M = this.Houses25M;
            returnVal.Houses25MId = this.Houses25MId;
            returnVal.NoHousing = this.NoHousing;
            returnVal.NoHousingId = this.NoHousingId;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (FireRiskCollectionEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(FireRiskCollectionDto test)
        {
            _original.OneSigRiskType = test.OneSigRiskType;
            _current.OneSigRiskType = test.OneSigRiskType;
            _original.OneSigRiskTypeId = test.OneSigRiskTypeId;
            _current.OneSigRiskTypeId = test.OneSigRiskTypeId;
            _original.OneSigRiskFiveYears = test.OneSigRiskFiveYears;
            _current.OneSigRiskFiveYears = test.OneSigRiskFiveYears;
            _original.OneSigRiskFiveYearsId = test.OneSigRiskFiveYearsId;
            _current.OneSigRiskFiveYearsId = test.OneSigRiskFiveYearsId;
            _original.NoSigInFiveYears = test.NoSigInFiveYears;
            _current.NoSigInFiveYears = test.NoSigInFiveYears;
            _original.NoSigInFiveYearsId = test.NoSigInFiveYearsId;
            _current.NoSigInFiveYearsId = test.NoSigInFiveYearsId;
            _original.NewCampFiresAnnually = test.NewCampFiresAnnually;
            _current.NewCampFiresAnnually = test.NewCampFiresAnnually;
            _original.NewCampFiresAnnuallyId = test.NewCampFiresAnnuallyId;
            _current.NewCampFiresAnnuallyId = test.NewCampFiresAnnuallyId;
            _original.HistoryOfAccidentalFires = test.HistoryOfAccidentalFires;
            _current.HistoryOfAccidentalFires = test.HistoryOfAccidentalFires;
            _original.HistoryOfAccidentalFiresId = test.HistoryOfAccidentalFiresId;
            _current.HistoryOfAccidentalFiresId = test.HistoryOfAccidentalFiresId;
            _original.CampFiresOccasionally = test.CampFiresOccasionally;
            _current.CampFiresOccasionally = test.CampFiresOccasionally;
            _original.CampFiresOccasionallyId = test.CampFiresOccasionallyId;
            _current.CampFiresOccasionallyId = test.CampFiresOccasionallyId;
            _original.HistoryAccidentalFires = test.HistoryAccidentalFires;
            _current.HistoryAccidentalFires = test.HistoryAccidentalFires;
            _original.HistoryAccidentalFiresId = test.HistoryAccidentalFiresId;
            _current.HistoryAccidentalFiresId = test.HistoryAccidentalFiresId;
            _original.NoHistoryOfAccidentalFires = test.NoHistoryOfAccidentalFires;
            _current.NoHistoryOfAccidentalFires = test.NoHistoryOfAccidentalFires;
            _original.NoHistoryOfAccidentalFiresId = test.NoHistoryOfAccidentalFiresId;
            _current.NoHistoryOfAccidentalFiresId = test.NoHistoryOfAccidentalFiresId;
            _original.SiteContainsConiferBlocks25 = test.SiteContainsConiferBlocks25;
            _current.SiteContainsConiferBlocks25 = test.SiteContainsConiferBlocks25;
            _original.SiteContainsConiferBlocks25Id = test.SiteContainsConiferBlocks25Id;
            _current.SiteContainsConiferBlocks25Id = test.SiteContainsConiferBlocks25Id;
            _original.SiteContainsHeathland = test.SiteContainsHeathland;
            _current.SiteContainsHeathland = test.SiteContainsHeathland;
            _original.SiteContainsHeathlandId = test.SiteContainsHeathlandId;
            _current.SiteContainsHeathlandId = test.SiteContainsHeathlandId;
            _original.SiteContainsBrash = test.SiteContainsBrash;
            _current.SiteContainsBrash = test.SiteContainsBrash;
            _original.SiteContainsBrashId = test.SiteContainsBrashId;
            _current.SiteContainsBrashId = test.SiteContainsBrashId;
            _original.SiteSoilsArePeat = test.SiteSoilsArePeat;
            _current.SiteSoilsArePeat = test.SiteSoilsArePeat;
            _original.SiteSoilsArePeatId = test.SiteSoilsArePeatId;
            _current.SiteSoilsArePeatId = test.SiteSoilsArePeatId;
            _original.SiteContainsMixedConifer = test.SiteContainsMixedConifer;
            _current.SiteContainsMixedConifer = test.SiteContainsMixedConifer;
            _original.SiteContainsMixedConiferId = test.SiteContainsMixedConiferId;
            _current.SiteContainsMixedConiferId = test.SiteContainsMixedConiferId;
            _original.SiteContainsSomeContinous = test.SiteContainsSomeContinous;
            _current.SiteContainsSomeContinous = test.SiteContainsSomeContinous;
            _original.SiteContainsSomeContinousId = test.SiteContainsSomeContinousId;
            _current.SiteContainsSomeContinousId = test.SiteContainsSomeContinousId;
            _original.GroundFloraIncludes = test.GroundFloraIncludes;
            _current.GroundFloraIncludes = test.GroundFloraIncludes;
            _original.GroundFloraIncludesId = test.GroundFloraIncludesId;
            _current.GroundFloraIncludesId = test.GroundFloraIncludesId;
            _original.PureBlWoodland = test.PureBlWoodland;
            _current.PureBlWoodland = test.PureBlWoodland;
            _original.PureBlWoodlandId = test.PureBlWoodlandId;
            _current.PureBlWoodlandId = test.PureBlWoodlandId;
            _original.LittleOrNoContinousArea = test.LittleOrNoContinousArea;
            _current.LittleOrNoContinousArea = test.LittleOrNoContinousArea;
            _original.LittleOrNoContinousAreaId = test.LittleOrNoContinousAreaId;
            _current.LittleOrNoContinousAreaId = test.LittleOrNoContinousAreaId;
            _original.WetThroughSummerMonths = test.WetThroughSummerMonths;
            _current.WetThroughSummerMonths = test.WetThroughSummerMonths;
            _original.WetThroughSummerMonthsId = test.WetThroughSummerMonthsId;
            _current.WetThroughSummerMonthsId = test.WetThroughSummerMonthsId;
            _original.WoodlandCreationSite = test.WoodlandCreationSite;
            _current.WoodlandCreationSite = test.WoodlandCreationSite;
            _original.WoodlandCreationSiteId = test.WoodlandCreationSiteId;
            _current.WoodlandCreationSiteId = test.WoodlandCreationSiteId;
            _original.HousingAdjoiningSite = test.HousingAdjoiningSite;
            _current.HousingAdjoiningSite = test.HousingAdjoiningSite;
            _original.HousingAdjoiningSiteId = test.HousingAdjoiningSiteId;
            _current.HousingAdjoiningSiteId = test.HousingAdjoiningSiteId;
            _original.Houses25M = test.Houses25M;
            _current.Houses25M = test.Houses25M;
            _original.Houses25MId = test.Houses25MId;
            _current.Houses25MId = test.Houses25MId;
            _original.NoHousing = test.NoHousing;
            _current.NoHousing = test.NoHousing;
            _original.NoHousingId = test.NoHousingId;
            _current.NoHousingId = test.NoHousingId;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<FireRiskCollectionEditList> MakeCollection(List<FireRiskCollectionDto> records)
        {

            var newData = new ExtRangeCollection<FireRiskCollectionEditList>();

            foreach (var rec in records)
            {
                var e = new FireRiskCollectionEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}