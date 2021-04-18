
namespace SubmarineProject
{
    abstract class Engine
    {
        protected Fuel fuel;
        virtual public void CheckSupplies()
        {
            fuel.HowMuchLeft();
        }
        public Engine() => fuel = new Fuel
        {
            Amount = 100
        };
        abstract public double Refill(double amount);
        abstract public void OneDayOfTravel();
    }
}
