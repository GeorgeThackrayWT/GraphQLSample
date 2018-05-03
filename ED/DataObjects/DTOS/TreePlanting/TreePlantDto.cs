using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using Abstractions;
using System.ComponentModel;

namespace DataObjects.DTOS.TreePlanting
{
    public class TreePlantDto : BaseDto, IRecord
    {
        public SubCompartmentLookupDto SubCompartmentID { get; set; }

        public DateTime? PlantingDate { get; set; }

        public bool Completed { get; set; }

        public double AreaHa { get; set; }

        public ComboBoxValue PlantingTypeID { get; set; }

        public ComboBoxValue PlantedByID { get; set; }

        public double WCAreaHa { get; set; }

        public bool SuitableToBeSold { get; set; }

        public TreePlantDto Clone()
        {
            return new TreePlantDto()
            {
                PlantingDate = this.PlantingDate,
                Completed = this.Completed,
                AreaHa = this.AreaHa,
                PlantingTypeID = this.PlantingTypeID,
                PlantedByID = this.PlantedByID,
                WCAreaHa = this.WCAreaHa,
                SuitableToBeSold = this.SuitableToBeSold,
            };
        }//endofclonemethods
    }

    public class TreePlantEdit : PropertyBase<TreePlantEdit>, IDuplicate
    {

        private TreePlantDto _dto;


        public TreePlantEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public SubCompartmentLookupDto SubCompartmentID { get; set; }

        public Property<DateTime?> PlantingDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> Completed { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<double> AreaHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<ComboBoxValue> PlantingTypeID { get; set; } = new Property<ComboBoxValue>() {
            Value = new ComboBoxValue()
            {
                ID = 0,
                Description = "Not Set",
                Name = "Not Set"
            },
            Original = new ComboBoxValue()
            {
                ID = 0,
                Description = "Not Set",
                Name = "Not Set"
            }
        };

        public Property<ComboBoxValue> PlantedByID { get; set; } = new Property<ComboBoxValue>()
        {
            Value = new ComboBoxValue()
            {
                ID = 0,
                Description = "Not Set",
                Name = "Not Set"
            },
            Original = new ComboBoxValue()
            {
                ID = 0,
                Description = "Not Set",
                Name = "Not Set"
            }
        };

        public Property<double> WCAreaHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<bool> SuitableToBeSold { get; set; } = new Property<bool>() { Value = false, Original = false };



        public int RecordId => Id.Value;


        public TreePlantDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PlantingDate = PlantingDate.Value;
            returnVal.Completed = Completed.Value;
            returnVal.AreaHa = AreaHa.Value;
            returnVal.PlantingTypeID = PlantingTypeID.Value;
            returnVal.PlantedByID = PlantedByID.Value;
            returnVal.WCAreaHa = WCAreaHa.Value;
            returnVal.SuitableToBeSold = SuitableToBeSold.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantDto test)
        {
            this.PlantingDate = Property<DateTime?>.Make(test.PlantingDate);
            this.Completed = Property<bool>.Make(test.Completed);
            this.AreaHa = Property<double>.Make(test.AreaHa);
            this.PlantingTypeID = Property<ComboBoxValue>.Make(test.PlantingTypeID);
            this.PlantedByID = Property<ComboBoxValue>.Make(test.PlantedByID);
            this.WCAreaHa = Property<double>.Make(test.WCAreaHa);
            this.SuitableToBeSold = Property<bool>.Make(test.SuitableToBeSold);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            PlantingDate.Revert();
            Completed.Revert();
            AreaHa.Revert();
            PlantingTypeID.Revert();
            PlantedByID.Revert();
            WCAreaHa.Revert();
            SuitableToBeSold.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantEdit> MakeCollection(List<TreePlantDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantEdit>();

            foreach (var rec in records)
            {
                var e = new TreePlantEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class TreePlantEditList : ListObj<TreePlantDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TreePlantDto _dto;


        public TreePlantEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public SubCompartmentLookupDto SubCompartmentID { get => _current.SubCompartmentID; set { _current.SubCompartmentID = value; OnPropertyChanged(); } }

        public DateTime? PlantingDate { get => _current.PlantingDate; set { _current.PlantingDate = value; OnPropertyChanged(); } }

        public bool Completed { get => _current.Completed; set { _current.Completed = value; OnPropertyChanged(); } }

        public double AreaHa { get => _current.AreaHa; set { _current.AreaHa = value; OnPropertyChanged(); } }

        public ComboBoxValue PlantingTypeID { get => _current.PlantingTypeID; set { _current.PlantingTypeID = value; OnPropertyChanged(); } }

        public ComboBoxValue PlantedByID { get => _current.PlantedByID; set { _current.PlantedByID = value; OnPropertyChanged(); } }

        public double WCAreaHa { get => _current.WCAreaHa; set { _current.WCAreaHa = value; OnPropertyChanged(); } }

        public bool SuitableToBeSold { get => _current.SuitableToBeSold; set { _current.SuitableToBeSold = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public TreePlantDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PlantingDate = this.PlantingDate;
            returnVal.Completed = this.Completed;
            returnVal.AreaHa = this.AreaHa;
            returnVal.PlantingTypeID = this.PlantingTypeID;
            returnVal.PlantedByID = this.PlantedByID;
            returnVal.WCAreaHa = this.WCAreaHa;
            returnVal.SuitableToBeSold = this.SuitableToBeSold;
            returnVal.SubCompartmentID = this.SubCompartmentID;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TreePlantEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TreePlantDto test)
        {
            _original.PlantingDate = test.PlantingDate;
            _current.PlantingDate = test.PlantingDate;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;
            _original.AreaHa = test.AreaHa;
            _current.AreaHa = test.AreaHa;
            _original.PlantingTypeID = test.PlantingTypeID;
            _current.PlantingTypeID = test.PlantingTypeID;
            _original.PlantedByID = test.PlantedByID;
            _current.PlantedByID = test.PlantedByID;
            _original.WCAreaHa = test.WCAreaHa;
            _current.WCAreaHa = test.WCAreaHa;
            _original.SuitableToBeSold = test.SuitableToBeSold;
            _current.SuitableToBeSold = test.SuitableToBeSold;
            _original.SubCompartmentID = test.SubCompartmentID;
            _current.SubCompartmentID = test.SubCompartmentID;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<TreePlantEditList> MakeCollection(List<TreePlantDto> records)
        {

            var newData = new ExtRangeCollection<TreePlantEditList>();

            foreach (var rec in records)
            {
                var e = new TreePlantEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}