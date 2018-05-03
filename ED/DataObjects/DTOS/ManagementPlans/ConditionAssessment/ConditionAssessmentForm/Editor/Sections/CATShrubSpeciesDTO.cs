using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATShrubSpeciesDTO : BaseDto, IRecord
    {
        public int Id { get; set; }

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj NativesNumberPresent { get; set; }

        public CATPlotObj NonNativesNumberPresent { get; set; }

        public CATPlotObjBool ShrubLayerDominatedByOneOrTwoSPP { get; set; }

        public CATPlotObj DAFORCover { get; set; }

        public CATShrubSpeciesDTO Clone()
        {
            return new CATShrubSpeciesDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                NativesNumberPresent = this.NativesNumberPresent,
                NonNativesNumberPresent = this.NonNativesNumberPresent,
                ShrubLayerDominatedByOneOrTwoSPP = this.ShrubLayerDominatedByOneOrTwoSPP,
                DAFORCover = this.DAFORCover,
            };
        }//endofclonemethods
    }

    public class CATShrubSpeciesDTOEdit : PropertyBase<CATShrubSpeciesDTOEdit>, IDuplicate
    {

        private CATShrubSpeciesDTO _dto;


        public CATShrubSpeciesDTOEdit()
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

        public Property<CATPlotObj> NativesNumberPresent { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> NonNativesNumberPresent { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObjBool> ShrubLayerDominatedByOneOrTwoSPP { get; set; } = new Property<CATPlotObjBool>() { Value = null, Original = null };

        public Property<CATPlotObj> DAFORCover { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };



        public int RecordId => Id.Value;


        public CATShrubSpeciesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.NativesNumberPresent = NativesNumberPresent.Value;
            returnVal.NonNativesNumberPresent = NonNativesNumberPresent.Value;
            returnVal.ShrubLayerDominatedByOneOrTwoSPP = ShrubLayerDominatedByOneOrTwoSPP.Value;
            returnVal.DAFORCover = DAFORCover.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATShrubSpeciesDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATShrubSpeciesDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.NativesNumberPresent = Property<CATPlotObj>.Make(test.NativesNumberPresent,NativesNumberPresent);
            this.NonNativesNumberPresent = Property<CATPlotObj>.Make(test.NonNativesNumberPresent,NonNativesNumberPresent);
            this.ShrubLayerDominatedByOneOrTwoSPP = Property<CATPlotObjBool>.Make(test.ShrubLayerDominatedByOneOrTwoSPP,ShrubLayerDominatedByOneOrTwoSPP);
            this.DAFORCover = Property<CATPlotObj>.Make(test.DAFORCover,DAFORCover);
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
            NativesNumberPresent.Revert();
            NonNativesNumberPresent.Revert();
            ShrubLayerDominatedByOneOrTwoSPP.Revert();
            DAFORCover.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATShrubSpeciesDTOEdit> MakeCollection(List<CATShrubSpeciesDTO> records)
        {

            var newData = new ExtRangeCollection<CATShrubSpeciesDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATShrubSpeciesDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CATShrubSpeciesDTOEditList : ListObj<CATShrubSpeciesDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATShrubSpeciesDTO _dto;


        public CATShrubSpeciesDTOEditList()
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

        public CATPlotObj NativesNumberPresent { get => _current.NativesNumberPresent; set { _current.NativesNumberPresent = value; OnPropertyChanged(); } }

        public CATPlotObj NonNativesNumberPresent { get => _current.NonNativesNumberPresent; set { _current.NonNativesNumberPresent = value; OnPropertyChanged(); } }

        public CATPlotObjBool ShrubLayerDominatedByOneOrTwoSPP { get => _current.ShrubLayerDominatedByOneOrTwoSPP; set { _current.ShrubLayerDominatedByOneOrTwoSPP = value; OnPropertyChanged(); } }

        public CATPlotObj DAFORCover { get => _current.DAFORCover; set { _current.DAFORCover = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public CATShrubSpeciesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.NativesNumberPresent = this.NativesNumberPresent;
            returnVal.NonNativesNumberPresent = this.NonNativesNumberPresent;
            returnVal.ShrubLayerDominatedByOneOrTwoSPP = this.ShrubLayerDominatedByOneOrTwoSPP;
            returnVal.DAFORCover = this.DAFORCover;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATShrubSpeciesDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATShrubSpeciesDTO test)
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
            _original.NativesNumberPresent = test.NativesNumberPresent;
            _current.NativesNumberPresent = test.NativesNumberPresent;
            _original.NonNativesNumberPresent = test.NonNativesNumberPresent;
            _current.NonNativesNumberPresent = test.NonNativesNumberPresent;
            _original.ShrubLayerDominatedByOneOrTwoSPP = test.ShrubLayerDominatedByOneOrTwoSPP;
            _current.ShrubLayerDominatedByOneOrTwoSPP = test.ShrubLayerDominatedByOneOrTwoSPP;
            _original.DAFORCover = test.DAFORCover;
            _current.DAFORCover = test.DAFORCover;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATShrubSpeciesDTOEditList> MakeCollection(List<CATShrubSpeciesDTO> records)
        {

            var newData = new ExtRangeCollection<CATShrubSpeciesDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATShrubSpeciesDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}