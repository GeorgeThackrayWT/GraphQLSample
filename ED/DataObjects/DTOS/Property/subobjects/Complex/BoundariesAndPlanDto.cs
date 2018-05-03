using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class BoundariesAndPlanDto : BaseDto, IRecord
    {
        public string BoundaryDescription { get; set; }

        public string Section { get; set; }

        public string Description { get; set; }

        public bool Ownership { get; set; }

        public bool Responsibility { get; set; }

        public BoundariesAndPlanDto Clone()
        {
            return new BoundariesAndPlanDto()
            {
                BoundaryDescription = this.BoundaryDescription,
                Section = this.Section,
                Description = this.Description,
                Ownership = this.Ownership,
                Responsibility = this.Responsibility,
            };
        }//endofclonemethods
    }

    public class BoundariesAndPlanEdit : PropertyBase<BoundariesAndPlanEdit>, IDuplicate
    {

        private BoundariesAndPlanDto _dto;


        public BoundariesAndPlanEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> BoundaryDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Section { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Ownership { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Responsibility { get; set; } = new Property<bool>() { Value = false, Original = false };



        public int RecordId => Id.Value;


        public BoundariesAndPlanDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.BoundaryDescription = BoundaryDescription.Value;
            returnVal.Section = Section.Value;
            returnVal.Description = Description.Value;
            returnVal.Ownership = Ownership.Value;
            returnVal.Responsibility = Responsibility.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (BoundariesAndPlanEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(BoundariesAndPlanDto test)
        {
            this.BoundaryDescription = Property<string>.Make(test.BoundaryDescription,BoundaryDescription);
            this.Section = Property<string>.Make(test.Section,Section);
            this.Description = Property<string>.Make(test.Description,Description);
            this.Ownership = Property<bool>.Make(test.Ownership,Ownership);
            this.Responsibility = Property<bool>.Make(test.Responsibility,Responsibility);
            this.Id = Property<int>.Make(test.Id,Id);

            this.SetPropChanged();

            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            BoundaryDescription.Revert();
            Section.Revert();
            Description.Revert();
            Ownership.Revert();
            Responsibility.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<BoundariesAndPlanEdit> MakeCollection(List<BoundariesAndPlanDto> records)
        {

            var newData = new ExtRangeCollection<BoundariesAndPlanEdit>();

            foreach (var rec in records)
            {
                var e = new BoundariesAndPlanEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class BoundariesAndPlanEditList : ListObj<BoundariesAndPlanDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private BoundariesAndPlanDto _dto;


        public BoundariesAndPlanEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string BoundaryDescription { get => _current.BoundaryDescription; set { _current.BoundaryDescription = value; OnPropertyChanged(); } }

        public string Section { get => _current.Section; set { _current.Section = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public bool Ownership { get => _current.Ownership; set { _current.Ownership = value; OnPropertyChanged(); } }

        public bool Responsibility { get => _current.Responsibility; set { _current.Responsibility = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public BoundariesAndPlanDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.BoundaryDescription = this.BoundaryDescription;
            returnVal.Section = this.Section;
            returnVal.Description = this.Description;
            returnVal.Ownership = this.Ownership;
            returnVal.Responsibility = this.Responsibility;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (BoundariesAndPlanEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(BoundariesAndPlanDto test)
        {
            _original.BoundaryDescription = test.BoundaryDescription;
            _current.BoundaryDescription = test.BoundaryDescription;
            _original.Section = test.Section;
            _current.Section = test.Section;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Ownership = test.Ownership;
            _current.Ownership = test.Ownership;
            _original.Responsibility = test.Responsibility;
            _current.Responsibility = test.Responsibility;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<BoundariesAndPlanEditList> MakeCollection(List<BoundariesAndPlanDto> records)
        {

            var newData = new ExtRangeCollection<BoundariesAndPlanEditList>();

            foreach (var rec in records)
            {
                var e = new BoundariesAndPlanEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}