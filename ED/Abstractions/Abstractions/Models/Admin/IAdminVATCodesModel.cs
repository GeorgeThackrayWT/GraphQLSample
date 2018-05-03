using DataObjects.DTOS.AdministrationArea;
using MvvmHelpers;

namespace Abstractions.Models.Admin
{
    public interface IAdminVATCodesModel
    {
        AdminVATCodeCollection VatCodes { get; set; }

        ObservableRangeCollection<SectionDescriptionDto> SectionLookup { get; set; }
    }
}