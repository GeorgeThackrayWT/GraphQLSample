using System;
using System.Collections.Generic;
using DataObjects.DTOS.ManagementPlans.Editors;
using System.ComponentModel;
using Abstractions;

namespace DataObjects
{




    public interface IDuplicate
    {
        void MakeFromExisting(object existingRecord, int id);
        void ResetChanges();

        int RecordId { get; }
    }

    public class IncomeDto : BaseDto, IRecord 
    {
         
        public int ManagementUnitId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsProject { get; set; }

        public int WorkOrder { get; set; }

        public string WorkOrderDescription { get; set; }

        public int ProductId { get; set; }

        public int AimId { get; set; }

        public double BudgetNet { get; set; }

        public double BudgetNetTotal { get; set; }

        public double ForecastNet { get; set; }

        public double ForecastNetTotal { get; set; }

        public int VatRateId { get; set; }

        public double ClmdInvd { get; set; }

        public double Actual { get; set; }

        public int Remaining { get; set; }

        public string SoNo { get; set; }

        public DateTime? SoDate { get; set; }

        public bool Received { get; set; }

        public bool Completed { get; set; }

        public int GrantSchemeId { get; set; }

        public string GrantSchemeDescription { get; set; }

        public bool Pe { get; set; }

        public bool Pipeline { get; set; }
        public bool Confidential { get; set; }

        public bool NoAgressoUpdate { get; set; }

        public string Description { get; set; }

        public int TaskCodeId { get; set; }

        public double Budget { get; set; } // editable
        public double Forecast { get; set; }

        public string Product { get; set; }


        public IncomeDto Clone()
        {
            return new IncomeDto()
            {
                ManagementUnitId = this.ManagementUnitId,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                IsProject = this.IsProject,
                WorkOrder = this.WorkOrder,
                WorkOrderDescription = this.WorkOrderDescription,
                ProductId = this.ProductId,
                AimId = this.AimId,
                BudgetNet = this.BudgetNet,
                BudgetNetTotal = this.BudgetNetTotal,
                ForecastNet = this.ForecastNet,
                ForecastNetTotal = this.ForecastNetTotal,
                VatRateId = this.VatRateId,
                ClmdInvd = this.ClmdInvd,
                Actual = this.Actual,
                Remaining = this.Remaining,
                SoNo = this.SoNo,
                SoDate = this.SoDate,
                Received = this.Received,
                Completed = this.Completed,
                GrantSchemeId = this.GrantSchemeId,
                GrantSchemeDescription = this.GrantSchemeDescription,
                Pe = this.Pe,
                Pipeline = this.Pipeline,
                Confidential = this.Confidential,
                NoAgressoUpdate = this.NoAgressoUpdate,
                Description = this.Description,
                TaskCodeId = this.TaskCodeId,
                Budget = this.Budget, // editable
                Forecast = this.Forecast,
                Product = this.Product
                
            };
        }

    }

    public class IncomeEdit: PropertyBase<IncomeEdit>, IDuplicate
    {
        private IncomeDto _sourceIncomeDto;

        public IncomeEdit()
        {
            Validator = e =>
            {
                if (string.IsNullOrEmpty(Description.Value))
                {
                    Description.Errors.Add("Description is NULL or Empty");
                }

                if (BudgetNet.Value > 0.0)
                {
                    BudgetNet.Errors.Add("Budget should be greater less 0.0");
                }

                //if (StartDate.Value > DateTime.Today.AddYears(-))
                //{
                //    StartDate.Errors.Add("Start Date should be before 1998");
                //}

                //if (EndDate.Value > DateTime.Today.AddYears(-20))
                //{
                //    EndDate.Errors.Add("End Date should be before 2118");
                //}

                if (SoDate.Value > DateTime.Today.AddYears(1))
                {
                    SoDate.Errors.Add("SO Date should be before 2018");
                }

                //this.ID.Value != this.ID.Original
            };

            IsNew = true;
            IsDirty = true;
            IsValid = false;
            
        }

