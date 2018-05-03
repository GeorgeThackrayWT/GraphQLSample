using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class TreePlantAccessDto : BaseDto, IRecord
    {
        public string Description { get; set; }

        public TreePlantAccessDto Clone()
        {
            return new TreePlantAccessDto()
            {
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class TreePlantAccessEdit : PropertyBase<TreePlantAccessEdit>, IDuplicate
    {

        private TreePlantAccessDto _dto;


        public TreePlantAccessEdit()
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


        public TreePlantAccessDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = Description.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantAccessEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantAccessDto test)
        {
            this.Description = Property<string>.Make(test.Description);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantAccessEdit> MakeCollection(List<TreePlantAccessDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantAccessEdit>();

            foreach (var rec in records)
            {
                var e = new TreePlantAccessEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class TreePlantAccessEditList : ListObj<TreePlantAccessDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TreePlantAccessDto _dto;


        public TreePlantAccessEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public TreePlantAccessDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = this.Description;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantAccessEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantAccessDto test)
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


        public static ExtRangeCollection<TreePlantAccessEditList> MakeCollection(List<TreePlantAccessDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantAccessEditList>();

            foreach (var rec in records)
            {
                var e = new TreePlantAccessEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}