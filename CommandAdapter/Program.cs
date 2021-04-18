using System;
using System.Collections.Generic;

namespace CommandAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Breaks brembo = new("Brembo");
            Filter OilFilter = new("Bosh", "oil filter");
            RepairBreaks repairBreaks = new(brembo, 500);
            ChangeFilter changeOilFilter = new(OilFilter, 100);
            AirConditioning aC = new(200);
            Mechanic janusz = new();

            janusz.Add(repairBreaks);
            janusz.Add(changeOilFilter);
            janusz.Add(aC);
            janusz.DoIt();

            Console.WriteLine("\n\n");

            Adapter Boss = new();
            Boss.DoIt(new List<IRepair>() { repairBreaks, changeOilFilter });
        }
    };
}

