using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS;
using MvvmHelpers;

namespace Abstractions
{
    public interface IExternalDesignationsModel : IBaseModel, INotifyPropertyChanged
    {
        ExtRangeCollection<ExternalDesignationEdit> Records { get; set; }

        ExternalDesignationEdit EditRecord { get; set; }

        AUIDEdit ParentAcquistionUnit { get; set; }

     
    }
}