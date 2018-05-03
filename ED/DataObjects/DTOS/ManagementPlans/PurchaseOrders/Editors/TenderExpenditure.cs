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
    public class TenderExpenditureDto : BaseDto, IRecord
    {
        public int ExpenditureId { get; set; }

        public string SiteName { get; set; }

        public int WorkOrderId { get; set; }

        public string WorkOrder { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public double ForecastNet { get; set; }

        public double ForecastTotal { get; set; }

        public double TenderPriceNet { get; set; }

        public double Total { get; set; }

        public string Description { get; set; }

        public string SpecRef { get; set; }

        public ComboBoxValue VatRate { get; set; }

        public TenderExpenditureDto Clone()
        {
            return new TenderExpenditureDto()
            {
                VatRate = this.VatRate,
                ExpenditureId = this.ExpenditureId,
                SiteName = this.SiteName,
                WorkOrderId = this.WorkOrderId,
                WorkOrder = this.WorkOrder,
                ProductId = this.ProductId,
                ProductName = this.ProductName,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                ForecastNet = this.ForecastNet,
                ForecastTotal = this.ForecastTotal,
                TenderPriceNet = this.TenderPriceNet,
                Total = this.Total,
                Description = this.Description,
                SpecRef = this.SpecRef,
            };
        }//endofclonemethods
    }

    public class TenderExpenditureEdit : PropertyBase<TenderExpenditureEdit>, IDuplicate
    {

        private TenderExpenditureDto _dto;


        public TenderExpenditureEdit()
        {

            this.Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }//endofconstructor

        public Property<int> ExpenditureId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> SiteName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> WorkOrderId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> WorkOrder { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<int> ProductId { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<string> ProductName { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime> StartDate { get; set; } = new Property<DateTime>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<DateTime> EndDate { get; set; } = new Property<DateTime>() { Value = DateTime.Today, Original = DateTime.Today };


        public Property<double> ForecastNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> ForecastTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> TenderPriceNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> Total { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<string> SpecRef { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };


        public Property<ComboBoxValue> VatRate { get; set; } = new Property<ComboBoxValue>() { Value = null, Original = null };


        public int RecordId => Id.Value;


        public TenderExpenditureDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ExpenditureId = ExpenditureId.Value;
            returnVal.VatRate = VatRate.Value;
            returnVal.SiteName = SiteName.Value;
            returnVal.WorkOrderId = WorkOrderId.Value;
            returnVal.WorkOrder = WorkOrder.Value;
            returnVal.ProductId = ProductId.Value;
            returnVal.ProductName = ProductName.Value;
            returnVal.StartDate = StartDate.Value;
            returnVal.EndDate = EndDate.Value;
            returnVal.ForecastNet = ForecastNet.Value;
            returnVal.ForecastTotal = ForecastTotal.Value;
            returnVal.TenderPriceNet = TenderPriceNet.Value;
            returnVal.Total = Total.Value;
            returnVal.Description = Description.Value;
            returnVal.SpecRef = SpecRef.Value;
            returnVal.Id = Id.Value;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TenderExpenditureEdit)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TenderExpenditureDto test)
        {
            this.ExpenditureId = Property<int>.Make(test.ExpenditureId);
            this.SiteName = Property<string>.Make(test.SiteName);
            this.VatRate = Property<ComboBoxValue>.Make(test.VatRate);
            this.WorkOrderId = Property<int>.Make(test.WorkOrderId);
            this.WorkOrder = Property<string>.Make(test.WorkOrder);
            this.ProductId = Property<int>.Make(test.ProductId);
            this.ProductName = Property<string>.Make(test.ProductName);
            this.StartDate = Property<DateTime>.Make(test.StartDate);
            this.EndDate = Property<DateTime>.Make(test.EndDate);
            this.ForecastNet = Property<double>.Make(test.ForecastNet);
            this.ForecastTotal = Property<double>.Make(test.ForecastTotal);
            this.TenderPriceNet = Property<double>.Make(test.TenderPriceNet);
            this.Total = Property<double>.Make(test.Total);
            this.Description = Property<string>.Make(test.Description);
            this.SpecRef = Property<string>.Make(test.SpecRef);
            this.Id = Property<int>.Make(test.Id);
            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            ExpenditureId.Revert();
            SiteName.Revert();
            WorkOrderId.Revert();
            WorkOrder.Revert();
            ProductId.Revert();
            ProductName.Revert();
            StartDate.Revert();
            EndDate.Revert();
            ForecastNet.Revert();
            ForecastTotal.Revert();
            TenderPriceNet.Revert();
            Total.Revert();
            Description.Revert();
            SpecRef.Revert();
            VatRate.Revert();
        }//endofResetChanges


        public static ExtRangeCollection<TenderExpenditureEdit> MakeCollection(List<TenderExpenditureDto> records)
        {

            var newData = new ExtRangeCollection<TenderExpenditureEdit>();

            foreach (var rec in records)
            {
                var e = new TenderExpenditureEdit();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass

    public class TenderExpenditureEditList : ListObj<TenderExpenditureDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {

        private TenderExpenditureDto _dto;


        public TenderExpenditureEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }//endofconstructor

        public int ExpenditureId { get => _current.ExpenditureId; set { _current.ExpenditureId = value; OnPropertyChanged(); } }

        public string SiteName { get => _current.SiteName; set { _current.SiteName = value; OnPropertyChanged(); } }

        public int WorkOrderId { get => _current.WorkOrderId; set { _current.WorkOrderId = value; OnPropertyChanged(); } }

        public string WorkOrder { get => _current.WorkOrder; set { _current.WorkOrder = value; OnPropertyChanged(); } }

        public int ProductId { get => _current.ProductId; set { _current.ProductId = value; OnPropertyChanged(); } }

        public string ProductName { get => _current.ProductName; set { _current.ProductName = value; OnPropertyChanged(); } }

        public DateTime StartDate { get => _current.StartDate; set { _current.StartDate = value; OnPropertyChanged(); } }

        public DateTime EndDate { get => _current.EndDate; set { _current.EndDate = value; OnPropertyChanged(); } }


        public double ForecastNet { get => _current.ForecastNet; set { _current.ForecastNet = value; OnPropertyChanged(); } }

        public double ForecastTotal { get => _current.ForecastTotal; set { _current.ForecastTotal = value; OnPropertyChanged(); } }

        public double TenderPriceNet { get => _current.TenderPriceNet; set { _current.TenderPriceNet = value; OnPropertyChanged(); } }

        public double Total { get => _current.Total; set { _current.Total = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public string SpecRef { get => _current.SpecRef; set { _current.SpecRef = value; OnPropertyChanged(); } }


        public ComboBoxValue VatRate { get => _current.VatRate; set { _current.VatRate = value; OnPropertyChanged(); } }


        public int RecordId => Id;


        public TenderExpenditureDto ConvertToDto()
        {
            var returnVal = _dto.Clone();
            returnVal.ExpenditureId = this.ExpenditureId;
            returnVal.SiteName = this.SiteName;
            returnVal.WorkOrderId = this.WorkOrderId;
            returnVal.WorkOrder = this.WorkOrder;
            returnVal.ProductId = this.ProductId;
            returnVal.ProductName = this.ProductName;
            returnVal.StartDate = this.StartDate;
            returnVal.EndDate = this.EndDate;
            returnVal.ForecastNet = this.ForecastNet;
            returnVal.ForecastTotal = this.ForecastTotal;
            returnVal.TenderPriceNet = this.TenderPriceNet;
            returnVal.Total = this.Total;
            returnVal.Description = this.Description;
            returnVal.SpecRef = this.SpecRef;
            returnVal.VatRate = this.VatRate;
            returnVal.Id = this.Id;
            return returnVal;
        }//ConvertToDto


        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (TenderExpenditureEditList)existingRecord;
            var temp = t1.ConvertToDto();
            temp.Id = id;
            Make(temp);
        }//MakeFromExisting


        public void Make(TenderExpenditureDto test)
        {
            _original.ExpenditureId = test.ExpenditureId;
            _current.ExpenditureId = test.ExpenditureId;
            _original.SiteName = test.SiteName;
            _current.SiteName = test.SiteName;
            _original.WorkOrderId = test.WorkOrderId;
            _current.WorkOrderId = test.WorkOrderId;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductId = test.ProductId;
            _current.ProductId = test.ProductId;
            _original.ProductName = test.ProductName;
            _current.ProductName = test.ProductName;
            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastTotal = test.ForecastTotal;
            _current.ForecastTotal = test.ForecastTotal;
            _original.TenderPriceNet = test.TenderPriceNet;
            _current.TenderPriceNet = test.TenderPriceNet;
            _original.Total = test.Total;
            _current.Total = test.Total;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.SpecRef = test.SpecRef;
            _current.SpecRef = test.SpecRef;
            _original.Id = test.Id;
            _current.Id = test.Id;

            _current.VatRate = test.VatRate;
            _original.VatRate = test.VatRate;

            _dto = test;
        }//endoffirstmake


        public void ResetChanges()
        {
            this._current = this._original;
        }//endofResetChanges


        public static ExtRangeCollection<TenderExpenditureEditList> MakeCollection(List<TenderExpenditureDto> records)
        {

            var newData = new ExtRangeCollection<TenderExpenditureEditList>();

            foreach (var rec in records)
            {
                var e = new TenderExpenditureEditList();
                e.Make(rec);
                newData.AddItem(e);
            }

            return newData;
        }
    }//endofclass



}
