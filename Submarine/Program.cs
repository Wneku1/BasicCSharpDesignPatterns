using System;

namespace SubmarineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // construct engine
            Engine myEngine = new NuclearEngine();
            myEngine.CheckSupplies();
            // construct navigation panel
            NavigationPanel myPanel = new();
            // and define the travel route
            myPanel.AddPort("Szczecin", 1);
            myPanel.AddPort("Rotterdam", 3);
            myPanel.AddPort("Antwerp", 1);
            // construct submarine
            Submarine mySubmarine = new(myEngine, myPanel);
            mySubmarine.Recruit(4, 2);
            double cost = mySubmarine.RefillStocks(300.0, 100.0);
            // let's go!
            mySubmarine.Travel();
            // final station reached - buy some more supplies
            cost += mySubmarine.RefillStocks(50.0, 50.0);
            // how are we doing?
            mySubmarine.CheckSupplies();
            Console.WriteLine("Total cost so far: " + cost);
        }
    }
}
