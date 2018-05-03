using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class PlantedByDto : BaseDto, IRecord
    {  
        public string Description { get; set; }
        public PlantedByDto Clone()
        {
            return new PlantedByDto()
            {
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class PlantedByEdit : PropertyBase<PlantedByEdit>, IDuplicate
    {

        private PlantedByDto _dto;


        public PlantedByEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public PlantedByDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = Description.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PlantedByEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PlantedByDto test)
        {
            this.Description = Property<string>.Make(test.Description);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PlantedByEdit> MakeCollection(List<PlantedByDto> records)
        {

            var newData = new ExtRangeCollection<PlantedByEdit>();

            foreach (var rec in records)
            {
                var e = new PlantedByEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PlantedByEditList : ListObj<PlantedByDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PlantedByDto _dto;


        public PlantedByEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PlantedByDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = this.Description;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PlantedByEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PlantedByDto test)
        {
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PlantedByEditList> MakeCollection(List<PlantedByDto> records)
        {

            var newData = new ExtRangeCollection<PlantedByEditList>();

            foreach (var rec in records)
            {
                var e = new PlantedByEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}