using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Smartphone
    {
        public string Name { get; set; }
        public Cpu Cpu { get; set; }
        public Ram Ram { get; set; }
        public Rom Rom { get; set; }

        public Screen Screen {get; set;}
        public Smartphone(string name,Cpu cpu, Ram ram, Rom rom, Screen screen)
        {
            Name = name;
            Cpu = cpu;
            Ram = ram;
            Rom = rom;
            Screen = screen;
        }

    }
}
