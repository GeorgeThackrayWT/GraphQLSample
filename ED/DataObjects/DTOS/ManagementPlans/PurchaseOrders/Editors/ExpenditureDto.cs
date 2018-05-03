using System;
using System.Collections.Generic;
using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.ManagementPlans.Editors;

namespace DataObjects
{
    public class ExpenditureEdit : PropertyBase<ExpenditureEdit>, IDuplicate
    {
        private ExpenditureDto _sourceExpenditureDto;

        public ExpenditureEdit()
        {

            Validator = e =>
            {

            };
            IsNew = true;
            IsDirty = true;
            IsValid = false;
        }

        public int RecordId => Id.Value;

 
        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> StartDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<DateTime?> EndDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };
        public Property<int> WorkOrder { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> ProductID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> AimID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<int> FundingStatusID { get; set; } = new Property<int>() { Value = 0, Original = 0 };
        public Property<double> BudgetNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };
        public Property<double> BudgetTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> ForecastNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> ForecastNetTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<int> VATRateID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<int> TAXRateID { get; set; } = new Property<int>() { Value = 0, Original = 0 };

        public Property<double> Ordered { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<double> Actual { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0 };

        public Property<string> PONo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<DateTime?> PODate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today };

        public Property<bool> GRN { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Compeleted { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> CptNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> EMC { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> RPI { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> PesticideRecord { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<string> EMCSpecification { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty };

        public Property<bool> WSP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> DTP { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Pipeline { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> PE { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Chalara { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> Confidential { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> OpsGrantAided { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> VolunteerWork { get; set; } = new Property<bool>() { Value = false, Original = false };

        public Property<bool> NoAgressoUpdate { get; set; } = new Property<bool>() { Value = false, Original = false };


        public void Make(ExpenditureDto test)
        {
            Id = Property<int>.Make(test.Id,Id);
            Description = Property<string>.Make(test.Description,Description);
            StartDate = Property<DateTime?>.Make(test.StartDate,StartDate);
            EndDate = Property<DateTime?>.Make(test.EndDate,EndDate);
            WorkOrder = Property<int>.Make(test.WorkOrder,WorkOrder);
            ProductID = Property<int>.Make(test.ProductID,ProductID);
            AimID = Property<int>.Make(test.AimID,AimID);
            FundingStatusID = Property<int>.Make(test.FundingStatusID,FundingStatusID);
            BudgetNet = Property<double>.Make(test.BudgetNet,BudgetNet);
            BudgetTotal = Property<double>.Make(test.BudgetTotal,BudgetTotal);
            ForecastNet = Property<double>.Make(test.ForecastNet,ForecastNet);
            ForecastNetTotal = Property<double>.Make(test.ForecastNetTotal,ForecastNetTotal);
            VATRateID = Property<int>.Make(test.VATRateID,VATRateID);
            TAXRateID = Property<int>.Make(test.TAXRateID,TAXRateID);
            Ordered = Property<double>.Make(test.Ordered,Ordered);
            Actual = Property<double>.Make(test.Actual,Actual);
            PONo = Property<string>.Make(test.PONo,PONo);
            PODate = Property<DateTime?>.Make(test.PODate,PODate);
            GRN = Property<bool>.Make(test.GRN,GRN);
            Compeleted = Property<bool>.Make(test.Compeleted,Compeleted);
            CptNo = Property<string>.Make(test.CptNo,CptNo);
            EMC = Property<bool>.Make(test.EMC,EMC);
            RPI = Property<bool>.Make(test.RPI,RPI);
            PesticideRecord = Property<bool>.Make(test.PesticideRecord,PesticideRecord);
            EMCSpecification = Property<string>.Make(test.EMCSpecification,EMCSpecification);
            WSP = Property<bool>.Make(test.WSP,WSP);
            DTP = Property<bool>.Make(test.DTP,DTP);
            Pipeline = Property<bool>.Make(test.Pipeline,Pipeline);
            PE = Property<bool>.Make(test.PE,PE);
            Chalara = Property<bool>.Make(test.Chalara,Chalara);
            Confidential = Property<bool>.Make(test.Confidential,Confidential);
            OpsGrantAided = Property<bool>.Make(test.OpsGrantAided,OpsGrantAided);
            VolunteerWork = Property<bool>.Make(test.VolunteerWork,VolunteerWork);
            NoAgressoUpdate = Property<bool>.Make(test.NoAgressoUpdate,NoAgressoUpdate);

            _sourceExpenditureDto = test;

            //ExtRangeCollection<ExpenditureEditDTOBO>
        }//endofmake

        public ExpenditureDto ConvertToDto()
        {
            var retVal = _sourceExpenditureDto.Clone();

            retVal.Id = Id.Value;
            retVal.Description = Description.Value;
            retVal.StartDate = StartDate.Value;
            retVal.EndDate = EndDate.Value;
            retVal.WorkOrder = WorkOrder.Value;
            retVal.ProductID = ProductID.Value;
            retVal.AimID = AimID.Value;
            retVal.FundingStatusID = FundingStatusID.Value;
            retVal.BudgetNet = BudgetNet.Value;
            retVal.BudgetTotal = BudgetTotal.Value;
            retVal.ForecastNet = ForecastNet.Value;
            retVal.ForecastNetTotal = ForecastNetTotal.Value;
            retVal.VATRateID = VATRateID.Value;
            retVal.TAXRateID = TAXRateID.Value;
            retVal.Ordered = Ordered.Value;
            retVal.Actual = Actual.Value;
            retVal.PONo = PONo.Value;
            retVal.PODate = PODate.Value;
            retVal.GRN = GRN.Value;
            retVal.Compeleted = Compeleted.Value;
            retVal.CptNo = CptNo.Value;
            retVal.EMC = EMC.Value;
            retVal.RPI = RPI.Value;
            retVal.PesticideRecord = PesticideRecord.Value;
            retVal.EMCSpecification = EMCSpecification.Value;
            retVal.WSP = WSP.Value;
            retVal.DTP = DTP.Value;
            retVal.Pipeline = Pipeline.Value;
            retVal.PE = PE.Value;
            retVal.Chalara = Chalara.Value;
            retVal.Confidential = Confidential.Value;
            retVal.OpsGrantAided = OpsGrantAided.Value;
            retVal.VolunteerWork = VolunteerWork.Value;
            retVal.NoAgressoUpdate = NoAgressoUpdate.Value;
          
            return retVal;
        }

        public void ResetChanges()
        {
            Id.Revert();
            Description.Revert();
            StartDate.Revert();
            EndDate.Revert();
            WorkOrder.Revert();
            ProductID.Revert();
            AimID.Revert();
            FundingStatusID.Revert();
            BudgetNet.Revert();
            BudgetTotal.Revert();
            ForecastNet.Revert();
            ForecastNetTotal.Revert();
            VATRateID.Revert();
            TAXRateID.Revert();
            Ordered.Revert();
            Actual.Revert();
            PONo.Revert();
            PODate.Revert();
            GRN.Revert();
            Compeleted.Revert();
            CptNo.Revert();
            EMC.Revert();
            RPI.Revert();
            PesticideRecord.Revert();
            EMCSpecification.Revert();
            WSP.Revert();
            DTP.Revert();
            Pipeline.Revert();
            PE.Revert();
            Chalara.Revert();
            Confidential.Revert();
            OpsGrantAided.Revert();
            VolunteerWork.Revert();
            NoAgressoUpdate.Revert();
        }

        public static ExtRangeCollection<ExpenditureEdit> MakeCollection(List<ExpenditureDto> records)
        {
            var newData = new ExtRangeCollection<ExpenditureEdit>();

            foreach (var rec in records)
            {
                var e = new ExpenditureEdit();
                e.Make(rec);

                newData.AddItem(e);
            }


            return newData;
        }

        public void MakeFromExisting(object existingRecord, int id)
        {
            var temp = ConvertToDto();
            temp.Id = id;
            Make(temp);
        }
    }//endofclass

    public class ExpenditureDto : BaseDto, IRecord
    {
        public int Id { get; set; }

       
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int WorkOrder { get; set; }

        public string WorkOrderDescription { get; set; }

        public int ProductID { get; set; }
        public int AimID { get; set; }
        public int FundingStatusID { get; set; }
        public double BudgetNet { get; set; }
        public double BudgetTotal { get; set; }

        public double ForecastNet { get; set; }

        public double ForecastNetTotal { get; set; }

        public int VATRateID { get; set; }

        public int TAXRateID { get; set; }

        public double Ordered { get; set; }

        public double Actual { get; set; }

        public string PONo { get; set; }

        public DateTime? PODate { get; set; }

        public bool GRN { get; set; }

        public bool Compeleted { get; set; }

        public string CptNo { get; set; }

        public bool EMC { get; set; }

        public bool RPI { get; set; }

        public bool PesticideRecord { get; set; }

        public string EMCSpecification { get; set; }

        public bool WSP { get; set; }

        public bool DTP { get; set; }

        public bool Pipeline { get; set; }

        public bool PE { get; set; }

        public bool Chalara { get; set; }

        public bool Confidential { get; set; }

        public bool OpsGrantAided { get; set; }

        public bool VolunteerWork { get; set; }

        public bool NoAgressoUpdate { get; set; }

        public int ManagementUnitId { get; set; }
   
        public string Product { get; set; }

        public double Budget { get; set; }
        public double? Forecast { get; set; }
    
        public int Remaining { get; set; }

        public int TenderId { get; set; }

        public bool Completed { get; set; }

        public ExpenditureDto Clone()
        {
            return new ExpenditureDto()
            {
                Id = this.Id,
                Description = this.Description,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                WorkOrder = this.WorkOrder,
                WorkOrderDescription = this.WorkOrderDescription,
                ProductID = this.ProductID,
                AimID = this.AimID,
                FundingStatusID = this.FundingStatusID,
                BudgetNet = this.BudgetNet,
                BudgetTotal = this.BudgetTotal,
                ForecastNet = this.ForecastNet,
                ForecastNetTotal = this.ForecastNetTotal,
                VATRateID = this.VATRateID,
                TAXRateID = this.TAXRateID,
                Ordered = this.Ordered,
                Actual = this.Actual,
                PONo = this.PONo,
                PODate = this.PODate,
                GRN = this.GRN,
                Compeleted = this.Compeleted,
                CptNo = this.CptNo,
                EMC = this.EMC,
                RPI = this.RPI,
                PesticideRecord = this.PesticideRecord,
                EMCSpecification = this.EMCSpecification,
                WSP = this.WSP,
                DTP = this.DTP,
                Pipeline = this.Pipeline,
                PE = this.PE,
                Chalara = this.Chalara,
                Confidential = this.Confidential,
                OpsGrantAided = this.OpsGrantAided,
                VolunteerWork = this.VolunteerWork,
                NoAgressoUpdate = this.NoAgressoUpdate,
                ManagementUnitId = this.ManagementUnitId,
                Product = this.Product,
                Budget = this.Budget,
                Forecast = this.Forecast,
                Remaining = this.Remaining,
                Completed = this.Completed,
                TenderId = this.TenderId
            };
        }
    }

    public class ExpenditureEditList : ListObj<ExpenditureDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private ExpenditureDto _sourceExpenditureDto;

        public ExpenditureEditList()
        {

            this.Validator = e =>
            {
                IsValid = !(e.Errors.Count > 0);
            };



        }
        public int RecordId => Id;

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public DateTime? StartDate { get => _current.StartDate; set { _current.StartDate = value; OnPropertyChanged(); } }
        public DateTime? EndDate { get => _current.EndDate; set { _current.EndDate = value; OnPropertyChanged(); } }
        public int WorkOrder { get => _current.WorkOrder; set { _current.WorkOrder = value; OnPropertyChanged(); } }

        public string WorkOrderDescription { get => _current.WorkOrderDescription; set { _current.WorkOrderDescription = value; OnPropertyChanged(); } }

        public int ProductID { get => _current.ProductID; set { _current.ProductID = value; OnPropertyChanged(); } }
        public int AimID { get => _current.AimID; set { _current.AimID = value; OnPropertyChanged(); } }
        public int FundingStatusID { get => _current.FundingStatusID; set { _current.FundingStatusID = value; OnPropertyChanged(); } }
        public double BudgetNet { get => _current.BudgetNet; set { _current.BudgetNet = value; OnPropertyChanged(); } }
        public double BudgetTotal { get => _current.BudgetTotal; set { _current.BudgetTotal = value; OnPropertyChanged(); } }

        public double ForecastNet { get => _current.ForecastNet; set { _current.ForecastNet = value; OnPropertyChanged(); } }

        public double ForecastNetTotal { get => _current.ForecastNetTotal; set { _current.ForecastNetTotal = value; OnPropertyChanged(); } }

        public int VATRateID { get => _current.VATRateID; set { _current.VATRateID = value; OnPropertyChanged(); } }

        public int TAXRateID { get => _current.TAXRateID; set { _current.TAXRateID = value; OnPropertyChanged(); } }

        public double Ordered { get => _current.Ordered; set { _current.Ordered = value; OnPropertyChanged(); } }

        public double Actual { get => _current.Actual; set { _current.Actual = value; OnPropertyChanged(); } }

        public string PONo { get => _current.PONo; set { _current.PONo = value; OnPropertyChanged(); } }

        public DateTime? PODate { get => _current.PODate; set { _current.PODate = value; OnPropertyChanged(); } }

        public bool GRN { get => _current.GRN; set { _current.GRN = value; OnPropertyChanged(); } }

        public bool Compeleted { get => _current.Compeleted; set { _current.Compeleted = value; OnPropertyChanged(); } }

        public string CptNo { get => _current.CptNo; set { _current.CptNo = value; OnPropertyChanged(); } }

        public bool EMC { get => _current.EMC; set { _current.EMC = value; OnPropertyChanged(); } }

        public bool RPI { get => _current.RPI; set { _current.RPI = value; OnPropertyChanged(); } }

        public bool PesticideRecord { get => _current.PesticideRecord; set { _current.PesticideRecord = value; OnPropertyChanged(); } }

        public string EMCSpecification { get => _current.EMCSpecification; set { _current.EMCSpecification = value; OnPropertyChanged(); } }

        public bool WSP { get => _current.WSP; set { _current.WSP = value; OnPropertyChanged(); } }

        public bool DTP { get => _current.DTP; set { _current.DTP = value; OnPropertyChanged(); } }

        public bool Pipeline { get => _current.Pipeline; set { _current.Pipeline = value; OnPropertyChanged(); } }

        public bool PE { get => _current.PE; set { _current.PE = value; OnPropertyChanged(); } }

        public bool Chalara { get => _current.Chalara; set { _current.Chalara = value; OnPropertyChanged(); } }

        public bool Confidential { get => _current.Confidential; set { _current.Confidential = value; OnPropertyChanged(); } }

        public bool OpsGrantAided { get => _current.OpsGrantAided; set { _current.OpsGrantAided = value; OnPropertyChanged(); } }

        public bool VolunteerWork { get => _current.VolunteerWork; set { _current.VolunteerWork = value; OnPropertyChanged(); } }

        public bool NoAgressoUpdate { get => _current.NoAgressoUpdate; set { _current.NoAgressoUpdate = value; OnPropertyChanged(); } }

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }

        public string Product { get => _current.Product; set { _current.Product = value; OnPropertyChanged(); } }

        public double Budget { get => _current.Budget; set { _current.Budget = value; OnPropertyChanged(); } }
        public double? Forecast { get => _current.Forecast; set { _current.Forecast = value; OnPropertyChanged(); } }

        public int Remaining { get => _current.Remaining; set { _current.Remaining = value; OnPropertyChanged(); } }

        public bool Completed { get => _current.Completed; set { _current.Completed = value; OnPropertyChanged(); } }

        public int TenderId { get => _current.TenderId; set { _current.TenderId = value; OnPropertyChanged(); } }

        public void MakeFromExisting(ExpenditureEditList test, int id)
        {
            //_sourceExpenditureDto = test.Cl

            _original.Id = id;
            _current.Id = id;
            _original.WorkOrderDescription = test.WorkOrderDescription;
            _current.WorkOrderDescription = test.WorkOrderDescription;

            _original.TenderId = test.TenderId;
            _current.TenderId = test.TenderId;

            _original.Description = test.Description;
            _current.Description = test.Description;

            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductID = test.ProductID;
            _current.ProductID = test.ProductID;
            _original.AimID = test.AimID;
            _current.AimID = test.AimID;
            _original.FundingStatusID = test.FundingStatusID;
            _current.FundingStatusID = test.FundingStatusID;
            _original.BudgetNet = test.BudgetNet;
            _current.BudgetNet = test.BudgetNet;
            _original.BudgetTotal = test.BudgetTotal;
            _current.BudgetTotal = test.BudgetTotal;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastNetTotal = test.ForecastNetTotal;
            _current.ForecastNetTotal = test.ForecastNetTotal;
            _original.VATRateID = test.VATRateID;
            _current.VATRateID = test.VATRateID;
            _original.TAXRateID = test.TAXRateID;
            _current.TAXRateID = test.TAXRateID;
            _original.Ordered = test.Ordered;
            _current.Ordered = test.Ordered;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.PONo = test.PONo;
            _current.PONo = test.PONo;
            _original.PODate = test.PODate;
            _current.PODate = test.PODate;
            _original.GRN = test.GRN;
            _current.GRN = test.GRN;
            _original.Compeleted = test.Compeleted;
            _current.Compeleted = test.Compeleted;
            _original.CptNo = test.CptNo;
            _current.CptNo = test.CptNo;
            _original.EMC = test.EMC;
            _current.EMC = test.EMC;
            _original.RPI = test.RPI;
            _current.RPI = test.RPI;
            _original.PesticideRecord = test.PesticideRecord;
            _current.PesticideRecord = test.PesticideRecord;
            _original.EMCSpecification = test.EMCSpecification;
            _current.EMCSpecification = test.EMCSpecification;
            _original.WSP = test.WSP;
            _current.WSP = test.WSP;
            _original.DTP = test.DTP;
            _current.DTP = test.DTP;
            _original.Pipeline = test.Pipeline;
            _current.Pipeline = test.Pipeline;
            _original.PE = test.PE;
            _current.PE = test.PE;
            _original.Chalara = test.Chalara;
            _current.Chalara = test.Chalara;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.OpsGrantAided = test.OpsGrantAided;
            _current.OpsGrantAided = test.OpsGrantAided;
            _original.VolunteerWork = test.VolunteerWork;
            _current.VolunteerWork = test.VolunteerWork;
            _original.NoAgressoUpdate = test.NoAgressoUpdate;
            _current.NoAgressoUpdate = test.NoAgressoUpdate;
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Product = test.Product;
            _current.Product = test.Product;
            _original.Budget = test.Budget;
            _current.Budget = test.Budget;
            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;
            _original.Remaining = test.Remaining;
            _current.Remaining = test.Remaining;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;

            

        


        }//endoffirstmake


        public void Make(ExpenditureDto test)
        {
            _sourceExpenditureDto = test;

            _original.Id = test.Id;
            _current.Id = test.Id;
            _original.WorkOrderDescription = test.WorkOrderDescription;
            _current.WorkOrderDescription = test.WorkOrderDescription;

            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductID = test.ProductID;
            _current.ProductID = test.ProductID;
            _original.AimID = test.AimID;
            _current.AimID = test.AimID;
            _original.FundingStatusID = test.FundingStatusID;
            _current.FundingStatusID = test.FundingStatusID;
            _original.BudgetNet = test.BudgetNet;
            _current.BudgetNet = test.BudgetNet;
            _original.BudgetTotal = test.BudgetTotal;
            _current.BudgetTotal = test.BudgetTotal;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastNetTotal = test.ForecastNetTotal;
            _current.ForecastNetTotal = test.ForecastNetTotal;
            _original.VATRateID = test.VATRateID;
            _current.VATRateID = test.VATRateID;
            _original.TAXRateID = test.TAXRateID;
            _current.TAXRateID = test.TAXRateID;
            _original.Ordered = test.Ordered;
            _current.Ordered = test.Ordered;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.PONo = test.PONo;
            _current.PONo = test.PONo;
            _original.PODate = test.PODate;
            _current.PODate = test.PODate;
            _original.GRN = test.GRN;
            _current.GRN = test.GRN;
            _original.Compeleted = test.Compeleted;
            _current.Compeleted = test.Compeleted;
            _original.CptNo = test.CptNo;
            _current.CptNo = test.CptNo;
            _original.EMC = test.EMC;
            _current.EMC = test.EMC;
            _original.RPI = test.RPI;
            _current.RPI = test.RPI;
            _original.PesticideRecord = test.PesticideRecord;
            _current.PesticideRecord = test.PesticideRecord;
            _original.EMCSpecification = test.EMCSpecification;
            _current.EMCSpecification = test.EMCSpecification;
            _original.WSP = test.WSP;
            _current.WSP = test.WSP;
            _original.DTP = test.DTP;
            _current.DTP = test.DTP;
            _original.Pipeline = test.Pipeline;
            _current.Pipeline = test.Pipeline;
            _original.PE = test.PE;
            _current.PE = test.PE;
            _original.Chalara = test.Chalara;
            _current.Chalara = test.Chalara;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.OpsGrantAided = test.OpsGrantAided;
            _current.OpsGrantAided = test.OpsGrantAided;
            _original.VolunteerWork = test.VolunteerWork;
            _current.VolunteerWork = test.VolunteerWork;
            _original.NoAgressoUpdate = test.NoAgressoUpdate;
            _current.NoAgressoUpdate = test.NoAgressoUpdate;
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Product = test.Product;
            _current.Product = test.Product;
            _original.Budget = test.Budget;
            _current.Budget = test.Budget;
            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;
            _original.Remaining = test.Remaining;
            _current.Remaining = test.Remaining;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;

            _original.TenderId = test.TenderId;
            _current.TenderId = test.TenderId;

            SetPropChanged();

            _sourceExpenditureDto = test;
        }//endoffirstmake

        public static ExtRangeCollection<ExpenditureEditList> MakeCollection(List<ExpenditureDto> records)
        {
            var newData = new ExtRangeCollection<ExpenditureEditList>();

            foreach (var rec in records)
            {
                var e = new ExpenditureEditList();
                e.Make(rec);

                newData.AddItem(e);
            }


            return newData;
        }

        public void MakeFromExisting(object existingRecord, int id)
        {
            ExpenditureEditList test = (ExpenditureEditList)existingRecord;

            _sourceExpenditureDto = test._sourceExpenditureDto;

            _original.Id = id;
            _current.Id = id;
            _original.WorkOrderDescription = test.WorkOrderDescription;
            _current.WorkOrderDescription = test.WorkOrderDescription;

            _original.TenderId = test.TenderId;
            _current.TenderId = test.TenderId;

            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductID = test.ProductID;
            _current.ProductID = test.ProductID;
            _original.AimID = test.AimID;
            _current.AimID = test.AimID;
            _original.FundingStatusID = test.FundingStatusID;
            _current.FundingStatusID = test.FundingStatusID;
            _original.BudgetNet = test.BudgetNet;
            _current.BudgetNet = test.BudgetNet;
            _original.BudgetTotal = test.BudgetTotal;
            _current.BudgetTotal = test.BudgetTotal;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastNetTotal = test.ForecastNetTotal;
            _current.ForecastNetTotal = test.ForecastNetTotal;
            _original.VATRateID = test.VATRateID;
            _current.VATRateID = test.VATRateID;
            _original.TAXRateID = test.TAXRateID;
            _current.TAXRateID = test.TAXRateID;
            _original.Ordered = test.Ordered;
            _current.Ordered = test.Ordered;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.PONo = test.PONo;
            _current.PONo = test.PONo;
            _original.PODate = test.PODate;
            _current.PODate = test.PODate;
            _original.GRN = test.GRN;
            _current.GRN = test.GRN;
            _original.Compeleted = test.Compeleted;
            _current.Compeleted = test.Compeleted;
            _original.CptNo = test.CptNo;
            _current.CptNo = test.CptNo;
            _original.EMC = test.EMC;
            _current.EMC = test.EMC;
            _original.RPI = test.RPI;
            _current.RPI = test.RPI;
            _original.PesticideRecord = test.PesticideRecord;
            _current.PesticideRecord = test.PesticideRecord;
            _original.EMCSpecification = test.EMCSpecification;
            _current.EMCSpecification = test.EMCSpecification;
            _original.WSP = test.WSP;
            _current.WSP = test.WSP;
            _original.DTP = test.DTP;
            _current.DTP = test.DTP;
            _original.Pipeline = test.Pipeline;
            _current.Pipeline = test.Pipeline;
            _original.PE = test.PE;
            _current.PE = test.PE;
            _original.Chalara = test.Chalara;
            _current.Chalara = test.Chalara;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.OpsGrantAided = test.OpsGrantAided;
            _current.OpsGrantAided = test.OpsGrantAided;
            _original.VolunteerWork = test.VolunteerWork;
            _current.VolunteerWork = test.VolunteerWork;
            _original.NoAgressoUpdate = test.NoAgressoUpdate;
            _current.NoAgressoUpdate = test.NoAgressoUpdate;
            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;
            _original.Product = test.Product;
            _current.Product = test.Product;
            _original.Budget = test.Budget;
            _current.Budget = test.Budget;
            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;
            _original.Remaining = test.Remaining;
            _current.Remaining = test.Remaining;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;
        }

        public void ResetChanges()
        {
            _current = _original;
        }

        public ExpenditureDto ConvertToDto()
        {
            var retVal = _sourceExpenditureDto.Clone();

            retVal.Id = this.Id;
            retVal.WorkOrderDescription = this.WorkOrderDescription;
            retVal.Description = this.Description;
            retVal.StartDate = this.StartDate;
            retVal.EndDate = this.EndDate;
            retVal.WorkOrder = this.WorkOrder;
            retVal.ProductID = this.ProductID;
            retVal.AimID = this.AimID;
            retVal.FundingStatusID = this.FundingStatusID;
            retVal.BudgetNet = this.BudgetNet;
            retVal.BudgetTotal = this.BudgetTotal;
            retVal.ForecastNet = this.ForecastNet;
            retVal.ForecastNetTotal = this.ForecastNetTotal;
            retVal.VATRateID = this.VATRateID;
            retVal.TAXRateID = this.TAXRateID;
            retVal.Ordered = this.Ordered;
            retVal.Actual = this.Actual;
            retVal.PONo = this.PONo;
            retVal.PODate = this.PODate;
            retVal.GRN = this.GRN;
            retVal.Compeleted = this.Compeleted;
            retVal.CptNo = this.CptNo;
            retVal.EMC = this.EMC;
            retVal.RPI = this.RPI;
            retVal.PesticideRecord = this.PesticideRecord;
            retVal.EMCSpecification = this.EMCSpecification;
            retVal.WSP = this.WSP;
            retVal.DTP = this.DTP;
            retVal.Pipeline = this.Pipeline;
            retVal.PE = this.PE;
            retVal.Chalara = this.Chalara;
            retVal.Confidential = this.Confidential;
            retVal.OpsGrantAided = this.OpsGrantAided;
            retVal.VolunteerWork = this.VolunteerWork;
            retVal.NoAgressoUpdate = this.NoAgressoUpdate;
            retVal.ManagementUnitId = this.ManagementUnitId;
            retVal.Product = this.Product;
            retVal.Budget = this.Budget;
            retVal.Forecast = this.Forecast;
            retVal.Remaining = this.Remaining;
            retVal.Completed = this.Completed;


            retVal.TenderId = this.TenderId;
    


            return retVal;
        }
    }//endofclass

}