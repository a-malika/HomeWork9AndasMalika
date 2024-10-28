using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Latte : IBeverage
    {
        public double GetCost()
        {
            return 600;
        }
        public string GetDescription()
        {
            return "Latte";
        }
    }
}
