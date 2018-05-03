using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;
using Abstractions.Stores;
using DataObjects;
using DataObjects.DAOS;
using DataObjects.DTOS.ManagementPlans;
using FreshMvvm;
using Task = System.Threading.Tasks.Task;

namespace SQLite
{
    public class Cache : ISQLiteCache
    {
        private IManagementUnitStore _iManagementUnitStore;

        private IPropertyStore _iPropertyStore;

        private IUserStore _iUserStore;

        private IRegionStore _regionStore;

        private ITaskStore _taskStore;

        private IManagementPlanStore _iManagementPlanStore;

        private IPurchasesStore _iPurchasesStore;

        private ISalesStore _iSalesStore;

        private List<Expenditure> _expenditures;

        private List<IncomeDto> _incomes;

        private List<ManagementUnitDto> _managementUnits;

        private List<AcquisitionUnit> _acquisitionUnit;

        private List<User> _users;

        private List<ManagementPlanDto> _managementPlan;


        private Dictionary<int, string> _taskCategories;

        private Dictionary<int, string> _userLookup;

        private Dictionary<int, string> _tenureLookup;

        private Dictionary<int, string> _regionLookup;

        private Task _ackTask;
        private Task _manUTask;
        private Task _userTask;
        private Task _tenureTask;
        private Task _regionTask;
        private Task _catTask;
        private Task _manPlanTask;
        private Task _expenditureTask;
        private Task _incomeTask;



        public bool AcquisitionUnitsLoaded { get; set; }

        public bool ManagementUnitsLoaded { get; set; }

        public bool ManagementPlansLoaded { get; set; }

        public bool UsersLoaded { get; set; }

        public bool RegionsLoaded { get; set; }

        public bool TenuresLoaded { get; set; }

        public bool TaskCategoriesLoaded { get; set; }

        public bool IncomesLoaded { get; set; }

        public bool ExpendituresLoaded { get; set; }


        public List<AcquisitionUnit> AcquisitionUnits
        {
            get
            {
                ProcessTask(_ackTask, AcquisitionUnitsLoaded);

                return _acquisitionUnit;
            }
            set { _acquisitionUnit = value; }
        }

        public List<ManagementUnitDto> ManagementUnits
        {
            get
            {
                ProcessTask(_manUTask, ManagementUnitsLoaded);
                return _managementUnits;
            }
            set { _managementUnits = value; }
        }

        public List<User> Users
        {
            get
            {
                ProcessTask(_userTask, UsersLoaded);

                Task.WaitAll(_userTask);

                return _users;
            }
            set { _users = value; }
        }

        public Dictionary<int, string> UserLookup
        {
            get
            {

                ProcessTask(_userTask, UsersLoaded);

                Task.WaitAll(_userTask);

                return _userLookup;
            }
        }

        public Dictionary<int, string> RegionLookup
        {
            get
            {
                ProcessTask(_regionTask, RegionsLoaded);

                Task.WaitAll(_regionTask);

                return _regionLookup;
            }
        }

        public Dictionary<int, string> TenureLookup
        {
            get
            {
                ProcessTask(_tenureTask, TenuresLoaded);

                Task.WaitAll(_tenureTask);

                return _tenureLookup;
            }
        }

        public Dictionary<int, string> TaskCategories
        {
            get
            {
                ProcessTask(_catTask, TaskCategoriesLoaded);

                Task.WaitAll(_catTask);

                return _taskCategories;
            }
        }

        public List<ManagementPlanDto> ManagementPlans
        {
            get
            {
                ProcessTask(_manPlanTask, ManagementPlansLoaded);

                return _managementPlan;
            }
            set { _managementPlan = value; }
        }




        public List<Expenditure> Expenditures
        {
            get
            {
                ProcessTask(_expenditureTask, ExpendituresLoaded);

                return _expenditures;
            }

            set
            {
                _expenditures = value;
            }
        }



        public List<IncomeDto> Incomes
        {
            get
            {
                ProcessTask(_incomeTask, IncomesLoaded);

                return _incomes;
            }

            set { _incomes = value; }
        }

        public Cache()
        {
            //    ////Debug.WriteLine("Cache created");



        }

        private void ProcessTask(Task myTask, bool dataLoaded)
        {
            if (!dataLoaded && myTask.Status != TaskStatus.Running)
                myTask.Start();

            Task.WaitAll(myTask);


        }

        public void Init()
        {

            SetDependencies();

            CreateTasks();
        }

        public void Init(IManagementUnitStore iManagementUnitStore,
            IPropertyStore iPropertyStore,
            IUserStore iUserStore,
            IRegionStore iRegionStore,
            ITaskStore iTaskStore,
            IManagementPlanStore iManagementPlanStore,
            IPurchasesStore iPurchasesStore,
            ISalesStore iSalesStore
            )
        {
            _iManagementUnitStore = iManagementUnitStore;
            _iPropertyStore = iPropertyStore;
            _iUserStore = iUserStore;
            _regionStore = iRegionStore;
            _taskStore = iTaskStore;
            _iManagementPlanStore = iManagementPlanStore;
            _iPurchasesStore = iPurchasesStore;
            _iSalesStore = iSalesStore;

            CreateTasks();
        }

