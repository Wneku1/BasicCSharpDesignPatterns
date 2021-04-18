using System;
using System.Collections.Generic;

namespace CompositeDecorator
{
    class CarEquimpent 
    {
        private List<IAdditionalCarEquipment> allEquipment = new();
        public void Add(IAdditionalCarEquipment item)
        {
            allEquipment.Add(item);
        }

        public void ShowEquipment()
        {
            Console.WriteLine("Your car have: \n");
            foreach (IAdditionalCarEquipment equipment in allEquipment)
            {
               Console.WriteLine("- " + equipment.GetName() + " it cost: " + equipment.GetCost());
            }
        }
    }
}
