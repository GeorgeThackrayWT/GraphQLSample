using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class ManagementUnitShortDto : BaseDto, IRecord
    {
        public int ManagementUnitId { get; set; }

        public string Name { get; set; }

        public int WoodlandOfficerId { get; set; }

        public string WoodlandOfficer { get; set; }

        public int DeputyWoodlandOfficerId { get; set; }

        public string DeputyWoodlandOfficer { get; set; }

        public bool Selected { get; set; }

        public ManagementUnitShortDto Clone()
        {
            return new ManagementUnitShortDto()
            {
                ManagementUnitId = this.ManagementUnitId,
                Name = this.Name,
                WoodlandOfficerId = this.WoodlandOfficerId,
                WoodlandOfficer = this.WoodlandOfficer,
                DeputyWoodlandOfficerId = this.DeputyWoodlandOfficerId,
                DeputyWoodlandOfficer = this.DeputyWoodlandOfficer,
                Selected = this.Selected,
            };
        }//endofclonemethods
    }

    public class ManagementUnitShortEdit : PropertyBase<ManagementUnitShortEdit>, IDuplicate
    {

        private ManagementUnitShortDto _dto;


        public ManagementUnitShortEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Name { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> WoodlandOfficerId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> WoodlandOfficer { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> DeputyWoodlandOfficerId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> DeputyWoodlandOfficer { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Selected { get; set; } = new Property<bool>() { Value = false, Original = false };



        public int RecordId => Id.Value;


        public ManagementUnitShortDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.Name = Name.Value;
            returnVal.WoodlandOfficerId = WoodlandOfficerId.Value;
            returnVal.WoodlandOfficer = WoodlandOfficer.Value;
            returnVal.DeputyWoodlandOfficerId = DeputyWoodlandOfficerId.Value;
            returnVal.DeputyWoodlandOfficer = DeputyWoodlandOfficer.Value;
            returnVal.Selected = Selected.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ManagementUnitShortEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ManagementUnitShortDto test)
        {
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId);
            this.Name = Property<string>.Make(test.Name);
            this.WoodlandOfficerId = Property<int>.Make(test.WoodlandOfficerId);
            this.WoodlandOfficer = Property<string>.Make(test.WoodlandOfficer);
            this.DeputyWoodlandOfficerId = Property<int>.Make(test.DeputyWoodlandOfficerId);
            this.DeputyWoodlandOfficer = Property<string>.Make(test.DeputyWoodlandOfficer);
            this.Selected = Property<bool>.Make(test.Selected);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitId.Revert();
            Name.Revert();
            WoodlandOfficerId.Revert();
            WoodlandOfficer.Revert();
            DeputyWoodlandOfficerId.Revert();
            DeputyWoodlandOfficer.Revert();
            Selected.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ManagementUnitShortEdit> MakeCollection(List<ManagementUnitShortDto> records)
        {

            var newData = new ExtRangeCollection<ManagementUnitShortEdit>();

            foreach (var rec in records)
            {
                var e = new ManagementUnitShortEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class ManagementUnitShortEditList : ListObj<ManagementUnitShortDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ManagementUnitShortDto _dto;


        public ManagementUnitShortEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }

        public string Name { get => _current.Name; set { _current.Name = value; OnPropertyChanged(); } }

        public int WoodlandOfficerId { get => _current.WoodlandOfficerId; set { _current.WoodlandOfficerId = value; OnPropertyChanged(); } }

        public string WoodlandOfficer { get => _current.WoodlandOfficer; set { _current.WoodlandOfficer = value; OnPropertyChanged(); } }

        public int DeputyWoodlandOfficerId { get => _current.DeputyWoodlandOfficerId; set { _current.DeputyWoodlandOfficerId = value; OnPropertyChanged(); } }

        public string DeputyWoodlandOfficer { get => _current.DeputyWoodlandOfficer; set { _current.DeputyWoodlandOfficer = value; OnPropertyChanged(); } }

        public bool Selected { get => _current.Selected; set { _current.Selected = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public ManagementUnitShortDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.Name = this.Name;
            returnVal.WoodlandOfficerId = this.WoodlandOfficerId;
            returnVal.WoodlandOfficer = this.WoodlandOfficer;
            returnVal.DeputyWoodlandOfficerId = this.DeputyWoodlandOfficerId;
            returnVal.DeputyWoodlandOfficer = this.DeputyWoodlandOfficer;
            returnVal.Selected = this.Selected;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ManagementUnitShortEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ManagementUnitShortDto test)
        {
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Name = test.Name;
            _current.Name = test.Name;
            _original.WoodlandOfficerId = test.WoodlandOfficerId;
            _current.WoodlandOfficerId = test.WoodlandOfficerId;
            _original.WoodlandOfficer = test.WoodlandOfficer;
            _current.WoodlandOfficer = test.WoodlandOfficer;
            _original.DeputyWoodlandOfficerId = test.DeputyWoodlandOfficerId;
            _current.DeputyWoodlandOfficerId = test.DeputyWoodlandOfficerId;
            _original.DeputyWoodlandOfficer = test.DeputyWoodlandOfficer;
            _current.DeputyWoodlandOfficer = test.DeputyWoodlandOfficer;
            _original.Selected = test.Selected;
            _current.Selected = test.Selected;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;

            SetPropChanged();

        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ManagementUnitShortEditList> MakeCollection(List<ManagementUnitShortDto> records)
        {

            var newData = new ExtRangeCollection<ManagementUnitShortEditList>();

            foreach (var rec in records)
            {
                var e = new ManagementUnitShortEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}