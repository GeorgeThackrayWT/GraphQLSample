using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATHumanImpactsDTO : BaseDto, IRecord
    {
        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Oneoffimpacts { get; set; }

        public CATPlotObj Continuousimpacts { get; set; }
        public CATHumanImpactsDTO Clone()
        {
            return new CATHumanImpactsDTO()
            {
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Oneoffimpacts = this.Oneoffimpacts,
                Continuousimpacts = this.Continuousimpacts,
            };
        }//endofclonemethods
    }

    public class CATHumanImpactsDTOEdit : PropertyBase<CATHumanImpactsDTOEdit>, IDuplicate
    {

        private CATHumanImpactsDTO _dto;


        public CATHumanImpactsDTOEdit()
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

        public Property<CATPlotObj> Oneoffimpacts { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Continuousimpacts { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public CATHumanImpactsDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Oneoffimpacts = Oneoffimpacts.Value;
            returnVal.Continuousimpacts = Continuousimpacts.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATHumanImpactsDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATHumanImpactsDTO test)
        {
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Oneoffimpacts = Property<CATPlotObj>.Make(test.Oneoffimpacts,Oneoffimpacts);
            this.Continuousimpacts = Property<CATPlotObj>.Make(test.Continuousimpacts,Continuousimpacts);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            GeneralTarget.Revert();
            InterventionDesirable.Revert();
            InterventionAchievable.Revert();
            Notes.Revert();
            Oneoffimpacts.Revert();
            Continuousimpacts.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATHumanImpactsDTOEdit> MakeCollection(List<CATHumanImpactsDTO> records)
        {

            var newData = new ExtRangeCollection<CATHumanImpactsDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATHumanImpactsDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATHumanImpactsDTOEditList : ListObj<CATHumanImpactsDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATHumanImpactsDTO _dto;


        public CATHumanImpactsDTOEditList()
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

        public CATPlotObj Oneoffimpacts { get => _current.Oneoffimpacts; set { _current.Oneoffimpacts = value; OnPropertyChanged(); } }

        public CATPlotObj Continuousimpacts { get => _current.Continuousimpacts; set { _current.Continuousimpacts = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public CATHumanImpactsDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Oneoffimpacts = this.Oneoffimpacts;
            returnVal.Continuousimpacts = this.Continuousimpacts;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATHumanImpactsDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATHumanImpactsDTO test)
        {
            _original.GeneralTarget = test.GeneralTarget;
            _current.GeneralTarget = test.GeneralTarget;
            _original.InterventionDesirable = test.InterventionDesirable;
            _current.InterventionDesirable = test.InterventionDesirable;
            _original.InterventionAchievable = test.InterventionAchievable;
            _current.InterventionAchievable = test.InterventionAchievable;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.Oneoffimpacts = test.Oneoffimpacts;
            _current.Oneoffimpacts = test.Oneoffimpacts;
            _original.Continuousimpacts = test.Continuousimpacts;
            _current.Continuousimpacts = test.Continuousimpacts;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATHumanImpactsDTOEditList> MakeCollection(List<CATHumanImpactsDTO> records)
        {

            var newData = new ExtRangeCollection<CATHumanImpactsDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATHumanImpactsDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}