
//todo move this thing to abstractions project somehow within creating a circular reference .

using System;

namespace DataObjects
{
    public interface IComboBoxValue 
    {
        int ID { get; set; }

        string Name { get; set; }

        string Description { get; set; }
    }
}
