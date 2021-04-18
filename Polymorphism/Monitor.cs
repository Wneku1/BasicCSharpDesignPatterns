using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Monitor : Device
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int RefreshRate { get; set; }
        public string Type { get; set; }
        public double SizeScreen { get; set; }
        private double Pixel()
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }

        public double Ppi()
        {
            return Pixel() / SizeScreen;
        }

        public override void ViewInformation()
        {
            base.ViewInformation();
            Console.WriteLine(ToString());
        }

        public override void SpecialFeatures()
        {
            Console.WriteLine("Stunning colors better color accuracy, deeper blacks, superior brightness than others. An immersive visual experience.\n");
        }

        public override string ToString()
        {
            return "This is a " + Name + "\n" +
                "Type:\t" + Type + "\n" +
                "Width:\t" + Width + "\n" +
                "Height:\t" + Height + "\n" +
                "SizeScreen:\t" + SizeScreen + "\n" +
                "RefreshRate:\t" + RefreshRate + "\n";
        }
    }
}
