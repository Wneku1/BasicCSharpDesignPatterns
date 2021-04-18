using System;

namespace ObserverStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer rossman = new("Rossman", 4, 80);
            Observer kaufland = new("Kaufland", 10, 400);
            Observer groceryStore = new("Grocery Store", 2, 50);

            ObserveStore myStores = new();
            myStores.Subscribed(rossman);
            myStores.Subscribed(kaufland);
            myStores.Subscribed(groceryStore);
            myStores.Run();

            Console.WriteLine();

            Calculator calculator = new();
            calculator.SetMode(new Adding());
            Console.WriteLine("The resuult is: " + calculator.calculate(2, 2) + "\n");
            calculator.SetMode(new Multiplication());
            Console.WriteLine("The resuult is: " + calculator.calculate(4, 4) + "\n");
        }
    }
}
