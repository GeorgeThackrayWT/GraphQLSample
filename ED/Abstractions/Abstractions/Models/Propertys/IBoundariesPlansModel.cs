using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IBoundariesPlansModel : IPropInfoBase, INotifyPropertyChanged
    {
       ExtRangeCollection<BoundariesAndPlanEdit> Records { get; set; }

       BoundariesAndPlanEdit EditRecord { get; set; }
    }

  
}