using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CATFloraDTO : BaseDto, IRecord
    {

        public string GeneralTarget { get; set; }

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public CATPlotObj Ancientwoodlandplantsspecialists { get; set; }

        public CATPlotObj Otherwoodlandplantsgeneralists { get; set; }

        public CATPlotObj Othernativeplantsegseminaturalopenground { get; set; }

        public CATPlotObj Coarsevegetationbrackenbramble { get; set; }

        public CATPlotObj Otherplants { get; set; }

        public CATPlotObj Novegetation { get; set; }

        public CATFloraDTO Clone()
        {
            return new CATFloraDTO()
            {
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                Ancientwoodlandplantsspecialists = this.Ancientwoodlandplantsspecialists,
                Otherwoodlandplantsgeneralists = this.Otherwoodlandplantsgeneralists,
                Othernativeplantsegseminaturalopenground = this.Othernativeplantsegseminaturalopenground,
                Coarsevegetationbrackenbramble = this.Coarsevegetationbrackenbramble,
                Otherplants = this.Otherplants,
                Novegetation = this.Novegetation,
            };
        }//endofclonemethods
    }

    public class CATFloraDTOEdit : PropertyBase<CATFloraDTOEdit>, IDuplicate
    {

        private CATFloraDTO _dto;


        public CATFloraDTOEdit()
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

        public Property<CATPlotObj> Ancientwoodlandplantsspecialists { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Otherwoodlandplantsgeneralists { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Othernativeplantsegseminaturalopenground { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Coarsevegetationbrackenbramble { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Otherplants { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };

        public Property<CATPlotObj> Novegetation { get; set; } = new Property<CATPlotObj>() { Value = null, Original = null };



        public int RecordId => Id.Value;


        public CATFloraDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.Ancientwoodlandplantsspecialists = Ancientwoodlandplantsspecialists.Value;
            returnVal.Otherwoodlandplantsgeneralists = Otherwoodlandplantsgeneralists.Value;
            returnVal.Othernativeplantsegseminaturalopenground = Othernativeplantsegseminaturalopenground.Value;
            returnVal.Coarsevegetationbrackenbramble = Coarsevegetationbrackenbramble.Value;
            returnVal.Otherplants = Otherplants.Value;
            returnVal.Novegetation = Novegetation.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATFloraDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATFloraDTO test)
        {
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.Ancientwoodlandplantsspecialists = Property<CATPlotObj>.Make(test.Ancientwoodlandplantsspecialists,Ancientwoodlandplantsspecialists);
            this.Otherwoodlandplantsgeneralists = Property<CATPlotObj>.Make(test.Otherwoodlandplantsgeneralists,Otherwoodlandplantsgeneralists);
            this.Othernativeplantsegseminaturalopenground = Property<CATPlotObj>.Make(test.Othernativeplantsegseminaturalopenground,Othernativeplantsegseminaturalopenground);
            this.Coarsevegetationbrackenbramble = Property<CATPlotObj>.Make(test.Coarsevegetationbrackenbramble,Coarsevegetationbrackenbramble);
            this.Otherplants = Property<CATPlotObj>.Make(test.Otherplants,Otherplants);
            this.Novegetation = Property<CATPlotObj>.Make(test.Novegetation,Novegetation);
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
            Ancientwoodlandplantsspecialists.Revert();
            Otherwoodlandplantsgeneralists.Revert();
            Othernativeplantsegseminaturalopenground.Revert();
            Coarsevegetationbrackenbramble.Revert();
            Otherplants.Revert();
            Novegetation.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CATFloraDTOEdit> MakeCollection(List<CATFloraDTO> records)
        {

            var newData = new ExtRangeCollection<CATFloraDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CATFloraDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


    public class CATFloraDTOEditList : ListObj<CATFloraDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CATFloraDTO _dto;


        public CATFloraDTOEditList()
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

        public CATPlotObj Ancientwoodlandplantsspecialists { get => _current.Ancientwoodlandplantsspecialists; set { _current.Ancientwoodlandplantsspecialists = value; OnPropertyChanged(); } }

        public CATPlotObj Otherwoodlandplantsgeneralists { get => _current.Otherwoodlandplantsgeneralists; set { _current.Otherwoodlandplantsgeneralists = value; OnPropertyChanged(); } }

        public CATPlotObj Othernativeplantsegseminaturalopenground { get => _current.Othernativeplantsegseminaturalopenground; set { _current.Othernativeplantsegseminaturalopenground = value; OnPropertyChanged(); } }

        public CATPlotObj Coarsevegetationbrackenbramble { get => _current.Coarsevegetationbrackenbramble; set { _current.Coarsevegetationbrackenbramble = value; OnPropertyChanged(); } }

        public CATPlotObj Otherplants { get => _current.Otherplants; set { _current.Otherplants = value; OnPropertyChanged(); } }

        public CATPlotObj Novegetation { get => _current.Novegetation; set { _current.Novegetation = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public CATFloraDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.Ancientwoodlandplantsspecialists = this.Ancientwoodlandplantsspecialists;
            returnVal.Otherwoodlandplantsgeneralists = this.Otherwoodlandplantsgeneralists;
            returnVal.Othernativeplantsegseminaturalopenground = this.Othernativeplantsegseminaturalopenground;
            returnVal.Coarsevegetationbrackenbramble = this.Coarsevegetationbrackenbramble;
            returnVal.Otherplants = this.Otherplants;
            returnVal.Novegetation = this.Novegetation;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CATFloraDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CATFloraDTO test)
        {
            _original.GeneralTarget = test.GeneralTarget;
            _current.GeneralTarget = test.GeneralTarget;
            _original.InterventionDesirable = test.InterventionDesirable;
            _current.InterventionDesirable = test.InterventionDesirable;
            _original.InterventionAchievable = test.InterventionAchievable;
            _current.InterventionAchievable = test.InterventionAchievable;
            _original.Notes = test.Notes;
            _current.Notes = test.Notes;
            _original.Ancientwoodlandplantsspecialists = test.Ancientwoodlandplantsspecialists;
            _current.Ancientwoodlandplantsspecialists = test.Ancientwoodlandplantsspecialists;
            _original.Otherwoodlandplantsgeneralists = test.Otherwoodlandplantsgeneralists;
            _current.Otherwoodlandplantsgeneralists = test.Otherwoodlandplantsgeneralists;
            _original.Othernativeplantsegseminaturalopenground = test.Othernativeplantsegseminaturalopenground;
            _current.Othernativeplantsegseminaturalopenground = test.Othernativeplantsegseminaturalopenground;
            _original.Coarsevegetationbrackenbramble = test.Coarsevegetationbrackenbramble;
            _current.Coarsevegetationbrackenbramble = test.Coarsevegetationbrackenbramble;
            _original.Otherplants = test.Otherplants;
            _current.Otherplants = test.Otherplants;
            _original.Novegetation = test.Novegetation;
            _current.Novegetation = test.Novegetation;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CATFloraDTOEditList> MakeCollection(List<CATFloraDTO> records)
        {

            var newData = new ExtRangeCollection<CATFloraDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CATFloraDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}