using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATAnimalDamageDTO : BaseDto, IRecord
    {
        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Squirrels { get; set; }

        public CATPlotObj Deer { get; set; }

        public CATPlotObj Rabbits { get; set; }

        public CATPlotObj Other { get; set; }
        public CATAnimalDamageDTO Clone()
        {
            return new CATAnimalDamageDTO()
            {
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Squirrels = this.Squirrels,
                Deer = this.Deer,
                Rabbits = this.Rabbits,
                Other = this.Other,
            };
        }//endofclonemethods
    }

    public class CATAnimalDamageDTOEdit : PropertyBase<CATAnimalDamageDTOEdit>, IDuplicate
    {

        private CATAnimalDamageDTO _dto;


        public CATAnimalDamageDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<string> GeneralTarget { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> InterventionDesirable { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> InterventionAchievable { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> Notes { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<CATPlotObj> Squirrels { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Deer { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Rabbits { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Other { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public CATAnimalDamageDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Squirrels = Squirrels.Value;
            returnVal.Deer = Deer.Value;
            returnVal.Rabbits = Rabbits.Value;
            returnVal.Other = Other.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATAnimalDamageDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATAnimalDamageDTO test)
        {
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Squirrels = Property<CATPlotObj>.Make(test.Squirrels,Squirrels);
            this.Deer = Property<CATPlotObj>.Make(test.Deer,Deer);
            this.Rabbits = Property<CATPlotObj>.Make(test.Rabbits,Rabbits);
            this.Other = Property<CATPlotObj>.Make(test.Other,Other);
            this.Id = Property<int>.Make(test.Id,Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            GeneralTarget.Revert();
            InterventionDesirable.Revert();
            InterventionAchievable.Revert();
            Notes.Revert();
            Squirrels.Revert();
            Deer.Revert();
            Rabbits.Revert();
            Other.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATAnimalDamageDTOEdit> MakeCollection(List<CATAnimalDamageDTO> records)
        {

            var newData = new ExtRangeCollection<CATAnimalDamageDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATAnimalDamageDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATAnimalDamageDTOEditList : ListObj<CATAnimalDamageDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATAnimalDamageDTO _dto;


        public CATAnimalDamageDTOEditList()
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

        public CATPlotObj Squirrels { get => _current.Squirrels; set { _current.Squirrels = value; OnPropertyChanged(); } }

        public CATPlotObj Deer { get => _current.Deer; set { _current.Deer = value; OnPropertyChanged(); } }

        public CATPlotObj Rabbits { get => _current.Rabbits; set { _current.Rabbits = value; OnPropertyChanged(); } }

        public CATPlotObj Other { get => _current.Other; set { _current.Other = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public CATAnimalDamageDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Squirrels = this.Squirrels;
            returnVal.Deer = this.Deer;
            returnVal.Rabbits = this.Rabbits;
            returnVal.Other = this.Other;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATAnimalDamageDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATAnimalDamageDTO test)
        {
            _original.GeneralTarget = test.GeneralTarget;
            _current.GeneralTarget = test.GeneralTarget;
            _original.InterventionDesirable = test.InterventionDesirable;
            _current.InterventionDesirable = test.InterventionDesirable;
            _original.InterventionAchievable = test.InterventionAchievable;
            _current.InterventionAchievable = test.InterventionAchievable;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.Squirrels = test.Squirrels;
            _current.Squirrels = test.Squirrels;
            _original.Deer = test.Deer;
            _current.Deer = test.Deer;
            _original.Rabbits = test.Rabbits;
            _current.Rabbits = test.Rabbits;
            _original.Other = test.Other;
            _current.Other = test.Other;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            SetPropChanged();           
            _dto = test;   
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATAnimalDamageDTOEditList> MakeCollection(List<CATAnimalDamageDTO> records)
        {

            var newData = new ExtRangeCollection<CATAnimalDamageDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATAnimalDamageDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}