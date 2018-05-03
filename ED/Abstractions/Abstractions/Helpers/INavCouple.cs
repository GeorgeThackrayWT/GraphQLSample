using System;
using System.Windows.Input;

namespace Abstractions.Helpers
{
    public interface INavCouple
    {
        ICommand Command { get; }
        Type Editor();
    }
}
