
namespace CommandAdapter
{
    class Breaks
    {
        private readonly string brand;

        public Breaks(string brand)
        {
            this.brand = brand;
        }

        public override string ToString()
        {
            return brand;
        }
    }
}
