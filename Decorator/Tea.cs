using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Tea : IBeverage
    {
        public double GetCost()
        {
            return 200;
        }
        public string GetDescription()
        {
            return "Tea";
        }
    }
}
