using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATTreeAgesDTO : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj VeteranPollardsAncientCoppiceStools { get; set; }

        public CATPlotObj OneTwoHundredYears { get; set; }

        public CATPlotObj FiftyHundredYears { get; set; }

        public CATPlotObj TwentyFiftyYears { get; set; }

        public CATPlotObj LessThanTwentyYears { get; set; }

        public CATTreeAgesDTO Clone()
        {
            return new CATTreeAgesDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                VeteranPollardsAncientCoppiceStools = this.VeteranPollardsAncientCoppiceStools,
                OneTwoHundredYears = this.OneTwoHundredYears,
                FiftyHundredYears = this.FiftyHundredYears,
                TwentyFiftyYears = this.TwentyFiftyYears,
                LessThanTwentyYears = this.LessThanTwentyYears,
            };
        }//endofclonemethods
    }

    public class CATTreeAgesDTOEdit : PropertyBase<CATTreeAgesDTOEdit>, IDuplicate
    {

        private CATTreeAgesDTO _dto;


        public CATTreeAgesDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> GeneralTarget { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> InterventionDesirable { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> InterventionAchievable { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> Notes { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<CATPlotObj> VeteranPollardsAncientCoppiceStools { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> OneTwoHundredYears { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> FiftyHundredYears { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> TwentyFiftyYears { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> LessThanTwentyYears { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };



        public int RecordId => Id.Value;


        public CATTreeAgesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.VeteranPollardsAncientCoppiceStools = VeteranPollardsAncientCoppiceStools.Value;
            returnVal.OneTwoHundredYears = OneTwoHundredYears.Value;
            returnVal.FiftyHundredYears = FiftyHundredYears.Value;
            returnVal.TwentyFiftyYears = TwentyFiftyYears.Value;
            returnVal.LessThanTwentyYears = LessThanTwentyYears.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATTreeAgesDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATTreeAgesDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.VeteranPollardsAncientCoppiceStools = Property<CATPlotObj>.Make(test.VeteranPollardsAncientCoppiceStools,VeteranPollardsAncientCoppiceStools);
            this.OneTwoHundredYears = Property<CATPlotObj>.Make(test.OneTwoHundredYears,OneTwoHundredYears);
            this.FiftyHundredYears = Property<CATPlotObj>.Make(test.FiftyHundredYears,FiftyHundredYears);
            this.TwentyFiftyYears = Property<CATPlotObj>.Make(test.TwentyFiftyYears,TwentyFiftyYears);
            this.LessThanTwentyYears = Property<CATPlotObj>.Make(test.LessThanTwentyYears,LessThanTwentyYears);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            GeneralTarget.Revert();
            InterventionDesirable.Revert();
            InterventionAchievable.Revert();
            Notes.Revert();
            VeteranPollardsAncientCoppiceStools.Revert();
            OneTwoHundredYears.Revert();
            FiftyHundredYears.Revert();
            TwentyFiftyYears.Revert();
            LessThanTwentyYears.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATTreeAgesDTOEdit> MakeCollection(List<CATTreeAgesDTO> records)
        {

            var newData = new ExtRangeCollection<CATTreeAgesDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATTreeAgesDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATTreeAgesDTOEditList : ListObj<CATTreeAgesDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATTreeAgesDTO _dto;


        public CATTreeAgesDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public string GeneralTarget { get => _current.GeneralTarget; set { _current.GeneralTarget = value; OnPropertyChanged(); } }

        public bool InterventionDesirable { get => _current.InterventionDesirable; set { _current.InterventionDesirable = value; OnPropertyChanged(); } }

        public bool InterventionAchievable { get => _current.InterventionAchievable; set { _current.InterventionAchievable = value; OnPropertyChanged(); } }

        public string Notes { get => _current.Notes; set { _current.Notes = value; OnPropertyChanged(); } }

        public CATPlotObj VeteranPollardsAncientCoppiceStools { get => _current.VeteranPollardsAncientCoppiceStools; set { _current.VeteranPollardsAncientCoppiceStools = value; OnPropertyChanged(); } }

        public CATPlotObj OneTwoHundredYears { get => _current.OneTwoHundredYears; set { _current.OneTwoHundredYears = value; OnPropertyChanged(); } }

        public CATPlotObj FiftyHundredYears { get => _current.FiftyHundredYears; set { _current.FiftyHundredYears = value; OnPropertyChanged(); } }

        public CATPlotObj TwentyFiftyYears { get => _current.TwentyFiftyYears; set { _current.TwentyFiftyYears = value; OnPropertyChanged(); } }

        public CATPlotObj LessThanTwentyYears { get => _current.LessThanTwentyYears; set { _current.LessThanTwentyYears = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public CATTreeAgesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.VeteranPollardsAncientCoppiceStools = this.VeteranPollardsAncientCoppiceStools;
            returnVal.OneTwoHundredYears = this.OneTwoHundredYears;
            returnVal.FiftyHundredYears = this.FiftyHundredYears;
            returnVal.TwentyFiftyYears = this.TwentyFiftyYears;
            returnVal.LessThanTwentyYears = this.LessThanTwentyYears;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATTreeAgesDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATTreeAgesDTO test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.GeneralTarget = test.GeneralTarget;
            _current.GeneralTarget = test.GeneralTarget;
            _original.InterventionDesirable = test.InterventionDesirable;
            _current.InterventionDesirable = test.InterventionDesirable;
            _original.InterventionAchievable = test.InterventionAchievable;
            _current.InterventionAchievable = test.InterventionAchievable;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.VeteranPollardsAncientCoppiceStools = test.VeteranPollardsAncientCoppiceStools;
            _current.VeteranPollardsAncientCoppiceStools = test.VeteranPollardsAncientCoppiceStools;
            _original.OneTwoHundredYears = test.OneTwoHundredYears;
            _current.OneTwoHundredYears = test.OneTwoHundredYears;
            _original.FiftyHundredYears = test.FiftyHundredYears;
            _current.FiftyHundredYears = test.FiftyHundredYears;
            _original.TwentyFiftyYears = test.TwentyFiftyYears;
            _current.TwentyFiftyYears = test.TwentyFiftyYears;
            _original.LessThanTwentyYears = test.LessThanTwentyYears;
            _current.LessThanTwentyYears = test.LessThanTwentyYears;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATTreeAgesDTOEditList> MakeCollection(List<CATTreeAgesDTO> records)
        {

            var newData = new ExtRangeCollection<CATTreeAgesDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATTreeAgesDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}