using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    class Waste : IStorable
    {
        private readonly string name;
     
        public double Amount { get; set; }
        public void HowMuchLeft() 
        {
            Console.WriteLine("Generic wasted stored: " + Amount);
        }
        public Waste(string s)
        {
            name = s;
            Amount++;
        }
    }
}
