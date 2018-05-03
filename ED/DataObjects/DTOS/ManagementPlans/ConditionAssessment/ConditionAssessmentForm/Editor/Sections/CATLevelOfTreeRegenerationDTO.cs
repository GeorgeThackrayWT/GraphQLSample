using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATLevelOfTreeRegenerationDTO : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj SeedlingsLessTen { get; set; }

        public CATPlotObj SeedlingsTenHundred { get; set; }

        public CATPlotObj SeedlingsGreaterHundred { get; set; }

        public CATPlotObj CoppiceRegrowthOrSuckering { get; set; }
        public CATLevelOfTreeRegenerationDTO Clone()
        {
            return new CATLevelOfTreeRegenerationDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                SeedlingsLessTen = this.SeedlingsLessTen,
                SeedlingsTenHundred = this.SeedlingsTenHundred,
                SeedlingsGreaterHundred = this.SeedlingsGreaterHundred,
                CoppiceRegrowthOrSuckering = this.CoppiceRegrowthOrSuckering,
            };
        }//endofclonemethods
    }

    public class CATLevelOfTreeRegenerationDTOEdit : PropertyBase<CATLevelOfTreeRegenerationDTOEdit>, IDuplicate
    {

        private CATLevelOfTreeRegenerationDTO _dto;


        public CATLevelOfTreeRegenerationDTOEdit()
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

        public Property<CATPlotObj> SeedlingsLessTen { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> SeedlingsTenHundred { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> SeedlingsGreaterHundred { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> CoppiceRegrowthOrSuckering { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public CATLevelOfTreeRegenerationDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.SeedlingsLessTen = SeedlingsLessTen.Value;
            returnVal.SeedlingsTenHundred = SeedlingsTenHundred.Value;
            returnVal.SeedlingsGreaterHundred = SeedlingsGreaterHundred.Value;
            returnVal.CoppiceRegrowthOrSuckering = CoppiceRegrowthOrSuckering.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATLevelOfTreeRegenerationDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATLevelOfTreeRegenerationDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.SeedlingsLessTen = Property<CATPlotObj>.Make(test.SeedlingsLessTen,SeedlingsLessTen);
            this.SeedlingsTenHundred = Property<CATPlotObj>.Make(test.SeedlingsTenHundred,SeedlingsTenHundred);
            this.SeedlingsGreaterHundred = Property<CATPlotObj>.Make(test.SeedlingsGreaterHundred,SeedlingsGreaterHundred);
            this.CoppiceRegrowthOrSuckering = Property<CATPlotObj>.Make(test.CoppiceRegrowthOrSuckering,CoppiceRegrowthOrSuckering);
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
            SeedlingsLessTen.Revert();
            SeedlingsTenHundred.Revert();
            SeedlingsGreaterHundred.Revert();
            CoppiceRegrowthOrSuckering.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATLevelOfTreeRegenerationDTOEdit> MakeCollection(List<CATLevelOfTreeRegenerationDTO> records)
        {

            var newData = new ExtRangeCollection<CATLevelOfTreeRegenerationDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATLevelOfTreeRegenerationDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATLevelOfTreeRegenerationDTOEditList : ListObj<CATLevelOfTreeRegenerationDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private CATLevelOfTreeRegenerationDTO _dto;

        public CATLevelOfTreeRegenerationDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor
   
        public string GeneralTarget { get => _current.GeneralTarget; set { _current.GeneralTarget = value; OnPropertyChanged(); } }

        public bool InterventionDesirable { get => _current.InterventionDesirable; set { _current.InterventionDesirable = value; OnPropertyChanged(); } }

        public bool InterventionAchievable { get => _current.InterventionAchievable; set { _current.InterventionAchievable = value; OnPropertyChanged(); } }

        public string Notes { get => _current.Notes; set { _current.Notes = value; OnPropertyChanged(); } }

        public CATPlotObj SeedlingsLessTen { get => _current.SeedlingsLessTen; set { _current.SeedlingsLessTen = value; OnPropertyChanged(); } }

        public CATPlotObj SeedlingsTenHundred { get => _current.SeedlingsTenHundred; set { _current.SeedlingsTenHundred = value; OnPropertyChanged(); } }

        public CATPlotObj SeedlingsGreaterHundred { get => _current.SeedlingsGreaterHundred; set { _current.SeedlingsGreaterHundred = value; OnPropertyChanged(); } }

        public CATPlotObj CoppiceRegrowthOrSuckering { get => _current.CoppiceRegrowthOrSuckering; set { _current.CoppiceRegrowthOrSuckering = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public CATLevelOfTreeRegenerationDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.SeedlingsLessTen = this.SeedlingsLessTen;
            returnVal.SeedlingsTenHundred = this.SeedlingsTenHundred;
            returnVal.SeedlingsGreaterHundred = this.SeedlingsGreaterHundred;
            returnVal.CoppiceRegrowthOrSuckering = this.CoppiceRegrowthOrSuckering;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATLevelOfTreeRegenerationDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATLevelOfTreeRegenerationDTO test)
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
            _original.SeedlingsLessTen = test.SeedlingsLessTen;
            _current.SeedlingsLessTen = test.SeedlingsLessTen;
            _original.SeedlingsTenHundred = test.SeedlingsTenHundred;
            _current.SeedlingsTenHundred = test.SeedlingsTenHundred;
            _original.SeedlingsGreaterHundred = test.SeedlingsGreaterHundred;
            _current.SeedlingsGreaterHundred = test.SeedlingsGreaterHundred;
            _original.CoppiceRegrowthOrSuckering = test.CoppiceRegrowthOrSuckering;
            _current.CoppiceRegrowthOrSuckering = test.CoppiceRegrowthOrSuckering;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATLevelOfTreeRegenerationDTOEditList> MakeCollection(List<CATLevelOfTreeRegenerationDTO> records)
        {

            var newData = new ExtRangeCollection<CATLevelOfTreeRegenerationDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATLevelOfTreeRegenerationDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}