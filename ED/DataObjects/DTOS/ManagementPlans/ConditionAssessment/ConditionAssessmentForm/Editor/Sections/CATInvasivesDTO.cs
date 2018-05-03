using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATInvasivesDTO : BaseDto, IRecord
    {
        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Rhododendron { get; set; }

        public CATPlotObj Himalayanbalsam { get; set; }

        public CATPlotObj Japaneseknotweed { get; set; }

        public CATPlotObj Other { get; set; }
        public CATInvasivesDTO Clone()
        {
            return new CATInvasivesDTO()
            {
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Rhododendron = this.Rhododendron,
                Himalayanbalsam = this.Himalayanbalsam,
                Japaneseknotweed = this.Japaneseknotweed,
                Other = this.Other,
            };
        }//endofclonemethods
    }

    public class CATInvasivesDTOEdit : PropertyBase<CATInvasivesDTOEdit>, IDuplicate
    {

        private CATInvasivesDTO _dto;


        public CATInvasivesDTOEdit()
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

        public Property<CATPlotObj> Rhododendron { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Himalayanbalsam { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Japaneseknotweed { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Other { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public CATInvasivesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Rhododendron = Rhododendron.Value;
            returnVal.Himalayanbalsam = Himalayanbalsam.Value;
            returnVal.Japaneseknotweed = Japaneseknotweed.Value;
            returnVal.Other = Other.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATInvasivesDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATInvasivesDTO test)
        {
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Rhododendron = Property<CATPlotObj>.Make(test.Rhododendron,Rhododendron);
            this.Himalayanbalsam = Property<CATPlotObj>.Make(test.Himalayanbalsam,Himalayanbalsam);
            this.Japaneseknotweed = Property<CATPlotObj>.Make(test.Japaneseknotweed,Japaneseknotweed);
            this.Other = Property<CATPlotObj>.Make(test.Other,Other);
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
            Rhododendron.Revert();
            Himalayanbalsam.Revert();
            Japaneseknotweed.Revert();
            Other.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATInvasivesDTOEdit> MakeCollection(List<CATInvasivesDTO> records)
        {

            var newData = new ExtRangeCollection<CATInvasivesDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATInvasivesDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATInvasivesDTOEditList : ListObj<CATInvasivesDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATInvasivesDTO _dto;


        public CATInvasivesDTOEditList()
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

        public CATPlotObj Rhododendron { get => _current.Rhododendron; set { _current.Rhododendron = value; OnPropertyChanged(); } }

        public CATPlotObj Himalayanbalsam { get => _current.Himalayanbalsam; set { _current.Himalayanbalsam = value; OnPropertyChanged(); } }

        public CATPlotObj Japaneseknotweed { get => _current.Japaneseknotweed; set { _current.Japaneseknotweed = value; OnPropertyChanged(); } }

        public CATPlotObj Other { get => _current.Other; set { _current.Other = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public CATInvasivesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Rhododendron = this.Rhododendron;
            returnVal.Himalayanbalsam = this.Himalayanbalsam;
            returnVal.Japaneseknotweed = this.Japaneseknotweed;
            returnVal.Other = this.Other;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATInvasivesDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATInvasivesDTO test)
        {
            _original.GeneralTarget = test.GeneralTarget;
            _current.GeneralTarget = test.GeneralTarget;
            _original.InterventionDesirable = test.InterventionDesirable;
            _current.InterventionDesirable = test.InterventionDesirable;
            _original.InterventionAchievable = test.InterventionAchievable;
            _current.InterventionAchievable = test.InterventionAchievable;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.Rhododendron = test.Rhododendron;
            _current.Rhododendron = test.Rhododendron;
            _original.Himalayanbalsam = test.Himalayanbalsam;
            _current.Himalayanbalsam = test.Himalayanbalsam;
            _original.Japaneseknotweed = test.Japaneseknotweed;
            _current.Japaneseknotweed = test.Japaneseknotweed;
            _original.Other = test.Other;
            _current.Other = test.Other;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATInvasivesDTOEditList> MakeCollection(List<CATInvasivesDTO> records)
        {

            var newData = new ExtRangeCollection<CATInvasivesDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATInvasivesDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}