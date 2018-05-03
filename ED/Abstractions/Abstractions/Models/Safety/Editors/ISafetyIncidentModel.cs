using System.ComponentModel;
using DataObjects;
using DataObjects.DTOS.SafetyObjects.Editors;
using MvvmHelpers;

namespace Abstractions
{
    public interface ISafetyIncidentModel : IBaseModel, INotifyPropertyChanged
    {
        ExtRangeCollection<HazardIncidentEditList> Records { get; set; }

        HazardIncidentEditList EditRecord { get; set; }

        int HazardId { get; set; }

    }
}