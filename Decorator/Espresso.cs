using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Espresso : IBeverage
    {
        public double GetCost()
        {
            return 300;
        }
        public string GetDescription()
        {
            return "Espresso";
        }
    }
}
