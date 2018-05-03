using System.ComponentModel;
using System.Windows.Input;
using DataObjects.DTOS.PublicInformationDtos;

namespace Abstractions.Models.PublicInformation
{
    public interface IPublicInfoEditorModel : IBaseModel, INotifyPropertyChanged
    {

        bool SpecialSiteFeaturesVisible { get; set; }

        bool SuitableForFilmingVisible { get; set; }

        bool AntiSocialVisible { get; set; }

        bool DirectoryInfoVisible { get; set; }

        bool LocalNameWhyVisible { get; set; }

        bool PartOfVisible { get; set; }

        bool ExtendedInfoVisible { get; set; }

   //     int ManagementUnitID { get; set; }

        ICommand PartOf { get; }

        PublicInformationEdit EditRecord { get; set; }

        ICommand PublicEvents { get; }

        ICommand SpecialSiteFeatures { get; }

        ICommand SuitableForFilming { get; }

        ICommand AntiSocialIssues { get; }

        ICommand DirectoryInfo { get; }

        ICommand LocationMap { get; }

        ICommand VisitorAccessMap { get; }

        ICommand WoodMicrosite { get; }

        ICommand ATHRegister { get; }

        ICommand PhotoLibrary { get; }

        ICommand OperationsPosters { get; }

        ICommand OtherSiteMaterial { get; }

        ICommand LocalNameWhy { get; }

        ICommand ExtendedInfo { get; }
    }
}