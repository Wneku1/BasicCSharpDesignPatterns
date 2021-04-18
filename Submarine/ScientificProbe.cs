using System;

namespace SubmarineProject
{
    class ScientificProbe : ITool
    {
        public void Conserve()
        {
            Console.WriteLine("Conserve completed!");
        }
        public void GatherData()
        {
            Console.WriteLine("GatherData");
        }
    }
}
