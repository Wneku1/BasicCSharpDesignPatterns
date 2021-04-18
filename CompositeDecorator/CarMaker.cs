
namespace CompositeDecorator
{
    abstract class CarMaker : IAdditionalCarEquipment
    {
        protected IAdditionalCarEquipment equipment;
        public CarMaker(IAdditionalCarEquipment equipment) => this.equipment = equipment;
        public virtual string GetName()
        {
            return equipment.GetName();
        }

        public virtual int GetCost()
        {
            return equipment.GetCost();
        }
    }
}
