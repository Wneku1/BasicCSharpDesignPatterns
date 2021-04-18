using System;

namespace Factory
{
    public class Screen
    {
        string Type { get; set; }
        double Size { get; set; }

        public Screen(string type, double size)
        {
            Type = type;
            Size = size;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Screen: Type: " + Type + "\nSize: " + Size + "\n");
        }
    }
}