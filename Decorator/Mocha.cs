using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Mocha : IBeverage
    {
        public double GetCost()
        {
            return 700;
        }
        public string GetDescription()
        {
            return "Mocha";
        }
    }
}
