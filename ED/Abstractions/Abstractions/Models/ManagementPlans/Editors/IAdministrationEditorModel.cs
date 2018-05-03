using System.ComponentModel;
using System.Windows.Input;
using DataObjects;

namespace Abstractions.Models.ManagementPlans.Editors
{
    public interface IAdministrationEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        AdminEditDTOEdit AdminEditDTO { get;}

        ICommand LoadPesticides { get; }      
    }

}
