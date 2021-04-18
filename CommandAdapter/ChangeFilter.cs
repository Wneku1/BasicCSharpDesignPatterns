using System;

namespace CommandAdapter
{
    class ChangeFilter : IRepair
    {
        private readonly Filter filter;
        private readonly short cost;

        public ChangeFilter(Filter filter, short cost)
        {
            this.filter = filter;
            this.cost = cost;
        }
        public void Repair()
        {
            Console.WriteLine("Your filter: " + filter + " have been changed. It cost " + cost);
        }
    }
}
