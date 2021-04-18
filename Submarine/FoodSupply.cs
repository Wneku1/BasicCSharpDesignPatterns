using System;

namespace SubmarineProject
{
    class FoodSupply : IStorable
    {
        public double Amount { get; set; }
        public void HowMuchLeft()
        {
            Console.WriteLine("Food supply: " + Amount);
        }
    }
}
