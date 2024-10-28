using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class StripePaymentAdapter : IPaymentProcessor
    {
        private StripePaymentService stripePaymentService;
        public StripePaymentAdapter(StripePaymentService stripePaymentService)
        {
            this.stripePaymentService = stripePaymentService;
        }
        public void ProcessPayment(double amount)
        {
            stripePaymentService.MakeTransaction(amount);
        }
    }
}
