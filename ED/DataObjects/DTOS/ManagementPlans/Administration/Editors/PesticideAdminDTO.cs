using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using MvvmHelpers;

namespace DataObjects.DTOS.ManagementPlans.Administration.Editors
{
    public class PesticideAdminDto : BaseDto, IRecord
    {

        public int PesticideId { get; set; }

        public string ContractorName { get; set; }

        public string PurchaseOrderNo { get; set; }

        public string WoodNumber { get; set; }

        public string HowDisposed { get; set; }
        public string Comments { get; set; }

        public int TypeOfSite { get; set; }

        public int ReasonForUse { get; set; }

        public int TargetSpecies { get; set; }

        public string LocationInSite { get; set; }

        public string Product { get; set; }

        public double ConcentrationQuantityUsed { get; set; }

        public int ActiveIngredient { get; set; }

        public double ApplicationRate { get; set; }

        public int UnitId { get; set; }

        public int ApplicationMethodId { get; set; }

        public double NetAreaTreatedHa { get; set; }

        public int ApplicationTypeId { get; set; }

        public string WeatherConditions { get; set; }



        public PesticideAdminDto Clone()
        {
            return new PesticideAdminDto()
            {
                PesticideId = this.PesticideId,
                ContractorName = this.ContractorName,
                PurchaseOrderNo = this.PurchaseOrderNo,
                WoodNumber = this.WoodNumber,
                HowDisposed = this.HowDisposed,
                Comments = this.Comments,
                TypeOfSite = this.TypeOfSite,
                ReasonForUse = this.ReasonForUse,
                TargetSpecies = this.TargetSpecies,
                LocationInSite = this.LocationInSite,
                Product = this.Product,
                ConcentrationQuantityUsed = this.ConcentrationQuantityUsed,
                ActiveIngredient = this.ActiveIngredient,
                ApplicationRate = this.ApplicationRate,
                UnitId = this.UnitId,
                ApplicationMethodId = this.ApplicationMethodId,
                NetAreaTreatedHa = this.NetAreaTreatedHa,
                ApplicationTypeId = this.ApplicationTypeId,
                WeatherConditions = this.WeatherConditions,
            };
        }//endofclonemethods
    }

    public class PesticideAdminEdit : PropertyBase<PesticideAdminEdit>, IDuplicate
    {

        private PesticideAdminDto _dto;


        public PesticideAdminEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor


