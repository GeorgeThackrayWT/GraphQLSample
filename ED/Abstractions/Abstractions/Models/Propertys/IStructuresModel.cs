using System.ComponentModel;
using Abstractions;
using DataObjects;
using DataObjects.DTOS;

namespace EDCORE.ViewModel.Property.PropertyInfos
{
    public interface IStructuresModel : IBaseModel, IPropInfoBase, INotifyPropertyChanged
    {    
        ExtRangeCollection<StructureEdit> Records { get; set; }

        StructureEdit EditRecord { get; set; }
    }
}