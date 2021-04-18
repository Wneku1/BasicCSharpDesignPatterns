using System;

namespace CompositeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEquimpent car = new();
            AirConditioning ac = new();
            Esp esp = new();
            Power power = new();
            Asr asr = new();
            SportyLook sportylook = new();
            car.Add(esp);
            car.Add(ac);
            car.Add(power);
            car.Add(asr);
            car.Add(sportylook);
            car.ShowEquipment();

            Console.WriteLine("\n\n\n");

            IAdditionalCarEquipment items1 = new Esp();
            items1 = new SportyLookDecorator(items1);
            IAdditionalCarEquipment items2 = new Power();
            items2 = new AsrDecorator(items2);
            IAdditionalCarEquipment items3 = new AirConditioning();
            items3 = new PowerDecorator(items3);

            Console.WriteLine(items1.GetName() + items1.GetCost());
            Console.WriteLine(items2.GetName() + items2.GetCost());
            Console.WriteLine(items3.GetName() + items3.GetCost());
        }
    }
}
