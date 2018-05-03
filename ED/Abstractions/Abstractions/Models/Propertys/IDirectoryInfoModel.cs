using System.ComponentModel;
using Abstractions;
using DataObjects.DTOS.property.subobjects;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IDirectoryInfoModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {
        DirectoryInfoDto DirectoryInfoDto { get; }

    }
}