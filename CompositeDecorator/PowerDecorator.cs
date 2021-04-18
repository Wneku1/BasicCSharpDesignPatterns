
namespace CompositeDecorator
{
    class PowerDecorator : CarMaker
    {
        public PowerDecorator(IAdditionalCarEquipment equipment) : base(equipment) { }
        public override string GetName()
        {
            return base.GetName() + "and more power than series it cost ";
        }

        public override int GetCost()
        {
            return base.GetCost() + 5400;
        }
    }
}
