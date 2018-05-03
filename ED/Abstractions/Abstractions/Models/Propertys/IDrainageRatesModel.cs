using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IDrainageRatesModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
 
        ExtRangeCollection<DrainageRateEdit> Records { get; set; }

        DrainageRateEdit EditRecord { get; set; }
    }
}