using System;
using DataObjects;

namespace Abstractions
{

    public interface IRadGridTappedEventHandler
    {
        string Process(object sender, object args);
    }

    public interface ITappedRouteEventHandler
    {
        string Process(object sender, object args);
    }

    public interface IRoutedEventArgsHandler
    {
        string Process(object sender, object args);

        string Parents(object sender, object args);


    }

    public interface IDatePickerArgsHandler
    {
        DateTime? Process(object sender, object args);
    }

    public interface IPivotSelectionEventHandler
    {
        object Process(object sender, object args);
    }

    public interface IRadGridEventHandler
    {
        RadGridSelectionDto Process(object sender, object args);
    }

}