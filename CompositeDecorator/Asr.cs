
namespace CompositeDecorator
{
    class Asr : IAdditionalCarEquipment
    {
        public string GetName()
        {
            return "ASR ";
        }
        public int GetCost()
        {
            return 1100;
        }
    }
}
