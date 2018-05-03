using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class TreePlantTerrainDto : BaseDto, IRecord
    {
        public string Description { get; set; }
        public TreePlantTerrainDto Clone()
        {
            return new TreePlantTerrainDto()
            {
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class TreePlantTerrainEdit : PropertyBase<TreePlantTerrainEdit>, IDuplicate
    {

        private TreePlantTerrainDto _dto;


        public TreePlantTerrainEdit()
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


        public TreePlantTerrainDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = Description.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantTerrainEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantTerrainDto test)
        {
            this.Description = Property<string>.Make(test.Description);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantTerrainEdit> MakeCollection(List<TreePlantTerrainDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantTerrainEdit>();

            foreach (var rec in records)
            {
                var e = new TreePlantTerrainEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class TreePlantTerrainEditList : ListObj<TreePlantTerrainDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TreePlantTerrainDto _dto;


        public TreePlantTerrainEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public TreePlantTerrainDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = this.Description;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantTerrainEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantTerrainDto test)
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


        public static ExtRangeCollection<TreePlantTerrainEditList> MakeCollection(List<TreePlantTerrainDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantTerrainEditList>();

            foreach (var rec in records)
            {
                var e = new TreePlantTerrainEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}