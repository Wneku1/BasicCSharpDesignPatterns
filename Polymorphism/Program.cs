using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor mon = new()
            {
                Name = "Monitor",
                Width = 1920,
                Height = 1080,
                Type = "Amoled",
                RefreshRate = 30,
                SizeScreen = 21.5,
                Rom = 2
            };

            Computer pc = new()
            {
                Frequency = 2.4,
                Graphic = "Nvidia GeForce gtx 2080",
                Name = "Computer",
                Processor = "Intel i5",
                Ram = 8,
                Rom = 500
            };

            Smartwatch sm = new()
            {
                Name = "Smartwatch",
                Os = "Andorid Wear OS",
                Processor = "Samsung Exynos 9110",
                Rom = 16,
                Frequency = 1.5
            };

            var electornics = new List<Device> { mon, pc, sm };

            foreach (var element in electornics)
            {
                Console.WriteLine(element.ToString());
                Console.WriteLine("Storage in Mb:" + element.StorageInMb() + "\n");
            }
        }
    }
}
