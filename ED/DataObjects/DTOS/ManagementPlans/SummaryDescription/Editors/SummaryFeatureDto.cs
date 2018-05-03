using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class SummaryFeatureDto : BaseDto, IRecord
    {
        public int FeatureId { get; set; }

        public ComboBoxValue Feature { get; set; }

        public string Description { get; set; }

        public bool Confidential { get; set; }

        public string MapRef { get; set; }

        public int SubCompartmentId { get; set; }

        public SummaryFeatureDto Clone()
        {
            return new SummaryFeatureDto()
            {
                FeatureId = this.FeatureId,
                Feature = this.Feature,
                Description = this.Description,
                Confidential = this.Confidential,
                MapRef = this.MapRef,
                SubCompartmentId = this.SubCompartmentId,
            };
        }//endofclonemethods
    }

    public class SummaryFeatureEdit : PropertyBase<SummaryFeatureEdit>, IDuplicate
    {

        private SummaryFeatureDto _dto;

        public SummaryFeatureEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> FeatureId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> Feature { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> Confidential { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> MapRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> SubCompartmentId { get; set; } = new Property<int>() { Value = 0, Original = 0 };



        public int RecordId => Id.Value;


        public SummaryFeatureDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureId = FeatureId.Value;
            returnVal.Feature = Feature.Value;
            returnVal.Description = Description.Value;
            returnVal.Confidential = Confidential.Value;
            returnVal.MapRef = MapRef.Value;
            returnVal.SubCompartmentId = SubCompartmentId.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryFeatureEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryFeatureDto test)
        {
            this.FeatureId = Property<int>.Make(test.FeatureId,FeatureId);
            this.Feature = Property<ComboBoxValue>.Make(test.Feature,Feature);
            this.Description = Property<string>.Make(test.Description,Description);
            this.Confidential = Property<bool>.Make(test.Confidential,Confidential);
            this.MapRef = Property<string>.Make(test.MapRef,MapRef);
            this.SubCompartmentId = Property<int>.Make(test.SubCompartmentId,SubCompartmentId);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            FeatureId.Revert();
            Feature.Revert();
            Description.Revert();
            Confidential.Revert();
            MapRef.Revert();
            SubCompartmentId.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SummaryFeatureEdit> MakeCollection(List<SummaryFeatureDto> records)
        {

            var newData = new ExtRangeCollection<SummaryFeatureEdit>();

            foreach (var rec in records)
            {
                var e = new SummaryFeatureEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SummaryFeatureEditList : ListObj<SummaryFeatureDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private SummaryFeatureDto _dto;
        public SummaryFeatureEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int FeatureId { get => _current.FeatureId; set { _current.FeatureId = value; OnPropertyChanged(); } }

        public ComboBoxValue Feature { get => _current.Feature; set { _current.Feature = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public bool Confidential { get => _current.Confidential; set { _current.Confidential = value; OnPropertyChanged(); } }

        public string MapRef { get => _current.MapRef; set { _current.MapRef = value; OnPropertyChanged(); } }

        public int SubCompartmentId { get => _current.SubCompartmentId; set { _current.SubCompartmentId = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public SummaryFeatureDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.FeatureId = this.FeatureId;
            returnVal.Feature = this.Feature;
            returnVal.Description = this.Description;
            returnVal.Confidential = this.Confidential;
            returnVal.MapRef = this.MapRef;
            returnVal.SubCompartmentId = this.SubCompartmentId;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryFeatureEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryFeatureDto test)
        {
            _original.FeatureId = test.FeatureId;
            _current.FeatureId = test.FeatureId;
            _original.Feature = test.Feature;
            _current.Feature = test.Feature;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.MapRef = test.MapRef;
            _current.MapRef = test.MapRef;
            _original.SubCompartmentId = test.SubCompartmentId;
            _current.SubCompartmentId = test.SubCompartmentId;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SummaryFeatureEditList> MakeCollection(List<SummaryFeatureDto> records)
        {

            var newData = new ExtRangeCollection<SummaryFeatureEditList>();

            foreach (var rec in records)
            {
                var e = new SummaryFeatureEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}