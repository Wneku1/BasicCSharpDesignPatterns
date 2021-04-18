using System.Collections.Generic;

namespace CommandAdapter
{
    interface IThingsToReapir
    {
        public void DoIt(List<IRepair> items);
    }
}
