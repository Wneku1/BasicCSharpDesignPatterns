using System;

namespace SubmarineProject
{
    abstract class Human
    {
        private readonly Random random = new(Seed: (int)DateTime.Now.Ticks);
        static public double MedianSalary = 5000;
        double Salary { get;}
        public int Breathe()
        {
            return random.Next(2000, 3000);
        }
        public double Eat()
        {
            return random.NextDouble() + 5;
        }
        public Human(double s) => Salary = s;
    }
}
