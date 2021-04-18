using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    class NavigationPanel : ITool
    {
        private int currentNumber;
        private List<Destination> ports;
        private List<int> travelDays;

        public int TotalNumber { get; set; }
        public void AddPort(string name, int days)
        {
            Destination temp = new Destination(name);
            ports.Add(temp);
            travelDays.Add(days);
            TotalNumber++;
        }
        public void Arrived()
        {
            currentNumber++;
        }
        public void Conserve()
        {
            Console.WriteLine("Conservation of navigation panel completed!");
        }
        public int DaysToNextDestination()
        {
            return travelDays[currentNumber];
        }
        public NavigationPanel()
        {
            ports = new List<Destination>();
            travelDays = new List<int>();
        }
        public string NextDestination() 
        {
            return  ports[currentNumber].Name;

        }
    }
}
