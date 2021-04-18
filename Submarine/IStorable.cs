using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineProject
{
    interface IStorable
    {
        double Amount { get; set; }
        void HowMuchLeft();
    }
}
