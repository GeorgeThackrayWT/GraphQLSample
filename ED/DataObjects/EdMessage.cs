using System;

namespace DataObjects
{
    public class EdMessage
    {
        public EdEvent EdEvent { get; set; }

        public object Data { get; set; }

        public Guid InstanceId { get; set; }

        public bool BaseIgnore { get; set; }
    }
}