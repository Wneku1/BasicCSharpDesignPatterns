using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Laptop
    {

        public Monitor Screen { get; set; }

        public string Processor { get; set; }
        public int Ram { get; set; }
        public int HardDrive { get; set; }

        public double StorageInMb
        {
            get
            {
                return HardDrive * 1024;
            }
        }

        public Laptop(Monitor screen,string processor,int ram, int hardDrive)
        {
            this.Screen = screen;
            this.Processor = processor;
            this.Ram = ram;
            this.HardDrive = hardDrive;
        }
    }
}
