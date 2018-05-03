using System.ComponentModel;

namespace Abstractions.Models.Safety.Editors
{
    public interface ISafetyBioRiskModel : IBaseModel, INotifyPropertyChanged
    {       
        int HazardID { get; set; }

    }
}