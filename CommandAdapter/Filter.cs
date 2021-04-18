
namespace CommandAdapter
{
    class Filter
    {
        private readonly string brand;
        private readonly string type;

        public Filter(string brand,string type)
        {
            this.brand = brand;
            this.type = type;
        }

        public override string ToString()
        {
            return brand + " " + type;
        }
    }
}
