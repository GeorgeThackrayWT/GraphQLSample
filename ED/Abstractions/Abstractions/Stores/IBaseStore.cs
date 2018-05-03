using System.Collections.Generic;
using DataObjects;

namespace Abstractions
{
    public interface IBaseStore
    {
        List<ComboBoxValue> GetYears();
    }


}