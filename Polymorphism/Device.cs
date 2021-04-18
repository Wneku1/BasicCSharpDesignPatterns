using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    abstract class Device : IFrequency, IRom
    {
        public string Name { get; set; }
        public uint Rom { get; set; }
        public string Processor { get; set; }
        public double Frequency { get; set; }

        abstract public void SpecialFeatures();

        virtual public void ViewInformation()
        {
            Console.WriteLine("This is a device\n");
            SpecialFeatures();
        }

        public void ChangeFrequency()
        {

            Console.WriteLine("Input Frequency:\n");
            Frequency = Convert.ToDouble(Console.ReadLine());
        }

        public void ChangeRom()
        {

            Console.WriteLine("Input Rom:\n");
            Rom = Convert.ToUInt16(Console.ReadLine());
        }

        public uint StorageInMb()
        {
            return Rom * 1024;
        }
    }
}
