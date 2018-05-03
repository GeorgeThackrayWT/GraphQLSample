using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class ExternalDesignationDto : BaseDto, IRecord
    {
        public int DesignationTypeId { get; set; }

        public int DesignatorID { get; set; }

        public double Hectares { get; set; }

        public string SitePartDescription { get; set; }

        public string Comments { get; set; }

        public string DesignatedAreaName { get; set; }

        public string SSSICitation { get; set; }

        public string DesignationDescription { get; set; }

        public int AcquisitionUnitID { get; set; }

        public ExternalDesignationDto Clone()
        {
            return new ExternalDesignationDto()
            {
                DesignationTypeId = this.DesignationTypeId,
                DesignatorID = this.DesignatorID,
                Hectares = this.Hectares,
                SitePartDescription = this.SitePartDescription,
                Comments = this.Comments,
                DesignatedAreaName = this.DesignatedAreaName,
                SSSICitation = this.SSSICitation,
                DesignationDescription = this.DesignationDescription,
                AcquisitionUnitID = this.AcquisitionUnitID,
            };
        }//endofclonemethods
    }

    public class ExternalDesignationEdit : PropertyBase<ExternalDesignationEdit>, IDuplicate
    {

        private ExternalDesignationDto _dto;


        public ExternalDesignationEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> DesignationTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> DesignatorID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> Hectares { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<string> SitePartDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> DesignatedAreaName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> SSSICitation { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> DesignationDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> AcquisitionUnitID { get; set; } = new Property<int>() { Value = 0, Original = 0 };



        public int RecordId => Id.Value;


        public ExternalDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.DesignationTypeId = DesignationTypeId.Value;
            returnVal.DesignatorID = DesignatorID.Value;
            returnVal.Hectares = Hectares.Value;
            returnVal.SitePartDescription = SitePartDescription.Value;
            returnVal.Comments = Comments.Value;
            returnVal.DesignatedAreaName = DesignatedAreaName.Value;
            returnVal.SSSICitation = SSSICitation.Value;
            returnVal.DesignationDescription = DesignationDescription.Value;
            returnVal.AcquisitionUnitID = AcquisitionUnitID.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ExternalDesignationEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ExternalDesignationDto test)
        {
            this.DesignationTypeId = Property<int>.Make(test.DesignationTypeId);
            this.DesignatorID = Property<int>.Make(test.DesignatorID);
            this.Hectares = Property<double>.Make(test.Hectares);
            this.SitePartDescription = Property<string>.Make(test.SitePartDescription);
            this.Comments = Property<string>.Make(test.Comments);
            this.DesignatedAreaName = Property<string>.Make(test.DesignatedAreaName);
            this.SSSICitation = Property<string>.Make(test.SSSICitation);
            this.DesignationDescription = Property<string>.Make(test.DesignationDescription);
            this.AcquisitionUnitID = Property<int>.Make(test.AcquisitionUnitID);
            this.Id = Property<int>.Make(test.Id);

            this.SetPropChanged();

            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            DesignationTypeId.Revert();
            DesignatorID.Revert();
            Hectares.Revert();
            SitePartDescription.Revert();
            Comments.Revert();
            DesignatedAreaName.Revert();
            SSSICitation.Revert();
            DesignationDescription.Revert();
            AcquisitionUnitID.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<ExternalDesignationEdit> MakeCollection(List<ExternalDesignationDto> records)
        {

            var newData = new ExtRangeCollection<ExternalDesignationEdit>();

            foreach (var rec in records)
            {
                var e = new ExternalDesignationEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class ExternalDesignationEditList : ListObj<ExternalDesignationDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private ExternalDesignationDto _dto;


        public ExternalDesignationEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int DesignationTypeId { get => _current.DesignationTypeId; set { _current.DesignationTypeId = value; OnPropertyChanged(); } }

        public int DesignatorID { get => _current.DesignatorID; set { _current.DesignatorID = value; OnPropertyChanged(); } }

        public double Hectares { get => _current.Hectares; set { _current.Hectares = value; OnPropertyChanged(); } }

        public string SitePartDescription { get => _current.SitePartDescription; set { _current.SitePartDescription = value; OnPropertyChanged(); } }

        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }

        public string DesignatedAreaName { get => _current.DesignatedAreaName; set { _current.DesignatedAreaName = value; OnPropertyChanged(); } }

        public string SSSICitation { get => _current.SSSICitation; set { _current.SSSICitation = value; OnPropertyChanged(); } }

        public string DesignationDescription { get => _current.DesignationDescription; set { _current.DesignationDescription = value; OnPropertyChanged(); } }

        public int AcquisitionUnitID { get => _current.AcquisitionUnitID; set { _current.AcquisitionUnitID = value; OnPropertyChanged(); } }



        public int RecordId => Id;


        public ExternalDesignationDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.DesignationTypeId = this.DesignationTypeId;
            returnVal.DesignatorID = this.DesignatorID;
            returnVal.Hectares = this.Hectares;
            returnVal.SitePartDescription = this.SitePartDescription;
            returnVal.Comments = this.Comments;
            returnVal.DesignatedAreaName = this.DesignatedAreaName;
            returnVal.SSSICitation = this.SSSICitation;
            returnVal.DesignationDescription = this.DesignationDescription;
            returnVal.AcquisitionUnitID = this.AcquisitionUnitID;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (ExternalDesignationEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(ExternalDesignationDto test)
        {
            _original.DesignationTypeId = test.DesignationTypeId;
            _current.DesignationTypeId = test.DesignationTypeId;
            _original.DesignatorID = test.DesignatorID;
            _current.DesignatorID = test.DesignatorID;
            _original.Hectares = test.Hectares;
            _current.Hectares = test.Hectares;
            _original.SitePartDescription = test.SitePartDescription;
            _current.SitePartDescription = test.SitePartDescription;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.DesignatedAreaName = test.DesignatedAreaName;
            _current.DesignatedAreaName = test.DesignatedAreaName;
            _original.SSSICitation = test.SSSICitation;
            _current.SSSICitation = test.SSSICitation;
            _original.DesignationDescription = test.DesignationDescription;
            _current.DesignationDescription = test.DesignationDescription;
            _original.AcquisitionUnitID = test.AcquisitionUnitID;
            _current.AcquisitionUnitID = test.AcquisitionUnitID;
            _original.Id = test.Id;
            _current.Id = test.Id;
            SetPropChanged();  
            _dto = test; 
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<ExternalDesignationEditList> MakeCollection(List<ExternalDesignationDto> records)
        {

            var newData = new ExtRangeCollection<ExternalDesignationEditList>();

            foreach (var rec in records)
            {
                var e = new ExternalDesignationEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}