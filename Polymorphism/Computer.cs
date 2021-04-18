using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Computer : Device
    {
        public int Ram { get; set; }
        public string Graphic { get; set; }
        public override void SpecialFeatures()
        {
            Console.WriteLine("Window side Case Panel and custom ARGB case Lighting\n");
        }

        public override string ToString() 
        {
            return "This is a " + Name + "\n" +
                "Processor:\t" + Processor + "\n" +
                "Frequency:\t" + Frequency + "\n" + 
                "Ram:\t" + Ram + "\n" +
                "Rom:\t" + Rom + "\n" +
                "Storage in Mb:\t" +base.StorageInMb() + "\n" +
                "Graphic:\t" + Graphic + "\n";
        }
    }
}
