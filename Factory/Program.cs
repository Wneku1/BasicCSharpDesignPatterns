using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var budgetFactory = new BudgetSmartphoneFactory();
            var midFactory = new MidSmartphoneFactory();
            var highFactory = new HighEndSmartphoneFactory();
            var budgetsmartphone = budgetFactory.Create();
            var midsmartphone = midFactory.Create();
            var highsmartphone = highFactory.Create();

            List<Smartphone> smartphone = new List<Smartphone>();
            smartphone.Add(budgetsmartphone);
            smartphone.Add(midsmartphone);
            smartphone.Add(highsmartphone);

            Console.WriteLine("My smartphone: \n");
            
            foreach (Smartphone phone in smartphone)
            {
                Console.WriteLine(phone.Name);
                phone.Cpu.Showinfo();
                phone.Ram.ShowInfo();
                phone.Rom.ShowInfo();
                phone.Screen.ShowInfo();
            }

        }
    }
}
