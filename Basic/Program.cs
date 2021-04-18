using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor asus = new Monitor(1920,1080, 144,23,"LCD");
            Monitor lenovo = new Monitor(1920, 1080, 165, 24, "LED");
            Monitor samsung = new Monitor(1920, 1080, 60, 21.5, "LCD");
            Monitor lg = new Monitor(1920, 1080, 60, 22, "IPS");
            Laptop acer = new Laptop(asus, "Intel i5", 8, 1000);
            ComputerMouse logitech = new ComputerMouse("Laser", 0.2);

            List<Monitor> listMonitor = new List<Monitor>
            {
                asus,
                lenovo,
                samsung,
                lg,
            };

            foreach (Monitor monitor in listMonitor)
            {
                Console.WriteLine("Device: Monitor\tType: {0}\tSize: {1}", monitor.Type, monitor.Size);
            }

            Console.WriteLine("Device: Laptop\tProcessor: {0}\tRam: {1}", acer.Processor, acer.Ram);
            Console.WriteLine("Device: Mouse\tSensor: {0}\tWeight: {1}", logitech.Sensor, logitech.Weight);
        }
    }
}