        #region properties

        public int RecordId => Id.Value;

        //public Property<int> Id { get; set; } = new Property<int>() { Value = 0, Original = 0, IsDisplayOnly = false};

        public Property<int> ManagementUnitId { get; set; } = new Property<int>() { Value = 0, Original = 0, IsDisplayOnly = false };

        public Property<DateTime?> StartDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today, IsDisplayOnly = false };
        public Property<DateTime?> EndDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today, IsDisplayOnly = false };               
        public Property<int> ProductId { get; set; } = new Property<int>() { Value = 1, Original = 1, IsDisplayOnly = false };
        public Property<int> AimId { get; set; } = new Property<int>() { Value = 1, Original = 1, IsDisplayOnly = false };          
        public Property<double> ClmdInvd { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = false };
        public Property<double> Actual { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = false };
        public Property<string> SoNo { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty, IsDisplayOnly = false };
        public Property<DateTime?> SoDate { get; set; } = new Property<DateTime?>() { Value = DateTime.Today, Original = DateTime.Today, IsDisplayOnly = false };
        public Property<bool> Received { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = false };
        public Property<bool> Completed { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = false };
        public Property<bool> Pe { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = false };
        public Property<bool> Pipeline { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = false };
        public Property<bool> Confidential { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = false };        
        public Property<string> Description { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty, IsDisplayOnly = false };
        public Property<int> WorkOrder { get; set; } = new Property<int>() { Value = 1, Original = 1, IsDisplayOnly = false };
        public Property<int> GrantSchemeId { get; set; } = new Property<int>() { Value = 1, Original = 1, IsDisplayOnly = false };
        public Property<string> GrantSchemeDescription { get; set; } = new Property<string>() { Value = string.Empty, Original = string.Empty, IsDisplayOnly = false };
        public Property<int> TaxCodeId { get; set; } = new Property<int>() { Value = 50000, Original = 50000, IsDisplayOnly = false };
        public Property<double> BudgetNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = false };
        public Property<double> ForecastNet { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = false };

        public Property<bool> NoAgressoUpdate { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = true };               
        public Property<double> BudgetNetTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = true };        
        public Property<double> ForecastNetTotal { get; set; } = new Property<double>() { Value = 0.0, Original = 0.0, IsDisplayOnly = true };   
        public Property<bool> IsProject { get; set; } = new Property<bool>() { Value = false, Original = false, IsDisplayOnly = true };


        #endregion

        public void Make(IncomeDto test)
        {
            Id = Property<int>.Make(test.Id,Id);
            ManagementUnitId = Property<int>.Make(test.ManagementUnitId,ManagementUnitId);
            StartDate = Property<DateTime?>.Make(test.StartDate,StartDate);
            EndDate = Property<DateTime?>.Make(test.EndDate,EndDate);
            IsProject = Property<bool>.Make(test.IsProject,IsProject);
            WorkOrder = Property<int>.Make(test.WorkOrder,WorkOrder);
            ProductId = Property<int>.Make(test.ProductId,ProductId);
            AimId = Property<int>.Make(test.AimId,AimId);
            BudgetNet = Property<double>.Make(test.BudgetNet,BudgetNet);
            BudgetNetTotal = Property<double>.Make(test.BudgetNetTotal,BudgetNetTotal);
            ForecastNet = Property<double>.Make(test.ForecastNet,ForecastNet);
            ForecastNetTotal = Property<double>.Make(test.ForecastNetTotal,ForecastNetTotal);        
            ClmdInvd = Property<double>.Make(test.ClmdInvd,ClmdInvd);
            Actual = Property<double>.Make(test.Actual,Actual);
            SoNo = Property<string>.Make(test.SoNo,SoNo);
            SoDate = Property<DateTime?>.Make(test.SoDate,SoDate);
            Received = Property<bool>.Make(test.Received,Received);
            Completed = Property<bool>.Make(test.Completed,Completed);
            GrantSchemeId = Property<int>.Make(test.GrantSchemeId,GrantSchemeId);
            GrantSchemeDescription = Property<string>.Make(test.GrantSchemeDescription,GrantSchemeDescription);
            Pe = Property<bool>.Make(test.Pe,Pe);
            Pipeline = Property<bool>.Make(test.Pipeline,Pipeline);
            Confidential = Property<bool>.Make(test.Confidential,Confidential);
            NoAgressoUpdate = Property<bool>.Make(test.NoAgressoUpdate,NoAgressoUpdate);
            Description = Property<string>.Make(test.Description,Description);

            _sourceIncomeDto = test;
        }//endofmake

      
        public IncomeDto ConvertToDto()
        {
            var newIncomeDto = _sourceIncomeDto.Clone();

            newIncomeDto.Id = Id.Value;
            newIncomeDto.ManagementUnitId = ManagementUnitId.Value;
            newIncomeDto.StartDate = StartDate.Value;
            newIncomeDto.EndDate = EndDate.Value;
            newIncomeDto.IsProject = IsProject.Value;
            newIncomeDto.WorkOrder = WorkOrder.Value;
            newIncomeDto.ProductId = ProductId.Value;
            newIncomeDto.AimId = AimId.Value;
            newIncomeDto.BudgetNet = BudgetNet.Value;
            newIncomeDto.BudgetNetTotal = BudgetNetTotal.Value;
            newIncomeDto.ForecastNet = ForecastNet.Value;
            newIncomeDto.ForecastNetTotal = ForecastNetTotal.Value;
            newIncomeDto.ClmdInvd = ClmdInvd.Value;
            newIncomeDto.Actual = Actual.Value;
            newIncomeDto.SoNo = SoNo.Value;
            newIncomeDto.SoDate = SoDate.Value;
            newIncomeDto.Received = Received.Value;
            newIncomeDto.Completed = Completed.Value;
            newIncomeDto.GrantSchemeId = GrantSchemeId.Value;
            newIncomeDto.GrantSchemeDescription = GrantSchemeDescription.Value;
            newIncomeDto.Pe = Pe.Value;
            newIncomeDto.Pipeline = Pipeline.Value;
            newIncomeDto.Confidential = Confidential.Value;
            newIncomeDto.NoAgressoUpdate = NoAgressoUpdate.Value;
            newIncomeDto.Description = Description.Value;
            
            return newIncomeDto;
        }

        public static ExtRangeCollection<IncomeEdit> MakeCollection(List<IncomeDto> records)
        {
            var newData = new ExtRangeCollection<IncomeEdit>();

            foreach (var rec in records)
            {
                var e = new IncomeEdit();
                e.Make(rec);

                newData.AddItem(e);
            }


            return newData;
        }

        public void MakeFromExisting(object existingRecord, int id)
        {
            var t1 = (IncomeEdit) existingRecord;

            var temp = t1.ConvertToDto();
            
            temp.Id = id;

            Make(temp);
        }

        public void ResetChanges()
        {
            Id.Revert();
            ManagementUnitId.Revert();
            StartDate.Revert();
            EndDate.Revert();
            IsProject.Revert();
            WorkOrder.Revert();
            ProductId.Revert();
            AimId.Revert();
            BudgetNet.Revert();
            BudgetNetTotal.Revert();
            ForecastNet.Revert();
            ForecastNetTotal.Revert();
            ClmdInvd.Revert();
            Actual.Revert();
            SoNo.Revert();
            SoDate.Revert();
            Received.Revert();
            Completed.Revert();
            GrantSchemeId.Revert();
            GrantSchemeDescription.Revert();
            Pe.Revert();
            Pipeline.Revert();
            Confidential.Revert();
            NoAgressoUpdate.Revert();
            Description.Revert();
        }
    }

    public class IncomeEditList : ListObj<IncomeDto>, INotifyPropertyChanged, IRecord, IDuplicate
    {
        private IncomeDto _sourceIncomeDto;

        public IncomeEditList()
        {

            Validator = e =>
            {

            };
     
        }

        #region properties
        public int RecordId => Id;

        public int Id { get => _current.Id; set { _current.Id = value; OnPropertyChanged(); } }

        public int ManagementUnitId { get => _current.ManagementUnitId; set { _current.ManagementUnitId = value; OnPropertyChanged(); } }

        public DateTime? StartDate { get => _current.StartDate; set { _current.StartDate = value; OnPropertyChanged(); } }

        public DateTime? EndDate { get => _current.EndDate; set { _current.EndDate = value; OnPropertyChanged(); } }

        public bool IsProject { get => _current.IsProject; set { _current.IsProject = value; OnPropertyChanged(); } }

        public int WorkOrder { get => _current.WorkOrder; set { _current.WorkOrder = value; OnPropertyChanged(); } }

        public string WorkOrderDescription { get => _current.WorkOrderDescription; set { _current.WorkOrderDescription = value; OnPropertyChanged(); } }

        public int ProductId { get => _current.ProductId; set { _current.ProductId = value; OnPropertyChanged(); } }

        public int AimId { get => _current.AimId; set { _current.AimId = value; OnPropertyChanged(); } }

        public double BudgetNet { get => _current.BudgetNet; set { _current.BudgetNet = value; OnPropertyChanged(); } }

        public double BudgetNetTotal { get => _current.BudgetNetTotal; set { _current.BudgetNetTotal = value; OnPropertyChanged(); } }

        public double ForecastNet { get => _current.ForecastNet; set { _current.ForecastNet = value; OnPropertyChanged(); } }

        public double ForecastNetTotal { get => _current.ForecastNetTotal; set { _current.ForecastNetTotal = value; OnPropertyChanged(); } }

        public int VatRateId { get => _current.VatRateId; set { _current.VatRateId = value; OnPropertyChanged(); } }

        public double ClmdInvd { get => _current.ClmdInvd; set { _current.ClmdInvd = value; OnPropertyChanged(); } }

        public double Budget { get => _current.Budget; set { _current.Budget = value; OnPropertyChanged(); } }

        public double Forecast { get => _current.Forecast; set { _current.Forecast = value; OnPropertyChanged(); } }

        public double Actual { get => _current.Actual; set { _current.Actual = value; OnPropertyChanged(); } }

        public string SoNo { get => _current.SoNo; set { _current.SoNo = value; OnPropertyChanged(); } }

        public int Remaining { get => _current.Remaining; set { _current.Remaining = value; OnPropertyChanged(); } }

        public DateTime? SoDate { get => _current.SoDate; set { _current.SoDate = value; OnPropertyChanged(); } }

        public bool Received { get => _current.Received; set { _current.Received = value; OnPropertyChanged(); } }

        public bool Completed { get => _current.Completed; set { _current.Completed = value; OnPropertyChanged(); } }

        public int GrantSchemeId { get => _current.GrantSchemeId; set { _current.GrantSchemeId = value; OnPropertyChanged(); } }

        public string GrantSchemeDescription { get => _current.GrantSchemeDescription; set { _current.GrantSchemeDescription = value; OnPropertyChanged(); } }

        public string Product { get => _current.Product; set { _current.Product = value; OnPropertyChanged(); } }

        public bool Pe { get => _current.Pe; set { _current.Pe = value; OnPropertyChanged(); } }

        public bool Pipeline { get => _current.Pipeline; set { _current.Pipeline = value; OnPropertyChanged(); } }
        public bool Confidential { get => _current.Confidential; set { _current.Confidential = value; OnPropertyChanged(); } }

        public bool NoAgressoUpdate { get => _current.NoAgressoUpdate; set { _current.NoAgressoUpdate = value; OnPropertyChanged(); } }

        public string Description { get => _current.Description; set { _current.Description = value; OnPropertyChanged(); } }

        public int TaskCodeId { get => _current.TaskCodeId; set { _current.TaskCodeId = value; OnPropertyChanged(); } }


        #endregion

        public void MakeFromExisting(object existingRecord, int id)
        {
            IncomeEditList test = (IncomeEditList)existingRecord;

            _sourceIncomeDto = test._sourceIncomeDto;

            _original.Id = id;
            _current.Id = id;

            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;

            _original.WorkOrderDescription = test.WorkOrderDescription;
            _current.WorkOrderDescription = test.WorkOrderDescription;

            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;

            _original.Budget = test.Budget;
            _current.Budget = test.Budget;

            _original.Product = test.Product;
            _current.Product = test.Product;

            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.IsProject = test.IsProject;
            _current.IsProject = test.IsProject;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductId = test.ProductId;
            _current.ProductId = test.ProductId;
            _original.AimId = test.AimId;
            _current.AimId = test.AimId;
            _original.BudgetNet = test.BudgetNet;
            _current.BudgetNet = test.BudgetNet;
            _original.BudgetNetTotal = test.BudgetNetTotal;
            _current.BudgetNetTotal = test.BudgetNetTotal;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastNetTotal = test.ForecastNetTotal;
            _current.ForecastNetTotal = test.ForecastNetTotal;
            _original.VatRateId = test.VatRateId;
            _current.VatRateId = test.VatRateId;
            _original.ClmdInvd = test.ClmdInvd;
            _current.ClmdInvd = test.ClmdInvd;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.SoNo = test.SoNo;
            _current.SoNo = test.SoNo;
            _original.SoDate = test.SoDate;
            _current.SoDate = test.SoDate;
            _original.Received = test.Received;
            _current.Received = test.Received;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;
            _original.GrantSchemeId = test.GrantSchemeId;
            _current.GrantSchemeId = test.GrantSchemeId;
            _original.GrantSchemeDescription = test.GrantSchemeDescription;
            _current.GrantSchemeDescription = test.GrantSchemeDescription;
            _original.Pe = test.Pe;
            _current.Pe = test.Pe;
            _original.Pipeline = test.Pipeline;
            _current.Pipeline = test.Pipeline;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.NoAgressoUpdate = test.NoAgressoUpdate;
            _current.NoAgressoUpdate = test.NoAgressoUpdate;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.TaskCodeId = test.TaskCodeId;
            _current.TaskCodeId = test.TaskCodeId;

           
        }//endoffirstmake

        public void Make(IncomeDto test)
        {
            _original.Id = test.Id;
            _current.Id = test.Id;

            _original.ManagementUnitId = test.ManagementUnitId;
            _current.ManagementUnitId = test.ManagementUnitId;


            _original.WorkOrderDescription = test.WorkOrderDescription;
            _current.WorkOrderDescription = test.WorkOrderDescription;

            _original.Forecast = test.Forecast;
            _current.Forecast = test.Forecast;

            _original.Budget = test.Budget;
            _current.Budget = test.Budget;

            _original.Product = test.Product;
            _current.Product = test.Product;

            _original.StartDate = test.StartDate;
            _current.StartDate = test.StartDate;
            _original.EndDate = test.EndDate;
            _current.EndDate = test.EndDate;
            _original.IsProject = test.IsProject;
            _current.IsProject = test.IsProject;
            _original.WorkOrder = test.WorkOrder;
            _current.WorkOrder = test.WorkOrder;
            _original.ProductId = test.ProductId;
            _current.ProductId = test.ProductId;
            _original.AimId = test.AimId;
            _current.AimId = test.AimId;
            _original.BudgetNet = test.BudgetNet;
            _current.BudgetNet = test.BudgetNet;
            _original.BudgetNetTotal = test.BudgetNetTotal;
            _current.BudgetNetTotal = test.BudgetNetTotal;
            _original.ForecastNet = test.ForecastNet;
            _current.ForecastNet = test.ForecastNet;
            _original.ForecastNetTotal = test.ForecastNetTotal;
            _current.ForecastNetTotal = test.ForecastNetTotal;
            _original.VatRateId = test.VatRateId;
            _current.VatRateId = test.VatRateId;
            _original.ClmdInvd = test.ClmdInvd;
            _current.ClmdInvd = test.ClmdInvd;
            _original.Actual = test.Actual;
            _current.Actual = test.Actual;
            _original.SoNo = test.SoNo;
            _current.SoNo = test.SoNo;
            _original.SoDate = test.SoDate;
            _current.SoDate = test.SoDate;
            _original.Received = test.Received;
            _current.Received = test.Received;
            _original.Completed = test.Completed;
            _current.Completed = test.Completed;
            _original.GrantSchemeId = test.GrantSchemeId;
            _current.GrantSchemeId = test.GrantSchemeId;
            _original.GrantSchemeDescription = test.GrantSchemeDescription;
            _current.GrantSchemeDescription = test.GrantSchemeDescription;
            _original.Pe = test.Pe;
            _current.Pe = test.Pe;
            _original.Pipeline = test.Pipeline;
            _current.Pipeline = test.Pipeline;
            _original.Confidential = test.Confidential;
            _current.Confidential = test.Confidential;
            _original.NoAgressoUpdate = test.NoAgressoUpdate;
            _current.NoAgressoUpdate = test.NoAgressoUpdate;
            _original.Description = test.Description;
            _current.Description = test.Description;
            _original.TaskCodeId = test.TaskCodeId;
            _current.TaskCodeId = test.TaskCodeId;
            SetPropChanged();
            _sourceIncomeDto = test;
        }//endoffirstmake

        public static ExtRangeCollection<IncomeEditList> MakeCollection(List<IncomeDto> records)
        {
            var newData = new ExtRangeCollection<IncomeEditList>();

            foreach (var rec in records)
            {
                var e = new IncomeEditList();
                e.Make(rec);

                newData.AddItem(e);
            }


            return newData;
        }

        public void ResetChanges()
        {
            this._current = this._original;
        }

        public IncomeDto ConvertToDto()
        {
            var newIncomeDto = _sourceIncomeDto.Clone();



            newIncomeDto.Id = this.Id;
            newIncomeDto.ManagementUnitId = this.ManagementUnitId;
            newIncomeDto.WorkOrderDescription = this.WorkOrderDescription;
            newIncomeDto.Forecast = this.Forecast;
            newIncomeDto.Budget = this.Budget;
            newIncomeDto.Product = this.Product;
            newIncomeDto.StartDate = this.StartDate;
            newIncomeDto.EndDate = this.EndDate;
            newIncomeDto.IsProject = this.IsProject;
            newIncomeDto.WorkOrder = this.WorkOrder;
            newIncomeDto.ProductId = this.ProductId;
            newIncomeDto.AimId = this.AimId;
            newIncomeDto.BudgetNet = this.BudgetNet;
            newIncomeDto.BudgetNetTotal = this.BudgetNetTotal;
            newIncomeDto.ForecastNet = this.ForecastNet;
            newIncomeDto.ForecastNetTotal = this.ForecastNetTotal;
            newIncomeDto.VatRateId = this.VatRateId;
            newIncomeDto.ClmdInvd = this.ClmdInvd;
            newIncomeDto.Actual = this.Actual;
            newIncomeDto.SoNo = this.SoNo;
            newIncomeDto.SoDate = this.SoDate;
            newIncomeDto.Received = this.Received;
            newIncomeDto.Completed = this.Completed;
            newIncomeDto.GrantSchemeId = this.GrantSchemeId;
            newIncomeDto.GrantSchemeDescription = this.GrantSchemeDescription;
            newIncomeDto.Pe = this.Pe;
            newIncomeDto.Pipeline = this.Pipeline;
            newIncomeDto.Confidential = this.Confidential;
            newIncomeDto.NoAgressoUpdate = this.NoAgressoUpdate;
            newIncomeDto.Description = this.Description;
            newIncomeDto.TaskCodeId = this.TaskCodeId;



            return newIncomeDto;
        }
    }//endofclass
}