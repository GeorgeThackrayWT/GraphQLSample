using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IThirdPartyRightsModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
        ExtRangeCollection<ThirdPartyRightEdit> Records { get; set; }

        ThirdPartyRightEdit EditRecord { get; set; }
    }
}