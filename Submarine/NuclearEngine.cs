using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    class NuclearEngine : Engine
    {
        private Waste nuclearWaste; 
        public NuclearEngine()
        {   
            nuclearWaste = new Waste("Nuclear waste");
        }
        public override void CheckSupplies()
        {
            base.CheckSupplies();
            nuclearWaste.HowMuchLeft();
        }
        override public double Refill(double amount)
        {
            double costRefill;
            fuel.Amount += amount;
            costRefill = amount * 10;
            return costRefill;
        }
        override public void OneDayOfTravel()
        {
            fuel.Amount -= 5;
            nuclearWaste.Amount++;
        }
    }
}
