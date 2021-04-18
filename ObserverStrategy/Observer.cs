using System;

namespace ObserverStrategy
{
    class Observer
    {
        readonly string name;
        readonly int numberOfCashRegisters;
        readonly int surfaceOfStore;

        public Observer(string name, int numberOfCashRegisters, int surfaceOfStore)
        {
            this.name = name;
            this.numberOfCashRegisters = numberOfCashRegisters;
            this.surfaceOfStore = surfaceOfStore;
        }
        public void Received(int value)
        {
            if(surfaceOfStore > 100)
            {
                if (value > (surfaceOfStore / 15)) Console.WriteLine("In store is " + value + " people. You can't entry to " + name);
                else Console.WriteLine("In store is " + value + " people. You can entry to  [" + name + "]");
            }
            else
            {
                if (value > (numberOfCashRegisters*4)) Console.WriteLine("In store is " + value + " people. You can't entry to " + name);
                else Console.WriteLine("In store is " + value + " people. You can entry to  [" + name + "]");
            }
        }
    }
}
