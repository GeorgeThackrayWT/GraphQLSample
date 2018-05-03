using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class SummaryDesignationDto : BaseDto, IRecord
    {
   
        public ComboBoxValue Description { get; set; }
        public SummaryDesignationDto Clone()
        {
            return new SummaryDesignationDto()
            {
                Id = this.Id,
                Description = this.Description,
            };
        }//endofclonemethods
    }

    public class SummaryDesignationEdit : PropertyBase<SummaryDesignationEdit>, IDuplicate
    {

        private SummaryDesignationDto _dto;


        public SummaryDesignationEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor
        
        public Property<ComboBoxValue> Description { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public SummaryDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.Description = Description.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryDesignationEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryDesignationDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.Description = Property<ComboBoxValue>.Make(test.Description,Description);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            Description.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SummaryDesignationEdit> MakeCollection(List<SummaryDesignationDto> records)
        {

            var newData = new ExtRangeCollection<SummaryDesignationEdit>();

            foreach (var rec in records)
            {
                var e = new SummaryDesignationEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SummaryDesignationEditList : ListObj<SummaryDesignationDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private SummaryDesignationDto _dto;


        public SummaryDesignationEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

      //  public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }
        public ComboBoxValue Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public SummaryDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.Description = this.Description;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryDesignationEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryDesignationDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.Description = test.Description;
            _current.Description = test.Description;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SummaryDesignationEditList> MakeCollection(List<SummaryDesignationDto> records)
        {

            var newData = new ExtRangeCollection<SummaryDesignationEditList>();

            foreach (var rec in records)
            {
                var e = new SummaryDesignationEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}