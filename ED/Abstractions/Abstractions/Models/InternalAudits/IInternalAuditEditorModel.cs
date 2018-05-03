using System.ComponentModel;
using System.Windows.Input;
using DataObjects;
using DataObjects.DTOS.InternalAudits;
using MvvmHelpers;

namespace Abstractions.Models.InternalAudits
{
    public interface IInternalAuditEditorModel : IBaseModel, INotifyPropertyChanged
    {
        InternalAuditsEditEdit InternalAuditsEditDto { get; set; }

        ExtRangeCollection<InternalAuditsObservationEditEdit> Records { get; set; }

        InternalAuditsObservationEditEdit EditRecord { get; set; }

        int InternalAuditID { get; set; }

        ICommand Publish { get; }

        ICommand CertifyCorrect { get; }

        ICommand AutheriseCorrect { get; }
    }
}
