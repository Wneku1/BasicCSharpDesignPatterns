using System;

namespace CommandAdapter
{
    class RepairBreaks : IRepair
    {
        private readonly Breaks breaks;
        private readonly short cost;

        public RepairBreaks (Breaks breaks,short cost )
        {
            this.breaks = breaks;
            this.cost = cost;
        }

        public void Repair()
        {
            Console.WriteLine("Your brakes: " + breaks + " have been fixed. It cost " + cost);
        }
    }
}
