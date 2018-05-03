using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class PlantTypeDto : BaseDto, IRecord
    {
        public string Description { get; set; }
        public PlantTypeDto Clone()
        {
            return new PlantTypeDto()
            {
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class PlantTypeEdit : PropertyBase<PlantTypeEdit>, IDuplicate
    {

        private PlantTypeDto _dto;


        public PlantTypeEdit()
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


        public PlantTypeDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = Description.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PlantTypeEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PlantTypeDto test)
        {
            this.Description = Property<string>.Make(test.Description);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PlantTypeEdit> MakeCollection(List<PlantTypeDto> records)
        {

            var newData = new ExtRangeCollection<PlantTypeEdit>();

            foreach (var rec in records)
            {
                var e = new PlantTypeEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class PlantTypeEditList : ListObj<PlantTypeDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PlantTypeDto _dto;


        public PlantTypeEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public PlantTypeDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = this.Description;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PlantTypeEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PlantTypeDto test)
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


        public static ExtRangeCollection<PlantTypeEditList> MakeCollection(List<PlantTypeDto> records)
        {

            var newData = new ExtRangeCollection<PlantTypeEditList>();

            foreach (var rec in records)
            {
                var e = new PlantTypeEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}