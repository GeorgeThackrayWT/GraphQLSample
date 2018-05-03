using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace Abstractions.Stores.Content.ManagementPlans
{
    public interface IBaseStore
    {
        List<ComboBoxValue> GetYears();
    }
}
