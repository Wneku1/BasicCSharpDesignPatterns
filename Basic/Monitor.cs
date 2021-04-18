using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Monitor
    {
        private int refreshRate;
        private double size;
        private string type;

        public int Width { get; set; }
        public int Height { get; set; }

        public int RefreshRate 
        {
            get { return refreshRate; }
            set
            {
                if (value > 0)
                    refreshRate = value;
            }
        }

        public double Size
        {
            get { return size; }
            set
            {
                if (value > 0) size = value;
            }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private double Pixel()
        {
            return Math.Sqrt(Width*Width + Height* Height);
        }

        public double Ppi()
        {
            return Pixel()/Size;
        }

        public Monitor(int width, int height, int refreshRate, double size, string type)
        {
            this.Width = width;
            this.Height = height;
            this.RefreshRate = refreshRate;
            this.Size = size;
            this.Type = type;
        }
    }
}
