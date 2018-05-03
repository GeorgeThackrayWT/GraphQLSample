using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class SummaryOverviewDto : BaseDto, IRecord
    {
        public string SummaryDescription { get; set; }

        public string LongTermPolicyConclusions { get; set; }

        public int ManagementUnitId { get; set; }
        public SummaryOverviewDto Clone()
        {
            return new SummaryOverviewDto()
            {
                SummaryDescription = this.SummaryDescription,
                LongTermPolicyConclusions = this.LongTermPolicyConclusions,
                ManagementUnitId = this.ManagementUnitId,
            };
        }//endofclonemethods
    }

    public class SummaryOverviewEdit : PropertyBase<SummaryOverviewEdit>, IDuplicate
    {

        private SummaryOverviewDto _dto;

        public SummaryOverviewEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> SummaryDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> LongTermPolicyConclusions { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };


        public int RecordId => Id.Value;


        public SummaryOverviewDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SummaryDescription = SummaryDescription.Value;
            returnVal.LongTermPolicyConclusions = LongTermPolicyConclusions.Value;
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryOverviewEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryOverviewDto test)
        {
            this.SummaryDescription = Property<string>.Make(test.SummaryDescription,SummaryDescription);
            this.LongTermPolicyConclusions = Property<string>.Make(test.LongTermPolicyConclusions,LongTermPolicyConclusions);
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId,ManagementUnitId);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            SummaryDescription.Revert();
            LongTermPolicyConclusions.Revert();
            ManagementUnitId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SummaryOverviewEdit> MakeCollection(List<SummaryOverviewDto> records)
        {

            var newData = new ExtRangeCollection<SummaryOverviewEdit>();

            foreach (var rec in records)
            {
                var e = new SummaryOverviewEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SummaryOverviewEditList : ListObj<SummaryOverviewDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private SummaryOverviewDto _dto;

        public SummaryOverviewEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public string SummaryDescription { get => _current.SummaryDescription; set { _current.SummaryDescription = value; OnPropertyChanged(); } }

        public string LongTermPolicyConclusions { get => _current.LongTermPolicyConclusions; set { _current.LongTermPolicyConclusions = value; OnPropertyChanged(); } }

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public SummaryOverviewDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SummaryDescription = this.SummaryDescription;
            returnVal.LongTermPolicyConclusions = this.LongTermPolicyConclusions;
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryOverviewEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryOverviewDto test)
        {
            _original.SummaryDescription = test.SummaryDescription;
            _current.SummaryDescription = test.SummaryDescription;
            _original.LongTermPolicyConclusions = test.LongTermPolicyConclusions;
            _current.LongTermPolicyConclusions = test.LongTermPolicyConclusions;
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SummaryOverviewEditList> MakeCollection(List<SummaryOverviewDto> records)
        {

            var newData = new ExtRangeCollection<SummaryOverviewEditList>();

            foreach (var rec in records)
            {
                var e = new SummaryOverviewEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}