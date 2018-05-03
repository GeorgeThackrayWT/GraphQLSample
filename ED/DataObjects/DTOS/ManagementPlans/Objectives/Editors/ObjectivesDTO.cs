using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class ObjectivesDTO : BaseDto, IRecord
    {
        public int FeatureID { get; set; }

        public int KeyFeatureTypeID { get; set; }

        public int AimID { get; set; }

        public string Ref { get; set; }

        public bool IsConfidential { get; set; }

        public bool IsWoodProduction { get; set; }

        public string ConditionAssessment { get; set; }

        public string Description { get; set; }

        public string Significance { get; set; }

        public string OpportunitiesAndConstraints { get; set; }

        public string FactorsCausingChange { get; set; }

        public string LongTermObjective { get; set; }

        public string ShortTermObjective { get; set; }

        public bool IsWholeSite { get; set; }


        public ObjectivesDTO Clone()
        {
            return new ObjectivesDTO()
            {
                FeatureID = this.FeatureID,
                KeyFeatureTypeID = this.KeyFeatureTypeID,
                AimID = this.AimID,
                Ref = this.Ref,
                IsConfidential = this.IsConfidential,
                IsWoodProduction = this.IsWoodProduction,
                ConditionAssessment = this.ConditionAssessment,
                Description = this.Description,
                Significance = this.Significance,
                OpportunitiesAndConstraints = this.OpportunitiesAndConstraints,
                FactorsCausingChange = this.FactorsCausingChange,
                LongTermObjective = this.LongTermObjective,
                ShortTermObjective = this.ShortTermObjective,
                IsWholeSite = this.IsWholeSite,
                Id = this.Id
            };
        }//endofclonemethods
    }
    
    public class ObjectivesDTOEdit : PropertyBase<ObjectivesDTOEdit>, IDuplicate
    {

        private ObjectivesDTO _dto;


        public ObjectivesDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> FeatureID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> KeyFeatureTypeID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> AimID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> Ref { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> IsConfidential { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> IsWoodProduction { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> ConditionAssessment { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Significance { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> OpportunitiesAndConstraints { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> FactorsCausingChange { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> LongTermObjective { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> ShortTermObjective { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> IsWholeSite { get; set; } = new Property<bool>() { Value = false, Original = false };




        public int RecordId => Id.Value;


        public ObjectivesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureID = FeatureID.Value;
            returnVal.KeyFeatureTypeID = KeyFeatureTypeID.Value;
            returnVal.AimID = AimID.Value;
            returnVal.Ref = Ref.Value;
            returnVal.IsConfidential = IsConfidential.Value;
            returnVal.IsWoodProduction = IsWoodProduction.Value;
            returnVal.ConditionAssessment = ConditionAssessment.Value;
            returnVal.Description = Description.Value;
            returnVal.Significance = Significance.Value;
            returnVal.OpportunitiesAndConstraints = OpportunitiesAndConstraints.Value;
            returnVal.FactorsCausingChange = FactorsCausingChange.Value;
            returnVal.LongTermObjective = LongTermObjective.Value;
            returnVal.ShortTermObjective = ShortTermObjective.Value;
            returnVal.IsWholeSite = IsWholeSite.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ObjectivesDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ObjectivesDTO test)
        {
            this.FeatureID = Property<int>.Make(test.FeatureID,FeatureID);
            this.KeyFeatureTypeID = Property<int>.Make(test.KeyFeatureTypeID,KeyFeatureTypeID);
            this.AimID = Property<int>.Make(test.AimID,AimID);
            this.Ref = Property<string>.Make(test.Ref,Ref);
            this.IsConfidential = Property<bool>.Make(test.IsConfidential,IsConfidential);
            this.IsWoodProduction = Property<bool>.Make(test.IsWoodProduction,IsWoodProduction);
            this.ConditionAssessment = Property<string>.Make(test.ConditionAssessment,ConditionAssessment);
            this.Description = Property<string>.Make(test.Description,Description);
            this.Significance = Property<string>.Make(test.Significance,Significance);
            this.OpportunitiesAndConstraints = Property<string>.Make(test.OpportunitiesAndConstraints,OpportunitiesAndConstraints);
            this.FactorsCausingChange = Property<string>.Make(test.FactorsCausingChange,FactorsCausingChange);
            this.LongTermObjective = Property<string>.Make(test.LongTermObjective,LongTermObjective);
            this.ShortTermObjective = Property<string>.Make(test.ShortTermObjective,ShortTermObjective);
            this.IsWholeSite = Property<bool>.Make(test.IsWholeSite,IsWholeSite);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            FeatureID.Revert();
            KeyFeatureTypeID.Revert();
            AimID.Revert();
            Ref.Revert();
            IsConfidential.Revert();
            IsWoodProduction.Revert();
            ConditionAssessment.Revert();
            Description.Revert();
            Significance.Revert();
            OpportunitiesAndConstraints.Revert();
            FactorsCausingChange.Revert();
            LongTermObjective.Revert();
            ShortTermObjective.Revert();
            IsWholeSite.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ObjectivesDTOEdit> MakeCollection(List<ObjectivesDTO> records)
        {

            var newData = new ExtRangeCollection<ObjectivesDTOEdit>();

            foreach (var rec in records)
            {
                var e = new ObjectivesDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class ObjectivesDTOEditList : ListObj<ObjectivesDTOEditList>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ObjectivesDTO _dto;


        public ObjectivesDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int FeatureID { get => _current.FeatureID; set { _current.FeatureID = value; OnPropertyChanged(); } }

        public int KeyFeatureTypeID { get => _current.KeyFeatureTypeID; set { _current.KeyFeatureTypeID = value; OnPropertyChanged(); } }

        public int AimID { get => _current.AimID; set { _current.AimID = value; OnPropertyChanged(); } }

        public string Ref { get => _current.Ref; set { _current.Ref = value; OnPropertyChanged(); } }

        public bool IsConfidential { get => _current.IsConfidential; set { _current.IsConfidential = value; OnPropertyChanged(); } }

        public bool IsWoodProduction { get => _current.IsWoodProduction; set { _current.IsWoodProduction = value; OnPropertyChanged(); } }

        public string ConditionAssessment { get => _current.ConditionAssessment; set { _current.ConditionAssessment = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public string Significance { get => _current.Significance; set { _current.Significance = value; OnPropertyChanged(); } }

        public string OpportunitiesAndConstraints { get => _current.OpportunitiesAndConstraints; set { _current.OpportunitiesAndConstraints = value; OnPropertyChanged(); } }

        public string FactorsCausingChange { get => _current.FactorsCausingChange; set { _current.FactorsCausingChange = value; OnPropertyChanged(); } }

        public string LongTermObjective { get => _current.LongTermObjective; set { _current.LongTermObjective = value; OnPropertyChanged(); } }

        public string ShortTermObjective { get => _current.ShortTermObjective; set { _current.ShortTermObjective = value; OnPropertyChanged(); } }

        public bool IsWholeSite { get => _current.IsWholeSite; set { _current.IsWholeSite = value; OnPropertyChanged(); } }




        public int RecordId => Id;


        public ObjectivesDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureID = this.FeatureID;
            returnVal.KeyFeatureTypeID = this.KeyFeatureTypeID;
            returnVal.AimID = this.AimID;
            returnVal.Ref = this.Ref;
            returnVal.IsConfidential = this.IsConfidential;
            returnVal.IsWoodProduction = this.IsWoodProduction;
            returnVal.ConditionAssessment = this.ConditionAssessment;
            returnVal.Description = this.Description;
            returnVal.Significance = this.Significance;
            returnVal.OpportunitiesAndConstraints = this.OpportunitiesAndConstraints;
            returnVal.FactorsCausingChange = this.FactorsCausingChange;
            returnVal.LongTermObjective = this.LongTermObjective;
            returnVal.ShortTermObjective = this.ShortTermObjective;
            returnVal.IsWholeSite = this.IsWholeSite;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ObjectivesDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ObjectivesDTO test)
        {
            _original.FeatureID = test.FeatureID;
            _current.FeatureID = test.FeatureID;
            _original.KeyFeatureTypeID = test.KeyFeatureTypeID;
            _current.KeyFeatureTypeID = test.KeyFeatureTypeID;
            _original.AimID = test.AimID;
            _current.AimID = test.AimID;
            _original.Ref = test.Ref;
            _current.Ref = test.Ref;
            _original.IsConfidential = test.IsConfidential;
            _current.IsConfidential = test.IsConfidential;
            _original.IsWoodProduction = test.IsWoodProduction;
            _current.IsWoodProduction = test.IsWoodProduction;
            _original.ConditionAssessment = test.ConditionAssessment;
            _current.ConditionAssessment = test.ConditionAssessment;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Significance = test.Significance;
            _current.Significance = test.Significance;
            _original.OpportunitiesAndConstraints = test.OpportunitiesAndConstraints;
            _current.OpportunitiesAndConstraints = test.OpportunitiesAndConstraints;
            _original.FactorsCausingChange = test.FactorsCausingChange;
            _current.FactorsCausingChange = test.FactorsCausingChange;
            _original.LongTermObjective = test.LongTermObjective;
            _current.LongTermObjective = test.LongTermObjective;
            _original.ShortTermObjective = test.ShortTermObjective;
            _current.ShortTermObjective = test.ShortTermObjective;
            _original.IsWholeSite = test.IsWholeSite;
            _current.IsWholeSite = test.IsWholeSite;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ObjectivesDTOEditList> MakeCollection(List<ObjectivesDTO> records)
        {

            var newData = new ExtRangeCollection<ObjectivesDTOEditList>();

            foreach (var rec in records)
            {
                var e = new ObjectivesDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}