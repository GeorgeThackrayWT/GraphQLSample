using System;

namespace Abstractions
{
    public interface IWTTimer
    {
        TimeSpan Interval { get; set; }
    
        System.Boolean IsEnabled { get; }

        event EventHandler<System.Object> Tick;

        void Start();
       
        void Stop();
        
    }
}
