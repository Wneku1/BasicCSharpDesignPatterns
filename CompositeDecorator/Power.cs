
namespace CompositeDecorator
{
    class Power : IAdditionalCarEquipment
    {
        public string GetName()
        {
            return "More power than series ";
        }
        public int GetCost()
        {
            return 5400;
        }
    }
}
