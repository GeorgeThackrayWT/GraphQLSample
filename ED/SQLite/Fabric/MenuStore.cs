using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects.DAOS;
using DataObjects.DTOS;



namespace Stores
{
    public class MenuStore : BaseStore, IMenuStore
    {
        private readonly ISQLiteCache _iCache;


        public MenuStore(IDBPlatformSettings platform, ISQLiteCache iCache)
        {
            _platform = platform;

            _iCache = iCache;

            _sqLiteSyncConnection = GetSynchConnection();
        }
 
      
        public IEnumerable<MenuDTO> GetTier1Menus()
        {
            var menuDtos = new List<MenuDTO>();

            var menus = _sqLiteSyncConnection.Table<Menu>().Where(p=>p.ParentMenuId==0 && p.Caption!="Hamburger").OrderBy(p=>p.ID).ToList();
      
            menuDtos.AddRange(menus.Select(t => new MenuDTO()
            {
                Text = t.Caption,
                Destination = t.Destination,
                Id = t.ID,
                ParentMenuId = t.ParentMenuId
            }));

            return menuDtos;
        }

        public IEnumerable<MenuDTO> GetTier2Menus()
        {
            var menuDtos = new List<MenuDTO>();

            var menus = _sqLiteSyncConnection.Table<Menu>().Where(w => w.ParentMenuId != 0).ToList();

            menuDtos.AddRange(menus.Select(t => new MenuDTO()
            {
                Text = t.Caption,
                Destination = t.Destination,
                Id = t.ID,
                ParentMenuId = t.ParentMenuId
            }));

            return menuDtos;
        }



        #region CRUD

        public void CreateMenusAsynch()
        {
          _sqLiteSyncConnection.CreateTable<Menu>();          
        }


        public void CreateInternalDesignations()
        {                  
            _sqLiteSyncConnection.CreateTable<InternalDesignation>();
           
            _sqLiteSyncConnection.CreateTable<InternalDesignationType>();       
        }

        public void AddMenuData()
        {

            var delResult = _sqLiteSyncConnection.DeleteAll<Menu>();

            var topMenu = new List<Menu>
            {
                new Menu {ID = 1, Caption = "Tasks", Destination = "tasks", ParentMenuId = 0},
                new Menu {ID = 2, Caption = "Property", Destination = "property", ParentMenuId = 0},
                new Menu {ID = 3, Caption = "Management Plans", Destination = "managementplans", ParentMenuId = 0},
                new Menu {ID = 4, Caption = "Safety", Destination = "safety", ParentMenuId = 0},
                new Menu {ID = 5, Caption = "Tree Planting", Destination = "treeplanting", ParentMenuId = 0},
                new Menu {ID = 6, Caption = "Public Information", Destination = "publicinformation", ParentMenuId = 0},
                new Menu {ID = 7, Caption = "Maps", Destination = "maps", ParentMenuId = 0},
                new Menu {ID = 8, Caption = "Reports", Destination = "reports", ParentMenuId = 0},
                new Menu {ID = 9, Caption = "Internal Audits", Destination = "internalaudits", ParentMenuId = 0},
                new Menu {ID = 10, Caption = "Documents", Destination = "documents", ParentMenuId = 0},
                new Menu { ID = 11, Caption = "Administration Area", Destination = "administrationarea", ParentMenuId = 0  }
            };


            var tasksMenu = new List<Menu>
            {
                new Menu {ID = 12, Caption = "Today", Destination = "taskstoday", ParentMenuId = 1},
                new Menu {ID = 13, Caption = "Week", Destination = "taskweek", ParentMenuId = 1},
                new Menu {ID = 14, Caption = "Month", Destination = "taskmonth", ParentMenuId = 1},
                new Menu {ID = 15, Caption = "Year", Destination = "taskyear", ParentMenuId = 1},
                new Menu {ID = 16, Caption = "All", Destination = "taskall", ParentMenuId = 1}
            };

            var managementPlansMenu = new List<Menu>
            {
                new Menu {ID = 17, Caption = "Administration", Destination = "administration", ParentMenuId = 3},
                new Menu {ID = 18, Caption = "Grant Contracts", Destination = "grantcontracts", ParentMenuId = 3},
                new Menu {ID = 19, Caption = "Condition Assessment", Destination = "conditionassessment", ParentMenuId = 3},
                new Menu {ID = 20, Caption = "Summary Description", Destination = "summarydescription", ParentMenuId = 3},
                new Menu {ID = 21, Caption = "Objectives KF", Destination = "objectiveskf", ParentMenuId = 3},
                new Menu {ID = 22, Caption = "Work Programme", Destination = "workprogramme", ParentMenuId = 3},
                new Menu {ID = 23, Caption = "Purchase Orders", Destination = "purchaseorders", ParentMenuId = 3},
                new Menu {ID = 24, Caption = "Sales Orders", Destination = "salesorders", ParentMenuId = 3},
                new Menu {ID = 25, Caption = "Monitoring", Destination = "monitoring", ParentMenuId = 3},
                new Menu {ID = 26, Caption = "Harvesting", Destination = "harvesting", ParentMenuId = 3},
                new Menu {ID = 27, Caption = "Reference Information", Destination = "referenceinformation", ParentMenuId = 3}
            };

            var adminMenus = new List<Menu>
            {
                new Menu {ID = 28, Caption = "General Details", Destination = "general details", ParentMenuId = 11},
                new Menu {ID = 29, Caption = "Users and Groups", Destination = "users and groups", ParentMenuId = 11},
                new Menu {ID = 30, Caption = "Work Programme", Destination = "work programme", ParentMenuId = 11},
                new Menu {ID = 31, Caption = "Reports", Destination = "reports", ParentMenuId = 11},
                new Menu {ID = 32, Caption = "VAT Codes", Destination = "vat codes", ParentMenuId = 11},
                new Menu {ID = 33, Caption = "Lookup Editor", Destination = "lookup editor", ParentMenuId = 11},
                new Menu {ID = 34, Caption = "WTFL Sites", Destination = "wtfl sites", ParentMenuId = 11},
                new Menu {ID = 35, Caption = "Funded Project Sites", Destination = "funded project sites", ParentMenuId = 11},
                new Menu {ID = 36, Caption = "Income Products", Destination = "income products", ParentMenuId = 11},
                new Menu {ID = 37, Caption = "Expenditure Products", Destination = "expenditure products", ParentMenuId = 11},
                new Menu {ID = 38, Caption = "VAT Rate Locks", Destination = "vat rate locks", ParentMenuId = 11},
                new Menu {ID = 39, Caption = "Documents", Destination = "documents", ParentMenuId = 11}
            };

            

            _sqLiteSyncConnection.InsertAll(topMenu);

            _sqLiteSyncConnection.InsertAll(tasksMenu);

            _sqLiteSyncConnection.InsertAll(managementPlansMenu);

            _sqLiteSyncConnection.InsertAll(adminMenus);

        }


        #endregion
    }

   
}