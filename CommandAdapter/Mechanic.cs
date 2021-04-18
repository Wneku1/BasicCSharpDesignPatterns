using System.Collections.Generic;

namespace CommandAdapter
{
    class Mechanic
    {
        private readonly List<IRepair> thingsToRepair;
        public Mechanic()
        {
            thingsToRepair = new List<IRepair>();
        }
        public void Add(IRepair thing)
        {
            thingsToRepair.Add(thing);
        }
        public void DoIt()
        {
            foreach (IRepair com in thingsToRepair)
            {
                com.Repair();
            }
        }
    }
}
