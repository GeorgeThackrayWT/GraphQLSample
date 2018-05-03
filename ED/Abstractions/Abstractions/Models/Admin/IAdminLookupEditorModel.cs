using System.Collections.Generic;
using DataObjects.DTOS.AdministrationArea;

namespace Abstractions.Models.Admin
{
    public interface IAdminLookupEditorModel
    {
        List<AdminLookupEditorDTO> LookupEditorDtos { get; set; }
    }
}