using DataObjects.DTOS;
using MvvmHelpers;

namespace EDCORE.Helpers
{


    public interface IMenuFormatter
    {

        ObservableRangeCollection<MenuDTO> GetTier1Menus();

        ObservableRangeCollection<MenuDTO> GetTier2Menus();


    }


}
