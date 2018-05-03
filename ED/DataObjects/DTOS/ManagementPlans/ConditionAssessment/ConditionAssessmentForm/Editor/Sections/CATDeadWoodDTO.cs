using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATDeadWoodDTO : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Standing { get; set; }

        public CATPlotObj Fallen { get; set; }

        public CATDeadWoodDTO Clone()
        {
            return new CATDeadWoodDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Standing = this.Standing,
                Fallen = this.Fallen,
            };
        }//endofclonemethods
    }

    public class CATDeadWoodDTOEdit : PropertyBase<CATDeadWoodDTOEdit>, IDuplicate
    {
        private CATDeadWoodDTO _dto;

        public CATDeadWoodDTOEdit()
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

        public Property<CATPlotObj> Standing { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Fallen { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public int RecordId => Id.Value;

        public CATDeadWoodDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Standing = Standing.Value;
            returnVal.Fallen = Fallen.Value;
            return returnVal;
        }//ConvertToDto

        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATDeadWoodDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATDeadWoodDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Standing = Property<CATPlotObj>.Make(test.Standing,Standing);
            this.Fallen = Property<CATPlotObj>.Make(test.Fallen,Fallen);
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
            Standing.Revert();
            Fallen.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATDeadWoodDTOEdit> MakeCollection(List<CATDeadWoodDTO> records)
        {

            var newData = new ExtRangeCollection<CATDeadWoodDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATDeadWoodDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATDeadWoodDTOEditList : ListObj<CATDeadWoodDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATDeadWoodDTO _dto;


        public CATDeadWoodDTOEditList()
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

        public CATPlotObj Standing { get => _current.Standing; set { _current.Standing = value; OnPropertyChanged(); } }

        public CATPlotObj Fallen { get => _current.Fallen; set { _current.Fallen = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public CATDeadWoodDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Standing = this.Standing;
            returnVal.Fallen = this.Fallen;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATDeadWoodDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATDeadWoodDTO test)
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
            _original.Standing = test.Standing;
            _current.Standing = test.Standing;
            _original.Fallen = test.Fallen;
            _current.Fallen = test.Fallen;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATDeadWoodDTOEditList> MakeCollection(List<CATDeadWoodDTO> records)
        {

            var newData = new ExtRangeCollection<CATDeadWoodDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATDeadWoodDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}