        private void CreateTasks()
        {
            Debug.WriteLine("Cache created");

            AcquisitionUnitsLoaded = false;
            ManagementUnitsLoaded = false;
            ManagementPlansLoaded = false;
            UsersLoaded = false;
            RegionsLoaded = false;
            TenuresLoaded = false;
            TaskCategoriesLoaded = false;
            ExpendituresLoaded = false;
            IncomesLoaded = false;

            Stopwatch stopwatch = Stopwatch.StartNew();

            _expenditureTask = new Task(() =>
            {
                //_managementUnits = _iManagementPlanStore
                _expenditures = _iPurchasesStore.GetCacheExpenditures();
                ExpendituresLoaded = true;
                Debug.WriteLine("exp task loaded");
            });

            _incomeTask = new Task(() =>
            {
                //  _managementUnits = _iManagementUnitStore.GetManagementUnits();

                _incomes = _iSalesStore.GetIncomes();
                IncomesLoaded = true;
                Debug.WriteLine("incom task loaded");
            });


            _manUTask = new Task(() =>
            {
                _managementUnits = _iManagementUnitStore.GetManagementUnits();
                ManagementUnitsLoaded = true;
                Debug.WriteLine("manu task loaded");
            });

            _userTask = new Task(() =>
            {
                _users = _iUserStore.GetUsers();
                _userLookup = new Dictionary<int, string>();

                foreach (var u in _users)
                {
                    if (u?.DisplayName != null && u.DisplayName.Length > 0)
                        _userLookup.Add(u.ID, u.DisplayName);
                }

                UsersLoaded = true;

                if (!_userLookup.ContainsKey(0))
                {
                    _userLookup.Add(0, "");
                }


                Debug.WriteLine("user task loaded");
            });

            _catTask = new Task(() =>
            {
                var data = _taskStore.GetTaskCategories();

                _taskCategories = new Dictionary<int, string>();

                foreach (var d in data)
                {
                    _taskCategories.Add(d.ID, d.Description);
                }

                TaskCategoriesLoaded = true;


                Debug.WriteLine("cat task loaded");
            });

            _ackTask = new Task(() =>
            {
                _acquisitionUnit = _iPropertyStore.GetAcquisitionUnits();
                AcquisitionUnitsLoaded = true;

                Debug.WriteLine("ack  task loaded");
            });

            _tenureTask = new Task(() =>
            {
                var tenures = _iManagementUnitStore.GetTenures();

                _tenureLookup = new Dictionary<int, string>();

                foreach (var t in tenures)
                {
                    _tenureLookup.Add(t.Id, t.Description);
                }

                TenuresLoaded = true;

                Debug.WriteLine("tenure task loaded");
            });

            _regionTask = new Task(() =>
            {
                var regions = _regionStore.GetRegions().Result;

                _regionLookup = new Dictionary<int, string>();

                foreach (var r in regions)
                {
                    _regionLookup.Add(r.ID, r.Description);
                }

                RegionsLoaded = true;

                Debug.WriteLine("region task loaded");
            });

            _manPlanTask = new Task(() =>
            {
                _managementPlan = _iManagementUnitStore.GetManagementPlans();

                ManagementPlansLoaded = true;

                Debug.WriteLine("management plan loaded");
            });

            _manUTask.ContinueWith((x) =>
            {
                Debug.WriteLine("ContinueWith");
                if (_userTask.Status != TaskStatus.Running)
                    _userTask.Start();
            });

            _expenditureTask.Start();
            _incomeTask.Start();


            stopwatch.Stop();

            Debug.WriteLine("Cache loaded in: " + stopwatch.ElapsedMilliseconds);
        }

        private void SetDependencies()
        {
            _iManagementUnitStore = FreshIOC.Container.Resolve<IManagementUnitStore>();
            _iPropertyStore = FreshIOC.Container.Resolve<IPropertyStore>();
            _iUserStore = FreshIOC.Container.Resolve<IUserStore>();
            _regionStore = FreshIOC.Container.Resolve<IRegionStore>();
            _taskStore = FreshIOC.Container.Resolve<ITaskStore>();
            _iManagementPlanStore = FreshIOC.Container.Resolve<IManagementPlanStore>();

            _iPurchasesStore = FreshIOC.Container.Resolve<IPurchasesStore>();
            _iSalesStore = FreshIOC.Container.Resolve<ISalesStore>();

            //TinyIoCContainer.Current.Register<IPurchasesStore, PurchasesStore>();

            //TinyIoCContainer.Current.Register<ISalesStore, SalesStore>();


        }

        public int GetValue()
        {
            return 0;
        }
    }
}
