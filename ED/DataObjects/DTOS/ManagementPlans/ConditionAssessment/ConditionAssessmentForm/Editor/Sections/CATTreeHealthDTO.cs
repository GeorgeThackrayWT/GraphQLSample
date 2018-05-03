using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATTreeHealthDTO : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Notifiablepestordisease { get; set; }

        public CATPlotObj Otherdiseaseorpest { get; set; }
        public CATTreeHealthDTO Clone()
        {
            return new CATTreeHealthDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Notifiablepestordisease = this.Notifiablepestordisease,
                Otherdiseaseorpest = this.Otherdiseaseorpest,
            };
        }//endofclonemethods
    }

    public class CATTreeHealthDTOEdit : PropertyBase<CATTreeHealthDTOEdit>, IDuplicate
    {

        private CATTreeHealthDTO _dto;


        public CATTreeHealthDTOEdit()
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

        public Property<CATPlotObj> Notifiablepestordisease { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Otherdiseaseorpest { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public CATTreeHealthDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Notifiablepestordisease = Notifiablepestordisease.Value;
            returnVal.Otherdiseaseorpest = Otherdiseaseorpest.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATTreeHealthDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATTreeHealthDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Notifiablepestordisease = Property<CATPlotObj>.Make(test.Notifiablepestordisease,Notifiablepestordisease);
            this.Otherdiseaseorpest = Property<CATPlotObj>.Make(test.Otherdiseaseorpest,Otherdiseaseorpest);
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
            Notifiablepestordisease.Revert();
            Otherdiseaseorpest.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATTreeHealthDTOEdit> MakeCollection(List<CATTreeHealthDTO> records)
        {

            var newData = new ExtRangeCollection<CATTreeHealthDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATTreeHealthDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATTreeHealthDTOEditList : ListObj<CATTreeHealthDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATTreeHealthDTO _dto;


        public CATTreeHealthDTOEditList()
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

        public CATPlotObj Notifiablepestordisease { get => _current.Notifiablepestordisease; set { _current.Notifiablepestordisease = value; OnPropertyChanged(); } }

        public CATPlotObj Otherdiseaseorpest { get => _current.Otherdiseaseorpest; set { _current.Otherdiseaseorpest = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public CATTreeHealthDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Notifiablepestordisease = this.Notifiablepestordisease;
            returnVal.Otherdiseaseorpest = this.Otherdiseaseorpest;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATTreeHealthDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATTreeHealthDTO test)
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
            _original.Notifiablepestordisease = test.Notifiablepestordisease;
            _current.Notifiablepestordisease = test.Notifiablepestordisease;
            _original.Otherdiseaseorpest = test.Otherdiseaseorpest;
            _current.Otherdiseaseorpest = test.Otherdiseaseorpest;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATTreeHealthDTOEditList> MakeCollection(List<CATTreeHealthDTO> records)
        {

            var newData = new ExtRangeCollection<CATTreeHealthDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATTreeHealthDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}