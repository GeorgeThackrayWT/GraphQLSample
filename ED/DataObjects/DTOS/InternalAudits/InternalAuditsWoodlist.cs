using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS.InternalAudits
{
    public class InternalAuditsWoodlist : BaseDto, IRecord
    {
        public int AcquisitionUnitID { get; set; }
        public int WoodNumber { get; set; }
        public int CostCentre { get; set; }
        public string WoodName { get; set; }
        public InternalAuditsWoodlist Clone()
        {
            return new InternalAuditsWoodlist()
            {
                AcquisitionUnitID = this.AcquisitionUnitID,
                WoodNumber = this.WoodNumber,
                CostCentre = this.CostCentre,
            };
        }//endofclonemethods
    }

    public class InternalAuditsWoodlistEdit : PropertyBase<InternalAuditsWoodlistEdit>, IDuplicate
    {

        private InternalAuditsWoodlist _dto;


        public InternalAuditsWoodlistEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor


        public Property<int> AcquisitionUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> WoodNumber { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> CostCentre { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public string WoodName { get; set; }



        public int RecordId => Id.Value;


        public InternalAuditsWoodlist ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionUnitID = AcquisitionUnitID.Value;
            returnVal.WoodNumber = WoodNumber.Value;
            returnVal.CostCentre = CostCentre.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsWoodlistEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsWoodlist test)
        {
            this.AcquisitionUnitID = Property<int>.Make(test.AcquisitionUnitID);
            this.WoodNumber = Property<int>.Make(test.WoodNumber);
            this.CostCentre = Property<int>.Make(test.CostCentre);
            this.Id = Property<int>.Make(test.Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            AcquisitionUnitID.Revert();
            WoodNumber.Revert();
            CostCentre.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsWoodlistEdit> MakeCollection(List<InternalAuditsWoodlist> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsWoodlistEdit>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsWoodlistEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class InternalAuditsWoodlistEditList : ListObj<InternalAuditsWoodlist>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private InternalAuditsWoodlist _dto;


        public InternalAuditsWoodlistEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public int AcquisitionUnitID { get => _current.AcquisitionUnitID; set { _current.AcquisitionUnitID = value; OnPropertyChanged(); } }

        public int WoodNumber { get => _current.WoodNumber; set { _current.WoodNumber = value; OnPropertyChanged(); } }

        public int CostCentre { get => _current.CostCentre; set { _current.CostCentre = value; OnPropertyChanged(); } }

        public string WoodName { get; set; }



        public int RecordId => Id;


        public InternalAuditsWoodlist ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.AcquisitionUnitID = this.AcquisitionUnitID;
            returnVal.WoodNumber = this.WoodNumber;
            returnVal.CostCentre = this.CostCentre;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (InternalAuditsWoodlistEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(InternalAuditsWoodlist test)
        {
            _original.AcquisitionUnitID = test.AcquisitionUnitID;
            _current.AcquisitionUnitID = test.AcquisitionUnitID;
            _original.WoodNumber = test.WoodNumber;
            _current.WoodNumber = test.WoodNumber;
            _original.CostCentre = test.CostCentre;
            _current.CostCentre = test.CostCentre;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            _dto = test;

        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<InternalAuditsWoodlistEditList> MakeCollection(List<InternalAuditsWoodlist> records)
        {

            var newData = new ExtRangeCollection<InternalAuditsWoodlistEditList>();

            foreach (var rec in records)
            {
                var e = new InternalAuditsWoodlistEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}
