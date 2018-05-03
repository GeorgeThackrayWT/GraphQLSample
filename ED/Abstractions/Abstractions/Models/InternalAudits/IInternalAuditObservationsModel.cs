using System.ComponentModel;
using DataObjects.DTOS.InternalAudits;

namespace Abstractions.Models.InternalAudits
{
    public interface IInternalAuditObservationsModel : IBaseModel, INotifyPropertyChanged
    {
        InternalAuditsObservationEditEdit InternalAuditObservations { get; set; }

        
    }
}
