using System.Collections.Generic;

namespace CommandAdapter
{
    class Adapter : IThingsToReapir
    {
        private Mechanic adapter = new();

        public void DoIt(List<IRepair> items)
        {
            foreach (var item in items)
            {
                adapter.Add(item);
            }
            adapter.DoIt();
        }
    }
}
