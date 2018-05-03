using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IPartDisposalsModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
        ExtRangeCollection<PartDisposalEdit> Records { get; set; }

        PartDisposalEdit EditRecord { get; set; }
    }
}