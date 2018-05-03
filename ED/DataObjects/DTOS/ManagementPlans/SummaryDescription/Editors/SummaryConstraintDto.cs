using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class SummaryConstraintDto : BaseDto, IRecord
    {

        public SummaryConstraintDto()
        {

        }

    //    public int ID { get; set; }

        public int TypeID { get; set; }

        public ComboBoxValue Type { get; set; }

        public string OtherDescription { get; set; }

        public bool Confidential { get; set; }

        public int SubCompartmentId { get; set; }

        public SummaryConstraintDto Clone()
        {
            return new SummaryConstraintDto()
            {
                Id = this.Id,
                TypeID = this.TypeID,
                Type = this.Type,
                OtherDescription = this.OtherDescription,
                Confidential = this.Confidential,
                SubCompartmentId = this.SubCompartmentId,
            };
        }//endofclonemethods
    }


    public class SummaryConstraintEdit : PropertyBase<SummaryConstraintEdit>, IDuplicate
    {
        private SummaryConstraintDto _dto;
        public SummaryConstraintEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

    //    public Property<int> ID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        
        public Property<int> TypeID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> Type { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<string> OtherDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Confidential { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> SubCompartmentId { get; set; } = new Property<int>() { Value = 0, Original = 0 };



        public int RecordId => Id.Value;


        public SummaryConstraintDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.TypeID = TypeID.Value;
            returnVal.Type = Type.Value;
            returnVal.OtherDescription = OtherDescription.Value;
            returnVal.Confidential = Confidential.Value;
            returnVal.SubCompartmentId = SubCompartmentId.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryConstraintEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryConstraintDto test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.TypeID = Property<int>.Make(test.TypeID,TypeID);
            this.Type = Property<ComboBoxValue>.Make(test.Type,Type);
            this.OtherDescription = Property<string>.Make(test.OtherDescription,OtherDescription);
            this.Confidential = Property<bool>.Make(test.Confidential,Confidential);
            this.SubCompartmentId = Property<int>.Make(test.SubCompartmentId,SubCompartmentId);
            SetPropChanged();

            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            TypeID.Revert();
            Type.Revert();
            OtherDescription.Revert();
            Confidential.Revert();
            SubCompartmentId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SummaryConstraintEdit> MakeCollection(List<SummaryConstraintDto> records)
        {

            var newData = new ExtRangeCollection<SummaryConstraintEdit>();

            foreach (var rec in records)
            {
                var e = new SummaryConstraintEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SummaryConstraintEditList : ListObj<SummaryConstraintDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private SummaryConstraintDto _dto;


        public SummaryConstraintEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

   //     public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public int TypeID { get => _current.TypeID; set { _current.TypeID = value; OnPropertyChanged(); } }

        public ComboBoxValue Type { get => _current.Type; set { _current.Type = value; OnPropertyChanged(); } }

        public string OtherDescription { get => _current.OtherDescription; set { _current.OtherDescription = value; OnPropertyChanged(); } }

        public bool Confidential { get => _current.Confidential; set { _current.Confidential = value; OnPropertyChanged(); } }

        public int SubCompartmentId { get => _current.SubCompartmentId; set { _current.SubCompartmentId = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public SummaryConstraintDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.TypeID = this.TypeID;
            returnVal.Type = this.Type;
            returnVal.OtherDescription = this.OtherDescription;
            returnVal.Confidential = this.Confidential;
            returnVal.SubCompartmentId = this.SubCompartmentId;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryConstraintEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryConstraintDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.TypeID = test.TypeID;
            _current.TypeID = test.TypeID;
            _original.Type = test.Type;
            _current.Type = test.Type;
            _original.OtherDescription = test.OtherDescription;
            _current.OtherDescription = test.OtherDescription;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.SubCompartmentId = test.SubCompartmentId;
            _current.SubCompartmentId = test.SubCompartmentId;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SummaryConstraintEditList> MakeCollection(List<SummaryConstraintDto> records)
        {

            var newData = new ExtRangeCollection<SummaryConstraintEditList>();

            foreach (var rec in records)
            {
                var e = new SummaryConstraintEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}