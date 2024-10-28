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
            IPaymentProcessor processor1 = new PayPalPaymentProcessor();
            IPaymentProcessor processor2 = new StripePaymentAdapter(new StripePaymentService());
            IPaymentProcessor processor3 = new KaspiPaymentAdapter(new KaspiPaymentService());

            processor1.ProcessPayment(10500.0);
            processor2.ProcessPayment(1200.0);
            processor3.ProcessPayment(23000.0);
        }
    }
}
