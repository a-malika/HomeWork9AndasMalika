using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBeverage beverage1 = new Latte();
            beverage1 = new CinnamonDecorator(beverage1);
            beverage1 = new WhippedCreamDecorator(beverage1);
            Console.WriteLine($"First beverage - {beverage1.GetDescription()}.");
            Console.WriteLine($"Cost: {beverage1.GetCost()}.");
            
            IBeverage beverage2 = new Tea();
            beverage2 = new MilkDecorator(beverage2);
            beverage2 = new SugarDecorator(beverage2);
            Console.WriteLine($"Second beverage - {beverage2.GetDescription()}.");
            Console.WriteLine($"Cost: {beverage2.GetCost()}.");

            IBeverage beverage3 = new Mocha();
            beverage3 = new SugarDecorator(beverage3);
            beverage3 = new MilkDecorator(beverage3);
            beverage3 = new CinnamonDecorator(beverage3);
            beverage3 = new WhippedCreamDecorator(beverage3);
            Console.WriteLine($"Third beverage - {beverage3.GetDescription()}.");
            Console.WriteLine($"Cost: {beverage3.GetCost()}.");
        }
    }
}
