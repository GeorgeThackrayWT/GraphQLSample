using System;
using DataObjects;

namespace Abstractions
{
    public interface IChangeTracking
    {
        Property<DateTime> LMDT { get; set; }

        Property<int?> LMUID { get; set; }

        Property<DateTime?> CRDT { get; set; }

        Property<int?> CRUID { get; set; }

        Property<DateTime?> DLDT { get; set; }

        Property<int?> DLUID { get; set; }
    }
}