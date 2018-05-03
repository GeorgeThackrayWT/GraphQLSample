using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.SafetyObjects.Editors
{
    public class HazardIncidentDto : BaseDto, IRecord
    {
        public int HazardId { get; set; }

        public string Description { get; set; }

        public DateTime? DateRecorded { get; set; }

        public HazardIncidentDto Clone()
        {
            return new HazardIncidentDto()
            {
                HazardId = this.HazardId,
                Description = this.Description,
                DateRecorded = this.DateRecorded,
            };
        }//endofclonemethods
    }

    public class HazardIncidentEdit : PropertyBase<HazardIncidentEdit>, IDuplicate
    {

        private HazardIncidentDto _dto;


        public HazardIncidentEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> HazardId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> DateRecorded { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };



        public int RecordId => Id.Value;


        public HazardIncidentDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.HazardId = HazardId.Value;
            returnVal.Description = Description.Value;
            returnVal.DateRecorded = DateRecorded.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardIncidentEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardIncidentDto test)
        {
            this.HazardId = Property<int>.Make(test.HazardId);
            this.Description = Property<string>.Make(test.Description);
            this.DateRecorded = Property<DateTime?>.Make(test.DateRecorded);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            HazardId.Revert();
            Description.Revert();
            DateRecorded.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<HazardIncidentEdit> MakeCollection(List<HazardIncidentDto> records)
        {

            var newData = new ExtRangeCollection<HazardIncidentEdit>();

            foreach (var rec in records)
            {
                var e = new HazardIncidentEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class HazardIncidentEditList : ListObj<HazardIncidentDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private HazardIncidentDto _dto;


        public HazardIncidentEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int HazardId { get => _current.HazardId; set { _current.HazardId = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public DateTime? DateRecorded { get => _current.DateRecorded; set { _current.DateRecorded = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public HazardIncidentDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.HazardId = this.HazardId;
            returnVal.Description = this.Description;
            returnVal.DateRecorded = this.DateRecorded;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HazardIncidentEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HazardIncidentDto test)
        {
            _original.HazardId = test.HazardId;
            _current.HazardId = test.HazardId;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.DateRecorded = test.DateRecorded;
            _current.DateRecorded = test.DateRecorded;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<HazardIncidentEditList> MakeCollection(List<HazardIncidentDto> records)
        {

            var newData = new ExtRangeCollection<HazardIncidentEditList>();

            foreach (var rec in records)
            {
                var e = new HazardIncidentEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}