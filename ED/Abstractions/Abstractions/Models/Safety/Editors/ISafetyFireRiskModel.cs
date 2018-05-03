using System.ComponentModel;
using DataObjects.DTOS.SafetyObjects.Editors;

namespace Abstractions.Models.Safety.Editors
{
    public interface ISafetyFireRiskModel : IBaseModel, INotifyPropertyChanged
    {
        FireRiskCollectionEdit Record { get; set; }

        int HazardID { get; set; }

    }
}