using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS;
using MvvmHelpers;

namespace Abstractions
{

    public interface IInternalDesignationsModel : IBaseModel, INotifyPropertyChanged
    {
        ExtRangeCollection<InternalDesignationEdit> Records { get; set; }

        InternalDesignationEdit EditRecord { get; set; }

        AUIDEdit ParentAcquistionUnit { get; set; }
    }
}
