using System.ComponentModel;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IWorkProgrammeEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        WorkProgrammeListDTO WorkProgrammeListDTO { get; }
        
    }
}