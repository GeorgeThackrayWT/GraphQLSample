using System.ComponentModel;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IReferenceInformationModel : IBaseModel,  INotifyPropertyChanged
    {
        ReferenceInfoListDTO ReferenceInfoListDTO { get; }
        
    }
}