using DataObjects;

namespace Abstractions
{
    public interface IPropertyRecord
    {
        Property<int> Id { get; set; }
        Property<bool> Deleted { get; set; }
    }

    public interface IRecord
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}