
namespace ObserverStrategy
{
    abstract class CalculatorMode
    {
        abstract public float calculate(float a , float b);
    }

    class Adding : CalculatorMode
    {
        public override float calculate(float a, float b) 
        {
            return a + b;
        }
    }

    class Subtraction : CalculatorMode
    {
        public override float calculate(float a, float b)
        {
            return a - b ;
        }
    }

    class Multiplication : CalculatorMode
    {
        public override float calculate(float a, float b)
        {
            return a*b;
        }
    }

    class Division : CalculatorMode
    {
        public override float calculate(float a, float b)
        {
            return a /b;
        }
    }
}
