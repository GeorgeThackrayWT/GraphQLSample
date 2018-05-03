using System.Collections.Generic;
using DataObjects.DTOS;

namespace Abstractions
{
    public interface IMenuStore : IBaseStore
    {
        IEnumerable<MenuDTO> GetTier1Menus();

        IEnumerable<MenuDTO> GetTier2Menus();

        void CreateMenusAsynch();

        void AddMenuData();

       void CreateInternalDesignations();

    }
}