using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class HighEndSmartphoneFactory : SmartphoneFactory
    {
        public override Smartphone Create()
        {
            return new Smartphone("High end Smartphone: ",
                        new Cpu(2.70, "Exynos 990"),
                        new Ram(8, "DDR5"),
                        new Rom(256, 400),
                        new Screen("Dynamic Amoled", 6.2)
                );
        }
    }
}
