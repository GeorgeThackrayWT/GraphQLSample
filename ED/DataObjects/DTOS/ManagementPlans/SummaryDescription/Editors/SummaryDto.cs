
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.lookups;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class SummaryDto : BaseDto, IRecord
    {
        public SummaryDto()
        {
            ManagementUnitId = 0;
            SubCompartmentID = 0;
            Compartment = 0;
            SubCompartmentRef = "";
            AreaHa = 0.0;
            Year = 2017;
            CompartmentDescription = "";
        }

        public int ManagementUnitId { get; set; }
        public int SubCompartmentID { get; set; }//links to management constraints , conservation features, designations
        public int Compartment { get; set; }
        public string SubCompartmentRef { get; set; }
        public double AreaHa { get; set; }
        public int Year { get; set; }
        public ComboBoxValue YearLookup { get; set; }
        public int MainSpeciesID { get; set; }
        public ComboBoxValue MainSpecies { get; set; }
        public int SecondarySpeciesID { get; set; }
        public ComboBoxValue SecondarySpecies { get; set; }
        public int ManagementRegimeID { get; set; }
        public ComboBoxValue ManagementRegime { get; set; }
        public string CompartmentDescription { get; set; }
        public SummaryDto Clone()
        {
            return new SummaryDto()
            {
                ManagementUnitId = this.ManagementUnitId,
                SubCompartmentID = this.SubCompartmentID,
                Compartment = this.Compartment,
                SubCompartmentRef = this.SubCompartmentRef,
                AreaHa = this.AreaHa,
                Year = this.Year,
                YearLookup = this.YearLookup,
                MainSpeciesID = this.MainSpeciesID,
                MainSpecies = this.MainSpecies,
                SecondarySpeciesID = this.SecondarySpeciesID,
                SecondarySpecies = this.SecondarySpecies,
                ManagementRegimeID = this.ManagementRegimeID,
                ManagementRegime = this.ManagementRegime,
                CompartmentDescription = this.CompartmentDescription,
            };
        }//endofclonemethods
    }

    public class SummaryEdit : PropertyBase<SummaryEdit>, IDuplicate
    {

       private SummaryDto _dto;
        
       public SummaryEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> SubCompartmentID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> Compartment { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<string> SubCompartmentRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<double> AreaHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<int> Year { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> YearLookup { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };
        public Property<int> MainSpeciesID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> MainSpecies { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };
        public Property<int> SecondarySpeciesID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> SecondarySpecies { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };
        public Property<int> ManagementRegimeID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<ComboBoxValue> ManagementRegime { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };
        public Property<string> CompartmentDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public int RecordId => Id.Value;


        public SummaryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = ManagementUnitId.Value;
            returnVal.SubCompartmentID = SubCompartmentID.Value;
            returnVal.Compartment = Compartment.Value;
            returnVal.SubCompartmentRef = SubCompartmentRef.Value;
            returnVal.AreaHa = AreaHa.Value;
            returnVal.Year = Year.Value;
            returnVal.YearLookup = YearLookup.Value;
            returnVal.MainSpeciesID = MainSpeciesID.Value;
            returnVal.MainSpecies = MainSpecies.Value;
            returnVal.SecondarySpeciesID = SecondarySpeciesID.Value;
            returnVal.SecondarySpecies = SecondarySpecies.Value;
            returnVal.ManagementRegimeID = ManagementRegimeID.Value;
            returnVal.ManagementRegime = ManagementRegime.Value;
            returnVal.CompartmentDescription = CompartmentDescription.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryDto test)
        {
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId,ManagementUnitId);
            this.SubCompartmentID = Property<int>.Make(test.SubCompartmentID,SubCompartmentID);
            this.Compartment = Property<int>.Make(test.Compartment,Compartment);
            this.SubCompartmentRef = Property<string>.Make(test.SubCompartmentRef,SubCompartmentRef);
            this.AreaHa = Property<double>.Make(test.AreaHa,AreaHa);
            this.Year = Property<int>.Make(test.Year,Year);
            this.YearLookup = Property<ComboBoxValue>.Make(test.YearLookup,YearLookup);
            this.MainSpeciesID = Property<int>.Make(test.MainSpeciesID,MainSpeciesID);
            this.MainSpecies = Property<ComboBoxValue>.Make(test.MainSpecies,MainSpecies);
            this.SecondarySpeciesID = Property<int>.Make(test.SecondarySpeciesID,SecondarySpeciesID);
            this.SecondarySpecies = Property<ComboBoxValue>.Make(test.SecondarySpecies,SecondarySpecies);
            this.ManagementRegimeID = Property<int>.Make(test.ManagementRegimeID,ManagementRegimeID);
            this.ManagementRegime = Property<ComboBoxValue>.Make(test.ManagementRegime,ManagementRegime);
            this.CompartmentDescription = Property<string>.Make(test.CompartmentDescription,CompartmentDescription);
            this.Id = Property<int>.Make(test.Id,Id);
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitId.Revert();
            SubCompartmentID.Revert();
            Compartment.Revert();
            SubCompartmentRef.Revert();
            AreaHa.Revert();
            Year.Revert();
            YearLookup.Revert();
            MainSpeciesID.Revert();
            MainSpecies.Revert();
            SecondarySpeciesID.Revert();
            SecondarySpecies.Revert();
            ManagementRegimeID.Revert();
            ManagementRegime.Revert();
            CompartmentDescription.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<SummaryEdit> MakeCollection(List<SummaryDto> records)
        {

            var newData = new ExtRangeCollection<SummaryEdit>();

            foreach (var rec in records)
            {
                var e = new SummaryEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class SummaryEditList : ListObj<SummaryDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private SummaryDto _dto;


        public SummaryEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }
        public int SubCompartmentID { get => _current.SubCompartmentID; set { _current.SubCompartmentID = value; OnPropertyChanged(); } }
        public int Compartment { get => _current.Compartment; set { _current.Compartment = value; OnPropertyChanged(); } }
        public string SubCompartmentRef { get => _current.SubCompartmentRef; set { _current.SubCompartmentRef = value; OnPropertyChanged(); } }
        public double AreaHa { get => _current.AreaHa; set { _current.AreaHa = value; OnPropertyChanged(); } }
        public int Year { get => _current.Year; set { _current.Year = value; OnPropertyChanged(); } }
        public ComboBoxValue YearLookup { get => _current.YearLookup; set { _current.YearLookup = value; OnPropertyChanged(); } }
        public int MainSpeciesID { get => _current.MainSpeciesID; set { _current.MainSpeciesID = value; OnPropertyChanged(); } }
        public ComboBoxValue MainSpecies { get => _current.MainSpecies; set { _current.MainSpecies = value; OnPropertyChanged(); } }
        public int SecondarySpeciesID { get => _current.SecondarySpeciesID; set { _current.SecondarySpeciesID = value; OnPropertyChanged(); } }
        public ComboBoxValue SecondarySpecies { get => _current.SecondarySpecies; set { _current.SecondarySpecies = value; OnPropertyChanged(); } }
        public int ManagementRegimeID { get => _current.ManagementRegimeID; set { _current.ManagementRegimeID = value; OnPropertyChanged(); } }
        public ComboBoxValue ManagementRegime { get => _current.ManagementRegime; set { _current.ManagementRegime = value; OnPropertyChanged(); } }
        public string CompartmentDescription { get => _current.CompartmentDescription; set { _current.CompartmentDescription = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public SummaryDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = this.ManagementUnitId;
            returnVal.SubCompartmentID = this.SubCompartmentID;
            returnVal.Compartment = this.Compartment;
            returnVal.SubCompartmentRef = this.SubCompartmentRef;
            returnVal.AreaHa = this.AreaHa;
            returnVal.Year = this.Year;
            returnVal.YearLookup = this.YearLookup;
            returnVal.MainSpeciesID = this.MainSpeciesID;
            returnVal.MainSpecies = this.MainSpecies;
            returnVal.SecondarySpeciesID = this.SecondarySpeciesID;
            returnVal.SecondarySpecies = this.SecondarySpecies;
            returnVal.ManagementRegimeID = this.ManagementRegimeID;
            returnVal.ManagementRegime = this.ManagementRegime;
            returnVal.CompartmentDescription = this.CompartmentDescription;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (SummaryEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(SummaryDto test)
        {
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.SubCompartmentID = test.SubCompartmentID;
            _current.SubCompartmentID = test.SubCompartmentID;
            _original.Compartment = test.Compartment;
            _current.Compartment = test.Compartment;
            _original.SubCompartmentRef = test.SubCompartmentRef;
            _current.SubCompartmentRef = test.SubCompartmentRef;
            _original.AreaHa = test.AreaHa;
            _current.AreaHa = test.AreaHa;
            _original.Year = test.Year;
            _current.Year = test.Year;
            _original.YearLookup = test.YearLookup;
            _current.YearLookup = test.YearLookup;
            _original.MainSpeciesID = test.MainSpeciesID;
            _current.MainSpeciesID = test.MainSpeciesID;
            _original.MainSpecies = test.MainSpecies;
            _current.MainSpecies = test.MainSpecies;
            _original.SecondarySpeciesID = test.SecondarySpeciesID;
            _current.SecondarySpeciesID = test.SecondarySpeciesID;
            _original.SecondarySpecies = test.SecondarySpecies;
            _current.SecondarySpecies = test.SecondarySpecies;
            _original.ManagementRegimeID = test.ManagementRegimeID;
            _current.ManagementRegimeID = test.ManagementRegimeID;
            _original.ManagementRegime = test.ManagementRegime;
            _current.ManagementRegime = test.ManagementRegime;
            _original.CompartmentDescription = test.CompartmentDescription;
            _current.CompartmentDescription = test.CompartmentDescription;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<SummaryEditList> MakeCollection(List<SummaryDto> records)
        {

            var newData = new ExtRangeCollection<SummaryEditList>();

            foreach (var rec in records)
            {
                var e = new SummaryEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass


}