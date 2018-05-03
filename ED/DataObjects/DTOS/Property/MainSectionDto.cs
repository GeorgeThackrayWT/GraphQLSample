using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class MainSectionDto : BaseDto, IRecord
    {
        public string CostCentre { get; set; }
        public string WoodNo { get; set; }
        public int Region { get; set; }
        public string SiteName { get; set; }
        public string Location { get; set; }
        public int LPM { get; set; }
        public string GridReference { get; set; }
        public int ManagedBy { get; set; }
        public int Manager { get; set; }
        public int County { get; set; }
        public int AcquisitionTypeId { get; set; }
        public double LandHa { get; set; }
        public double WoodHa { get; set; }
        public double GISHa { get; set; }

        public double LandAcres { get; set; }
        public double WoodAcres { get; set; }
        public double GISAcres { get; set; }

        public int ApplicationId { get; set; }
        public bool SetAsMainAcquisitionUnit { get; set; }
        public string PostCode { get; set; }

        public MainSectionDto Clone()
        {
            return new MainSectionDto()
            {
                CostCentre = this.CostCentre,
                WoodNo = this.WoodNo,
                Region = this.Region,
                SiteName = this.SiteName,
                Location = this.Location,
                LPM = this.LPM,
                GridReference = this.GridReference,
                ManagedBy = this.ManagedBy,
                Manager = this.Manager,
                County = this.County,
                AcquisitionTypeId = this.AcquisitionTypeId,
                LandHa = this.LandHa,
                WoodHa = this.WoodHa,
                GISHa = this.GISHa,
                LandAcres = this.LandAcres,
                WoodAcres = this.WoodAcres,
                GISAcres = this.GISAcres,
                ApplicationId = this.ApplicationId,
                SetAsMainAcquisitionUnit = this.SetAsMainAcquisitionUnit,
                PostCode = this.PostCode,
            };
        }//endofclonemethods
    }


    public class MainSectionEdit : PropertyBase<MainSectionEdit>, IDuplicate
    {

        private MainSectionDto _dto;


        public MainSectionEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> CostCentre { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> WoodNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> Region { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> SiteName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Location { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> LPM { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> GridReference { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<int> ManagedBy { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> Manager { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> County { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> AcquisitionTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<double> LandHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<double> WoodHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<double> GISHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> LandAcres { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<double> WoodAcres { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<double> GISAcres { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> ApplicationId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> SetAsMainAcquisitionUnit { get; set; } = new Property<bool>() { Value = false, Original = false };
        public Property<string> PostCode { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public MainSectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.CostCentre = CostCentre.Value;
            returnVal.WoodNo = WoodNo.Value;
            returnVal.Region = Region.Value;
            returnVal.SiteName = SiteName.Value;
            returnVal.Location = Location.Value;
            returnVal.LPM = LPM.Value;
            returnVal.GridReference = GridReference.Value;
            returnVal.ManagedBy = ManagedBy.Value;
            returnVal.Manager = Manager.Value;
            returnVal.County = County.Value;
            returnVal.AcquisitionTypeId = AcquisitionTypeId.Value;
            returnVal.LandHa = LandHa.Value;
            returnVal.WoodHa = WoodHa.Value;
            returnVal.GISHa = GISHa.Value;
            returnVal.LandAcres = LandAcres.Value;
            returnVal.WoodAcres = WoodAcres.Value;
            returnVal.GISAcres = GISAcres.Value;
            returnVal.ApplicationId = ApplicationId.Value;
            returnVal.SetAsMainAcquisitionUnit = SetAsMainAcquisitionUnit.Value;
            returnVal.PostCode = PostCode.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (MainSectionEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(MainSectionDto test)
        {
            this.CostCentre = Property<string>.Make(test.CostCentre);
            this.WoodNo = Property<string>.Make(test.WoodNo);
            this.Region = Property<int>.Make(test.Region);
            this.SiteName = Property<string>.Make(test.SiteName);
            this.Location = Property<string>.Make(test.Location);
            this.LPM = Property<int>.Make(test.LPM);
            this.GridReference = Property<string>.Make(test.GridReference);
            this.ManagedBy = Property<int>.Make(test.ManagedBy);
            this.Manager = Property<int>.Make(test.Manager);
            this.County = Property<int>.Make(test.County);
            this.AcquisitionTypeId = Property<int>.Make(test.AcquisitionTypeId);
            this.LandHa = Property<double>.Make(test.LandHa);
            this.WoodHa = Property<double>.Make(test.WoodHa);
            this.GISHa = Property<double>.Make(test.GISHa);
            this.LandAcres = Property<double>.Make(test.LandAcres);
            this.WoodAcres = Property<double>.Make(test.WoodAcres);
            this.GISAcres = Property<double>.Make(test.GISAcres);
            this.ApplicationId = Property<int>.Make(test.ApplicationId);
            this.SetAsMainAcquisitionUnit = Property<bool>.Make(test.SetAsMainAcquisitionUnit);
            this.PostCode = Property<string>.Make(test.PostCode);
            this.Id = Property<int>.Make(test.Id);

            SetPropChanged();
            
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            CostCentre.Revert();
            WoodNo.Revert();
            Region.Revert();
            SiteName.Revert();
            Location.Revert();
            LPM.Revert();
            GridReference.Revert();
            ManagedBy.Revert();
            Manager.Revert();
            County.Revert();
            AcquisitionTypeId.Revert();
            LandHa.Revert();
            WoodHa.Revert();
            GISHa.Revert();
            LandAcres.Revert();
            WoodAcres.Revert();
            GISAcres.Revert();
            ApplicationId.Revert();
            SetAsMainAcquisitionUnit.Revert();
            PostCode.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<MainSectionEdit> MakeCollection(List<MainSectionDto> records)
        {

            var newData = new ExtRangeCollection<MainSectionEdit>();

            foreach (var rec in records)
            {
                var e = new MainSectionEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class MainSectionEditList : ListObj<MainSectionDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private MainSectionDto _dto;


        public MainSectionEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string CostCentre { get => _current.CostCentre; set { _current.CostCentre = value; OnPropertyChanged(); } }
        public string WoodNo { get => _current.WoodNo; set { _current.WoodNo = value; OnPropertyChanged(); } }
        public int Region { get => _current.Region; set { _current.Region = value; OnPropertyChanged(); } }
        public string SiteName { get => _current.SiteName; set { _current.SiteName = value; OnPropertyChanged(); } }
        public string Location { get => _current.Location; set { _current.Location = value; OnPropertyChanged(); } }
        public int LPM { get => _current.LPM; set { _current.LPM = value; OnPropertyChanged(); } }
        public string GridReference { get => _current.GridReference; set { _current.GridReference = value; OnPropertyChanged(); } }
        public int ManagedBy { get => _current.ManagedBy; set { _current.ManagedBy = value; OnPropertyChanged(); } }
        public int Manager { get => _current.Manager; set { _current.Manager = value; OnPropertyChanged(); } }
        public int County { get => _current.County; set { _current.County = value; OnPropertyChanged(); } }
        public int AcquisitionTypeId { get => _current.AcquisitionTypeId; set { _current.AcquisitionTypeId = value; OnPropertyChanged(); } }
        public double LandHa { get => _current.LandHa; set { _current.LandHa = value; OnPropertyChanged(); } }
        public double WoodHa { get => _current.WoodHa; set { _current.WoodHa = value; OnPropertyChanged(); } }
        public double GISHa { get => _current.GISHa; set { _current.GISHa = value; OnPropertyChanged(); } }

        public double LandAcres { get => _current.LandAcres; set { _current.LandAcres = value; OnPropertyChanged(); } }
        public double WoodAcres { get => _current.WoodAcres; set { _current.WoodAcres = value; OnPropertyChanged(); } }
        public double GISAcres { get => _current.GISAcres; set { _current.GISAcres = value; OnPropertyChanged(); } }

        public int ApplicationId { get => _current.ApplicationId; set { _current.ApplicationId = value; OnPropertyChanged(); } }
        public bool SetAsMainAcquisitionUnit { get => _current.SetAsMainAcquisitionUnit; set { _current.SetAsMainAcquisitionUnit = value; OnPropertyChanged(); } }
        public string PostCode { get => _current.PostCode; set { _current.PostCode = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public MainSectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.CostCentre = this.CostCentre;
            returnVal.WoodNo = this.WoodNo;
            returnVal.Region = this.Region;
            returnVal.SiteName = this.SiteName;
            returnVal.Location = this.Location;
            returnVal.LPM = this.LPM;
            returnVal.GridReference = this.GridReference;
            returnVal.ManagedBy = this.ManagedBy;
            returnVal.Manager = this.Manager;
            returnVal.County = this.County;
            returnVal.AcquisitionTypeId = this.AcquisitionTypeId;
            returnVal.LandHa = this.LandHa;
            returnVal.WoodHa = this.WoodHa;
            returnVal.GISHa = this.GISHa;
            returnVal.LandAcres = this.LandAcres;
            returnVal.WoodAcres = this.WoodAcres;
            returnVal.GISAcres = this.GISAcres;
            returnVal.ApplicationId = this.ApplicationId;
            returnVal.SetAsMainAcquisitionUnit = this.SetAsMainAcquisitionUnit;
            returnVal.PostCode = this.PostCode;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (MainSectionEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(MainSectionDto test)
        {
            _original.CostCentre = test.CostCentre;
            _current.CostCentre = test.CostCentre;
            _original.WoodNo = test.WoodNo;
            _current.WoodNo = test.WoodNo;
            _original.Region = test.Region;
            _current.Region = test.Region;
            _original.SiteName = test.SiteName;
            _current.SiteName = test.SiteName;
            _original.Location = test.Location;
            _current.Location = test.Location;
            _original.LPM = test.LPM;
            _current.LPM = test.LPM;
            _original.GridReference = test.GridReference;
            _current.GridReference = test.GridReference;
            _original.ManagedBy = test.ManagedBy;
            _current.ManagedBy = test.ManagedBy;
            _original.Manager = test.Manager;
            _current.Manager = test.Manager;
            _original.County = test.County;
            _current.County = test.County;
            _original.AcquisitionTypeId = test.AcquisitionTypeId;
            _current.AcquisitionTypeId = test.AcquisitionTypeId;
            _original.LandHa = test.LandHa;
            _current.LandHa = test.LandHa;
            _original.WoodHa = test.WoodHa;
            _current.WoodHa = test.WoodHa;
            _original.GISHa = test.GISHa;
            _current.GISHa = test.GISHa;
            _original.LandAcres = test.LandAcres;
            _current.LandAcres = test.LandAcres;
            _original.WoodAcres = test.WoodAcres;
            _current.WoodAcres = test.WoodAcres;
            _original.GISAcres = test.GISAcres;
            _current.GISAcres = test.GISAcres;
            _original.ApplicationId = test.ApplicationId;
            _current.ApplicationId = test.ApplicationId;
            _original.SetAsMainAcquisitionUnit = test.SetAsMainAcquisitionUnit;
            _current.SetAsMainAcquisitionUnit = test.SetAsMainAcquisitionUnit;
            _original.PostCode = test.PostCode;
            _current.PostCode = test.PostCode;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<MainSectionEditList> MakeCollection(List<MainSectionDto> records)
        {

            var newData = new ExtRangeCollection<MainSectionEditList>();

            foreach (var rec in records)
            {
                var e = new MainSectionEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}