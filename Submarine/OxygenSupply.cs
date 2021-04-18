using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    class OxygenSupply : IStorable
    {
        public double Amount{get; set;}
        public double MaxCapacity { get; set; }
        public void HowMuchLeft()
        {
            Console.WriteLine("Oxygen supply: " + Amount);
        }
        public  OxygenSupply(double capacity)
        {
            MaxCapacity = capacity;
            Amount = capacity;
        }
    }
}
