using System.Windows.Input;

namespace Abstractions.Models.PublicInformation
{
    public interface IPublicInformationSearch<T> : IGeneralManagementPlanSearchModel<T>
    {
        ICommand ViewDirections { get; set; }
        ICommand ViewLocations { get; set; }

        bool DirectionsFieldVisible { get; set; }

        string DirectionsDescription { get; set; }
    }
}
