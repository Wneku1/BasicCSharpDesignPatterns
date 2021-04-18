using System;
using System.Collections.Generic;

namespace ObserverStrategy
{
    class ObserveStore
    {
        private readonly List<Observer> stores = new();
        public void Subscribed(Observer observer)
        {
            stores.Add(observer);
        }

        public void Unsubscribed(Observer observer)
        {
            stores.Remove(observer);
        }
        public void Run()
        {
            Random random = new();
            for (int i = 0; i < 5; i++)
            {
                foreach (Observer item in stores)
                {
                    int value = random.Next(0, 25);
                    item.Received(value);
                }
                Console.WriteLine();
            }
        }
    }
}
