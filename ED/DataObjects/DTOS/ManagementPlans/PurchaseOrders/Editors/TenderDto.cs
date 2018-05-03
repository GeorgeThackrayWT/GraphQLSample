using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors
{
    public class TenderDto : BaseDto, IRecord
    {
        public int SupplierId { get; set; }

        public string SupplierRef { get; set; }

        public string Remarks { get; set; }

        public string TenderNumber { get; set; }

        public DateTime? DateCreated { get; set; }

        public int CreatedByUser { get; set; }

        public string CreatedByUserName { get; set; }

        public bool NettingOffPO { get; set; }

        public DateTime? ReturnedBy { get; set; }

        public int ReturnedTo { get; set; }

        public string ReturnedToName { get; set; }


        public double TotalForecastNet { get; set; }


        public double TotalForecastTotal { get; set; }

        public double PriceNet { get; set; }


        public double Total { get; set; }


        public double TenderTotal { get; set; }

        public double AuthorisationLimit { get; set; }




        public TenderDto Clone()
        {
            return new TenderDto()
            {
                SupplierId = this.SupplierId,
                SupplierRef = this.SupplierRef,
                Remarks = this.Remarks,
                TenderNumber = this.TenderNumber,
                DateCreated = this.DateCreated,
                CreatedByUser = this.CreatedByUser,
                NettingOffPO = this.NettingOffPO,
                ReturnedBy = this.ReturnedBy,
                ReturnedTo = this.ReturnedTo,
                TotalForecastNet = this.TotalForecastNet,
                TotalForecastTotal = this.TotalForecastTotal,
                PriceNet = this.PriceNet,
                Total = this.Total,
                TenderTotal = this.TenderTotal,
                AuthorisationLimit = this.AuthorisationLimit,
                CreatedByUserName = this.CreatedByUserName,
                ReturnedToName = this.ReturnedToName
            };
        }//endofclonemethods
    }

    public class TenderEdit : PropertyBase<TenderEdit>, IDuplicate
    {

        private TenderDto _dto;


        public TenderEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> SupplierId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> SupplierRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> Remarks { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> TenderNumber { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> DateCreated { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> CreatedByUser { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> CreatedByUserName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> NettingOffPO { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<DateTime?> ReturnedBy { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<int> ReturnedTo { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> ReturnedToName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<double> TotalForecastNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


        public Property<double> TotalForecastTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> PriceNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


        public Property<double> Total { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


        public Property<double> TenderTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> AuthorisationLimit { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };


       



        public int RecordId => Id.Value;


        public TenderDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SupplierId = SupplierId.Value;
            returnVal.Remarks = Remarks.Value;
            returnVal.TenderNumber = TenderNumber.Value;
            returnVal.DateCreated = DateCreated.Value;
            returnVal.CreatedByUser = CreatedByUser.Value;
            returnVal.CreatedByUserName = CreatedByUserName.Value;
            returnVal.NettingOffPO = NettingOffPO.Value;
            returnVal.ReturnedBy = ReturnedBy.Value;
            returnVal.ReturnedTo = ReturnedTo.Value;
            returnVal.TotalForecastNet = TotalForecastNet.Value;
            returnVal.TotalForecastTotal = TotalForecastTotal.Value;
            returnVal.PriceNet = PriceNet.Value;
            returnVal.Total = Total.Value;
            returnVal.TenderTotal = TenderTotal.Value;
            returnVal.AuthorisationLimit = AuthorisationLimit.Value;
            returnVal.Id = Id.Value;
            returnVal.SupplierRef = SupplierRef.Value;
            returnVal.ReturnedToName = ReturnedToName.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TenderEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TenderDto test)
        {
            this.SupplierId = Property<int>.Make(test.SupplierId);
            this.SupplierRef = Property<string>.Make(test.SupplierRef);
            this.Remarks = Property<string>.Make(test.Remarks);
            this.TenderNumber = Property<string>.Make(test.TenderNumber);
            this.DateCreated = Property<DateTime?>.Make(test.DateCreated);
            this.CreatedByUser = Property<int>.Make(test.CreatedByUser);
            this.CreatedByUserName = Property<string>.Make(test.CreatedByUserName);
            this.NettingOffPO = Property<bool>.Make(test.NettingOffPO);
            this.ReturnedBy = Property<DateTime?>.Make(test.ReturnedBy);
            this.ReturnedTo = Property<int>.Make(test.ReturnedTo);
            this.ReturnedToName = Property<string>.Make(test.ReturnedToName);
            this.TotalForecastNet = Property<double>.Make(test.TotalForecastNet);
            this.TotalForecastTotal = Property<double>.Make(test.TotalForecastTotal);
            this.PriceNet = Property<double>.Make(test.PriceNet);
            this.Total = Property<double>.Make(test.Total);
            this.TenderTotal = Property<double>.Make(test.TenderTotal);
            this.AuthorisationLimit = Property<double>.Make(test.AuthorisationLimit);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            SupplierId.Revert();
            SupplierRef.Revert();
            Remarks.Revert();
            TenderNumber.Revert();
            DateCreated.Revert();
            CreatedByUser.Revert();
            CreatedByUserName.Revert();
            NettingOffPO.Revert();
            ReturnedBy.Revert();
            ReturnedTo.Revert();
            TotalForecastNet.Revert();
            TotalForecastTotal.Revert();
            PriceNet.Revert();
            Total.Revert();
            TenderTotal.Revert();
            AuthorisationLimit.Revert();
            ReturnedToName.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TenderEdit> MakeCollection(List<TenderDto> records)
        {

            var newData = new ExtRangeCollection<TenderEdit>();

            foreach (var rec in records)
            {
                var e = new TenderEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class TenderEditList : ListObj<TenderDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TenderDto _dto;


        public TenderEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int SupplierId { get => _current.SupplierId; set { _current.SupplierId = value; OnPropertyChanged(); } }

        public string Remarks { get => _current.Remarks; set { _current.Remarks = value; OnPropertyChanged(); } }

        public string TenderNumber { get => _current.TenderNumber; set { _current.TenderNumber = value; OnPropertyChanged(); } }

        public DateTime? DateCreated { get => _current.DateCreated; set { _current.DateCreated = value; OnPropertyChanged(); } }

        public int CreatedByUser { get => _current.CreatedByUser; set { _current.CreatedByUser = value; OnPropertyChanged(); } }

        public bool NettingOffPO { get => _current.NettingOffPO; set { _current.NettingOffPO = value; OnPropertyChanged(); } }

        public DateTime? ReturnedBy { get => _current.ReturnedBy; set { _current.ReturnedBy = value; OnPropertyChanged(); } }

        public int ReturnedTo { get => _current.ReturnedTo; set { _current.ReturnedTo = value; OnPropertyChanged(); } }


        public double TotalForecastNet { get => _current.TotalForecastNet; set { _current.TotalForecastNet = value; OnPropertyChanged(); } }


        public double TotalForecastTotal { get => _current.TotalForecastTotal; set { _current.TotalForecastTotal = value; OnPropertyChanged(); } }

        public double PriceNet { get => _current.PriceNet; set { _current.PriceNet = value; OnPropertyChanged(); } }


        public double Total { get => _current.Total; set { _current.Total = value; OnPropertyChanged(); } }


        public double TenderTotal { get => _current.TenderTotal; set { _current.TenderTotal = value; OnPropertyChanged(); } }

        public double AuthorisationLimit { get => _current.AuthorisationLimit; set { _current.AuthorisationLimit = value; OnPropertyChanged(); } }






        public int RecordId => Id;


        public TenderDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.SupplierId = this.SupplierId;
            returnVal.Remarks = this.Remarks;
            returnVal.TenderNumber = this.TenderNumber;
            returnVal.DateCreated = this.DateCreated;
            returnVal.CreatedByUser = this.CreatedByUser;
            returnVal.NettingOffPO = this.NettingOffPO;
            returnVal.ReturnedBy = this.ReturnedBy;
            returnVal.ReturnedTo = this.ReturnedTo;
            returnVal.TotalForecastNet = this.TotalForecastNet;
            returnVal.TotalForecastTotal = this.TotalForecastTotal;
            returnVal.PriceNet = this.PriceNet;
            returnVal.Total = this.Total;
            returnVal.TenderTotal = this.TenderTotal;
            returnVal.AuthorisationLimit = this.AuthorisationLimit;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TenderEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TenderDto test)
        {
            _original.SupplierId = test.SupplierId;
            _current.SupplierId = test.SupplierId;
            _original.Remarks = test.Remarks;
            _current.Remarks = test.Remarks;
            _original.TenderNumber = test.TenderNumber;
            _current.TenderNumber = test.TenderNumber;
            _original.DateCreated = test.DateCreated;
            _current.DateCreated = test.DateCreated;
            _original.CreatedByUser = test.CreatedByUser;
            _current.CreatedByUser = test.CreatedByUser;
            _original.NettingOffPO = test.NettingOffPO;
            _current.NettingOffPO = test.NettingOffPO;
            _original.ReturnedBy = test.ReturnedBy;
            _current.ReturnedBy = test.ReturnedBy;
            _original.ReturnedTo = test.ReturnedTo;
            _current.ReturnedTo = test.ReturnedTo;
            _original.TotalForecastNet = test.TotalForecastNet;
            _current.TotalForecastNet = test.TotalForecastNet;
            _original.TotalForecastTotal = test.TotalForecastTotal;
            _current.TotalForecastTotal = test.TotalForecastTotal;
            _original.PriceNet = test.PriceNet;
            _current.PriceNet = test.PriceNet;
            _original.Total = test.Total;
            _current.Total = test.Total;
            _original.TenderTotal = test.TenderTotal;
            _current.TenderTotal = test.TenderTotal;
            _original.AuthorisationLimit = test.AuthorisationLimit;
            _current.AuthorisationLimit = test.AuthorisationLimit;
            _original.Id = test.Id;
            _current.Id = test.Id;
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<TenderEditList> MakeCollection(List<TenderDto> records)
        {

            var newData = new ExtRangeCollection<TenderEditList>();

            foreach (var rec in records)
            {
                var e = new TenderEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

}
