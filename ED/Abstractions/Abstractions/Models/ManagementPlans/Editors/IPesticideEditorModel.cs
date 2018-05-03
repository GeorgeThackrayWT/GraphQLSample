using System.ComponentModel;
using Abstractions.Models.ManagementPlans.Editors;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Administration.Editors;

namespace Abstractions.Models.ManagementPlans
{
    public interface IPesticideEditorModel : IBaseModel,  INotifyPropertyChanged
    {
        ExtRangeCollection<PesticideAdminEdit> Records { get; set; }

        PesticideAdminEdit EditRecord { get; set; }

        ExtRangeCollection<PesticideEntryEditList> PesticideEntryRecords { get; set; }

        PesticideEntryEditList PesticideEntryEditRecord { get; set; }

    }
}
