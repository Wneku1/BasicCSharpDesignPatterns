using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class ComputerMouse
    { 
        public string Sensor { get; set; }

        public double Weight { get; set; }

        public ComputerMouse(string sensor,double weight)
        {
            this.Sensor = sensor;
            this.Weight = weight;
        }
    }
}
