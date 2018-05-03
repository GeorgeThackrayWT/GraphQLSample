using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using DataObjects.DTOS;
using EDC_Estate.Models.DB;

namespace EFStores.Fabric
{
    public class MenuEFStore : BaseEFStore, IMenuStore
    {
        public MenuEFStore(EstateContext ec,ICache iCache) : 
            base(ec,iCache)
        {
        }

        public IEnumerable<MenuDTO> GetTier1Menus()
        {
            var menuDtos = new List<MenuDTO>();

            var menus = Context.Menu.Where(p => p.ParentMenuId == 0 && p.Caption != "Hamburger").OrderBy(p => p.Id).ToList();

            menuDtos.AddRange(menus.Select(t => new MenuDTO()
            {
                Text = t.Caption,
                Destination = t.Destination,
                Id = t.Id,
                ParentMenuId = t.ParentMenuId
            }));

            return menuDtos;
        }

        public IEnumerable<MenuDTO> GetTier2Menus()
        {
            var menuDtos = new List<MenuDTO>();

            var menus = Context.Menu.Where(w => w.ParentMenuId != 0).ToList();

            menuDtos.AddRange(menus.Select(t => new MenuDTO()
            {
                Text = t.Caption,
                Destination = t.Destination,
                Id = t.Id,
                ParentMenuId = t.ParentMenuId
            }));

            return menuDtos;
        }

        #region CRUD
        public void CreateMenusAsynch()
        {
            throw new NotImplementedException();
        }

        public void AddMenuData()
        {
            throw new NotImplementedException();
        }

        public void CreateInternalDesignations()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
