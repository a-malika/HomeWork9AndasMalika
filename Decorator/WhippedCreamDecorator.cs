using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class WhippedCreamDecorator : BeverageDecorator
    {
        public WhippedCreamDecorator(IBeverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return base.GetCost() + 45.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Whipped Cream";
        }
    }
}
