using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Smartwatch : Device
    {
        public string Os { get; set; }
        public override void SpecialFeatures()
        {
            Console.WriteLine("Sleep tracker. Swimproof. Built-in compass\n");
        }

        public override string ToString()
        {
            return "This is a " + Name + "\n" +
                   "Processor:\t" + Processor + "\n" +
                   "Os:\t" + Os + "\n";
        }

        public override void ViewInformation()
        {
            Console.WriteLine(ToString());
        }
    }
}
