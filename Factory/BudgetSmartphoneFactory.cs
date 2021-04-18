using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class BudgetSmartphoneFactory : SmartphoneFactory    
    {
        public override Smartphone Create()
        {
            return new Smartphone("Budget Smartphone: ",
                                    new Cpu(1.6, "Samsung Exynos 7884"),
                                    new Ram(3, "DDR4"),
                                    new Rom(32, 200),
                                    new Screen("Amoled", 5.7)
                );
        }
    }
}
