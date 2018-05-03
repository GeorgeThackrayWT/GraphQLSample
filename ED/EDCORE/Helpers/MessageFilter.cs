using System;
using System.Collections.Generic;
using DataObjects;
using EDCORE.ViewModel;

namespace EDCORE.Helpers
{
    class EventRecord : IEquatable<EventRecord>
    {
        public Guid MessageId { get; set; }
        public string Destination { get; set; }

        public EdEvent EdEvent { get; set; }

        public bool Equals(EventRecord other)
        {
            return MessageId == other.MessageId && Destination == other.Destination && EdEvent == other.EdEvent;
        }
    }

    public class MessageFilter
    {
        private readonly List<EventRecord> _eventLog = new List<EventRecord>();

        public bool FilterHandledMessages(EdMessage message,string instanceId, bool showDebug=false)
        {
            InstanceData instanceData = message.Data as InstanceData;



            var newEvent = new EventRecord
            {
                EdEvent = message.EdEvent,

                MessageId = message.InstanceId
            };

            if (instanceData != null)
            {
                newEvent.Destination = instanceId;
            }


            if (_eventLog.Contains(newEvent)) return true;

            _eventLog.Add(newEvent);
            
            // make sure this doesnt get too big
            if(_eventLog.Count > 10)
                _eventLog.RemoveAt(0);


            return false;
        }
    }
}