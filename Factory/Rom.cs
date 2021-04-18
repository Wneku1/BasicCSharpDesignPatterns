using System;

namespace Factory
{
    public class Rom
    {
        int Storage { get; set; }
        int Speed { get; set; }
        public Rom (int storage,int speed)
        {
            Storage = storage;
            Speed = speed;
        }

        public void ShowInfo()
        {
            Console.WriteLine("ROM: Storage: " + Storage + "\nSpeed: " + Speed + "\n");
        }
    }
}