using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class InternalDesignationDto : BaseDto, IRecord
    {

        public int InternalDesignationTypeId { get; set; }

        public string Comments { get; set; }

        public int AcquisitionUnitID { get; set; }

        public InternalDesignationDto Clone()
        {
            return new InternalDesignationDto()
            {
                InternalDesignationTypeId = this.InternalDesignationTypeId,
                Comments = this.Comments,
                AcquisitionUnitID = this.AcquisitionUnitID,
            };
        }//endofclonemethods
    }

    public class InternalDesignationEdit : PropertyBase<InternalDesignationEdit>, IDuplicate
    {

        private InternalDesignationDto _dto;


        public InternalDesignationEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor


        public Property<int> InternalDesignationTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> AcquisitionUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };



        public int RecordId => Id.Value;


        public InternalDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();

            if (InternalDesignationTypeId == null) return new InternalDesignationDto();

            returnVal.InternalDesignationTypeId = InternalDesignationTypeId.Value;
            returnVal.Comments = Comments.Value;
            returnVal.AcquisitionUnitID = AcquisitionUnitID.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalDesignationEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalDesignationDto test)
        {
            this.InternalDesignationTypeId = Property<int>.Make(test.InternalDesignationTypeId);
            this.Comments = Property<string>.Make(test.Comments);
            this.AcquisitionUnitID = Property<int>.Make(test.AcquisitionUnitID);
            this.Id = Property<int>.Make(test.Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            InternalDesignationTypeId.Revert();
            Comments.Revert();
            AcquisitionUnitID.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<InternalDesignationEdit> MakeCollection(List<InternalDesignationDto> records)
        {

            var newData = new ExtRangeCollection<InternalDesignationEdit>();

            foreach (var rec in records)
            {
                var e = new InternalDesignationEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class InternalDesignationEditList : ListObj<InternalDesignationDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private InternalDesignationDto _dto;


        public InternalDesignationEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public int InternalDesignationTypeId { get => _current.InternalDesignationTypeId; set { _current.InternalDesignationTypeId = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }

        public int AcquisitionUnitID { get => _current.AcquisitionUnitID; set { _current.AcquisitionUnitID = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public InternalDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.InternalDesignationTypeId = this.InternalDesignationTypeId;
            returnVal.Comments = this.Comments;
            returnVal.AcquisitionUnitID = this.AcquisitionUnitID;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalDesignationEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalDesignationDto test)
        {
            _original.InternalDesignationTypeId = test.InternalDesignationTypeId;
            _current.InternalDesignationTypeId = test.InternalDesignationTypeId;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.AcquisitionUnitID = test.AcquisitionUnitID;
            _current.AcquisitionUnitID = test.AcquisitionUnitID;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<InternalDesignationEditList> MakeCollection(List<InternalDesignationDto> records)
        {

            var newData = new ExtRangeCollection<InternalDesignationEditList>();

            foreach (var rec in records)
            {
                var e = new InternalDesignationEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}