
namespace CompositeDecorator
{
    class Esp : IAdditionalCarEquipment
    {
        public string GetName()
        {
            return "ESP ";
        }
        public int GetCost()
        {
            return 1800;
        }
    }
}
