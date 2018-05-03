using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.ManagementPlans.ConditionAssessment.ConditionAssessmentForm.Editor
{
    public class WoodlandSubsectionDto : BaseDto, IRecord
    {

        public bool WholeSite { get; set; }

        public int KeyFeatureId { get; set; }
        public ComboBoxValue KeyFeature { get; set; }

        public string KeyFeatureDescription { get; set; }

        public int StratumId { get; set; }
        public ComboBoxValue Stratum { get; set; }

        public string StratumDescription { get; set; }

        public int ManagementUnitId { get; set; }
        public WoodlandSubsectionDto Clone()
        {
            return new WoodlandSubsectionDto()
            {
                WholeSite = this.WholeSite,
                KeyFeatureId = this.KeyFeatureId,
                KeyFeature = this.KeyFeature,
                KeyFeatureDescription = this.KeyFeatureDescription,
                StratumId = this.StratumId,
                Stratum = this.Stratum,
                StratumDescription = this.StratumDescription,
                ManagementUnitId = this.ManagementUnitId,
            };
        }//endofclonemethods
    }

    public class WoodlandSubsectionEdit : PropertyBase<WoodlandSubsectionEdit>, IDuplicate
    {

        private WoodlandSubsectionDto _dto;


        public WoodlandSubsectionEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor


        public Property<bool> WholeSite { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<int> KeyFeatureId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> KeyFeature { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<string> KeyFeatureDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> StratumId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> Stratum { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<string> StratumDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };


        public int RecordId => Id.Value;


        public WoodlandSubsectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.WholeSite = WholeSite.Value;
            returnVal.KeyFeatureId = KeyFeatureId.Value;
            returnVal.KeyFeature = KeyFeature.Value;
            returnVal.KeyFeatureDescription = KeyFeatureDescription.Value;
            returnVal.StratumId = StratumId.Value;
            returnVal.Stratum = Stratum.Value;
            returnVal.StratumDescription = StratumDescription.Value;
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (WoodlandSubsectionEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(WoodlandSubsectionDto test)
        {
            this.WholeSite = Property<bool>.Make(test.WholeSite,WholeSite);
            this.KeyFeatureId = Property<int>.Make(test.KeyFeatureId,KeyFeatureId);
            this.KeyFeature = Property<ComboBoxValue>.Make(test.KeyFeature,KeyFeature);
            this.KeyFeatureDescription = Property<string>.Make(test.KeyFeatureDescription,KeyFeatureDescription);
            this.StratumId = Property<int>.Make(test.StratumId,StratumId);
            this.Stratum = Property<ComboBoxValue>.Make(test.Stratum,Stratum);
            this.StratumDescription = Property<string>.Make(test.StratumDescription,StratumDescription);
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId,ManagementUnitId);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            WholeSite.Revert();
            KeyFeatureId.Revert();
            KeyFeature.Revert();
            KeyFeatureDescription.Revert();
            StratumId.Revert();
            Stratum.Revert();
            StratumDescription.Revert();
            ManagementUnitId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<WoodlandSubsectionEdit> MakeCollection(List<WoodlandSubsectionDto> records)
        {

            var newData = new ExtRangeCollection<WoodlandSubsectionEdit>();

            foreach (var rec in records)
            {
                var e = new WoodlandSubsectionEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class WoodlandSubsectionEditList : ListObj<WoodlandSubsectionDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private WoodlandSubsectionDto _dto;


        public WoodlandSubsectionEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public bool WholeSite { get => _current.WholeSite; set { _current.WholeSite = value; OnPropertyChanged(); } }

        public int KeyFeatureId { get => _current.KeyFeatureId; set { _current.KeyFeatureId = value; OnPropertyChanged(); } }
        public ComboBoxValue KeyFeature { get => _current.KeyFeature; set { _current.KeyFeature = value; OnPropertyChanged(); } }

        public string KeyFeatureDescription { get => _current.KeyFeatureDescription; set { _current.KeyFeatureDescription = value; OnPropertyChanged(); } }

        public int StratumId { get => _current.StratumId; set { _current.StratumId = value; OnPropertyChanged(); } }
        public ComboBoxValue Stratum { get => _current.Stratum; set { _current.Stratum = value; OnPropertyChanged(); } }

        public string StratumDescription { get => _current.StratumDescription; set { _current.StratumDescription = value; OnPropertyChanged(); } }

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public WoodlandSubsectionDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.WholeSite = this.WholeSite;
            returnVal.KeyFeatureId = this.KeyFeatureId;
            returnVal.KeyFeature = this.KeyFeature;
            returnVal.KeyFeatureDescription = this.KeyFeatureDescription;
            returnVal.StratumId = this.StratumId;
            returnVal.Stratum = this.Stratum;
            returnVal.StratumDescription = this.StratumDescription;
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (WoodlandSubsectionEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(WoodlandSubsectionDto test)
        {
            _original.WholeSite = test.WholeSite;
            _current.WholeSite = test.WholeSite;
            _original.KeyFeatureId = test.KeyFeatureId;
            _current.KeyFeatureId = test.KeyFeatureId;
            _original.KeyFeature = test.KeyFeature;
            _current.KeyFeature = test.KeyFeature;
            _original.KeyFeatureDescription = test.KeyFeatureDescription;
            _current.KeyFeatureDescription = test.KeyFeatureDescription;
            _original.StratumId = test.StratumId;
            _current.StratumId = test.StratumId;
            _original.Stratum = test.Stratum;
            _current.Stratum = test.Stratum;
            _original.StratumDescription = test.StratumDescription;
            _current.StratumDescription = test.StratumDescription;
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<WoodlandSubsectionEditList> MakeCollection(List<WoodlandSubsectionDto> records)
        {

            var newData = new ExtRangeCollection<WoodlandSubsectionEditList>();

            foreach (var rec in records)
            {
                var e = new WoodlandSubsectionEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}