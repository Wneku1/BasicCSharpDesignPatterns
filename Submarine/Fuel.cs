using System;

namespace SubmarineProject
{
    class Fuel : IStorable
    {
        public double Amount { get; set; }
        public void HowMuchLeft()
        {
            Console.WriteLine("Fuel supply: " + Amount);
        }
    }
}
