using Abstractions;

namespace EDCORE.ViewModel
{
    public class PlatformEventHandling : IPlatformEventHandling
    {
        private readonly IRoutedEventArgsHandler _iRoutedEventArgsHandler;
        private readonly ITappedRouteEventHandler _tappedRouteEventHandler;
        private readonly IDatePickerArgsHandler _datePickerArgsHandler;
        private readonly IPivotSelectionEventHandler _pivotSelectionEventHandler;
        private readonly IRadGridEventHandler _radGridEventHandler;

        public IRoutedEventArgsHandler RoutedEventArgsHandler => _iRoutedEventArgsHandler;

        public ITappedRouteEventHandler TappedRouteEventHandler => _tappedRouteEventHandler;

        public IDatePickerArgsHandler DatePickerArgsHandler => _datePickerArgsHandler;

        public IPivotSelectionEventHandler PivotSelectionEventHandler => _pivotSelectionEventHandler;

        public IRadGridEventHandler IRadGridEventHandler => _radGridEventHandler;

        public PlatformEventHandling(ITappedRouteEventHandler iTappedRouteEventHandler, 
            IRoutedEventArgsHandler iRoutedEventArgsHandler,
            IDatePickerArgsHandler iDatePickerArgsHandler,
            IPivotSelectionEventHandler iPivotSelectionEventHandler, 
            IRadGridEventHandler iRadGridEventHandler)
        {
            _iRoutedEventArgsHandler = iRoutedEventArgsHandler;
            _tappedRouteEventHandler = iTappedRouteEventHandler;
            _datePickerArgsHandler = iDatePickerArgsHandler;
            _pivotSelectionEventHandler = iPivotSelectionEventHandler;
            _radGridEventHandler = iRadGridEventHandler;

        }
        
    }
}