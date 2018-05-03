using System.ComponentModel;
using DataObjects.DTOS.InternalAudits;
using MvvmHelpers;

namespace Abstractions.Models.InternalAudits
{
    public interface IInternalAuditWoodListModel : IBaseModel, INotifyPropertyChanged
    {
        ObservableRangeCollection<InternalAuditsWoodlist> InternalAuditsWoodList { get; }

        InternalAuditsWoodlist SelectedAuditsWoodlist { get; set; }

        int InternalAuditId { get; set; }
    }
}