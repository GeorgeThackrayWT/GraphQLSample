using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class CAFOverallDTO : BaseDto, IRecord
    {

        public string GeneralTarget { get; set; } = "";

        public bool InterventionDesirable { get; set; }

        public bool InterventionAchievable { get; set; }

        public string Notes { get; set; }

        public int FeatureID { get; set; }

        public int TotalTreeCanopyCoverCurrent { get; set; }
        public int TotalTreeCanopyCoverMin { get; set; }
        public int TotalTreeCanopyCoverMax { get; set; }

        public int OpenSpaceSemiNaturalHabitatCurrent { get; set; }
        public int OpenSpaceSemiNaturalHabitatMin { get; set; }
        public int OpenSpaceSemiNaturalHabitatMax { get; set; }

        public int OpenSpaceRidesCurrent { get; set; }
        public int OpenSpaceRidesMin { get; set; }
        public int OpenSpaceRidesMax { get; set; }

        public int OpenSpaceTemporaryCurrent { get; set; }
        public int OpenSpaceTemporaryMin { get; set; }
        public int OpenSpaceTemporaryMax { get; set; }

        public int OpenSpaceWaterFeaturesCurrent { get; set; }
        public int OpenSpaceWaterFeaturesMin { get; set; }
        public int OpenSpaceWaterFeaturesMax { get; set; }

        public int TotalOpenSpace { get; set; }

        public int TotalTreeCanopyOpenSpace { get; set; }

        public int ShrubCoverCurrent { get; set; }
        public int ShrubCoverMin { get; set; }
        public int ShrubCoverMax { get; set; }


        public CAFOverallDTO Clone()
        {
            return new CAFOverallDTO()
            {
                Id = this.Id,
                GeneralTarget = this.GeneralTarget,
                InterventionDesirable = this.InterventionDesirable,
                InterventionAchievable = this.InterventionAchievable,
                Notes = this.Notes,
                FeatureID = this.FeatureID,
                TotalTreeCanopyCoverCurrent = this.TotalTreeCanopyCoverCurrent,
                TotalTreeCanopyCoverMin = this.TotalTreeCanopyCoverMin,
                TotalTreeCanopyCoverMax = this.TotalTreeCanopyCoverMax,
                OpenSpaceSemiNaturalHabitatCurrent = this.OpenSpaceSemiNaturalHabitatCurrent,
                OpenSpaceSemiNaturalHabitatMin = this.OpenSpaceSemiNaturalHabitatMin,
                OpenSpaceSemiNaturalHabitatMax = this.OpenSpaceSemiNaturalHabitatMax,
                OpenSpaceRidesCurrent = this.OpenSpaceRidesCurrent,
                OpenSpaceRidesMin = this.OpenSpaceRidesMin,
                OpenSpaceRidesMax = this.OpenSpaceRidesMax,
                OpenSpaceTemporaryCurrent = this.OpenSpaceTemporaryCurrent,
                OpenSpaceTemporaryMin = this.OpenSpaceTemporaryMin,
                OpenSpaceTemporaryMax = this.OpenSpaceTemporaryMax,
                OpenSpaceWaterFeaturesCurrent = this.OpenSpaceWaterFeaturesCurrent,
                OpenSpaceWaterFeaturesMin = this.OpenSpaceWaterFeaturesMin,
                OpenSpaceWaterFeaturesMax = this.OpenSpaceWaterFeaturesMax,
                TotalOpenSpace = this.TotalOpenSpace,
                TotalTreeCanopyOpenSpace = this.TotalTreeCanopyOpenSpace,
                ShrubCoverCurrent = this.ShrubCoverCurrent,
                ShrubCoverMin = this.ShrubCoverMin,
                ShrubCoverMax = this.ShrubCoverMax,
            };
        }//endofclonemethods
    }

    public class CAFOverallDTOEdit : PropertyBase<CAFOverallDTOEdit>, IDuplicate
    {

        private CAFOverallDTO _dto;


        public CAFOverallDTOEdit()
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

        public Property<int> FeatureID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TotalTreeCanopyCoverCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> TotalTreeCanopyCoverMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> TotalTreeCanopyCoverMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> OpenSpaceSemiNaturalHabitatCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceSemiNaturalHabitatMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceSemiNaturalHabitatMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> OpenSpaceRidesCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceRidesMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceRidesMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> OpenSpaceTemporaryCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceTemporaryMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceTemporaryMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> OpenSpaceWaterFeaturesCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceWaterFeaturesMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> OpenSpaceWaterFeaturesMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TotalOpenSpace { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TotalTreeCanopyOpenSpace { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> ShrubCoverCurrent { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> ShrubCoverMin { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> ShrubCoverMax { get; set; } = new Property<int>() { Value = 0, Original = 0 };




        public int RecordId => Id.Value;


        public CAFOverallDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.GeneralTarget = GeneralTarget.Value;
            returnVal.InterventionDesirable = InterventionDesirable.Value;
            returnVal.InterventionAchievable = InterventionAchievable.Value;
            returnVal.Notes = Notes.Value;
            returnVal.FeatureID = FeatureID.Value;
            returnVal.TotalTreeCanopyCoverCurrent = TotalTreeCanopyCoverCurrent.Value;
            returnVal.TotalTreeCanopyCoverMin = TotalTreeCanopyCoverMin.Value;
            returnVal.TotalTreeCanopyCoverMax = TotalTreeCanopyCoverMax.Value;
            returnVal.OpenSpaceSemiNaturalHabitatCurrent = OpenSpaceSemiNaturalHabitatCurrent.Value;
            returnVal.OpenSpaceSemiNaturalHabitatMin = OpenSpaceSemiNaturalHabitatMin.Value;
            returnVal.OpenSpaceSemiNaturalHabitatMax = OpenSpaceSemiNaturalHabitatMax.Value;
            returnVal.OpenSpaceRidesCurrent = OpenSpaceRidesCurrent.Value;
            returnVal.OpenSpaceRidesMin = OpenSpaceRidesMin.Value;
            returnVal.OpenSpaceRidesMax = OpenSpaceRidesMax.Value;
            returnVal.OpenSpaceTemporaryCurrent = OpenSpaceTemporaryCurrent.Value;
            returnVal.OpenSpaceTemporaryMin = OpenSpaceTemporaryMin.Value;
            returnVal.OpenSpaceTemporaryMax = OpenSpaceTemporaryMax.Value;
            returnVal.OpenSpaceWaterFeaturesCurrent = OpenSpaceWaterFeaturesCurrent.Value;
            returnVal.OpenSpaceWaterFeaturesMin = OpenSpaceWaterFeaturesMin.Value;
            returnVal.OpenSpaceWaterFeaturesMax = OpenSpaceWaterFeaturesMax.Value;
            returnVal.TotalOpenSpace = TotalOpenSpace.Value;
            returnVal.TotalTreeCanopyOpenSpace = TotalTreeCanopyOpenSpace.Value;
            returnVal.ShrubCoverCurrent = ShrubCoverCurrent.Value;
            returnVal.ShrubCoverMin = ShrubCoverMin.Value;
            returnVal.ShrubCoverMax = ShrubCoverMax.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CAFOverallDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CAFOverallDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.GeneralTarget = Property<string>.Make(test.GeneralTarget,GeneralTarget);
            this.InterventionDesirable = Property<bool>.Make(test.InterventionDesirable,InterventionDesirable);
            this.InterventionAchievable = Property<bool>.Make(test.InterventionAchievable,InterventionAchievable);
            this.Notes = Property<string>.Make(test.Notes,Notes);
            this.FeatureID = Property<int>.Make(test.FeatureID,FeatureID);
            this.TotalTreeCanopyCoverCurrent = Property<int>.Make(test.TotalTreeCanopyCoverCurrent,TotalTreeCanopyCoverCurrent);
            this.TotalTreeCanopyCoverMin = Property<int>.Make(test.TotalTreeCanopyCoverMin,TotalTreeCanopyCoverMin);
            this.TotalTreeCanopyCoverMax = Property<int>.Make(test.TotalTreeCanopyCoverMax,TotalTreeCanopyCoverMax);
            this.OpenSpaceSemiNaturalHabitatCurrent = Property<int>.Make(test.OpenSpaceSemiNaturalHabitatCurrent,OpenSpaceSemiNaturalHabitatCurrent);
            this.OpenSpaceSemiNaturalHabitatMin = Property<int>.Make(test.OpenSpaceSemiNaturalHabitatMin,OpenSpaceSemiNaturalHabitatMin);
            this.OpenSpaceSemiNaturalHabitatMax = Property<int>.Make(test.OpenSpaceSemiNaturalHabitatMax,OpenSpaceSemiNaturalHabitatMax);
            this.OpenSpaceRidesCurrent = Property<int>.Make(test.OpenSpaceRidesCurrent,OpenSpaceRidesCurrent);
            this.OpenSpaceRidesMin = Property<int>.Make(test.OpenSpaceRidesMin,OpenSpaceRidesMin);
            this.OpenSpaceRidesMax = Property<int>.Make(test.OpenSpaceRidesMax,OpenSpaceRidesMax);
            this.OpenSpaceTemporaryCurrent = Property<int>.Make(test.OpenSpaceTemporaryCurrent,OpenSpaceTemporaryCurrent);
            this.OpenSpaceTemporaryMin = Property<int>.Make(test.OpenSpaceTemporaryMin,OpenSpaceTemporaryMin);
            this.OpenSpaceTemporaryMax = Property<int>.Make(test.OpenSpaceTemporaryMax,OpenSpaceTemporaryMax);
            this.OpenSpaceWaterFeaturesCurrent = Property<int>.Make(test.OpenSpaceWaterFeaturesCurrent,OpenSpaceWaterFeaturesCurrent);
            this.OpenSpaceWaterFeaturesMin = Property<int>.Make(test.OpenSpaceWaterFeaturesMin,OpenSpaceWaterFeaturesMin);
            this.OpenSpaceWaterFeaturesMax = Property<int>.Make(test.OpenSpaceWaterFeaturesMax,OpenSpaceWaterFeaturesMax);
            this.TotalOpenSpace = Property<int>.Make(test.TotalOpenSpace,TotalOpenSpace);
            this.TotalTreeCanopyOpenSpace = Property<int>.Make(test.TotalTreeCanopyOpenSpace,TotalTreeCanopyOpenSpace);
            this.ShrubCoverCurrent = Property<int>.Make(test.ShrubCoverCurrent,ShrubCoverCurrent);
            this.ShrubCoverMin = Property<int>.Make(test.ShrubCoverMin,ShrubCoverMin);
            this.ShrubCoverMax = Property<int>.Make(test.ShrubCoverMax,ShrubCoverMax);
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
            FeatureID.Revert();
            TotalTreeCanopyCoverCurrent.Revert();
            TotalTreeCanopyCoverMin.Revert();
            TotalTreeCanopyCoverMax.Revert();
            OpenSpaceSemiNaturalHabitatCurrent.Revert();
            OpenSpaceSemiNaturalHabitatMin.Revert();
            OpenSpaceSemiNaturalHabitatMax.Revert();
            OpenSpaceRidesCurrent.Revert();
            OpenSpaceRidesMin.Revert();
            OpenSpaceRidesMax.Revert();
            OpenSpaceTemporaryCurrent.Revert();
            OpenSpaceTemporaryMin.Revert();
            OpenSpaceTemporaryMax.Revert();
            OpenSpaceWaterFeaturesCurrent.Revert();
            OpenSpaceWaterFeaturesMin.Revert();
            OpenSpaceWaterFeaturesMax.Revert();
            TotalOpenSpace.Revert();
            TotalTreeCanopyOpenSpace.Revert();
            ShrubCoverCurrent.Revert();
            ShrubCoverMin.Revert();
            ShrubCoverMax.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<CAFOverallDTOEdit> MakeCollection(List<CAFOverallDTO> records)
        {

            var newData = new ExtRangeCollection<CAFOverallDTOEdit>();

            foreach (var rec in records)
            {
                var e = new CAFOverallDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class CAFOverallDTOEditList : ListObj<CAFOverallDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private CAFOverallDTO _dto;


        public CAFOverallDTOEditList()
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

        public int FeatureID { get => _current.FeatureID; set { _current.FeatureID = value; OnPropertyChanged(); } }

        public int TotalTreeCanopyCoverCurrent { get => _current.TotalTreeCanopyCoverCurrent; set { _current.TotalTreeCanopyCoverCurrent = value; OnPropertyChanged(); } }
        public int TotalTreeCanopyCoverMin { get => _current.TotalTreeCanopyCoverMin; set { _current.TotalTreeCanopyCoverMin = value; OnPropertyChanged(); } }
        public int TotalTreeCanopyCoverMax { get => _current.TotalTreeCanopyCoverMax; set { _current.TotalTreeCanopyCoverMax = value; OnPropertyChanged(); } }

        public int OpenSpaceSemiNaturalHabitatCurrent { get => _current.OpenSpaceSemiNaturalHabitatCurrent; set { _current.OpenSpaceSemiNaturalHabitatCurrent = value; OnPropertyChanged(); } }
        public int OpenSpaceSemiNaturalHabitatMin { get => _current.OpenSpaceSemiNaturalHabitatMin; set { _current.OpenSpaceSemiNaturalHabitatMin = value; OnPropertyChanged(); } }
        public int OpenSpaceSemiNaturalHabitatMax { get => _current.OpenSpaceSemiNaturalHabitatMax; set { _current.OpenSpaceSemiNaturalHabitatMax = value; OnPropertyChanged(); } }

        public int OpenSpaceRidesCurrent { get => _current.OpenSpaceRidesCurrent; set { _current.OpenSpaceRidesCurrent = value; OnPropertyChanged(); } }
        public int OpenSpaceRidesMin { get => _current.OpenSpaceRidesMin; set { _current.OpenSpaceRidesMin = value; OnPropertyChanged(); } }
        public int OpenSpaceRidesMax { get => _current.OpenSpaceRidesMax; set { _current.OpenSpaceRidesMax = value; OnPropertyChanged(); } }

        public int OpenSpaceTemporaryCurrent { get => _current.OpenSpaceTemporaryCurrent; set { _current.OpenSpaceTemporaryCurrent = value; OnPropertyChanged(); } }
        public int OpenSpaceTemporaryMin { get => _current.OpenSpaceTemporaryMin; set { _current.OpenSpaceTemporaryMin = value; OnPropertyChanged(); } }
        public int OpenSpaceTemporaryMax { get => _current.OpenSpaceTemporaryMax; set { _current.OpenSpaceTemporaryMax = value; OnPropertyChanged(); } }

        public int OpenSpaceWaterFeaturesCurrent { get => _current.OpenSpaceWaterFeaturesCurrent; set { _current.OpenSpaceWaterFeaturesCurrent = value; OnPropertyChanged(); } }
        public int OpenSpaceWaterFeaturesMin { get => _current.OpenSpaceWaterFeaturesMin; set { _current.OpenSpaceWaterFeaturesMin = value; OnPropertyChanged(); } }
        public int OpenSpaceWaterFeaturesMax { get => _current.OpenSpaceWaterFeaturesMax; set { _current.OpenSpaceWaterFeaturesMax = value; OnPropertyChanged(); } }

        public int TotalOpenSpace { get => _current.TotalOpenSpace; set { _current.TotalOpenSpace = value; OnPropertyChanged(); } }

        public int TotalTreeCanopyOpenSpace { get => _current.TotalTreeCanopyOpenSpace; set { _current.TotalTreeCanopyOpenSpace = value; OnPropertyChanged(); } }

        public int ShrubCoverCurrent { get => _current.ShrubCoverCurrent; set { _current.ShrubCoverCurrent = value; OnPropertyChanged(); } }
        public int ShrubCoverMin { get => _current.ShrubCoverMin; set { _current.ShrubCoverMin = value; OnPropertyChanged(); } }
        public int ShrubCoverMax { get => _current.ShrubCoverMax; set { _current.ShrubCoverMax = value; OnPropertyChanged(); } }




        public int RecordId => Id;


        public CAFOverallDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.GeneralTarget = this.GeneralTarget;
            returnVal.InterventionDesirable = this.InterventionDesirable;
            returnVal.InterventionAchievable = this.InterventionAchievable;
            returnVal.Notes = this.Notes;
            returnVal.FeatureID = this.FeatureID;
            returnVal.TotalTreeCanopyCoverCurrent = this.TotalTreeCanopyCoverCurrent;
            returnVal.TotalTreeCanopyCoverMin = this.TotalTreeCanopyCoverMin;
            returnVal.TotalTreeCanopyCoverMax = this.TotalTreeCanopyCoverMax;
            returnVal.OpenSpaceSemiNaturalHabitatCurrent = this.OpenSpaceSemiNaturalHabitatCurrent;
            returnVal.OpenSpaceSemiNaturalHabitatMin = this.OpenSpaceSemiNaturalHabitatMin;
            returnVal.OpenSpaceSemiNaturalHabitatMax = this.OpenSpaceSemiNaturalHabitatMax;
            returnVal.OpenSpaceRidesCurrent = this.OpenSpaceRidesCurrent;
            returnVal.OpenSpaceRidesMin = this.OpenSpaceRidesMin;
            returnVal.OpenSpaceRidesMax = this.OpenSpaceRidesMax;
            returnVal.OpenSpaceTemporaryCurrent = this.OpenSpaceTemporaryCurrent;
            returnVal.OpenSpaceTemporaryMin = this.OpenSpaceTemporaryMin;
            returnVal.OpenSpaceTemporaryMax = this.OpenSpaceTemporaryMax;
            returnVal.OpenSpaceWaterFeaturesCurrent = this.OpenSpaceWaterFeaturesCurrent;
            returnVal.OpenSpaceWaterFeaturesMin = this.OpenSpaceWaterFeaturesMin;
            returnVal.OpenSpaceWaterFeaturesMax = this.OpenSpaceWaterFeaturesMax;
            returnVal.TotalOpenSpace = this.TotalOpenSpace;
            returnVal.TotalTreeCanopyOpenSpace = this.TotalTreeCanopyOpenSpace;
            returnVal.ShrubCoverCurrent = this.ShrubCoverCurrent;
            returnVal.ShrubCoverMin = this.ShrubCoverMin;
            returnVal.ShrubCoverMax = this.ShrubCoverMax;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (CAFOverallDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(CAFOverallDTO test)
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
            _original.FeatureID = test.FeatureID;
            _current.FeatureID = test.FeatureID;
            _original.TotalTreeCanopyCoverCurrent = test.TotalTreeCanopyCoverCurrent;
            _current.TotalTreeCanopyCoverCurrent = test.TotalTreeCanopyCoverCurrent;
            _original.TotalTreeCanopyCoverMin = test.TotalTreeCanopyCoverMin;
            _current.TotalTreeCanopyCoverMin = test.TotalTreeCanopyCoverMin;
            _original.TotalTreeCanopyCoverMax = test.TotalTreeCanopyCoverMax;
            _current.TotalTreeCanopyCoverMax = test.TotalTreeCanopyCoverMax;
            _original.OpenSpaceSemiNaturalHabitatCurrent = test.OpenSpaceSemiNaturalHabitatCurrent;
            _current.OpenSpaceSemiNaturalHabitatCurrent = test.OpenSpaceSemiNaturalHabitatCurrent;
            _original.OpenSpaceSemiNaturalHabitatMin = test.OpenSpaceSemiNaturalHabitatMin;
            _current.OpenSpaceSemiNaturalHabitatMin = test.OpenSpaceSemiNaturalHabitatMin;
            _original.OpenSpaceSemiNaturalHabitatMax = test.OpenSpaceSemiNaturalHabitatMax;
            _current.OpenSpaceSemiNaturalHabitatMax = test.OpenSpaceSemiNaturalHabitatMax;
            _original.OpenSpaceRidesCurrent = test.OpenSpaceRidesCurrent;
            _current.OpenSpaceRidesCurrent = test.OpenSpaceRidesCurrent;
            _original.OpenSpaceRidesMin = test.OpenSpaceRidesMin;
            _current.OpenSpaceRidesMin = test.OpenSpaceRidesMin;
            _original.OpenSpaceRidesMax = test.OpenSpaceRidesMax;
            _current.OpenSpaceRidesMax = test.OpenSpaceRidesMax;
            _original.OpenSpaceTemporaryCurrent = test.OpenSpaceTemporaryCurrent;
            _current.OpenSpaceTemporaryCurrent = test.OpenSpaceTemporaryCurrent;
            _original.OpenSpaceTemporaryMin = test.OpenSpaceTemporaryMin;
            _current.OpenSpaceTemporaryMin = test.OpenSpaceTemporaryMin;
            _original.OpenSpaceTemporaryMax = test.OpenSpaceTemporaryMax;
            _current.OpenSpaceTemporaryMax = test.OpenSpaceTemporaryMax;
            _original.OpenSpaceWaterFeaturesCurrent = test.OpenSpaceWaterFeaturesCurrent;
            _current.OpenSpaceWaterFeaturesCurrent = test.OpenSpaceWaterFeaturesCurrent;
            _original.OpenSpaceWaterFeaturesMin = test.OpenSpaceWaterFeaturesMin;
            _current.OpenSpaceWaterFeaturesMin = test.OpenSpaceWaterFeaturesMin;
            _original.OpenSpaceWaterFeaturesMax = test.OpenSpaceWaterFeaturesMax;
            _current.OpenSpaceWaterFeaturesMax = test.OpenSpaceWaterFeaturesMax;
            _original.TotalOpenSpace = test.TotalOpenSpace;
            _current.TotalOpenSpace = test.TotalOpenSpace;
            _original.TotalTreeCanopyOpenSpace = test.TotalTreeCanopyOpenSpace;
            _current.TotalTreeCanopyOpenSpace = test.TotalTreeCanopyOpenSpace;
            _original.ShrubCoverCurrent = test.ShrubCoverCurrent;
            _current.ShrubCoverCurrent = test.ShrubCoverCurrent;
            _original.ShrubCoverMin = test.ShrubCoverMin;
            _current.ShrubCoverMin = test.ShrubCoverMin;
            _original.ShrubCoverMax = test.ShrubCoverMax;
            _current.ShrubCoverMax = test.ShrubCoverMax;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();  
 _dto = test; 
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<CAFOverallDTOEditList> MakeCollection(List<CAFOverallDTO> records)
        {

            var newData = new ExtRangeCollection<CAFOverallDTOEditList>();

            foreach (var rec in records)
            {
                var e = new CAFOverallDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}
