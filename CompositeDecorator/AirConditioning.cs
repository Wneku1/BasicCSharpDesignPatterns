
namespace CompositeDecorator
{
    class AirConditioning : IAdditionalCarEquipment
    {
        public string GetName()
        {
            return "Air Conditioning ";
        }

        public int GetCost()
        {
            return 3000;
        }
    }
}
