using System;

namespace Factory
{
    public class Ram
    {
        int Size { get; set; }
        string Type { get; set; }
        public Ram(int size, string type)
        {
            Size = size;
            Type = type;
        }

        public  void ShowInfo()
        {
            Console.WriteLine("RAM: Size: " + Size + "\nType: " + Type + "\n");
        }
    }
}