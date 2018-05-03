using System;

namespace Abstractions.Navigation
{
    public interface INavigation
    {
        Object Frame { get; set; }

        Type DefaultLocation { get; }

        bool Navigate(Type sourcePageType);

        bool Navigate(Type sourcePageType, object parameter);

        bool SidebarNavigate(object parameter);

        void EnableBackButton();

        void DisableBackButton();

        void GoBack();

        bool OnPage(Type sourcePageType);

        string CurrentLocation { get; }
    }
}