        public Property<int> PesticideId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> ContractorName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> PurchaseOrderNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> WoodNumber { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> HowDisposed { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };
        public Property<string> Comments { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> TypeOfSite { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> ReasonForUse { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TargetSpecies { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> LocationInSite { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Product { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> ConcentrationQuantityUsed { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> ActiveIngredient { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> ApplicationRate { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> UnitId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> ApplicationMethodId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> NetAreaTreatedHa { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> ApplicationTypeId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> WeatherConditions { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };





        public int RecordId => Id.Value;


        public PesticideAdminDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PesticideId = PesticideId.Value;
            returnVal.ContractorName = ContractorName.Value;
            returnVal.PurchaseOrderNo = PurchaseOrderNo.Value;
            returnVal.WoodNumber = WoodNumber.Value;
            returnVal.HowDisposed = HowDisposed.Value;
            returnVal.Comments = Comments.Value;
            returnVal.TypeOfSite = TypeOfSite.Value;
            returnVal.ReasonForUse = ReasonForUse.Value;
            returnVal.TargetSpecies = TargetSpecies.Value;
            returnVal.LocationInSite = LocationInSite.Value;
            returnVal.Product = Product.Value;
            returnVal.ConcentrationQuantityUsed = ConcentrationQuantityUsed.Value;
            returnVal.ActiveIngredient = ActiveIngredient.Value;
            returnVal.ApplicationRate = ApplicationRate.Value;
            returnVal.UnitId = UnitId.Value;
            returnVal.ApplicationMethodId = ApplicationMethodId.Value;
            returnVal.NetAreaTreatedHa = NetAreaTreatedHa.Value;
            returnVal.ApplicationTypeId = ApplicationTypeId.Value;
            returnVal.WeatherConditions = WeatherConditions.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PesticideAdminEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PesticideAdminDto test)
        {
            this.PesticideId = Property<int>.Make(test.PesticideId,PesticideId);
            this.ContractorName = Property<string>.Make(test.ContractorName,ContractorName);
            this.PurchaseOrderNo = Property<string>.Make(test.PurchaseOrderNo,PurchaseOrderNo);
            this.WoodNumber = Property<string>.Make(test.WoodNumber,WoodNumber);
            this.HowDisposed = Property<string>.Make(test.HowDisposed,HowDisposed);
            this.Comments = Property<string>.Make(test.Comments,Comments);
            this.TypeOfSite = Property<int>.Make(test.TypeOfSite,TypeOfSite);
            this.ReasonForUse = Property<int>.Make(test.ReasonForUse,ReasonForUse);
            this.TargetSpecies = Property<int>.Make(test.TargetSpecies,TargetSpecies);
            this.LocationInSite = Property<string>.Make(test.LocationInSite,LocationInSite);
            this.Product = Property<string>.Make(test.Product,Product);
            this.ConcentrationQuantityUsed = Property<double>.Make(test.ConcentrationQuantityUsed,ConcentrationQuantityUsed);
            this.ActiveIngredient = Property<int>.Make(test.ActiveIngredient,ActiveIngredient);
            this.ApplicationRate = Property<double>.Make(test.ApplicationRate,ApplicationRate);
            this.UnitId = Property<int>.Make(test.UnitId,UnitId);
            this.ApplicationMethodId = Property<int>.Make(test.ApplicationMethodId,ApplicationMethodId);
            this.NetAreaTreatedHa = Property<double>.Make(test.NetAreaTreatedHa,NetAreaTreatedHa);
            this.ApplicationTypeId = Property<int>.Make(test.ApplicationTypeId,ApplicationTypeId);
            this.WeatherConditions = Property<string>.Make(test.WeatherConditions,WeatherConditions);
            this.Id = Property<int>.Make(test.Id,Id);
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            PesticideId.Revert();
            ContractorName.Revert();
            PurchaseOrderNo.Revert();
            WoodNumber.Revert();
            HowDisposed.Revert();
            Comments.Revert();
            TypeOfSite.Revert();
            ReasonForUse.Revert();
            TargetSpecies.Revert();
            LocationInSite.Revert();
            Product.Revert();
            ConcentrationQuantityUsed.Revert();
            ActiveIngredient.Revert();
            ApplicationRate.Revert();
            UnitId.Revert();
            ApplicationMethodId.Revert();
            NetAreaTreatedHa.Revert();
            ApplicationTypeId.Revert();
            WeatherConditions.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<PesticideAdminEdit> MakeCollection(List<PesticideAdminDto> records)
        {

            var newData = new ExtRangeCollection<PesticideAdminEdit>();

            foreach (var rec in records)
            {
                var e = new PesticideAdminEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class PesticideAdminEditList : ListObj<PesticideAdminDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private PesticideAdminDto _dto;


        public PesticideAdminEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor


        public int PesticideId { get => _current.PesticideId; set { _current.PesticideId = value; OnPropertyChanged(); } }

        public string ContractorName { get => _current.ContractorName; set { _current.ContractorName = value; OnPropertyChanged(); } }

        public string PurchaseOrderNo { get => _current.PurchaseOrderNo; set { _current.PurchaseOrderNo = value; OnPropertyChanged(); } }

        public string WoodNumber { get => _current.WoodNumber; set { _current.WoodNumber = value; OnPropertyChanged(); } }

        public string HowDisposed { get => _current.HowDisposed; set { _current.HowDisposed = value; OnPropertyChanged(); } }
        public string Comments { get => _current.Comments; set { _current.Comments = value; OnPropertyChanged(); } }

        public int TypeOfSite { get => _current.TypeOfSite; set { _current.TypeOfSite = value; OnPropertyChanged(); } }

        public int ReasonForUse { get => _current.ReasonForUse; set { _current.ReasonForUse = value; OnPropertyChanged(); } }

        public int TargetSpecies { get => _current.TargetSpecies; set { _current.TargetSpecies = value; OnPropertyChanged(); } }

        public string LocationInSite { get => _current.LocationInSite; set { _current.LocationInSite = value; OnPropertyChanged(); } }

        public string Product { get => _current.Product; set { _current.Product = value; OnPropertyChanged(); } }

        public double ConcentrationQuantityUsed { get => _current.ConcentrationQuantityUsed; set { _current.ConcentrationQuantityUsed = value; OnPropertyChanged(); } }

        public int ActiveIngredient { get => _current.ActiveIngredient; set { _current.ActiveIngredient = value; OnPropertyChanged(); } }

        public double ApplicationRate { get => _current.ApplicationRate; set { _current.ApplicationRate = value; OnPropertyChanged(); } }

        public int UnitId { get => _current.UnitId; set { _current.UnitId = value; OnPropertyChanged(); } }

        public int ApplicationMethodId { get => _current.ApplicationMethodId; set { _current.ApplicationMethodId = value; OnPropertyChanged(); } }

        public double NetAreaTreatedHa { get => _current.NetAreaTreatedHa; set { _current.NetAreaTreatedHa = value; OnPropertyChanged(); } }

        public int ApplicationTypeId { get => _current.ApplicationTypeId; set { _current.ApplicationTypeId = value; OnPropertyChanged(); } }

        public string WeatherConditions { get => _current.WeatherConditions; set { _current.WeatherConditions = value; OnPropertyChanged(); } }





        public int RecordId => Id;


        public PesticideAdminDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.PesticideId = this.PesticideId;
            returnVal.ContractorName = this.ContractorName;
            returnVal.PurchaseOrderNo = this.PurchaseOrderNo;
            returnVal.WoodNumber = this.WoodNumber;
            returnVal.HowDisposed = this.HowDisposed;
            returnVal.Comments = this.Comments;
            returnVal.TypeOfSite = this.TypeOfSite;
            returnVal.ReasonForUse = this.ReasonForUse;
            returnVal.TargetSpecies = this.TargetSpecies;
            returnVal.LocationInSite = this.LocationInSite;
            returnVal.Product = this.Product;
            returnVal.ConcentrationQuantityUsed = this.ConcentrationQuantityUsed;
            returnVal.ActiveIngredient = this.ActiveIngredient;
            returnVal.ApplicationRate = this.ApplicationRate;
            returnVal.UnitId = this.UnitId;
            returnVal.ApplicationMethodId = this.ApplicationMethodId;
            returnVal.NetAreaTreatedHa = this.NetAreaTreatedHa;
            returnVal.ApplicationTypeId = this.ApplicationTypeId;
            returnVal.WeatherConditions = this.WeatherConditions;
            returnVal.Id = Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (PesticideAdminEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(PesticideAdminDto test)
        {
            _original.PesticideId = test.PesticideId;
            _current.PesticideId = test.PesticideId;
            _original.ContractorName = test.ContractorName;
            _current.ContractorName = test.ContractorName;
            _original.PurchaseOrderNo = test.PurchaseOrderNo;
            _current.PurchaseOrderNo = test.PurchaseOrderNo;
            _original.WoodNumber = test.WoodNumber;
            _current.WoodNumber = test.WoodNumber;
            _original.HowDisposed = test.HowDisposed;
            _current.HowDisposed = test.HowDisposed;
            _original.Comments = test.Comments;
            _current.Comments = test.Comments;
            _original.TypeOfSite = test.TypeOfSite;
            _current.TypeOfSite = test.TypeOfSite;
            _original.ReasonForUse = test.ReasonForUse;
            _current.ReasonForUse = test.ReasonForUse;
            _original.TargetSpecies = test.TargetSpecies;
            _current.TargetSpecies = test.TargetSpecies;
            _original.LocationInSite = test.LocationInSite;
            _current.LocationInSite = test.LocationInSite;
            _original.Product = test.Product;
            _current.Product = test.Product;
            _original.ConcentrationQuantityUsed = test.ConcentrationQuantityUsed;
            _current.ConcentrationQuantityUsed = test.ConcentrationQuantityUsed;
            _original.ActiveIngredient = test.ActiveIngredient;
            _current.ActiveIngredient = test.ActiveIngredient;
            _original.ApplicationRate = test.ApplicationRate;
            _current.ApplicationRate = test.ApplicationRate;
            _original.UnitId = test.UnitId;
            _current.UnitId = test.UnitId;
            _original.ApplicationMethodId = test.ApplicationMethodId;
            _current.ApplicationMethodId = test.ApplicationMethodId;
            _original.NetAreaTreatedHa = test.NetAreaTreatedHa;
            _current.NetAreaTreatedHa = test.NetAreaTreatedHa;
            _original.ApplicationTypeId = test.ApplicationTypeId;
            _current.ApplicationTypeId = test.ApplicationTypeId;
            _original.WeatherConditions = test.WeatherConditions;
            _current.WeatherConditions = test.WeatherConditions;
            _original.Id = test.Id;
            _current.Id = test.Id;
            this.SetPropChanged();
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<PesticideAdminEditList> MakeCollection(List<PesticideAdminDto> records)
        {

            var newData = new ExtRangeCollection<PesticideAdminEditList>();

            foreach (var rec in records)
            {
                var e = new PesticideAdminEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}
