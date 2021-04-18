using System;

namespace CommandAdapter
{
    class AirConditioning : IRepair
    {
        private readonly short cost;
        public AirConditioning(short cost)
        {
            this.cost = cost;
        }
        public void Repair()
        {
            Console.WriteLine("Your air conditioning factor has been replenished it cost: " + cost);
        }
    }
}
