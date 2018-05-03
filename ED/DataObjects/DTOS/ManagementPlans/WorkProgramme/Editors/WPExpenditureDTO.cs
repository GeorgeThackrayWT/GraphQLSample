//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using Abstractions;
//using MvvmHelpers;

//namespace DataObjects.DTOS.ManagementPlans.Editors
//{

//    public class WPExpenditureDTOBO : ListObj<WPExpenditureDTO>, INotifyPropertyChanged
//    {

//        public WPExpenditureDTOBO()
//        {

//            this.Validator = e =>
//            {
//                if (StartDate > DateTime.Today.AddYears(1))
//                {
//                    e.Errors.Add("Start Date should be before 2018");
//                }

//                if (EndDate > DateTime.Today.AddYears(1))
//                {
//                    e.Errors.Add("End Date should be before 2018");
//                }

//                if (string.IsNullOrEmpty(Description))
//                {
//                    e.Errors.Add("Description is NULL or Empty");
//                }
//            };




//        }

//        public int Id { get => _current.ID; set { _current.ID = value; OnPropertyChanged(); } }

//        public int ManagementUnitId { get => _current.ManagementUnitID; set { _current.ManagementUnitID = value; OnPropertyChanged(); } }

//        public string WorkOrder { get => _current.WorkOrder; set { _current.WorkOrder = value; OnPropertyChanged(); } }

//        public string Product { get => _current.Product; set { _current.Product = value; OnPropertyChanged(); } }

//        public DateTime StartDate { get => _current.StartDate; set { _current.StartDate = value; OnPropertyChanged(); } }

//        public DateTime EndDate { get => _current.EndDate; set { _current.EndDate = value; OnPropertyChanged(); } }

//        public double Budget { get => _current.Budget; set { _current.Budget = value; OnPropertyChanged(); } }

//        public double? Forecast { get => _current.Forecast; set { _current.Forecast = value; OnPropertyChanged(); } }

//        public double? Actual { get => _current.Actual; set { _current.Actual = value; OnPropertyChanged(); } }

//        public int Remaining { get => _current.Remaining; set { _current.Remaining = value; OnPropertyChanged(); } }

//        public string PONo { get => _current.PONo; set { _current.PONo = value; OnPropertyChanged(); } }

//        public bool? GRN { get => _current.GRN; set { _current.GRN = value; OnPropertyChanged(); } }

//        public bool Completed { get => _current.Completed; set { _current.Completed = value; OnPropertyChanged(); } }

//        public string Description
//        {
//            get => _current.Description;
//            set
//            {
//                _current.Description = value;
//                OnPropertyChanged();
//            }
//        }


//        public void Make(WPExpenditureDTO test)
//        {
//            _original.ID = test.ID;
//            _current.ID = test.ID;

//            _original.ManagementUnitID = test.ManagementUnitID;
//            _current.ManagementUnitID = test.ManagementUnitID;

//            _original.WorkOrder = test.WorkOrder;
//            _current.WorkOrder = test.WorkOrder;

//            _original.Product = test.Product;
//            _current.Product = test.Product;

//            _original.StartDate = test.StartDate;
//            _current.StartDate = test.StartDate;

//            _original.EndDate = test.EndDate;
//            _current.EndDate = test.EndDate;

//            _original.Budget = test.Budget;
//            _current.Budget = test.Budget;

//            _original.Forecast = test.Forecast;
//            _current.Forecast = test.Forecast;

//            _original.Actual = test.Actual;
//            _current.Actual = test.Actual;

//            _original.Remaining = test.Remaining;
//            _current.Remaining = test.Remaining;

//            _original.PONo = test.PONo;
//            _current.PONo = test.PONo;

//            _original.GRN = test.GRN;
//            _current.GRN = test.GRN;

//            _original.Completed = test.Completed;
//            _current.Completed = test.Completed;

//            _original.Description = test.Description;
//            _current.Description = test.Description;

//        }//endofmake

//        public static ExtRangeCollection<WPExpenditureDTOBO> MakeCollection(List<WPExpenditureDTO> records)
//        {
//            var newData = new ExtRangeCollection<WPExpenditureDTOBO>();

//            foreach (var rec in records)
//            {
//                var e = new WPExpenditureDTOBO();
//                e.Make(rec);

//                newData.AddItem(e);
//            }


//            return newData;
//        }




//    }//endofclass


//    public class WPExpenditureDTO :BaseDto, IRecord
//    {
//        public int ID { get; set; }
//        public int ManagementUnitID { get; set; }
//        public string WorkOrder { get; set; }
//        public string Product { get; set; }
//        public DateTime StartDate { get; set; }
//        public DateTime EndDate { get; set; }
//        public double Budget { get; set; }
//        public double? Forecast { get; set; }
//        public double? Actual { get; set; }
//        public int Remaining { get; set; }
//        public string PONo { get; set; }
//        public bool? GRN { get; set; }
//        public bool Completed { get; set; }
//        public string Description { get; set; }
         
//    }
//}