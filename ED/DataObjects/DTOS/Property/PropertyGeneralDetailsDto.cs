using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class PropertyGeneralDetailsDto : BaseDto, IRecord
    {

        public string AdminArea { get; set; }

        public int AdminAreaId { get; set; }

        public bool NonFSC { get; set; } //ack unit

        public int NonFSCType { get; set; } //ack unit

        public double NonFSCHa { get; set; } // ack unit

        public DateTime? NonFSCDate { get; set; } //ack unit

        public int County { get; set; } //ack unit

        public string Comments { get; set; } // unknown

        public string Parish { get; set; } //ack unit

        public bool DirectorySuppressed { get; set; }

        public bool PotSite { get; set; } // man unit

        public bool GeneralPotSite { get; set; }

        public bool AllowPOSO { get; set; } // man unit

        public bool Disposed { get; set; } // man unit

        public bool WCBudget { get; set; } // man unit

        public string LADistrict { get; set; }

        public PropertyGeneralDetailsDto Clone()
        {
            return new PropertyGeneralDetailsDto()
            {
                AdminArea = this.AdminArea,
                AdminAreaId = this.AdminAreaId,
                NonFSC = this.NonFSC,
                NonFSCType = this.NonFSCType,
                NonFSCHa = this.NonFSCHa,
                NonFSCDate = this.NonFSCDate,
                County = this.County,
                Comments = this.Comments,
                Parish = this.Parish,
                DirectorySuppressed = this.DirectorySuppressed,
                PotSite = this.PotSite,
                GeneralPotSite = this.GeneralPotSite,
                AllowPOSO = this.AllowPOSO,
                Disposed = this.Disposed,
                WCBudget = this.WCBudget,
                LADistrict = this.LADistrict,
            };
        }//endofclonemethods
    }

    public class PropertyGeneralDetailsEdit : PropertyBase<PropertyGeneralDetailsEdit>, IDuplicate
    {

        private PropertyGeneralDetailsDto _dto;
        private Property<DateTime?> _nonFSCDate = new Property<DateTime?>() { Value = null, Original = null };

        public PropertyGeneralDetailsEdit()
        {

            //this.PropertyChanged += (sender, args) =>
            //{
            //    if (args is ExtPropertyChangedEventArgs e)
            //        Debug.WriteLine("prop gen details changed: " + e.Tag + " "+ e.PropertyName);
            //};

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = false;
            IsValid = false;
        }//endofconstructor


        public Property<string> AdminArea { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> AdminAreaId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<bool> NonFSC { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> NonFSCType { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> NonFSCHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        //   public Property<DateTime?> NonFSCDate { get; set; } = new Property<DateTime?>() { Value = null, Original = null };

        public Property<DateTime?> NonFSCDate {
            get { return _nonFSCDate; }
            set
            {
                _nonFSCDate = value;
            }
        }

        public Property<int> County { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Parish { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> DirectorySuppressed { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> PotSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> GeneralPotSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> AllowPOSO { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Disposed { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> WCBudget { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> LADistrict { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public PropertyGeneralDetailsDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AdminArea = AdminArea.Value;
            returnVal.AdminAreaId = AdminAreaId.Value;
            returnVal.NonFSC = NonFSC.Value;
            returnVal.NonFSCType = NonFSCType.Value;
            returnVal.NonFSCHa = NonFSCHa.Value;
            returnVal.NonFSCDate = NonFSCDate.Value;
            returnVal.County = County.Value;
            returnVal.Comments = Comments.Value;
            returnVal.Parish = Parish.Value;
            returnVal.DirectorySuppressed = DirectorySuppressed.Value;
            returnVal.PotSite = PotSite.Value;
            returnVal.GeneralPotSite = GeneralPotSite.Value;
            returnVal.AllowPOSO = AllowPOSO.Value;
            returnVal.Disposed = Disposed.Value;
            returnVal.WCBudget = WCBudget.Value;
            returnVal.LADistrict = LADistrict.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyGeneralDetailsEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyGeneralDetailsDto test)
        {
            this.AdminArea = Property<string>.Make(test.AdminArea,AdminArea, "AdminArea");
            this.AdminAreaId = Property<int>.Make(test.AdminAreaId,AdminAreaId, "AdminAreaId");
            this.NonFSC = Property<bool>.Make(test.NonFSC,NonFSC, "NonFSC");
            this.NonFSCType = Property<int>.Make(test.NonFSCType,NonFSCType, "NonFSCType");
            this.NonFSCHa = Property<double>.Make(test.NonFSCHa,NonFSCHa, "NonFSCHa");
            this.NonFSCDate = Property<DateTime?>.Make(test.NonFSCDate,NonFSCDate, "NonFSCDate");
            this.County = Property<int>.Make(test.County,County, "County");
            this.Comments = Property<string>.Make(test.Comments,Comments, "Comments");
            this.Parish = Property<string>.Make(test.Parish,Parish, "Parish");
            this.DirectorySuppressed = Property<bool>.Make(test.DirectorySuppressed,DirectorySuppressed, "DirectorySuppressed");
            this.PotSite = Property<bool>.Make(test.PotSite,PotSite, "PotSite");
            this.GeneralPotSite = Property<bool>.Make(test.GeneralPotSite,GeneralPotSite, "GeneralPotSite");
            this.AllowPOSO = Property<bool>.Make(test.AllowPOSO,AllowPOSO, "AllowPOSO");
            this.Disposed = Property<bool>.Make(test.Disposed,Disposed, "Disposed");
            this.WCBudget = Property<bool>.Make(test.WCBudget,WCBudget, "WCBudget");
            this.LADistrict = Property<string>.Make(test.LADistrict,LADistrict, "LADistrict");
            this.Id = Property<int>.Make(test.Id,Id, "Id");
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AdminArea.Revert();
            AdminAreaId.Revert();
            NonFSC.Revert();
            NonFSCType.Revert();
            NonFSCHa.Revert();
            NonFSCDate.Revert();
            County.Revert();
            Comments.Revert();
            Parish.Revert();
            DirectorySuppressed.Revert();
            PotSite.Revert();
            GeneralPotSite.Revert();
            AllowPOSO.Revert();
            Disposed.Revert();
            WCBudget.Revert();
            LADistrict.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PropertyGeneralDetailsEdit> MakeCollection(List<PropertyGeneralDetailsDto> records)
        {

            var newData = new ExtRangeCollection<PropertyGeneralDetailsEdit>();

            foreach (var rec in records)
            {
                var e = new PropertyGeneralDetailsEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PropertyGeneralDetailsEditList : ListObj<PropertyGeneralDetailsDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PropertyGeneralDetailsDto _dto;


        public PropertyGeneralDetailsEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public string AdminArea { get => _current.AdminArea; set { _current.AdminArea = value; OnPropertyChanged(); } }

        public int AdminAreaId { get => _current.AdminAreaId; set { _current.AdminAreaId = value; OnPropertyChanged(); } }

        public bool NonFSC { get => _current.NonFSC; set { _current.NonFSC = value; OnPropertyChanged(); } }

        public int NonFSCType { get => _current.NonFSCType; set { _current.NonFSCType = value; OnPropertyChanged(); } }

        public double NonFSCHa { get => _current.NonFSCHa; set { _current.NonFSCHa = value; OnPropertyChanged(); } }

        public DateTime? NonFSCDate { get => _current.NonFSCDate; set { _current.NonFSCDate = value; OnPropertyChanged(); } }

        public int County { get => _current.County; set { _current.County = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }

        public string Parish { get => _current.Parish; set { _current.Parish = value; OnPropertyChanged(); } }

        public bool DirectorySuppressed { get => _current.DirectorySuppressed; set { _current.DirectorySuppressed = value; OnPropertyChanged(); } }

        public bool PotSite { get => _current.PotSite; set { _current.PotSite = value; OnPropertyChanged(); } }

        public bool GeneralPotSite { get => _current.GeneralPotSite; set { _current.GeneralPotSite = value; OnPropertyChanged(); } }

        public bool AllowPOSO { get => _current.AllowPOSO; set { _current.AllowPOSO = value; OnPropertyChanged(); } }

        public bool Disposed { get => _current.Disposed; set { _current.Disposed = value; OnPropertyChanged(); } }

        public bool WCBudget { get => _current.WCBudget; set { _current.WCBudget = value; OnPropertyChanged(); } }

        public string LADistrict { get => _current.LADistrict; set { _current.LADistrict = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public PropertyGeneralDetailsDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AdminArea = this.AdminArea;
            returnVal.AdminAreaId = this.AdminAreaId;
            returnVal.NonFSC = this.NonFSC;
            returnVal.NonFSCType = this.NonFSCType;
            returnVal.NonFSCHa = this.NonFSCHa;
            returnVal.NonFSCDate = this.NonFSCDate;
            returnVal.County = this.County;
            returnVal.Comments = this.Comments;
            returnVal.Parish = this.Parish;
            returnVal.DirectorySuppressed = this.DirectorySuppressed;
            returnVal.PotSite = this.PotSite;
            returnVal.GeneralPotSite = this.GeneralPotSite;
            returnVal.AllowPOSO = this.AllowPOSO;
            returnVal.Disposed = this.Disposed;
            returnVal.WCBudget = this.WCBudget;
            returnVal.LADistrict = this.LADistrict;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PropertyGeneralDetailsEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PropertyGeneralDetailsDto test)
        {
            _original.AdminArea = test.AdminArea;
            _current.AdminArea = test.AdminArea;
            _original.AdminAreaId = test.AdminAreaId;
            _current.AdminAreaId = test.AdminAreaId;
            _original.NonFSC = test.NonFSC;
            _current.NonFSC = test.NonFSC;
            _original.NonFSCType = test.NonFSCType;
            _current.NonFSCType = test.NonFSCType;
            _original.NonFSCHa = test.NonFSCHa;
            _current.NonFSCHa = test.NonFSCHa;
            _original.NonFSCDate = test.NonFSCDate;
            _current.NonFSCDate = test.NonFSCDate;
            _original.County = test.County;
            _current.County = test.County;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.Parish = test.Parish;
            _current.Parish = test.Parish;
            _original.DirectorySuppressed = test.DirectorySuppressed;
            _current.DirectorySuppressed = test.DirectorySuppressed;
            _original.PotSite = test.PotSite;
            _current.PotSite = test.PotSite;
            _original.GeneralPotSite = test.GeneralPotSite;
            _current.GeneralPotSite = test.GeneralPotSite;
            _original.AllowPOSO = test.AllowPOSO;
            _current.AllowPOSO = test.AllowPOSO;
            _original.Disposed = test.Disposed;
            _current.Disposed = test.Disposed;
            _original.WCBudget = test.WCBudget;
            _current.WCBudget = test.WCBudget;
            _original.LADistrict = test.LADistrict;
            _current.LADistrict = test.LADistrict;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PropertyGeneralDetailsEditList> MakeCollection(List<PropertyGeneralDetailsDto> records)
        {

            var newData = new ExtRangeCollection<PropertyGeneralDetailsEditList>();

            foreach (var rec in records)
            {
                var e = new PropertyGeneralDetailsEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass




}