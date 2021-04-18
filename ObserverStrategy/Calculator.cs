
namespace ObserverStrategy
{
    class Calculator
    {
        CalculatorMode mode;
        public void SetMode(CalculatorMode mode)
        {
            this.mode = mode;
        }

        public float calculate(float a, float b)
        {
            return mode.calculate(a , b);
        }
    }
}
