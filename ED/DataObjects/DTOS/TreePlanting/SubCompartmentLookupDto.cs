using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.TreePlanting
{
    public class SubCompartmentLookupDto : BaseDto, IRecord
    {
        public string Description { get; set; }

        public string Reference { get; set; }

        public double AreaInHectares { get; set; }
        public SubCompartmentLookupDto Clone()
        {
            return new SubCompartmentLookupDto()
            {
                Description = this.Description,
                Reference = this.Reference,
                AreaInHectares = this.AreaInHectares,
            };
        }//endofclonemethods
    }

    public class SubCompartmentLookupEdit : PropertyBase<SubCompartmentLookupEdit>, IDuplicate
    {

        private SubCompartmentLookupDto _dto;


        public SubCompartmentLookupEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Reference { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> AreaInHectares { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


        public int RecordId => Id.Value;


        public SubCompartmentLookupDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = Description.Value;
            returnVal.Reference = Reference.Value;
            returnVal.AreaInHectares = AreaInHectares.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SubCompartmentLookupEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SubCompartmentLookupDto test)
        {
            this.Description = Property<string>.Make(test.Description);
            this.Reference = Property<string>.Make(test.Reference);
            this.AreaInHectares = Property<double>.Make(test.AreaInHectares);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Description.Revert();
            Reference.Revert();
            AreaInHectares.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SubCompartmentLookupEdit> MakeCollection(List<SubCompartmentLookupDto> records)
        {

            var newData = new ExtRangeCollection<SubCompartmentLookupEdit>();

            foreach (var rec in records)
            {
                var e = new SubCompartmentLookupEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SubCompartmentLookupEditList : ListObj<SubCompartmentLookupDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private SubCompartmentLookupDto _dto;


        public SubCompartmentLookupEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public string Reference { get => _current.Reference; set { _current.Reference = value; OnPropertyChanged(); } }

        public double AreaInHectares { get => _current.AreaInHectares; set { _current.AreaInHectares = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public SubCompartmentLookupDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Description = this.Description;
            returnVal.Reference = this.Reference;
            returnVal.AreaInHectares = this.AreaInHectares;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SubCompartmentLookupEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SubCompartmentLookupDto test)
        {
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Reference = test.Reference;
            _current.Reference = test.Reference;
            _original.AreaInHectares = test.AreaInHectares;
            _current.AreaInHectares = test.AreaInHectares;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SubCompartmentLookupEditList> MakeCollection(List<SubCompartmentLookupDto> records)
        {

            var newData = new ExtRangeCollection<SubCompartmentLookupEditList>();

            foreach (var rec in records)
            {
                var e = new SubCompartmentLookupEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}