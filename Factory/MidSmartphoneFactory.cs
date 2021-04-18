using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class MidSmartphoneFactory : SmartphoneFactory
    {
        public override Smartphone Create()
        {
            return new Smartphone("Medium Smartphone: ",
                        new Cpu(2.20, "Qualcomm Snapdragon 730"),
                        new Ram(6, "DDR4"),
                        new Rom(64, 250),
                        new Screen("Amoled", 6.39)
                );
        }
    }
}
