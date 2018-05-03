using System;

namespace DataObjects
{
    public class StateContainer : IEquatable<StateContainer>
    {
        public int RecordId { get; set; }

        public Tuple<int, string> Tuple { get; set; }

        public bool NewRecord { get; set; }

        public static StateContainer Create(int recordId, bool isNew)
        {
            return new StateContainer() { NewRecord = isNew, RecordId = recordId };
        }
        public static StateContainer Create(int recordId, string data, bool isNew)
        {
            return new StateContainer() { NewRecord = isNew, Tuple = new Tuple<int, string>(recordId, data) };
        }

        public bool Equals(StateContainer other)
        {
            return this.RecordId == other.RecordId && this.NewRecord == other.NewRecord;
        }

        public override int GetHashCode()
        {
            return RecordId.GetHashCode();  // see other links for hashcode guidance 
        }

        public static int GetRecordId(object param)
        {
            var stateContainer = param as StateContainer;

            if (stateContainer != null)
                return stateContainer.RecordId;
            else
                return 0;
        }

        public static StateContainer GetFromObject(object param)
        {
            var stateContainer = param as StateContainer;

            if (stateContainer?.Tuple != null)
            {
                stateContainer.RecordId = stateContainer.Tuple.Item1;
            }

            if (stateContainer != null) return stateContainer;

            return new StateContainer();
        }

    }
}
