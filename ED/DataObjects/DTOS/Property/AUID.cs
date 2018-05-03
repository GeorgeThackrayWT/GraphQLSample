using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects.DTOS
{
    public class AUID : BaseDto, IRecord
    {
        public int ManagementUnitId { get; set; }
        public string Name { get; set; }
        public int ManagedById { get; set; }
        public bool NewRecord { get; set; }

        public PropertyGeneralDetailsEdit PropertyGeneralDetails { get; set; }

        public PropertyLegalTitleEdit PropertyLegalTitle { get; set; }

        public PropertyFarmingEdit PropertyFarming { get; set; }

        public MainSectionEdit AcquisitionMainSection { get; set; }


        public AUID Clone()
        {
            return new AUID()
            {
                ManagementUnitId = this.ManagementUnitId,           
                Name = this.Name,              
                ManagedById = this.ManagedById,
                NewRecord = this.NewRecord,

                PropertyGeneralDetails = this.PropertyGeneralDetails,
                PropertyLegalTitle = this.PropertyLegalTitle,
                PropertyFarming = this.PropertyFarming,
                AcquisitionMainSection = this.AcquisitionMainSection,

            };
        }//endofclonemethods
    }

    public class AUIDEdit : PropertyBase<AUIDEdit>, IDuplicate
    {

        private AUID _dto;

        public string ModelTag { get; set; }

        public AUIDEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };   
        public Property<string> Name { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };      
        public Property<int> ManagedById { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<bool> NewRecord { get; set; } = new Property<bool>() { Value = false, Original = false };

        public PropertyGeneralDetailsEdit PropertyGeneralDetails { get; set; }
        public PropertyLegalTitleEdit PropertyLegalTitle { get; set; }
        public PropertyFarmingEdit PropertyFarming { get; set; }
        public MainSectionEdit AcquisitionMainSection { get; set; }



        public int RecordId => Id.Value;


        public AUID ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ManagementUnitId = ManagementUnitId.Value;

            returnVal.Name = Name.Value;
         
            returnVal.ManagedById = ManagedById.Value;
            returnVal.NewRecord = NewRecord.Value;
            returnVal.Id = Id.Value;

            returnVal.PropertyGeneralDetails = PropertyGeneralDetails;
            returnVal.PropertyLegalTitle = PropertyLegalTitle;
            returnVal.PropertyFarming = PropertyFarming;
            returnVal.AcquisitionMainSection = AcquisitionMainSection;


            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (AUIDEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(AUID test)
        {
            this.ManagementUnitId = Property<int>.Make(test.ManagementUnitId);
      
            this.Name = Property<string>.Make(test.Name);
      
            this.ManagedById = Property<int>.Make(test.ManagedById);
            this.NewRecord = Property<bool>.Make(test.NewRecord);
            this.Id = Property<int>.Make(test.Id);

            this.PropertyGeneralDetails = test.PropertyGeneralDetails;
            this.PropertyLegalTitle = test.PropertyLegalTitle;
            this.PropertyFarming = test.PropertyFarming;
            this.AcquisitionMainSection = test.AcquisitionMainSection;



            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ManagementUnitId.Revert();
       
            Name.Revert();
        
            ManagedById.Revert();
            NewRecord.Revert();



        }//endofResetChanges


        public static ExtRangeCollection<AUIDEdit> MakeCollection(List<AUID> records)
        {

            var newData = new ExtRangeCollection<AUIDEdit>();

            foreach (var rec in records)
            {
                var e = new AUIDEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

  
}