using Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataObjects.DTOS.ManagementPlans.Editors
{
    public class HarvestingEditDTO : BaseDto, IRecord
    {
    //    public int Id { get; set; }

        public ComboBoxValue TypeID { get; set; }


        public int ManagementUnitID { get; set; }

        public ComboBoxValue SubCompartmentID { get; set; }

        public double WorkAreaInHectares { get; set; }

        public double EstimatedAmount { get; set; }

        public double ActualAmount { get; set; }

        public ComboBoxValue ForecastYear { get; set; }

        public DateTime? CompletionDate { get; set; }

        public string Comments { get; set; }

        public double VolumeHa { get; set; }

        public bool m3 { get; set; }

        public bool t { get; set; }

        public HarvestingEditDTO Clone()
        {
            return new HarvestingEditDTO()
            {
                Id = this.Id,
                TypeID = this.TypeID,
                ManagementUnitID = this.ManagementUnitID,
                SubCompartmentID = this.SubCompartmentID,
                WorkAreaInHectares = this.WorkAreaInHectares,
                EstimatedAmount = this.EstimatedAmount,
                ActualAmount = this.ActualAmount,
                ForecastYear = this.ForecastYear,
                CompletionDate = this.CompletionDate,
                Comments = this.Comments,
                VolumeHa = this.VolumeHa,
                m3 = this.m3,
                t = this.t,
            };
        }//endofclonemethods
    }

    public class HarvestingEditDTOEdit : PropertyBase<HarvestingEditDTOEdit>, IDuplicate
    {

        private HarvestingEditDTO _dto;


      public HarvestingEditDTOEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> TypeID { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };


        public Property<int> ManagementUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<ComboBoxValue> SubCompartmentID { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<double> WorkAreaInHectares { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> EstimatedAmount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> ActualAmount { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<ComboBoxValue> ForecastYear { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };

        public Property<DateTime?> CompletionDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> VolumeHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<bool> m3 { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> t { get; set; } = new Property<bool>() { Value = false, Original = false };



        public int RecordId => Id.Value;


        public HarvestingEditDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = Id.Value;
            returnVal.TypeID = TypeID.Value;
            returnVal.ManagementUnitID = ManagementUnitID.Value;
            returnVal.SubCompartmentID = SubCompartmentID.Value;
            returnVal.WorkAreaInHectares = WorkAreaInHectares.Value;
            returnVal.EstimatedAmount = EstimatedAmount.Value;
            returnVal.ActualAmount = ActualAmount.Value;
            returnVal.ForecastYear = ForecastYear.Value;
            returnVal.CompletionDate = CompletionDate.Value;
            returnVal.Comments = Comments.Value;
            returnVal.VolumeHa = VolumeHa.Value;
            returnVal.m3 = m3.Value;
            returnVal.t = t.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HarvestingEditDTOEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HarvestingEditDTO test)
        {
            this.Id = Property<int>.Make(test.Id,Id);
            this.TypeID = Property<ComboBoxValue>.Make(test.TypeID,TypeID);
            this.ManagementUnitID = Property<int>.Make(test.ManagementUnitID,ManagementUnitID);
            this.SubCompartmentID = Property<ComboBoxValue>.Make(test.SubCompartmentID,SubCompartmentID);
            this.WorkAreaInHectares = Property<double>.Make(test.WorkAreaInHectares,WorkAreaInHectares);
            this.EstimatedAmount = Property<double>.Make(test.EstimatedAmount,EstimatedAmount);
            this.ActualAmount = Property<double>.Make(test.ActualAmount,ActualAmount);
            this.ForecastYear = Property<ComboBoxValue>.Make(test.ForecastYear,ForecastYear);
            this.CompletionDate = Property<DateTime?>.Make(test.CompletionDate,CompletionDate);
            this.Comments = Property<string>.Make(test.Comments,Comments);
            this.VolumeHa = Property<double>.Make(test.VolumeHa,VolumeHa);
            this.m3 = Property<bool>.Make(test.m3,m3);
            this.t = Property<bool>.Make(test.t,t);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            Id.Revert();
            TypeID.Revert();
            ManagementUnitID.Revert();
            SubCompartmentID.Revert();
            WorkAreaInHectares.Revert();
            EstimatedAmount.Revert();
            ActualAmount.Revert();
            ForecastYear.Revert();
            CompletionDate.Revert();
            Comments.Revert();
            VolumeHa.Revert();
            m3.Revert();
            t.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<HarvestingEditDTOEdit> MakeCollection(List<HarvestingEditDTO> records)
        {

            var newData = new ExtRangeCollection<HarvestingEditDTOEdit>();

            foreach (var rec in records)
            {
                var e = new HarvestingEditDTOEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class HarvestingEditDTOEditList : ListObj<HarvestingEditDTO>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private HarvestingEditDTO _dto;


      public HarvestingEditDTOEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public ComboBoxValue TypeID { get => _current.TypeID; set { _current.TypeID = value; OnPropertyChanged(); } }


        public int ManagementUnitID { get => _current.ManagementUnitID; set { _current.ManagementUnitID = value; OnPropertyChanged(); } }

        public ComboBoxValue SubCompartmentID { get => _current.SubCompartmentID; set { _current.SubCompartmentID = value; OnPropertyChanged(); } }

        public double WorkAreaInHectares { get => _current.WorkAreaInHectares; set { _current.WorkAreaInHectares = value; OnPropertyChanged(); } }

        public double EstimatedAmount { get => _current.EstimatedAmount; set { _current.EstimatedAmount = value; OnPropertyChanged(); } }

        public double ActualAmount { get => _current.ActualAmount; set { _current.ActualAmount = value; OnPropertyChanged(); } }

        public ComboBoxValue ForecastYear { get => _current.ForecastYear; set { _current.ForecastYear = value; OnPropertyChanged(); } }

        public DateTime? CompletionDate { get => _current.CompletionDate; set { _current.CompletionDate = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }

        public double VolumeHa { get => _current.VolumeHa; set { _current.VolumeHa = value; OnPropertyChanged(); } }

        public bool m3 { get => _current.m3; set { _current.m3 = value; OnPropertyChanged(); } }

        public bool t { get => _current.t; set { _current.t = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public HarvestingEditDTO ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.Id = this.Id;
            returnVal.TypeID = this.TypeID;
            returnVal.ManagementUnitID = this.ManagementUnitID;
            returnVal.SubCompartmentID = this.SubCompartmentID;
            returnVal.WorkAreaInHectares = this.WorkAreaInHectares;
            returnVal.EstimatedAmount = this.EstimatedAmount;
            returnVal.ActualAmount = this.ActualAmount;
            returnVal.ForecastYear = this.ForecastYear;
            returnVal.CompletionDate = this.CompletionDate;
            returnVal.Comments = this.Comments;
            returnVal.VolumeHa = this.VolumeHa;
            returnVal.m3 = this.m3;
            returnVal.t = this.t;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (HarvestingEditDTOEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(HarvestingEditDTO test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.TypeID = test.TypeID;
            _current.TypeID = test.TypeID;
            _original.ManagementUnitID = test.ManagementUnitID;
            _current.ManagementUnitID = test.ManagementUnitID;
            _original.SubCompartmentID = test.SubCompartmentID;
            _current.SubCompartmentID = test.SubCompartmentID;
            _original.WorkAreaInHectares = test.WorkAreaInHectares;
            _current.WorkAreaInHectares = test.WorkAreaInHectares;
            _original.EstimatedAmount = test.EstimatedAmount;
            _current.EstimatedAmount = test.EstimatedAmount;
            _original.ActualAmount = test.ActualAmount;
            _current.ActualAmount = test.ActualAmount;
            _original.ForecastYear = test.ForecastYear;
            _current.ForecastYear = test.ForecastYear;
            _original.CompletionDate = test.CompletionDate;
            _current.CompletionDate = test.CompletionDate;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.VolumeHa = test.VolumeHa;
            _current.VolumeHa = test.VolumeHa;
            _original.m3 = test.m3;
            _current.m3 = test.m3;
            _original.t = test.t;
            _current.t = test.t;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<HarvestingEditDTOEditList> MakeCollection(List<HarvestingEditDTO> records)
        {

            var newData = new ExtRangeCollection<HarvestingEditDTOEditList>();

            foreach (var rec in records)
            {
                var e = new HarvestingEditDTOEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}