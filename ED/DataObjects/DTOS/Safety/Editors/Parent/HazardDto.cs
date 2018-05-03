using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class HazardDto : BaseDto, IRecord
    {
        public int ManagementUnitId { get; set; }

        public HazardTypeDtoLookup HazardType { get; set; }

        public HazardOwnershipDtoLookup Ownership { get; set; }

        public string MapRef { get; set; }

        public string GridReference { get; set; }

        public bool WholeSite { get; set; }

        public string Description { get; set; }

        public HazardDto Clone()
        {
            return new HazardDto()
            {
                ManagementUnitId = this.ManagementUnitId,
                MapRef = this.MapRef,
                GridReference = this.GridReference,
                WholeSite = this.WholeSite,
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class HazardEdit : PropertyBase<HazardEdit>, IDuplicate
    {

        private HazardDto _dto;


        public HazardEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<HazardTypeDtoLookup> HazardType { get; set; } = new Property<HazardTypeDtoLookup>()
        {
            Value = new HazardTypeDtoLookup(),
            Original = new HazardTypeDtoLookup()
        };

        public Property<HazardOwnershipDtoLookup> Ownership { get; set; } = new Property<HazardOwnershipDtoLookup>()
        {
            Value = new HazardOwnershipDtoLookup(),
            Original = new HazardOwnershipDtoLookup(),
        };

        public Property<string> MapRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> GridReference { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> WholeSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };



        public int RecordId => Id.Value;


        public HazardDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.MapRef = MapRef.Value;
            returnVal.GridReference = GridReference.Value;
            returnVal.WholeSite = WholeSite.Value;
            returnVal.Description = Description.Value;
            returnVal.HazardType = HazardType.Value;
            returnVal.Ownership = Ownership.Value;
            returnVal.Id = Id.Value;


            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardDto test)
        {
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId);
            this.MapRef = Property<string>.Make(test.MapRef);
            this.GridReference = Property<string>.Make(test.GridReference);
            this.WholeSite = Property<bool>.Make(test.WholeSite);
            this.Description = Property<string>.Make(test.Description);
            this.HazardType = Property<HazardTypeDtoLookup>.Make(test.HazardType);
            this.Ownership = Property<HazardOwnershipDtoLookup>.Make(test.Ownership);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitId.Revert();
            MapRef.Revert();
            GridReference.Revert();
            WholeSite.Revert();
            Description.Revert();

            HazardType.Revert();
            Ownership.Revert();

        }//endofResetChanges


        public static ExtRangeCollection<HazardEdit> MakeCollection(List<HazardDto> records)
        {

            var newData = new ExtRangeCollection<HazardEdit>();

            foreach (var rec in records)
            {
                var e = new HazardEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class HazardEditList : ListObj<HazardDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private HazardDto _dto;


        public HazardEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }

        public HazardTypeDtoLookup HazardType { get => _current.HazardType; set { _current.HazardType = value; OnPropertyChanged(); } }

        public HazardOwnershipDtoLookup Ownership { get => _current.Ownership; set { _current.Ownership = value; OnPropertyChanged(); } }

        public string MapRef { get => _current.MapRef; set { _current.MapRef = value; OnPropertyChanged(); } }

        public string GridReference { get => _current.GridReference; set { _current.GridReference = value; OnPropertyChanged(); } }

        public bool WholeSite { get => _current.WholeSite; set { _current.WholeSite = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public HazardDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.MapRef = this.MapRef;
            returnVal.GridReference = this.GridReference;
            returnVal.WholeSite = this.WholeSite;
            returnVal.Description = this.Description;

            returnVal.HazardType = this.HazardType;
            returnVal.Ownership = this.Ownership;

            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardDto test)
        {
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.MapRef = test.MapRef;
            _current.MapRef = test.MapRef;
            _original.GridReference = test.GridReference;
            _current.GridReference = test.GridReference;
            _original.WholeSite = test.WholeSite;
            _current.WholeSite = test.WholeSite;
            _original.Description = test.Description;
            _current.Description = test.Description;

            _original.HazardType = test.HazardType;
            _current.HazardType = test.HazardType;

            _original.Ownership = test.Ownership;
            _current.Ownership = test.Ownership;

            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<HazardEditList> MakeCollection(List<HazardDto> records)
        {

            var newData = new ExtRangeCollection<HazardEditList>();

            foreach (var rec in records)
            {
                var e = new HazardEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass
}