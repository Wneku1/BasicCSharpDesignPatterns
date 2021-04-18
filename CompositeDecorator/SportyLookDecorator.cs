
namespace CompositeDecorator
{
    class SportyLookDecorator : CarMaker
    {
        public SportyLookDecorator(IAdditionalCarEquipment equipment) : base(equipment) { }
        public override string GetName()
        {
            return base.GetName() + "and more sporty look it cost ";
        }

        public override int GetCost()
        {
            return base.GetCost() + 9600;
        }
    }
}
