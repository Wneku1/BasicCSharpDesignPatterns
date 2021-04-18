
namespace CompositeDecorator
{
    class AsrDecorator : CarMaker
    {
        public AsrDecorator(IAdditionalCarEquipment equipment) : base(equipment) { }
        public override string GetName()
        {
            return base.GetName() + "and ASR it cost ";
        }

        public override int GetCost()
        {
            return base.GetCost() + 1100;
        }
    }
}
