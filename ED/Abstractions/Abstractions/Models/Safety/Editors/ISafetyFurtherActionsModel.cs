using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using MvvmHelpers;

namespace Abstractions
{
    public interface ISafetyFurtherActionsModel : IBaseModel, INotifyPropertyChanged
    {
        ExtRangeCollection<HazardActionEdit> Records { get; set; }

        HazardActionEdit EditRecord { get; set; }

        int HazardId { get; set; }
        
    }
}