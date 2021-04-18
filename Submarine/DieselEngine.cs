
namespace SubmarineProject
{
    class DieselEngine : Engine
    {
        override public double Refill(double amount)
        {
            fuel.Amount += amount;
            return amount * 10;
        }
        override public void OneDayOfTravel()
        {
            fuel.Amount -= 15;
        }
    }
}
