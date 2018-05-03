using Abstractions;

namespace EDCORE.ViewModel
{
    public interface IPlatformEventHandling
    {
        IRoutedEventArgsHandler RoutedEventArgsHandler { get; }
        ITappedRouteEventHandler TappedRouteEventHandler { get; }

        

        IDatePickerArgsHandler DatePickerArgsHandler { get; }

        IPivotSelectionEventHandler PivotSelectionEventHandler { get; }

        IRadGridEventHandler IRadGridEventHandler { get; }


    }
}