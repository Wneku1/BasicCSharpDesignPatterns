using System;
namespace Factory
{
    public class Cpu
    {
        double Frequnecy { get; set; }
        string Name { get; set; }
        public Cpu(double frequency,string name) 
        { 
            Frequnecy = frequency;
            Name = name;
        }

        public void Showinfo()
        {
            Console.WriteLine("CPU: Frequency: " + Frequnecy + "\nName: " + Name + "\n");
        }

    }
}