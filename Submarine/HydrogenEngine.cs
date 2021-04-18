using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    class HydrogenEngine : Engine
    {
        override public double Refill(double amount)
        {
            fuel.Amount += amount;
            return amount * 10;
        }
        override public void OneDayOfTravel()
        {
            fuel.Amount -= 10;
        }
    }
}
