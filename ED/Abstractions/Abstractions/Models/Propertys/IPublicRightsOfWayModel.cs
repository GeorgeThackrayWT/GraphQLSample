using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IPublicRightsOfWayModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {   
        ExtRangeCollection<PublicRightOfWayEdit> Records { get; set; }

        PublicRightOfWayEdit EditRecord { get; set; }
    }
}