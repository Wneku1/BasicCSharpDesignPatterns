
namespace CompositeDecorator
{
    class SportyLook : IAdditionalCarEquipment
    {
        public string GetName()
        {
            return "More sporty look ";
        }
        public int GetCost()
        {
            return 9600;
        }
    }
}
