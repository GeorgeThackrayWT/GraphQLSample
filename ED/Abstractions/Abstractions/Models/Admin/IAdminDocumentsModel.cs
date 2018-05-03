using DataObjects;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminDocumentsModel
    {
        AdminDocumentsDTOEdit EditRecord { get; set; }

        ExtRangeCollection<AdminDocumentsDTOEdit> RecordsFlip { get; set; }
    }


    
}